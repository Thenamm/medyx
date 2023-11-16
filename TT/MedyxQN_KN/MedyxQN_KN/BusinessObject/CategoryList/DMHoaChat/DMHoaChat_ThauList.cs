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
    public class DMHoaChat_ThauList : BusinessListBase<DMHoaChat_ThauList, DMHoaChat_Thau>
    {
        #region Factory Methods
        public static DMHoaChat_ThauList GetAllDMHoaChat_Thau(string mancc,string namthau, String dk,byte loai)
        {
            return DataPortal.Fetch<DMHoaChat_ThauList>(new Criteria(true ,mancc, namthau,dk ,loai));
        }
        public static DMHoaChat_ThauList GetDMHoaChat_Thau_TOTALBYMAHC(Decimal NgayPnhap,string mancc, string maHC)
        {
            return DataPortal.Fetch<DMHoaChat_ThauList>(new CriteriaOther(NgayPnhap ,mancc,maHC ));
        }
        // tim theo dieu kien ten
        //public static DMHoaChat_ThauList FindDMHoaChat_ThauByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMHoaChat_ThauList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMHoaChat_ThauList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMHoaChat_ThauList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMHoaChat_Thau NewTo()
        {
            DMHoaChat_Thau obj = DMHoaChat_Thau.NewDMHoaChat_Thau();
            return obj;
        }
        public void NewTo(DMHoaChat_Thau _DMHoaChat_Thau)
        {

            try
            {
                if (!Contains(_DMHoaChat_Thau.MaHC, _DMHoaChat_Thau.MaNCC, _DMHoaChat_Thau.NamThau))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMHoaChat_Thau.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMHoaChat_Thau);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMHoaChat_Thau.OrderNumber = ++_count;
                        this.Add(_DMHoaChat_Thau);
                    }
                    else
                    {
                        _DMHoaChat_Thau.OrderNumber = 1;
                        this.Add(_DMHoaChat_Thau);

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
        public void UpdatedTo(DMHoaChat_Thau _DMHoaChat_Thau)
        {

            _DMHoaChat_Thau.MaHC = this.Items[this.IndexOf(_DMHoaChat_Thau)].MaHC;
            this.Items[this.IndexOf(_DMHoaChat_Thau)] = _DMHoaChat_Thau;
        }
        public void RemoveTo(DMHoaChat_Thau _DMHoaChat_Thau)
        {
           
            if (_DMHoaChat_Thau.IsNew == true)

                this.Items.Remove(_DMHoaChat_Thau);
            else
                Remove(_DMHoaChat_Thau);

        }
        public DMHoaChat_Thau AssignTo(DMHoaChat_Thau _DMHoaChat_Thau)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMHoaChat_Thau.OrderNumber = ++_count;
                this.Add(_DMHoaChat_Thau);
            }
            else
            {
                _DMHoaChat_Thau.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMHoaChat_Thau);
            }
            //Add(_PhieuNhap_C);
            return _DMHoaChat_Thau;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMHoaChat_Thau item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaHC, string MaNCC, string NamThau)
        {
            foreach (DMHoaChat_Thau obj in this)
                if ((obj.MaHC == MaHC) && (obj.MaNCC == MaNCC) && (obj.NamThau == NamThau))
                    return true;
            return false;
        }

        //public DMHoaChat_Thau GetDMHoaChat_ThauById(string makho, decimal stt, string makhoa)
        //{
        //    foreach (DMHoaChat_Thau item in this)
        //        if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
        //            return item;
        //    return null;
        //}
        //public void Remove(string makho, int stt,string makhoa)
        //{
        //    foreach (DMHoaChat_Thau  item in this)
        //    {
        //        if ((item.Makho == makho  ) && (item.STT == stt)&&(item .Makhoa==makhoa  ))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public DMHoaChat_Thau GetTo(decimal STT) //
        {
            foreach (DMHoaChat_Thau obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            DMHoaChat_Thau item = DMHoaChat_Thau.NewDMHoaChat_Thau();
            Add(item);
            return item;
        }

       
        //public static DMHoaChat_ThauList GetDMHoaChat_Thau(String maHC, String maNCC, String namThau,String dK)
        //{
        //    return DataPortal.Fetch<DMHoaChat_ThauList>(new OtherCriteria(maHC ,maNCC , namThau, dK ));
        //}

        private DMHoaChat_ThauList()
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
            private string _dK;
            public string DK
            {
                get
                {
                    return _dK;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private Byte _loai = 0;
            public Byte loai
            {
                get
                {
                    return _loai;
                }

            }
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
            private String _namThau;
            public String NamThau
            {
                get
                {
                    return _namThau;
                }

            }
            public Criteria(Boolean qAdmin,string mancc,string namthau, string dK,byte loai)
            {
                //_qadmin = qAdmin;
                _dK = dK;
                _loai = loai;
                _maNCC = mancc;
                _namThau = namthau;

            }
        }
   

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_Thau(criteria.qadmin,criteria .MaNCC ,criteria .NamThau , criteria.DK,criteria .loai )))
            {
                int i = 1;
                while (dr.Read())
                {
                   this.Add(DMHoaChat_Thau.GetDMHoaChat_Thau(dr, i));         
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
          private class CriteriaOther
        {

             private Boolean _qadmin = false ;
              private string _maHC;
              public string maHC
            {
                get
                {
                    return _maHC;
                }
            }
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
              public Decimal _NgayPnhap;
              public Decimal NgayPnhap
            {
                get
                {
                    return _NgayPnhap;
                }
            }
            public CriteriaOther(Decimal NgayPnhap, string mancc,string maHC)
            {
                _NgayPnhap = NgayPnhap;
                _maHC = maHC;
                _maNCC = mancc;

            }
        }
   

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHoaChat_Thau_TOTALBYMAHC (criteria.NgayPnhap , criteria.MaNCC,  criteria.maHC )))
            {
                int i = 1;
                while (dr.Read())
                {
                   this.Add(DMHoaChat_Thau.GetDMHoaChat_Thau(dr,i));         
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMHoaChat_Thau item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMHoaChat_Thau item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMHoaChat_ThauList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMHoaChat_ThauList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
