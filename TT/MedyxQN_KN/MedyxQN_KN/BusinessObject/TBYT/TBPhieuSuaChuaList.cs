using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
    public class TBPhieuSuaChuaList : List<TBPhieuSuaChua>
    {
        public TBPhieuSuaChuaList()
        {

        }
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBPhieuSuaChuaList GetAll(DateTime Ngayyeucaubatdau, DateTime Ngayyeucauketthuc, String MaKhoaYC, Boolean Quyenadmin, Nullable<Boolean> DaDuyet, String Acount)
        {
            TBPhieuSuaChuaList Lists = new TBPhieuSuaChuaList();
            int Ordernumber = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_GetAll", Ngayyeucaubatdau, Ngayyeucauketthuc, MaKhoaYC, Quyenadmin, DaDuyet, Acount)))
            {
                while (dr.Read())
                {
                    Ordernumber++;
                    Lists.Add(new TBPhieuSuaChua(dr, Ordernumber));
                }
            }
            return Lists;
        }
    }
}
