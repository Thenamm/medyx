using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	//Loai:1 Gui Yeu Cau Sua Chua
	//Loai2: Xac Nhan Yeu Cau Sua Chua

	public class TBPhieuSuaChua
	{

		#region State Fields
		private String _maPhieuYC;
		private DateTime _ngayYC;
		private String _maKhoaYC;
		private String _nhanVienYC;
		private Int32 _soYC;
		private Boolean _duyetYC;
		private DateTime _ngayDuyetYC;
		private String _nguoiDuyetYC;
		private DateTime _ngayLap;
		private String _nguoiLap;
		private DateTime _ngaySD;
		private String _nguoiSD;
		private Boolean _huy;
		private DateTime _ngayhuy;
		private String _nguoihuy;
		private String _tenKhoaYC;
		private String _tenNhanVienYC;
		private String _tenNguoiDuyetYC;
		private String _tenNguoiLap;
		private String _tenNguoiSD;
		private String _tenNguoiHuy;
		private String _nguyenNhanHuy;
		private int _ordernumber;
		#endregion

		#region Business Properties and Methods
		public String MaPhieuYC
		{
			get
			{
				return _maPhieuYC;
			}
			set
			{
				_maPhieuYC = value;
			}
		}
		public DateTime NgayYC
		{
			get
			{
				return _ngayYC;
			}
			set
			{
				_ngayYC = value;
			}
		}
		public String MaKhoaYC
		{
			get
			{
				return _maKhoaYC;
			}
			set
			{
				_maKhoaYC = value;
			}
		}
		public String NhanVienYC
		{
			get
			{
				return _nhanVienYC;
			}
			set
			{
				_nhanVienYC = value;
			}
		}
		public Int32 SoYC
		{
			get
			{
				return _soYC;
			}
			set
			{
				_soYC = value;
			}
		}
		public Boolean DuyetYC
		{
			get
			{
				return _duyetYC;
			}
			set
			{
				_duyetYC = value;
			}
		}
		public DateTime NgayDuyetYC
		{
			get
			{
				return _ngayDuyetYC;
			}
			set
			{
				_ngayDuyetYC = value;
			}
		}
		public String NguoiDuyetYC
		{
			get
			{
				return _nguoiDuyetYC;
			}
			set
			{
				_nguoiDuyetYC = value;
			}
		}
		public DateTime NgayLap
		{
			get
			{
				return _ngayLap;
			}
			set
			{
				_ngayLap = value;
			}
		}
		public String NguoiLap
		{
			get
			{
				return _nguoiLap;
			}
			set
			{
				_nguoiLap = value;
			}
		}
		public DateTime NgaySD
		{
			get
			{
				return _ngaySD;
			}
			set
			{
				_ngaySD = value;
			}
		}
		public String NguoiSD
		{
			get
			{
				return _nguoiSD;
			}
			set
			{
				_nguoiSD = value;
			}
		}
		public Boolean Huy
		{
			get
			{
				return _huy;
			}
			set
			{
				_huy = value;
			}
		}
		public DateTime Ngayhuy
		{
			get
			{
				return _ngayhuy;
			}
			set
			{
				_ngayhuy = value;
			}
		}
		public String Nguoihuy
		{
			get
			{
				return _nguoihuy;
			}
			set
			{
				_nguoihuy = value;
			}
		}
		public String TenKhoaYC
		{
			get
			{
				return _tenKhoaYC;
			}
			set
			{
				_tenKhoaYC = value;
			}
		}
		public String TenNhanVienYC
		{
			get
			{
				return _tenNhanVienYC;
			}
			set
			{
				_tenNhanVienYC = value;
			}
		}
		public String TenNguoiDuyetYC
		{
			get
			{
				return _tenNguoiDuyetYC;
			}
			set
			{
				_tenNguoiDuyetYC = value;
			}
		}
		public String TenNguoiLap
		{
			get
			{
				return _tenNguoiLap;
			}
			set
			{
				_tenNguoiLap = value;
			}
		}
		public String TenNguoiSD
		{
			get
			{
				return _tenNguoiSD;
			}
			set
			{
				_tenNguoiSD = value;
			}
		}
		public String TenNguoiHuy
		{
			get
			{
				return _tenNguoiHuy;
			}
			set
			{
				_tenNguoiHuy = value;
			}
		}
		public String NguyenNhanHuy
		{
			get
			{
				return _nguyenNhanHuy;
			}
			set
			{
				_nguyenNhanHuy = value;
			}
		}
		public int Ordernumber
		{
			get
			{
				return _ordernumber;
			}
			set
			{
				_ordernumber = value;
			}
		}
		#endregion

		#region Data Access
		public TBPhieuSuaChua()
		{

		}
		public TBPhieuSuaChua(IDataReader dr, int Ordernumber)
		{
			_ordernumber = Ordernumber;
			if (dr["MaPhieuYC"] != null && dr["MaPhieuYC"].GetType().Name != "DBNull") _maPhieuYC = Convert.ToString(dr["MaPhieuYC"]);
			if (dr["NgayYC"] != null && dr["NgayYC"].GetType().Name != "DBNull") _ngayYC = Convert.ToDateTime(dr["NgayYC"]);
			if (dr["MaKhoaYC"] != null && dr["MaKhoaYC"].GetType().Name != "DBNull") _maKhoaYC = Convert.ToString(dr["MaKhoaYC"]);
			if (dr["NhanVienYC"] != null && dr["NhanVienYC"].GetType().Name != "DBNull") _nhanVienYC = Convert.ToString(dr["NhanVienYC"]);
			if (dr["SoYC"] != null && dr["SoYC"].GetType().Name != "DBNull") _soYC = Convert.ToInt32(dr["SoYC"]);
			if (dr["DuyetYC"] != null && dr["DuyetYC"].GetType().Name != "DBNull") _duyetYC = Convert.ToBoolean(dr["DuyetYC"]);
			if (dr["NgayDuyetYC"] != null && dr["NgayDuyetYC"].GetType().Name != "DBNull") _ngayDuyetYC = Convert.ToDateTime(dr["NgayDuyetYC"]);
			if (dr["NguoiDuyetYC"] != null && dr["NguoiDuyetYC"].GetType().Name != "DBNull") _nguoiDuyetYC = Convert.ToString(dr["NguoiDuyetYC"]);
			if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]);
			if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
			if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
			if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
			if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
			if (dr["Ngayhuy"] != null && dr["Ngayhuy"].GetType().Name != "DBNull") _ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]);
			if (dr["Nguoihuy"] != null && dr["Nguoihuy"].GetType().Name != "DBNull") _nguoihuy = Convert.ToString(dr["Nguoihuy"]);
			if (dr["TenKhoaYC"] != null && dr["TenKhoaYC"].GetType().Name != "DBNull") _tenKhoaYC = Convert.ToString(dr["TenKhoaYC"]);
			if (dr["TenNhanVienYC"] != null && dr["TenNhanVienYC"].GetType().Name != "DBNull") _tenNhanVienYC = Convert.ToString(dr["TenNhanVienYC"]);
			if (dr["TenNguoiDuyetYC"] != null && dr["TenNguoiDuyetYC"].GetType().Name != "DBNull") _tenNguoiDuyetYC = Convert.ToString(dr["TenNguoiDuyetYC"]);
			if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") _tenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
			if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") _tenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
			if (dr["TenNguoiHuy"] != null && dr["TenNguoiHuy"].GetType().Name != "DBNull") _tenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
			if (dr["NguyenNhanHuy"] != null && dr["NguyenNhanHuy"].GetType().Name != "DBNull") _nguyenNhanHuy = Convert.ToString(dr["NguyenNhanHuy"]);
		}
		#endregion

		private static string ConnectString
		{
			get
			{
                return System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
			}
		}

		public static TBPhieuSuaChua GetByMaPhieu(string MaPhieuYC)
		{
			using(IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_Get", MaPhieuYC)))
			{
				while(dr.Read())
				{
					return new TBPhieuSuaChua(dr, 1);
				}
			}
			return null;
		}

		public static String InsertYeuCau(DateTime NgayYC, String MaKhoaYC, String NhanVienYC, String NguoiLap)
		{
			return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_YeuCau_INSERT", NgayYC, MaKhoaYC, NhanVienYC, NguoiLap));
		}

		public static Decimal EditYeuCau(string MaPhieuYC, DateTime NgayYC, String MaKhoaYC, String NhanVienYC, String NguoiSD, Boolean Huy)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_YeuCau_UPDATE", MaPhieuYC, NgayYC, MaKhoaYC, NhanVienYC, NguoiSD, Huy)));
		}

		public static void UlDelete(string MaPhieuYC)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBPHIEUSUACHUA_ULDelete", MaPhieuYC);
		}

		public static void Delete(string MaPhieuYC, String NguoiHuy, String NguyenNhanHuy)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBPHIEUSUACHUA_Delete", MaPhieuYC, NguoiHuy, NguyenNhanHuy);
		}

		public static Decimal DuyetYeuCau(string MaPhieuYC, String NguoiDuyet,Boolean DuyetYC, Boolean Huy, DateTime NgayYC)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_DuyetYeuCau", MaPhieuYC, NguoiDuyet, DuyetYC, Huy, NgayYC)));
		}

		public static void DeleteKhaoSat(string MaPhieuYC, String NguoiHuy, String NguyenNhanHuy, Boolean DaLap, Boolean DaDuyet)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBPHIEUSUACHUA_KhaoSat_Delete", MaPhieuYC, NguoiHuy, NguyenNhanHuy, DaLap, DaDuyet);
		}

        public static DataSet CRBienBanYeuCauSuaChua_Get(String MaPhieuSC, Boolean qAdmin)
        {
            DataSet ds = new DataSet();
            string[] s = { "PhieuYeuCau", "DanhSachTBYeuCau" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanYeuCauSuaChua_Get", ds, s, MaPhieuSC, qAdmin);
            //ds.WriteXmlSchema("E:\\PhieuYeuCau.xsd");
            return ds;
        }

        //public static DataSet CRBienBanKhaoSatSuaChua_Get(String MaPhieuSC, Boolean qAdmin)
        //{
        //    DataSet ds = new DataSet();
        //    string[] s = { "PhieuYeuCau", "DanhSachTBYeuCau" };
        //    SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanYeuCauSuaChua_Get", ds, s, MaPhieuSC, qAdmin);
        //    ds.WriteXmlSchema("E:\\PhieuKhaoSat.xsd");
        //    return ds;
        //}
	}
}
