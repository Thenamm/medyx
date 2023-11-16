using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
	public class Dzual_DMKhoaList: List<Dzual_DMKhoa>
	{
		public Dzual_DMKhoaList()
		{
		
		}
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}
		public static Dzual_DMKhoaList GetAll(String _account)
		{
			Dzual_DMKhoaList List = new Dzual_DMKhoaList();
			using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMKhoa_SelectByAccount", _account))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new Dzual_DMKhoa(dr, Ordernumber));
				}
			}
			return List;
		}

		public static Dzual_DMKhoaList GetAllNULL(String _account)
		{
			Dzual_DMKhoaList List = new Dzual_DMKhoaList();
			Dzual_DMKhoa getItem = new Dzual_DMKhoa();
			getItem.TenKhoa = "Tất cả";
			List.Add(getItem);
			using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMKhoa_SelectByAccount", _account))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new Dzual_DMKhoa(dr, Ordernumber));
				}
			}
			return List;
		}
        /// <summary>
        /// Loại:1 tất cả các khoa, Loại:2 danh cho đơn vị sửa chữa, Loại 3 Dành cho khoa chứa những thiết bị thuộc đơn vị sửa chữa.
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Loai"></param>
        /// <param name="TuCap"></param>
        /// <param name="DenCap"></param>
        /// <returns></returns>
        public static DataTable FindAccount(String Account, Byte Loai, Byte TuCap = 1, Byte DenCap = 3)
        {
            return SqlHelper.ExecuteDataset(ConnectString, "dbo.spDMKhoa_FindAccount", Account, Loai, TuCap, DenCap).Tables[0];
           
        }
	}
}
