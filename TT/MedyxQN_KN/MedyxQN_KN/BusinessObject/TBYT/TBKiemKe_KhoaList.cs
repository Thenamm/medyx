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
    public class TBKiemKe_KhoaList : BusinessListBase<TBKiemKe_KhoaList, TBKiemKe_Khoa >
    {
         #region Factory Methods
        public static TBKiemKe_KhoaList GetAllTBKiemKe_Khoa(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<TBKiemKe_KhoaList>(new Criteria(_maKhoa, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(TBKiemKe_Khoa _TBKiemKe_Khoa)
        {
            _TBKiemKe_Khoa.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TBKiemKe_Khoa);
        }
        public TBKiemKe_Khoa NewTo()
        {
             TBKiemKe_Khoa obj = TBKiemKe_Khoa.NewTBKiemKe_Khoa ();
              return obj;
        }
        public void UpdatedTo(TBKiemKe_Khoa _TBKiemKe_Khoa)
        {

            _TBKiemKe_Khoa.OrderNumber = this.Items[this.IndexOf(_TBKiemKe_Khoa)].OrderNumber;
            this.Items[this.IndexOf(_TBKiemKe_Khoa)] = _TBKiemKe_Khoa;
        }
        public void RemoveTo(TBKiemKe_Khoa _TBKiemKe_Khoa)
        {
            this.Items.Remove(_TBKiemKe_Khoa);

        }
        private TBKiemKe_KhoaList()
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
            public Criteria(String maKhoa, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _makhoa = maKhoa;
                _tungay = tuNgay;
                _denngay = denNgay;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBKiemKe_Khoa(criteria.makhoa, criteria.tungay, criteria.denngay, criteria.dk, criteria.qadmin   )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben TBKiemKe_Khoa vao phuong thuc (internal TBKiemKe_Khoa)
                {
                    try 
                    {
                        TBKiemKe_Khoa item = new TBKiemKe_Khoa(
     i,
     dr.GetString("MaKK") ,
			                                dr.GetSmartDate("NgayKK", true) ,
			                                dr.GetString("Makhoa") ,
			                                dr.GetString("NguoiKK") ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("Ngaylap", true) ,
			                                dr.GetString("GhiChu") ,
			                                dr.GetBoolean("Xuly") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
			                                dr.GetString("Nguoihuy") ,
			                                dr.GetBoolean("Huy") ,
     dr.GetString("TenKhoa"),
     dr.GetString("TenNVKK"),
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
