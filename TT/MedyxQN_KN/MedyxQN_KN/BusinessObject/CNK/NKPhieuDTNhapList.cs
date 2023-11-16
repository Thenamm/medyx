using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;
using Csla.Data;
//using System.Windows.Forms;

namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKPhieuDTNhapList : BusinessListBase<NKPhieuDTNhapList, NKPhieuDTNhap >
    {
         #region Factory Methods
        public static NKPhieuDTNhapList GetAllNKPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<NKPhieuDTNhapList>(new Criteria(_qadmin, _maKho, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(NKPhieuDTNhap _NKPhieuDTNhap)
        {
            if (this.Count == 0)
                _NKPhieuDTNhap.OrderNumber = 1;
            else
            _NKPhieuDTNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_NKPhieuDTNhap);
        }
        public NKPhieuDTNhap NewTo()
        {
             NKPhieuDTNhap obj = NKPhieuDTNhap.NewNKPhieuDTNhap ();
              return obj;
        }
        public void UpdatedTo(NKPhieuDTNhap _NKPhieuDTNhap)
        {

            _NKPhieuDTNhap.OrderNumber = this.Items[this.IndexOf(_NKPhieuDTNhap)].OrderNumber;
            this.Items[this.IndexOf(_NKPhieuDTNhap)] = _NKPhieuDTNhap;
        }
        public void RemoveTo(NKPhieuDTNhap _NKPhieuDTNhap)
        {
            this.Items.Remove(_NKPhieuDTNhap);

        }
        private NKPhieuDTNhapList()
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
            public Criteria(Boolean qadmin, String maKho, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _qadmin = qadmin;
                _makho = maKho;
                _tungay = tuNgay;
                _denngay = denNgay;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKPhieuDTNhap(criteria.qadmin, criteria.makho, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        NKPhieuDTNhap item = new NKPhieuDTNhap(
     i,
     dr.GetString("MaDuTru") ,
      dr.GetString("MaKhoa"),
      dr.GetString("TenKhoa"),
			                                dr.GetString("SoCT"),
			                                dr.GetSmartDate("NgayPhieu", true),
     dr.GetSmartDate("NgayPhieu", true),
			                                dr.GetString("Makho") ,
			                                dr.GetString("NguoiDuTru") ,
			                                dr.GetDecimal("Tong") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetSmartDate("NgaySD", true),
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetString("MaMay") ,
     dr.GetString("TenKho"),
     dr.GetString("TenNguoiDT"),
     dr.GetString("TENNGUOILAP"),
     dr.GetString("TENNGUOISD"),
     dr.GetString("TENNGUOIHUY")
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
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        #endregion
    }
}
