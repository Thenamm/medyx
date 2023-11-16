using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using Microsoft.ApplicationBlocks.Data;
using System.Data;
namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTPhieuNhap_Cs : List<TBVTPhieuNhap_C>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBVTPhieuNhap_Cs()
        {

        }

        public static TBVTPhieuNhap_Cs GetByMaPN(Boolean Qadmin, String MaPN)
        {
            TBVTPhieuNhap_Cs list = new TBVTPhieuNhap_Cs();
            int i = 1;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuNhap_C_GETALL", Qadmin, MaPN)))
            {
                while (dr.Read())
                {
                    list.Add(new TBVTPhieuNhap_C(dr, i));
                    i++;
                }
            }
            return list;
        }
    }
}
