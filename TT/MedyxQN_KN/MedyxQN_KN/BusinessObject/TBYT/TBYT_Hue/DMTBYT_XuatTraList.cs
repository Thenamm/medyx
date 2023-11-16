using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class DMTBYT_XuatTraList : List<DMTBYT_XuatTra>
    {
        public DMTBYT_XuatTraList()
        {
            
        }
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMTBYT_XuatTraList GetByMaKho(DateTime Thang, String MaKho, Boolean isKhoa)
        {
            DMTBYT_XuatTraList List = new DMTBYT_XuatTraList();
            List.Add(new DMTBYT_XuatTra());
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_XUATTRA_GET", Thang, MaKho, isKhoa))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMTBYT_XuatTra(dr, Ordernumber));
                }
            }
            return List;
        }
    }

}