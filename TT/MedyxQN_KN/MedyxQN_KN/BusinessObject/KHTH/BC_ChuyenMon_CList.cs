using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_ChuyenMon_CList : BusinessListBase<BC_ChuyenMon_CList, BC_ChuyenMon_C>
    {
         #region Business Methods
        public BC_ChuyenMon_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public BC_ChuyenMon_C this[string ma]
        {
            get
            {
                foreach (BC_ChuyenMon_C obj in this)
                    if  (obj.Ma.Equals(ma))
                        return obj;
                return null;
            }
        }

        public void NewTo(string Makhoa, SmartDate thang, string ma)
        {
            if (!Contains(Makhoa,thang,ma))
            {
                BC_ChuyenMon_C obj = BC_ChuyenMon_C.NewBC_ChuyenMon_C(Makhoa,thang,ma);
                int _count = 0;
                _count = (int)this.Items.Count;
                obj.OrderNumber  = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public BC_ChuyenMon_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              BC_ChuyenMon_C obj = BC_ChuyenMon_C.NewBC_ChuyenMon_C();
              return obj;
               
        }
        public void NewTo(BC_ChuyenMon_C _BC_ChuyenMon_C) //moi sua
        {
            if (!Contains(_BC_ChuyenMon_C.MaKhoa,SmartDate.Parse ( _BC_ChuyenMon_C.Thang),_BC_ChuyenMon_C.Ma))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = (int)this.Items.Count;
                    _BC_ChuyenMon_C.OrderNumber = ++_count;
                    this.Add(_BC_ChuyenMon_C);
                }
                else
                {
                    _BC_ChuyenMon_C.OrderNumber = 1;
                    this.Add(_BC_ChuyenMon_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        
     
        protected override object AddNewCore()
        {
            BC_ChuyenMon_C item = BC_ChuyenMon_C.NewBC_ChuyenMon_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

      
        public void RemoveTo(BC_ChuyenMon_C obj) //xoa 1 BC_ChuyenMon_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string Makhoa,SmartDate thang,string ma)
        {
            foreach (BC_ChuyenMon_C obj in this)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse (obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }



        public bool ContainsDeleted(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_ChuyenMon_C obj in DeletedList)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }
        public void UpdatedTo(BC_ChuyenMon_C _BC_ChuyenMon_C)
        {

            _BC_ChuyenMon_C.OrderNumber = this.Items[this.IndexOf(_BC_ChuyenMon_C)].OrderNumber;
            this.Items[this.IndexOf(_BC_ChuyenMon_C)] = _BC_ChuyenMon_C;
        }
        public BC_ChuyenMon_C GetTo(Int32 OrderNumber) //
        {
            foreach (BC_ChuyenMon_C obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static BC_ChuyenMon_CList NewBC_ChuyenMon_CList()
        {
            return new BC_ChuyenMon_CList();
        }

        internal static BC_ChuyenMon_CList GetBC_ChuyenMon_CList(SafeDataReader dr)
        {
            return new BC_ChuyenMon_CList(dr);
        }

        private BC_ChuyenMon_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BC_ChuyenMon_CList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            int i = 0;
            while (dr.Read())
            {
                i++;
                this.Add(BC_ChuyenMon_C.GetBC_ChuyenMon_C(dr, i));/////////
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(BC_ChuyenMon packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            //foreach (BC_ChuyenMon_C item in DeletedList)
            //    item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (BC_ChuyenMon_C item in this)
            {
                if ((item.IsNew) )   
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
