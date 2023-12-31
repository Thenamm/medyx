using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBPhieuTraNgoai_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal PhieuXuat_CId { get; set; }
        public Decimal PhieuXuatId { get; set; }
        public Decimal TBYTId { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (TBYTId < 0 ? "HT" : "TB") + Math.Abs(TBYTId).ToString();
            }
        }
        public Decimal SoLuong { get; set; }
        public Decimal SLYC { get; set; }
        public Decimal DonGia { get; set; }
        public String GhiChu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenTBYT { get; set; }
        public String TenDVT { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }

        public TBPhieuTraNgoai_C()
        {
            PhieuXuat_CId = 0;
            PhieuXuatId = 0;
            TBYTId = 0;
            SoLuong = 0;
            SLYC = 0;
            DonGia = 0;
            GhiChu = "";
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenTBYT = "";
            TenDVT = "";
            Model = "";
            SerialNo = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TonCK = 0;
            TonCKDT = 0;
            Ordernumber = 0;
        }

        public TBPhieuTraNgoai_C(Decimal PhieuXuat_CId, Decimal PhieuXuatId, Decimal TBYTId, Decimal SoLuong, Decimal SLYC, Decimal DonGia, String GhiChu, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenTBYT, String TenDVT, String Model, String SerialNo, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Decimal TonCK, Decimal TonCKDT, Int32 Ordernumber)
        {
            this.PhieuXuat_CId = PhieuXuat_CId;
            this.PhieuXuatId = PhieuXuatId;
            this.TBYTId = TBYTId;
            this.SoLuong = SoLuong;
            this.SLYC = SLYC;
            this.DonGia = DonGia;
            this.GhiChu = GhiChu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenTBYT = TenTBYT;
            this.TenDVT = TenDVT;
            this.Model = Model;
            this.SerialNo = SerialNo;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TonCK = TonCK;
            this.TonCKDT = TonCKDT;
            this.Ordernumber = Ordernumber;
        }

        public TBPhieuTraNgoai_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["PhieuXuat_CId"].GetType().Name != "DBNull" && dr["PhieuXuat_CId"] != null)
            {
                this.PhieuXuat_CId = Convert.ToDecimal(dr["PhieuXuat_CId"]);
            }
            else
            {
                this.PhieuXuat_CId = 0;
            }
            if (dr["PhieuXuatId"].GetType().Name != "DBNull" && dr["PhieuXuatId"] != null)
            {
                this.PhieuXuatId = Convert.ToDecimal(dr["PhieuXuatId"]);
            }
            else
            {
                this.PhieuXuatId = 0;
            }
            if (dr["TBYTId"].GetType().Name != "DBNull" && dr["TBYTId"] != null)
            {
                this.TBYTId = Convert.ToDecimal(dr["TBYTId"]);
            }
            else
            {
                this.TBYTId = 0;
            }            
            if (dr["SoLuong"].GetType().Name != "DBNull" && dr["SoLuong"] != null)
            {
                this.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
            }
            else
            {
                this.SoLuong = 0;
            }
            if (dr["SLYC"].GetType().Name != "DBNull" && dr["SLYC"] != null)
            {
                this.SLYC = Convert.ToDecimal(dr["SLYC"]);
            }
            else
            {
                this.SLYC = 0;
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
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
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
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
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
            if (dr["TonCK"].GetType().Name != "DBNull" && dr["TonCK"] != null)
            {
                this.TonCK = Convert.ToDecimal(dr["TonCK"]);
            }
            else
            {
                this.TonCK = 0;
            }
            if (dr["TonCKDT"].GetType().Name != "DBNull" && dr["TonCKDT"] != null)
            {
                this.TonCKDT = Convert.ToDecimal(dr["TonCKDT"]);
            }
            else
            {
                this.TonCKDT = 0;
            }
            this.Ordernumber = Ordernumber;
        }

        public static TBPhieuTraNgoai_C GetByMa(Decimal PhieuXuat_CId)
        {
            TBPhieuTraNgoai_C obj = new TBPhieuTraNgoai_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBPhieuTraNgoai_C_Get", PhieuXuat_CId))
            {
                while (dr.Read())
                {
                    obj = new TBPhieuTraNgoai_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            try
            {
                String Error = "";
                object[] paras ={  
                    new SqlParameter ("@PhieuXuatId", this.PhieuXuatId),
                    new SqlParameter ("@TBYTId", this.TBYTId),
                    new SqlParameter ("@SoLuong", this.SoLuong),
                    new SqlParameter ("@SLYC", this.SLYC),
                    new SqlParameter ("@DonGia", this.DonGia),
                    new SqlParameter ("@GhiChu", this.GhiChu),
                    new SqlParameter ("@MaMay", this.MaMay),
                    new SqlParameter ("@NguoiLap", this.NguoiLap),
                    new SqlParameter ("@Error", SqlDbType.NVarChar,200){Direction = ParameterDirection.Output}
                    };
                using (SqlConnection conn = new SqlConnection(strConnect))
                using (SqlCommand cmd = new SqlCommand("spTBPhieuTraNgoai_C_Create", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paras);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Error = (paras[8] as SqlParameter).Value.ToString();
                    conn.Close();
                };
                return Error;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update()
        {
            try
            {
                String Error = "";
                object[] paras ={
                    new SqlParameter ("@PhieuXuat_CId", this.PhieuXuat_CId),
                    new SqlParameter ("@PhieuXuatId", this.PhieuXuatId),
                    new SqlParameter ("@TBYTId", this.TBYTId),
                    new SqlParameter ("@SoLuong", this.SoLuong),
                    new SqlParameter ("@SLYC", this.SLYC),
                    new SqlParameter ("@DonGia", this.DonGia),
                    new SqlParameter ("@GhiChu", this.GhiChu),
                    new SqlParameter ("@MaMay", this.MaMay),
                    new SqlParameter ("@Huy", this.Huy),
                    new SqlParameter ("@NguoiSD", this.NguoiSD),
                    new SqlParameter ("@Error", SqlDbType.NVarChar,200){Direction = ParameterDirection.Output}
                    };
                using (SqlConnection conn = new SqlConnection(strConnect))
                using (SqlCommand cmd = new SqlCommand("spTBPhieuTraNgoai_C_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paras);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Error = (paras[10] as SqlParameter).Value.ToString();
                    conn.Close();
                };
                return Error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete()
        {
            try
            {
                String Error = "";
                object[] paras ={
                    new SqlParameter ("@PhieuXuat_CId", this.PhieuXuat_CId),
                    new SqlParameter ("@MaMay", this.MaMay),
                    new SqlParameter ("@NguoiHuy", this.NguoiHuy),
                    new SqlParameter ("@Error", SqlDbType.NVarChar,200){Direction = ParameterDirection.Output}
                    };
                using (SqlConnection conn = new SqlConnection(strConnect))
                using (SqlCommand cmd = new SqlCommand("spTBPhieuTraNgoai_C_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paras);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Error = (paras[3] as SqlParameter).Value.ToString();
                    conn.Close();
                };
                return Error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
    


    [Serializable()]
    public class TBPhieuTraNgoai_Cs : List<TBPhieuTraNgoai_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBPhieuTraNgoai_Cs GetALL(Decimal PhieuXuatId, Boolean Qadmin)
        {
            TBPhieuTraNgoai_Cs obj = new TBPhieuTraNgoai_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBPhieuTraNgoai_C_GetAll", PhieuXuatId, Qadmin))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new TBPhieuTraNgoai_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }

        public static TBPhieuTraNgoai_Cs GetByNoiXuat(Byte LoaiPhieu, String NoiXuat, String NoiNhan, DateTime Thang)
        {
            TBPhieuTraNgoai_Cs obj = new TBPhieuTraNgoai_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBPhieuTraNgoai_C_GetByMa", LoaiPhieu, NoiXuat, NoiNhan, Thang))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new TBPhieuTraNgoai_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }

        public static DataSet CRTBPhieuXuatKhoaGetId(Decimal PhieuXuatId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spCRTBPhieuXuatKhoaGetId", PhieuXuatId);
        }
    }
}