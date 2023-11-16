using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKiemDinh_ATBXList : BusinessListBase<DMKiemDinh_ATBXList, DMKiemDinh_ATBX>
    {
        #region Factory Methods
        public static DMKiemDinh_ATBXList GetDMKiemDinh_ATBX_ByTB(String maTB)
        {
            return DataPortal.Fetch<DMKiemDinh_ATBXList>(new CriteriaTB(maTB));
        }
        public static DMKiemDinh_ATBXList GetDMKiemDinh_ATBX_ByKhoa(String maKhoa)
        {
            return DataPortal.Fetch<DMKiemDinh_ATBXList>(new CriteriaKhoa(maKhoa));
        }
        public static DMKiemDinh_ATBXList SearchDMKiemDinh_ATBX(DateTime tungay, DateTime denngay, string matb, string noicap)
        {
            return DataPortal.Fetch<DMKiemDinh_ATBXList>(new CriteriaSearch(tungay, denngay, matb, noicap));
        }
        public static DMKiemDinh_ATBXList FindDMKiemDinh_ATBX(string MaTB,
            string MaKhoa,
            string HoatDo,
            string MaGP,
            DateTime NgayCap,
            string NoiCap,
            DateTime NgayHetHan,
            bool DangSD,
            byte MaTTKhaiBao,
            string GhiChu,
            DateTime NgayKiemDinh,
            string MaKiemDinh,
            bool Huy)
        {
            return DataPortal.Fetch<DMKiemDinh_ATBXList>(new CriteriaOther( MaTB,
             MaKhoa,
             HoatDo,
             MaGP,
             NgayCap,
             NoiCap,
             NgayHetHan,
             DangSD,
             MaTTKhaiBao,
             GhiChu,
             NgayKiemDinh,
             MaKiemDinh,
             Huy));
        }
        public void NewTo(DMKiemDinh_ATBX _DMKiemDinh_ATBX)
        {
            if (this.Count == 0)
                _DMKiemDinh_ATBX.OrderNumber = 1;
            else
                _DMKiemDinh_ATBX.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKiemDinh_ATBX);
        }
        public void UpdatedTo(DMKiemDinh_ATBX _DMKiemDinh_ATBX)
        {

            _DMKiemDinh_ATBX.OrderNumber = this.Items[this.IndexOf(_DMKiemDinh_ATBX)].OrderNumber;
            this.Items[this.IndexOf(_DMKiemDinh_ATBX)] = _DMKiemDinh_ATBX;
        }
        public void RemoveTo(DMKiemDinh_ATBX _DMKiemDinh_ATBX)
        {
            this.Items.Remove(_DMKiemDinh_ATBX);

        }

        private DMKiemDinh_ATBXList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        [Serializable()]
        protected class Criteria
        {
            private String _maKiemDinh;
            public String maKiemDinh
            {
                get
                {
                    return _maKiemDinh;
                }
            }

            public Criteria(String maKiemDinh)
            {
                _maKiemDinh = maKiemDinh;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maKiemDinh.Equals(c._maKiemDinh))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTB", _maKiemDinh.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        private class CriteriaSearch
        {
            private DateTime _tuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
            }
            private DateTime _denNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            private string _maTB;
            public string MaTB
            {
                get
                {
                    return _maTB;
                }
            }
            private string _NoiCap;
            public string NoiCap
            {
                get
                {
                    return _NoiCap;
                }
            }
            public CriteriaSearch(DateTime tungay, DateTime denngay, string matb, string noicap)
            {
                _tuNgay = tungay;
                _denNgay = denngay;
                _maTB = matb;
                _NoiCap = noicap;
            }
        }
        [Serializable()]
        protected class CriteriaTB
        {
            private String _maTB;
            public String maTB
            {
                get
                {
                    return _maTB;
                }
            }

            public CriteriaTB(String maTB)
            {
                _maTB = maTB;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTB)
                {
                    CriteriaTB c = (CriteriaTB)obj;
                    if (!_maTB.Equals(c._maTB))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTB", _maTB.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class CriteriaKhoa
        {
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }

            public CriteriaKhoa(String maKhoa)
            {
                _maKhoa = maKhoa;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaKhoa)
                {
                    CriteriaKhoa c = (CriteriaKhoa)obj;
                    if (!_maKhoa.Equals(c._maKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaKhoa", _maKhoa.ToString()).GetHashCode();
            }
        }
        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {
            private string _MaTB;
            public string MaTB
            {
                get
                {
                    return _MaTB;
                }
            }
            private string _MaKhoa;
            public string MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private string _HoatDo;
            public string HoatDo
            {
                get
                {
                    return _HoatDo;
                }
            }
            private string _MaGP;
            public string MaGP
            {
                get
                {
                    return _MaGP;
                }
            }
            private DateTime _NgayCap;
            public DateTime NgayCap
            {
                get
                {
                    return _NgayCap;
                }
            }
            private string _NoiCap;
            public string NoiCap
            {
                get
                {
                    return _NoiCap;
                }
            }
            private DateTime _NgayHetHan;
            public DateTime NgayHetHan
            {
                get
                {
                    return _NgayHetHan;
                }
            }
            private bool _DangSD;
            public bool DangSD
            {
                get
                {
                    return _DangSD;
                }
            }
            private byte _MaTTKhaiBao;
            public byte MaTTKhaiBao
            {
                get
                {
                    return _MaTTKhaiBao;
                }
            }
            private string _GhiChu;
            public string GhiChu
            {
                get
                {
                    return _GhiChu;
                }
            }
            private DateTime _NgayKiemDinh;
            public DateTime NgayKiemDinh
            {
                get
                {
                    return _NgayKiemDinh;
                }
            }
            private string _MaKiemDinh;
            public string MaKiemDinh
            {
                get
                {
                    return _MaKiemDinh;
                }
            }
            private bool _Huy;
            public bool Huy
            {
                get
                {
                    return _Huy;
                }
            }

            public CriteriaOther(string MaTB,string MaKhoa,string HoatDo,string MaGP,DateTime NgayCap,string NoiCap,DateTime NgayHetHan,bool DangSD,byte MaTTKhaiBao,string GhiChu,DateTime NgayKiemDinh,string MaKiemDinh,bool Huy)
            {
                _MaTB = MaTB;
                _MaKhoa = MaKhoa;
                _HoatDo = HoatDo;
                _MaGP = MaGP;
                _NgayCap = NgayCap;
                _NoiCap = NoiCap;
                _NgayHetHan = NgayHetHan;
                _DangSD = DangSD;
                _MaTTKhaiBao = MaTTKhaiBao;
                _GhiChu = GhiChu;
                _NgayKiemDinh = NgayKiemDinh;
                _MaKiemDinh = MaKiemDinh;
                _Huy = Huy;
            }
        }
        #endregion

        private void DataPortal_Fetch(CriteriaTB tb)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKiemDinh_ATBXByMaTB(tb.maTB)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMKiemDinh_ATBX item = new DMKiemDinh_ATBX(
                    dr.GetString("MaKD"),
                    dr.GetString("MaTB"),
                    dr.GetString("MaGP"),
                    dr.GetSmartDate("NgayKD", false),
                    dr.GetSmartDate("NgayHetHanKD", false),
                    dr.GetString("HoatDo"),
                    dr.GetBoolean("SuDung"),
                    dr.GetString("KQKiemDinh"),
                    dr.GetByte("TTKhaiBao"),
                    dr.GetString("GhiChu"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTBYT"),
                    dr.GetString("MaKhoa"),
                    dr.GetString("TenKhoa"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("TenTTKhaiBao"),
                    dr.GetString("HoTen"),
                    dr.GetString("SoGP"),
                    i
         );
                    this.Add(item);
                    i += 1;
                }
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaKhoa khoa)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKiemDinh_ATBXByMaTB(khoa.maKhoa)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMKiemDinh_ATBX item = new DMKiemDinh_ATBX(
                    dr.GetString("MaKD"),
                    dr.GetString("MaTB"),
                    dr.GetString("MaGP"),
                    dr.GetSmartDate("NgayKD", false),
                    dr.GetSmartDate("NgayHetHanKD", false),
                    dr.GetString("HoatDo"),
                    dr.GetBoolean("SuDung"),
                    dr.GetString("KQKiemDinh"),
                    dr.GetByte("TTKhaiBao"),
                    dr.GetString("GhiChu"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTBYT"),
                    dr.GetString("MaKhoa"),
                    dr.GetString("TenKhoa"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("TenTTKhaiBao"),
                    dr.GetString("HoTen"),
                    dr.GetString("SoGP"),
                    i
         );
                    this.Add(item);
                    i += 1;
                }
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther c)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKiemDinh_ATBX(c.MaTB,
            c.MaKhoa,
            c.HoatDo,
            c.MaGP,
            c.NgayCap,
            c.NoiCap,
            c.NgayHetHan,
            c.DangSD,
            c.MaTTKhaiBao,
            c.GhiChu,
            c.NgayKiemDinh,
            c.MaKiemDinh,
            c.Huy)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMKiemDinh_ATBX item = new DMKiemDinh_ATBX(
                    dr.GetString("MaKD"),
                    dr.GetString("MaTB"),
                    dr.GetString("MaGP"),
                    dr.GetSmartDate("NgayKD", false),
                    dr.GetSmartDate("NgayHetHanKD", false),
                    dr.GetString("HoatDo"),
                    dr.GetBoolean("SuDung"),
                    dr.GetString("KQKiemDinh"),
                    dr.GetByte("TTKhaiBao"),
                    dr.GetString("GhiChu"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTBYT"),
                    dr.GetString("MaKhoa"),
                    dr.GetString("TenKhoa"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("TenTTKhaiBao"),
                    dr.GetString("HoTen"),
                    dr.GetString("SoGP"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaSearch c)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().SearchDMKiemDinhATBX(c.TuNgay, c.DenNgay, c.MaTB, c.NoiCap)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMKiemDinh_ATBX item = new DMKiemDinh_ATBX(
                    dr.GetString("MaKD"),
                    dr.GetString("MaTB"),
                    dr.GetString("MaGP"),
                    dr.GetSmartDate("NgayKD", false),
                    dr.GetSmartDate("NgayHetHanKD", false),
                    dr.GetString("HoatDo"),
                    dr.GetBoolean("SuDung"),
                    dr.GetString("KQKiemDinh"),
                    dr.GetByte("TTKhaiBao"),
                    dr.GetString("GhiChu"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTBYT"),
                    dr.GetString("MaKhoa"),
                    dr.GetString("TenKhoa"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("TenTTKhaiBao"),
                    dr.GetString("HoTen"),
                    dr.GetString("SoGP"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
