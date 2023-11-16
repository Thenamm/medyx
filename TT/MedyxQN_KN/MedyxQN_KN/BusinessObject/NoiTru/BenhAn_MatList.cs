using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_MatList : BusinessListBase<BenhAn_MatList, BenhAn_Mat>
    {
        #region Factory Methods
        public static BenhAn_MatList GetAllBenhAn_Mat(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_MatList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Mat _BenhAn_Mat)
        {
            if (this.Count == 0)
                _BenhAn_Mat.OrderNumber = 1;
            else
            _BenhAn_Mat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Mat);
        }
        public void UpdatedTo(BenhAn_Mat _BenhAn_Mat)
        {

            _BenhAn_Mat.OrderNumber = this.Items[this.IndexOf(_BenhAn_Mat)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Mat)] = _BenhAn_Mat;
        }
        public void RemoveTo(BenhAn_Mat _BenhAn_Mat)
        {
            this.Items.Remove(_BenhAn_Mat);

        }

        private BenhAn_MatList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Mat(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Mat item = new BenhAn_Mat(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			 dr.GetSmartDate("NgayKham", true) ,
			 dr.GetString("BSKHAM") ,
			 dr.GetString("LyDoKham") ,
			 dr.GetString("Mach") ,
			 dr.GetString("ApHuyet") ,
			 dr.GetString("NhietDo") ,
			 dr.GetString("NhipTho") ,
			 dr.GetString("CanNang") ,
			 dr.GetString("ChieuCao") ,

			
         dr.GetString("ToanThan") ,
         dr.GetString("ThiLucVV") ,
         dr.GetString("KhongKinhMP") ,
         dr.GetString("KhongKinhMT") ,
         dr.GetString("CoKinhMP") ,
         dr.GetString("CoKinhMT") ,
         dr.GetString("NhanAPMP") ,
         dr.GetString("NhanApMT") ,
         dr.GetString("ThiTruongMP") ,
         dr.GetString("ThiTruongMT") ,
          dr.GetString("LeDaoMP"),
  dr.GetString("LeDaoMT"),
  dr.GetString("MiMatMP"),
  dr.GetString("MiMatMT"),
  dr.GetString("KetMacMP"),
  dr.GetString("KetMacMT"),
  dr.GetString("MatHotMP"),
  dr.GetString("MatHotMT"),
  dr.GetString("GiaMacMP"),
  dr.GetString("GiaMacMT"),
  dr.GetString("CungMacMP"),
  dr.GetString("CungMacMT"),
  dr.GetString("TTTienPhongMP"),
  dr.GetString("TTTienPhongMT"),
  dr.GetString("TTMongMatMP"),
  dr.GetString("TTMongMatMT"),
  dr.GetString("TTDongTuPXMP"),
  dr.GetString("TTDongTuPXMT"),
  dr.GetString("TTThuyTinhTheMP"),
  dr.GetString("TTThuyTinhTheMT"),
  dr.GetString("TTThuyTinhDichMP"),
  dr.GetString("TTThuyTinhDichMT"),
  dr.GetString("TTSADongTuMP"),
  dr.GetString("TTSADongTuMT"),
  dr.GetString("TTNhanCauMP"),
  dr.GetString("TTNhanCauMT"),
  dr.GetString("TTHocMatMP"),
  dr.GetString("TTHocMatMT"),
  dr.GetString("TTDayMatMP"),
  dr.GetString("TTDayMatMT"),
  dr.GetString("KhamToanThan"),
  dr.GetString("CQNoiTiet"),
  dr.GetString("CQTamThan"),
  dr.GetString("CQTuanHoan"),
  dr.GetString("CQHoHap"),
  dr.GetString("CQTieuHoa"),
  dr.GetString("CQCXKhop"),
  dr.GetString("CQTietNieuSD"),
  dr.GetString("CoQuanKhac"),
  dr.GetString("DieuTri"),
  dr.GetString("BenhSu"),
  dr.GetString("Mabenh"),
  dr.GetString("MaBenhKem"),
  dr.GetString("PhanBiet"),
  dr.GetString("TienLuong"),
  dr.GetString("HuongDT"),       
			 dr.GetString("Machuyenkhoa") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD"),
             dr.GetString("tomtatba"),
			 dr.GetString("cacxncls"),
         dr.GetString("TenBenh") ,
         dr.GetString("TenBenhKem") ,
         dr.GetString("MaICDKem") ,
         dr.GetString("TenBSKham") ,
         dr.GetString("TenNguoiSD")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
