using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAnList : BusinessListBase<BenhAnList, BenhAn>
    {
        #region Factory Methods
        public static BenhAnList GetAllBenhAn(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk)
        {
            return DataPortal.Fetch<BenhAnList>(new Criteria(maKhoa, Tungay, Denngay, loaikqkhoa,madt, dk));
        }
        
        public void NewTo(BenhAn _BenhAn)
        {
            if (this.Count == 0)
                _BenhAn.OrderNumber = 1;
            else
            _BenhAn.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn);
        }
        public void UpdatedTo(BenhAn _BenhAn)
        {

            _BenhAn.OrderNumber = this.Items[this.IndexOf(_BenhAn)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn)] = _BenhAn;
        }
        public void RemoveTo(BenhAn _BenhAn)
        {
            this.Items.Remove(_BenhAn);

        }

        private BenhAnList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
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
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private DateTime _Tungay;
            public DateTime Tungay
            {
                get
                {
                    return _Tungay;
                }
            }
            private DateTime _Denngay;
            public DateTime Denngay
            {
                get
                {
                    return _Denngay;
                }
            }
            private Byte _LoaiKQKhoa;
            public Byte LoaiKQKhoa
            {
                get
                {
                    return _LoaiKQKhoa;
                }
            }
            public Criteria(string maKhoa, DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk)
            {
                _Tungay = tungay ;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa ;
                _maKhoa  = maKhoa;
                _DK = dk ;
                _MaDT = madt;
                
                
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn(criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa,criteria.MaDT ,  criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn item = new BenhAn(
         i,
         dr.GetString("MaBA") ,
         dr.GetString("MaLoaiBA"),
			 dr.GetString("MaBN") ,
			 dr.GetString("MaDT") ,
			 dr.GetString("Sothe") ,
			 dr.GetSmartDate("GiatriDN", true) ,
			 dr.GetString("MaBV") ,
			 dr.GetString("MaTinh") ,
			 dr.GetSmartDate("NgayKT", true) ,
			 dr.GetSmartDate("Ngayduyet", true) ,
			 dr.GetString("Nguoiduyet") ,
			 dr.GetSmartDate("NgayQT", true) ,
			 dr.GetSmartDate("NgayQTTT", true) ,
			 dr.GetString("NguoiQT") ,
			 dr.GetString("MaBenhNoiGT") ,
			 dr.GetString("MaNoiGT") ,
			 dr.GetString("CDNoiGT") ,
			 dr.GetString("Ghichu") ,
			 dr.GetBoolean("Cungtra") ,
			 dr.GetDecimal("CK") ,
			 dr.GetSmartDate("NgayLap", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetString("NguoiHuy") ,
			 dr.GetSmartDate("NgayHuy", true) ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1") ,
			 dr.GetSmartDate("NgayVV", true) ,
			 dr.GetString("SoPhieuTTRV") ,
			 dr.GetString("MaBALuu") ,
			 dr.GetBoolean("RaVien") ,
			 dr.GetString("MaKhoa_HT") ,
     
         dr.GetString("mabhxh") ,
         dr.GetString("tendt"),
         dr.GetDecimal("bhtra") ,
         dr.GetDecimal("sotienbhtra") ,
         dr.GetString("tenBV") ,
         dr.GetString("maicdngt") ,
         dr.GetString("tenbenhngt") ,
         dr.GetString("hoten") ,
         dr.GetByte("tuoi") ,
         dr.GetSmartDate("ngaySinh", true) ,
         dr.GetString("diaChi") ,
         dr.GetBoolean("gt") ,
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy") ,
         dr.GetString("tenKhoaHT") ,
         dr.GetDecimal("tongtien"),
           dr.GetDecimal("giatrimaxktc"),
          dr.GetSmartDate("giatritn", true),
          dr.GetSmartDate("NgayRaVien", true),
          dr.GetString("MaBALienQuan"),
          dr.GetString("MaBAQL"),
         dr.GetBoolean("taibienthuoc"),
         dr.GetBoolean("taibienpt"),
         dr.GetBoolean("taibientt"),
         dr.GetBoolean("hoichan") 
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
