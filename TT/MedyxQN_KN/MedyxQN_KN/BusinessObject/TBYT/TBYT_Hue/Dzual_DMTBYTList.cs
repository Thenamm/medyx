using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;


namespace Dzual.CategoryList
{
    [Serializable()]
	public class Dzual_DMTBYTList: List<Dzual_DMTBYT>
	{
		public Dzual_DMTBYTList()
		{

		}
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

        /// <summary>
        /// tìm kiếm thiết bị theo mã kho hoặc khoa và theo mã nhóm
        /// </summary>
        /// <param name="MaNoiChua"></param>
        /// <param name="MaNhom"></param>
        /// <param name="Account"></param>
        /// <returns></returns>
        public static Dzual_DMTBYTList DMTBYT_BYKHOKHOA(String MaNoiChua, String MaNhom, String Account)
		{
			Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_BYKHOKHOA", MaNoiChua, MaNhom, Account))
			{
				int Ordernumber = 0;
				while(dr.Read())
				{
					Ordernumber ++;
					List.Add(new Dzual_DMTBYT(dr,Ordernumber));
				}
			}
			return List;
		}
        /// <summary>
        /// Tìm kiếm thiết bị Loại 0: tất cả, Loại 1:khoa, Loại 2:kho
        /// </summary>
        /// <param name="LoaiNoiChua"></param>
        /// <param name="MaNoiChua"></param>
        /// <param name="MaNhom"></param>
        /// <param name="Account"></param>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        public static Dzual_DMTBYTList DMTBYT_Search(Byte LoaiNoiChua, String MaNoiChua, String MaNhom, String Account, String TenTB, DateTime NgayMua)
        {
            Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_Search", LoaiNoiChua, MaNoiChua, MaNhom, Account, TenTB, NgayMua))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new Dzual_DMTBYT(dr, Ordernumber));
                }
            }
            return List;
        }
        /// <summary>
        /// Lấy thiết bị từ ngày đến ngày theo account
        /// </summary>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <param name="Account"></param>
        /// <returns></returns>
		public static Dzual_DMTBYTList DMTBYT_GETALL(DateTime TuNgay, DateTime DenNgay, String Account)
		{
			Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_GETALL", TuNgay, DenNgay, Account))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new Dzual_DMTBYT(dr, Ordernumber));
				}
			}
			return List;
		}

        /// <summary>
        /// Lấy hết thông tin thiết bị theo account
        /// </summary>        
        /// <param name="Account"></param>
        /// <returns></returns>
        public static Dzual_DMTBYTList DMTBYT_GETALL(String Account)
        {
            Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_GETALLKHOKHOA", Account))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new Dzual_DMTBYT(dr, Ordernumber));
                }
            }
            return List;
        }

        /// <summary>
        /// tìm kiếm thông tin thiết bị theo Tên thiết bị
        /// </summary>        
        /// <param name="Account"></param>
        /// <returns></returns>
        public static Dzual_DMTBYTList DMTBYT_GETALL(String Account, String TenTB)
        {
            Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_FindKHOKHOA", Account, TenTB))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new Dzual_DMTBYT(dr, Ordernumber));
                }
            }
            return List;
        }


        /// <summary>
        /// tìm kiếm thông tin thiết bị theo một số thuộc tính
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="MaTB"></param>
        /// <param name="TenTB"></param>
        /// <param name="MaBarCode"></param>
        /// <param name="Serino"></param>
        /// <param name="Model"></param>
        /// <param name="MaNCC"></param>
        /// <param name="MaQG"></param>
        /// <param name="MaKho"></param>
        /// <param name="MaKhoa"></param>
        /// <param name="MaNoiSua"></param>
        /// <returns></returns>
        public static Dzual_DMTBYTList DMTBYT_GETALL(String Account, String MaTB, String TenTB, String MaBarCode, String Serino, String Model, String MaNCC, String MaQG, String MaKho, String MaKhoa, String MaNoiSua)
        {
            Dzual_DMTBYTList List = new Dzual_DMTBYTList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_FINDS", Account, MaTB, TenTB, MaBarCode, Serino, Model, MaNCC, MaQG, MaKho, MaKhoa, MaNoiSua))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new Dzual_DMTBYT(dr, Ordernumber));
                }
            }
            return List;
        }


		public static Dzual_DMTBYTList DMTBYT_CanSuaChua(string Account, String MaPhieuYC)
		{
			Dzual_DMTBYTList List = new Dzual_DMTBYTList();
			using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_SuaChua", Account, MaPhieuYC))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new Dzual_DMTBYT(dr, Ordernumber));
				}
			}
			return List;
		}

        public static Dzual_DMTBYTList DMTBYT_CanBaoTri(string Account, Decimal MaPhieuBT, String MaDonViYeuCau)
		{
			Dzual_DMTBYTList List = new Dzual_DMTBYTList();
			List.Add(new Dzual_DMTBYT());
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYT_BaoTri", Account, MaPhieuBT, MaDonViYeuCau))
			{
				int Ordernumber = 0;
				while (dr.Read())
				{
					Ordernumber++;
					List.Add(new Dzual_DMTBYT(dr, Ordernumber));
				}
			}
			return List;
		}

	}
}
