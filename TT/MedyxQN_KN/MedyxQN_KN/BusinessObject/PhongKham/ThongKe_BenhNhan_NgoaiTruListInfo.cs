using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class ThongKe_BenhNhan_NgoaiTruListInfo  : ReadOnlyListBase<ThongKe_BenhNhan_NgoaiTruListInfo, ThongKe_BenhNhan_NgoaiTru_Info >
    {
        #region Factory Methods
        public static ThongKe_BenhNhan_NgoaiTruListInfo GetThongKe_BenhNhan_NgoaiTru_Info(DateTime tungay, DateTime denngay, String makhoa, byte loai, string dk)
        {
            return DataPortal.Fetch<ThongKe_BenhNhan_NgoaiTruListInfo>(new Criteria(tungay, denngay, makhoa, loai, dk));
            
        }

        private ThongKe_BenhNhan_NgoaiTruListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
           
            private DateTime  _tungay;
            public DateTime tungay
            {
                get
                {
                    return _tungay;
                }
            }
            private DateTime _denngay;
            public DateTime denngay
            {
                get
                {
                    return _denngay;
                }
            }
            private String  _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa ;
                }
            }
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }

           

            public Criteria(DateTime mtungay, DateTime mdenngay,String mmakhoa, byte mloai, string mdk)
            {
                _tungay = mtungay;
                _denngay = mdenngay;
                _makhoa = mmakhoa;
                _loai = mloai;
                _dk = mdk;
               
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;

            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongKe_BenhNhan_NgoaiTru_Info( criteria.tungay, criteria.denngay,criteria.makhoa , criteria.loai, criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    ThongKe_BenhNhan_NgoaiTru_Info item = new ThongKe_BenhNhan_NgoaiTru_Info(
                        
         i,
         dr.GetString("MaKhoa") ,
         dr.GetString("TenKhoa") ,
         dr.GetInt32  ("SoLuotCK"),
         dr.GetInt32("SoLuotDK"),
          dr.GetInt32("SoLuotCKC"),
         dr.GetInt32("SoLuotDKC"),
            dr.GetInt32("SoLuotTD"),
           dr.GetInt32("SoLuotTDC"),
             dr.GetInt32("SoLuotTT"),
           dr.GetInt32("SoLuotTTC"),
         dr.GetInt32("SoLuotDangK")   
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
