using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.Duoc
{
    [Serializable()]
    public class NhapTrasDT : BusinessListBase<NhapTrasDT,NhapTraDT>
    {
        #region Factory Methods
        public static NhapTrasDT GetAllNhapTra(bool qadmin, String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem, String MaDT)
        {
            return DataPortal.Fetch<NhapTrasDT>(new Criteria(qadmin , makho , loaiphieu, daphat , tungay, denngay, dieukienthem,MaDT));
        }
        //public static NhapTrasDT FindNhapTraByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<NhapTrasDT>()
        //}
        public void NewTo(NhapTraDT _NhapTra)
        {
            _NhapTra.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_NhapTra);
        }
        public NhapTraDT AssignTo(NhapTraDT _NhapTra)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _NhapTra.OrderNumber = ++_count;
                    _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
                    _NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
                    this.Add(_NhapTra);
                }
                else
                {
                    _NhapTra.OrderNumber = 1;
                    _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
                    _NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
                    this.Add(_NhapTra);
                }
           
            
            return _NhapTra;
        }
        public void UpdatedTo(NhapTraDT _NhapTra)
        {
            _NhapTra.OrderNumber = this.Items[this.IndexOf(_NhapTra)].OrderNumber;
            //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
            //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
            this.Items[this.IndexOf(_NhapTra)] = _NhapTra;
        }
        public void RemoveTo(NhapTraDT _NhapTra)
        {
            this.Items.Remove(_NhapTra);

        }
        //public void RemoveTo(NhapTraDT obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        //public void RemoveTo(String MaPNT)
        //{
        //    foreach (NhapTraDT obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        private NhapTrasDT()
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
            private String _MaDT;
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
            public String MaDT
            {
                get
                {
                    return _MaDT;
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

            public Criteria(bool qadmin, String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem, String MaDT)
            {
                _qadmin = qadmin;
                _maKho = makho;
                _MaDT = MaDT;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhapTra(criteria.qadmin, criteria.MaKho,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.MaDT)))
            {
                int i = 1;
                while (dr.Read())
                { 
                NhapTraDT item=new NhapTraDT(
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
     dr.GetString("tenNoiNhap"),
     dr.GetString("TenNVXuat"),    
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNguoiNhan"),
     dr.GetBoolean("DADUYET"),
     dr.GetBoolean("Khongsua"),
     dr.GetString ("MaDT"),  
     dr.GetDecimal("SLThang") 
                                  
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
