using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HoaDon_TonKhoaList : List<HoaDon_TonKhoa>
    {
         private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();


         public static HoaDon_TonKhoaList GetALL(String Makhoa, DateTime Thang)
         {
             HoaDon_TonKhoaList obj = new HoaDon_TonKhoaList();
             using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHoaDon_TON_GETSKhoa", Thang, Makhoa))
             {
                 int stt = 1;
                 while (dr.Read())
                 {
                     obj.Add(new HoaDon_TonKhoa(dr, stt));
                     stt++;
                 }
             }
             return obj;
         }

         public static HoaDon_TonKhoaList Find(DateTime Thang, String Makhoa, String KyHieuMau, String KyHieu, Decimal TuSo, Decimal DenSo)
         {
             HoaDon_TonKhoaList obj = new HoaDon_TonKhoaList();
             using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHoaDon_TON_FindKhoa", Thang, Makhoa, KyHieuMau, KyHieu, TuSo, DenSo))
             {
                 int stt = 1;
                 while (dr.Read())
                 {
                     obj.Add(new HoaDon_TonKhoa(dr, stt));
                     stt++;
                 }
             }
             return obj;
         }
    }
}
