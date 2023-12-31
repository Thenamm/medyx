using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDKiemKe_HDList : List<HDKiemKe_HD>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDKiemKe_HDList GetALL(String MaKK, Boolean QAdmin)
        {
            HDKiemKe_HDList obj = new HDKiemKe_HDList();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDKiemKe_HD_GETALL", MaKK, QAdmin))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDKiemKe_HD(dr, stt));
                    stt++;
                }
            }
            return obj;
        }


        public static DataSet CrBCGetALL(String MaKK, Boolean QAdmin)
        {
            DataSet ds = new DataSet("crKiemKe");
            string[] s = { "crKiemKe" };
            SqlHelper.FillDataset(strConnect, "spBCHDKiemKe_HDGetAll", ds, s, MaKK, QAdmin);
            return ds;
        }
    }
}
