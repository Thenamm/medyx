using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuDTNhapList : BusinessListBase<VTPhieuDTNhapList, VTPhieuDTNhap >
    {
         #region Factory Methods
        public static VTPhieuDTNhapList GetAllVTPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<VTPhieuDTNhapList>(new Criteria(_qadmin, _maKho, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(VTPhieuDTNhap _VTPhieuDTNhap)
        {
            if (this.Count == 0)
                _VTPhieuDTNhap.OrderNumber = 1;
            else
            _VTPhieuDTNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VTPhieuDTNhap);
        }
        public VTPhieuDTNhap NewTo()
        {
             VTPhieuDTNhap obj = VTPhieuDTNhap.NewVTPhieuDTNhap ();
              return obj;
        }
        public void UpdatedTo(VTPhieuDTNhap _VTPhieuDTNhap)
        {

            _VTPhieuDTNhap.OrderNumber = this.Items[this.IndexOf(_VTPhieuDTNhap)].OrderNumber;
            this.Items[this.IndexOf(_VTPhieuDTNhap)] = _VTPhieuDTNhap;
        }
        public void RemoveTo(VTPhieuDTNhap _VTPhieuDTNhap)
        {
            this.Items.Remove(_VTPhieuDTNhap);

        }
        private VTPhieuDTNhapList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTPhieuDTNhap(criteria.qadmin, criteria.makho, criteria.tungay, criteria.denngay, criteria.dk)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        VTPhieuDTNhap item = new VTPhieuDTNhap(
     i,
     dr.GetString("MaDuTru") ,
      dr.GetString("MaNCC"),
      dr.GetString("TenNCC"),
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
