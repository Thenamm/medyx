using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_CoXuongKhopList : BusinessListBase<BenhAn_CoXuongKhopList, BenhAn_CoXuongKhop>
    {
        #region Factory Methods
        public static BenhAn_CoXuongKhopList GetAllBenhAn_CoXuongKhop(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_CoXuongKhopList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_CoXuongKhop _BenhAn_CoXuongKhop)
        {
            if (this.Count == 0)
                _BenhAn_CoXuongKhop.OrderNumber = 1;
            else
            _BenhAn_CoXuongKhop.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_CoXuongKhop);
        }
        public void UpdatedTo(BenhAn_CoXuongKhop _BenhAn_CoXuongKhop)
        {

            _BenhAn_CoXuongKhop.OrderNumber = this.Items[this.IndexOf(_BenhAn_CoXuongKhop)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_CoXuongKhop)] = _BenhAn_CoXuongKhop;
        }
        public void RemoveTo(BenhAn_CoXuongKhop _BenhAn_CoXuongKhop)
        {
            this.Items.Remove(_BenhAn_CoXuongKhop);

        }

        private BenhAn_CoXuongKhopList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_CoXuongKhop(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_CoXuongKhop item = new BenhAn_CoXuongKhop(
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

			 dr.GetString("TinhThan") ,
         dr.GetString("DaNiemMac") ,
         dr.GetString("TTNgoaiDa") ,
         dr.GetString("Hach") ,
         dr.GetString("KNDiLai") ,
         dr.GetString("NgonDuiTrong") ,
         dr.GetString("HCRaynand") ,
         dr.GetString("CoXuongKhop") ,
         dr.GetString("TuanHoan") ,
         dr.GetString("HoHap") ,
         dr.GetString("TieuHoa") ,
         dr.GetString("ThanTNieuSDuc") ,
         dr.GetString("ThanKinh") ,
         dr.GetString("NoiTiet") ,
         dr.GetString("TaiMuiHong") ,
         dr.GetString("Mat") ,

			 dr.GetString("DieuTri") ,
			 dr.GetString("BenhSu") ,
			 dr.GetString("HuongDT") ,
			 dr.GetString("Mabenh") ,
			 dr.GetString("MaBenhKem") ,
			 dr.GetString("Machuyenkhoa") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD"),
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1"),
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
