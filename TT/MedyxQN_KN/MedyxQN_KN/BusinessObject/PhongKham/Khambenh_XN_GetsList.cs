using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_XN_GetsList : BusinessListBase<KhamBenh_XN_GetsList, KhamBenh_XN_Gets>
    {

        #region Business Methods



        public KhamBenh_XN_Gets Contains(Int32 SoTT)
        {
            foreach (KhamBenh_XN_Gets obj in this)
                if (obj.OrderNumber   == SoTT)
                    return obj;
            return null;
        }
        public void NewTo(KhamBenh_C _KhamBenh_C, string _bschidinh) //moi sua
        {
            KhamBenh_XN_Gets obj = KhamBenh_XN_Gets.NewKhamBenh_XN_Gets();
            obj.BSCHIDINH = _bschidinh;
            obj.MADV = _KhamBenh_C.MaDV  ;
            obj.TENDV = _KhamBenh_C.TenTM;
            obj.NhapSL = _KhamBenh_C.NhapSL;
            obj.MASOKHAM = _KhamBenh_C.MaSoKham  ;
            obj.STT = _KhamBenh_C.STT ;
            if (this.Items.Count == 0)
                obj.OrderNumber = 1;
            else
                obj.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
           
            this.Add (obj);
 
        }

        public void UpdatedTo(KhamBenh_C _KhamBenh_C, KhamBenh_XN_Gets _KhamBenh_XN_Gets)
        {

            //_KhamBenh_XN_Gets.OrderNumber = this.Items[this.IndexOf(_KhamBenh_XN_Gets)].OrderNumber;
            //_KhamBenh_XN_Gets.ADGIAUSD = _KhamBenh_C.ADGiaUSD;
            //_KhamBenh_XN_Gets.BHTINHTIEN = _KhamBenh_C.BHTinhTien;
            //_KhamBenh_XN_Gets.BSKHAM = _KhamBenh_C.MaBS;
            //_KhamBenh_XN_Gets.CK = _KhamBenh_C.CK;
            //_KhamBenh_XN_Gets.DATT = _KhamBenh_C.DaTT;
            //_KhamBenh_XN_Gets.DONGIABH = _KhamBenh_C.DonGiaBH;
            //_KhamBenh_XN_Gets.DONGIATT = _KhamBenh_C.DongiaTT;
            //_KhamBenh_XN_Gets.LOAIDV = 1;
            //_KhamBenh_XN_Gets.MaDV = _KhamBenh_C.MaDV;
            //_KhamBenh_XN_Gets.MAKHOA = _KhamBenh_C.Makhoa;
            //_KhamBenh_XN_Gets.SoLuong = _KhamBenh_C.slmua - _KhamBenh_C.SLTra;

            //_KhamBenh_XN_Gets.SoTT = _KhamBenh_C.STT;
            _KhamBenh_XN_Gets.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
           
            this.Items[this.IndexOf(_KhamBenh_XN_Gets)] = _KhamBenh_XN_Gets;

        }
        public void RemoveTo(KhamBenh_XN_Gets _KhamBenh_XN_Gets)
        {

            if (_KhamBenh_XN_Gets.IsNew == true)
                this.Items.Remove(_KhamBenh_XN_Gets);

            else
                Remove(_KhamBenh_XN_Gets);

        }
        #endregion
        #region Factory Methods

        public static KhamBenh_XN_GetsList GetAllGetsDichVu(string _masokham, Byte _datt, DateTime _ngayyc, Byte _loaiphieu, String _dk, Int32 _stt)
        {
            return DataPortal.Fetch<KhamBenh_XN_GetsList>(new Criteria(_masokham, _datt, _ngayyc, _loaiphieu, _dk,_stt));

        }

        private KhamBenh_XN_GetsList()
        {  /* Require use of factory methods */ }

        public static KhamBenh_XN_GetsList NewKhamBenh_XN_GetsList()
        {
            return new KhamBenh_XN_GetsList();
        }
        
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            private Int32  _stt;
            public Int32 stt
            {
                get
                {
                    return _stt;
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
            public Criteria(string MaSoKham, Byte DaTT, DateTime ngayYC, Byte loai, string dk, int stt)
            {
                _ngayYC = ngayYC;
                _Loai = loai;
                _MaSoKham = MaSoKham;
                _DK = dk;
                _DaTT = DaTT;
                _stt = stt;


            }
        }



        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_GETsMABNInfo(criteria.MaBN, criteria.NgayYC, criteria.Loai, criteria.DK, criteria.qadmin)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            KhamBenh_GETsMABNInfo item = new KhamBenh_GETsMABNInfo(
        // i,
        // dr.GetString("MaSoKham"),
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

        //    RaiseListChangedEvents = true; 
        //}

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_XN_Gets( criteria.qadmin, criteria.MaSoKham,criteria.DaTT , criteria.ngayYC, criteria.Loai, criteria.DK,criteria.stt  )))
            {
                int i = 1;
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
                    KhamBenh_XN_Gets  item = new KhamBenh_XN_Gets(
             dr.GetString("MASOKHAM"),
             dr.GetInt32("STT"),
              dr.GetString("MADV"),
             dr.GetString("BSCHIDINH"),
			  //(Byte[])dr.GetValue("FILEKQ"),
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
                dr.GetString("TenKQ")
         );
                    this.Add(item);

                }
                //IsReadOnly = true;
                dr.Close(); dr.Dispose();
               // dr = null;
            }
            RaiseListChangedEvents = true;             
        }
    
        #endregion
    }
}
