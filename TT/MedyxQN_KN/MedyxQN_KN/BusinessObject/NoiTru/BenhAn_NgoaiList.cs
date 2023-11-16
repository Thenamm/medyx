using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_NgoaiList : BusinessListBase<BenhAn_NgoaiList, BenhAn_Ngoai>
    {
        #region Factory Methods
        public static BenhAn_NgoaiList GetAllBenhAn_Ngoai(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_NgoaiList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Ngoai _BenhAn_Ngoai)
        {
            if (this.Count == 0)
                _BenhAn_Ngoai.OrderNumber = 1;
            else
            _BenhAn_Ngoai.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Ngoai);
        }
        public void UpdatedTo(BenhAn_Ngoai _BenhAn_Ngoai)
        {

            _BenhAn_Ngoai.OrderNumber = this.Items[this.IndexOf(_BenhAn_Ngoai)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Ngoai)] = _BenhAn_Ngoai;
        }
        public void RemoveTo(BenhAn_Ngoai _BenhAn_Ngoai)
        {
            this.Items.Remove(_BenhAn_Ngoai);

        }

        private BenhAn_NgoaiList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Ngoai(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Ngoai item = new BenhAn_Ngoai(
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
			 dr.GetString("BenhNgoaiKhoa") ,
			 dr.GetString("Coquankhac") ,
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
