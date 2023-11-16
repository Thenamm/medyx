using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.NhanSu
{
    [Serializable()]
    public class HopDongList : BusinessListBase<HopDongList, HopDong>
    {
        #region Factory Methods

        public static HopDongList GetAllHopDong(DateTime tungay, DateTime denngay, String makhoa, String dieukienthem, Boolean qadmin)
        {
            return DataPortal.Fetch<HopDongList>(new Criteria(tungay ,denngay ,makhoa ,dieukienthem ,qadmin ));
        }

        //public static HopDongList GetAllHopDongByKhoa(string MaKhoa)
        //{
        //    return DataPortal.Fetch<HopDongList>(new CriteriaOther(3, MaKhoa));
        //}
        // tim theo dieu kien ten
        //public static HopDongList FindHopDongByTen(string HoTen)
        //{
        //    return DataPortal.Fetch<HopDongList>(new CriteriaOther(2, HoTen));
        //}

        //public static HopDongList FindHopDongByMa(string MaNV)
        //{
        //    return DataPortal.Fetch<HopDongList>(new CriteriaOther(1, MaNV));
        //}

        public void NewTo(HopDong _HopDong)
        {
            if (this.Count == 0)
                _HopDong.OrderNumber = 1;
            else
                _HopDong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HopDong);
        }
        public void UpdatedTo(HopDong _HopDong)
        {

            _HopDong.OrderNumber = this.Items[this.IndexOf(_HopDong)].OrderNumber;
            this.Items[this.IndexOf(_HopDong)] = _HopDong;
        }
        public void RemoveTo(HopDong _HopDong)
        {
            this.Items.Remove(_HopDong);


        }
        public HopDong Contains(string SoHD)
        {
            foreach (HopDong obj in this)
                if (obj.SoHD  == SoHD )
                    return obj;
            return null;
        }

        public HopDong GetTo(string soHD) //
        {
            foreach (HopDong obj in this)
                if (obj.SoHD  == soHD )
                    return obj;
            return null;

        }
        private HopDongList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            private String _maKhoa;
            private DateTime _tuNgay;
            private DateTime _denNgay;
            private String _dieuKienThem;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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

            public Criteria( DateTime tungay, DateTime denngay, String makhoa,String dieukienthem,Boolean qadmin)
            {
                _qadmin = qadmin;
                _maKhoa = makhoa;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }

        }
        #endregion
       

        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHopDong(criteria.TuNgay ,criteria.DenNgay , criteria.MaKhoa, criteria.DieuKienThem ,criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    HopDong item = new HopDong(
     i,
     dr.GetString("SoHD"),
     dr.GetString("MaNV"),
     dr.GetString("MaKhoa"),
     dr.GetSmartDate("NgayKy", true),
     dr.GetString("NguoiKy"),
     dr.GetString("MaLoaiHD"),
     dr.GetSmartDate("TuNgay", true),
     dr.GetSmartDate("DenNgay", true),
     dr.GetString("DiaDiem"),
     dr.GetString("MaChucVu"),
     dr.GetString("TenCongViec"),
     dr.GetDecimal("MucLuong"),
     dr.GetSmartDate("ThuViecTuNgay", true),
     dr.GetSmartDate("ThuViecDenNgay", true),
     dr.GetString("MaCheDoLV"),
     dr.GetString("ThoiGianLV"),
     dr.GetString("DungCu"),
     dr.GetString("SoNgayNghi"),
     dr.GetString("PhucLoi"),
     dr.GetString("GhiChu"),
      dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("LyDoHuy"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetString("TenKhoa"),
     dr.GetString("TenLoaiHD"),
     dr.GetString("TenCheDoLV"),
     dr.GetString("TenCV"),
     dr.GetString("HoTen"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy")
     
         );
                    this.Add(item);
                    i += 1;

                }

                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        #endregion
    }
}
