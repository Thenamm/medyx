using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_San_DeList : BusinessListBase<BenhAn_San_DeList, BenhAn_San_De>
    {
        #region Factory Methods
        public static BenhAn_San_DeList GetAllBenhAn_San_De(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_San_DeList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_San_De _BenhAn_San_De)
        {
            if (this.Count == 0)
                _BenhAn_San_De.OrderNumber = 1;
            else
            _BenhAn_San_De.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_San_De);
        }
        public void UpdatedTo(BenhAn_San_De _BenhAn_San_De)
        {

            _BenhAn_San_De.OrderNumber = this.Items[this.IndexOf(_BenhAn_San_De)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_San_De)] = _BenhAn_San_De;
        }
        public void RemoveTo(BenhAn_San_De _BenhAn_San_De)
        {
            this.Items.Remove(_BenhAn_San_De);

        }

        private BenhAn_San_DeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San_De(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_San_De item = new BenhAn_San_De(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			 dr.GetSmartDate("NgayKham", true) ,
			dr.GetString("BSKham") ,
			dr.GetString("LyDoKham") ,
            dr.GetString("benhsu"),
			dr.GetSmartDate("NgayDe", true) ,
			dr.GetString("TenConTrai") ,
			dr.GetString("TenConGai") ,
			dr.GetString("TinhThan") ,
			dr.GetString("TheTrang") ,
			dr.GetString("Mach") ,
			dr.GetString("Da") ,
			dr.GetString("NiemMac") ,
			dr.GetString("ApHuyet") ,
			dr.GetString("NhietDo") ,
			dr.GetString("NhipTho") ,
			dr.GetString("CanNang") ,
			dr.GetString("ChieuCao") ,
			dr.GetByte("Phu") ,
			dr.GetString("ToanThan") ,
			dr.GetString("ToanTrang") ,
			dr.GetString("Cao") ,
			dr.GetString("Tim") ,
			dr.GetString("Gan") ,
			dr.GetString("Phoi"),
			dr.GetString("Than") ,
			dr.GetString("BenhKhac") ,
			dr.GetString("KhamTai") ,
			dr.GetByte("TuoiThai") ,
			dr.GetBoolean("TiemPhong") ,
            dr.GetString("Mui"),
			dr.GetSmartDate("NgayChuyenDa", true) ,
			dr.GetString("TrieuTrung") ,
			dr.GetString("DauHieu") ,
			dr.GetByte("SeoPTCu") ,
			dr.GetBoolean("DauVetMo") ,
			dr.GetString("ChieuCaoTC") ,
			dr.GetString("VongBung") ,
			dr.GetString("TimThai") ,
			dr.GetBoolean("TimThaiRo") ,
			dr.GetString("LuongGai") ,
			dr.GetString("Baudelocque") ,
			dr.GetString("LuongUNgoi") ,
			dr.GetString("HinhDangTC") ,
			dr.GetString("TuThe") ,
			dr.GetString("ConCoTC") ,
			dr.GetString("NgoiThai") ,
			dr.GetString("Vu") ,
			dr.GetString("LuongMao") ,
			dr.GetString("LuongMau") ,
			dr.GetByte("KhungChau") ,
			dr.GetString("CutHaVe") ,
			dr.GetString("AmHo") ,
			dr.GetString("AmDao") ,
            dr.GetByte("CoTuCung"),
			dr.GetString("Mo") ,
			dr.GetString("Bishop") ,
			dr.GetBoolean("KhoiU") ,
			dr.GetString("KhoiUC"),
			dr.GetByte("DauOi") ,
            dr.GetByte("KieuOiVo"),
			dr.GetSmartDate("OiVo", true) ,
            dr.GetByte("MauOi"),
			dr.GetString("Ngoi") ,
			dr.GetString("The") ,
			dr.GetByte("DoLot") ,
			dr.GetString("TangSinhMon") ,
			dr.GetString("KieuThe") ,
			dr.GetString("DuongKinhNho") ,
			dr.GetString("TienLuong") ,
			dr.GetString("DieuTri") ,
			dr.GetString("ChanDoan") ,
			dr.GetString("KhiDe") ,
			dr.GetString("PhanBiet") ,
			dr.GetString("MaMay"),
			dr.GetBoolean("Huy") ,
			dr.GetSmartDate("NgaySD", true) ,
			dr.GetString("NguoiSD") ,
			dr.GetSmartDate("NgaySD1", true) ,
			dr.GetString("NguoiSD1") ,
            dr.GetString("TenBSKham") ,
            dr.GetString("TenNguoiSD")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
