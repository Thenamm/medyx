using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace HTC.BusinessObject.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBPhieuMuaLK
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal STT { get; set; }
        public Decimal TBPhieuBaoTri_CId { get; set; }
        public String TenLinhKien { get; set; }
        public String SerialNo { get; set; }
        public String Model { get; set; }
        public Int32 SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public String GhiChu { get; set; }
        public Boolean Huy { get; set; }
        public Decimal ThanhTien
        {
            get
            {
                return DonGia * SoLuong;
            }
        }
        public TBPhieuMuaLK()
        {
            STT = 0;
            TBPhieuBaoTri_CId = 0;
            TenLinhKien = "";
            SerialNo = "";
            Model = "";
            SoLuong = 0;
            DonGia = 0;
            GhiChu = "";
            Huy = false;
            Ordernumber = 0;
        }

        public TBPhieuMuaLK(Decimal STT, Decimal TBPhieuBaoTri_CId, String TenLinhKien, String SerialNo, String Model, Int32 SoLuong, Decimal DonGia, String GhiChu, Boolean Huy, Int32 Ordernumber)
        {
            this.STT = STT;
            this.TBPhieuBaoTri_CId = TBPhieuBaoTri_CId;
            this.TenLinhKien = TenLinhKien;
            this.SerialNo = SerialNo;
            this.Model = Model;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.GhiChu = GhiChu;
            this.Huy = Huy;
            this.Ordernumber = Ordernumber;
        }
        public TBPhieuMuaLK(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            {
                this.STT = Convert.ToDecimal(dr["STT"]);
            }
            else
            {
                this.STT = 0;
            }
            if (dr["TBPhieuBaoTri_CId"].GetType().Name != "DBNull" && dr["TBPhieuBaoTri_CId"] != null)
            {
                this.TBPhieuBaoTri_CId = Convert.ToDecimal(dr["TBPhieuBaoTri_CId"]);
            }
            else
            {
                this.TBPhieuBaoTri_CId = 0;
            }
            if (dr["TenLinhKien"].GetType().Name != "DBNull" && dr["TenLinhKien"] != null)
            {
                this.TenLinhKien = Convert.ToString(dr["TenLinhKien"]);
            }
            else
            {
                this.TenLinhKien = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["SoLuong"].GetType().Name != "DBNull" && dr["SoLuong"] != null)
            {
                this.SoLuong = Convert.ToInt32(dr["SoLuong"]);
            }
            else
            {
                this.SoLuong = 0;
            }
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            this.Ordernumber = Ordernumber;
        }


        public static TBPhieuMuaLK GetBySTT(Decimal STT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuMuaLK_Get", STT)))
            {
                while (dr.Read())
                {
                    return new TBPhieuMuaLK(dr, 1);
                }
            }
            return null;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuMuaLK_Insert", TBPhieuBaoTri_CId, TenLinhKien, SerialNo, Model, SoLuong, DonGia, GhiChu).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuMuaLK_Update", STT, TBPhieuBaoTri_CId, TenLinhKien, SerialNo, Model, SoLuong, DonGia, GhiChu, Huy).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuMuaLK_Delete", STT).ToString();
        }

    }

    [Serializable()]
    public class TBPhieuMuaLKList : List<TBPhieuMuaLK>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBPhieuMuaLKList GetAll(Decimal TBPhieuBaoTri_CId, String Account
)
        {
            TBPhieuMuaLKList ListItems = new TBPhieuMuaLKList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuMuaLK_GetAll", TBPhieuBaoTri_CId, Account)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new TBPhieuMuaLK(dr, order));
                }
            }
            return ListItems;
        }
    }
}
