using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuXuat_Cs : List<HDPhieuXuat_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDPhieuXuat_Cs GetALL(String MAPX, Boolean QADMIN)
        {
            HDPhieuXuat_Cs obj = new HDPhieuXuat_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPHIEUXUAT_C_GETALL", MAPX, QADMIN))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDPhieuXuat_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }


        public static DataSet CrBCGetALL(String MAPX, Boolean QADMIN)
        {
            DataSet ds = new DataSet("crPhieuXuat_C_GetAll");
            string[] s = { "crPhieuXuat_C_GetAll" };
            SqlHelper.FillDataset(strConnect, "spHDPHIEUXUAT_C_GETALL", ds, s, MAPX, QADMIN);
            return ds;
        }
    }
}