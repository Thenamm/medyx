using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_NoiList : BusinessListBase<BenhAn_NoiList, BenhAn_Noi>
    {
        #region Factory Methods
        public static BenhAn_NoiList GetAllBenhAn_Noi(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_NoiList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Noi _BenhAn_Noi)
        {
            if (this.Count == 0)
                _BenhAn_Noi.OrderNumber = 1;
            else
            _BenhAn_Noi.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Noi);
        }
        public void UpdatedTo(BenhAn_Noi _BenhAn_Noi)
        {

            _BenhAn_Noi.OrderNumber = this.Items[this.IndexOf(_BenhAn_Noi)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Noi)] = _BenhAn_Noi;
        }
        public void RemoveTo(BenhAn_Noi _BenhAn_Noi)
        {
            this.Items.Remove(_BenhAn_Noi);

        }

        private BenhAn_NoiList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Noi(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Noi item = new BenhAn_Noi(
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
            dr.GetString("TuanHoan") ,
            dr.GetString("HoHap") ,
            dr.GetString("TieuHoa") ,
            dr.GetString("ThanTNieuSDuc") ,
            //dr.GetString("MoTaChiTietCQBenhLy"),
            dr.GetString("ThanKinh") ,
            dr.GetString("XuongKhop") ,
            dr.GetString("TaiMuiHong") ,
            dr.GetString("RangHamMat") ,
            dr.GetString("Mat") ,
            dr.GetString("BenhLyKhac") ,
            dr.GetString("mota"),
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
             dr.GetString("MaICD"),
            dr.GetString("MaICDKem") ,
             dr.GetString("MaICDPhanBiet"),
            dr.GetString("TenBSKham") ,
            dr.GetString("TenNguoiSD"),
            dr.GetString("CanLamSang"),
            dr.GetString("TomTatBenhAn"),
            dr.GetString("MaBenhKemTheo"),
            dr.GetString("MaBenhPhanBiet"),
            dr.GetString("TenBenhKemTheo"),
            dr.GetString("TenBenhPhanBiet"),
            dr.GetString("MaBenhChinh"),
            dr.GetString("TenBenhChinh"),
             dr.GetString("MoTaChiTietCQBenhLy")
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
