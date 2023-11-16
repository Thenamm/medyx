using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVaiTro_PhuCapList : BusinessListBase<DMVaiTro_PhuCapList, DMVaiTro_PhuCap>
    {
        #region Factory Methods
        ////public static DMVaiTro_PhuCapList GetAllDMVaiTro_PhuCap(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMVaiTro_PhuCapList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        public static DMVaiTro_PhuCapList FindDMVaiTro_PhuCap(Boolean Qadmin, string MaChungLoai, string MaLH, string DK)
        {
            return DataPortal.Fetch<DMVaiTro_PhuCapList>(new CriteriaOther(Qadmin , MaChungLoai ,MaLH, DK ));
        }
        //public static DMVaiTro_PhuCapList FindDMDichVuByMa(string MaChungLoai, string MaLH, string  DK )
        //{
        //    return DataPortal.Fetch<DMVaiTro_PhuCapList>(new CriteriaOther(1, MaChungLoai, MaLH , DK ));
        //}
        public DMVaiTro_PhuCap NewTo()
        {
            DMVaiTro_PhuCap obj = DMVaiTro_PhuCap.NewDMVaiTro_PhuCap();
            return obj;
        }
        public void   NewTo(DMVaiTro_PhuCap _DMVaiTro_PhuCap)
        {
           
            try
            {
                if (!Contains(_DMVaiTro_PhuCap.MaVaiTro  , _DMVaiTro_PhuCap.MaChungLoai ,_DMVaiTro_PhuCap.MaLH   ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVaiTro_PhuCap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
                        //this.Add(_DMVaiTro_PhuCap);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVaiTro_PhuCap.OrderNumber = ++_count;
                        this.Add(_DMVaiTro_PhuCap);
                    }
                    else
                    {
                        _DMVaiTro_PhuCap.OrderNumber = 1;
                        this.Add(_DMVaiTro_PhuCap);

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
        public void UpdatedTo(DMVaiTro_PhuCap _DMVaiTro_PhuCap)
        {

            _DMVaiTro_PhuCap.OrderNumber  = this.Items[this.IndexOf(_DMVaiTro_PhuCap)].OrderNumber ;
            this.Items[this.IndexOf(_DMVaiTro_PhuCap)] = _DMVaiTro_PhuCap;
        }
        public void RemoveTo(DMVaiTro_PhuCap _DMVaiTro_PhuCap)
        {
            this.Items.Remove(_DMVaiTro_PhuCap);

        }
        public DMVaiTro_PhuCap  AssignTo(DMVaiTro_PhuCap  _DMVaiTro_PhuCap)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVaiTro_PhuCap.OrderNumber  = ++_count;
                this.Add(_DMVaiTro_PhuCap);
            }
            else
            {
                _DMVaiTro_PhuCap.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVaiTro_PhuCap);
            }
            //Add(_PhieuNhap_C);
            return _DMVaiTro_PhuCap;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMVaiTro_PhuCap item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(decimal  MaVaiTro, string MaChungLoai,string   MaLH)
        {
            foreach (DMVaiTro_PhuCap obj in this)
                if ((obj.MaVaiTro  == MaVaiTro ) && (obj.MaChungLoai  == MaChungLoai )&&(obj.MaLH  ==MaLH   ) )
                    return true;
            return false;
        }

        public DMVaiTro_PhuCap GetDMVaiTro_PhuCapById( decimal OrderNumber)
        {
            foreach (DMVaiTro_PhuCap item in this)
                if ( (item.OrderNumber == OrderNumber))
                    return item;
            return null;
        }
        public void Remove(decimal MaVaiTro, string MaChungLoai ,string MaLH)
        {
            foreach (DMVaiTro_PhuCap  item in this)
            {
                if ((item.MaVaiTro == MaVaiTro   ) && (item.MaChungLoai  == MaChungLoai )&&(item .MaLH==MaLH   ))
                {
                    Remove(item);
                    break;
                }
            }
        }
        private class CriteriaOther
        { 
        private Boolean _qadmin = false ;
            public bool Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
        
        private String _maChungLoai;
        public String MaChungLoai
        {
            get
            {
                return _maChungLoai;
            }
        }
        private String _maLH;
        public String MaLH
        {
            get
            {
                return _maLH ;
            }
        }
        private String _dK;
        public String Dk
        {
            get
            {
                return _dK;
            }
        }
        public CriteriaOther (Boolean Qadmin, String MaChungLoai, String MaLH, String DK )
        {
            _qadmin = Qadmin;
           _maChungLoai = MaChungLoai;
            _maLH = MaLH ;
            _dK = DK ;
        
        }
    }
        protected override object AddNewCore()
        {
            DMVaiTro_PhuCap item = DMVaiTro_PhuCap.NewDMVaiTro_PhuCap();
            Add(item);
            return item;
        }

        public static DMVaiTro_PhuCapList GetAllDMVaiTro_PhuCap(Boolean Qadmin)
        {
            return DataPortal.Fetch<DMVaiTro_PhuCapList>(new Criteria(Qadmin ));
        }

        private DMVaiTro_PhuCapList()
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
           
            private Boolean _qadmin = false ;
           
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Boolean Qadmin)
            {
                _qadmin = Qadmin;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVaiTro_PhuCap(criteria.qadmin)))
            {
                int i;
                i = 1;
                while (dr.Read())
                {
                    this.Add(DMVaiTro_PhuCap.GetDMVaiTro_PhuCap(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteriaOther)
        {
            this.RaiseListChangedEvents = false;
            int i;
            i = 1;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMVaiTro_PhuCap(criteriaOther.Qadmin, criteriaOther.MaChungLoai ,criteriaOther.MaLH ,criteriaOther.Dk)))
            {
                while (dr.Read())
                {
                    this.Add(DMVaiTro_PhuCap.GetDMVaiTro_PhuCap(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVaiTro_PhuCap item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVaiTro_PhuCap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVaiTro_PhuCapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVaiTro_PhuCapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
