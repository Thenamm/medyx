using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable]
    public class DMTBHeThong
    {
        public Int32 Ordernumber { get; set; }
        public String TBHeThongMaId
        {
            get
            {
                return "HT" + Math.Abs(TBHeThongId).ToString();
            }
        }
        public Decimal TBHeThongId { get; set; }
        public String TenTBHeThong { get; set; }
        public String MaTBHeThong { get; set; }
        public String MaNhom { get; set; }
        public String MaChungLoai { get; set; }
        public String MaDVT { get; set; }
        public String NamSX { get; set; }
        public Decimal KhoiLuong { get; set; }
        public Decimal TyLeKH { get; set; }
        public Decimal BaoHanh { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal NguyenTe { get; set; }
        public Int32 KyBaoDuong { get; set; }
        public String DacTinhKT { get; set; }
        public String MaNSX { get; set; }
        public String MaQuocGia { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public Boolean IsKhoChua { get; set; }
        public String NoiChua { get; set; }
        public String TenNhom { get; set; }
        public String TenChungLoai { get; set; }
        public String TenDVT { get; set; }
        public String TenNSX { get; set; }
        public String TenQuocGia { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenNoiChua { get; set; }
        public Int32 CountRow { get; set; }
        public Boolean IsSuDung { get; set; }

        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public DMTBHeThong()
        {
            TBHeThongId = 0;
            TenTBHeThong = "";
            MaTBHeThong = "";
            MaNhom = "";
            MaChungLoai = "";
            MaDVT = "";
            NamSX = "";
            KhoiLuong = 0;
            TyLeKH = 0;
            BaoHanh = 0;
            DonGia = 0;
            NguyenTe = 0;
            KyBaoDuong = 0;
            DacTinhKT = "";
            MaNSX = "";
            MaQuocGia = "";
            Ghichu = "";
            MaMay = "";
            NgayHuy = "";
            NguoiHuy = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            IsKhoChua = false;
            NoiChua = "";
            TenNhom = "";
            TenChungLoai = "";
            TenDVT = "";
            TenNSX = "";
            TenQuocGia = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenNoiChua = "";
            CountRow = 0;
            Ordernumber = 0;
            IsSuDung = false;
        }

        public DMTBHeThong(Decimal TBHeThongId, String TenTBHeThong, String MaTBHeThong, String MaNhom, String MaChungLoai, String MaDVT, String NamSX, Decimal KhoiLuong, Decimal TyLeKH, Decimal BaoHanh, Decimal DonGia, Decimal NguyenTe, Int32 KyBaoDuong, String DacTinhKT, String MaNSX, String MaQuocGia, String Ghichu, String MaMay, String NgayHuy, String NguoiHuy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, Boolean IsKhoChua, String NoiChua, String TenNhom, String TenChungLoai, String TenDVT, String TenNSX, String TenQuocGia, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenNoiChua, Int32 CountRow, Boolean IsSuDung, Int32 Ordernumber)
        {
            this.TBHeThongId = TBHeThongId;
            this.TenTBHeThong = TenTBHeThong;
            this.MaTBHeThong = MaTBHeThong;
            this.MaNhom = MaNhom;
            this.MaChungLoai = MaChungLoai;
            this.MaDVT = MaDVT;
            this.NamSX = NamSX;
            this.KhoiLuong = KhoiLuong;
            this.TyLeKH = TyLeKH;
            this.BaoHanh = BaoHanh;
            this.DonGia = DonGia;
            this.NguyenTe = NguyenTe;
            this.KyBaoDuong = KyBaoDuong;
            this.DacTinhKT = DacTinhKT;
            this.MaNSX = MaNSX;
            this.MaQuocGia = MaQuocGia;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.IsKhoChua = IsKhoChua;
            this.NoiChua = NoiChua;
            this.TenNhom = TenNhom;
            this.TenChungLoai = TenChungLoai;
            this.TenDVT = TenDVT;
            this.TenNSX = TenNSX;
            this.TenQuocGia = TenQuocGia;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenNoiChua = TenNoiChua;
            this.CountRow = CountRow;
            this.IsSuDung = IsSuDung;
            this.Ordernumber = Ordernumber;
        }
        public DMTBHeThong(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["TBHeThongId"].GetType().Name != "DBNull" && dr["TBHeThongId"] != null)
            {
                this.TBHeThongId = Convert.ToDecimal(dr["TBHeThongId"]);
            }
            else
            {
                this.TBHeThongId = 0;
            }
            if (dr["TenTBHeThong"].GetType().Name != "DBNull" && dr["TenTBHeThong"] != null)
            {
                this.TenTBHeThong = Convert.ToString(dr["TenTBHeThong"]);
            }
            else
            {
                this.TenTBHeThong = "";
            }
            if (dr["MaTBHeThong"].GetType().Name != "DBNull" && dr["MaTBHeThong"] != null)
            {
                this.MaTBHeThong = Convert.ToString(dr["MaTBHeThong"]);
            }
            else
            {
                this.MaTBHeThong = "";
            }
            if (dr["MaNhom"].GetType().Name != "DBNull" && dr["MaNhom"] != null)
            {
                this.MaNhom = Convert.ToString(dr["MaNhom"]);
            }
            else
            {
                this.MaNhom = "";
            }
            if (dr["MaChungLoai"].GetType().Name != "DBNull" && dr["MaChungLoai"] != null)
            {
                this.MaChungLoai = Convert.ToString(dr["MaChungLoai"]);
            }
            else
            {
                this.MaChungLoai = "";
            }
            if (dr["MaDVT"].GetType().Name != "DBNull" && dr["MaDVT"] != null)
            {
                this.MaDVT = Convert.ToString(dr["MaDVT"]);
            }
            else
            {
                this.MaDVT = "";
            }
            if (dr["NamSX"].GetType().Name != "DBNull" && dr["NamSX"] != null)
            {
                this.NamSX = Convert.ToDateTime(dr["NamSX"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NamSX = "";
            }
            if (dr["KhoiLuong"].GetType().Name != "DBNull" && dr["KhoiLuong"] != null)
            {
                this.KhoiLuong = Convert.ToDecimal(dr["KhoiLuong"]);
            }
            else
            {
                this.KhoiLuong = 0;
            }
            if (dr["TyLeKH"].GetType().Name != "DBNull" && dr["TyLeKH"] != null)
            {
                this.TyLeKH = Convert.ToDecimal(dr["TyLeKH"]);
            }
            else
            {
                this.TyLeKH = 0;
            }
            if (dr["BaoHanh"].GetType().Name != "DBNull" && dr["BaoHanh"] != null)
            {
                this.BaoHanh = Convert.ToDecimal(dr["BaoHanh"]);
            }
            else
            {
                this.BaoHanh = 0;
            }
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["NguyenTe"].GetType().Name != "DBNull" && dr["NguyenTe"] != null)
            {
                this.NguyenTe = Convert.ToDecimal(dr["NguyenTe"]);
            }
            else
            {
                this.NguyenTe = 0;
            }
            if (dr["KyBaoDuong"].GetType().Name != "DBNull" && dr["KyBaoDuong"] != null)
            {
                this.KyBaoDuong = Convert.ToInt32(dr["KyBaoDuong"]);
            }
            else
            {
                this.KyBaoDuong = 0;
            }
            if (dr["DacTinhKT"].GetType().Name != "DBNull" && dr["DacTinhKT"] != null)
            {
                this.DacTinhKT = Convert.ToString(dr["DacTinhKT"]);
            }
            else
            {
                this.DacTinhKT = "";
            }
            if (dr["MaNSX"].GetType().Name != "DBNull" && dr["MaNSX"] != null)
            {
                this.MaNSX = Convert.ToString(dr["MaNSX"]);
            }
            else
            {
                this.MaNSX = "";
            }
            if (dr["MaQuocGia"].GetType().Name != "DBNull" && dr["MaQuocGia"] != null)
            {
                this.MaQuocGia = Convert.ToString(dr["MaQuocGia"]);
            }
            else
            {
                this.MaQuocGia = "";
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHuy = "";
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["IsKhoChua"].GetType().Name != "DBNull" && dr["IsKhoChua"] != null)
            {
                this.IsKhoChua = Convert.ToBoolean(dr["IsKhoChua"]);
            }
            else
            {
                this.IsKhoChua = false;
            }
            if (dr["NoiChua"].GetType().Name != "DBNull" && dr["NoiChua"] != null)
            {
                this.NoiChua = Convert.ToString(dr["NoiChua"]);
            }
            else
            {
                this.NoiChua = "";
            }
            if (dr["TenNhom"].GetType().Name != "DBNull" && dr["TenNhom"] != null)
            {
                this.TenNhom = Convert.ToString(dr["TenNhom"]);
            }
            else
            {
                this.TenNhom = "";
            }
            if (dr["TenChungLoai"].GetType().Name != "DBNull" && dr["TenChungLoai"] != null)
            {
                this.TenChungLoai = Convert.ToString(dr["TenChungLoai"]);
            }
            else
            {
                this.TenChungLoai = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
            }
            if (dr["TenNSX"].GetType().Name != "DBNull" && dr["TenNSX"] != null)
            {
                this.TenNSX = Convert.ToString(dr["TenNSX"]);
            }
            else
            {
                this.TenNSX = "";
            }
            if (dr["TenQuocGia"].GetType().Name != "DBNull" && dr["TenQuocGia"] != null)
            {
                this.TenQuocGia = Convert.ToString(dr["TenQuocGia"]);
            }
            else
            {
                this.TenQuocGia = "";
            }
            if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
            {
                this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            }
            else
            {
                this.TenNguoiLap = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            {
                this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            }
            else
            {
                this.TenNguoiHuy = "";
            }
            if (dr["TenNoiChua"].GetType().Name != "DBNull" && dr["TenNoiChua"] != null)
            {
                this.TenNoiChua = Convert.ToString(dr["TenNoiChua"]);
            }
            else
            {
                this.TenNoiChua = "";
            }
            if (dr["CountRow"].GetType().Name != "DBNull" && dr["CountRow"] != null)
            {
                this.CountRow = Convert.ToInt32(dr["CountRow"]);
            }
            else
            {
                this.CountRow = 0;
            }
            if (dr["IsSuDung"].GetType().Name != "DBNull" && dr["CountRow"] != null)
            {
                this.IsSuDung = Convert.ToBoolean(dr["IsSuDung"]);
            }
            else
            {
                this.IsSuDung = false;
            }
            this.Ordernumber = Ordernumber;
        }


        public static DMTBHeThong GetByMa(Decimal MaTBHeThong)
        {
            DMTBHeThong obj = new DMTBHeThong();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTBHeThong_GET", MaTBHeThong))
            {
                while (dr.Read())
                {
                    obj = new DMTBHeThong(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBHeThong_Create", MaTBHeThong, TenTBHeThong, MaNhom, MaChungLoai, MaDVT, NamSX == "" ? new Nullable<DateTime>() : DateTime.Parse(NamSX), KhoiLuong, TyLeKH, BaoHanh, DonGia, NguyenTe, KyBaoDuong, DacTinhKT, MaNSX, MaQuocGia, Ghichu, MaMay, NguoiLap, IsSuDung).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBHeThong_Update", TBHeThongId, MaTBHeThong, TenTBHeThong, MaNhom, MaChungLoai, MaDVT, NamSX == "" ? new Nullable<DateTime>() : DateTime.Parse(NamSX), KhoiLuong, TyLeKH, BaoHanh, DonGia, NguyenTe, KyBaoDuong, DacTinhKT, MaNSX, MaQuocGia, Ghichu, MaMay, NguoiSD, Huy, IsSuDung).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBHeThong_Delete", TBHeThongId, MaMay, NguoiHuy).ToString();
        }

    }

    [Serializable]
    public class DMTBHeThongs: List<DMTBHeThong>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        private Int32 _countRowTotal = 0;
        public Int32 CountRowTotal
        {
            get
            {
                return _countRowTotal;
            }
        }
        public static DMTBHeThongs Find(Int32 SoTrang, Int32 SoDong, Boolean Qadmin, String DieuKien)
        {
            DMTBHeThongs List = new DMTBHeThongs();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spDMTBHeThong_Find", SoTrang, SoDong, Qadmin, DieuKien))
            {
                int Ordernumber = SoTrang * SoDong;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoDong)
                    {
                        List._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                    }
                    Ordernumber++;
                    List.Add(new DMTBHeThong(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
