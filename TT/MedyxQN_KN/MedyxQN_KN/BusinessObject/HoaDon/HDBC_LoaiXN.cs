using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;


namespace HTC.Business.HoaDon
{
    [Serializable]
    public class HDBC_LoaiXN
    {
        public int Key { get; set; }
        public String Value  { get; set; }

        public HDBC_LoaiXN()
        {
            Key = 0;
            Value = string.Empty;
        }

        public HDBC_LoaiXN(int Key, String Value)
        {
            this.Key = Key;
            this.Value = Value;
        }       
    }

    [Serializable]
    public class HDBC_LoaiXNList : List<HDBC_LoaiXN>
    {
        public static HDBC_LoaiXNList Get(Byte Loai, Byte LoaiBC)
        {
            HDBC_LoaiXNList obj = new HDBC_LoaiXNList();
            using (IDataReader dr = SqlHelper.ExecuteReader(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spHDBC_LoaiXN", Loai, LoaiBC))
            {
                while (dr.Read())
                {
                    obj.Add(new HDBC_LoaiXN(string.IsNullOrEmpty(dr["Key"].ToString()) ? 0 : int.Parse(dr["Key"].ToString()), string.IsNullOrEmpty(dr["Value"].ToString()) ? "" : dr["Value"].ToString()));
                }
            }
            return obj;
        }
    }


    public class BCHoaDon
    {
        public static DataSet HDPhieuNhap(DateTime TUNGAY, DateTime DENNGAY, String KyHieuMau, String KyHieu, String DK)
        {
            DataSet ds = new DataSet("spCRHDPhieuNhap_C_GETALL");
            string[] s = { "spCRHDPhieuNhap_C_GETALL" };
            SqlHelper.FillDataset(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spCRHDPhieuNhap_C_GETALL", ds, s, TUNGAY, DENNGAY, KyHieuMau, KyHieu, DK);
            return ds;
        }


        public static DataSet HDPhieuXuat(DateTime TuNgay, DateTime DenNgay, Byte Loai, String KyHieuMau, String KyHieu, String DK)
        {
            DataSet ds = new DataSet();
            string[] s = {};
            SqlHelper.FillDataset(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spCRHDPHieuXuat_GETALL", ds, s, TuNgay, DenNgay, Loai, KyHieuMau, KyHieu, DK);
            return ds;
        }

        public static DataSet HDNhapTra(DateTime TuNgay, DateTime DenNgay, Byte Loai, String KyHieuMau, String KyHieu, String DK)
        {
            DataSet ds = new DataSet();
            string[] s = { };
            SqlHelper.FillDataset(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spCRHDNhapTra_GETALL", ds, s, TuNgay, DenNgay, Loai, KyHieuMau, KyHieu, DK);
            return ds;
        }


        public static DataSet HDXNTKhoChiTiet(DateTime TuNgay, DateTime DenNgay, String NoiSuDung, String KyHieuMau, String KyHieu)
        {
            DataSet ds = new DataSet();
            string[] s = { };
            SqlHelper.FillDataset(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spHDXNTKhoChiTiet", ds, s, TuNgay, DenNgay, NoiSuDung, KyHieuMau, KyHieu);
            return ds;
        }
    }
}
