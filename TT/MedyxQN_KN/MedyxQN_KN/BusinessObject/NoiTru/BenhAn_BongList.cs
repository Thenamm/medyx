using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{

    [Serializable()]
    public class BenhAn_BongList : BusinessListBase<BenhAn_BongList, BenhAn_Bong>
    {
        #region Factory Methods
        public static BenhAn_BongList GetAllBenhAn_Bong(String maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_BongList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Bong _BenhAn_Bong)
        {
            if (this.Count == 0)
                _BenhAn_Bong.OrderNumber = 1;
            else
            _BenhAn_Bong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Bong);
        }
        public void UpdatedTo(BenhAn_Bong _BenhAn_Bong)
        {

            _BenhAn_Bong.OrderNumber = this.Items[this.IndexOf(_BenhAn_Bong)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Bong)] = _BenhAn_Bong;
        }
        public void RemoveTo(BenhAn_Bong _BenhAn_Bong)
        {
            this.Items.Remove(_BenhAn_Bong);

        }

        private BenhAn_BongList()
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
            public Criteria(String maBA, Byte STTKhoa)
            {
               
                _STTKhoa = STTKhoa ;
                _maBA = maBA;
             
                
                
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Bong(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Bong item = new BenhAn_Bong (
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

			 dr.GetString("ToanThan"),
             //dr.GetString("BenhChuyenKhoa") ,
             dr.GetString("cqtuanhoan"),
             dr.GetString("cqhohap"),
             dr.GetString("cqtieuhoa"),
              dr.GetString("cqtietnieu"),
               dr.GetString("cqtamthan"),
             dr.GetString("cqcoxuongkhop"),
             dr.GetString("cqsinhduc"),
             dr.GetString("CoQuanKhac") ,
             dr.GetString("TonThuong") ,
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
