using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuNhapDTList : BusinessListBase<PhieuNhapDTList, PhieuNhapDT >
    {
         #region Factory Methods
        public static PhieuNhapDTList GetAllPhieuNhap(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<PhieuNhapDTList>(new Criteria(_qadmin, _maKho, _mNCC, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(PhieuNhapDT _PhieuNhap)
        {
            _PhieuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhieuNhap);
        }
        public PhieuNhapDT NewTo()
        {
             PhieuNhapDT obj = PhieuNhapDT.NewPhieuNhap ();
              return obj;
        }
        public void UpdatedTo(PhieuNhapDT _PhieuNhap)
        {

            _PhieuNhap.OrderNumber = this.Items[this.IndexOf(_PhieuNhap)].OrderNumber;
            this.Items[this.IndexOf(_PhieuNhap)] = _PhieuNhap;
        }
        public void RemoveTo(PhieuNhapDT _PhieuNhap)
        {
            this.Items.Remove(_PhieuNhap);

        }
        private PhieuNhapDTList()
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
         public abstract IDataReader GetPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, SmartDate _tuNgay, SmartDate _denNgay, String _dKien);
        public abstract IDataReader GetAllPhieuNhap_Get(String _maPhieuNhap);
        public abstract IDataReader GetPhieuNhap_C_GetAll(Boolean _qadmin, String _maPhieu);
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuNhap_GetAll(criteria.qadmin, criteria.makho, criteria.maNCC, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben PhieuNhapDT vao phuong thuc (internal PhieuNhapDT)
                {
                    try 
                    {
                        PhieuNhapDT item = new PhieuNhapDT(
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
     dr.GetString("sohdon"),
     dr.GetSmartDate("NgayhDon", false)
     ,dr.GetString("MaDT"), dr.GetString("TenDT") 
  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       //MessageBox.Show(ex.ToString());
                    }
                    
                }
                
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

      
        #endregion
    }
}
