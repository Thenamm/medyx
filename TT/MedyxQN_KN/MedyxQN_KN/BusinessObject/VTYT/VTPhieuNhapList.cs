using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuNhapList : BusinessListBase<VTPhieuNhapList, VTPhieuNhap >
    {
         #region Factory Methods
        public static VTPhieuNhapList GetAllVTPhieuNhap(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<VTPhieuNhapList>(new Criteria(_qadmin, _maKho, _mNCC, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(VTPhieuNhap _VTPhieuNhap)
        {
            if (this.Count == 0)
                _VTPhieuNhap.OrderNumber = 1;
            else
            _VTPhieuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VTPhieuNhap);
        }
        public VTPhieuNhap NewTo()
        {
             VTPhieuNhap obj = VTPhieuNhap.NewVTPhieuNhap ();
              return obj;
        }
        public void UpdatedTo(VTPhieuNhap _VTPhieuNhap)
        {

            _VTPhieuNhap.OrderNumber = this.Items[this.IndexOf(_VTPhieuNhap)].OrderNumber;
            this.Items[this.IndexOf(_VTPhieuNhap)] = _VTPhieuNhap;
        }
        public void RemoveTo(VTPhieuNhap _VTPhieuNhap)
        {
            this.Items.Remove(_VTPhieuNhap);

        }
        private VTPhieuNhapList()
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
            private String _makho;
            public String makho
            {
                get
                {
                    return _makho;
                }
            }
            private String _maNCC;
            public String maNCC
            {
                get
                {
                    return _maNCC;
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
            public Criteria(Boolean qadmin, String maKho, String mNCC, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _qadmin = qadmin;
                _makho = maKho;
                _maNCC = mNCC;
                _tungay = tuNgay;
                _denngay = denNgay;
                _dk = dKien;
            }
        }
        #endregion
        /*
         public abstract IDataReader GetVTPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, SmartDate _tuNgay, SmartDate _denNgay, String _dKien);
        public abstract IDataReader GetAllVTPhieuNhap_Get(String _maVTPhieuNhap);
        public abstract IDataReader GetVTPhieuNhap_C_GetAll(Boolean _qadmin, String _maPhieu);
         */

        // tim kiem theo ten
        //#region CriteriaOther
        //[Serializable()]
        //private class CriteriaOther
        //{
        //    //private int _id;
        //    //public int Id
        //    //{
        //    //    get
        //    //    {
        //    //        return _id;
        //    //    }
        //    //}
        //    private Byte _IdFind;
        //    public Byte IdFind
        //    {
        //        get
        //        {
        //            return _IdFind;
        //        }
        //    }
        //    private string _DK;
        //    public string DK
        //    {
        //        get
        //        {
        //            return _DK;
        //        }
        //    }

        //     private Boolean _qadmin = false ;
        //    public bool qadmin
        //    {
        //        get
        //        {
        //            return _qadmin;
        //        }
        //    }
        //    //public Criteria(Boolean mqadmin)
        //    //{

        //    //    _qadmin = mqadmin;
        //    //}
        //    public CriteriaOther(Byte mIdFind, String mDK)
        //    {

        //        _IdFind = mIdFind;
        //        if (mIdFind == 1)
        //            _DK = "MaPN like '%" + mDK + "'";
        //        else if (mIdFind == 2)
        //            _DK = "ltrim(rtrim(TenBC)) like N'" + mDK + "%'";


        //    }
        //}
        //#endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVTPhieuNhap_GetAll(criteria.qadmin, criteria.makho, criteria.maNCC, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben VTPhieuNhap vao phuong thuc (internal VTPhieuNhap)
                {
                    try 
                    {
                        VTPhieuNhap item = new VTPhieuNhap(
     i,
     dr.GetString("MaPN") ,
     dr.GetString("MaNCC") ,    
     dr.GetString("SoCT") ,
     dr.GetString("SoHD"), 
     dr.GetSmartDate("NgayPnhap", false),
     dr.GetString("MaKho"),
     dr.GetBoolean("ThanhToan"),
     dr.GetSmartDate("NgayTToan", false),
     dr.GetSmartDate("NgayNhapTT", false),
     dr.GetString("NVNhap"),
     dr.GetDecimal("VAT"),
     dr.GetDecimal("Tong"),
     dr.GetString("Ghichu"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD1"),
     dr.GetString("NguoiGiao"),
     dr.GetSmartDate("NgayLap", false),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy", false),
     dr.GetString("NguoiHuy"),
     dr.GetString("MaMay"),
     dr.GetString("TenNCC"),
     dr.GetString("TenKho"),
     dr.GetString("TENNVNHAP"),
     dr.GetString("TENNGUOILAP"),
     dr.GetString("TENNGUOISD"),
     dr.GetString("TENNGUOIHUY"),
     dr.GetSmartDate("NgayNhapTT", false),
     dr.GetString("SoHDon")
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
