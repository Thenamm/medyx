using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.TBYT
{
    [Serializable()]
    public class LKNhapTras : BusinessListBase<LKNhapTras,LKNhapTra>
    {
        #region Factory Methods
        public static LKNhapTras GetAllLKNhapTra(bool qadmin ,String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<LKNhapTras>(new Criteria(qadmin , makho, loaiphieu, daphat , tungay, denngay, dieukienthem));
        }
        //public static LKNhapTras FindLKNhapTraByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<LKNhapTras>()
        //}
        public void NewTo(LKNhapTra _LKNhapTra)
        {
            _LKNhapTra.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_LKNhapTra);
        }
        public LKNhapTra AssignTo(LKNhapTra _LKNhapTra)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _LKNhapTra.OrderNumber = ++_count;
                    _LKNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.Noinhap).TenKho;
                    _LKNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.NoiXuat).TenKho;
                    this.Add(_LKNhapTra);
                }
                else
                {
                    _LKNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.Noinhap).TenKho;
                    _LKNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.NoiXuat).TenKho;
                    this.Add(_LKNhapTra);
                }
           
            
            return _LKNhapTra;
        }
        public void UpdatedTo(LKNhapTra _LKNhapTra)
        {
            _LKNhapTra.OrderNumber = this.Items[this.IndexOf(_LKNhapTra)].OrderNumber;
            //_LKNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.Noinhap).TenKho;
            //_LKNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_LKNhapTra.NoiXuat).TenKho;
            this.Items[this.IndexOf(_LKNhapTra)] = _LKNhapTra;
        }
        public void RemoveTo(LKNhapTra _DMVTYTNhapTra)
        {
            this.Items.Remove(_DMVTYTNhapTra);

        }
        //public void RemoveTo(LKNhapTra obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        //public void RemoveTo(String MaPNT)
        //{
        //    foreach (LKNhapTra obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        private LKNhapTras()
        {
            /* Require use of factory methods */
        }
        #endregion
        

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maKho;
            private Byte _loaiPhieu;
            private Byte _daPhat;
            private DateTime _tuNgay;
            private DateTime _denNgay ;
            private String _dieuKienThem;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
            public Byte DaPhat
            {
                get
                {
                    return _daPhat;
                }
            }
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
 
            }
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            public String DieuKienThem
            {
                get
                {
                    return _dieuKienThem;
                }
            }

            public Criteria(bool qadmin,String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem)
            {
                _qadmin = qadmin;
                _maKho = makho;
                _loaiPhieu = loaiphieu;
                _daPhat = daphat;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        #region CriteriaOther
        private class CriteriaOther
        {
            //
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllLKNhapTra(criteria.qadmin, criteria.MaKho,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                { 
                LKNhapTra item=new LKNhapTra(
     i,
     dr.GetString("MaPNT"),
     dr.GetString("NoiXuat"),
     //dr.GetSmartDate("Ngayxuat", false),
     //dr.GetSmartDate("NgayXuatTT", false),
     dr.GetSmartDate("ngayNhap",false),
     dr.GetSmartDate("ngayNhapTT",false),
     dr.GetString("NoiNhap"),
     dr.GetByte("LoaiPhieu"),
     dr.GetString("SoCT"),
     dr.GetString("NVXuat"),
     dr.GetString("NVNhan"),
     dr.GetString("GhiChu"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgayLap",false),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy",false),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgaySD1",false),
     dr.GetString("NguoiSD1"),
     dr.GetByte("DaPhat"),
     dr.GetBoolean("bnTra"),
     dr.GetString("MaMay"),
     dr.GetString("TenNoiXuat"),
     dr.GetString("TenNoiNhap"),
     dr.GetString("TenNVXuat"),    
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNguoiNhan"),
     dr.GetBoolean("daduyet")
                                  
                    );
                this.Add(item);
                i +=1;
                }
            }
            RaiseListChangedEvents=true;
        }
        #endregion
    }
}
