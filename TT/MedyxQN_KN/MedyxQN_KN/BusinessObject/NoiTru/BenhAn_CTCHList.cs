using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_CTCHList : BusinessListBase<BenhAn_CTCHList, BenhAn_CTCH>
    {
        #region Factory Methods
        public static BenhAn_CTCHList GetAllBenhAn_CTCH(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_CTCHList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_CTCH _BenhAn_CTCH)
        {
            if (this.Count == 0)
                _BenhAn_CTCH.OrderNumber = 1;
            else
            _BenhAn_CTCH.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_CTCH);
        }
        public void UpdatedTo(BenhAn_CTCH _BenhAn_CTCH)
        {

            _BenhAn_CTCH.OrderNumber = this.Items[this.IndexOf(_BenhAn_CTCH)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_CTCH)] = _BenhAn_CTCH;
        }
        public void RemoveTo(BenhAn_CTCH _BenhAn_CTCH)
        {
            this.Items.Remove(_BenhAn_CTCH);

        }

        private BenhAn_CTCHList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_CTCH(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_CTCH item = new BenhAn_CTCH(
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
         dr.GetString("BenhngoaiKhoa") ,
         dr.GetString("TuanHoan") ,
         dr.GetString("HoHap") ,
         dr.GetString("TieuHoa") ,
         dr.GetString("ThanTNSD") ,
         dr.GetString("ThanKinh") ,
         dr.GetString("CoXuongKhop") ,
         dr.GetString("TaiMuiHong") ,
         dr.GetString("RangHamMat") ,
         dr.GetString("Mat") ,
         dr.GetString("Khac") ,

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
