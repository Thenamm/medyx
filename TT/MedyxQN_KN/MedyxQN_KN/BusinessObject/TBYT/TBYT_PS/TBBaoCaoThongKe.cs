using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    public class TBBaoCaoThongKe
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static DataSet CRBCLKTonKhoKhoa(DateTime Thang, String MaKho, String MaKhoa, Byte LoaiLK, String MaNhom)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCLKTonKhoKhoa", Thang, MaKho, MaKhoa, LoaiLK, MaNhom);
        }

        public static DataSet CRBCTBTonKhoKhoa(DateTime Thang, String MaKho, String MaKhoa, Byte LoaiLK, String MaNhom)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCTBTonKhoKhoa", Thang, MaKho, MaKhoa, LoaiLK, MaNhom);
        }

        public static DataSet CRBCTBNhapToanKho(DateTime TuNgay, DateTime DenNgay, String MaKho, String MaNCC, String MaNhom, String MaChungLoai, Byte LoaiLK)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCTBNhapToanKho", TuNgay, DenNgay, MaKho, MaNCC, MaNhom, MaChungLoai, LoaiLK);
        }

        public static DataSet CRBCTBBaoDuongSuaChua(DateTime TuNgay, DateTime DenNgay, Byte Loai, String MaDVYC, Decimal TBYTId, String MaNoiSua)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCTBBaoDuongSuaChua", TuNgay, DenNgay, Loai, MaDVYC, TBYTId, MaNoiSua);
        }
    }
}
