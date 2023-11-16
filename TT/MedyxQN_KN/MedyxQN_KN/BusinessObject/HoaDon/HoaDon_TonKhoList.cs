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
    public class HoaDon_TonKhoList : List<HoaDon_TonKho>
    {
         private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();


         public static HoaDon_TonKhoList GetALL(String MaKho, DateTime Thang)
         {
             HoaDon_TonKhoList obj = new HoaDon_TonKhoList();
             using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHoaDon_TON_GETSKHO", Thang, MaKho))
             {
                 int stt = 1;
                 while (dr.Read())
                 {
                     obj.Add(new HoaDon_TonKho(dr, stt));
                     stt++;
                 }
             }
             return obj;
         }

         public static HoaDon_TonKhoList Find(DateTime Thang, String MaKho, String KyHieuMau, String KyHieu, Decimal TuSo, Decimal DenSo)
         {
             HoaDon_TonKhoList obj = new HoaDon_TonKhoList();
             using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHoaDon_TON_Find", Thang, MaKho, KyHieuMau, KyHieu, TuSo, DenSo))
             {
                 int stt = 1;
                 while (dr.Read())
                 {
                     obj.Add(new HoaDon_TonKho(dr, stt));
                     stt++;
                 }
             }
             return obj;
         }
    }
}
