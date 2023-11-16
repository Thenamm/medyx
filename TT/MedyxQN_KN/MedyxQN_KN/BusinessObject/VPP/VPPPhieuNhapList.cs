using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPPhieuNhapList : BusinessListBase<VPPPhieuNhapList, VPPPhieuNhap >
    {
         #region Factory Methods
        public static VPPPhieuNhapList GetAllVPPPhieuNhap(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<VPPPhieuNhapList>(new Criteria(_qadmin, _maKho, _mNCC, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(VPPPhieuNhap _VPPPhieuNhap)
        {
            if (this.Count == 0)
                _VPPPhieuNhap.OrderNumber = 1;
            else
            _VPPPhieuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VPPPhieuNhap);
        }
        public VPPPhieuNhap NewTo()
        {
             VPPPhieuNhap obj = VPPPhieuNhap.NewVPPPhieuNhap ();
              return obj;
        }
        public void UpdatedTo(VPPPhieuNhap _VPPPhieuNhap)
        {

            _VPPPhieuNhap.OrderNumber = this.Items[this.IndexOf(_VPPPhieuNhap)].OrderNumber;
            this.Items[this.IndexOf(_VPPPhieuNhap)] = _VPPPhieuNhap;
        }
        public void RemoveTo(VPPPhieuNhap _VPPPhieuNhap)
        {
            this.Items.Remove(_VPPPhieuNhap);

        }
        private VPPPhieuNhapList()
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
         public abstract IDataReader GetVPPPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, SmartDate _tuNgay, SmartDate _denNgay, String _dKien);
        public abstract IDataReader GetAllVPPPhieuNhap_Get(String _maVPPPhieuNhap);
        public abstract IDataReader GetVPPPhieuNhap_C_GetAll(Boolean _qadmin, String _maPhieu);
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVPPPhieuNhap_GetAll(criteria.qadmin, criteria.makho, criteria.maNCC, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben VPPPhieuNhap vao phuong thuc (internal VPPPhieuNhap)
                {
                    try 
                    {
                        VPPPhieuNhap item = new VPPPhieuNhap(
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
