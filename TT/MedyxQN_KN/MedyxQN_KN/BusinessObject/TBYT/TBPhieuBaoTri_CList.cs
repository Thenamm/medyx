using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.BusinessObject.TBYT
{
    [Serializable()]
	public class TBPhieuBaoTri_CList:List<TBPhieuBaoTri_C>
	{
		public TBPhieuBaoTri_CList()
		{

		}

	#region GetData
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

		public static TBPhieuBaoTri_CList GetAllByMaPhieu(Decimal MaPhieuBT, Boolean Quyenadmin)
		{
			TBPhieuBaoTri_CList ListItems = new TBPhieuBaoTri_CList();
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_C_GetByMaPhieuBT", MaPhieuBT, Quyenadmin)))
			{
				int order = 0;
				while (dr.Read())
				{
					order ++;
					ListItems.Add(new TBPhieuBaoTri_C(dr, order));
				}
			}
			return ListItems;
		}

		public static TBPhieuBaoTri_CList GetAllDuTru(DateTime NgayLapTTbatdau, DateTime NgayLapTTketthuc, String MaDVYC, String Acount, Boolean LapPhieu, Nullable<Boolean> DuyetDT)
		{
			TBPhieuBaoTri_CList ListItems = new TBPhieuBaoTri_CList();
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_C_DuTru_GetAll", NgayLapTTbatdau, NgayLapTTketthuc, MaDVYC, Acount, LapPhieu, DuyetDT)))
			{
				int order = 0;
				while (dr.Read())
				{
					order++;
					ListItems.Add(new TBPhieuBaoTri_C(dr, order));
				}
			}
			return ListItems;
		}

		public static TBPhieuBaoTri_CList GetAllNhapBaoTri(DateTime NgayLapTTbatdau, DateTime NgayLapTTketthuc, String MaDVYC, String Acount, byte TrangthaiCV)
		{
			TBPhieuBaoTri_CList ListItems = new TBPhieuBaoTri_CList();
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_C_NhapBT_GetAll", NgayLapTTbatdau, NgayLapTTketthuc, MaDVYC, Acount, TrangthaiCV)))
			{
				int order = 0;
				while (dr.Read())
				{
					order++;
					ListItems.Add(new TBPhieuBaoTri_C(dr, order));
				}
			}
			return ListItems;
		}

	#endregion

	}
}
