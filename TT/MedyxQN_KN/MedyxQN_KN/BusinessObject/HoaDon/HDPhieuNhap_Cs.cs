using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuNhap_Cs : List<HDPhieuNhap_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDPhieuNhap_Cs GetALL(String MaPN, Boolean Qadmin)
        {
            HDPhieuNhap_Cs obj = new HDPhieuNhap_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuNhap_C_GETALL", MaPN, Qadmin))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDPhieuNhap_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }

        public static DataSet crHDPhieuNhap_C_GetAll (Boolean _qadmin, String _maPN)
        {
            DataSet ds = new DataSet("crPhieuNhap_C_GetAll");
            string[] s = { "crPhieuNhap_C_GetAll" };
            SqlHelper.FillDataset(strConnect, "spHDPhieuNhap_C_GETALL", ds, s, _maPN, _qadmin);           
            return ds;

        }        
    }
}