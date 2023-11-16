using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;


namespace HTC.BusinessObject.CategoryList
{
    [Serializable()]
	public class DMTBYT_HueList: List<DMTBYT_Hue>
	{
		public DMTBYT_HueList()
		{

		}
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

        public DMTBYT_HueList DMTBYT_spDMTBYT_BYKHOKHOA(String MaNoiChua, String MaNhom, String Account)
		{
			DMTBYT_HueList List = new DMTBYT_HueList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_BYKHOKHOA", MaNoiChua, MaNhom, Account))
			{
				int Ordernumber = 0;
				while(dr.Read())
				{
					Ordernumber ++;
					List.Add(new DMTBYT_Hue(dr,Ordernumber));
				}
			}
			return List;
		}

		public static DMTBYT_HueList DMTBYT_GETALL(DateTime TuNgay, DateTime DenNgay, String Account)
		{
			DMTBYT_HueList List = new DMTBYT_HueList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_GETALL", TuNgay, DenNgay, Account))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new DMTBYT_Hue(dr, Ordernumber));
				}
			}
			return List;
		}

		public static DMTBYT_HueList DMTBYT_CanSuaChua(string Account, String MaPhieuYC)
		{
			DMTBYT_HueList List = new DMTBYT_HueList();
			using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_SuaChua", Account, MaPhieuYC))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new DMTBYT_Hue(dr, Ordernumber));
				}
			}
			return List;
		}

        public static DMTBYT_HueList DMTBYT_CanBaoTri(string Account, Decimal MaPhieuBT, String MaDonViYeuCau)
		{
			DMTBYT_HueList List = new DMTBYT_HueList();
			List.Add(new DMTBYT_Hue());
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_BaoTri", Account, MaPhieuBT, MaDonViYeuCau))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new DMTBYT_Hue(dr, Ordernumber));
				}
			}
			return List;
		}

	}
}
