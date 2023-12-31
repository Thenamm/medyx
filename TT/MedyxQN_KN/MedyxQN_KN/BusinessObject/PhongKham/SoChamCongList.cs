using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
 //using System.Windows.Forms;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class SoChamCongList : BusinessListBase<SoChamCongList, SoChamCong>
    {
        #region Factory Methods
        public static SoChamCongList GetAllSoChamCong(Boolean _qadmin, String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dKien)
        {
            return DataPortal.Fetch<SoChamCongList>(new Criteria( _qadmin,  _maKhoa,  _tuNgay,  _denNgay,  _dKien ));
        }
        //public static SoChamCongList GetAllBenhAn_ThuThuat(String _maSCC)
        //{
           //return DataPortal.Fetch<SoChamCongList>(new Criteria(_maSCC, " and a.machungloai ='00012'",false ));
        //}
        public void NewTo(SoChamCong _SoChamCong)
        {
            _SoChamCong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_SoChamCong);
        }
        public SoChamCong NewTo()
        {
             SoChamCong obj = SoChamCong.NewSoChamCong();
              return obj;
        }
        public void UpdatedTo(SoChamCong _SoChamCong)
        {

            _SoChamCong.OrderNumber = this.Items[this.IndexOf(_SoChamCong)].OrderNumber;
            this.Items[this.IndexOf(_SoChamCong)] = _SoChamCong;
        }
        public void RemoveTo(SoChamCong _SoChamCong)
        {
            this.Items.Remove(_SoChamCong);

        }
        private SoChamCongList()
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
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa ;
                }
            }
            private DateTime _tuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
            }
            private DateTime _denNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay ;
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

            public Criteria(Boolean qadmin, String maKhoa, DateTime tuNgay, DateTime denNgay, String dKien)
            {
                _qadmin = qadmin;          
                _dk = dKien;
                _maKhoa= maKhoa;
                _tuNgay=tuNgay;
                _denNgay=denNgay;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            //Boolean _qadmin,String _maKhoa, SmartDate _tuNgay, SmartDate _denNgay,  String _dKien
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllSoChamCong(criteria .qadmin ,criteria .MaKhoa ,criteria .TuNgay ,criteria .DenNgay ,criteria.dk  )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        SoChamCong item = new SoChamCong(
     i,
      dr.GetString("MaSCC") ,
			                                 dr.GetSmartDate("NgayKham", true) ,
			                                 dr.GetString("MaPhong"),
			                                 dr.GetDecimal("NgayNgoaiTru") ,
			                                 dr.GetDecimal("NguoiNgoaiTru") ,
			                                 dr.GetDecimal("SoCaSang")  ,
			                                 dr.GetDecimal("SoCaChieu") ,
			                                 dr.GetDecimal("Holter")  ,
			                                 dr.GetDecimal("HuyetAp")  ,
			                                 dr.GetString("BacSy")  ,
			                                 dr.GetString("DieuDuong")  ,
			                                 dr.GetString("ghichu")  ,
			                                 dr.GetBoolean("Huy") ,
			                                 dr.GetSmartDate("NgayLap", true) ,
			                                 dr.GetString("NguoiLap") ,
			                                 dr.GetSmartDate("NgayHuy", true) ,
			                                 dr.GetString("NguoiHuy")  ,
			                                 dr.GetSmartDate("NgaySD", true)  ,
			                                 dr.GetString("NguoiSD")  ,
			                                 dr.GetSmartDate("NgaySD1", true),
			                                 dr.GetString("NguoiSD1") ,
      dr.GetString ("TenKhoa"),
			                                 dr.GetString("MaMay") 
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