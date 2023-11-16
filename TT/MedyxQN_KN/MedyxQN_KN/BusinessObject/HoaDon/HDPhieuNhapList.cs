using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuNhapList : List<HDPhieuNhap >
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDPhieuNhapList GetALL(Boolean QADMIN, String MAKHO, String MANCC, DateTime TUNGAY, DateTime DENNGAY, String DK)
        {
            HDPhieuNhapList obj = new HDPhieuNhapList();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuNhap_GETALL", QADMIN, MAKHO, MANCC, TUNGAY, DENNGAY, DK))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDPhieuNhap(dr, stt));
                    stt++;
                }
            }
            return obj;
        }

        public static HDPhieuNhapList Find(Boolean QADMIN, String DK)
        {
            HDPhieuNhapList obj = new HDPhieuNhapList();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuNhap_FINDS", QADMIN, DK))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDPhieuNhap(dr, stt));
                    stt++;
                }
            }
            return obj;
        }
    }
}
