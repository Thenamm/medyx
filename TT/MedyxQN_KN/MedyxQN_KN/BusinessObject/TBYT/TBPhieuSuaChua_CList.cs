using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBPhieuSuaChua_CList: List<TBPhieuSuaChua_C>
	{
		private static string ConnectString
		{
			get
			{
                return System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
			}
		}
		public TBPhieuSuaChua_CList()
		{

		}

		public static TBPhieuSuaChua_CList GetAll(String MaPhieuYC, Boolean QuyenAdmin)
		{
			TBPhieuSuaChua_CList List = new TBPhieuSuaChua_CList();
			int Ordernumber = 0;
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_GetAll", MaPhieuYC, QuyenAdmin)))
			{
				while (dr.Read())
				{
					Ordernumber ++;
					List.Add(new TBPhieuSuaChua_C(dr, Ordernumber));
				}
			}
			return List;
		}

        public static TBPhieuSuaChua_CList KhaoSatGetAll(DateTime Ngayyeucaubatdau, DateTime Ngayyeucauketthuc, String MaKhoaYC, Boolean Quyenadmin, Boolean DaLap, Boolean DaDuyet, String Acount)
		{
			TBPhieuSuaChua_CList List = new TBPhieuSuaChua_CList();
			int Ordernumber = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_KhaoSatGetAll", Ngayyeucaubatdau, Ngayyeucauketthuc, MaKhoaYC, Quyenadmin, DaLap, DaDuyet, Acount)))
			{
				while (dr.Read())
				{
					Ordernumber ++;
					List.Add(new TBPhieuSuaChua_C(dr, Ordernumber));
				}
			}
			return List;
		}

		public static TBPhieuSuaChua_CList DuTruGetAll(DateTime Ngayyeucaubatdau, DateTime Ngayyeucauketthuc, String MaKhoaYC, Boolean Quyenadmin, Nullable<Boolean> DaLap, Nullable<Boolean> DaDuyet, String Acount)
		{
			TBPhieuSuaChua_CList List = new TBPhieuSuaChua_CList();
			int Ordernumber = 0;
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DuTruGetAll", Ngayyeucaubatdau, Ngayyeucauketthuc, MaKhoaYC, Quyenadmin, DaLap, DaDuyet, Acount)))
			{
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new TBPhieuSuaChua_C(dr, Ordernumber));
				}
			}
			return List;
		}


        public static TBPhieuSuaChua_CList DaSuaGetAll(DateTime Ngayyeucaubatdau, DateTime Ngayyeucauketthuc, String MaDVYCSC, String MaNVSuaChua, Byte TrangThaiCV, String Acount)
		{
			TBPhieuSuaChua_CList List = new TBPhieuSuaChua_CList();
			int Ordernumber = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DaSua_GetAll", Ngayyeucaubatdau, Ngayyeucauketthuc, MaDVYCSC, MaNVSuaChua, TrangThaiCV, Acount)))
			{
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new TBPhieuSuaChua_C(dr, Ordernumber));
				}
			}
			return List;
		}
	}
}
