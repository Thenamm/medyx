using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBVTYT_TonKhoHDList : ReadOnlyListBase<DMTBVTYT_TonKhoHDList, DMTBVTYT_TonKhoHD>
    {
        #region Factory Methods
        public DMTBVTYT_TonKhoHD Containsfind(string mavt, string solo, string hansd)
        {
            foreach (DMTBVTYT_TonKhoHD obj in this)
                if (solo == "" && hansd == "")
                {
                    if (obj.MaVT == mavt)
                        return obj;
                }
                else if ((obj.MaVT == mavt) && (obj.SoLo == solo) && (obj.HanSD == hansd))
                    return obj;
            return null;

        }
        public static DMTBVTYT_TonKhoHDList GetAllDMTBVTYTTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(0, maKho, thang, "", "", DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList GetAllDMTBVTYTTonKho(String maKho, DateTime thang,string dk)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(0, maKho, thang,dk, "", DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, "", DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoTen(String maKho, DateTime thang, String Ten,String DK)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(5, maKho, thang, Ten, DK, DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoMa(String maKho, DateTime thang, String Ma, String DK)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(4, maKho, thang, Ma, DK, DateTime.Parse("01/01/1900")));
        }
        public static DMTBVTYT_TonKhoHDList GetAllDMTBVTYTTonKho(String maKho, DateTime thang, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(0, maKho, thang, "", solo, hansd));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoMa(String maKho, DateTime thang, String Ma, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, solo, hansd));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoTen(String maKho, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, solo, hansd));
        }
        public static DMTBVTYT_TonKhoHDList FindDMTBVTYTTonKhoTenD(String maKho, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, solo, hansd));
        }
		public static DMTBVTYT_TonKhoHDList GetAllDMTBVTYTTonKhoHD(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd)
		{
			return DataPortal.Fetch<DMTBVTYT_TonKhoHDList>(new Criteria1(maKho, MaNCC, SoHD, DK, solo, hansd));
		}
	  
	    private DMTBVTYT_TonKhoHDList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        protected class Criteria
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang ;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            public Criteria(Byte mIdFind, String maKho, DateTime thang, String mDK, string solo, DateTime hansd)
            {
                _maKho = maKho;
                _thang = thang;
                _hansd = hansd;
                if (_hansd == DateTime.Parse("01/01/0001"))
                    _hansd = DateTime.Parse("01/01/1900");
                _dK = mDK;
                if ((mIdFind == 1) || (mIdFind == 4))
                   _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 2) || (mIdFind == 5))
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 5))
                {
                    _dK = _dK + solo;
                    _solo = "";
                }
                else
                    _solo = solo;
            }


        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBVTYTTonKhoHD(criteria.MaKho , criteria.thang, criteria.DK,criteria.solo,criteria.hansd   )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBVTYT_TonKhoHD item = new DMTBVTYT_TonKhoHD(
     i,
     dr.GetString("MaVT"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap"),
     //dr.GetString("Tengoc"),
     dr.GetString("SoLo"),
     dr.GetSmartDate("HanSD", false),
     dr.GetDecimal("nguong")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

		protected class Criteria1
		{
			private String _maKho;
			public String MaKho
			{
				get
				{
					return _maKho;
				}
			}
			private DateTime _hansd;
			public DateTime hansd
			{
				get
				{
					return _hansd;
				}
			}
			private String _dK;
			public String DK
			{
				get
				{
					return _dK;
				}
			}
			private String _MaNCC;
			public String MaNCC
			{
				get
				{
					return _MaNCC;
				}
			}

			private String _SoHD;
			public String SoHD
			{
				get
				{
					return _SoHD;
				}
			}

			private String _solo;
			public String solo
			{
				get
				{
					return _solo;
				}
			}

			public Criteria1(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd)
			{
				_maKho = maKho;
				_MaNCC = MaNCC;
				_SoHD = SoHD;
				_dK = DK;
				_solo = solo;
				_hansd = hansd;
			}


		}

		private void DataPortal_Fetch(Criteria1 criteria1)
		{
			RaiseListChangedEvents = false;
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBVTYTTonKhoHD(criteria1.MaKho,criteria1.MaNCC, criteria1.SoHD, criteria1.DK, criteria1.solo, criteria1.hansd)))
			{
				int i = 1;
				IsReadOnly = false;
				while (dr.Read())
				{
					DMTBVTYT_TonKhoHD item = new DMTBVTYT_TonKhoHD(
					i,
					dr.GetString("MaVT"),
					dr.GetString("TenTM"),
					dr.GetString("TenDVT"),
					dr.GetDecimal("TonCK"),
					dr.GetDecimal("TonCKDT"),
					dr.GetString("TenTA"),
					dr.GetBoolean("Handung"),
					dr.GetString("TenNSX"),
					dr.GetString("MaQL"),
					dr.GetDecimal("DonGiatt"),
					dr.GetDecimal("gianhap"),
									//dr.GetString("Tengoc"),
					dr.GetString("SoLo"),
					dr.GetSmartDate("HanSD", false),
					dr.GetDecimal("nguong")
						);
								this.Add(item);
								i += 1;
							}
							IsReadOnly = true;
						}
						RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
					}


        #endregion
    }
}
