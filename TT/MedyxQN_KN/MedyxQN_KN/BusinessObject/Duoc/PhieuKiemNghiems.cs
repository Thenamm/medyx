using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuKiemNghiems : BusinessListBase<PhieuKiemNghiems, PhieuKiemNghiem>
    {
        #region Business Methods
        public PhieuKiemNghiem this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
        public static PhieuKiemNghiems GetAllPhieuKiemNghiem(Boolean qadmin, String MaDT, DateTime tungay, DateTime denngay, String dieukienthem, byte loaiphieu)
        {
            return DataPortal.Fetch<PhieuKiemNghiems>(new Criteria(qadmin, MaDT, tungay, denngay, dieukienthem, loaiphieu));
        }
        public void NewTo(PhieuKiemNghiem _PhieuKiemNghiem)
        {
            _PhieuKiemNghiem.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhieuKiemNghiem);
        }
        public PhieuKiemNghiem NewTo()
        {
            PhieuKiemNghiem obj = PhieuKiemNghiem.NewPhieuKiemNghiem();
            return obj;
        }
        //public void NewTo(PhieuKiemNghiem _PhieuKiemNghiem)
        //{
        //    _PhieuKiemNghiem.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
        //    this.Add(_PhieuKiemNghiem);
        //}
        public void UpdatedTo(PhieuKiemNghiem _PhieuKiemNghiem)
        {
            _PhieuKiemNghiem.OrderNumber = this.Items[this.IndexOf(_PhieuKiemNghiem)].OrderNumber;
            this.Items[this.IndexOf(_PhieuKiemNghiem)] = _PhieuKiemNghiem;
        }
        public void RemoveTo(PhieuKiemNghiem _PhieuKiemNghiem)
        {
            this.Items.Remove(_PhieuKiemNghiem);

        }

        private PhieuKiemNghiems()
        {
            /* Require use of factory methods */
        }
        #endregion


        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maKho;
            private String _MaDT;
            private DateTime _tuNgay;
            private DateTime _denNgay;
            private String _dieuKienThem;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            private Boolean _daDuyet;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }

            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }

            }
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            public String DieuKienThem
            {
                get
                {
                    return _dieuKienThem;
                }
            }
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
            public Boolean DaPhat
            {
                get
                {
                    return _daPhat;
                }
            }
            public Boolean DaDuyet
            {
                get
                {
                    return _daDuyet;
                }
            }
            public Criteria(Boolean qadmin, String MaDT, DateTime tungay, DateTime denngay, String dieukienthem, byte loaiphieu)
            {
                _qadmin = qadmin;
                _MaDT = MaDT;

                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
                _loaiPhieu = loaiphieu;

            }
        }
        #endregion

        #region CriteriaOther
        private class CriteriaOther
        {
            //
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuKiemNghiem(criteria.qadmin, criteria.MaDT,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.LoaiPhieu)))
            {
                int i = 1;
                while (dr.Read())
                {
                    PhieuKiemNghiem item = new PhieuKiemNghiem(
         i,
                                dr.GetString("MaKN"),
                                 dr.GetSmartDate("Ngaynhap", false),
                                 dr.GetSmartDate("NgayYCKN", false),

                                  dr.GetSmartDate("NgayKN", false),
                                   dr.GetSmartDate("NgayTraKN", false),
                                   dr.GetSmartDate("NgayGiao", false),
                                 dr.GetString("NoiNhap"),
                                  dr.GetString("solt"),
                                dr.GetString("soCT"),
                                   dr.GetString("NVKN"),
                                dr.GetString("tenNguoiKN"),
                                dr.GetString("NVgiao"),
                                dr.GetString("tenNguoigiao"),
                                   dr.GetString("NVlay"),
                                dr.GetString("tenNguoilay"),
                                   dr.GetString("NVtra"),
                                dr.GetString("tenNguoitra"),
                                   dr.GetString("NVnhan"),
                                dr.GetString("tenNguoinhan"),
                                dr.GetString("ghiChu"),
                                dr.GetBoolean("Huy"),
                                dr.GetSmartDate("NgaySD"),
                                dr.GetString("NguoiSD"),
                                dr.GetSmartDate("NgayLap"),
                                dr.GetString("NguoiLap"),
                                dr.GetSmartDate("NgayHuy"),
                                dr.GetString("NguoiHuy")

                                , dr.GetString("MaMay"),
                                dr.GetString("TenNoiNhap"),
                                dr.GetString("TenNguoiLap"),
                                dr.GetString("TenNguoiSD"),
                                dr.GetString("tenNguoiHuy"),
                                 dr.GetString("MaDT"),
                                dr.GetString("TenDT"),
                                dr.GetString("Mathuoc"),
                                dr.GetString("TenTM"),
                                dr.GetString("TenDVT"),
                                dr.GetDecimal("SoLuong"),

                                dr.GetSmartDate("HanSD"),
                                 dr.GetSmartDate("NgaySX"),
                                dr.GetString("SoLo"),
                                dr.GetString("KetQua"),


                                 dr.GetBoolean("KQ"),
                                 dr.GetString("YeuCauKN"),
                                 dr.GetSmartDate("NgayU"),
                                 dr.GetString("DangMau"),
                                 dr.GetString("DangKN"),
                                 dr.GetString("MaNCC"),
                                 dr.GetString("TenNCC"),
                                  dr.GetString("TenGoc")
                        );
                    this.Add(item);
                    i += 1;
                }
            }
            RaiseListChangedEvents = true;
        }
        #endregion
    }
}
