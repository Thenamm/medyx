using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDKiemKeList : List<HDKiemKe>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDKiemKeList GetALL(String MaKho, DateTime TuNgay, DateTime DenNgay, String DK, Boolean QADMIN)
        {
         
            HDKiemKeList obj = new HDKiemKeList();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDKiemKe_GETALL", MaKho, TuNgay, DenNgay, DK, QADMIN))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDKiemKe(dr, stt));
                    stt++;
                }
            }
            return obj;
        }
    }
}
