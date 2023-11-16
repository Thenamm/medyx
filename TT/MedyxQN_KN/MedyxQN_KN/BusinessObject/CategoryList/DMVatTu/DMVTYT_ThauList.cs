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
    public class DMVTYT_ThauList : BusinessListBase<DMVTYT_ThauList, DMVTYT_Thau>
    {
        #region Factory Methods
        public static DMVTYT_ThauList GetAllDMVTYT_Thau(string mancc,string namthau,  String dk,byte loai)
        {
            return DataPortal.Fetch<DMVTYT_ThauList>(new Criteria(true, mancc, namthau, dk,loai));
        }
        public static DMVTYT_ThauList GetDMVTYT_Thau_TOTALBYMAVT(Decimal NgayPnhap, string mancc,string maVT)
        {
            return DataPortal.Fetch<DMVTYT_ThauList>(new CriteriaOther(NgayPnhap ,mancc,maVT ));
        }
        // tim theo dieu kien ten
        //public static DMVTYT_ThauList FindDMVTYT_ThauByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_ThauList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMVTYT_ThauList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_ThauList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMVTYT_Thau NewTo()
        {
            DMVTYT_Thau obj = DMVTYT_Thau.NewDMVTYT_Thau();
            return obj;
        }
        public void NewTo(DMVTYT_Thau _DMVTYT_Thau)
        {

            try
            {
                if (!Contains(_DMVTYT_Thau.MaVT, _DMVTYT_Thau.MaNCC, _DMVTYT_Thau.NamThau))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVTYT_Thau.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVTYT_Thau);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVTYT_Thau.OrderNumber = ++_count;
                        this.Add(_DMVTYT_Thau);
                    }
                    else
                    {
                        _DMVTYT_Thau.OrderNumber = 1;
                        this.Add(_DMVTYT_Thau);

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
        public void UpdatedTo(DMVTYT_Thau _DMVTYT_Thau)
        {

            _DMVTYT_Thau.MaVT = this.Items[this.IndexOf(_DMVTYT_Thau)].MaVT;
            this.Items[this.IndexOf(_DMVTYT_Thau)] = _DMVTYT_Thau;
        }
        public void RemoveTo(DMVTYT_Thau _DMVTYT_Thau)
        {
          

            if (_DMVTYT_Thau.IsNew == true)

                this.Items.Remove(_DMVTYT_Thau);
            else
                Remove(_DMVTYT_Thau);

      

        }
        public DMVTYT_Thau AssignTo(DMVTYT_Thau _DMVTYT_Thau)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVTYT_Thau.OrderNumber = ++_count;
                this.Add(_DMVTYT_Thau);
            }
            else
            {
                _DMVTYT_Thau.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVTYT_Thau);
            }
            //Add(_PhieuNhap_C);
            return _DMVTYT_Thau;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMVTYT_Thau item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaVT, string MaNCC, string NamThau)
        {
            foreach (DMVTYT_Thau obj in this)
                if ((obj.MaVT == MaVT) && (obj.MaNCC == MaNCC) && (obj.NamThau == NamThau))
                    return true;
            return false;
        }

        //public DMVTYT_Thau GetDMVTYT_ThauById(string makho, decimal stt, string makhoa)
        //{
        //    foreach (DMVTYT_Thau item in this)
        //        if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
        //            return item;
        //    return null;
        //}
        //public void Remove(string makho, int stt,string makhoa)
        //{
        //    foreach (DMVTYT_Thau  item in this)
        //    {
        //        if ((item.Makho == makho  ) && (item.STT == stt)&&(item .Makhoa==makhoa  ))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public DMVTYT_Thau GetTo(decimal STT) //
        {
            foreach (DMVTYT_Thau obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            DMVTYT_Thau item = DMVTYT_Thau.NewDMVTYT_Thau();
            Add(item);
            return item;
        }

       
        //public static DMVTYT_ThauList GetDMVTYT_Thau(String maVT, String maNCC, String namThau,String dK)
        //{
        //    return DataPortal.Fetch<DMVTYT_ThauList>(new OtherCriteria(maVT ,maNCC , namThau, dK ));
        //}

        private DMVTYT_ThauList()
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
            public Criteria(Boolean qAdmin, string mancc, string namthau, string dK, byte loai)
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_Thau(criteria.qadmin, criteria.MaNCC ,criteria.NamThau ,   criteria.DK,criteria.loai  )))
            {
                int i = 1;
                while (dr.Read())
                {
                   this.Add(DMVTYT_Thau.GetDMVTYT_Thau(dr, i));         
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
          private class CriteriaOther
        {

             private Boolean _qadmin = false ;
              private string _maVT;
              public string maVT
            {
                get
                {
                    return _maVT;
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
             private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
            public CriteriaOther(Decimal NgayPnhap,string mancc,  string maVT)
            {
                _NgayPnhap = NgayPnhap;
                _maVT = maVT;
                _maNCC = mancc;

            }
        }
   

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVTYT_Thau_TOTALBYMAVT (criteria.NgayPnhap , criteria.MaNCC, criteria.maVT )))
            {
                int i = 1;
                while (dr.Read())
                {
                   this.Add(DMVTYT_Thau.GetDMVTYT_Thau(dr, i));         
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVTYT_Thau item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVTYT_Thau item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVTYT_ThauList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVTYT_ThauList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
