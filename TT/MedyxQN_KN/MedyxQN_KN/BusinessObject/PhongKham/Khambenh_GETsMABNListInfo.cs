using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_GETsMABNListInfo : BusinessListBase<KhamBenh_GETsMABNListInfo, KhamBenh_GETsMABNInfo>
    {
        #region Factory Methods
        public static KhamBenh_GETsMABNListInfo NewList()
        {
            return DataPortal.Fetch<KhamBenh_GETsMABNListInfo>(new TemCriteria());
        }
        public static KhamBenh_GETsMABNListInfo GetAllKhamBenh_GETsMABNInfo(string MABN ,Byte  loai ,string dk )
        {
            return DataPortal.Fetch<KhamBenh_GETsMABNListInfo>(new Criteria(MABN,loai,dk  ));
        }
        public static KhamBenh_GETsMABNListInfo GetAllKhamBenh_GETsMABNInfoTT(string MABN, Byte loai, string dk)
        {
            return DataPortal.Fetch<KhamBenh_GETsMABNListInfo>(new CriteriaTT(MABN, loai, dk));
        }
        
        private KhamBenh_GETsMABNListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria
        {
            private string _MaBN;
            private Byte _Loai;
            private DateTime _NgayYC;
            private string _DK;
            private Boolean _qadmin = false ;
            public string MaBN
            {
                get
                {
                    return _MaBN;
                }
            }
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public DateTime NgayYC
            {
                get
                {
                    return _NgayYC;
                }
            }

            public string DK
            {
                get
                {
                    return _DK;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public Criteria(string mMaBN,  Byte mLoai, string mDK)
            {
                _Loai = mLoai;
                _MaBN = mMaBN;
              //  _NgayYC = mNgayYC;
                _DK = mDK;
                
            }
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_GETsMABNInfo(criteria.MaBN,    criteria.Loai,criteria.DK,     criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_GETsMABNInfo item = new KhamBenh_GETsMABNInfo(
     i,
     dr.GetString("MaSoKham") ,
     dr.GetString("MaBN"),
     dr.GetString("MaDT") ,
     dr.GetString("Sothe") ,
     dr.GetSmartDate("GiatriDN", true) ,
     dr.GetString("MaBV") ,
     dr.GetString("MaTinh") ,
     dr.GetSmartDate("NgayKT", true) ,
     dr.GetString("Gio") ,
     dr.GetSmartDate("Ngayduyet", true) ,
     dr.GetString("Nguoiduyet") ,
     dr.GetSmartDate("NgayQT", true) ,
     dr.GetSmartDate("NgayQTTT", true) ,
     dr.GetString("NguoiQT") ,
     dr.GetString("MaBenhNoiGT") ,
     dr.GetString("MaNoiGT") ,
     dr.GetString("CDNoiGT") ,
     dr.GetString("Ghichu") ,
     dr.GetByte("Loaikham") ,
     dr.GetBoolean("Cungtra") ,
     dr.GetDecimal("CK") ,
     dr.GetSmartDate("NgayLap", true) ,
     dr.GetString("NguoiLap") ,
     dr.GetSmartDate("NgaySD", true)  ,
     dr.GetString("NguoiSD") ,
     dr.GetString("MaMay") ,
     dr.GetBoolean("Huy") ,
     dr.GetByte("NguoiHuy") ,
     dr.GetSmartDate("NgayHuy", true) ,
     dr.GetSmartDate("NgaySD1", true) ,
     dr.GetString("NguoiSD1") ,
     dr.GetString("DienThoai") ,
     dr.GetString("DiaChi") ,
     dr.GetDecimal("TongTien") ,
     dr.GetDecimal("TongBHTra") ,
     dr.GetDecimal("TongTienBH"),
     dr.GetSmartDate("NgayDK"),
     dr.GetString("hoten"),
      dr.GetString("bschidinh"),
      dr.GetString("tenbenh")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
               // dr.Close();
                dr.Close(); dr.Dispose();
            }
           
            //IsReadOnly = true;
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class CriteriaTT
        {
            private string _MaBN;
            private Byte _Loai;
            private DateTime _NgayYC;
            private string _DK;
             private Boolean _qadmin = false ;
            public string MaBN
            {
                get
                {
                    return _MaBN;
                }
            }
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public DateTime NgayYC
            {
                get
                {
                    return _NgayYC;
                }
            }

            public string DK
            {
                get
                {
                    return _DK;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public CriteriaTT(string mMaBN, Byte mLoai, string mDK)
            {
                _Loai = mLoai;
                _MaBN = mMaBN;
                //  _NgayYC = mNgayYC;
                _DK = mDK;

            }
        }
        private void DataPortal_Fetch(CriteriaTT CriteriaTT)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_GETsMABNInfo(CriteriaTT.MaBN, CriteriaTT.Loai, CriteriaTT.DK, CriteriaTT.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_GETsMABNInfo item = new KhamBenh_GETsMABNInfo(
     i,
     dr.GetString("MaSoKham"),
     dr.GetString("MaBN"),
     dr.GetSmartDate("NgayDK"),
      dr.GetString("bschidinh"),
      dr.GetString("tenbenh")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
                // dr.Close();
                SmartDate sm = new SmartDate(true);
                KhamBenh_GETsMABNInfo _KhamBenh_GETsMABNInfo = new KhamBenh_GETsMABNInfo(i, "", "", sm, "", "");
                this.Add(_KhamBenh_GETsMABNInfo);
               
                dr.Close(); dr.Dispose();
            }

            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
