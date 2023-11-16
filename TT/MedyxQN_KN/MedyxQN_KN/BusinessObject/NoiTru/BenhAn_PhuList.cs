using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_PhuList : BusinessListBase<BenhAn_PhuList, BenhAn_Phu>
    {
        #region Factory Methods
        public static BenhAn_PhuList GetAllBenhAn_Phu(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_PhuList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Phu _BenhAn_Phu)
        {
            if (this.Count == 0)
                _BenhAn_Phu.OrderNumber = 1;
            else
            _BenhAn_Phu.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Phu);
        }
        public void UpdatedTo(BenhAn_Phu _BenhAn_Phu)
        {

            _BenhAn_Phu.OrderNumber = this.Items[this.IndexOf(_BenhAn_Phu)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Phu)] = _BenhAn_Phu;
        }
        public void RemoveTo(BenhAn_Phu _BenhAn_Phu)
        {
            this.Items.Remove(_BenhAn_Phu);

        }

        private BenhAn_PhuList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Phu(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Phu item = new BenhAn_Phu(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			dr.GetSmartDate("NgayKham", true) ,
			 dr.GetString("BSKham") ,
			 dr.GetString("LyDoKham") ,
			 dr.GetString("Mach") ,
			 dr.GetString("Da") ,
			 dr.GetString("NiemMac") ,
			 dr.GetString("ApHuyet") ,
			 dr.GetString("XuatHuyet") ,
			 dr.GetString("NhietDo") ,
			 dr.GetString("NhipTho") ,
			 dr.GetString("CanNang") ,
			 dr.GetString("ChieuCao") ,
			 dr.GetString("Phu") ,
			 dr.GetString("ThieuMau") ,
			 dr.GetString("Cao") ,
			 dr.GetString("Tim") ,
			 dr.GetString("Gan") ,
			 dr.GetString("Phoi") ,
			 dr.GetString("Than") ,
			 dr.GetString("BenhKhac") ,
             dr.GetString("TrieuChung") ,
			 dr.GetString("amho") ,
			 dr.GetString("amdao") ,
			 dr.GetString("CTC") ,
			 dr.GetString("Tucung") ,
			 dr.GetString("PhanPhu") ,
			 dr.GetString("KetLuan") ,
			 dr.GetString("Tuvan") ,
			 dr.GetString("BenhSu"),
			 dr.GetString("TomTat") ,
			 dr.GetString("DieuTri") ,
			 dr.GetString("ChanDoan") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true),
			 dr.GetString("NguoiSD") ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1"),
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
