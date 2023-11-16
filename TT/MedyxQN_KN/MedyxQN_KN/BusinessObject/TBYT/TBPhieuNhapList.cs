using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 using System.Windows.Forms;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBPhieuNhapList : BusinessListBase<TBPhieuNhapList, TBPhieuNhap >
    {
         #region Factory Methods
        public static TBPhieuNhapList GetAllTBPhieuNhap(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<TBPhieuNhapList>(new Criteria(_qadmin, _maKho, _mNCC, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(TBPhieuNhap _TBPhieuNhap)
        {
            _TBPhieuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TBPhieuNhap);
        }
        public TBPhieuNhap NewTo()
        {
             TBPhieuNhap obj = TBPhieuNhap.NewTBPhieuNhap ();
              return obj;
        }
        public void UpdatedTo(TBPhieuNhap _TBPhieuNhap)
        {

            _TBPhieuNhap.OrderNumber = this.Items[this.IndexOf(_TBPhieuNhap)].OrderNumber;
            this.Items[this.IndexOf(_TBPhieuNhap)] = _TBPhieuNhap;
        }
        public void RemoveTo(TBPhieuNhap _TBPhieuNhap)
        {
            this.Items.Remove(_TBPhieuNhap);

        }
        private TBPhieuNhapList()
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
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBPhieuNhap(criteria.qadmin, criteria.makho, criteria.maNCC, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben TBPhieuNhap vao phuong thuc (internal TBPhieuNhap)
                {
                    try 
                    {
                        TBPhieuNhap item = new TBPhieuNhap(
     i,
     dr.GetString("MaPN") ,
			                                dr.GetString("MaNCC") ,
			                                dr.GetString("SoHD") ,
			                                dr.GetString("SoCT") ,
			                                dr.GetString("SoHDon") ,
			                                dr.GetString("Makho") ,
			                                dr.GetBoolean("Thanhtoan") ,
			                                dr.GetSmartDate("NgayTToan", true) ,
			                                dr.GetSmartDate("NgayNhapTT", true) ,
			                                dr.GetString("NVNhap") ,
			                                dr.GetDecimal("VAT") ,
			                                dr.GetDecimal("Tong") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetString("Nguoigiao") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
			                                dr.GetString("Nguoihuy") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetString("MaHinhThuc"),
			                                dr.GetString("MaNguon") ,
			                                dr.GetSmartDate("NgayHDon", true) ,
			                                dr.GetSmartDate("NgayPnhap", true) ,
     dr.GetString("TenNCC"),
     dr.GetString("TenKho"),
     dr.GetString("TENNVNHAP"),
     dr.GetString("TENNGUOILAP"),
     dr.GetString("TENNGUOISD"),
     dr.GetString("TENNGUOIHUY"), dr.GetDecimal("TONGTIEN") );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       throw ex;
                    }
                    
                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        #endregion
    }
}
