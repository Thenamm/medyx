using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
	public class Dzual_DMKhoa
	{
		#region State Fields

		private String _maKhoa;
		private String _tenKhoa;
		private String _tenTA;
		private String _diaDiem;
		private Byte _loai;
		private Byte _cap;
		private String _machuyenkhoa;
		private String _maMay;
		private Boolean _huy;
		private DateTime _ngaySD;
		private String _nguoiSD;
		private String _ghichu;
		private Boolean _khongHD;
		private Decimal _sogiuong;
		private String _maNhom;
		private String _maKhoaBC;
		private String _khoaNT;
		private String _maKhoaQL;
		private String _maDV;
		private int _ordernumber;
		#endregion

		#region Business Properties and Methods
		public String MaKhoa
		{
			get
			{
				return _maKhoa;
			}
			set
			{
				_maKhoa = value;
			}
		}
		public String TenKhoa
		{
			get
			{
				return _tenKhoa;
			}
			set
			{
				_tenKhoa = value;
			}
		}
		public String TenTA
		{
			get
			{
				return _tenTA;
			}
			set
			{
				_tenTA = value;
			}
		}
		public String DiaDiem
		{
			get
			{
				return _diaDiem;
			}
			set
			{
				_diaDiem = value;
			}
		}
		public Byte Loai
		{
			get
			{
				return _loai;
			}
			set
			{
				_loai = value;
			}
		}
		public Byte Cap
		{
			get
			{
				return _cap;
			}
			set
			{
				_cap = value;
			}
		}
		public String Machuyenkhoa
		{
			get
			{
				return _machuyenkhoa;
			}
			set
			{
				_machuyenkhoa = value;
			}
		}
		public String MaMay
		{
			get
			{
				return _maMay;
			}
			set
			{
				_maMay = value;
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
		public String Ghichu
		{
			get
			{
				return _ghichu;
			}
			set
			{
				_ghichu = value;
			}
		}
		public Boolean KhongHD
		{
			get
			{
				return _khongHD;
			}
			set
			{
				_khongHD = value;
			}
		}
		public Decimal Sogiuong
		{
			get
			{
				return _sogiuong;
			}
			set
			{
				_sogiuong = value;
			}
		}
		public String MaNhom
		{
			get
			{
				return _maNhom;
			}
			set
			{
				_maNhom = value;
			}
		}
		public String MaKhoaBC
		{
			get
			{
				return _maKhoaBC;
			}
			set
			{
				_maKhoaBC = value;
			}
		}
		public String KhoaNT
		{
			get
			{
				return _khoaNT;
			}
			set
			{
				_khoaNT = value;
			}
		}
		public String MaKhoaQL
		{
			get
			{
				return _maKhoaQL;
			}
			set
			{
				_maKhoaQL = value;
			}
		}
		public String MaDV
		{
			get
			{
				return _maDV;
			}
			set
			{
				_maDV = value;
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
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}
		public Dzual_DMKhoa()
		{

		}
		public Dzual_DMKhoa(IDataReader dr, int Ordernumber)
		{
			_ordernumber = Ordernumber;
			if (dr["MaKhoa"] != null && dr["MaKhoa"].GetType().Name != "DBNull") _maKhoa = Convert.ToString(dr["MaKhoa"]);
			if (dr["TenKhoa"] != null && dr["TenKhoa"].GetType().Name != "DBNull") _tenKhoa = Convert.ToString(dr["TenKhoa"]);
			if (dr["TenTA"] != null && dr["TenTA"].GetType().Name != "DBNull") _tenTA = Convert.ToString(dr["TenTA"]);
			if (dr["DiaDiem"] != null && dr["DiaDiem"].GetType().Name != "DBNull") _diaDiem = Convert.ToString(dr["DiaDiem"]);
			if (dr["Loai"] != null && dr["Loai"].GetType().Name != "DBNull") _loai = Convert.ToByte(dr["Loai"]);
			if (dr["Cap"] != null && dr["Cap"].GetType().Name != "DBNull") _cap = Convert.ToByte(dr["Cap"]);
			if (dr["Machuyenkhoa"] != null && dr["Machuyenkhoa"].GetType().Name != "DBNull") _machuyenkhoa = Convert.ToString(dr["Machuyenkhoa"]);
			if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
			if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
			if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
			if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
			if (dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
			if (dr["KhongHD"] != null && dr["KhongHD"].GetType().Name != "DBNull") _khongHD = Convert.ToBoolean(dr["KhongHD"]);
			if (dr["Sogiuong"] != null && dr["Sogiuong"].GetType().Name != "DBNull") _sogiuong = Convert.ToDecimal(dr["Sogiuong"]);
			if (dr["MaNhom"] != null && dr["MaNhom"].GetType().Name != "DBNull") _maNhom = Convert.ToString(dr["MaNhom"]);
			if (dr["MaKhoaBC"] != null && dr["MaKhoaBC"].GetType().Name != "DBNull") _maKhoaBC = Convert.ToString(dr["MaKhoaBC"]);
			if (dr["KhoaNT"] != null && dr["KhoaNT"].GetType().Name != "DBNull") _khoaNT = Convert.ToString(dr["KhoaNT"]);
			if (dr["MaKhoaQL"] != null && dr["MaKhoaQL"].GetType().Name != "DBNull") _maKhoaQL = Convert.ToString(dr["MaKhoaQL"]);
			if (dr["MaDV"] != null && dr["MaDV"].GetType().Name != "DBNull") _maDV = Convert.ToString(dr["MaDV"]);
		}

		public static Dzual_DMKhoa GetByMaKhoa(String _maKhoa)
		{
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMKhoa_GetByMaKhoa", _maKhoa)))
			{
				while (dr.Read())
				{
					return new Dzual_DMKhoa(dr, 0);
				}
			}
			return null;
		}
		#endregion
	}
}
