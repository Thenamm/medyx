using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.NhanSu
{
    [Serializable()]
    public class NhanVienList : BusinessListBase<NhanVienList, NhanVien>
    {
        #region Factory Methods
        public static NhanVienList GetAllNhanVien()
        {
            return DataPortal.Fetch<NhanVienList>(new Criteria());
        }
        public static NhanVienList GetAllNhanVienByKhoa(string MaKhoa)
        {
            
            
                return DataPortal.Fetch<NhanVienList>(new CriteriaOther(3, MaKhoa));
         
        }
        public static NhanVienList GetAllNhanVienByKhoaLV(string MaKhoa)
        {


            return DataPortal.Fetch<NhanVienList>(new CriteriaOther(4, MaKhoa));

        }
        public static NhanVienList GetAllNhanVienByKhoaNV(string MaKhoa)
        {

            return DataPortal.Fetch<NhanVienList>(new CriteriaOther(5, MaKhoa));
         
        }
        // tim theo dieu kien ten
        public static NhanVienList FindNhanVienByTen(string HoTen)
        {
            return DataPortal.Fetch<NhanVienList>(new CriteriaOther(2,HoTen));
        }
       
        public static NhanVienList FindNhanVienByMa(string MaNV)
        {
            return DataPortal.Fetch<NhanVienList>(new CriteriaOther(1,MaNV));
        }
       
        public void NewTo(NhanVien _NhanVien)
        {
            if (this.Count == 0)
                _NhanVien.OrderNumber = 1;
            else
            _NhanVien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_NhanVien);
        }
        public void UpdatedTo(NhanVien _NhanVien)
        {

            _NhanVien.OrderNumber = this.Items[this.IndexOf(_NhanVien)].OrderNumber;
            this.Items[this.IndexOf(_NhanVien)] = _NhanVien;
        }
        public void RemoveTo(NhanVien _NhanVien)
        {
            this.Items.Remove(_NhanVien);
            //if (_NhanVien.IsNew == true)
            //    this.Items.Remove(_NhanVien);

            //else
            //    Remove(_NhanVien);

        }
        public NhanVien Contains(string MaNV)
        {
            foreach (NhanVien obj in this)
                if (obj.MaNV == MaNV)
                    return obj;
            return null;
        }

        public NhanVien GetTo(string manv) //
        {
            foreach (NhanVien obj in this)
                if (obj.MaNV == manv)
                    return obj;
            return null;

        }
        private NhanVienList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
           
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
           
        }
        #endregion
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = " and a.MaNV like '" + mDK + "%' ";
                else if  (mIdFind == 2) 
                        _DK = " and ltrim(rtrim(HoTen)) like N'" + mDK + "%'";
                    else if ((mIdFind == 3) && (mDK != "All"))
                        _DK = " and ltrim(rtrim(a.makhoa)) like N'" + mDK + "%'";
                    else if ((mIdFind == 4) && (mDK != "All"))
                        _DK = " and ltrim(rtrim(a.makhoa)) like N'" + mDK + "%' and isnull(a.matrangthai,'') in ('00001','00002')";
                    else if ((mIdFind == 4) && (mDK == "All"))
                        _DK = " and  isnull(a.matrangthai,'') in ('00001','00002')";
                    else if ((mIdFind == 5) && (mDK != "All"))
                        _DK = " and ltrim(rtrim(a.makhoa)) like N'" + mDK + "%' and isnull(a.matrangthai,'') not in ('00001','00002')";
                    else if ((mIdFind == 5) && (mDK == "All"))
                        _DK = " and  isnull(a.matrangthai,'') not in ('00001','00002')";
                //else if ((mIdFind == 3) && (mDK != "All")  )
                //        _DK = "ltrim(rtrim(A.MaNhomDV)) like N'" + mDK + "%'";
                //    else if (mIdFind == 4)
                //        _DK = "ltrim(rtrim(HoTen)) like N'" + mDK + "'";

            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    NhanVien item = new NhanVien(
     i,
     dr.GetString("MaNV") ,
			                                dr.GetString("Hoten"),
			                                dr.GetString("Hotenks") ,
			                                dr.GetBoolean("Gioitinh") ,
			                                dr.GetSmartDate("Ngaysinh", true) ,
			                                dr.GetString("DienThoai") ,
			                                dr.GetString("MaKhoa") ,
			                                dr.GetString("Noisinh") ,
			                                dr.GetString("Quequan") ,
			                                dr.GetString("Matongiao") ,
			                                dr.GetString("Madantoc") ,
			                                dr.GetString("ChooHT") ,
			                                dr.GetString("Thuongtru") ,
			                                dr.GetString("SoCMND"),
			                                dr.GetString("Noicap") ,
			                                dr.GetSmartDate("Ngaycap", true) ,
			                                dr.GetString("MaTPhanGD") ,
			                                dr.GetString("MaTPhanBT") ,
			                                dr.GetString("MaDienCSach") ,
			                                dr.GetString("SoBHXH") ,
			                                dr.GetBoolean("DongBHXH") ,
			                                dr.GetSmartDate("TuNgayCM", true) ,
			                                dr.GetSmartDate("DenNgayCM", true) ,
			                                dr.GetSmartDate("TuNgayCMy", true) ,
			                                dr.GetSmartDate("DenNgayCMy", true) ,
			                                dr.GetSmartDate("TuNgayBCK", true) ,
			                                dr.GetSmartDate("DenNgayBCK", true) ,
			                                dr.GetSmartDate("Ngaynhapngu", true) ,
			                                dr.GetSmartDate("Ngayxuatngu", true) ,
			                                dr.GetSmartDate("NgayVaoBChe", true) ,
			                                dr.GetSmartDate("TuNgayPV", true) ,
			                                dr.GetSmartDate("DenNgayPV", true) ,
			                                dr.GetSmartDate("TNXPhong", true) ,
			                                dr.GetSmartDate("DNXPhong", true) ,
			                                dr.GetSmartDate("TNDocHai", true) ,
			                                dr.GetSmartDate("DNDocHai", true) ,
			                                dr.GetSmartDate("TNKhac", true) ,
			                                dr.GetSmartDate("DNKhac", true) ,
			                                dr.GetString("MaChucDanh") ,
			                                dr.GetString("MaChucVu") ,
			                                dr.GetString("MaHocHam") ,
			                                dr.GetString("MaChuyenMon") ,
			                                dr.GetString("MaHocVan") ,
			                                dr.GetString("MaTDChinhTri") ,
			                                dr.GetString("MaTDNgoaiNgu"),
			                                dr.GetSmartDate("NgayDang", true) ,
			                                dr.GetString("NoiKNap") ,
			                                dr.GetString("NguoiGT") ,
			                                dr.GetSmartDate("NgayDoan", true) ,
			                                dr.GetSmartDate("NgayvaoCQ", true) ,
			                                dr.GetString("MaSuckhoe") ,
			                                dr.GetString("MaTrangthai") ,
			                                dr.GetSmartDate("Ngaynghiviec", true) ,
			                                dr.GetString("LydoNghi") ,
			                                (Byte[])dr.GetValue("Anh") ,
			                                dr.GetBoolean("TinhLuongHeso") ,
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
     dr.GetString("MaLoaiHD"),
			                                dr.GetString("MaNVQL") ,
     dr.GetString("TenNguoiSD") ,
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenKhoa"),
     dr.GetString("MaTDTinHoc"),
     dr.GetString("MaChuyenNganh"),
     dr.GetString("TenChuyenMon")
     , dr.GetString("TenCV")
     , dr.GetString("TenTonGiao")
     , dr.GetString("TenDanToc")
     , dr.GetString("TenTPhanGD")
     , dr.GetString("TenTPhanBT")
     , dr.GetString("TenHocVan"),
                    dr.GetString("TenHocHam"),
                    dr.GetString("TenTDChinhTri"),
                    dr.GetString("TenTDTinHoc")
                    ,dr.GetString("TenChuyenNganh"),dr.GetString("TenCD"), dr.GetString("TenSucKhoe"), dr.GetString("TenDienCSach")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien(criteria.DK,criteria.qadmin)))         
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    NhanVien item = new NhanVien(
     i,
     dr.GetString("MaNV"),
     dr.GetString("Hoten"),
     dr.GetString("Hotenks"),
     dr.GetBoolean("Gioitinh"),
     dr.GetSmartDate("Ngaysinh", true),
     dr.GetString("DienThoai"),
     dr.GetString("MaKhoa"),
     dr.GetString("Noisinh"),
     dr.GetString("Quequan"),
     dr.GetString("Matongiao"),
     dr.GetString("Madantoc"),
     dr.GetString("ChooHT"),
     dr.GetString("Thuongtru"),
     dr.GetString("SoCMND"),
     dr.GetString("Noicap"),
     dr.GetSmartDate("Ngaycap", true),
     dr.GetString("MaTPhanGD"),
     dr.GetString("MaTPhanBT"),
     dr.GetString("MaDienCSach"),
     dr.GetString("SoBHXH"),
     dr.GetBoolean("DongBHXH"),
     dr.GetSmartDate("TuNgayCM", true),
     dr.GetSmartDate("DenNgayCM", true),
     dr.GetSmartDate("TuNgayCMy", true),
     dr.GetSmartDate("DenNgayCMy", true),
     dr.GetSmartDate("TuNgayBCK", true),
     dr.GetSmartDate("DenNgayBCK", true),
     dr.GetSmartDate("Ngaynhapngu", true),
     dr.GetSmartDate("Ngayxuatngu", true),
     dr.GetSmartDate("NgayVaoBChe", true),
     dr.GetSmartDate("TuNgayPV", true),
     dr.GetSmartDate("DenNgayPV", true),
     dr.GetSmartDate("TNXPhong", true),
     dr.GetSmartDate("DNXPhong", true),
     dr.GetSmartDate("TNDocHai", true),
     dr.GetSmartDate("DNDocHai", true),
     dr.GetSmartDate("TNKhac", true),
     dr.GetSmartDate("DNKhac", true),
     dr.GetString("MaChucDanh"),
     dr.GetString("MaChucVu"),
     dr.GetString("MaHocHam"),
     dr.GetString("MaChuyenMon"),
     dr.GetString("MaHocVan"),
     dr.GetString("MaTDChinhTri"),
     dr.GetString("MaTDNgoaiNgu"),
     dr.GetSmartDate("NgayDang", true),
     dr.GetString("NoiKNap"),
     dr.GetString("NguoiGT"),
     dr.GetSmartDate("NgayDoan", true),
     dr.GetSmartDate("NgayvaoCQ", true),
     dr.GetString("MaSuckhoe"),
     dr.GetString("MaTrangthai"),
     dr.GetSmartDate("Ngaynghiviec", true),
     dr.GetString("LydoNghi"),
     (Byte[])dr.GetValue("Anh"),
     dr.GetBoolean("TinhLuongHeso"),
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
     dr.GetString("MaLoaiHD"),
     dr.GetString("MaNVQL"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenKhoa"),
     dr.GetString("MaTDTinHoc"),
     dr.GetString("MaChuyenNganh"),
     dr.GetString("TenChuyenMon")
     , dr.GetString("TenCV")
     , dr.GetString("TenTonGiao")
     , dr.GetString("TenDanToc")
     , dr.GetString("TenTPhanGD")
     , dr.GetString("TenTPhanBT")
     , dr.GetString("TenHocVan"),
                    dr.GetString("TenHocHam"),
                    dr.GetString("TenTDChinhTri"),
                    dr.GetString("TenTDTinHoc")
                    , dr.GetString("TenChuyenNganh"), dr.GetString("TenCD"), dr.GetString("TenSucKhoe"), dr.GetString("TenDienCSach")
     ); 
      this.Add(item);
 i += 1;

                }
                //if (this.Count == 0)
                //{
                //   //MessageBox.Show("Không tồn tại dịch vụ này, bạn hãy chọn dịch vụ khác!","Thong bao",MessageBoxIcon.Information );
                //}
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
