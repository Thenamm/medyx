using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBYTList : BusinessListBase<DMTBYTList, DMTBYT>
    {
        #region Factory Methods
        public static DMTBYTList GetAllDMTBYT()
        {
            return DataPortal.Fetch<DMTBYTList>(new Criteria());
        }
        public static DMTBYTList FindDMTBYTMa(string Ma)
        {
            return DataPortal.Fetch<DMTBYTList>(new CriteriaOther(1, Ma));
        }
        public static DMTBYTList FindDMTBYTTen(string Ten)
        {
            return DataPortal.Fetch<DMTBYTList>(new CriteriaOther(2, Ten));
        }
        public static DMTBYTList FindDMTBYTTenD(string Ten)
        {
            return DataPortal.Fetch<DMTBYTList>(new CriteriaOther(4, Ten));
        }
       
        public static DMTBYTList FindDMTBYTByNhomTBYT(string manhom)
        {
            return DataPortal.Fetch<DMTBYTList>(new CriteriaOther(3, manhom));
        }
        public static DMTBYTList FindDMTBYNhomTBMa(string Ma, String NhomTB)
        {
            return DataPortal.Fetch<DMTBYTList>(new OtherCriteria(5, Ma, NhomTB));
        }
        public static DMTBYTList FindDMTBYNhomTBTen(string Ma, String NhomTB)
        {
            return DataPortal.Fetch<DMTBYTList>(new OtherCriteria(6, Ma, NhomTB));
        }

		public static DMTBYTList FindDMTBYT(string DK)
		{
			return DataPortal.Fetch<DMTBYTList>(new CriteriaOther(5,DK));
		}
        public void NewTo(DMTBYT _DMTBYT)
        {
            if (this.Count == 0)
                _DMTBYT.OrderNumber = 1;
            else
            _DMTBYT.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTBYT);
        }
        public void UpdatedTo(DMTBYT _DMTBYT)
        {

            _DMTBYT.OrderNumber = this.Items[this.IndexOf(_DMTBYT)].OrderNumber;
            this.Items[this.IndexOf(_DMTBYT)] = _DMTBYT;
        }
        public void RemoveTo(DMTBYT _DMTBYT)
        {
            this.Items.Remove(_DMTBYT);

        }
        private DMTBYTList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
        }
        
        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
           
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                _DK = "";
                if (mIdFind == 1)
                    _DK = " and a.MaTB like N'%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(TenTB)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                    _DK = " and ltrim(rtrim(TenTB)) like N'" + mDK + "'"; 
                //else if ((mIdFind == 3) && (mDK == string.Empty ))
                else if ((mIdFind == 3) && (mDK != "All"))
                    _DK = " and A.MaNhom like '%" + mDK + "'";
				else if(mIdFind==5)
				{
					_DK = mDK;
				}
                
            }
        }


        #endregion

        #region OtherCriteria
        [Serializable()]
        private class OtherCriteria
        {
            
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private string _NhomTB;
            public string NhomTB
            {
                get
                {
                    return _NhomTB;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public OtherCriteria(Byte mIdFind, String mDK,String NhomTB)
            {

                _IdFind = mIdFind;
                _DK = "";
                _NhomTB = NhomTB;
                if (mIdFind == 5)
                    _DK = " and a.MaTB like N'%" + mDK + "'";
                else if (mIdFind == 6)
                    _DK = " and ltrim(rtrim(TenTB)) like N'" + mDK + "%'";

            }
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBYT(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBYT item = new DMTBYT(
         i,
         dr.GetString("MaTB") ,
			 dr.GetString("TenTB") ,
			 dr.GetString("MaNhom"),
			 dr.GetString("MaChungLoai") ,
			 dr.GetString("MaLH") ,
			 dr.GetString("MaDVT") ,
			 dr.GetSmartDate("NamSX", true) ,
			 dr.GetDecimal("KhoiLuong") ,
			 dr.GetDecimal("Tl_khcb") ,
			 dr.GetString("Ghichu") ,
			 dr.GetBoolean("S_khauhao") ,
			 dr.GetString("CongsuatTK") ,
			 dr.GetString("MaNSX") ,
			 dr.GetString("MaQG") ,
			 dr.GetInt32("KyBaoDuong") ,
			 dr.GetString("MaMay") ,
			 dr.GetSmartDate("NgayHuy", true) ,
			 dr.GetString("NguoiHuy") ,
			 dr.GetSmartDate("NgayLap", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1") ,
			 dr.GetString("TenNhom") ,
			 dr.GetString("TenChungLoai") ,
         dr.GetString("tenNSX") , 
         dr.GetString("TenDVT"),
         dr.GetString("TenQG"),
		 dr.GetString("TenNguoiLap") ,
         dr.GetString("TenNguoiSD") ,
         dr.GetString("TenNguoiHuy"),
         dr.GetInt32("ThangSD")
         );
                   
                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTBYTByNhomTB(criteria.DK,criteria.NhomTB    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBYT item = new DMTBYT(
     i,
     dr.GetString("MaTB"),
         dr.GetString("TenTB"),
         dr.GetString("MaNhom"),
         dr.GetString("MaChungLoai"),
         dr.GetString("MaLH"),
         dr.GetString("MaDVT"),
         dr.GetSmartDate("NamSX", true),
         dr.GetDecimal("KhoiLuong"),
         dr.GetDecimal("Tl_khcb"),
         dr.GetString("Ghichu"),
         dr.GetBoolean("S_khauhao"),
         dr.GetString("CongsuatTK"),
         dr.GetString("MaNSX"),
         dr.GetString("MaQG"),
         dr.GetInt32("KyBaoDuong"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetString("TenNhom"),
         dr.GetString("TenChungLoai"),
         dr.GetString("tenNSX"),
         dr.GetString("tendvt"),
         
         dr.GetString("TenQG"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("TenNguoiLap"),
         dr.GetString("TenNguoiHuy"),
         dr.GetInt32("ThangSD")
         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTBYT(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBYT item = new DMTBYT(
     i,
     dr.GetString("MaTB"),
         dr.GetString("TenTB"),
         dr.GetString("MaNhom"),
         dr.GetString("MaChungLoai"),
         dr.GetString("MaLH"),
         dr.GetString("MaDVT"),
         dr.GetSmartDate("NamSX", true),
         dr.GetDecimal("KhoiLuong"),
         dr.GetDecimal("Tl_khcb"),
         dr.GetString("Ghichu"),
         dr.GetBoolean("S_khauhao"),
         dr.GetString("CongsuatTK"),
         dr.GetString("MaNSX"),
         dr.GetString("MaQG"),
         dr.GetInt32("KyBaoDuong"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetString("TenNhom"),
         dr.GetString("TenChungLoai"),
         dr.GetString("tenNSX"),
         dr.GetString("tendvt"),

         dr.GetString("TenQG"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("TenNguoiLap"),
         dr.GetString("TenNguoiHuy"),
         dr.GetInt32("ThangSD")
         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }     
        #endregion
    }
}
