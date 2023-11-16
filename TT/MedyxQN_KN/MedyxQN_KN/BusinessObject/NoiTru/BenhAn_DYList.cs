using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_DYList : BusinessListBase<BenhAn_DYList, BenhAn_DY>
    {
        #region Factory Methods
        public static BenhAn_DYList GetAllBenhAn_DY(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_DYList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_DY _BenhAn_DY)
        {
            if (this.Count == 0)
                _BenhAn_DY.OrderNumber = 1;
            else
            _BenhAn_DY.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_DY);
        }
        public void UpdatedTo(BenhAn_DY _BenhAn_DY)
        {

            _BenhAn_DY.OrderNumber = this.Items[this.IndexOf(_BenhAn_DY)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_DY)] = _BenhAn_DY;
        }
        public void RemoveTo(BenhAn_DY _BenhAn_DY)
        {
            this.Items.Remove(_BenhAn_DY);

        }

        private BenhAn_DYList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            
            private Byte _STTKhoa;
            public Byte STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(string maBA, Byte STTKhoa)
            {
               
                _STTKhoa = STTKhoa ;
                _maBA = maBA;
             
                
                
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DY(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_DY item = new BenhAn_DY(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			 dr.GetSmartDate("NgayKham", true) ,
			 dr.GetString("BSKHAM") ,
              dr.GetString("HinhThai"),
          dr.GetString("Than"),
          dr.GetString("Sac"),
          dr.GetString("Trach"),
          dr.GetString("ChatLuoi"),
          dr.GetString("Sacluoi"),
          dr.GetString("ReuLuoi"),
          dr.GetString("KhacVongChan"),
          dr.GetString("MotaVongChan"),
          dr.GetString("Giongnoi"),
          dr.GetString("HoiTho"),
         dr.GetBoolean("CoHo"),
          dr.GetString("Ho"),
         dr.GetBoolean("OAmThanh"),
         dr.GetBoolean("NacAmThanh"),
         dr.GetBoolean("CoMui"),
          dr.GetString("KieuMui"),
         dr.GetBoolean("CoChatThai"),
          dr.GetString("KieuChatThai"),
          dr.GetString("MoTaVanChan"),
          dr.GetByte("BHHanNhiet"),
          dr.GetString("MTBieuhien"),
          dr.GetString("Thichnghi"),
          dr.GetString("Mohoi"),
         dr.GetBoolean("BHDauMat"),
          dr.GetString("DauDau"),
          dr.GetString("DauMat"),
          dr.GetString("DauTai"),
          dr.GetString("DauMui"),
          dr.GetString("DauHong"),
          dr.GetString("DauCoVai"),
         dr.GetBoolean("BHLung"),
          dr.GetString("Lung"),
         dr.GetBoolean("BHBungNguc"),
          dr.GetString("BungNguc"),
         dr.GetBoolean("BHChanTay"),
         dr.GetBoolean("BHAn"),
          dr.GetString("An"),
         dr.GetBoolean("BHUong"),
          dr.GetString("Uong"),
         dr.GetBoolean("BHDTT"),
          dr.GetString("TieuTien"),
          dr.GetString("DaiTien"),
         dr.GetBoolean("BHNgu"),
          dr.GetString("Ngu"),
         dr.GetBoolean("BHKN"),
          dr.GetString("RLKinhnguyet"),
          dr.GetString("ThongKinh"),
          dr.GetString("DoiHa"),
         dr.GetBoolean("RLKNSinhDuc"),
          dr.GetString("RLNam"),
          dr.GetString("RLNu"),
         dr.GetBoolean("DKXHBenh"),
          dr.GetString("MTVaanChan"),


          dr.GetString("XucChan_da"),
          dr.GetString("XucChan_mohoi"),
          dr.GetString("XucChan_coxuongkhop"),
          dr.GetString("XucChanbung"),
          dr.GetString("MachChan"),
          dr.GetString("TongKhanTrai"),
          dr.GetString("TongKhanPhai"),
          dr.GetString("ViKhanTraiThon"),
          dr.GetString("ViKhanPhaiThon"),
          dr.GetString("ViKhanTraiQuan"),
          dr.GetString("ViKhanPhaiQuan"),
          dr.GetString("ViKhanTraiXich"),
          dr.GetString("ViKhanPhaiXich"),
          dr.GetString("MTThietChan"),
          dr.GetString("TomtatTuChan"),
          dr.GetString("BienChungLieuTri"),
          dr.GetString("BenhDanh"),
          dr.GetString("Batcuong"),
          dr.GetString("Tangphu"),
          dr.GetString("KinhMach"),
          dr.GetString("DinhViBenhTheo"),
          dr.GetString("Nguyennhan"),

          dr.GetString("BatcuongDT"),
          dr.GetString("TangphuDT"),
          dr.GetString("NguyennhanDT"),
          dr.GetString("ChanDoanRaVien"),
          dr.GetString("Phapdieutri"),
          dr.GetString("Phuongthuoc"),
          dr.GetString("Phuonghuyet"),
          dr.GetString("XoaBop"),
          dr.GetString("Khac"),
          dr.GetString("mabenhRaVien"),
          dr.GetString("maBenhvv"),
          dr.GetString("maBenhKKB"),
          dr.GetString("maICDRaVien"),
          dr.GetString("maICDvv"),
          dr.GetString("maICDKKB"),
          dr.GetString("ChanDoanVV"),
          dr.GetString("ChanDoanKKB"),
          dr.GetString("CheDoDinhDuong"),
         
           dr.GetString("CheDoChamSoc"),
            dr.GetString("TienLuong"),
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD"),
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1"),
     
         dr.GetString("TenBSKham") ,
         dr.GetString("TenNguoiSD")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
