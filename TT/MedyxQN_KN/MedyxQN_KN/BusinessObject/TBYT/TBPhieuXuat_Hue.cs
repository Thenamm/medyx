using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Csla;

namespace HTC.BusinessObject.TBYT
{
	public class TBPhieuXuat_Hue
	{

		#region State Fields

			private Decimal _maPX;
			private String _noixuat;
			private String _noinhap;
			private Byte _loaiphieu;
			private DateTime _ngayxuat;
			private DateTime _ngayxuatTT;
			private String _nVXuat;
			private String _nVNhan;
			private String _noidungxuat;
			private String _maMay;
			private DateTime _ngayLap;
			private String _nguoiLap;
			private DateTime _ngaySD;
			private String _nguoiSD;
			private Boolean _huy;
			private DateTime _ngayHuy;
			private String _nguoiHuy;
			private Boolean _daPhat;
			private Boolean _daDuyet;
			private Boolean _huynhan;
			private String _nguoiHuynhan;
			private DateTime _ngayHuynhan;
			private String _maTB;
			private String _model;
			private String _serialNo;
			private String _maBarCode;
			private Decimal _dongia;
			private String _tenNoiXuat;
			private String _tenNoiNhap;
			private String _tenNVXuat;
			private String _tenNVNhan;
			private String _tenNguoiHuyNhan;
			private String _tenTB;
			private String _tenDVT;
			private int _ordernumber;
		#endregion

