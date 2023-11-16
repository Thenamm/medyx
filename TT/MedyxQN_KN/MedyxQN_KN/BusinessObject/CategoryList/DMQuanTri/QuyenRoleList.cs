using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;
using System.Transactions;
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class QuyenRoleList : BusinessListBase<QuyenRoleList, QuyenRole>
    {
         
      #region Business Methods
       

        #region State Fields
        private int i =1;
        #endregion
        public QuyenRole this[string MaMN]
        {
            get
            {
                foreach (QuyenRole obj in this)
                    if (obj.MaMN.Equals(MaMN))
                        return obj;
                return null;
            }
        }

     
        public QuyenRole NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              QuyenRole obj = QuyenRole.NewQuyenRole();
              return obj;
               
        }
        public void NewTo(QuyenRole _QuyenRole) //moi sua
        {
            if (!Contains(_QuyenRole.MaMN))
            {
                QuyenRole obj = QuyenRole.NewQuyenRole();
                obj.MaMN = _QuyenRole.MaMN;
                obj.Tenmn = _QuyenRole.Tenmn;
                obj.QuyenMN = _QuyenRole.QuyenMN;
                obj.MaRole = _QuyenRole.MaRole;
                
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    obj.OrderNumber  = ++_count;
                    this.Add(obj);
                }
                else
                {
                    obj.OrderNumber = 1;
                    this.Add(obj);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
      
        public QuyenRole AssignTo(QuyenRole _QuyenRole)//add mot hang QuyenRole
        {
            
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items[this.Count - 1].OrderNumber + 1;
               
                _QuyenRole.OrderNumber = ++_count;

                this.Add(_QuyenRole);
            }
            else
            {
                _QuyenRole.OrderNumber = 1;
               
                this.Add(_QuyenRole);
            }
            //Add(_QuyenRole);
            return _QuyenRole;
        }
        protected override object AddNewCore()
        {
            QuyenRole item = QuyenRole.NewQuyenRole();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(int stt) //xoa 1 QuyenRole
        //{
           
        //    //foreach (QuyenRole obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //QuyenRole obj;
        //    for(int i = 0;i < this.Items.Count ;i ++ )
        //    {
        //       // obj = this.Items[i];
        //        if (this.Items[i].OrderNumber  == stt)
        //        {
        //            this.Items.RemoveAt(i);
        //            break;

        //        }
        //    }
        //}

        public void RemoveTo(string mamn)
        {
            foreach (QuyenRole obj in this)
            {
                if (obj.MaMN.Equals(mamn))
                {
                    //Remove(obj);
                    if(obj.IsNew == true )
                    this.Items.Remove(obj);
                    else
                    Remove(obj);
                    //this.Remov(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaMN)
        {
            foreach (QuyenRole obj in this)
                if (obj.MaMN == MaMN )
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaMN)
        {
            foreach (QuyenRole obj in DeletedList)
                if (obj.MaMN == MaMN)
                    return true;
            return false;
        }
        public void UpdatedTo(QuyenRole _QuyenRole)
        {

            _QuyenRole.OrderNumber = this.Items[this.IndexOf(_QuyenRole)].OrderNumber;
            this.Items[this.IndexOf(_QuyenRole)] = _QuyenRole;
        }
        public QuyenRole GetTo(int STT) //
        {
            foreach (QuyenRole obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static QuyenRoleList NewQuyenRoleList()
        {
            return new QuyenRoleList();
        }

        internal static QuyenRoleList GetQuyenRoleList(SafeDataReader dr)
        {
            return new QuyenRoleList(dr);
        }
        public static QuyenRoleList GetQuyenRoleList()
        {
            return DataPortal.Fetch<QuyenRoleList>(new Criteria());
        }
        private QuyenRoleList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private QuyenRoleList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access
        private class Criteria
        {
           
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
          
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllQuyenMenuRole()))
            {
               // IsReadOnly = false;
                //while (dr.Read())
                //{
                     Fetch(dr);
                //}
            }
        }

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            //int i;
            while (dr.Read())
            {
                this.Add(QuyenRole.GetQuyenRole(dr, i));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMRole packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (QuyenRole item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (QuyenRole item in this)
            {
                if (item.IsNew)
             
                    item.Insert(packet);
               
               
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
      
        #endregion
   
    }
}
