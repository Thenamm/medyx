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
    public class ThongTinBN_TienSu_VoSinhList : BusinessListBase<ThongTinBN_TienSu_VoSinhList, ThongTinBN_TienSu_VoSinh>
    {
         
        #region Factory Methods
        public static ThongTinBN_TienSu_VoSinhList GetAllThongTinBN_TienSu_VoSinh(String dk)
        {
            return DataPortal.Fetch<ThongTinBN_TienSu_VoSinhList>(new Criteria(dk,false ));
        }
       
        public void NewTo(ThongTinBN_TienSu_VoSinh _ThongTinBN_TienSu_VoSinh)
        {
            _ThongTinBN_TienSu_VoSinh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_ThongTinBN_TienSu_VoSinh);
        }
        public ThongTinBN_TienSu_VoSinh NewTo()
        {
             ThongTinBN_TienSu_VoSinh obj = ThongTinBN_TienSu_VoSinh.NewThongTinBN_TienSu_VoSinh();
              return obj;
        }
        public void UpdatedTo(ThongTinBN_TienSu_VoSinh _ThongTinBN_TienSu_VoSinh)
        {

            _ThongTinBN_TienSu_VoSinh.OrderNumber = this.Items[this.IndexOf(_ThongTinBN_TienSu_VoSinh)].OrderNumber;
            this.Items[this.IndexOf(_ThongTinBN_TienSu_VoSinh)] = _ThongTinBN_TienSu_VoSinh;
        }
        public void RemoveTo(ThongTinBN_TienSu_VoSinh _ThongTinBN_TienSu_VoSinh)
        {
            this.Items.Remove(_ThongTinBN_TienSu_VoSinh);

        }
        private ThongTinBN_TienSu_VoSinhList()
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
            
           
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
           
            public Criteria(String dKien,Boolean qadmin)
            {
                _qadmin = qadmin;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongTinBN_TienSu_VoSinh(criteria.dk, criteria.qadmin)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        ThongTinBN_TienSu_VoSinh item = new ThongTinBN_TienSu_VoSinh(
     i,
     dr.GetString("MaBN") ,
			 dr.GetBoolean("cothaivs"),
           dr.GetString("cothaivsCT"),
            dr.GetBoolean("NhiemTrung"),
             dr.GetBoolean("BenhLayquaTD"),
               dr.GetString("ThoiGian"),
               dr.GetString("solan"),
            dr.GetString("DieuTri"),
              dr.GetString("trieuChung"),
            dr.GetBoolean("ChanThuongTH"),
            dr.GetString("ChanThuongTHCT"),
             dr.GetBoolean("DauTangSM"),
             dr.GetBoolean("ViemTH"),
            dr.GetBoolean("DanTM"),
            dr.GetString("DanTMCT"),
             dr.GetBoolean("THlacCho"),
            dr.GetBoolean("QuaiBi"),
            dr.GetBoolean("ThoatViBen"),
            dr.GetString("CacBoPhanSD"),
             dr.GetString("ThuocDaDung"),
           dr.GetBoolean("DungMatuy"),
            dr.GetString("DungMatuyCT"),
             dr.GetBoolean("DungRuouBia"),
             dr.GetString("DungRuouBiaCT"),
             dr.GetBoolean("DungThuocLa"),
            dr.GetString("DungThuocLaCT"),
           dr.GetBoolean("tiepxucDH"),
            dr.GetString("tiepxucDHCT"),
             dr.GetString("SolanQH"),
            dr.GetBoolean("SolanQHtuan"),
            dr.GetBoolean("XuatSom"),
            dr.GetBoolean("LietDuong"),
             dr.GetBoolean("GDcobenhDitruyen"),
            dr.GetBoolean("ChatDocDaCam"),
           dr.GetBoolean("CoMau"),
             dr.GetString("MauSac"),
            dr.GetString("QuanHeBT"),
            dr.GetString("TienSuNoiNgoaiKhoa"),
			dr.GetString("MaMay") ,
			dr.GetBoolean("Huy") ,
			dr.GetSmartDate("NgaySD", true),
			dr.GetString("NguoiSD") ,
			dr.GetSmartDate("NgaySD1", true) ,
			dr.GetString("NguoiSD1") ,
            dr.GetString("TenNguoiSD")
          
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