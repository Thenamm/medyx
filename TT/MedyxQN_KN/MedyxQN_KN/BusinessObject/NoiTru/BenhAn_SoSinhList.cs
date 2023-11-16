using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_SoSinhList : BusinessListBase<BenhAn_SoSinhList, BenhAn_SoSinh>
    {
        #region Factory Methods
        public static BenhAn_SoSinhList GetAllBenhAn_SoSinh(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_SoSinhList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_SoSinh _BenhAn_SoSinh)
        {
            if (this.Count == 0)
                _BenhAn_SoSinh.OrderNumber = 1;
            else
            _BenhAn_SoSinh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_SoSinh);
        }
        public void UpdatedTo(BenhAn_SoSinh _BenhAn_SoSinh)
        {

            _BenhAn_SoSinh.OrderNumber = this.Items[this.IndexOf(_BenhAn_SoSinh)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_SoSinh)] = _BenhAn_SoSinh;
        }
        public void RemoveTo(BenhAn_SoSinh _BenhAn_SoSinh)
        {
            this.Items.Remove(_BenhAn_SoSinh);

        }

        private BenhAn_SoSinhList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_SoSinh(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_SoSinh item = new BenhAn_SoSinh(
         i,
         dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
         dr.GetSmartDate("NgayKham", true) ,
			 dr.GetString("BSKham") ,
			 dr.GetString("LyDoKham") ,
              dr.GetString("benhsu"),
			 dr.GetString("MeMach") ,
			 dr.GetString("MeDa") ,
			 dr.GetString("MeNiemMac"),
			 dr.GetString("MeApHuyet") ,
			 dr.GetString("MeNhietDo") ,
			 dr.GetString("MeNhipTho"),
			 dr.GetString("MeCanNang") ,
			 dr.GetString("MeChieuCao") ,
			 dr.GetBoolean("MePhu") ,
			 dr.GetString("MeToanThan") ,
			 dr.GetString("MeToanTrang") ,
			 dr.GetString("MeCao") ,
			 dr.GetString("MeTim") ,
			 dr.GetString("MeGan") ,
			 dr.GetString("MePhoi") ,
			 dr.GetString("MeThan") ,
			 dr.GetString("MeNuocOi") ,
         dr.GetString("MeKieuOiVo"),
			 dr.GetString("MeTieng") ,
         dr.GetString("MeCachDe"),
         dr.GetSmartDate("MeGioDe",true ),
			 dr.GetString("MeLyDo") ,
			 dr.GetString("MeNguoiDoDe") ,
			 dr.GetString("MeApgar1"),
			 dr.GetString("MeApgar5") ,
			 dr.GetBoolean("HutDich") ,
			 dr.GetBoolean("XoaBop") ,
			 dr.GetBoolean("Tho") ,
			 dr.GetBoolean("DiTat") ,
			 dr.GetBoolean("DatNoiKhiQuan") ,
			 dr.GetBoolean("BopBong") ,
			 dr.GetBoolean("DiTathaumon") ,
			 dr.GetString("CuThe") ,
			 dr.GetString("NguoiChuyen") ,
			 dr.GetString("NhipTim") ,
			 dr.GetString("XuongKhop") ,
			 dr.GetString("ApHuyet") ,
			 dr.GetString("NhietDo") ,
			 dr.GetString("NhipTho") ,
			 dr.GetString("CanNang") ,
			 dr.GetString("ChieuCao") ,
			 dr.GetBoolean("Phu") ,
			 dr.GetString("ToanThan") ,
			 dr.GetString("ToanTrang") ,
			 dr.GetString("VongDau") ,
			 dr.GetString("VongNguc") ,
			 dr.GetByte("Da") ,
			 dr.GetString("NghePhoi") ,
			 dr.GetString("ChiSoSilerman") ,
			 dr.GetString("Bung") ,
			 dr.GetString("SinhDucNgoai") ,
			 dr.GetString("PhanXa") ,
			 dr.GetString("TruongLucCo") ,
			 dr.GetString("BoPhanKhac") ,
			 dr.GetString("TuoiThai") ,
			 dr.GetString("DieuTri") ,
			 dr.GetString("ChanDoan") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1") ,
         dr.GetString("TenBSKham"),
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
