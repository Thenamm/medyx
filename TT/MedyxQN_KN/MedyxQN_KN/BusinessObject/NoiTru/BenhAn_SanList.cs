using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_SanList : BusinessListBase<BenhAn_SanList, BenhAn_San>
    {
        #region Factory Methods
        public static BenhAn_SanList GetAllBenhAn_San(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_SanList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_San _BenhAn_San)
        {
            if (this.Count == 0)
                _BenhAn_San.OrderNumber = 1;
            else
            _BenhAn_San.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_San);
        }
        public void UpdatedTo(BenhAn_San _BenhAn_San)
        {

            _BenhAn_San.OrderNumber = this.Items[this.IndexOf(_BenhAn_San)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_San)] = _BenhAn_San;
        }
        public void RemoveTo(BenhAn_San _BenhAn_San)
        {
            this.Items.Remove(_BenhAn_San);

        }

        private BenhAn_SanList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_San item = new BenhAn_San(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			dr.GetSmartDate("NgayKham", true) ,
			dr.GetString("BSKham") ,
			dr.GetString("LyDoKham") ,
			dr.GetString("Mach") ,
			dr.GetString("ApHuyet") ,
			dr.GetString("NhietDo") ,
			dr.GetString("NhipTho") ,
			dr.GetString("CanNang") ,
			dr.GetString("ChieuCao") ,
			dr.GetBoolean("Phu") ,
			dr.GetString("ToanThan") ,
			dr.GetString("ToanTrang") ,
			dr.GetString("Cao") ,
			dr.GetString("Tim") ,
			dr.GetString("Gan") ,
			dr.GetString("Phoi") ,
			dr.GetString("Than") ,
			dr.GetString("BenhKhac") ,
			dr.GetBoolean("SeoPTCu") ,
			dr.GetString("ChieuCaoTC") ,
			dr.GetString("VongBung") ,
			dr.GetString("TimThai") ,
			dr.GetBoolean("TimThaiRo") ,
			dr.GetString("LuongGai") ,
			dr.GetString("Baudelocque"),
			dr.GetString("LuongUNgoi") ,
			dr.GetString("HinhDangTC") ,
			dr.GetString("TuThe") ,
			dr.GetString("ConCoTC") ,
			dr.GetString("Vu") ,
			dr.GetString("LuongMao") ,
			dr.GetString("LuongMau") ,
			dr.GetString("CutHaVe") ,
			dr.GetString("AmHo") ,
			dr.GetString("AmDao") ,
			dr.GetString("CoTuCung") ,
			dr.GetString("PhanPhu") ,
			dr.GetSmartDate("OiVo", true) ,
			dr.GetString("MauOi") ,
			dr.GetString("Ngoi") ,
			dr.GetString("The") ,
			dr.GetString("DoLot") ,
			dr.GetString("TangSinhMon") ,
			dr.GetString("TinhTrangOi") ,
			dr.GetString("OivoTuNhien") ,
			dr.GetString("LuongNuocOi") ,
			dr.GetString("KieuThe") ,
			dr.GetString("DuongKinhNho") ,
			dr.GetString("TomTat") ,
			dr.GetString("DieuTri") ,
			dr.GetString("BenhSu") ,
			dr.GetString("HuongDT") ,
			dr.GetString("Mabenh") ,
			dr.GetString("MaBenhKem") ,
			dr.GetString("Machuyenkhoa") ,
			dr.GetString("MaMay") ,
			dr.GetBoolean("Huy") ,
			dr.GetSmartDate("NgaySD", true) ,
			dr.GetString("NguoiSD") ,
			dr.GetSmartDate("NgaySD1", true) ,
			dr.GetString("NguoiSD1") ,
            dr.GetString("TenBenh") ,
            dr.GetString("TenBenhKem") ,
            dr.GetString("MaICD") ,
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
