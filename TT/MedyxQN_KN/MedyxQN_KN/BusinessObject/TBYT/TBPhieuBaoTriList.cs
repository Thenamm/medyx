using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBPhieuBaoTriList:List<TBPhieuBaoTri>
	{
		public TBPhieuBaoTriList()
		{

		}

		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

		public static TBPhieuBaoTriList GetAll(DateTime NgayLapTTbatdau, DateTime NgayLapTTketthuc, String MaDVYC, String Account)
		{
			TBPhieuBaoTriList ListItems = new TBPhieuBaoTriList();
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_GetAll", NgayLapTTbatdau, NgayLapTTketthuc, MaDVYC, Account)))
			{
				int order =0;
				while (dr.Read())
				{
					order ++;
					ListItems.Add(new TBPhieuBaoTri(dr, order));
				}
			}
			return ListItems;
		}
	}
}
