using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_VP_GetsListInfo : BusinessListBase<BenhAn_VP_GetsListInfo, BenhAn_VP_GetsInfo>
    {
        #region Business Methods

        #region State Fields
        #endregion
        #endregion
        #region Factory Methods
        public static BenhAn_VP_GetsListInfo GetAllBenhAn_VP_GetsInfo( string _maba, Byte _datt)  
        {
            return DataPortal.Fetch<BenhAn_VP_GetsListInfo>(new Criteria(_maba,  _datt, ""));
        }
        
        
        private BenhAn_VP_GetsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
           
            private string _makhoa ;
             private Boolean _qadmin = false ;
           
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
         
            private Byte _DaTT;
            public Byte DaTT
            {
                get
                {
                    return _DaTT;
                }
            }
            private String _maba;
            public string maba
            {
                get
                {
                    return _maba;
                }
            }


            public Criteria(string maba, Byte datt, string dk)
            {
                             
                _DK = dk;
                _DaTT = datt;
               
                _maba= maba;
                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_VP_GetsInfo(criteria.maba, criteria.DaTT, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_VP_GetsInfo item = new BenhAn_VP_GetsInfo( 
     i,
      dr.GetInt32("LOAIBN"),
			 dr.GetInt32("Namsinh"),
			 dr.GetString("MABA"),
			 dr.GetString("MAKHOA"),
			dr.GetInt32("STTKHOA"),
			 dr.GetString("MABN"),
			 dr.GetSmartDate("NGAYDK", true),
			 dr.GetString("MADV"),
			 dr.GetString("TENDV"),
			 dr.GetDecimal("THUOC"),
			 dr.GetDecimal("MAU"),
			 dr.GetDecimal("XN"),
			 dr.GetDecimal("CDHA"),
			 dr.GetDecimal("DVKTTT"),
			 dr.GetDecimal("DVKTC"),
			 dr.GetDecimal("VTTH"),
			 dr.GetDecimal("VCBN"),
			 dr.GetDecimal("TDCN"),
			 dr.GetDecimal("THUOCTN"),
			 dr.GetDecimal("MAUTN"),
			 dr.GetDecimal("XNTN"),
			 dr.GetDecimal("CDHATN"),
			 dr.GetDecimal("DVKTTTTN"),
			 dr.GetDecimal("DVKTCTN"),
			 dr.GetDecimal("VTTHTN"),
			 dr.GetDecimal("VCBNTN"),
			 dr.GetDecimal("TDCNTN"),
			 dr.GetDecimal("GIUONG"),
			 dr.GetDecimal("GIUONGTN"),
			 dr.GetDecimal("PHAUTHUAT"),
			 dr.GetDecimal("PHAUTHUATTN"),
			 dr.GetBoolean("GT"),
		               dr.GetString("SOTHE"),
			 dr.GetSmartDate("GIATRIDN", true),
			 dr.GetString("MABV"),
			 dr.GetString("MAICD"),
			 dr.GetString("SOPHIEUTTRV"),
			 dr.GetDecimal("BHTRA"),
			 dr.GetDecimal("SOTIENMAX"),
                      dr.GetString("KQDT"),
             dr.GetDecimal("dvtunguyen"),
             dr.GetDecimal("tongtien"));
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
            }
           
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
