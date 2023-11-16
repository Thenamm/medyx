using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_ChuyenMonList : BusinessListBase<BC_ChuyenMonList, BC_ChuyenMon >
    {
         
         #region Factory Methods
        public static BC_ChuyenMonList GetAllBC_ChuyenMon(DateTime _tuNgay, DateTime _denNgay, String _maKhoa,  String _dKien)
        {
            return DataPortal.Fetch<BC_ChuyenMonList>(new Criteria( _tuNgay, _denNgay, _maKhoa, _dKien));
        }
        public void NewTo(BC_ChuyenMon _BC_ChuyenMon)
        {
            _BC_ChuyenMon.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BC_ChuyenMon);
        }
        public BC_ChuyenMon NewTo()
        {
             BC_ChuyenMon obj = BC_ChuyenMon.NewBC_ChuyenMon ();
              return obj;
        }
        public void UpdatedTo(BC_ChuyenMon _BC_ChuyenMon)
        {

            _BC_ChuyenMon.OrderNumber = this.Items[this.IndexOf(_BC_ChuyenMon)].OrderNumber;
            this.Items[this.IndexOf(_BC_ChuyenMon)] = _BC_ChuyenMon;
        }
        public void RemoveTo(BC_ChuyenMon _BC_ChuyenMon)
        {
            this.Items.Remove(_BC_ChuyenMon);

        }
        private BC_ChuyenMonList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
          
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            private DateTime _tungay;
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
            public Criteria( DateTime tuNgay, DateTime denNgay,String maKhoa, String dKien )
            {
                _qadmin = HTC.ShareVariables.pub_bQadmin  ;
                _makhoa = maKhoa;
                _dk = dKien ;
                _tungay = tuNgay;
                _denngay = denNgay;
            }
        }
        #endregion
    

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMon(criteria.tungay, criteria.denngay, criteria.makhoa, criteria.dk, criteria.qadmin)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
                {
                    try 
                    {
                        BC_ChuyenMon item = new BC_ChuyenMon(
     i,
    dr.GetString("MaKhoa"),
 dr.GetSmartDate("Thang", false),
 dr.GetDecimal("TTCcuu"),
 dr.GetDecimal("TTLoai1"),
 dr.GetDecimal("TTLoai2"),
 dr.GetDecimal("TTLoai3"),
 dr.GetDecimal("TTTruyenHC"),
 dr.GetDecimal("TongBNDTHC"),
 dr.GetDecimal("TongNgayDTHC"),
 dr.GetDecimal("TongBNDTNoiT"),
 dr.GetDecimal("TongNgayDTNoiT"),
 dr.GetDecimal("NgaySDung"),
 dr.GetDecimal("NgayDTTB"),
 dr.GetDecimal("GiuongBenhTH"),
 dr.GetDecimal("CongsuatSD"),
 dr.GetDecimal("TongBNNgoaitinhVV"),
 dr.GetDecimal("TongBNNgoaitinhVVBH"),
 dr.GetDecimal("TongBNNgoaitinhVVND"),
 dr.GetDecimal("TongNgayBNNgoaiT"),
 dr.GetString("DacBiet"),
 dr.GetDecimal("PTLoaiDB"),
 dr.GetDecimal("PTLoai1A"),
 dr.GetDecimal("PTLoai1B"),
 dr.GetDecimal("PTLoai1C"),
 dr.GetDecimal("PTLoai2A"),
 dr.GetDecimal("PTLoai2B"),
 dr.GetDecimal("PTLoai2C"),
 dr.GetDecimal("PTLoai3"),
 dr.GetDecimal("PTNgoaiTinh"),
 dr.GetDecimal("PTTuVong"),
 dr.GetDecimal("PTTaiBien"),
 dr.GetDecimal("PTTPPhongK"),
 dr.GetDecimal("TTSoiCTC"),
 dr.GetDecimal("TTSoiTMH"),
 dr.GetDecimal("TTBamST"),
 dr.GetDecimal("TTSoiDDDT"),

 dr.GetBoolean("Huy"),
  dr.GetSmartDate("ngaySD", false),
  dr.GetString("nguoiSD"),

  dr.GetString("maMay"),

  dr.GetString("tenNguoiSD"),
 dr.GetDecimal("saisotchuyenmon"),
 dr.GetDecimal("phanungcohai")
  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       
                        //MessageBox.Show(ex.ToString());
                    }
                    
                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        //private void DataPortal_Fetch(CriteriaOther criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_BC(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMDichVu_BC item = new DMDichVu_BC(
        // i,
        // dr.GetString("MaBC"),
        // dr.GetString("TenBC"),
        // dr.GetByte("Loai"),
        // dr.GetString("Ghichu"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetSmartDate("NgayHuy"),
        // dr.GetString("NguoiHuy"),
        // dr.GetSmartDate("NgayLap"),
        // dr.GetString("NguoiLap"),
        // dr.GetSmartDate("NgaySD", false),
        // dr.GetString("NguoiSD"),
        // dr.GetString("TenNguoiLap"),
        // dr.GetString("TenNguoiSD"),
        // dr.GetString("TenNguoiHuy")
        // );

        //            this.Add(item);
        //            i += 1;
        //        }
        //        //IsReadOnly = true;
        //    }

        /*
           i,
     dr.GetString("MaPN") ,
     dr.GetString("MaNCC") ,
     dr.GetString("SoHD"), 
     dr.GetString("SoCT") ,
     dr.GetSmartDate("NgayPnhap", false),
     dr.GetString("MaKho"),
     dr.GetInt32("VAT"),
     dr.GetBoolean("ThanhToan") ,
     dr.GetSmartDate("NgayTToan", false),
     dr.GetSmartDate("NgayNhapTT",false),
     dr.GetString("NVNhap"),
     dr.GetInt32("Tong"),
     dr.GetString("Ghichu"),
     dr.GetBoolean("Huy"),

     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD1"),
     dr.GetSmartDate("NgayLap", false),
     dr.GetString("NguoiGiao"),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy",false),
     dr.GetString("NguoiHuy"),
     dr.GetString("MaMay"),
     dr.GetString("TENNCC"),
     dr.GetString("TENKHO"),
     dr.GetString("TENNVNHAP"),
     dr.GetString("TENNGUOILAP"),
     dr.GetString("TENNGUOISD"),
     dr.GetString("TENNGUOIHUY")

         */
        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        #endregion
    }
}
