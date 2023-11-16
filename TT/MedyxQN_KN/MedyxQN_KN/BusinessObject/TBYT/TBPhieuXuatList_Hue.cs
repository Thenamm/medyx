using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;
using Csla.Data;
using HTC.Business;
using Csla;

namespace HTC.BusinessObject.TBYT
{
	public class TBPhieuXuatList_Hue : List<TBPhieuXuat_Hue>
	{
		public TBPhieuXuatList_Hue()
		{

		}

		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

		public static TBPhieuXuatList_Hue  GetAll(String Account, String MaKho, Byte LoaiPhieu, DateTime TuNgay, DateTime DenNgay)
		{
			
			TBPhieuXuatList_Hue ListHue = new TBPhieuXuatList_Hue();
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUXUAT_GETALL", Account, MaKho, LoaiPhieu, TuNgay, DenNgay)))
			{
				int i = 0;
				while (dr.Read())
				{
					i++;
					ListHue.Add(new TBPhieuXuat_Hue(dr, i));
				}
			}
			return ListHue;
		}

		public static TBPhieuXuat_Hue Get(decimal MaPX, Byte LoaiPhieu)
		{
			TBPhieuXuat_Hue Items = new TBPhieuXuat_Hue();
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuXuat_Hue_Get(MaPX,LoaiPhieu)))
			{
				while (dr.Read())
				{
					return new TBPhieuXuat_Hue(dr, 1);
				}
			}
			return null;
		}

        public static TBPhieuXuatList_Hue FindMaTB(String MaTB)
        {
            TBPhieuXuatList_Hue List = new TBPhieuXuatList_Hue();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUXUAT_ByMaTB", MaTB))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBPhieuXuat_Hue(dr, Ordernumber));
                }
            }
            return List;
        }   

		public static void Delete(string NguoiHuy, decimal MaPX)
		{
			DataProvider.Instance().DeleteTBPhieuXuat_Hue(NguoiHuy,MaPX);
		}

		public static Decimal AddItems(String Noixuat, String Noinhap, Byte Loaiphieu, DateTime Ngayxuat, DateTime NgayxuatTT, String NVXuat, String NVNhan, String Noidungxuat, String MaMay, String NguoiLap, Boolean DaPhat, Boolean DaDuyet, String MaTB, String Model, String SerialNo, String MaBarCode, Decimal Dongia)
		{
			return DataProvider.Instance().InsertTBPhieuXuat_Hue(Noixuat, Noinhap, Loaiphieu, Ngayxuat, NgayxuatTT, NVXuat, NVNhan, Noidungxuat, MaMay, NguoiLap, DaPhat, DaDuyet, MaTB, Model, SerialNo, MaBarCode, Dongia);
		}

		public static void EditItems(decimal Mapx, String Noixuat, String Noinhap, Byte Loaiphieu, DateTime Ngayxuat, DateTime NgayxuatTT, String NVXuat, String NVNhan, String Noidungxuat, String NguoiSD, Boolean Huy, Boolean DaPhat, Boolean DaDuyet, String MaTB, String Model, String SerialNo, String MaBarCode, Decimal Dongia)
		{
			DataProvider.Instance().UpdateTBPhieuXuat_Hue(Mapx, Noixuat, Noinhap, Loaiphieu, Ngayxuat, NgayxuatTT, NVXuat, NVNhan, Noidungxuat, NguoiSD, Huy, DaPhat, DaDuyet, MaTB, Model, SerialNo, MaBarCode, Dongia);
		}

	}
}
