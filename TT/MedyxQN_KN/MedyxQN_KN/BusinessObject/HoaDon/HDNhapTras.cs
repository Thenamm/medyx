using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDNhapTras : List<HDNhapTra>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDNhapTras GetALL(DateTime TUNGAY, DateTime DENNGAY, String MAKHO, Byte LOAI, Boolean DAPHAT, Boolean DADUYET, String DK, Boolean QADMIN)
        {
            HDNhapTras obj = new HDNhapTras();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDNhapTra_GETALL", TUNGAY, DENNGAY, MAKHO, LOAI, DAPHAT, DADUYET, DK, QADMIN))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDNhapTra(dr, stt));
                    stt++;
                }
            }
            return obj;
        }
    }
}
