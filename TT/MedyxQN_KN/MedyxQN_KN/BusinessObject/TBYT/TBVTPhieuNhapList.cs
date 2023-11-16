using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTPhieuNhapList :List<TBVTPhieuNhap>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBVTPhieuNhapList()
        {

        }

        public static TBVTPhieuNhapList GetAll(String Account, String MaKho, String MaNCC, DateTime TuNgay, DateTime DenNgay)
        {
            TBVTPhieuNhapList list = new TBVTPhieuNhapList();
            int i = 1;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuNhap_GETALL", Account, MaKho, MaNCC, TuNgay, DenNgay)))
            {
                while (dr.Read())
                {
                    list.Add(new TBVTPhieuNhap(dr, i));
                    i++;
                }
            }
            return list;
        }
    }
}
