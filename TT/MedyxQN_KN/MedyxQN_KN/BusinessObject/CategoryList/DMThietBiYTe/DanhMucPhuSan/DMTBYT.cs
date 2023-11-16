using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable]
    public class DMTBYT
    {
        public Int32 Ordernumber { get; set; }
        public String TBYTMaId
        {
            get
            {
                return "TB" + Math.Abs(TBYTId).ToString();
            }
        }
        public Decimal TBYTId { get; set; }
        public String TenTBYT { get; set; }
        public String MaTBYT { get; set; }
        public Decimal TBHeThongId { get; set; }
        public String MaNhom { get; set; }
        public String MaChungLoai { get; set; }
        public String MaDVT { get; set; }
        public String NamSX { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
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
        public Decimal ParentId { get; set; }
        public String TenNhom { get; set; }
        public String TenChungLoai { get; set; }
        public String TenDVT { get; set; }
        public String TenNSX { get; set; }
        public String TenQuocGia { get; set; }
        public String TenTBHeThong { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenParentId { get; set; }
        public String TenNoiChua { get; set; }
        public Int32 CountRow { get; set; }
        public Boolean IsSuDung { get; set; }
        public String ToKhaiHQ { get; set; }
        public String Invoice { get; set; }
        public String CO { get; set; }
        public String CQ { get; set; }
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public DMTBYT()
        {
            TBYTId = 0;
            TenTBYT = "";
            MaTBYT = "";
            TBHeThongId = 0;
            MaNhom = "";
            MaChungLoai = "";
            MaDVT = "";
            NamSX = "";
            Model = "";
            SerialNo = "";
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
            ParentId = 0;
            TenNhom = "";
            TenChungLoai = "";
            TenDVT = "";
            TenNSX = "";
            TenQuocGia = "";
            TenTBHeThong = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenParentId = "";
            TenNoiChua = "";
            CountRow = 0;
            Ordernumber = 0;
            IsSuDung = false;
            ToKhaiHQ = "";
            Invoice = "";
            CO = "";
            CQ = "";
        }

        public DMTBYT(Decimal TBYTId, String TenTBYT, String MaTBYT, Decimal TBHeThongId, String MaNhom, String MaChungLoai, String MaDVT, String NamSX, String Model, String SerialNo, Decimal KhoiLuong, Decimal TyLeKH, Decimal BaoHanh, Decimal DonGia, Decimal NguyenTe, Int32 KyBaoDuong, String DacTinhKT, String MaNSX, String MaQuocGia, String Ghichu, String MaMay, String NgayHuy, String NguoiHuy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, Boolean IsKhoChua, String NoiChua, Decimal ParentId, String TenNhom, String TenChungLoai, String TenDVT, String TenNSX, String TenQuocGia, String TenTBHeThong, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenParentId, String TenNoiChua, Int32 CountRow, Boolean IsSuDung, Int32 Ordernumber, String ToKhaiHQ, String Invoice, String CO, String CQ)
        {
            this.TBYTId = TBYTId;
            this.TenTBYT = TenTBYT;
            this.MaTBYT = MaTBYT;
            this.TBHeThongId = TBHeThongId;
            this.MaNhom = MaNhom;
            this.MaChungLoai = MaChungLoai;
            this.MaDVT = MaDVT;
            this.NamSX = NamSX;
            this.Model = Model;
            this.SerialNo = SerialNo;
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
            this.ParentId = ParentId;
            this.TenNhom = TenNhom;
            this.TenChungLoai = TenChungLoai;
            this.TenDVT = TenDVT;
            this.TenNSX = TenNSX;
            this.TenQuocGia = TenQuocGia;
            this.TenTBHeThong = TenTBHeThong;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenParentId = TenParentId;
            this.TenNoiChua = TenNoiChua;
            this.CountRow = CountRow;
            this.IsSuDung = IsSuDung;
            this.Ordernumber = Ordernumber;
            this.ToKhaiHQ = ToKhaiHQ;
            this.Invoice = Invoice;
            this.CO = CO;
            this.CQ = CQ;
        }

        public DMTBYT(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["TBYTId"].GetType().Name != "DBNull" && dr["TBYTId"] != null)
            {
                this.TBYTId = Convert.ToDecimal(dr["TBYTId"]);
            }
            else
            {
                this.TBYTId = 0;
            }
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
            }
            if (dr["MaTBYT"].GetType().Name != "DBNull" && dr["MaTBYT"] != null)
            {
                this.MaTBYT = Convert.ToString(dr["MaTBYT"]);
            }
            else
            {
                this.MaTBYT = "";
            }
            if (dr["TBHeThongId"].GetType().Name != "DBNull" && dr["TBHeThongId"] != null)
            {
                this.TBHeThongId = Convert.ToDecimal(dr["TBHeThongId"]);
            }
            else
            {
                this.TBHeThongId = 0;
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
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
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
            if (dr["ParentId"].GetType().Name != "DBNull" && dr["ParentId"] != null)
            {
                this.ParentId = Convert.ToDecimal(dr["ParentId"]);
            }
            else
            {
                this.ParentId = 0;
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
            if (dr["TenTBHeThong"].GetType().Name != "DBNull" && dr["TenTBHeThong"] != null)
            {
                this.TenTBHeThong = Convert.ToString(dr["TenTBHeThong"]);
            }
            else
            {
                this.TenTBHeThong = "";
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
            if (dr["TenParentId"].GetType().Name != "DBNull" && dr["TenParentId"] != null)
            {
                this.TenParentId = Convert.ToString(dr["TenParentId"]);
            }
            else
            {
                this.TenParentId = "";
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
            if (dr["ToKhaiHQ"].GetType().Name != "DBNull" && dr["ToKhaiHQ"] != null)
            {
                this.ToKhaiHQ = Convert.ToString(dr["ToKhaiHQ"]);
            }
            else
            {
                this.ToKhaiHQ = "";
            }
            if (dr["Invoice"].GetType().Name != "DBNull" && dr["Invoice"] != null)
            {
                this.Invoice = Convert.ToString(dr["Invoice"]);
            }
            else
            {
                this.Invoice = "";
            }
            if (dr["CO"].GetType().Name != "DBNull" && dr["CO"] != null)
            {
                this.CO = Convert.ToString(dr["CO"]);
            }
            else
            {
                this.CO = "";
            }
            if (dr["CQ"].GetType().Name != "DBNull" && dr["CQ"] != null)
            {
                this.CQ = Convert.ToString(dr["CQ"]);
            }
            else
            {
                this.CQ = "";
            }
            this.Ordernumber = Ordernumber;
        }


        public static DMTBYT GetByMa(Decimal MaTBYT)
        {
            DMTBYT obj = new DMTBYT();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTBYT_GET", MaTBYT))
            {
                while (dr.Read())
                {
                    obj = new DMTBYT(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBYT_Create", MaTBYT, TenTBYT, TBHeThongId, MaNhom, MaChungLoai, MaDVT, NamSX == "" ? new Nullable<DateTime>() : DateTime.Parse(NamSX), Model, SerialNo, KhoiLuong, TyLeKH, BaoHanh, DonGia, NguyenTe, KyBaoDuong, DacTinhKT, MaNSX, MaQuocGia, Ghichu, MaMay, NguoiLap, ParentId, IsSuDung, ToKhaiHQ,Invoice,CO,CQ).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBYT_Update", TBYTId, MaTBYT, TenTBYT, TBHeThongId, MaNhom, MaChungLoai, MaDVT, NamSX == "" ? new Nullable<DateTime>() : DateTime.Parse(NamSX), Model, SerialNo, KhoiLuong, TyLeKH, BaoHanh, DonGia, NguyenTe, KyBaoDuong, DacTinhKT, MaNSX, MaQuocGia, Ghichu, MaMay, NguoiSD, Huy, ParentId, IsSuDung, ToKhaiHQ, Invoice, CO, CQ).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTBYT_Delete", TBYTId, MaMay, NguoiHuy).ToString();
        }

    }

    [Serializable]
    public class DMTBYTs : List<DMTBYT>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        private  Int32 _countRowTotal = 0;
        public Int32 CountRowTotal
        {
            get
            {
                return _countRowTotal;
            }
        }

        public static DMTBYTs Find(Int32 SoTrang, Int32 SoDong, Boolean Qadmin, String DieuKien)
        {
            DMTBYTs List = new DMTBYTs();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spDMTBYT_Find", SoTrang, SoDong, Qadmin, DieuKien))
            {
                int Ordernumber = SoTrang * SoDong;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoDong)
                    {
                        List._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                    }
                    Ordernumber++;
                    List.Add(new DMTBYT(dr, Ordernumber));
                }
            }
            return List;
        }

        public static DataTable CRDMTBYTHT()
        {
            return SqlHelper.ExecuteDataset(strConnect, "dbo.spCRDMTBYTHT").Tables[0];
        }


        public static DataTable DMTB_HTYT_BySearchChucNang(Decimal TBYTId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "dbo.spDMTB_HTYT_BySearchChucNang", TBYTId).Tables[0];
        }
    }
}
