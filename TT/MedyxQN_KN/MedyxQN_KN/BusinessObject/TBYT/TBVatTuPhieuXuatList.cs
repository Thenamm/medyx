using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBVatTuPhieuXuatList: List<TBVatTuPhieuXuat>
	{
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}
		public TBVatTuPhieuXuatList()
		{

		}

		public static TBVatTuPhieuXuatList GetAll(Boolean QuyenAdmin, String MaKho, Byte Loai, Boolean DaPhat, DateTime TuNgay, DateTime DenNgay, String DK, Boolean DaDuyet)
		{
			TBVatTuPhieuXuatList List = new TBVatTuPhieuXuatList();
			int Ordernumber = 0;
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_GETALL", QuyenAdmin, MaKho, Loai, DaPhat, TuNgay, DenNgay, DK, DaDuyet)))
			{
				while (dr.Read())
				{
					Ordernumber ++;
					List.Add(new TBVatTuPhieuXuat(dr, Ordernumber));
				}
			}
			return List;
		}
	}
}
