using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBVatTuPhieuXuat_CList : List<TBVatTuPhieuXuat_C>
	{
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}
		public TBVatTuPhieuXuat_CList()
		{

		}

		public static TBVatTuPhieuXuat_CList GetAll(String MaPX, Boolean QuyenAdmin)
		{
			TBVatTuPhieuXuat_CList List = new TBVatTuPhieuXuat_CList();
			int Ordernumber = 0;
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_C_GETALL", MaPX, QuyenAdmin)))
			{
				while (dr.Read())
				{
					Ordernumber ++;
					List.Add(new TBVatTuPhieuXuat_C(dr, Ordernumber));
				}
			}
			return List;
		}
	}
}
