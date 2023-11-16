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
    public class TBKiemKeList : BusinessListBase<TBKiemKeList, TBKiemKe >
    {
         #region Factory Methods
        public static TBKiemKeList GetAllTBKiemKe(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<TBKiemKeList>(new Criteria(_maKho, _tuNgay, _denNgay, _dKien));
        }
        public void NewTo(TBKiemKe _TBKiemKe)
        {
            _TBKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TBKiemKe);
        }
        public TBKiemKe NewTo()
        {
             TBKiemKe obj = TBKiemKe.NewTBKiemKe ();
              return obj;
        }
        public void UpdatedTo(TBKiemKe _TBKiemKe)
        {

            _TBKiemKe.OrderNumber = this.Items[this.IndexOf(_TBKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_TBKiemKe)] = _TBKiemKe;
        }
        public void RemoveTo(TBKiemKe _TBKiemKe)
        {
            this.Items.Remove(_TBKiemKe);

        }
        private TBKiemKeList()
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
            private String _maKho;
            public String Makho
            {
                get
                {
                    return _maKho;
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
            public Criteria(String Makho, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _maKho = Makho;
                _tungay = tuNgay;
                _denngay = denNgay;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBKiemKe(criteria.Makho, criteria.tungay, criteria.denngay, criteria.dk, criteria.qadmin   )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben TBKiemKe vao phuong thuc (internal TBKiemKe)
                {
                    try 
                    {
                        TBKiemKe item = new TBKiemKe(
     i,
     dr.GetString("MaKK") ,
			                                dr.GetSmartDate("NgayKK", true) ,
			                                dr.GetString("Makho") ,
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
     dr.GetString("TENKHO"),
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
