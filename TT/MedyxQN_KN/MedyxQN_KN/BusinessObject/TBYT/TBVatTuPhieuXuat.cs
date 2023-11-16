using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBVatTuPhieuXuat
	{
		private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}

		#region State Fields

	private String _maPX;
	private String _noixuat;
	private DateTime _ngayxuat;
	private DateTime _ngayXuatTT;
	private String _noinhap;
	private Byte _loaiphieu;
	private String _soCT;
	private String _nVXuat;
	private String _nVNhan;
	private String _ghichu;
	private Boolean _huy;
	private DateTime _ngaySD;
	private String _nguoiSD;
	private DateTime _ngayLap;
	private String _nguoiLap;
	private DateTime _ngayHuy;
	private String _nguoiHuy;
	private DateTime _ngaySD1;
	private String _nguoiSD1;
	private Boolean _daphat;
	private Boolean _khoaYC;
	private String _maMay;
	private Boolean _daDuyet;
	private String _doiTuong;
	private String _tENNOIXUAT;
	private String _tENNOINHAP;
	private String _tENNVXUAT;
	private String _tENNGUOILAP;
	private String _tENNGUOISD;
	private String _tENNGUOIHUY;
	private String _tENNGUOINHAN;
	private int _ordernumber;
#endregion

		#region Business Properties and Methods
			public String MaPX
			{
				get
				{
					return _maPX;
				}
				set
				{
					_maPX = value;
				}
			}
			public String Noixuat
			{
				get
				{
					return _noixuat;
				}
				set
				{
					_noixuat = value;
				}
			}
			public DateTime Ngayxuat
			{
				get
				{
					return _ngayxuat;
				}
				set
				{
					_ngayxuat = value;
				}
			}
			public DateTime NgayXuatTT
			{
				get
				{
					return _ngayXuatTT;
				}
				set
				{
					_ngayXuatTT = value;
				}
			}
			public String Noinhap
			{
				get
				{
					return _noinhap;
				}
				set
				{
					_noinhap = value;
				}
			}
			public Byte Loaiphieu
			{
				get
				{
					return _loaiphieu;
				}
				set
				{
					_loaiphieu = value;
				}
			}
			public String SoCT
			{
				get
				{
					return _soCT;
				}
				set
				{
					_soCT = value;
				}
			}
			public String NVXuat
			{
				get
				{
					return _nVXuat;
				}
				set
				{
					_nVXuat = value;
				}
			}
			public String NVNhan
			{
				get
				{
					return _nVNhan;
				}
				set
				{
					_nVNhan = value;
				}
			}
			public String ghichu
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
			public DateTime NgayHuy
			{
				get
				{
					return _ngayHuy;
				}
				set
				{
					_ngayHuy = value;
				}
			}
			public String NguoiHuy
			{
				get
				{
					return _nguoiHuy;
				}
				set
				{
					_nguoiHuy = value;
				}
			}
			public DateTime NgaySD1
			{
				get
				{
					return _ngaySD1;
				}
				set
				{
					_ngaySD1 = value;
				}
			}
			public String NguoiSD1
			{
				get
				{
					return _nguoiSD1;
				}
				set
				{
					_nguoiSD1 = value;
				}
			}
			public Boolean Daphat
			{
				get
				{
					return _daphat;
				}
				set
				{
					_daphat = value;
				}
			}
			public Boolean KhoaYC
			{
				get
				{
					return _khoaYC;
				}
				set
				{
					_khoaYC = value;
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
			public Boolean DaDuyet
			{
				get
				{
					return _daDuyet;
				}
				set
				{
					_daDuyet = value;
				}
			}
			public String DoiTuong
			{
				get
				{
					return _doiTuong;
				}
				set
				{
					_doiTuong = value;
				}
			}
			public String TENNOIXUAT
			{
				get
				{
					return _tENNOIXUAT;
				}
				set
				{
					_tENNOIXUAT = value;
				}
			}
			public String TENNOINHAP
			{
				get
				{
					return _tENNOINHAP;
				}
				set
				{
					_tENNOINHAP = value;
				}
			}
			public String TENNVXUAT
			{
				get
				{
					return _tENNVXUAT;
				}
				set
				{
					_tENNVXUAT = value;
				}
			}
			public String TENNGUOILAP
			{
				get
				{
					return _tENNGUOILAP;
				}
				set
				{
					_tENNGUOILAP = value;
				}
			}
			public String TENNGUOISD
			{
				get
				{
					return _tENNGUOISD;
				}
				set
				{
					_tENNGUOISD = value;
				}
			}
			public String TENNGUOIHUY
			{
				get
				{
					return _tENNGUOIHUY;
				}
				set
				{
					_tENNGUOIHUY = value;
				}
			}
			public String TENNGUOINHAN
			{
				get
				{
					return _tENNGUOINHAN;
				}
				set
				{
					_tENNGUOINHAN = value;
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
			public TBVatTuPhieuXuat()
			{

			}
			public TBVatTuPhieuXuat(IDataReader dr, int Ordernumber)
			{
				_ordernumber = Ordernumber;
				if(dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToString(dr["MaPX"]);
				if(dr["Noixuat"] != null && dr["Noixuat"].GetType().Name != "DBNull") _noixuat = Convert.ToString(dr["Noixuat"]);
				if(dr["Ngayxuat"] != null && dr["Ngayxuat"].GetType().Name != "DBNull") _ngayxuat = Convert.ToDateTime(dr["Ngayxuat"]);
				if(dr["NgayXuatTT"] != null && dr["NgayXuatTT"].GetType().Name != "DBNull") _ngayXuatTT = Convert.ToDateTime(dr["NgayXuatTT"]);
				if(dr["Noinhap"] != null && dr["Noinhap"].GetType().Name != "DBNull") _noinhap = Convert.ToString(dr["Noinhap"]);
				if(dr["Loaiphieu"] != null && dr["Loaiphieu"].GetType().Name != "DBNull") _loaiphieu = Convert.ToByte(dr["Loaiphieu"]);
				if(dr["SoCT"] != null && dr["SoCT"].GetType().Name != "DBNull") _soCT = Convert.ToString(dr["SoCT"]);
				if(dr["NVXuat"] != null && dr["NVXuat"].GetType().Name != "DBNull") _nVXuat = Convert.ToString(dr["NVXuat"]);
				if(dr["NVNhan"] != null && dr["NVNhan"].GetType().Name != "DBNull") _nVNhan = Convert.ToString(dr["NVNhan"]);
				if(dr["ghichu"] != null && dr["ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["ghichu"]);
				if(dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
				if(dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
				if(dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
				if(dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]);
				if(dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
				if(dr["NgayHuy"] != null && dr["NgayHuy"].GetType().Name != "DBNull") _ngayHuy = Convert.ToDateTime(dr["NgayHuy"]);
				if(dr["NguoiHuy"] != null && dr["NguoiHuy"].GetType().Name != "DBNull") _nguoiHuy = Convert.ToString(dr["NguoiHuy"]);
				if(dr["NgaySD1"] != null && dr["NgaySD1"].GetType().Name != "DBNull") _ngaySD1 = Convert.ToDateTime(dr["NgaySD1"]);
				if(dr["NguoiSD1"] != null && dr["NguoiSD1"].GetType().Name != "DBNull") _nguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
				if(dr["Daphat"] != null && dr["Daphat"].GetType().Name != "DBNull") _daphat = Convert.ToBoolean(dr["Daphat"]);
				if(dr["KhoaYC"] != null && dr["KhoaYC"].GetType().Name != "DBNull") _khoaYC = Convert.ToBoolean(dr["KhoaYC"]);
				if(dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
				if(dr["DaDuyet"] != null && dr["DaDuyet"].GetType().Name != "DBNull") _daDuyet = Convert.ToBoolean(dr["DaDuyet"]);
				if(dr["DoiTuong"] != null && dr["DoiTuong"].GetType().Name != "DBNull") _doiTuong = Convert.ToString(dr["DoiTuong"]);
				if(dr["TENNOIXUAT"] != null && dr["TENNOIXUAT"].GetType().Name != "DBNull") _tENNOIXUAT = Convert.ToString(dr["TENNOIXUAT"]);
				if(dr["TENNOINHAP"] != null && dr["TENNOINHAP"].GetType().Name != "DBNull") _tENNOINHAP = Convert.ToString(dr["TENNOINHAP"]);
				if(dr["TENNVXUAT"] != null && dr["TENNVXUAT"].GetType().Name != "DBNull") _tENNVXUAT = Convert.ToString(dr["TENNVXUAT"]);
				if(dr["TENNGUOILAP"] != null && dr["TENNGUOILAP"].GetType().Name != "DBNull") _tENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]);
				if(dr["TENNGUOISD"] != null && dr["TENNGUOISD"].GetType().Name != "DBNull") _tENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
				if(dr["TENNGUOIHUY"] != null && dr["TENNGUOIHUY"].GetType().Name != "DBNull") _tENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]);
				if(dr["TENNGUOINHAN"] != null && dr["TENNGUOINHAN"].GetType().Name != "DBNull") _tENNGUOINHAN = Convert.ToString(dr["TENNGUOINHAN"]);
			}
		#endregion

		#region Data Update

		public static TBVatTuPhieuXuat GetByMaPX(String MaPX, Boolean QuyenAdmin,  byte loaiphieu, Boolean daphat)
		{
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_GET", MaPX, QuyenAdmin, loaiphieu, daphat)))
			{
				while (dr.Read())
				{
					return new TBVatTuPhieuXuat(dr, 1);
				}
			}
			return null;
		}


		public static void Delete(String MaPX, String MaMay, String NguoiSD)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_DELETED", MaPX, MaMay, NguoiSD);
		}

		public static Decimal Update(String MaPX, String NoiXuat, Nullable<DateTime> NgayXuat, Nullable<DateTime> NgayXuatTT, String NoiNhap, Nullable<Byte> LoaiPhieu, String SoCT, String NhanVienXuat, String NhanVienNhan, String GhiChu, Nullable<Boolean> Huy, String MaMay, String NguoiSD, Nullable<Boolean> DaPhat, Nullable<Boolean> DaDuyet, String DoiTuong)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_UPDATE", MaPX, NoiXuat, NgayXuat, NgayXuatTT, NoiNhap, LoaiPhieu, SoCT, NhanVienXuat, NhanVienNhan, GhiChu, Huy, MaMay, NguoiSD, DaPhat, DaDuyet, DoiTuong)));
		}

		public static String Insert(String NoiXuat, Nullable<DateTime> NgayXuat, Nullable<DateTime> NgayXuatTT, String NoiNhap, Nullable<Byte> LoaiPhieu, String SoCT, String NhanVienXuat, String NhanVienNhan, String GhiChu, Nullable<Boolean> Huy, String NguoiLap, Nullable<Boolean> KhoaYC, String MaMay, Nullable<Boolean> DaPhat, Nullable<Boolean> DaDuyet, String DoiTuong)
		{
			return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_CREATE", NoiXuat, NgayXuat, NgayXuatTT, NoiNhap, LoaiPhieu, SoCT, NhanVienXuat, NhanVienNhan, GhiChu, Huy, NguoiLap, KhoaYC, MaMay, DaPhat, DaDuyet, DoiTuong));
		}

		#endregion
	}
}
