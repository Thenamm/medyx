using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for TBVTTonkhoaList
/// </summary>
/// 
namespace Dzual.CategoryList
{
    [Serializable()]
    public class TBVTTonkhoaList : List<TBVTTonkhoa>
    {
        public TBVTTonkhoaList()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBVTTonkhoaList GetAll(DateTime dthang, String sMaKhoa)
        {
            TBVTTonkhoaList List = new TBVTTonkhoaList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTTonkhoa_GetAll", dthang, sMaKhoa))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBVTTonkhoa(dr, Ordernumber));
                }
            }
            return List;
        }

        public static TBVTTonkhoaList GetAll(DateTime dthang, String sMaKhoa, String sMaNoiNhap, Boolean LoaiKho)
        {
            TBVTTonkhoaList List = new TBVTTonkhoaList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTTonkhoa_GetMaNoiNhap", dthang, sMaKhoa, sMaNoiNhap, LoaiKho))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBVTTonkhoa(dr, Ordernumber));
                }
            }
            return List;
        }

    }
}