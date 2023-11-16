using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_XN_GetsList : BusinessListBase<BenhAn_XN_GetsList, BenhAn_XN_Gets>
    {

        #region Business Methods



        public BenhAn_XN_Gets Contains(Int32 SoTT)
        {
            foreach (BenhAn_XN_Gets obj in this)
                if (obj.OrderNumber == SoTT)
                    return obj;
            return null;
        }
        public void NewTo(BenhAn_C _BenhAn_C, string _bschidinh) //moi sua
        {
            BenhAn_XN_Gets obj = BenhAn_XN_Gets.NewBenhAn_XN_Gets();
            obj.BSCHIDINH = _bschidinh;
            obj.MADV = _BenhAn_C.MaDV;
            obj.TENDV = _BenhAn_C.TenDV;
            obj.NhapSL = _BenhAn_C.NhapSL;
            obj.maba = _BenhAn_C.MaBA;
            obj.STT = _BenhAn_C.STTKhoa;
            obj.STTKhoa = _BenhAn_C.STT;
            if (this.Items.Count == 0)
                obj.OrderNumber = 1;
            else
                obj.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber + 1;

            this.Add(obj);

        }

        public void UpdatedTo(BenhAn_C _BenhAn_C, BenhAn_XN_Gets _BenhAn_XN_Gets)
        {

            //_BenhAn_XN_Gets.OrderNumber = this.Items[this.IndexOf(_BenhAn_XN_Gets)].OrderNumber;
            //_BenhAn_XN_Gets.ADGIAUSD = _BenhAn_C.ADGiaUSD;
            //_BenhAn_XN_Gets.BHTINHTIEN = _BenhAn_C.BHTinhTien;
            //_BenhAn_XN_Gets.BSKHAM = _BenhAn_C.MaBS;
            //_BenhAn_XN_Gets.CK = _BenhAn_C.CK;
            //_BenhAn_XN_Gets.DATT = _BenhAn_C.DaTT;
            //_BenhAn_XN_Gets.DONGIABH = _BenhAn_C.DonGiaBH;
            //_BenhAn_XN_Gets.DONGIATT = _BenhAn_C.DongiaTT;
            //_BenhAn_XN_Gets.LOAIDV = 1;
            //_BenhAn_XN_Gets.MaDV = _BenhAn_C.MaDV;
            //_BenhAn_XN_Gets.MAKHOA = _BenhAn_C.Makhoa;
            //_BenhAn_XN_Gets.SoLuong = _BenhAn_C.slmua - _BenhAn_C.SLTra;

            //_BenhAn_XN_Gets.SoTT = _BenhAn_C.STT;
            _BenhAn_XN_Gets.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber + 1;

            this.Items[this.IndexOf(_BenhAn_XN_Gets)] = _BenhAn_XN_Gets;

        }

        #endregion
        #region Factory Methods

        public static BenhAn_XN_GetsList GetAllGetsDichVu(string _maba, Byte _datt, DateTime _ngayyc, Byte _loaiphieu, String _dk, Int32 _stt, int _sttkhoa)
        {
            return DataPortal.Fetch<BenhAn_XN_GetsList>(new Criteria(_maba, _datt, _ngayyc, _loaiphieu, _dk, _stt, _sttkhoa));

        }
        public static BenhAn_XN_GetsList GetAllGetsDichVu(string _maba, int _sttkhoa, String _dk)
        {
            return DataPortal.Fetch<BenhAn_XN_GetsList>(new OtherCriteria(_maba, _sttkhoa, _dk));

        }
        private BenhAn_XN_GetsList()
        {  /* Require use of factory methods */ }

        public static BenhAn_XN_GetsList NewBenhAn_XN_GetsList()
        {
            return new BenhAn_XN_GetsList();
        }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            private String _maba;
            public String maba
            {
                get
                {
                    return _maba;
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
            private DateTime _ngayYC;
            public DateTime ngayYC
            {
                get
                {
                    return _ngayYC;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Int32 _stt;
            public Int32 stt
            {
                get
                {
                    return _stt;
                }
            }
            private Int32 _sttkhoa;
            public Int32 sttkhoa
            {
                get
                {
                    return _sttkhoa;
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
            public Criteria(string maba, Byte DaTT, DateTime ngayYC, Byte loai, string dk, int stt, int sttKhoa)
            {
                _ngayYC = ngayYC;
                _Loai = loai;
                _maba = maba;
                _DK = dk;
                _DaTT = DaTT;
                _stt = stt;
                _sttkhoa = sttKhoa;

            }
        }

        private class OtherCriteria
        {

             private Boolean _qadmin = false ;
            private String _maba;
            public String maba
            {
                get
                {
                    return _maba;
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

            private Int32 _sttkhoa;
            public Int32 sttkhoa
            {
                get
                {
                    return _sttkhoa;
                }
            }

            public OtherCriteria(String MaBA, int sttKhoa, string dk)
            {

                _maba = MaBA;
                _DK = dk;

                _sttkhoa = sttKhoa;
               
            }
        }

        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_GETsMABNInfo(criteria.MaBN, criteria.NgayYC, criteria.Loai, criteria.DK, criteria.qadmin)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            BenhAn_GETsMABNInfo item = new BenhAn_GETsMABNInfo(
        // i,
        // dr.GetString("maba"),
        // dr.GetString("MaBN"),
        // dr.GetString("MaDT"),
        // dr.GetString("Sothe"),
        // dr.GetSmartDate("GiatriDN", true),
        // dr.GetString("MaBV"),
        // dr.GetString("MaTinh"),
        // dr.GetSmartDate("NgayKT", true),
        // dr.GetString("Gio"),
        // dr.GetSmartDate("Ngayduyet", true),
        // dr.GetString("Nguoiduyet"),
        // dr.GetSmartDate("NgayQT", true),
        // dr.GetSmartDate("NgayQTTT", true),
        // dr.GetString("NguoiQT"),
        // dr.GetString("MaBenhNoiGT"),
        // dr.GetString("MaNoiGT"),
        // dr.GetString("CDNoiGT"),
        // dr.GetString("Ghichu"),
        // dr.GetByte("Loaikham"),
        // dr.GetBoolean("Cungtra"),
        // dr.GetDecimal("CK"),
        // dr.GetSmartDate("NgayLap", true),
        // dr.GetString("NguoiLap"),
        // dr.GetSmartDate("NgaySD", true),
        // dr.GetString("NguoiSD"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetByte("NguoiHuy"),
        // dr.GetSmartDate("NgayHuy", true),
        // dr.GetSmartDate("NgaySD1", true),
        // dr.GetString("NguoiSD1"),
        // dr.GetString("DienThoai"),
        // dr.GetString("DiaChi"),
        // dr.GetDecimal("TongTien"),
        // dr.GetDecimal("TongBHTra"),
        // dr.GetDecimal("TongTienBH")
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }

        //IsReadOnly = true;

        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_XN_Gets(criteria.qadmin, criteria.maba, criteria.DaTT, criteria.ngayYC, criteria.Loai, criteria.DK, criteria.stt, criteria.sttkhoa)))
            {
                int i = 1;
                //IsReadOnly = false;
                int stt = -1;
                //IsReadOnly = false;
                while (dr.Read())
                {

                   if (stt == -1)
                        stt = dr.GetInt32("STT");
                    else if (stt != dr.GetInt32("STT"))
                    {
                        stt = dr.GetInt32("STT");
                        i += 1;
                    }
                    BenhAn_XN_Gets item = new BenhAn_XN_Gets(
             dr.GetString("maba"),
             dr.GetInt32("STTkhoa"),
             dr.GetInt32("STT"),
              dr.GetString("MADV"),
             dr.GetString("BSCHIDINH"),
              (Byte[])dr.GetValue("FILEKQ"),
              dr.GetString("KQ"),
              dr.GetInt32("STTCS"),
               dr.GetString("MACS"),
              dr.GetString("KQCS"),
               dr.GetString("TENCS"),
               dr.GetString("TENDV"),
               dr.GetString("CHISOCAONAM"),
               dr.GetString("CHISOCAONU"),
              dr.GetString("CHISOTHAPNAM"),
               dr.GetString("CHISOTHAPNU"),
               dr.GetString("DONVI"),
               dr.GetString("CHISOCAONAMCS"),
               dr.GetString("CHISOCAONUCS"),
              dr.GetString("CHISOTHAPNAMCS"),
              dr.GetString("CHISOTHAPNUCS"),
              dr.GetString("DONVICS"),
               dr.GetByte("LOAIKQ"),

         i,
               dr.GetByte("DATT"),
               dr.GetBoolean("nhapsl"),
                dr.GetString("FormSudung"),
                dr.GetString("MaKQ"),
                dr.GetString("TenKQ"),
                dr.GetSmartDate("NgayDK",true)

         );
                    this.Add(item);
                 

                }
                //IsReadOnly = true;

            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();            
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_XN_Gets(criteria.qadmin, criteria.maba, criteria.sttkhoa,criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_XN_Gets item = new BenhAn_XN_Gets(
             dr.GetString("maba"),
             dr.GetInt32("STTkhoa"),
             dr.GetInt32("STT"),
              dr.GetString("MADV"),
             dr.GetString("BSCHIDINH"),
              (Byte[])dr.GetValue("FILEKQ"),
              dr.GetString("KQ"),
              dr.GetInt32("STTCS"),
               dr.GetString("MACS"),
              dr.GetString("KQCS"),
               dr.GetString("TENCS"),
               dr.GetString("TENDV"),
               dr.GetString("CHISOCAONAM"),
               dr.GetString("CHISOCAONU"),
              dr.GetString("CHISOTHAPNAM"),
               dr.GetString("CHISOTHAPNU"),
               dr.GetString("DONVI"),
               dr.GetString("CHISOCAONAMCS"),
               dr.GetString("CHISOCAONUCS"),
              dr.GetString("CHISOTHAPNAMCS"),
              dr.GetString("CHISOTHAPNUCS"),
              dr.GetString("DONVICS"),
               dr.GetByte("LOAIKQ"),

         i,
               dr.GetByte("DATT"),
               dr.GetBoolean("nhapsl"),
                dr.GetString("FormSudung"),
                dr.GetString("MaKQ"),
                dr.GetString("TenKQ"),
                dr.GetSmartDate("NgayDK", true)

         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
                dr.Close(); dr.Dispose();
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();            
        }
        #endregion
    }
}
