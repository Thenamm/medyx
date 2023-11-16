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
    public class TBNhapTraList : BusinessListBase<TBNhapTraList, TBNhapTra >
    {
         #region Factory Methods
        public static TBNhapTraList GetAllTBNhapTra(String _maKho, byte _loai, byte _daphat, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<TBNhapTraList>(new Criteria(_maKho, _loai,_daphat,_tuNgay, _denNgay, _dKien));
        }
        public void NewTo(TBNhapTra _TBNhapTra)
        {
            _TBNhapTra.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TBNhapTra);
        }
        public TBNhapTra NewTo()
        {
             TBNhapTra obj = TBNhapTra.NewTBNhapTra ();
              return obj;
        }
        public void UpdatedTo(TBNhapTra _TBNhapTra)
        {

            _TBNhapTra.OrderNumber = this.Items[this.IndexOf(_TBNhapTra)].OrderNumber;
            this.Items[this.IndexOf(_TBNhapTra)] = _TBNhapTra;
        }
        public void RemoveTo(TBNhapTra _TBNhapTra)
        {
            this.Items.Remove(_TBNhapTra);

        }
        private TBNhapTraList()
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
            private byte _daphat;
            public byte daphat
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
            public Criteria(String maKho, byte loai, byte daphat, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _makho = maKho;
                _loai  = loai ;
                _daphat = daphat;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBNhapTra(criteria.qadmin, criteria.makho,criteria.loai ,criteria.daphat, criteria.tungay, criteria.denngay, criteria.dk  )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben TBNhapTra vao phuong thuc (internal TBNhapTra)
                {
                    try 
                    {
                        TBNhapTra item = new TBNhapTra(
     i,
    dr.GetString("MaPNT"),
			                                dr.GetString("Noixuat") ,
			                                dr.GetSmartDate("NgayNhap", true) ,
			                                dr.GetSmartDate("NgayNhapTT", true) ,
                                             dr.GetSmartDate("NGAYXUATTT", true),
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
			                    
      dr.GetString("tenNoiXuat"),
      dr.GetString("tenNoiNhap") ,
      dr.GetString("tenNVXuat") ,
      dr.GetString("tenNguoiLap") ,
      dr.GetString("tenNguoiSD") ,
      dr.GetString("tenNguoiHuy"),
      dr.GetString("tenNguoiNhan"), 
      dr.GetString("MaPX")
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
