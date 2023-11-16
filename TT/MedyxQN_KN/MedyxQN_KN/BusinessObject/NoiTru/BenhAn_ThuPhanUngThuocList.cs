using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class BenhAn_ThuPhanUngThuocList : BusinessListBase<BenhAn_ThuPhanUngThuocList, BenhAn_ThuPhanUngThuoc>
    {
        #region Factory Methods
        public static BenhAn_ThuPhanUngThuocList GetAllBenhAn_ThuPhanUngThuoc(String MaBA, int STT, int STTKhoa)
        {
            return DataPortal.Fetch<BenhAn_ThuPhanUngThuocList>(new Criteria(MaBA, STT, STTKhoa));
        }
        public static BenhAn_ThuPhanUngThuocList GetBenhAn_ThuPhanUngThuoc(String MaBA, int STT, int STTKhoa, String MaThu)
        {
            return DataPortal.Fetch<BenhAn_ThuPhanUngThuocList>(new Criteria1(MaBA, STT, STTKhoa,MaThu));
        }
        public BenhAn_ThuPhanUngThuoc GetTo(String MaBA, int STT, int STTKhoa, String MaThu) //
        {
            foreach (BenhAn_ThuPhanUngThuoc obj in this)
                if (obj.MaBA == MaBA && obj.STT == STT && obj.STTKhoa == STTKhoa && obj.MaThu == MaThu)
                    return obj;
            return null;

        }
        private BenhAn_ThuPhanUngThuocList()
        {  /* Require use of factory methods */ }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAnPhauThuat_DungCuMo  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public void UpdatedTo(BenhAn_ThuPhanUngThuoc _BenhAn_ThuPhanUngThuoc)
        {

            //_BenhAn_ThuPhanUngThuoc.MaBA = this.Items[this.IndexOf(_BenhAn_ThuPhanUngThuoc)].MaBA;
            this.Items[this.IndexOf(_BenhAn_ThuPhanUngThuoc)] = _BenhAn_ThuPhanUngThuoc;
        }
        public BenhAn_ThuPhanUngThuoc AssignTo(BenhAn_ThuPhanUngThuoc _BenhAn_ThuPhanUngThuoc)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_ThuPhanUngThuoc.Huy))
            {
                if (this.Items.Count > 0)
                {
                    this.Add(_BenhAn_ThuPhanUngThuoc);
                }
                else
                {
                    this.Add(_BenhAn_ThuPhanUngThuoc);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_ThuPhanUngThuoc;
        }
        #endregion
        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion
        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
                }
            }
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            public Criteria(String MaBA, int STT, int STTKhoa)
            {
                _MaBA = MaBA;
                _STT = STT;
                _STTKhoa = STTKhoa;
            }
        }
        [Serializable()]
        private class Criteria1
        {
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
                }
            }
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private string _MaThu;
            public string MaThu
            {
                get
                {
                    return _MaThu;
                }
            }
            public Criteria1(String MaBA, int STT, int STTKhoa, string MaThu)
            {
                _MaBA = MaBA;
                _STT = STT;
                _STTKhoa = STTKhoa;
                _MaThu = MaThu;
            }
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuPhanUngThuoc(criteria.MaBA, criteria.STT, criteria.STTKhoa)))
            {
                while (dr.Read())
                {
                    BenhAn_ThuPhanUngThuoc item = new BenhAn_ThuPhanUngThuoc(
     i,
    dr.GetString("MaThu"),
    dr.GetString("MaBA"),
    dr.GetInt32("STT"),
    dr.GetInt32("STTKhoa"),
    dr.GetString("MaThuoc"),
    dr.GetString("MaBN"),
    dr.GetSmartDate("TuNgay"),
    dr.GetSmartDate("DenNgay"),
    dr.GetString("PhuongPhapThu"),
    dr.GetString("BSChiDinh"),
    dr.GetString("NguoiThu"),
    dr.GetString("BSDoc"),
    dr.GetString("KQ"),
    dr.GetString("MaMay"),
    dr.GetBoolean("Huy"),
    dr.GetSmartDate("NgaySD", false),
    dr.GetString("NguoiSD"),
    dr.GetString("TenThuoc"),
    dr.GetString("TenBSChiDinh"),
    dr.GetString("TenNguoiThu"),
    dr.GetString("TenBSDoc"),
    dr.GetString("TenNguoiSD")
         );
                    this.Add(item);
                    i += 1;
                }
            }
            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(Criteria1 criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThuPhanUngThuoc(criteria.MaBA, criteria.STT, criteria.STTKhoa, criteria.MaThu)))
            {
                while (dr.Read())
                {
                    BenhAn_ThuPhanUngThuoc item = new BenhAn_ThuPhanUngThuoc(
     i,
    dr.GetString("MaThu"),
    dr.GetString("MaBA"),
    dr.GetInt32("STT"),
    dr.GetInt32("STTKhoa"),
    dr.GetString("MaThuoc"),
    dr.GetString("MaBN"),
    dr.GetSmartDate("TuNgay"),
    dr.GetSmartDate("DenNgay"),
    dr.GetString("PhuongPhapThu"),
    dr.GetString("BSChiDinh"),
    dr.GetString("NguoiThu"),
    dr.GetString("BSDoc"),
    dr.GetString("KQ"),
    dr.GetString("MaMay"),
    dr.GetBoolean("Huy"),
    dr.GetSmartDate("NgaySD", false),
    dr.GetString("NguoiSD"),
    dr.GetString("TenThuoc"),
    dr.GetString("TenBSChiDinh"),
    dr.GetString("TenNguoiThu"),
    dr.GetString("TenBSDoc"),
    dr.GetString("TenNguoiSD")
         );
                    this.Add(item);
                    i += 1;
                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_ThuPhanUngThuoc item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();
            foreach (BenhAn_ThuPhanUngThuoc item in this)
            {
                Csla.SmartDate d = new SmartDate("01/01/0001 12:00:00 AM");
                if (item.TuNgay != d && item.DenNgay != d && item.MaThuoc != "" && item.BSChiDinh != "" && item.BSDoc != "" && item.NguoiThu != "")
                {
                    if (item.IsNew && string.IsNullOrEmpty(item.MaThu))
                        item.Insert(item.MaBA, item.STT, item.STTKhoa, item.MaThuoc, item.MaBN, item.TuNgay.Date, item.DenNgay.Date, item.PhuongPhapThu, item.BSChiDinh, item.NguoiThu, item.BSDoc, item.KQ);
                    else
                        item.Update(item.MaThu, item.MaBA, item.STT, item.STTKhoa, item.MaThuoc, item.MaBN, item.TuNgay.Date, item.DenNgay.Date, item.PhuongPhapThu, item.BSChiDinh, item.NguoiThu, item.BSDoc, item.KQ, item.Huy, item.MaMay, item.NguoiSD);
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        public override BenhAn_ThuPhanUngThuocList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_ThuPhanUngThuocList result;
            result = base.Save();
            return result;
        }
        #endregion
    }
}
