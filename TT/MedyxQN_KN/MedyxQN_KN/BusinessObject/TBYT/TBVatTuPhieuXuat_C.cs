using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBVatTuPhieuXuat_C
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
	private Decimal _sTT;
	private Boolean _isNgoaiKho;
	private String _maVT;
	private Decimal _soluong;
	private DateTime _hanSD;
	private String _solo;
	private Decimal _dongia;
	private Decimal _sLyc;
	private Decimal _giaban;
	private Boolean _huy;
	private String _ghichu;
	private DateTime _ngaySD;
	private String _nguoiSD;
	private String _maMay;
	private String _mAQL;
	private String _tENTM;
	private String _tENDVT;
	private String _tENNGUOISD;
	private Decimal _tONCK;
	private Decimal _tONCKDT;
	private Boolean _hANDUNG;
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
			public Decimal STT
			{
				get
				{
					return _sTT;
				}
				set
				{
					_sTT = value;
				}
			}
			public Boolean IsNgoaiKho
			{
				get
				{
					return _isNgoaiKho;
				}
				set
				{
					_isNgoaiKho = value;
				}
			}
			public String MaVT
			{
				get
				{
					return _maVT;
				}
				set
				{
					_maVT = value;
				}
			}
			public Decimal Soluong
			{
				get
				{
					return _soluong;
				}
				set
				{
					_soluong = value;
				}
			}
			public DateTime HanSD
			{
				get
				{
					return _hanSD;
				}
				set
				{
					_hanSD = value;
				}
			}
			public String Solo
			{
				get
				{
					return _solo;
				}
				set
				{
					_solo = value;
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
			public Decimal SLyc
			{
				get
				{
					return _sLyc;
				}
				set
				{
					_sLyc = value;
				}
			}
			public Decimal Giaban
			{
				get
				{
					return _giaban;
				}
				set
				{
					_giaban = value;
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
			public String MAQL
			{
				get
				{
					return _mAQL;
				}
				set
				{
					_mAQL = value;
				}
			}
			public String TENTM
			{
				get
				{
					return _tENTM;
				}
				set
				{
					_tENTM = value;
				}
			}
			public String TENDVT
			{
				get
				{
					return _tENDVT;
				}
				set
				{
					_tENDVT = value;
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
			public Decimal TONCK
			{
				get
				{
					return _tONCK;
				}
				set
				{
					_tONCK = value;
				}
			}
			public Decimal TONCKDT
			{
				get
				{
					return _tONCKDT;
				}
				set
				{
					_tONCKDT = value;
				}
			}
			public Boolean HANDUNG
			{
				get
				{
					return _hANDUNG;
				}
				set
				{
					_hANDUNG = value;
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
			public TBVatTuPhieuXuat_C()
			{

			}
			public TBVatTuPhieuXuat_C(IDataReader dr, int Ordernumber)
			{
				_ordernumber = Ordernumber;
				if(dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToString(dr["MaPX"]);
				if(dr["STT"] != null && dr["STT"].GetType().Name != "DBNull") _sTT = Convert.ToDecimal(dr["STT"]);
				if(dr["IsNgoaiKho"] != null && dr["IsNgoaiKho"].GetType().Name != "DBNull") _isNgoaiKho = Convert.ToBoolean(dr["IsNgoaiKho"]);
				if(dr["MaVT"] != null && dr["MaVT"].GetType().Name != "DBNull") _maVT = Convert.ToString(dr["MaVT"]);
				if(dr["Soluong"] != null && dr["Soluong"].GetType().Name != "DBNull") _soluong = Convert.ToDecimal(dr["Soluong"]);
				if(dr["HanSD"] != null && dr["HanSD"].GetType().Name != "DBNull") _hanSD = Convert.ToDateTime(dr["HanSD"]);
				if(dr["Solo"] != null && dr["Solo"].GetType().Name != "DBNull") _solo = Convert.ToString(dr["Solo"]);
				if(dr["Dongia"] != null && dr["Dongia"].GetType().Name != "DBNull") _dongia = Convert.ToDecimal(dr["Dongia"]);
				if(dr["SLyc"] != null && dr["SLyc"].GetType().Name != "DBNull") _sLyc = Convert.ToDecimal(dr["SLyc"]);
				if(dr["Giaban"] != null && dr["Giaban"].GetType().Name != "DBNull") _giaban = Convert.ToDecimal(dr["Giaban"]);
				if(dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
				if(dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
				if(dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
				if(dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
				if(dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
				if(dr["MAQL"] != null && dr["MAQL"].GetType().Name != "DBNull") _mAQL = Convert.ToString(dr["MAQL"]);
				if(dr["TENTM"] != null && dr["TENTM"].GetType().Name != "DBNull") _tENTM = Convert.ToString(dr["TENTM"]);
				if(dr["TENDVT"] != null && dr["TENDVT"].GetType().Name != "DBNull") _tENDVT = Convert.ToString(dr["TENDVT"]);
				if(dr["TENNGUOISD"] != null && dr["TENNGUOISD"].GetType().Name != "DBNull") _tENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
				if(dr["TONCK"] != null && dr["TONCK"].GetType().Name != "DBNull") _tONCK = Convert.ToDecimal(dr["TONCK"]);
				if(dr["TONCKDT"] != null && dr["TONCKDT"].GetType().Name != "DBNull") _tONCKDT = Convert.ToDecimal(dr["TONCKDT"]);
				if(dr["HANDUNG"] != null && dr["HANDUNG"].GetType().Name != "DBNull") _hANDUNG = Convert.ToBoolean(dr["HANDUNG"]);
			}
		#endregion


		#region Data Update

			public static TBVatTuPhieuXuat_C GetByMaPX(String MaPX, Decimal STT)
		{
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_C_GET", MaPX, STT)))
			{
				while (dr.Read())
				{
					return new TBVatTuPhieuXuat_C(dr, 1);
				}
			}
			return null;
		}


		public static void Delete(String MaPX, Decimal STT, String NguoiSD, String MaMay)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_C_DELETED", MaPX, STT,NguoiSD, MaMay);
		}

		public static String Update(String MaPX, Decimal STT, String MaVT, Nullable<Decimal> SoLuong, Nullable<DateTime> HanSD, String SoLo, Nullable<Decimal> DonGia, Nullable<Decimal> SLYC, Nullable<Decimal> GiaBan, Nullable<Boolean> Huy, String GhiChu, String NguoiSD, String MaMay)
		{
			return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_C_UPDATE", MaPX, STT, MaVT, SoLuong, HanSD, SoLo, DonGia, SLYC, GiaBan, Huy, GhiChu, NguoiSD, MaMay));
		}

		public static String Insert(String MaPX, Nullable<Boolean> IsNgoaiKho, String MaVT, Nullable<Decimal> SoLuong, Nullable<DateTime> HanSD, String SoLo, Nullable<Decimal> DonGia, Nullable<Decimal> SLYC, Nullable<Decimal> GiaBan, String GhiChu, String NguoiSD, String MaMay)
		{
			return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_C_CREATE", MaPX, IsNgoaiKho, MaVT, SoLuong, HanSD, SoLo, DonGia, SLYC, GiaBan, GhiChu, NguoiSD, MaMay));
		}

		#endregion
	}
}