		#region Business Properties and Methods
			public Decimal MaPX
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
			public DateTime NgayxuatTT
			{
				get
				{
					return _ngayxuatTT;
				}
				set
				{
					_ngayxuatTT = value;
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
			public String Noidungxuat
			{
				get
				{
					return _noidungxuat;
				}
				set
				{
					_noidungxuat = value;
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
			public Boolean DaPhat
			{
				get
				{
					return _daPhat;
				}
				set
				{
					_daPhat = value;
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
			public Boolean Huynhan
			{
				get
				{
					return _huynhan;
				}
				set
				{
					_huynhan = value;
				}
			}
			public String NguoiHuynhan
			{
				get
				{
					return _nguoiHuynhan;
				}
				set
				{
					_nguoiHuynhan = value;
				}
			}
			public DateTime NgayHuynhan
			{
				get
				{
					return _ngayHuynhan;
				}
				set
				{
					_ngayHuynhan = value;
				}
			}
			public String MaTB
			{
				get
				{
					return _maTB;
				}
				set
				{
					_maTB = value;
				}
			}
			public String Model
			{
				get
				{
					return _model;
				}
				set
				{
					_model = value;
				}
			}
			public String SerialNo
			{
				get
				{
					return _serialNo;
				}
				set
				{
					_serialNo = value;
				}
			}
			public String MaBarCode
			{
				get
				{
					return _maBarCode;
				}
				set
				{
					_maBarCode = value;
				}
			}
			public Decimal Dongia
			{
				get
				{
					return _dongia;
				}
				set
				{
					_dongia = value;
				}
			}
			public String TenNoiXuat
			{
				get
				{
					return _tenNoiXuat;
				}
				set
				{
					_tenNoiXuat = value;
				}
			}
			public String TenNoiNhap
			{
				get
				{
					return _tenNoiNhap;
				}
				set
				{
					_tenNoiNhap = value;
				}
			}
			public String TenNVXuat
			{
				get
				{
					return _tenNVXuat;
				}
				set
				{
					_tenNVXuat = value;
				}
			}
			public String TenNVNhan
			{
				get
				{
					return _tenNVNhan;
				}
				set
				{
					_tenNVNhan = value;
				}
			}
			public String TenNguoiHuyNhan
			{
				get
				{
					return _tenNguoiHuyNhan;
				}
				set
				{
					_tenNguoiHuyNhan = value;
				}
			}
			public String TenTB
			{
				get
				{
					return _tenTB;
				}
				set
				{
					_tenTB = value;
				}
			}
			public String TenDVT
			{
				get
				{
					return _tenDVT;
				}
				set
				{
					_tenDVT = value;
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
			public TBPhieuXuat_Hue()
			{

			}
			public TBPhieuXuat_Hue(IDataReader dr, int Ordernumber)
			{
				_ordernumber = Ordernumber;
				if (dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToDecimal(dr["MaPX"]);
				if (dr["Noixuat"] != null && dr["Noixuat"].GetType().Name != "DBNull") _noixuat = Convert.ToString(dr["Noixuat"]);
				if (dr["Noinhap"] != null && dr["Noinhap"].GetType().Name != "DBNull") _noinhap = Convert.ToString(dr["Noinhap"]);
				if (dr["Loaiphieu"] != null && dr["Loaiphieu"].GetType().Name != "DBNull") _loaiphieu = Convert.ToByte(dr["Loaiphieu"]);
				if (dr["Ngayxuat"] != null && dr["Ngayxuat"].GetType().Name != "DBNull") _ngayxuat = Convert.ToDateTime(dr["Ngayxuat"]);
				if (dr["NgayxuatTT"] != null && dr["NgayxuatTT"].GetType().Name != "DBNull") _ngayxuatTT = Convert.ToDateTime(dr["NgayxuatTT"]);
				if (dr["NVXuat"] != null && dr["NVXuat"].GetType().Name != "DBNull") _nVXuat = Convert.ToString(dr["NVXuat"]);
				if (dr["NVNhan"] != null && dr["NVNhan"].GetType().Name != "DBNull") _nVNhan = Convert.ToString(dr["NVNhan"]);
				if (dr["Noidungxuat"] != null && dr["Noidungxuat"].GetType().Name != "DBNull") _noidungxuat = Convert.ToString(dr["Noidungxuat"]);
				if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
				if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]);
				if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
				if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
				if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
				if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
				if (dr["NgayHuy"] != null && dr["NgayHuy"].GetType().Name != "DBNull") _ngayHuy = Convert.ToDateTime(dr["NgayHuy"]);
				if (dr["NguoiHuy"] != null && dr["NguoiHuy"].GetType().Name != "DBNull") _nguoiHuy = Convert.ToString(dr["NguoiHuy"]);
				if (dr["DaPhat"] != null && dr["DaPhat"].GetType().Name != "DBNull") _daPhat = Convert.ToBoolean(dr["DaPhat"]);
				if (dr["DaDuyet"] != null && dr["DaDuyet"].GetType().Name != "DBNull") _daDuyet = Convert.ToBoolean(dr["DaDuyet"]);
				if (dr["Huynhan"] != null && dr["Huynhan"].GetType().Name != "DBNull") _huynhan = Convert.ToBoolean(dr["Huynhan"]);
				if (dr["NguoiHuynhan"] != null && dr["NguoiHuynhan"].GetType().Name != "DBNull") _nguoiHuynhan = Convert.ToString(dr["NguoiHuynhan"]);
				if (dr["NgayHuynhan"] != null && dr["NgayHuynhan"].GetType().Name != "DBNull") _ngayHuynhan = Convert.ToDateTime(dr["NgayHuynhan"]);
				if (dr["MaTB"] != null && dr["MaTB"].GetType().Name != "DBNull") _maTB = Convert.ToString(dr["MaTB"]);
				if (dr["Model"] != null && dr["Model"].GetType().Name != "DBNull") _model = Convert.ToString(dr["Model"]);
				if (dr["SerialNo"] != null && dr["SerialNo"].GetType().Name != "DBNull") _serialNo = Convert.ToString(dr["SerialNo"]);
				if (dr["MaBarCode"] != null && dr["MaBarCode"].GetType().Name != "DBNull") _maBarCode = Convert.ToString(dr["MaBarCode"]);
				if (dr["Dongia"] != null && dr["Dongia"].GetType().Name != "DBNull") _dongia = Convert.ToDecimal(dr["Dongia"]);
				if (dr["TenNoiXuat"] != null && dr["TenNoiXuat"].GetType().Name != "DBNull") _tenNoiXuat = Convert.ToString(dr["TenNoiXuat"]);
				if (dr["TenNoiNhap"] != null && dr["TenNoiNhap"].GetType().Name != "DBNull") _tenNoiNhap = Convert.ToString(dr["TenNoiNhap"]);
				if (dr["TenNVXuat"] != null && dr["TenNVXuat"].GetType().Name != "DBNull") _tenNVXuat = Convert.ToString(dr["TenNVXuat"]);
				if (dr["TenNVNhan"] != null && dr["TenNVNhan"].GetType().Name != "DBNull") _tenNVNhan = Convert.ToString(dr["TenNVNhan"]);
				if (dr["TenNguoiHuyNhan"] != null && dr["TenNguoiHuyNhan"].GetType().Name != "DBNull") _tenNguoiHuyNhan = Convert.ToString(dr["TenNguoiHuyNhan"]);
				if (dr["TenTB"] != null && dr["TenTB"].GetType().Name != "DBNull") _tenTB = Convert.ToString(dr["TenTB"]);
				if (dr["TenDVT"] != null && dr["TenDVT"].GetType().Name != "DBNull") _tenDVT = Convert.ToString(dr["TenDVT"]);
			}
		#endregion



	}
}
