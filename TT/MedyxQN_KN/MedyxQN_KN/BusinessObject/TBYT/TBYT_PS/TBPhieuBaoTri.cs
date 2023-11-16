using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace HTC.BusinessObject.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBPhieuBaoTri
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal MaPhieuBT { get; set; }
        public String MaPhieuYC { get; set; }
        public String NgayYC { get; set; }
        public String NVYC { get; set; }
        public String DVYC { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenNVYC { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenDVYC { get; set; }
        public Boolean isDuyetXN { get; set; }
        public Boolean isBT { get; set; }

        public TBPhieuBaoTri()
        {
            MaPhieuBT = 0;
            MaPhieuYC = "";
            NgayYC = "";
            NVYC = "";
            DVYC = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            NgayHuy = "";
            NguoiHuy = "";
            TenNVYC = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenDVYC = "";
            Ordernumber = 0;
            isDuyetXN = false;
            isBT = false;
        }

        public TBPhieuBaoTri(Decimal MaPhieuBT, String MaPhieuYC, String NgayYC, String NVYC, String DVYC, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String NgayHuy, String NguoiHuy, String TenNVYC, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenDVYC, Boolean isDuyetXN, Boolean isBT, Int32 Ordernumber)
        {
            this.MaPhieuBT = MaPhieuBT;
            this.MaPhieuYC = MaPhieuYC;
            this.NgayYC = NgayYC;
            this.NVYC = NVYC;
            this.DVYC = DVYC;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenNVYC = TenNVYC;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenDVYC = TenDVYC;
            this.Ordernumber = Ordernumber;
            this.isDuyetXN = isDuyetXN;
            this.isBT = isBT;
        }
        public TBPhieuBaoTri(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuBT"].GetType().Name != "DBNull" && dr["MaPhieuBT"] != null)
            {
                this.MaPhieuBT = Convert.ToDecimal(dr["MaPhieuBT"]);
            }
            else
            {
                this.MaPhieuBT = 0;
            }
            if (dr["MaPhieuYC"].GetType().Name != "DBNull" && dr["MaPhieuYC"] != null)
            {
                this.MaPhieuYC = Convert.ToString(dr["MaPhieuYC"]);
            }
            else
            {
                this.MaPhieuYC = "";
            }
            if (dr["NgayYC"].GetType().Name != "DBNull" && dr["NgayYC"] != null)
            {
                this.NgayYC = Convert.ToDateTime(dr["NgayYC"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayYC = "";
            }
            if (dr["NVYC"].GetType().Name != "DBNull" && dr["NVYC"] != null)
            {
                this.NVYC = Convert.ToString(dr["NVYC"]);
            }
            else
            {
                this.NVYC = "";
            }
            if (dr["DVYC"].GetType().Name != "DBNull" && dr["DVYC"] != null)
            {
                this.DVYC = Convert.ToString(dr["DVYC"]);
            }
            else
            {
                this.DVYC = "";
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
            if (dr["TenNVYC"].GetType().Name != "DBNull" && dr["TenNVYC"] != null)
            {
                this.TenNVYC = Convert.ToString(dr["TenNVYC"]);
            }
            else
            {
                this.TenNVYC = "";
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
            if (dr["TenDVYC"].GetType().Name != "DBNull" && dr["TenDVYC"] != null)
            {
                this.TenDVYC = Convert.ToString(dr["TenDVYC"]);
            }
            else
            {
                this.TenDVYC = "";
            }
            if (dr["isDuyetXN"].GetType().Name != "DBNull" && dr["TenDVYC"] != null)
            {
                this.isDuyetXN = Convert.ToBoolean(dr["isDuyetXN"]);
            }
            else
            {
                this.isDuyetXN = false;
            }
            if (dr["isBT"].GetType().Name != "DBNull" && dr["isBT"] != null)
            {
                this.isBT = Convert.ToBoolean(dr["isBT"]);
            }
            else
            {
                this.isBT = false;
            }
            this.Ordernumber = Ordernumber;
        }

        public static TBPhieuBaoTri GetByMaPhieu(Decimal MaPhieuBT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuBaoTri_Get", MaPhieuBT)))
            {
                while (dr.Read())
                {
                    return new TBPhieuBaoTri(dr, 1);
                }
            }
            return null;
        }

        public static DataSet GetReportById(Decimal MaPhieuBT, Byte ChucNang, Boolean Duyet, String Account)
        {
            var result = new Object[]
            {
                new SqlParameter("@MaPhieuBT", MaPhieuBT),
                new SqlParameter("@ChucNang", ChucNang),
                new SqlParameter("@Duyet", Duyet),
                new SqlParameter("@Account", Account),
            };
            return SqlHelper.ExecuteDataset(strConnect, "spTBPhieuBaoTriReportById", result);
        }


        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_Insert", MaPhieuBT, MaPhieuYC, NgayYC == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayYC), NVYC, DVYC, NguoiLap, isBT).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_Update", MaPhieuBT, MaPhieuYC, NgayYC == null ? new Nullable<DateTime>() : DateTime.Parse(NgayYC), NVYC, DVYC, NguoiSD, Huy, isBT).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_Delete", MaPhieuBT, NguoiHuy).ToString();
        }

    }

    [Serializable()]
    public class TBPhieuBaoTriList : List<TBPhieuBaoTri>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBPhieuBaoTriList GetAll(DateTime TuNgay, DateTime DenNgay, Byte ChucNang, Boolean Duyet, String Account, String MaKhoa, String DieuKien, Boolean isBT = false)
        {
            TBPhieuBaoTriList ListItems = new TBPhieuBaoTriList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuBaoTri_GetAll", TuNgay, DenNgay, ChucNang, Duyet, Account, MaKhoa, DieuKien, isBT)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new TBPhieuBaoTri(dr, order));
                }
            }
            return ListItems;
        }
    }
}
