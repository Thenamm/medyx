using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDNhapTra_Cs : List<HDNhapTra_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDNhapTra_Cs GetALL(String MaNT, Boolean QADMIN)
        {
            HDNhapTra_Cs obj = new HDNhapTra_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDNhapTra_C_GETALL", MaNT, QADMIN))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDNhapTra_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }


        public static DataSet CrBCGetALL(String MaNT, Boolean QADMIN)
        {
            DataSet ds = new DataSet("crPhieuXuat_C_GetAll");
            string[] s = { "crPhieuXuat_C_GetAll" };
            SqlHelper.FillDataset(strConnect, "spHDNhapTra_C_GETALL", ds, s, MaNT, QADMIN);
            return ds;
        }
    }
}