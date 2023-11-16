using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.Duoc
{
    [Serializable()]
    public class ThongBao_KhoaList : BusinessListBase<ThongBao_KhoaList, ThongBao_Khoa>
    {
        #region Factory Methods
        public static ThongBao_KhoaList GetAllThongBao_Khoa( string makhoa, String dk,Boolean qadmin)
        {
            return DataPortal.Fetch<ThongBao_KhoaList>(new Criteria( makhoa,dk,qadmin));
        }


       

        public ThongBao_Khoa NewTo()
        {
            ThongBao_Khoa obj = ThongBao_Khoa.NewThongBao_Khoa();
            return obj;
        }
        public void   NewTo(ThongBao_Khoa _ThongBao_Khoa)
        {
           
            try
            {
                if (!Contains(_ThongBao_Khoa.Makhoa,_ThongBao_Khoa .STT ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_ThongBao_Khoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_ThongBao_Khoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _ThongBao_Khoa.OrderNumber = ++_count;
                        _ThongBao_Khoa.STT = ++_count;
                        this.Add(_ThongBao_Khoa);
                    }
                    else
                    {
                        _ThongBao_Khoa.OrderNumber = 1;
                        _ThongBao_Khoa.STT = 1;
                        this.Add(_ThongBao_Khoa);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(ThongBao_Khoa _ThongBao_Khoa)
        {

            _ThongBao_Khoa.OrderNumber = this.Items[this.IndexOf(_ThongBao_Khoa)].OrderNumber;
            this.Items[this.IndexOf(_ThongBao_Khoa)] = _ThongBao_Khoa;
        }
        public void RemoveTo(ThongBao_Khoa _ThongBao_Khoa)
        {
            this.Items.Remove(_ThongBao_Khoa);

        }
        public ThongBao_Khoa  AssignTo(ThongBao_Khoa  _ThongBao_Khoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_ThongBao_Khoa.Makhoa, _ThongBao_Khoa.STT))
                {
                    if (this.Items.Count > 0)
                    {
                        //_ThongBao_Khoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_ThongBao_Khoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _ThongBao_Khoa.OrderNumber = ++_count;
                        _ThongBao_Khoa.STT = ++_count;
                        this.Add(_ThongBao_Khoa);
                    }
                    else
                    {
                        _ThongBao_Khoa.OrderNumber = 1;
                        _ThongBao_Khoa.STT = 1;
                        this.Add(_ThongBao_Khoa);

                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _ThongBao_Khoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (ThongBao_Khoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string makhoa, decimal stt)
        {
            foreach (ThongBao_Khoa obj in this)
                if ((obj.STT == stt) && (obj.Makhoa == makhoa) )
                    return true;
            return false;
        }

        public ThongBao_Khoa GetThongBao_KhoaById(string makhoa, decimal stt)
        {
            foreach (ThongBao_Khoa item in this)
                if ( (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, decimal stt)
        {
            foreach (ThongBao_Khoa  item in this)
            {
                if ((item.STT == stt ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            ThongBao_Khoa item = ThongBao_Khoa.NewThongBao_Khoa();
            Add(item);
            return item;
        }

       

        private ThongBao_KhoaList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion


        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private String _DK;
            private Boolean _qadmin;
            private String _MaKhoa;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public Boolean  qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
          
            public Criteria( String mMakhoa, String dk,Boolean qadmin)
            {
               
                _DK  = dk  ;
                _MaKhoa = mMakhoa;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongBao_Khoa( criteria.MaKhoa,criteria.DK ,criteria .qadmin     )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(ThongBao_Khoa.GetThongBao_Khoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
      
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (ThongBao_Khoa item in DeletedList)
            {
                item.DeleteSelf(item);
            }

            DeletedList.Clear();

            foreach (ThongBao_Khoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override ThongBao_KhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save ThongBao_KhoaList");
            foreach (ThongBao_Khoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //ThongBao_KhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
