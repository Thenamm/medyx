using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuCheBiens : BusinessListBase<HCPhieuCheBiens,HCPhieuCheBien>
    {
        #region Business Methods
        public HCPhieuCheBien this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
         public static HCPhieuCheBiens GetAllHCPhieuCheBien(Boolean qadmin ,String makho,String MaDT,  DateTime tungay, DateTime denngay, String dieukienthem,Byte loaiphieu, Boolean daphat, Boolean daduyet)
        {
            return DataPortal.Fetch<HCPhieuCheBiens>(new Criteria(qadmin, makho, MaDT, tungay, denngay, dieukienthem, loaiphieu,daphat,daduyet));
        }
        public void NewTo(HCPhieuCheBien _HCPhieuCheBien)
        {
            _HCPhieuCheBien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HCPhieuCheBien);
        }
        public HCPhieuCheBien NewTo()
        {
            HCPhieuCheBien obj = HCPhieuCheBien.NewHCPhieuCheBien ();
            return obj;
        }
        //public void NewTo(HCPhieuCheBien _HCPhieuCheBien)
        //{
        //    _HCPhieuCheBien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
        //    this.Add(_HCPhieuCheBien);
        //}
        public void UpdatedTo(HCPhieuCheBien _HCPhieuCheBien)
        {
            _HCPhieuCheBien.OrderNumber = this.Items[this.IndexOf(_HCPhieuCheBien)].OrderNumber;
            this.Items[this.IndexOf(_HCPhieuCheBien)] = _HCPhieuCheBien;
        }
        public void RemoveTo(HCPhieuCheBien _HCPhieuCheBien)
        {
            this.Items.Remove(_HCPhieuCheBien);

        }

        private HCPhieuCheBiens()
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
            private DateTime _denNgay ;
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
            public Criteria(Boolean qadmin, String makho, String MaDT, DateTime tungay, DateTime denngay, String dieukienthem, Byte loaiphieu, Boolean daphat, Boolean daduyet)
            {
                _qadmin = qadmin;
                _maKho = makho;
                _MaDT = MaDT;
               
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
                      _loaiPhieu = loaiphieu;
                _daPhat = daphat;
                 _daDuyet = daduyet;
                
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCPhieuCheBien(criteria.qadmin, criteria.MaKho,criteria.MaDT ,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem,criteria.LoaiPhieu,criteria.DaPhat,criteria.DaDuyet)))
            {
                int i = 1;
                while (dr.Read())
                {
                HCPhieuCheBien item=new HCPhieuCheBien(
     i,
                            dr.GetString("MaCB"),
                             dr.GetString("NoiXuat"),
                              dr.GetSmartDate("NgayXuat", false),
                             dr.GetSmartDate("NgayXuatTT", false),
                               dr.GetSmartDate("NgayNhap", false),
                             dr.GetString("NoiNhap"),
                          
                            dr.GetString("soCT"),
                               dr.GetString("NVXuat"),
                            dr.GetString("NVNhan")
                            ,dr.GetString("ghiChu"),
                            dr.GetBoolean("Huy")
                            ,dr.GetSmartDate("NgaySD"),
                            dr.GetString("NguoiSD"),
                            dr.GetSmartDate("NgayLap"),
                            dr.GetString("NguoiLap"),
                            dr.GetSmartDate("NgayHuy"),
                            dr.GetString("NguoiHuy")

                            ,dr.GetString("MaMay"),
                             dr.GetString("TenNoiXuat"),
                            dr.GetString("TenNoiNhap"),
                            dr.GetString("TenNguoiLap"),
                            dr.GetString("TenNguoiSD"),
                            dr.GetString("tenNguoiHuy"),
                            dr.GetString("tenNguoiXuat"),
                            dr.GetString("tenNguoiNhan")
                            , dr.GetString("MaDT"),
                            dr.GetString("TenDT"),
                            dr.GetString("Mahc"),
                            dr.GetString("TenTM"),
                                dr.GetDecimal("Soluong"),
                        
                            dr.GetString("TenDVT"),
                            dr.GetSmartDate("HanSD"),
                            dr.GetString("SoLo"),
                            dr.GetDecimal("Dongia"),
                            dr.GetDecimal("GiaBan"),
                            dr.GetString("MaPHC"),
                            dr.GetString("MaPPL"),
                            dr.GetString("MaPBB"),
                            dr.GetDecimal("TIENPX"),
                            dr.GetDecimal("TIENHC"),
                            dr.GetDecimal("TienPL"),
                            dr.GetDecimal("TienBB"),
                            dr.GetDecimal("TONGTIEN"),
                    dr.GetDecimal ("TienCong"),
                    dr.GetDecimal ("DienNuoc"),
                    dr.GetDecimal ("TienKhac"),
                                  dr.GetDecimal ("Khoanthem"),
 dr.GetBoolean("DaPhat"),
   dr.GetBoolean("DaDuyet"),
   dr.GetByte("LoaiPhieu")
                    );
                this.Add(item);
                i +=1;
                }
            }
            RaiseListChangedEvents=true;
        }
        #endregion
    }
}
