using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using System.Data;
using HTC.Business;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTPhieuXuat_Cs : List<TBVTPhieuXuat_C>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBVTPhieuXuat_Cs()
        {

        }

        public static TBVTPhieuXuat_Cs GetBy(String MAPX, Boolean Qadmin)
        {
            TBVTPhieuXuat_Cs List = new TBVTPhieuXuat_Cs();
            int STT = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_C_GETALL", MAPX, Qadmin)))
            {
                while (dr.Read())
                {
                    STT++;
                    List.Add(new TBVTPhieuXuat_C(dr, STT));
                }
            }
            return List;
        }

    }
}