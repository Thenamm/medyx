using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_TMList : BusinessListBase<BenhAn_TMList, BenhAn_TM>
    {
        #region Factory Methods
        public static BenhAn_TMList GetAllBenhAn_TM(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_TMList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_TM _BenhAn_TM)
        {
            if (this.Count == 0)
                _BenhAn_TM.OrderNumber = 1;
            else
            _BenhAn_TM.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_TM);
        }
        public void UpdatedTo(BenhAn_TM _BenhAn_TM)
        {

            _BenhAn_TM.OrderNumber = this.Items[this.IndexOf(_BenhAn_TM)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_TM)] = _BenhAn_TM;
        }
        public void RemoveTo(BenhAn_TM _BenhAn_TM)
        {
            this.Items.Remove(_BenhAn_TM);

        }

        private BenhAn_TMList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TM(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_TM item = new BenhAn_TM(
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
			 dr.GetBoolean("Da") ,
			 dr.GetBoolean("Phu") ,
			 dr.GetBoolean("NgonTay") ,
			 dr.GetBoolean("Hach") ,
			 dr.GetBoolean("Khotho") ,
			 dr.GetBoolean("Ho") ,
			 dr.GetBoolean("Daunguc") ,
			 dr.GetBoolean("Tim") ,
			 dr.GetBoolean("NgoiXom") ,
			 dr.GetBoolean("Ngat") ,
			 dr.GetBoolean("Hoihop") ,
			 dr.GetString("DauhieuKhac") ,
			 dr.GetString("Longnguc") ,
			 dr.GetString("Vitrimomtim"),
			 dr.GetString("Tiengtim") ,
			 dr.GetString("Tiengthoitim") ,
			 dr.GetString("Tiengthoimach") ,
			 dr.GetString("Tiengthoikhac") ,
			 dr.GetString("Machtuchi") ,
			 dr.GetString("Hohap") ,
			 dr.GetString("Bung") ,
			 dr.GetString("Thanhkinh") ,
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
