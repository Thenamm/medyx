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
    public class TBPhieuXuatList : BusinessListBase<TBPhieuXuatList, TBPhieuXuat >
    {
         #region Factory Methods
        public static TBPhieuXuatList GetAllTBPhieuXuat(String _maKho, byte _loai, Boolean _daphat, DateTime _tuNgay, DateTime _denNgay, String _dKien, Boolean _daduyet)
        {
            return DataPortal.Fetch<TBPhieuXuatList>(new Criteria(_maKho, _loai, _daphat, _tuNgay, _denNgay, _dKien, _daduyet));
        }
        public void NewTo(TBPhieuXuat _TBPhieuXuat)
        {
            _TBPhieuXuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TBPhieuXuat);
        }
        public TBPhieuXuat NewTo()
        {
             TBPhieuXuat obj = TBPhieuXuat.NewTBPhieuXuat ();
              return obj;
        }
        public void UpdatedTo(TBPhieuXuat _TBPhieuXuat)
        {

            _TBPhieuXuat.OrderNumber = this.Items[this.IndexOf(_TBPhieuXuat)].OrderNumber;
            this.Items[this.IndexOf(_TBPhieuXuat)] = _TBPhieuXuat;
        }
        public void RemoveTo(TBPhieuXuat _TBPhieuXuat)
        {
            this.Items.Remove(_TBPhieuXuat);

        }
        private TBPhieuXuatList()
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
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
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
            private bool  _daphat;
            public bool daphat
            {
                get
                {
                    return _daphat;
                }
            }
            private bool _daduyet;
            public bool daduyet
            {
                get
                {
                    return _daduyet;
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
            public Criteria(String maKho, byte loai, Boolean daphat, DateTime tuNgay, DateTime denNgay, String dKien, Boolean daduyet)
            {
                _makho = maKho;
                _loai  = loai ;
                _tungay = tuNgay;
                _denngay = denNgay;
                _dk = dKien;
                _daduyet = daduyet;
                _daphat = daphat;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBPhieuXuat(criteria.qadmin, criteria.makho,criteria.loai , criteria.daphat ,  criteria.tungay, criteria.denngay, criteria.dk, criteria.daduyet  )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben TBPhieuXuat vao phuong thuc (internal TBPhieuXuat)
                {
                    try 
                    {
                        TBPhieuXuat item = new TBPhieuXuat(
     i,
    dr.GetString("MaPX"),
			                                dr.GetString("Noixuat") ,
			                                dr.GetSmartDate("Ngayxuat", true) ,
			                                dr.GetSmartDate("NgayxuatTT", true) ,
			                                dr.GetString("Noinhap") ,
			                                dr.GetByte("Loaiphieu") ,
			                                dr.GetString("SoQD") ,
			                                dr.GetString("NVXuat") ,
			                                dr.GetString("NVNhan"),
			                                dr.GetString("ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD"),
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy"),
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("DaDuyet") ,
			                                dr.GetBoolean("DaPhat") ,
			                                dr.GetBoolean("NoiBo") , 
      dr.GetString("tenNoiXuat"),
      dr.GetString("tenNoiNhap") ,
      dr.GetString("tenNVXuat") ,
      dr.GetString("tenNguoiLap") ,
      dr.GetString("tenNguoiSD") ,
      dr.GetString("tenNguoiHuy"),
      dr.GetString("tenNguoiNhan") 
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
