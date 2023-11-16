// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThamSoLuong
// Kieu doi tuong  :	ThamSoLuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/28/2010 11:06:13 AM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThamSoLuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThamSoLuong : BusinessBase<ThamSoLuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private Decimal _mucLuongCB = 0;
		private Decimal _bHYT = 0;
		private Decimal _bHXH = 0;
		private Decimal _congDoan = 0;
		private Decimal _heSoThamNien = 0;
		private Decimal _donGiaTruc = 0;
		private Decimal _donGiaXQuang = 0;
		private Decimal _donGiaM2 = 0;
		private Decimal _donGiaNTHSCC = 0;
		private Decimal _donGiaNNHSCC = 0;
		private Decimal _donGiaNLHSCC = 0;
		private Decimal _donGiaQCCTNBHSCC = 0;
		private Decimal _donGiaND1142002HSCC = 0;
		private Decimal _donGiaNTCM = 0;
		private Decimal _donGiaNNCM = 0;
		private Decimal _donGiaNLCM = 0;
		private Decimal _donGiaQCCTNBCM = 0;
		private Decimal _donGiaNTLD = 0;
		private Decimal _donGiaNNLD = 0;
		private Decimal _donGiaNLLD = 0;
		private Decimal _donGiaCocIHSCC = 0;
		private Decimal _donGiaCocIIHSCC = 0;
		private Decimal _donGiaDDHSCC = 0;
		private Decimal _donGiaCocICM = 0;
		private Decimal _donGiaCocIICM = 0;
		private Decimal _donGiaDDCM = 0;
		private Decimal _dONGIADBAP1 = 0;
		private Decimal _dONGIADBAP2 = 0;
		private Decimal _dONGIADBBC = 0;
		private Decimal _dONGIADBBP1 = 0;
		private Decimal _dONGIADBBP2 = 0;
		private Decimal _dONGIADBCC = 0;
		private Decimal _dONGIADBCP1 = 0;
		private Decimal _dONGIADBCP2 = 0;
		private Decimal _dONGIAIC = 0;
		private Decimal _dONGIADB1P1 = 0;
		private Decimal _dONGIAKC = 0;
		private Decimal _dONGIAKP1 = 0;
		private Decimal _dONGIANgoaiVien = 0;
		private Decimal _dONGIAChuTri = 0;
		private Decimal _dONGIAThuKy = 0;
		private Decimal _dONGIABacSy = 0;
		private Decimal _dONGIADD = 0;
		private Decimal _dONGIANVien = 0;
		private Decimal _dONGIADBBS = 0;
		private Decimal _dONGIADBDD = 0;
		private Decimal _dONGIAIBS = 0;
		private Decimal _dONGIAIDD = 0;
		private Decimal _dONGIAIIBS = 0;
		private Decimal _dONGIAIIDD = 0;
		private Decimal _dONGIAIIIBS = 0;
		private Decimal _dONGIAIIIDD = 0;
		private Decimal _heSoPTHS = 0;
		private Decimal _dONGIAA = 0;
		private Decimal _dONGIAB = 0;
		private Decimal _dONGIAC = 0;
		private Decimal _mucTTThue = 0;
		private Decimal _heSoLamDem = 0;
		private Decimal _heSoNgoaiGio = 0;
		private Decimal _heSoNgoaiGio7 = 0;
		private Decimal _heSoNgoaiGioLe = 0;
		private Decimal _dONGIADBAC = 0;
		private Decimal _dONGIADCDBAP1 = 0;
		private Decimal _dONGIADCDBAP2 = 0;
		private Decimal _dONGIADCDBBC = 0;
		private Decimal _dONGIADCDBBP1 = 0;
		private Decimal _dONGIADCDBBP2 = 0;
		private Decimal _dONGIADCDBCC = 0;
		private Decimal _dONGIADCDBCP1 = 0;
		private Decimal _dONGIADCDBCP2 = 0;
		private Decimal _dONGIADCIC = 0;
		private Decimal _dONGIADCDB1P1 = 0;
		private Decimal _dONGIADCKC = 0;
		private Decimal _dONGIADCKP1 = 0;
		private Decimal _dONGIADCDBAC = 0;
		private Decimal _dONGIAGMDBAP1 = 0;
		private Decimal _dONGIAGMDBAP2 = 0;
		private Decimal _dONGIAGMDBBC = 0;
		private Decimal _dONGIAGMDBBP1 = 0;
		private Decimal _dONGIAGMDBBP2 = 0;
		private Decimal _dONGIAGMDBCC = 0;
		private Decimal _dONGIAGMDBCP1 = 0;
		private Decimal _dONGIAGMDBCP2 = 0;
		private Decimal _dONGIAGMIC = 0;
		private Decimal _dONGIAGMDB1P1 = 0;
		private Decimal _dONGIAGMKC = 0;
		private Decimal _dONGIAGMKP1 = 0;
		private Decimal _dONGIAGMDBAC = 0;
		private Decimal _dONGIACECDBAP1 = 0;
		private Decimal _dONGIACECDBAP2 = 0;
		private Decimal _dONGIACECDBBC = 0;
		private Decimal _dONGIACECDBBP1 = 0;
		private Decimal _dONGIACECDBBP2 = 0;
		private Decimal _dONGIACECDBCC = 0;
		private Decimal _dONGIACECDBCP1 = 0;
		private Decimal _dONGIACECDBCP2 = 0;
		private Decimal _dONGIACECIC = 0;
		private Decimal _dONGIACECDB1P1 = 0;
		private Decimal _dONGIACECKC = 0;
		private Decimal _dONGIACECKP1 = 0;
		private Decimal _dONGIACECDBAC = 0;
		private Decimal _donGiaAnTrua = 0;
		private Decimal _donGiaAnToi = 0;
		private Decimal _mucLuongDocHai = 0;
		private Decimal _dONGIADCDB1P2 = 0;
		private Decimal _dONGIADCKP2 = 0;
		private Decimal _dONGIACECDB1P2 = 0;
		private Decimal _dONGIACECKP2 = 0;
		private Decimal _dONGIAGMDB1P2 = 0;
		private Decimal _dONGIAGMKP2 = 0;
		private Decimal _dONGIATMDBAP1 = 0;
		private Decimal _dONGIATMDBAP2 = 0;
		private Decimal _dONGIATMDBBC = 0;
		private Decimal _dONGIATMDBBP1 = 0;
		private Decimal _dONGIATMDBBP2 = 0;
		private Decimal _dONGIATMDBCC = 0;
		private Decimal _dONGIATMDBCP1 = 0;
		private Decimal _dONGIATMDBCP2 = 0;
		private Decimal _dONGIATMIC = 0;
		private Decimal _dONGIATMDB1P1 = 0;
		private Decimal _dONGIATMKC = 0;
		private Decimal _dONGIATMKP1 = 0;
		private Decimal _dONGIATMDBAC = 0;
		private Decimal _dONGIATMDCDBAP1 = 0;
		private Decimal _dONGIATMDCDBAP2 = 0;
		private Decimal _dONGIATMDCDBBC = 0;
		private Decimal _dONGIATMDCDBBP1 = 0;
		private Decimal _dONGIATMDCDBBP2 = 0;
		private Decimal _dONGIATMDCDBCC = 0;
		private Decimal _dONGIATMDCDBCP1 = 0;
		private Decimal _dONGIATMDCDBCP2 = 0;
		private Decimal _dONGIATMDCIC = 0;
		private Decimal _dONGIATMDCDB1P1 = 0;
		private Decimal _dONGIATMDCKC = 0;
		private Decimal _dONGIATMDCKP1 = 0;
		private Decimal _dONGIATMDCDBAC = 0;
		private Decimal _dONGIATMGMDBAP1 = 0;
		private Decimal _dONGIATMGMDBAP2 = 0;
		private Decimal _dONGIATMGMDBBC = 0;
		private Decimal _dONGIATMGMDBBP1 = 0;
		private Decimal _dONGIATMGMDBBP2 = 0;
		private Decimal _dONGIATMGMDBCC = 0;
		private Decimal _dONGIATMGMDBCP1 = 0;
		private Decimal _dONGIATMGMDBCP2 = 0;
		private Decimal _dONGIATMGMIC = 0;
		private Decimal _dONGIATMGMDB1P1 = 0;
		private Decimal _dONGIATMGMKC = 0;
		private Decimal _dONGIATMGMKP1 = 0;
		private Decimal _dONGIATMGMDBAC = 0;
		private Decimal _dONGIATMCECDBAP1 = 0;
		private Decimal _dONGIATMCECDBAP2 = 0;
		private Decimal _dONGIATMCECDBBC = 0;
		private Decimal _dONGIATMCECDBBP1 = 0;
		private Decimal _dONGIATMCECDBBP2 = 0;
		private Decimal _dONGIATMCECDBCC = 0;
		private Decimal _dONGIATMCECDBCP1 = 0;
		private Decimal _dONGIATMCECDBCP2 = 0;
		private Decimal _dONGIATMCECIC = 0;
		private Decimal _dONGIATMCECDB1P1 = 0;
		private Decimal _dONGIATMCECKC = 0;
		private Decimal _dONGIATMCECKP1 = 0;
		private Decimal _dONGIATMCECDBAC = 0;
		private Decimal _dONGIATMDB1P2 = 0;
		private Decimal _dONGIATMKP2 = 0;
		private Decimal _dONGIATMDCDB1P2 = 0;
		private Decimal _dONGIATMDCKP2 = 0;
		private Decimal _dONGIATMCECDB1P2 = 0;
		private Decimal _dONGIATMCECKP2 = 0;
		private Decimal _dONGIATMGMDB1P2 = 0;
		private Decimal _dONGIATMGMKP2 = 0;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private Decimal _dONGIADB1P2 = 0;
        private Decimal _dONGIAKP2 = 0;
        private Decimal _dONGIAGMTE = 0;
		#endregion
		
		#region Business Properties and Methods
		
		public String MucLuongCB
		{
			get 
			{
				CanReadProperty("MucLuongCB", true);
                if (_mucLuongCB == 0)
                {
                    return "";
                }

                else if (_mucLuongCB - (int)(_mucLuongCB) != 0)
                    return _mucLuongCB.ToString("###,##0.##");
                else
                    return _mucLuongCB.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("MucLuongCB", true);
                if (_mucLuongCB.ToString() != value)
                {
                    if (value == "")
                        _mucLuongCB = 0;
                    else
                        _mucLuongCB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucLuongCB");
                }
			}
		}
		
		public String BHYT
		{
			get 
			{
				CanReadProperty("BHYT", true);
                if (_bHYT == 0)
                {
                    return "";
                }

                else if (_bHYT - (int)(_bHYT) != 0)
                    return _bHYT.ToString("###,##0.##");
                else
                    return _bHYT.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("BHYT", true);
                if (_bHYT.ToString() != value)
                {
                    if (value == "")
                        _bHYT = 0;
                    else
                        _bHYT = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BHYT");
                }
			}
		}
		
		public String BHXH
		{
			get 
			{
				CanReadProperty("BHXH", true);
                if (_bHXH == 0)
                {
                    return "";
                }

                else if (_bHXH - (int)(_bHXH) != 0)
                    return _bHXH.ToString("###,##0.##");
                else
                    return _bHXH.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("BHXH", true);
                if (_bHXH.ToString() != value)
                {
                    if (value == "")
                        _bHXH = 0;
                    else
                        _bHXH = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BHXH");
                }
			}
		}
		
		public String CongDoan
		{
			get 
			{
				CanReadProperty("CongDoan", true);
                if (_congDoan == 0)
                {
                    return "";
                }

                else if (_congDoan - (int)(_congDoan) != 0)
                    return _congDoan.ToString("###,##0.##");
                else
                    return _congDoan.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("CongDoan", true);
                if (_congDoan.ToString() != value)
                {
                    if (value == "")
                        _congDoan = 0;
                    else
                        _congDoan = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CongDoan");
                }
			}
		}
		
		public String HeSoThamNien
		{
			get 
			{
				CanReadProperty("HeSoThamNien", true);
                if (_heSoThamNien == 0)
                {
                    return "";
                }

                else if (_heSoThamNien - (int)(_heSoThamNien) != 0)
                    return _heSoThamNien.ToString("###,##0.##");
                else
                    return _heSoThamNien.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoThamNien", true);
                if (_heSoThamNien.ToString() != value)
                {
                    if (value == "")
                        _heSoThamNien = 0;
                    else
                        _heSoThamNien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoThamNien");
                }
			}
		}
		
		public String DonGiaTruc
		{
			get 
			{
				CanReadProperty("DonGiaTruc", true);
                if (_donGiaTruc == 0)
                {
                    return "";
                }

                else if (_donGiaTruc - (int)(_donGiaTruc) != 0)
                    return _donGiaTruc.ToString("###,##0.##");
                else
                    return _donGiaTruc.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaTruc", true);
                if (_donGiaTruc.ToString() != value)
                {
                    if (value == "")
                        _donGiaTruc = 0;
                    else
                        _donGiaTruc = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaTruc");
                }
			}
		}
		
		public String DonGiaXQuang
		{
			get 
			{
				CanReadProperty("DonGiaXQuang", true);
                if (_donGiaXQuang == 0)
                {
                    return "";
                }

                else if (_donGiaXQuang - (int)(_donGiaXQuang) != 0)
                    return _donGiaXQuang.ToString("###,##0.##");
                else
                    return _donGiaXQuang.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaXQuang", true);
                if (_donGiaXQuang.ToString() != value)
                {
                    if (value == "")
                        _donGiaXQuang = 0;
                    else
                        _donGiaXQuang = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaXQuang");
                }
			}
		}
		
		public String DonGiaM2
		{
			get 
			{
				CanReadProperty("DonGiaM2", true);
                if (_donGiaM2 == 0)
                {
                    return "";
                }

                else if (_donGiaM2 - (int)(_donGiaM2) != 0)
                    return _donGiaM2.ToString("###,##0.##");
                else
                    return _donGiaM2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaM2", true);
                if (_donGiaM2.ToString() != value)
                {
                    if (value == "")
                        _donGiaM2 = 0;
                    else
                        _donGiaM2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaM2");
                }
			}
		}
		
		public String DonGiaNTHSCC
		{
			get 
			{
				CanReadProperty("DonGiaNTHSCC", true);
                if (_donGiaNTHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaNTHSCC - (int)(_donGiaNTHSCC) != 0)
                    return _donGiaNTHSCC.ToString("###,##0.##");
                else
                    return _donGiaNTHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNTHSCC", true);
                if (_donGiaNTHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTHSCC = 0;
                    else
                        _donGiaNTHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DonGiaNNHSCC
		{
			get 
			{
				CanReadProperty("DonGiaNNHSCC", true);
                if (_donGiaNNHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaNNHSCC - (int)(_donGiaNNHSCC) != 0)
                    return _donGiaNNHSCC.ToString("###,##0.##");
                else
                    return _donGiaNNHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNNHSCC", true);
                if (_donGiaNNHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNHSCC = 0;
                    else
                        _donGiaNNHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNHSCC");
                }
			}
		}
		
		public String DonGiaNLHSCC
		{
			get 
			{
				CanReadProperty("DonGiaNLHSCC", true);
                if (_donGiaNLHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaNLHSCC - (int)(_donGiaNLHSCC) != 0)
                    return _donGiaNLHSCC.ToString("###,##0.##");
                else
                    return _donGiaNLHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNLHSCC", true);
                if (_donGiaNLHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLHSCC = 0;
                    else
                        _donGiaNLHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLHSCC");
                }
			}
		}
		
		public String DonGiaQCCTNBHSCC
		{
			get 
			{
				CanReadProperty("DonGiaQCCTNBHSCC", true);
                if (_donGiaQCCTNBHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaQCCTNBHSCC - (int)(_donGiaQCCTNBHSCC) != 0)
                    return _donGiaQCCTNBHSCC.ToString("###,##0.##");
                else
                    return _donGiaQCCTNBHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaQCCTNBHSCC", true);
                if (_donGiaQCCTNBHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaQCCTNBHSCC = 0;
                    else
                        _donGiaQCCTNBHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaQCCTNBHSCC");
                }
			}
		}
		
		public String DonGiaND1142002HSCC
		{
			get 
			{
				CanReadProperty("DonGiaND1142002HSCC", true);
                if (_donGiaND1142002HSCC == 0)
                {
                    return "";
                }

                else if (_donGiaND1142002HSCC - (int)(_donGiaND1142002HSCC) != 0)
                    return _donGiaND1142002HSCC.ToString("###,##0.##");
                else
                    return _donGiaND1142002HSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaND1142002HSCC", true);
                if (_donGiaND1142002HSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaND1142002HSCC = 0;
                    else
                        _donGiaND1142002HSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaND1142002HSCC");
                }
			}
		}
		
		public String DonGiaNTCM
		{
			get 
			{
				CanReadProperty("DonGiaNTCM", true);
                if (_donGiaNTCM == 0)
                {
                    return "";
                }

                else if (_donGiaNTCM - (int)(_donGiaNTCM) != 0)
                    return _donGiaNTCM.ToString("###,##0.##");
                else
                    return _donGiaNTCM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNTCM", true);
                if (_donGiaNTCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTCM = 0;
                    else
                        _donGiaNTCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTCM");
                }
			}
		}
		
		public String DonGiaNNCM
		{
			get 
			{
				CanReadProperty("DonGiaNNCM", true);
                if (_donGiaNNCM == 0)
                {
                    return "";
                }

                else if (_donGiaNNCM - (int)(_donGiaNNCM) != 0)
                    return _donGiaNNCM.ToString("###,##0.##");
                else
                    return _donGiaNNCM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNNCM", true);
                if (_donGiaNNCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNCM = 0;
                    else
                        _donGiaNNCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNCM");
                }
			}
		}
		
		public String DonGiaNLCM
		{
			get 
			{
				CanReadProperty("DonGiaNLCM", true);
                if (_donGiaNLCM == 0)
                {
                    return "";
                }

                else if (_donGiaNLCM - (int)(_donGiaNLCM) != 0)
                    return _donGiaNLCM.ToString("###,##0.##");
                else
                    return _donGiaNLCM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNLCM", true);
                if (_donGiaNLCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLCM = 0;
                    else
                        _donGiaNLCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLCM");
                }
			}
		}
		
		public String DonGiaQCCTNBCM
		{
			get 
			{
				CanReadProperty("DonGiaQCCTNBCM", true);
                if (_donGiaQCCTNBCM == 0)
                {
                    return "";
                }

                else if (_donGiaQCCTNBCM - (int)(_donGiaQCCTNBCM) != 0)
                    return _donGiaQCCTNBCM.ToString("###,##0.##");
                else
                    return _donGiaQCCTNBCM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaQCCTNBCM", true);
                if (_donGiaQCCTNBCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaQCCTNBCM = 0;
                    else
                        _donGiaQCCTNBCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaQCCTNBCM");
                }
			}
		}
		
		public String DonGiaNTLD
		{
			get 
			{
				CanReadProperty("DonGiaNTLD", true);
                if (_donGiaNTLD == 0)
                {
                    return "";
                }

                else if (_donGiaNTLD - (int)(_donGiaNTLD) != 0)
                    return _donGiaNTLD.ToString("###,##0.##");
                else
                    return _donGiaNTLD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNTLD", true);
                if (_donGiaNTLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTLD = 0;
                    else
                        _donGiaNTLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTLD");
                }
			}
		}
		
		public String DonGiaNNLD
		{
			get 
			{
				CanReadProperty("DonGiaNNLD", true);
                if (_donGiaNNLD == 0)
                {
                    return "";
                }

                else if (_donGiaNNLD - (int)(_donGiaNNLD) != 0)
                    return _donGiaNNLD.ToString("###,##0.##");
                else
                    return _donGiaNNLD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNNLD", true);
                if (_donGiaNNLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNLD = 0;
                    else
                        _donGiaNNLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNLD");
                }
			}
		}
		
		public String DonGiaNLLD
		{
			get 
			{
				CanReadProperty("DonGiaNLLD", true);
                if (_donGiaNLLD == 0)
                {
                    return "";
                }

                else if (_donGiaNLLD - (int)(_donGiaNLLD) != 0)
                    return _donGiaNLLD.ToString("###,##0.##");
                else
                    return _donGiaNLLD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaNLLD", true);
                if (_donGiaNLLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLLD = 0;
                    else
                        _donGiaNLLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLLD");
                }
			}
		}
		
		public String DonGiaCocIHSCC
		{
			get 
			{
				CanReadProperty("DonGiaCocIHSCC", true);
                if (_donGiaCocIHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaCocIHSCC - (int)(_donGiaCocIHSCC) != 0)
                    return _donGiaCocIHSCC.ToString("###,##0.##");
                else
                    return _donGiaCocIHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaCocIHSCC", true);
                if (_donGiaCocIHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIHSCC = 0;
                    else
                        _donGiaCocIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIHSCC");
                }
			}
		}
		
		public String DonGiaCocIIHSCC
		{
			get 
			{
				CanReadProperty("DonGiaCocIIHSCC", true);
                if (_donGiaCocIIHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaCocIIHSCC - (int)(_donGiaCocIIHSCC) != 0)
                    return _donGiaCocIIHSCC.ToString("###,##0.##");
                else
                    return _donGiaCocIIHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaCocIIHSCC", true);
                if (_donGiaCocIIHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIIHSCC = 0;
                    else
                        _donGiaCocIIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIIHSCC");
                }
			}
		}
		
		public String DonGiaDDHSCC
		{
			get 
			{
				CanReadProperty("DonGiaDDHSCC", true);
                if (_donGiaDDHSCC == 0)
                {
                    return "";
                }

                else if (_donGiaDDHSCC - (int)(_donGiaDDHSCC) != 0)
                    return _donGiaDDHSCC.ToString("###,##0.##");
                else
                    return _donGiaDDHSCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaDDHSCC", true);
                if (_donGiaDDHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaDDHSCC = 0;
                    else
                        _donGiaDDHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaDDHSCC");
                }
			}
		}
		
		public String DonGiaCocICM
		{
			get 
			{
				CanReadProperty("DonGiaCocICM", true);
                if (_donGiaCocICM == 0)
                {
                    return "";
                }

                else if (_donGiaCocICM - (int)(_donGiaCocICM) != 0)
                    return _donGiaCocICM.ToString("###,##0.##");
                else
                    return _donGiaCocICM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaCocICM", true);
                if (_donGiaCocICM.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocICM = 0;
                    else
                        _donGiaCocICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocICM");
                }
			}
		}
		
		public String DonGiaCocIICM
		{
			get 
			{
				CanReadProperty("DonGiaCocIICM", true);
                if (_donGiaCocIICM == 0)
                {
                    return "";
                }

                else if (_donGiaCocIICM - (int)(_donGiaCocIICM) != 0)
                    return _donGiaCocIICM.ToString("###,##0.##");
                else
                    return _donGiaCocIICM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaCocIICM", true);
                if (_donGiaCocIICM.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIICM = 0;
                    else
                        _donGiaCocIICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIICM");
                }
			}
		}
		
		public String DonGiaDDCM
		{
			get 
			{
				CanReadProperty("DonGiaDDCM", true);
                if (_donGiaDDCM == 0)
                {
                    return "";
                }

                else if (_donGiaDDCM - (int)(_donGiaDDCM) != 0)
                    return _donGiaDDCM.ToString("###,##0.##");
                else
                    return _donGiaDDCM.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaDDCM", true);
                if (_donGiaDDCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaDDCM = 0;
                    else
                        _donGiaDDCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaDDCM");
                }
			}
		}
		
		public String DONGIADBAP1
		{
			get 
			{
				CanReadProperty("DONGIADBAP1", true);
                if (_dONGIADBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADBAP1 - (int)(_dONGIADBAP1) != 0)
                    return _dONGIADBAP1.ToString("###,##0.##");
                else
                    return _dONGIADBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBAP1", true);
                if (_dONGIADBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBAP1 = 0;
                    else
                        _dONGIADBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBAP1");
                }
			}
		}
		
		public String DONGIADBAP2
		{
			get 
			{
				CanReadProperty("DONGIADBAP2", true);
                if (_dONGIADBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADBAP2 - (int)(_dONGIADBAP2) != 0)
                    return _dONGIADBAP2.ToString("###,##0.##");
                else
                    return _dONGIADBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBAP2", true);
                if (_dONGIADBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBAP2 = 0;
                    else
                        _dONGIADBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBAP2");
                }
			}
		}
		
		public String DONGIADBBC
		{
			get 
			{
				CanReadProperty("DONGIADBBC", true);
                if (_dONGIADBBC == 0)
                {
                    return "";
                }

                else if (_dONGIADBBC - (int)(_dONGIADBBC) != 0)
                    return _dONGIADBBC.ToString("###,##0.##");
                else
                    return _dONGIADBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBBC", true);
                if (_dONGIADBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBBC = 0;
                    else
                        _dONGIADBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBBC");
                }
			}
		}
		
		public String DONGIADBBP1
		{
			get 
			{
				CanReadProperty("DONGIADBBP1", true);
                if (_dONGIADBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADBBP1 - (int)(_dONGIADBBP1) != 0)
                    return _dONGIADBBP1.ToString("###,##0.##");
                else
                    return _dONGIADBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBBP1", true);
                if (_dONGIADBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBBP1 = 0;
                    else
                        _dONGIADBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBBP1");
                }
			}
		}
		
		public String DONGIADBBP2
		{
			get 
			{
				CanReadProperty("DONGIADBBP2", true);
                if (_dONGIADBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADBBP2 - (int)(_dONGIADBBP2) != 0)
                    return _dONGIADBBP2.ToString("###,##0.##");
                else
                    return _dONGIADBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBBP2", true);
                if (_dONGIADBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBBP2 = 0;
                    else
                        _dONGIADBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBBP2");
                }
			}
		}
		
		public String DONGIADBCC
		{
			get 
			{
				CanReadProperty("DONGIADBCC", true);
                if (_dONGIADBCC == 0)
                {
                    return "";
                }

                else if (_dONGIADBCC - (int)(_dONGIADBCC) != 0)
                    return _dONGIADBCC.ToString("###,##0.##");
                else
                    return _dONGIADBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBCC", true);
                if (_dONGIADBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBCC = 0;
                    else
                        _dONGIADBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBCC");
                }
			}
		}
		
		public String DONGIADBCP1
		{
			get 
			{
				CanReadProperty("DONGIADBCP1", true);
                if (_dONGIADBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADBCP1 - (int)(_dONGIADBCP1) != 0)
                    return _dONGIADBCP1.ToString("###,##0.##");
                else
                    return _dONGIADBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBCP1", true);
                if (_dONGIADBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBCP1 = 0;
                    else
                        _dONGIADBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBCP1");
                }
			}
		}
		
		public String DONGIADBCP2
		{
			get 
			{
				CanReadProperty("DONGIADBCP2", true);
                if (_dONGIADBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADBCP2 - (int)(_dONGIADBCP2) != 0)
                    return _dONGIADBCP2.ToString("###,##0.##");
                else
                    return _dONGIADBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBCP2", true);
                if (_dONGIADBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBCP2 = 0;
                    else
                        _dONGIADBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBCP2");
                }
			}
		}
		
		public String DONGIAIC
		{
			get 
			{
				CanReadProperty("DONGIAIC", true);
                if (_dONGIAIC == 0)
                {
                    return "";
                }

                else if (_dONGIAIC - (int)(_dONGIAIC) != 0)
                    return _dONGIAIC.ToString("###,##0.##");
                else
                    return _dONGIAIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIC", true);
                if (_dONGIAIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIC = 0;
                    else
                        _dONGIAIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIC");
                }
			}
		}
		
		public String DONGIADB1P1
		{
			get 
			{
				CanReadProperty("DONGIADB1P1", true);
                if (_dONGIADB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIADB1P1 - (int)(_dONGIADB1P1) != 0)
                    return _dONGIADB1P1.ToString("###,##0.##");
                else
                    return _dONGIADB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADB1P1", true);
                if (_dONGIADB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADB1P1 = 0;
                    else
                        _dONGIADB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADB1P1");
                }
			}
		}
		
		public String DONGIAKC
		{
			get 
			{
				CanReadProperty("DONGIAKC", true);
                if (_dONGIAKC == 0)
                {
                    return "";
                }

                else if (_dONGIAKC - (int)(_dONGIAKC) != 0)
                    return _dONGIAKC.ToString("###,##0.##");
                else
                    return _dONGIAKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAKC", true);
                if (_dONGIAKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAKC = 0;
                    else
                        _dONGIAKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAKC");
                }
			}
		}
		
		public String DONGIAKP1
		{
			get 
			{
				CanReadProperty("DONGIAKP1", true);
                if (_dONGIAKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIAKP1 - (int)(_dONGIAKP1) != 0)
                    return _dONGIAKP1.ToString("###,##0.##");
                else
                    return _dONGIAKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAKP1", true);
                if (_dONGIAKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAKP1 = 0;
                    else
                        _dONGIAKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAKP1");
                }
			}
		}
		
		public String DONGIANgoaiVien
		{
			get 
			{
				CanReadProperty("DONGIANgoaiVien", true);
                if (_dONGIANgoaiVien == 0)
                {
                    return "";
                }

                else if (_dONGIANgoaiVien - (int)(_dONGIANgoaiVien) != 0)
                    return _dONGIANgoaiVien.ToString("###,##0.##");
                else
                    return _dONGIANgoaiVien.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIANgoaiVien", true);
                if (_dONGIANgoaiVien.ToString() != value)
                {
                    if (value == "")
                        _dONGIANgoaiVien = 0;
                    else
                        _dONGIANgoaiVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIANgoaiVien");
                }
			}
		}
		
		public String DONGIAChuTri
		{
			get 
			{
				CanReadProperty("DONGIAChuTri", true);
                if (_dONGIAChuTri == 0)
                {
                    return "";
                }

                else if (_dONGIAChuTri - (int)(_dONGIAChuTri) != 0)
                    return _dONGIAChuTri.ToString("###,##0.##");
                else
                    return _dONGIAChuTri.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAChuTri", true);
                if (_dONGIAChuTri.ToString() != value)
                {
                    if (value == "")
                        _dONGIAChuTri = 0;
                    else
                        _dONGIAChuTri = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAChuTri");
                }
			}
		}
		
		public String DONGIAThuKy
		{
			get 
			{
				CanReadProperty("DONGIAThuKy", true);
                if (_dONGIAThuKy == 0)
                {
                    return "";
                }

                else if (_dONGIAThuKy - (int)(_dONGIAThuKy) != 0)
                    return _dONGIAThuKy.ToString("###,##0.##");
                else
                    return _dONGIAThuKy.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAThuKy", true);
                if (_dONGIAThuKy.ToString() != value)
                {
                    if (value == "")
                        _dONGIAThuKy = 0;
                    else
                        _dONGIAThuKy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAThuKy");
                }
			}
		}
		
		public String DONGIABacSy
		{
			get 
			{
				CanReadProperty("DONGIABacSy", true);
                if (_dONGIABacSy == 0)
                {
                    return "";
                }

                else if (_dONGIABacSy - (int)(_dONGIABacSy) != 0)
                    return _dONGIABacSy.ToString("###,##0.##");
                else
                    return _dONGIABacSy.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIABacSy", true);
                if (_dONGIABacSy.ToString() != value)
                {
                    if (value == "")
                        _dONGIABacSy = 0;
                    else
                        _dONGIABacSy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIABacSy");
                }
			}
		}
		
		public String DONGIADD
		{
			get 
			{
				CanReadProperty("DONGIADD", true);
                if (_dONGIADD == 0)
                {
                    return "";
                }

                else if (_dONGIADD - (int)(_dONGIADD) != 0)
                    return _dONGIADD.ToString("###,##0.##");
                else
                    return _dONGIADD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADD", true);
                if (_dONGIADD.ToString() != value)
                {
                    if (value == "")
                        _dONGIADD = 0;
                    else
                        _dONGIADD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADD");
                }
			}
		}
		
		public String DONGIANVien
		{
			get 
			{
				CanReadProperty("DONGIANVien", true);
                if (_dONGIANVien == 0)
                {
                    return "";
                }

                else if (_dONGIANVien - (int)(_dONGIANVien) != 0)
                    return _dONGIANVien.ToString("###,##0.##");
                else
                    return _dONGIANVien.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIANVien", true);
                if (_dONGIANVien.ToString() != value)
                {
                    if (value == "")
                        _dONGIANVien = 0;
                    else
                        _dONGIANVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIANVien");
                }
			}
		}
		
		public String DONGIADBBS
		{
			get 
			{
				CanReadProperty("DONGIADBBS", true);
                if (_dONGIADBBS == 0)
                {
                    return "";
                }

                else if (_dONGIADBBS - (int)(_dONGIADBBS) != 0)
                    return _dONGIADBBS.ToString("###,##0.##");
                else
                    return _dONGIADBBS.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBBS", true);
                if (_dONGIADBBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBBS = 0;
                    else
                        _dONGIADBBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBBS");
                }
			}
		}
		
		public String DONGIADBDD
		{
			get 
			{
				CanReadProperty("DONGIADBDD", true);
                if (_dONGIADBDD == 0)
                {
                    return "";
                }

                else if (_dONGIADBDD - (int)(_dONGIADBDD) != 0)
                    return _dONGIADBDD.ToString("###,##0.##");
                else
                    return _dONGIADBDD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBDD", true);
                if (_dONGIADBDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBDD = 0;
                    else
                        _dONGIADBDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBDD");
                }
			}
		}
		
		public String DONGIAIBS
		{
			get 
			{
				CanReadProperty("DONGIAIBS", true);
                if (_dONGIAIBS == 0)
                {
                    return "";
                }

                else if (_dONGIAIBS - (int)(_dONGIAIBS) != 0)
                    return _dONGIAIBS.ToString("###,##0.##");
                else
                    return _dONGIAIBS.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIBS", true);
                if (_dONGIAIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIBS = 0;
                    else
                        _dONGIAIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIBS");
                }
			}
		}
		
		public String DONGIAIDD
		{
			get 
			{
				CanReadProperty("DONGIAIDD", true);
                if (_dONGIAIDD == 0)
                {
                    return "";
                }

                else if (_dONGIAIDD - (int)(_dONGIAIDD) != 0)
                    return _dONGIAIDD.ToString("###,##0.##");
                else
                    return _dONGIAIDD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIDD", true);
                if (_dONGIAIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIDD = 0;
                    else
                        _dONGIAIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIDD");
                }
			}
		}
		
		public String DONGIAIIBS
		{
			get 
			{
				CanReadProperty("DONGIAIIBS", true);
                if (_dONGIAIIBS == 0)
                {
                    return "";
                }

                else if (_dONGIAIIBS - (int)(_dONGIAIIBS) != 0)
                    return _dONGIAIIBS.ToString("###,##0.##");
                else
                    return _dONGIAIIBS.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIIBS", true);
                if (_dONGIAIIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIBS = 0;
                    else
                        _dONGIAIIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIBS");
                }
			}
		}
		
		public String DONGIAIIDD
		{
			get 
			{
				CanReadProperty("DONGIAIIDD", true);
                if (_dONGIAIIDD == 0)
                {
                    return "";
                }

                else if (_dONGIAIIDD - (int)(_dONGIAIIDD) != 0)
                    return _dONGIAIIDD.ToString("###,##0.##");
                else
                    return _dONGIAIIDD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIIDD", true);
                if (_dONGIAIIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIDD = 0;
                    else
                        _dONGIAIIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIDD");
                }
			}
		}
		
		public String DONGIAIIIBS
		{
			get 
			{
				CanReadProperty("DONGIAIIIBS", true);
                if (_dONGIAIIIBS == 0)
                {
                    return "";
                }

                else if (_dONGIAIIIBS - (int)(_dONGIAIIIBS) != 0)
                    return _dONGIAIIIBS.ToString("###,##0.##");
                else
                    return _dONGIAIIIBS.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIIIBS", true);
                if (_dONGIAIIIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIIBS = 0;
                    else
                        _dONGIAIIIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIIBS");
                }
			}
		}
		
		public String DONGIAIIIDD
		{
			get 
			{
				CanReadProperty("DONGIAIIIDD", true);
                if (_dONGIAIIIDD == 0)
                {
                    return "";
                }

                else if (_dONGIAIIIDD - (int)(_dONGIAIIIDD) != 0)
                    return _dONGIAIIIDD.ToString("###,##0.##");
                else
                    return _dONGIAIIIDD.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAIIIDD", true);
                if (_dONGIAIIIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIIDD = 0;
                    else
                        _dONGIAIIIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIIDD");
                }
			}
		}
		
		public String HeSoPTHS
		{
			get 
			{
				CanReadProperty("HeSoPTHS", true);
                if (_heSoPTHS == 0)
                {
                    return "";
                }

                else if (_heSoPTHS - (int)(_heSoPTHS) != 0)
                    return _heSoPTHS.ToString("###,##0.##");
                else
                    return _heSoPTHS.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoPTHS", true);
                if (_heSoPTHS.ToString() != value)
                {
                    if (value == "")
                        _heSoPTHS = 0;
                    else
                        _heSoPTHS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoPTHS");
                }
			}
		}
		
		public String DONGIAA
		{
			get 
			{
				CanReadProperty("DONGIAA", true);
                if (_dONGIAA == 0)
                {
                    return "";
                }

                else if (_dONGIAA - (int)(_dONGIAA) != 0)
                    return _dONGIAA.ToString("###,##0.##");
                else
                    return _dONGIAA.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAA", true);
                if (_dONGIAA.ToString() != value)
                {
                    if (value == "")
                        _dONGIAA = 0;
                    else
                        _dONGIAA = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAA");
                }
			}
		}
		
		public String DONGIAB
		{
			get 
			{
				CanReadProperty("DONGIAB", true);
                if (_dONGIAB == 0)
                {
                    return "";
                }

                else if (_dONGIAB - (int)(_dONGIAB) != 0)
                    return _dONGIAB.ToString("###,##0.##");
                else
                    return _dONGIAB.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAB", true);
                if (_dONGIAB.ToString() != value)
                {
                    if (value == "")
                        _dONGIAB = 0;
                    else
                        _dONGIAB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAB");
                }
			}
		}
		
		public String DONGIAC
		{
			get 
			{
				CanReadProperty("DONGIAC", true);
                if (_dONGIAC == 0)
                {
                    return "";
                }

                else if (_dONGIAC - (int)(_dONGIAC) != 0)
                    return _dONGIAC.ToString("###,##0.##");
                else
                    return _dONGIAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAC", true);
                if (_dONGIAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAC = 0;
                    else
                        _dONGIAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAC");
                }
			}
		}
		
		public String MucTTThue
		{
			get 
			{
				CanReadProperty("MucTTThue", true);
                if (_mucTTThue == 0)
                {
                    return "";
                }

                else if (_mucTTThue - (int)(_mucTTThue) != 0)
                    return _mucTTThue.ToString("###,##0.##");
                else
                    return _mucTTThue.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("MucTTThue", true);
                if (_mucTTThue.ToString() != value)
                {
                    if (value == "")
                        _mucTTThue = 0;
                    else
                        _mucTTThue = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucTTThue");
                }
			}
		}
		
		public String HeSoLamDem
		{
			get 
			{
				CanReadProperty("HeSoLamDem", true);
                if (_heSoLamDem == 0)
                {
                    return "";
                }

                else if (_heSoLamDem - (int)(_heSoLamDem) != 0)
                    return _heSoLamDem.ToString("###,##0.##");
                else
                    return _heSoLamDem.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoLamDem", true);
                if (_heSoLamDem.ToString() != value)
                {
                    if (value == "")
                        _heSoLamDem = 0;
                    else
                        _heSoLamDem = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoLamDem");
                }
			}
		}
		
		public String HeSoNgoaiGio
		{
			get 
			{
				CanReadProperty("HeSoNgoaiGio", true);
                if (_heSoNgoaiGio == 0)
                {
                    return "";
                }

                else if (_heSoNgoaiGio - (int)(_heSoNgoaiGio) != 0)
                    return _heSoNgoaiGio.ToString("###,##0.##");
                else
                    return _heSoNgoaiGio.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoNgoaiGio", true);
                if (_heSoNgoaiGio.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGio = 0;
                    else
                        _heSoNgoaiGio = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGio");
                }
			}
		}
		
		public String HeSoNgoaiGio7
		{
			get 
			{
				CanReadProperty("HeSoNgoaiGio7", true);
                if (_heSoNgoaiGio7 == 0)
                {
                    return "";
                }

                else if (_heSoNgoaiGio7 - (int)(_heSoNgoaiGio7) != 0)
                    return _heSoNgoaiGio7.ToString("###,##0.##");
                else
                    return _heSoNgoaiGio7.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoNgoaiGio7", true);
                if (_heSoNgoaiGio7.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGio7 = 0;
                    else
                        _heSoNgoaiGio7 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGio7");
                }
			}
		}
		
		public String HeSoNgoaiGioLe
		{
			get 
			{
				CanReadProperty("HeSoNgoaiGioLe", true);
                if (_heSoNgoaiGioLe == 0)
                {
                    return "";
                }

                else if (_heSoNgoaiGioLe - (int)(_heSoNgoaiGioLe) != 0)
                    return _heSoNgoaiGioLe.ToString("###,##0.##");
                else
                    return _heSoNgoaiGioLe.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("HeSoNgoaiGioLe", true);
                if (_heSoNgoaiGioLe.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGioLe = 0;
                    else
                        _heSoNgoaiGioLe = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGioLe");
                }
			}
		}
		
		public String DONGIADBAC
		{
			get 
			{
				CanReadProperty("DONGIADBAC", true);
                if (_dONGIADBAC == 0)
                {
                    return "";
                }

                else if (_dONGIADBAC - (int)(_dONGIADBAC) != 0)
                    return _dONGIADBAC.ToString("###,##0.##");
                else
                    return _dONGIADBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADBAC", true);
                if (_dONGIADBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBAC = 0;
                    else
                        _dONGIADBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADBAC");
                }
			}
		}
		
		public String DONGIADCDBAP1
		{
			get 
			{
				CanReadProperty("DONGIADCDBAP1", true);
                if (_dONGIADCDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBAP1 - (int)(_dONGIADCDBAP1) != 0)
                    return _dONGIADCDBAP1.ToString("###,##0.##");
                else
                    return _dONGIADCDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBAP1", true);
                if (_dONGIADCDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBAP1 = 0;
                    else
                        _dONGIADCDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBAP1");
                }
			}
		}
		
		public String DONGIADCDBAP2
		{
			get 
			{
				CanReadProperty("DONGIADCDBAP2", true);
                if (_dONGIADCDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBAP2 - (int)(_dONGIADCDBAP2) != 0)
                    return _dONGIADCDBAP2.ToString("###,##0.##");
                else
                    return _dONGIADCDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBAP2", true);
                if (_dONGIADCDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBAP2 = 0;
                    else
                        _dONGIADCDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBAP2");
                }
			}
		}
		
		public String DONGIADCDBBC
		{
			get 
			{
				CanReadProperty("DONGIADCDBBC", true);
                if (_dONGIADCDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBBC - (int)(_dONGIADCDBBC) != 0)
                    return _dONGIADCDBBC.ToString("###,##0.##");
                else
                    return _dONGIADCDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBBC", true);
                if (_dONGIADCDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBBC = 0;
                    else
                        _dONGIADCDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBBC");
                }
			}
		}
		
		public String DONGIADCDBBP1
		{
			get 
			{
				CanReadProperty("DONGIADCDBBP1", true);
                if (_dONGIADCDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBBP1 - (int)(_dONGIADCDBBP1) != 0)
                    return _dONGIADCDBBP1.ToString("###,##0.##");
                else
                    return _dONGIADCDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBBP1", true);
                if (_dONGIADCDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBBP1 = 0;
                    else
                        _dONGIADCDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBBP1");
                }
			}
		}
		
		public String DONGIADCDBBP2
		{
			get 
			{
				CanReadProperty("DONGIADCDBBP2", true);
                if (_dONGIADCDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBBP2 - (int)(_dONGIADCDBBP2) != 0)
                    return _dONGIADCDBBP2.ToString("###,##0.##");
                else
                    return _dONGIADCDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBBP2", true);
                if (_dONGIADCDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBBP2 = 0;
                    else
                        _dONGIADCDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBBP2");
                }
			}
		}
		
		public String DONGIADCDBCC
		{
			get 
			{
				CanReadProperty("DONGIADCDBCC", true);
                if (_dONGIADCDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBCC - (int)(_dONGIADCDBCC) != 0)
                    return _dONGIADCDBCC.ToString("###,##0.##");
                else
                    return _dONGIADCDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBCC", true);
                if (_dONGIADCDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBCC = 0;
                    else
                        _dONGIADCDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCDBCP1
		{
			get 
			{
				CanReadProperty("DONGIADCDBCP1", true);
                if (_dONGIADCDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBCP1 - (int)(_dONGIADCDBCP1) != 0)
                    return _dONGIADCDBCP1.ToString("###,##0.##");
                else
                    return _dONGIADCDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBCP1", true);
                if (_dONGIADCDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBCP1 = 0;
                    else
                        _dONGIADCDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDBCP1");
                }
			}
		}
		
		public String DONGIADCDBCP2
		{
			get 
			{
				CanReadProperty("DONGIADCDBCP2", true);
                if (_dONGIADCDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBCP2 - (int)(_dONGIADCDBCP2) != 0)
                    return _dONGIADCDBCP2.ToString("###,##0.##");
                else
                    return _dONGIADCDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBCP2", true);
                if (_dONGIADCDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBCP2 = 0;
                    else
                        _dONGIADCDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCIC
		{
			get 
			{
				CanReadProperty("DONGIADCIC", true);
                if (_dONGIADCIC == 0)
                {
                    return "";
                }

                else if (_dONGIADCIC - (int)(_dONGIADCIC) != 0)
                    return _dONGIADCIC.ToString("###,##0.##");
                else
                    return _dONGIADCIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCIC", true);
                if (_dONGIADCIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCIC = 0;
                    else
                        _dONGIADCIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCDB1P1
		{
			get 
			{
				CanReadProperty("DONGIADCDB1P1", true);
                if (_dONGIADCDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDB1P1 - (int)(_dONGIADCDB1P1) != 0)
                    return _dONGIADCDB1P1.ToString("###,##0.##");
                else
                    return _dONGIADCDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDB1P1", true);
                if (_dONGIADCDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDB1P1 = 0;
                    else
                        _dONGIADCDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCKC
		{
			get 
			{
				CanReadProperty("DONGIADCKC", true);
                if (_dONGIADCKC == 0)
                {
                    return "";
                }

                else if (_dONGIADCKC - (int)(_dONGIADCKC) != 0)
                    return _dONGIADCKC.ToString("###,##0.##");
                else
                    return _dONGIADCKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCKC", true);
                if (_dONGIADCKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCKC = 0;
                    else
                        _dONGIADCKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCKP1
		{
			get 
			{
				CanReadProperty("DONGIADCKP1", true);
                if (_dONGIADCKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIADCKP1 - (int)(_dONGIADCKP1) != 0)
                    return _dONGIADCKP1.ToString("###,##0.##");
                else
                    return _dONGIADCKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCKP1", true);
                if (_dONGIADCKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCKP1 = 0;
                    else
                        _dONGIADCKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIADCDBAC
		{
			get 
			{
				CanReadProperty("DONGIADCDBAC", true);
                if (_dONGIADCDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIADCDBAC - (int)(_dONGIADCDBAC) != 0)
                    return _dONGIADCDBAC.ToString("###,##0.##");
                else
                    return _dONGIADCDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDBAC", true);
                if (_dONGIADCDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDBAC = 0;
                    else
                        _dONGIADCDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIAGMDBAP1
		{
			get 
			{
				CanReadProperty("DONGIAGMDBAP1", true);
                if (_dONGIAGMDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBAP1 - (int)(_dONGIAGMDBAP1) != 0)
                    return _dONGIAGMDBAP1.ToString("###,##0.##");
                else
                    return _dONGIAGMDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBAP1", true);
                if (_dONGIAGMDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBAP1 = 0;
                    else
                        _dONGIAGMDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIAGMDBAP2
		{
			get 
			{
				CanReadProperty("DONGIAGMDBAP2", true);
                if (_dONGIAGMDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBAP2 - (int)(_dONGIAGMDBAP2) != 0)
                    return _dONGIAGMDBAP2.ToString("###,##0.##");
                else
                    return _dONGIAGMDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBAP2", true);
                if (_dONGIAGMDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBAP2 = 0;
                    else
                        _dONGIAGMDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBAP2");
                }
			}
		}
		
		public String DONGIAGMDBBC
		{
			get 
			{
				CanReadProperty("DONGIAGMDBBC", true);
                if (_dONGIAGMDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBBC - (int)(_dONGIAGMDBBC) != 0)
                    return _dONGIAGMDBBC.ToString("###,##0.##");
                else
                    return _dONGIAGMDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBBC", true);
                if (_dONGIAGMDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBBC = 0;
                    else
                        _dONGIAGMDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBBC");
                }
			}
		}
		
		public String DONGIAGMDBBP1
		{
			get 
			{
				CanReadProperty("DONGIAGMDBBP1", true);
                if (_dONGIAGMDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBBP1 - (int)(_dONGIAGMDBBP1) != 0)
                    return _dONGIAGMDBBP1.ToString("###,##0.##");
                else
                    return _dONGIAGMDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBBP1", true);
                if (_dONGIAGMDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBBP1 = 0;
                    else
                        _dONGIAGMDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBBP1");
                }
			}
		}
		
		public String DONGIAGMDBBP2
		{
			get 
			{
				CanReadProperty("DONGIAGMDBBP2", true);
                if (_dONGIAGMDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBBP2 - (int)(_dONGIAGMDBBP2) != 0)
                    return _dONGIAGMDBBP2.ToString("###,##0.##");
                else
                    return _dONGIAGMDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBBP2", true);
                if (_dONGIAGMDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBBP2 = 0;
                    else
                        _dONGIAGMDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBBP2");
                }
			}
		}
		
		public String DONGIAGMDBCC
		{
			get 
			{
				CanReadProperty("DONGIAGMDBCC", true);
                if (_dONGIAGMDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBCC - (int)(_dONGIAGMDBCC) != 0)
                    return _dONGIAGMDBCC.ToString("###,##0.##");
                else
                    return _dONGIAGMDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBCC", true);
                if (_dONGIAGMDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBCC = 0;
                    else
                        _dONGIAGMDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIAGMDBCP1
		{
			get 
			{
				CanReadProperty("DONGIAGMDBCP1", true);
                if (_dONGIAGMDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBCP1 - (int)(_dONGIAGMDBCP1) != 0)
                    return _dONGIAGMDBCP1.ToString("###,##0.##");
                else
                    return _dONGIAGMDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBCP1", true);
                if (_dONGIAGMDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBCP1 = 0;
                    else
                        _dONGIAGMDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBCP1");
                }
			}
		}
		
		public String DONGIAGMDBCP2
		{
			get 
			{
				CanReadProperty("DONGIAGMDBCP2", true);
                if (_dONGIAGMDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBCP2 - (int)(_dONGIAGMDBCP2) != 0)
                    return _dONGIAGMDBCP2.ToString("###,##0.##");
                else
                    return _dONGIAGMDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBCP2", true);
                if (_dONGIAGMDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBCP2 = 0;
                    else
                        _dONGIAGMDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBCP2");
                }
			}
		}
		
		public String DONGIAGMIC
		{
			get 
			{
				CanReadProperty("DONGIAGMIC", true);
                if (_dONGIAGMIC == 0)
                {
                    return "";
                }

                else if (_dONGIAGMIC - (int)(_dONGIAGMIC) != 0)
                    return _dONGIAGMIC.ToString("###,##0.##");
                else
                    return _dONGIAGMIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMIC", true);
                if (_dONGIAGMIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMIC = 0;
                    else
                        _dONGIAGMIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIAGMDB1P1
		{
			get 
			{
				CanReadProperty("DONGIAGMDB1P1", true);
                if (_dONGIAGMDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDB1P1 - (int)(_dONGIAGMDB1P1) != 0)
                    return _dONGIAGMDB1P1.ToString("###,##0.##");
                else
                    return _dONGIAGMDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDB1P1", true);
                if (_dONGIAGMDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDB1P1 = 0;
                    else
                        _dONGIAGMDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDB1P1");
                }
			}
		}
		
		public String DONGIAGMKC
		{
			get 
			{
				CanReadProperty("DONGIAGMKC", true);
                if (_dONGIAGMKC == 0)
                {
                    return "";
                }

                else if (_dONGIAGMKC - (int)(_dONGIAGMKC) != 0)
                    return _dONGIAGMKC.ToString("###,##0.##");
                else
                    return _dONGIAGMKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMKC", true);
                if (_dONGIAGMKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMKC = 0;
                    else
                        _dONGIAGMKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMKC");
                }
			}
		}
		
		public String DONGIAGMKP1
		{
			get 
			{
				CanReadProperty("DONGIAGMKP1", true);
                if (_dONGIAGMKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMKP1 - (int)(_dONGIAGMKP1) != 0)
                    return _dONGIAGMKP1.ToString("###,##0.##");
                else
                    return _dONGIAGMKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMKP1", true);
                if (_dONGIAGMKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMKP1 = 0;
                    else
                        _dONGIAGMKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIAGMDBAC
		{
			get 
			{
				CanReadProperty("DONGIAGMDBAC", true);
                if (_dONGIAGMDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDBAC - (int)(_dONGIAGMDBAC) != 0)
                    return _dONGIAGMDBAC.ToString("###,##0.##");
                else
                    return _dONGIAGMDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDBAC", true);
                if (_dONGIAGMDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDBAC = 0;
                    else
                        _dONGIAGMDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDBAC");
                }
			}
		}
		
		public String DONGIACECDBAP1
		{
			get 
			{
				CanReadProperty("DONGIACECDBAP1", true);
                if (_dONGIACECDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBAP1 - (int)(_dONGIACECDBAP1) != 0)
                    return _dONGIACECDBAP1.ToString("###,##0.##");
                else
                    return _dONGIACECDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBAP1", true);
                if (_dONGIACECDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBAP1 = 0;
                    else
                        _dONGIACECDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBAP1");
                }
			}
		}
		
		public String DONGIACECDBAP2
		{
			get 
			{
				CanReadProperty("DONGIACECDBAP2", true);
                if (_dONGIACECDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBAP2 - (int)(_dONGIACECDBAP2) != 0)
                    return _dONGIACECDBAP2.ToString("###,##0.##");
                else
                    return _dONGIACECDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBAP2", true);
                if (_dONGIACECDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBAP2 = 0;
                    else
                        _dONGIACECDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBAP2");
                }
			}
		}
		
		public String DONGIACECDBBC
		{
			get 
			{
				CanReadProperty("DONGIACECDBBC", true);
                if (_dONGIACECDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBBC - (int)(_dONGIACECDBBC) != 0)
                    return _dONGIACECDBBC.ToString("###,##0.##");
                else
                    return _dONGIACECDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBBC", true);
                if (_dONGIACECDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBBC = 0;
                    else
                        _dONGIACECDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBBC");
                }
			}
		}
		
		public String DONGIACECDBBP1
		{
			get 
			{
				CanReadProperty("DONGIACECDBBP1", true);
                if (_dONGIACECDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBBP1 - (int)(_dONGIACECDBBP1) != 0)
                    return _dONGIACECDBBP1.ToString("###,##0.##");
                else
                    return _dONGIACECDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBBP1", true);
                if (_dONGIACECDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBBP1 = 0;
                    else
                        _dONGIACECDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBBP1");
                }
			}
		}
		
		public String DONGIACECDBBP2
		{
			get 
			{
				CanReadProperty("DONGIACECDBBP2", true);
                if (_dONGIACECDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBBP2 - (int)(_dONGIACECDBBP2) != 0)
                    return _dONGIACECDBBP2.ToString("###,##0.##");
                else
                    return _dONGIACECDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBBP2", true);
                if (_dONGIACECDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBBP2 = 0;
                    else
                        _dONGIACECDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIACECDBCC
		{
			get 
			{
				CanReadProperty("DONGIACECDBCC", true);
                if (_dONGIACECDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBCC - (int)(_dONGIACECDBCC) != 0)
                    return _dONGIACECDBCC.ToString("###,##0.##");
                else
                    return _dONGIACECDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBCC", true);
                if (_dONGIACECDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBCC = 0;
                    else
                        _dONGIACECDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBCC");
                }
			}
		}
		
		public String DONGIACECDBCP1
		{
			get 
			{
				CanReadProperty("DONGIACECDBCP1", true);
                if (_dONGIACECDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBCP1 - (int)(_dONGIACECDBCP1) != 0)
                    return _dONGIACECDBCP1.ToString("###,##0.##");
                else
                    return _dONGIACECDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBCP1", true);
                if (_dONGIACECDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBCP1 = 0;
                    else
                        _dONGIACECDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBCP1");
                }
			}
		}
		
		public String DONGIACECDBCP2
		{
			get 
			{
				CanReadProperty("DONGIACECDBCP2", true);
                if (_dONGIACECDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBCP2 - (int)(_dONGIACECDBCP2) != 0)
                    return _dONGIACECDBCP2.ToString("###,##0.##");
                else
                    return _dONGIACECDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBCP2", true);
                if (_dONGIACECDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBCP2 = 0;
                    else
                        _dONGIACECDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBCP2");
                }
			}
		}
		
		public String DONGIACECIC
		{
			get 
			{
				CanReadProperty("DONGIACECIC", true);
                if (_dONGIACECIC == 0)
                {
                    return "";
                }

                else if (_dONGIACECIC - (int)(_dONGIACECIC) != 0)
                    return _dONGIACECIC.ToString("###,##0.##");
                else
                    return _dONGIACECIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECIC", true);
                if (_dONGIACECIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECIC = 0;
                    else
                        _dONGIACECIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECIC");
                }
			}
		}
		
		public String DONGIACECDB1P1
		{
			get 
			{
				CanReadProperty("DONGIACECDB1P1", true);
                if (_dONGIACECDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDB1P1 - (int)(_dONGIACECDB1P1) != 0)
                    return _dONGIACECDB1P1.ToString("###,##0.##");
                else
                    return _dONGIACECDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDB1P1", true);
                if (_dONGIACECDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDB1P1 = 0;
                    else
                        _dONGIACECDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDB1P1");
                }
			}
		}
		
		public String DONGIACECKC
		{
			get 
			{
				CanReadProperty("DONGIACECKC", true);
                if (_dONGIACECKC == 0)
                {
                    return "";
                }

                else if (_dONGIACECKC - (int)(_dONGIACECKC) != 0)
                    return _dONGIACECKC.ToString("###,##0.##");
                else
                    return _dONGIACECKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECKC", true);
                if (_dONGIACECKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECKC = 0;
                    else
                        _dONGIACECKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECKC");
                }
			}
		}
		
		public String DONGIACECKP1
		{
			get 
			{
				CanReadProperty("DONGIACECKP1", true);
                if (_dONGIACECKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIACECKP1 - (int)(_dONGIACECKP1) != 0)
                    return _dONGIACECKP1.ToString("###,##0.##");
                else
                    return _dONGIACECKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECKP1", true);
                if (_dONGIACECKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECKP1 = 0;
                    else
                        _dONGIACECKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECKP1");
                }
			}
		}
		
		public String DONGIACECDBAC
		{
			get 
			{
				CanReadProperty("DONGIACECDBAC", true);
                if (_dONGIACECDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIACECDBAC - (int)(_dONGIACECDBAC) != 0)
                    return _dONGIACECDBAC.ToString("###,##0.##");
                else
                    return _dONGIACECDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDBAC", true);
                if (_dONGIACECDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDBAC = 0;
                    else
                        _dONGIACECDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDBAC");
                }
			}
		}
		
		public String DonGiaAnTrua
		{
			get 
			{
				CanReadProperty("DonGiaAnTrua", true);
                if (_donGiaAnTrua == 0)
                {
                    return "";
                }

                else if (_donGiaAnTrua - (int)(_donGiaAnTrua) != 0)
                    return _donGiaAnTrua.ToString("###,##0.##");
                else
                    return _donGiaAnTrua.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaAnTrua", true);
                if (_donGiaAnTrua.ToString() != value)
                {
                    if (value == "")
                        _donGiaAnTrua = 0;
                    else
                        _donGiaAnTrua = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaAnTrua");
                }
			}
		}
		
		public String DonGiaAnToi
		{
			get 
			{
				CanReadProperty("DonGiaAnToi", true);
                if (_donGiaAnToi == 0)
                {
                    return "";
                }

                else if (_donGiaAnToi - (int)(_donGiaAnToi) != 0)
                    return _donGiaAnToi.ToString("###,##0.##");
                else
                    return _donGiaAnToi.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DonGiaAnToi", true);
                if (_donGiaAnToi.ToString() != value)
                {
                    if (value == "")
                        _donGiaAnToi = 0;
                    else
                        _donGiaAnToi = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaAnToi");
                }
			}
		}
		
		public String MucLuongDocHai
		{
			get 
			{
				CanReadProperty("MucLuongDocHai", true);
                if (_mucLuongDocHai == 0)
                {
                    return "";
                }

                else if (_mucLuongDocHai - (int)(_mucLuongDocHai) != 0)
                    return _mucLuongDocHai.ToString("###,##0.##");
                else
                    return _mucLuongDocHai.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("MucLuongDocHai", true);
                if (_mucLuongDocHai.ToString() != value)
                {
                    if (value == "")
                        _mucLuongDocHai = 0;
                    else
                        _mucLuongDocHai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucLuongDocHai");
                }
			}
		}
		
		public String DONGIADCDB1P2
		{
			get 
			{
				CanReadProperty("DONGIADCDB1P2", true);
                if (_dONGIADCDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIADCDB1P2 - (int)(_dONGIADCDB1P2) != 0)
                    return _dONGIADCDB1P2.ToString("###,##0.##");
                else
                    return _dONGIADCDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCDB1P2", true);
                if (_dONGIADCDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCDB1P2 = 0;
                    else
                        _dONGIADCDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCDB1P2");
                }
			}
		}
		
		public String DONGIADCKP2
		{
			get 
			{
				CanReadProperty("DONGIADCKP2", true);
                if (_dONGIADCKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIADCKP2 - (int)(_dONGIADCKP2) != 0)
                    return _dONGIADCKP2.ToString("###,##0.##");
                else
                    return _dONGIADCKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIADCKP2", true);
                if (_dONGIADCKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADCKP2 = 0;
                    else
                        _dONGIADCKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADCKP2");
                }
			}
		}
		
		public String DONGIACECDB1P2
		{
			get 
			{
				CanReadProperty("DONGIACECDB1P2", true);
                if (_dONGIACECDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIACECDB1P2 - (int)(_dONGIACECDB1P2) != 0)
                    return _dONGIACECDB1P2.ToString("###,##0.##");
                else
                    return _dONGIACECDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECDB1P2", true);
                if (_dONGIACECDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECDB1P2 = 0;
                    else
                        _dONGIACECDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECDB1P2");
                }
			}
		}
		
		public String DONGIACECKP2
		{
			get 
			{
				CanReadProperty("DONGIACECKP2", true);
                if (_dONGIACECKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIACECKP2 - (int)(_dONGIACECKP2) != 0)
                    return _dONGIACECKP2.ToString("###,##0.##");
                else
                    return _dONGIACECKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIACECKP2", true);
                if (_dONGIACECKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIACECKP2 = 0;
                    else
                        _dONGIACECKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIACECKP2");
                }
			}
		}
		
		public String DONGIAGMDB1P2
		{
			get 
			{
				CanReadProperty("DONGIAGMDB1P2", true);
                if (_dONGIAGMDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMDB1P2 - (int)(_dONGIAGMDB1P2) != 0)
                    return _dONGIAGMDB1P2.ToString("###,##0.##");
                else
                    return _dONGIAGMDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMDB1P2", true);
                if (_dONGIAGMDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMDB1P2 = 0;
                    else
                        _dONGIAGMDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMDB1P2");
                }
			}
		}
		
		public String DONGIAGMKP2
		{
			get 
			{
				CanReadProperty("DONGIAGMKP2", true);
                if (_dONGIAGMKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIAGMKP2 - (int)(_dONGIAGMKP2) != 0)
                    return _dONGIAGMKP2.ToString("###,##0.##");
                else
                    return _dONGIAGMKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIAGMKP2", true);
                if (_dONGIAGMKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMKP2 = 0;
                    else
                        _dONGIAGMKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMKP2");
                }
			}
		}
		
		public String DONGIATMDBAP1
		{
			get 
			{
				CanReadProperty("DONGIATMDBAP1", true);
                if (_dONGIATMDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBAP1 - (int)(_dONGIATMDBAP1) != 0)
                    return _dONGIATMDBAP1.ToString("###,##0.##");
                else
                    return _dONGIATMDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBAP1", true);
                if (_dONGIATMDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBAP1 = 0;
                    else
                        _dONGIATMDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBAP1");
                }
			}
		}
		
		public String DONGIATMDBAP2
		{
			get 
			{
				CanReadProperty("DONGIATMDBAP2", true);
                if (_dONGIATMDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBAP2 - (int)(_dONGIATMDBAP2) != 0)
                    return _dONGIATMDBAP2.ToString("###,##0.##");
                else
                    return _dONGIATMDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBAP2", true);
                if (_dONGIATMDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBAP2 = 0;
                    else
                        _dONGIATMDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBAP2");
                }
			}
		}
		
		public String DONGIATMDBBC
		{
			get 
			{
				CanReadProperty("DONGIATMDBBC", true);
                if (_dONGIATMDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBBC - (int)(_dONGIATMDBBC) != 0)
                    return _dONGIATMDBBC.ToString("###,##0.##");
                else
                    return _dONGIATMDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBBC", true);
                if (_dONGIATMDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBBC = 0;
                    else
                        _dONGIATMDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBBC");
                }
			}
		}
		
		public String DONGIATMDBBP1
		{
			get 
			{
				CanReadProperty("DONGIATMDBBP1", true);
                if (_dONGIATMDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBBP1 - (int)(_dONGIATMDBBP1) != 0)
                    return _dONGIATMDBBP1.ToString("###,##0.##");
                else
                    return _dONGIATMDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBBP1", true);
                if (_dONGIATMDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBBP1 = 0;
                    else
                        _dONGIATMDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBBP1");
                }
			}
		}
		
		public String DONGIATMDBBP2
		{
			get 
			{
				CanReadProperty("DONGIATMDBBP2", true);
                if (_dONGIATMDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBBP2 - (int)(_dONGIATMDBBP2) != 0)
                    return _dONGIATMDBBP2.ToString("###,##0.##");
                else
                    return _dONGIATMDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBBP2", true);
                if (_dONGIATMDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBBP2 = 0;
                    else
                        _dONGIATMDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBBP2");
                }
			}
		}
		
		public String DONGIATMDBCC
		{
			get 
			{
				CanReadProperty("DONGIATMDBCC", true);
                if (_dONGIATMDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBCC - (int)(_dONGIATMDBCC) != 0)
                    return _dONGIATMDBCC.ToString("###,##0.##");
                else
                    return _dONGIATMDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBCC", true);
                if (_dONGIATMDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBCC = 0;
                    else
                        _dONGIATMDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBCC");
                }
			}
		}
		
		public String DONGIATMDBCP1
		{
			get 
			{
				CanReadProperty("DONGIATMDBCP1", true);
                if (_dONGIATMDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBCP1 - (int)(_dONGIATMDBCP1) != 0)
                    return _dONGIATMDBCP1.ToString("###,##0.##");
                else
                    return _dONGIATMDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBCP1", true);
                if (_dONGIATMDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBCP1 = 0;
                    else
                        _dONGIATMDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBCP1");
                }
			}
		}
		
		public String DONGIATMDBCP2
		{
			get 
			{
				CanReadProperty("DONGIATMDBCP2", true);
                if (_dONGIATMDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBCP2 - (int)(_dONGIATMDBCP2) != 0)
                    return _dONGIATMDBCP2.ToString("###,##0.##");
                else
                    return _dONGIATMDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBCP2", true);
                if (_dONGIATMDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBCP2 = 0;
                    else
                        _dONGIATMDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBCP2");
                }
			}
		}
		
		public String DONGIATMIC
		{
			get 
			{
				CanReadProperty("DONGIATMIC", true);
                if (_dONGIATMIC == 0)
                {
                    return "";
                }

                else if (_dONGIATMIC - (int)(_dONGIATMIC) != 0)
                    return _dONGIATMIC.ToString("###,##0.##");
                else
                    return _dONGIATMIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMIC", true);
                if (_dONGIATMIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMIC = 0;
                    else
                        _dONGIATMIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMIC");
                }
			}
		}
		
		public String DONGIATMDB1P1
		{
			get 
			{
				CanReadProperty("DONGIATMDB1P1", true);
                if (_dONGIATMDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDB1P1 - (int)(_dONGIATMDB1P1) != 0)
                    return _dONGIATMDB1P1.ToString("###,##0.##");
                else
                    return _dONGIATMDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDB1P1", true);
                if (_dONGIATMDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDB1P1 = 0;
                    else
                        _dONGIATMDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDB1P1");
                }
			}
		}
		
		public String DONGIATMKC
		{
			get 
			{
				CanReadProperty("DONGIATMKC", true);
                if (_dONGIATMKC == 0)
                {
                    return "";
                }

                else if (_dONGIATMKC - (int)(_dONGIATMKC) != 0)
                    return _dONGIATMKC.ToString("###,##0.##");
                else
                    return _dONGIATMKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMKC", true);
                if (_dONGIATMKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMKC = 0;
                    else
                        _dONGIATMKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMKC");
                }
			}
		}
		
		public String DONGIATMKP1
		{
			get 
			{
				CanReadProperty("DONGIATMKP1", true);
                if (_dONGIATMKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMKP1 - (int)(_dONGIATMKP1) != 0)
                    return _dONGIATMKP1.ToString("###,##0.##");
                else
                    return _dONGIATMKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMKP1", true);
                if (_dONGIATMKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMKP1 = 0;
                    else
                        _dONGIATMKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMKP1");
                }
			}
		}
		
		public String DONGIATMDBAC
		{
			get 
			{
				CanReadProperty("DONGIATMDBAC", true);
                if (_dONGIATMDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDBAC - (int)(_dONGIATMDBAC) != 0)
                    return _dONGIATMDBAC.ToString("###,##0.##");
                else
                    return _dONGIATMDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDBAC", true);
                if (_dONGIATMDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDBAC = 0;
                    else
                        _dONGIATMDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDBAC");
                }
			}
		}
		
		public String DONGIATMDCDBAP1
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBAP1", true);
                if (_dONGIATMDCDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBAP1 - (int)(_dONGIATMDCDBAP1) != 0)
                    return _dONGIATMDCDBAP1.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBAP1", true);
                if (_dONGIATMDCDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBAP1 = 0;
                    else
                        _dONGIATMDCDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBAP1");
                }
			}
		}
		
		public String DONGIATMDCDBAP2
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBAP2", true);
                if (_dONGIATMDCDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBAP2 - (int)(_dONGIATMDCDBAP2) != 0)
                    return _dONGIATMDCDBAP2.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBAP2", true);
                if (_dONGIATMDCDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBAP2 = 0;
                    else
                        _dONGIATMDCDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBAP2");
                }
			}
		}
		
		public String DONGIATMDCDBBC
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBBC", true);
                if (_dONGIATMDCDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBBC - (int)(_dONGIATMDCDBBC) != 0)
                    return _dONGIATMDCDBBC.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBBC", true);
                if (_dONGIATMDCDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBBC = 0;
                    else
                        _dONGIATMDCDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBBC");
                }
			}
		}
		
		public String DONGIATMDCDBBP1
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBBP1", true);
                if (_dONGIATMDCDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBBP1 - (int)(_dONGIATMDCDBBP1) != 0)
                    return _dONGIATMDCDBBP1.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBBP1", true);
                if (_dONGIATMDCDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBBP1 = 0;
                    else
                        _dONGIATMDCDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBBP1");
                }
			}
		}
		
		public String DONGIATMDCDBBP2
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBBP2", true);
                if (_dONGIATMDCDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBBP2 - (int)(_dONGIATMDCDBBP2) != 0)
                    return _dONGIATMDCDBBP2.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBBP2", true);
                if (_dONGIATMDCDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBBP2 = 0;
                    else
                        _dONGIATMDCDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBBP2");
                }
			}
		}
		
		public String DONGIATMDCDBCC
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBCC", true);
                if (_dONGIATMDCDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBCC - (int)(_dONGIATMDCDBCC) != 0)
                    return _dONGIATMDCDBCC.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBCC", true);
                if (_dONGIATMDCDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBCC = 0;
                    else
                        _dONGIATMDCDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBCC");
                }
			}
		}
		
		public String DONGIATMDCDBCP1
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBCP1", true);
                if (_dONGIATMDCDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBCP1 - (int)(_dONGIATMDCDBCP1) != 0)
                    return _dONGIATMDCDBCP1.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBCP1", true);
                if (_dONGIATMDCDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBCP1 = 0;
                    else
                        _dONGIATMDCDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBCP1");
                }
			}
		}
		
		public String DONGIATMDCDBCP2
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBCP2", true);
                if (_dONGIATMDCDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBCP2 - (int)(_dONGIATMDCDBCP2) != 0)
                    return _dONGIATMDCDBCP2.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBCP2", true);
                if (_dONGIATMDCDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBCP2 = 0;
                    else
                        _dONGIATMDCDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBCP2");
                }
			}
		}
		
		public String DONGIATMDCIC
		{
			get 
			{
				CanReadProperty("DONGIATMDCIC", true);
                if (_dONGIATMDCIC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCIC - (int)(_dONGIATMDCIC) != 0)
                    return _dONGIATMDCIC.ToString("###,##0.##");
                else
                    return _dONGIATMDCIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCIC", true);
                if (_dONGIATMDCIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCIC = 0;
                    else
                        _dONGIATMDCIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCIC");
                }
			}
		}
		
		public String DONGIATMDCDB1P1
		{
			get 
			{
				CanReadProperty("DONGIATMDCDB1P1", true);
                if (_dONGIATMDCDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDB1P1 - (int)(_dONGIATMDCDB1P1) != 0)
                    return _dONGIATMDCDB1P1.ToString("###,##0.##");
                else
                    return _dONGIATMDCDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDB1P1", true);
                if (_dONGIATMDCDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDB1P1 = 0;
                    else
                        _dONGIATMDCDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDB1P1");
                }
			}
		}
		
		public String DONGIATMDCKC
		{
			get 
			{
				CanReadProperty("DONGIATMDCKC", true);
                if (_dONGIATMDCKC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCKC - (int)(_dONGIATMDCKC) != 0)
                    return _dONGIATMDCKC.ToString("###,##0.##");
                else
                    return _dONGIATMDCKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCKC", true);
                if (_dONGIATMDCKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCKC = 0;
                    else
                        _dONGIATMDCKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCKC");
                }
			}
		}
		
		public String DONGIATMDCKP1
		{
			get 
			{
				CanReadProperty("DONGIATMDCKP1", true);
                if (_dONGIATMDCKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCKP1 - (int)(_dONGIATMDCKP1) != 0)
                    return _dONGIATMDCKP1.ToString("###,##0.##");
                else
                    return _dONGIATMDCKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCKP1", true);
                if (_dONGIATMDCKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCKP1 = 0;
                    else
                        _dONGIATMDCKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCKP1");
                }
			}
		}
		
		public String DONGIATMDCDBAC
		{
			get 
			{
				CanReadProperty("DONGIATMDCDBAC", true);
                if (_dONGIATMDCDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDBAC - (int)(_dONGIATMDCDBAC) != 0)
                    return _dONGIATMDCDBAC.ToString("###,##0.##");
                else
                    return _dONGIATMDCDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDBAC", true);
                if (_dONGIATMDCDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDBAC = 0;
                    else
                        _dONGIATMDCDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDBAC");
                }
			}
		}
		
		public String DONGIATMGMDBAP1
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBAP1", true);
                if (_dONGIATMGMDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBAP1 - (int)(_dONGIATMGMDBAP1) != 0)
                    return _dONGIATMGMDBAP1.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBAP1", true);
                if (_dONGIATMGMDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBAP1 = 0;
                    else
                        _dONGIATMGMDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBAP1");
                }
			}
		}
		
		public String DONGIATMGMDBAP2
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBAP2", true);
                if (_dONGIATMGMDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBAP2 - (int)(_dONGIATMGMDBAP2) != 0)
                    return _dONGIATMGMDBAP2.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBAP2", true);
                if (_dONGIATMGMDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBAP2 = 0;
                    else
                        _dONGIATMGMDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBAP2");
                }
			}
		}
		
		public String DONGIATMGMDBBC
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBBC", true);
                if (_dONGIATMGMDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBBC - (int)(_dONGIATMGMDBBC) != 0)
                    return _dONGIATMGMDBBC.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBBC", true);
                if (_dONGIATMGMDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBBC = 0;
                    else
                        _dONGIATMGMDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBBC");
                }
			}
		}
		
		public String DONGIATMGMDBBP1
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBBP1", true);
                if (_dONGIATMGMDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBBP1 - (int)(_dONGIATMGMDBBP1) != 0)
                    return _dONGIATMGMDBBP1.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBBP1", true);
                if (_dONGIATMGMDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBBP1 = 0;
                    else
                        _dONGIATMGMDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBBP1");
                }
			}
		}
		
		public String DONGIATMGMDBBP2
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBBP2", true);
                if (_dONGIATMGMDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBBP2 - (int)(_dONGIATMGMDBBP2) != 0)
                    return _dONGIATMGMDBBP2.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBBP2", true);
                if (_dONGIATMGMDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBBP2 = 0;
                    else
                        _dONGIATMGMDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBBP2");
                }
			}
		}
		
		public String DONGIATMGMDBCC
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBCC", true);
                if (_dONGIATMGMDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBCC - (int)(_dONGIATMGMDBCC) != 0)
                    return _dONGIATMGMDBCC.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBCC", true);
                if (_dONGIATMGMDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBCC = 0;
                    else
                        _dONGIATMGMDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBCC");
                }
			}
		}
		
		public String DONGIATMGMDBCP1
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBCP1", true);
                if (_dONGIATMGMDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBCP1 - (int)(_dONGIATMGMDBCP1) != 0)
                    return _dONGIATMGMDBCP1.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBCP1", true);
                if (_dONGIATMGMDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBCP1 = 0;
                    else
                        _dONGIATMGMDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBCP1");
                }
			}
		}
		
		public String DONGIATMGMDBCP2
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBCP2", true);
                if (_dONGIATMGMDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBCP2 - (int)(_dONGIATMGMDBCP2) != 0)
                    return _dONGIATMGMDBCP2.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBCP2", true);
                if (_dONGIATMGMDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBCP2 = 0;
                    else
                        _dONGIATMGMDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBCP2");
                }
			}
		}
		
		public String DONGIATMGMIC
		{
			get 
			{
				CanReadProperty("DONGIATMGMIC", true);
                if (_dONGIATMGMIC == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMIC - (int)(_dONGIATMGMIC) != 0)
                    return _dONGIATMGMIC.ToString("###,##0.##");
                else
                    return _dONGIATMGMIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMIC", true);
                if (_dONGIATMGMIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMIC = 0;
                    else
                        _dONGIATMGMIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMIC");
                }
			}
		}
		
		public String DONGIATMGMDB1P1
		{
			get 
			{
				CanReadProperty("DONGIATMGMDB1P1", true);
                if (_dONGIATMGMDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDB1P1 - (int)(_dONGIATMGMDB1P1) != 0)
                    return _dONGIATMGMDB1P1.ToString("###,##0.##");
                else
                    return _dONGIATMGMDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDB1P1", true);
                if (_dONGIATMGMDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDB1P1 = 0;
                    else
                        _dONGIATMGMDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDB1P1");
                }
			}
		}
		
		public String DONGIATMGMKC
		{
			get 
			{
				CanReadProperty("DONGIATMGMKC", true);
                if (_dONGIATMGMKC == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMKC - (int)(_dONGIATMGMKC) != 0)
                    return _dONGIATMGMKC.ToString("###,##0.##");
                else
                    return _dONGIATMGMKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMKC", true);
                if (_dONGIATMGMKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMKC = 0;
                    else
                        _dONGIATMGMKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMKC");
                }
			}
		}
		
		public String DONGIATMGMKP1
		{
			get 
			{
				CanReadProperty("DONGIATMGMKP1", true);
                if (_dONGIATMGMKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMKP1 - (int)(_dONGIATMGMKP1) != 0)
                    return _dONGIATMGMKP1.ToString("###,##0.##");
                else
                    return _dONGIATMGMKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMKP1", true);
                if (_dONGIATMGMKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMKP1 = 0;
                    else
                        _dONGIATMGMKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMKP1");
                }
			}
		}
		
		public String DONGIATMGMDBAC
		{
			get 
			{
				CanReadProperty("DONGIATMGMDBAC", true);
                if (_dONGIATMGMDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDBAC - (int)(_dONGIATMGMDBAC) != 0)
                    return _dONGIATMGMDBAC.ToString("###,##0.##");
                else
                    return _dONGIATMGMDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDBAC", true);
                if (_dONGIATMGMDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDBAC = 0;
                    else
                        _dONGIATMGMDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDBAC");
                }
			}
		}
		
		public String DONGIATMCECDBAP1
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBAP1", true);
                if (_dONGIATMCECDBAP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBAP1 - (int)(_dONGIATMCECDBAP1) != 0)
                    return _dONGIATMCECDBAP1.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBAP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBAP1", true);
                if (_dONGIATMCECDBAP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBAP1 = 0;
                    else
                        _dONGIATMCECDBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBAP1");
                }
			}
		}
		
		public String DONGIATMCECDBAP2
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBAP2", true);
                if (_dONGIATMCECDBAP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBAP2 - (int)(_dONGIATMCECDBAP2) != 0)
                    return _dONGIATMCECDBAP2.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBAP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBAP2", true);
                if (_dONGIATMCECDBAP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBAP2 = 0;
                    else
                        _dONGIATMCECDBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBAP2");
                }
			}
		}
		
		public String DONGIATMCECDBBC
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBBC", true);
                if (_dONGIATMCECDBBC == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBBC - (int)(_dONGIATMCECDBBC) != 0)
                    return _dONGIATMCECDBBC.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBBC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBBC", true);
                if (_dONGIATMCECDBBC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBBC = 0;
                    else
                        _dONGIATMCECDBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBBC");
                }
			}
		}
		
		public String DONGIATMCECDBBP1
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBBP1", true);
                if (_dONGIATMCECDBBP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBBP1 - (int)(_dONGIATMCECDBBP1) != 0)
                    return _dONGIATMCECDBBP1.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBBP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBBP1", true);
                if (_dONGIATMCECDBBP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBBP1 = 0;
                    else
                        _dONGIATMCECDBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBBP1");
                }
			}
		}
		
		public String DONGIATMCECDBBP2
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBBP2", true);
                if (_dONGIATMCECDBBP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBBP2 - (int)(_dONGIATMCECDBBP2) != 0)
                    return _dONGIATMCECDBBP2.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBBP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBBP2", true);
                if (_dONGIATMCECDBBP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBBP2 = 0;
                    else
                        _dONGIATMCECDBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBBP2");
                }
			}
		}
		
		public String DONGIATMCECDBCC
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBCC", true);
                if (_dONGIATMCECDBCC == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBCC - (int)(_dONGIATMCECDBCC) != 0)
                    return _dONGIATMCECDBCC.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBCC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBCC", true);
                if (_dONGIATMCECDBCC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBCC = 0;
                    else
                        _dONGIATMCECDBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBCC");
                }
			}
		}
		
		public String DONGIATMCECDBCP1
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBCP1", true);
                if (_dONGIATMCECDBCP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBCP1 - (int)(_dONGIATMCECDBCP1) != 0)
                    return _dONGIATMCECDBCP1.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBCP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBCP1", true);
                if (_dONGIATMCECDBCP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBCP1 = 0;
                    else
                        _dONGIATMCECDBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBCP1");
                }
			}
		}
		
		public String DONGIATMCECDBCP2
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBCP2", true);
                if (_dONGIATMCECDBCP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBCP2 - (int)(_dONGIATMCECDBCP2) != 0)
                    return _dONGIATMCECDBCP2.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBCP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBCP2", true);
                if (_dONGIATMCECDBCP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBCP2 = 0;
                    else
                        _dONGIATMCECDBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBCP2");
                }
			}
		}
		
		public String DONGIATMCECIC
		{
			get 
			{
				CanReadProperty("DONGIATMCECIC", true);
                if (_dONGIATMCECIC == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECIC - (int)(_dONGIATMCECIC) != 0)
                    return _dONGIATMCECIC.ToString("###,##0.##");
                else
                    return _dONGIATMCECIC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECIC", true);
                if (_dONGIATMCECIC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECIC = 0;
                    else
                        _dONGIATMCECIC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECIC");
                }
			}
		}
		
		public String DONGIATMCECDB1P1
		{
			get 
			{
				CanReadProperty("DONGIATMCECDB1P1", true);
                if (_dONGIATMCECDB1P1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDB1P1 - (int)(_dONGIATMCECDB1P1) != 0)
                    return _dONGIATMCECDB1P1.ToString("###,##0.##");
                else
                    return _dONGIATMCECDB1P1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDB1P1", true);
                if (_dONGIATMCECDB1P1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDB1P1 = 0;
                    else
                        _dONGIATMCECDB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDB1P1");
                }
			}
		}
		
		public String DONGIATMCECKC
		{
			get 
			{
				CanReadProperty("DONGIATMCECKC", true);
                if (_dONGIATMCECKC == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECKC - (int)(_dONGIATMCECKC) != 0)
                    return _dONGIATMCECKC.ToString("###,##0.##");
                else
                    return _dONGIATMCECKC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECKC", true);
                if (_dONGIATMCECKC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECKC = 0;
                    else
                        _dONGIATMCECKC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECKC");
                }
			}
		}
		
		public String DONGIATMCECKP1
		{
			get 
			{
				CanReadProperty("DONGIATMCECKP1", true);
                if (_dONGIATMCECKP1 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECKP1 - (int)(_dONGIATMCECKP1) != 0)
                    return _dONGIATMCECKP1.ToString("###,##0.##");
                else
                    return _dONGIATMCECKP1.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECKP1", true);
                if (_dONGIATMCECKP1.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECKP1 = 0;
                    else
                        _dONGIATMCECKP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECKP1");
                }
			}
		}
		
		public String DONGIATMCECDBAC
		{
			get 
			{
				CanReadProperty("DONGIATMCECDBAC", true);
                if (_dONGIATMCECDBAC == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDBAC - (int)(_dONGIATMCECDBAC) != 0)
                    return _dONGIATMCECDBAC.ToString("###,##0.##");
                else
                    return _dONGIATMCECDBAC.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDBAC", true);
                if (_dONGIATMCECDBAC.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDBAC = 0;
                    else
                        _dONGIATMCECDBAC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECDBAC");
                }
			}
		}
		
		public String DONGIATMDB1P2
		{
			get 
			{
				CanReadProperty("DONGIATMDB1P2", true);
                if (_dONGIATMDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDB1P2 - (int)(_dONGIATMDB1P2) != 0)
                    return _dONGIATMDB1P2.ToString("###,##0.##");
                else
                    return _dONGIATMDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDB1P2", true);
                if (_dONGIATMDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDB1P2 = 0;
                    else
                        _dONGIATMDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDB1P2");
                }
			}
		}
		
		public String DONGIATMKP2
		{
			get 
			{
				CanReadProperty("DONGIATMKP2", true);
                if (_dONGIATMKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMKP2 - (int)(_dONGIATMKP2) != 0)
                    return _dONGIATMKP2.ToString("###,##0.##");
                else
                    return _dONGIATMKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMKP2", true);
                if (_dONGIATMKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMKP2 = 0;
                    else
                        _dONGIATMKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMKP2");
                }
			}
		}
		
		public String DONGIATMDCDB1P2
		{
			get 
			{
				CanReadProperty("DONGIATMDCDB1P2", true);
                if (_dONGIATMDCDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCDB1P2 - (int)(_dONGIATMDCDB1P2) != 0)
                    return _dONGIATMDCDB1P2.ToString("###,##0.##");
                else
                    return _dONGIATMDCDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCDB1P2", true);
                if (_dONGIATMDCDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCDB1P2 = 0;
                    else
                        _dONGIATMDCDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMDCDB1P2");
                }
			}
		}
		
		public String DONGIATMDCKP2
		{
			get 
			{
				CanReadProperty("DONGIATMDCKP2", true);
                if (_dONGIATMDCKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMDCKP2 - (int)(_dONGIATMDCKP2) != 0)
                    return _dONGIATMDCKP2.ToString("###,##0.##");
                else
                    return _dONGIATMDCKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMDCKP2", true);
                if (_dONGIATMDCKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMDCKP2 = 0;
                    else
                        _dONGIATMDCKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIATMCECDB1P2
		{
			get 
			{
				CanReadProperty("DONGIATMCECDB1P2", true);
                if (_dONGIATMCECDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECDB1P2 - (int)(_dONGIATMCECDB1P2) != 0)
                    return _dONGIATMCECDB1P2.ToString("###,##0.##");
                else
                    return _dONGIATMCECDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECDB1P2", true);
                if (_dONGIATMCECDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECDB1P2 = 0;
                    else
                        _dONGIATMCECDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
			}
		}
		
		public String DONGIATMCECKP2
		{
			get 
			{
				CanReadProperty("DONGIATMCECKP2", true);
                if (_dONGIATMCECKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMCECKP2 - (int)(_dONGIATMCECKP2) != 0)
                    return _dONGIATMCECKP2.ToString("###,##0.##");
                else
                    return _dONGIATMCECKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMCECKP2", true);
                if (_dONGIATMCECKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMCECKP2 = 0;
                    else
                        _dONGIATMCECKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMCECKP2");
                }
			}
		}
		
		public String DONGIATMGMDB1P2
		{
			get 
			{
				CanReadProperty("DONGIATMGMDB1P2", true);
                if (_dONGIATMGMDB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMDB1P2 - (int)(_dONGIATMGMDB1P2) != 0)
                    return _dONGIATMGMDB1P2.ToString("###,##0.##");
                else
                    return _dONGIATMGMDB1P2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMDB1P2", true);
                if (_dONGIATMGMDB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMDB1P2 = 0;
                    else
                        _dONGIATMGMDB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMDB1P2");
                }
			}
		}
		
		public String DONGIATMGMKP2
		{
			get 
			{
				CanReadProperty("DONGIATMGMKP2", true);
                if (_dONGIATMGMKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIATMGMKP2 - (int)(_dONGIATMGMKP2) != 0)
                    return _dONGIATMGMKP2.ToString("###,##0.##");
                else
                    return _dONGIATMGMKP2.ToString("###,###");
            }
			set 
			{
				CanWriteProperty("DONGIATMGMKP2", true);
                if (_dONGIATMGMKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIATMGMKP2 = 0;
                    else
                        _dONGIATMGMKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIATMGMKP2");
                }
			}
		}


        public String DONGIADB1P2
        {
            get
            {
                CanReadProperty("DONGIADB1P2", true);
                if (_dONGIADB1P2 == 0)
                {
                    return "";
                }

                else if (_dONGIADB1P2 - (int)(_dONGIADB1P2) != 0)
                    return _dONGIADB1P2.ToString("###,##0.##");
                else
                    return _dONGIADB1P2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DONGIADB1P2", true);
                if (_dONGIADB1P2.ToString() != value)
                {
                    if (value == "")
                        _dONGIADB1P2 = 0;
                    else
                        _dONGIADB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIADB1P2");
                }
            }
        }

        public String DONGIAKP2
        {
            get
            {
                CanReadProperty("DONGIAKP2", true);
                if (_dONGIAKP2 == 0)
                {
                    return "";
                }

                else if (_dONGIAKP2 - (int)(_dONGIAKP2) != 0)
                    return _dONGIAKP2.ToString("###,##0.##");
                else
                    return _dONGIAKP2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DONGIAKP2", true);
                if (_dONGIAKP2.ToString() != value)
                {
                    if (value == "")
                        _dONGIAKP2 = 0;
                    else
                        _dONGIAKP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAKP2");
                }
            }
        }

        public String DONGIAGMTE
        {
            get
            {
                CanReadProperty("DONGIAGMTE", true);
                if (_dONGIAGMTE  == 0)
                {
                    return "";
                }

                else if (_dONGIAGMTE - (int)(_dONGIAGMTE) != 0)
                    return _dONGIAGMTE.ToString("###,##0.##");
                else
                    return _dONGIAGMTE.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DONGIAGMTE", true);
                if (_dONGIAGMTE.ToString() != value)
                {
                    if (value == "")
                        _dONGIAGMTE = 0;
                    else
                        _dONGIAGMTE = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAGMTE");
                }
            }
        }

		public Boolean Huy
		{
			get 
			{
				CanReadProperty("Huy", true);
				return _huy;
			}
			set 
			{
				CanWriteProperty("Huy", true);
				if (_huy != value) 
				{
					_huy = value;
					PropertyHasChanged("Huy");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
				return _ngaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD.Text != value) 
				{
					_ngaySD.Text = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
		
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
				return _nguoiSD;
			}
			set 
			{
				CanWriteProperty("NguoiSD", true);
				if (_nguoiSD != value) 
				{
					_nguoiSD = value;
					PropertyHasChanged("NguoiSD");
				}
			}
		}
		
		public String MaMay
		{
			get 
			{
				CanReadProperty("MaMay", true);
				return _maMay;
			}
			set 
			{
				CanWriteProperty("MaMay", true);
				if (_maMay != value) 
				{
					_maMay = value;
					PropertyHasChanged("MaMay");
				}
			}
		}
		
		protected override Object GetIdValue()
		{
			return _mucLuongCB;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThamSoLuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
		public static ThamSoLuong GetThamSoLuong()
		{
			return DataPortal.Fetch<ThamSoLuong>();
		}
		
		
		
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThamSoLuong()
		{	
			// Prevent direct creation
		}
		
		#endregion

		#region Criteria
         	
		
		 
		#endregion
		
		#region Authorization

		public static bool CanGetObject()
		{
			return true;
		}
		
		public static bool CanDeleteObject()
		{
			return true;
		}

		public static bool CanAddObject()
		{
			return true;
		}

		public static bool CanEditObject()
		{
			return true;
		}
		
		#endregion

		#region Data Access

		/// <summary>
		/// Retrieve an existing <see cref="ThamSoLuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch()
		{
			// public abstract IDataReader GetThamSoLuong();
			// public override IDataReader GetThamSoLuong()
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spThamSoLuong_GET"));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThamSoLuong()))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="ThamSoLuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
			if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
			if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
			if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
			if (dr.GetDecimal("HeSoThamNien") != null) _heSoThamNien = dr.GetDecimal("HeSoThamNien");
			if (dr.GetDecimal("DonGiaTruc") != null) _donGiaTruc = dr.GetDecimal("DonGiaTruc");
			if (dr.GetDecimal("DonGiaXQuang") != null) _donGiaXQuang = dr.GetDecimal("DonGiaXQuang");
			if (dr.GetDecimal("DonGiaM2") != null) _donGiaM2 = dr.GetDecimal("DonGiaM2");
			if (dr.GetDecimal("DonGiaNTHSCC") != null) _donGiaNTHSCC = dr.GetDecimal("DonGiaNTHSCC");
			if (dr.GetDecimal("DonGiaNNHSCC") != null) _donGiaNNHSCC = dr.GetDecimal("DonGiaNNHSCC");
			if (dr.GetDecimal("DonGiaNLHSCC") != null) _donGiaNLHSCC = dr.GetDecimal("DonGiaNLHSCC");
			if (dr.GetDecimal("DonGiaQCCTNBHSCC") != null) _donGiaQCCTNBHSCC = dr.GetDecimal("DonGiaQCCTNBHSCC");
			if (dr.GetDecimal("DonGiaND1142002HSCC") != null) _donGiaND1142002HSCC = dr.GetDecimal("DonGiaND1142002HSCC");
			if (dr.GetDecimal("DonGiaNTCM") != null) _donGiaNTCM = dr.GetDecimal("DonGiaNTCM");
			if (dr.GetDecimal("DonGiaNNCM") != null) _donGiaNNCM = dr.GetDecimal("DonGiaNNCM");
			if (dr.GetDecimal("DonGiaNLCM") != null) _donGiaNLCM = dr.GetDecimal("DonGiaNLCM");
			if (dr.GetDecimal("DonGiaQCCTNBCM") != null) _donGiaQCCTNBCM = dr.GetDecimal("DonGiaQCCTNBCM");
			if (dr.GetDecimal("DonGiaNTLD") != null) _donGiaNTLD = dr.GetDecimal("DonGiaNTLD");
			if (dr.GetDecimal("DonGiaNNLD") != null) _donGiaNNLD = dr.GetDecimal("DonGiaNNLD");
			if (dr.GetDecimal("DonGiaNLLD") != null) _donGiaNLLD = dr.GetDecimal("DonGiaNLLD");
			if (dr.GetDecimal("DonGiaCocIHSCC") != null) _donGiaCocIHSCC = dr.GetDecimal("DonGiaCocIHSCC");
			if (dr.GetDecimal("DonGiaCocIIHSCC") != null) _donGiaCocIIHSCC = dr.GetDecimal("DonGiaCocIIHSCC");
			if (dr.GetDecimal("DonGiaDDHSCC") != null) _donGiaDDHSCC = dr.GetDecimal("DonGiaDDHSCC");
			if (dr.GetDecimal("DonGiaCocICM") != null) _donGiaCocICM = dr.GetDecimal("DonGiaCocICM");
			if (dr.GetDecimal("DonGiaCocIICM") != null) _donGiaCocIICM = dr.GetDecimal("DonGiaCocIICM");
			if (dr.GetDecimal("DonGiaDDCM") != null) _donGiaDDCM = dr.GetDecimal("DonGiaDDCM");
			if (dr.GetDecimal("DONGIADBAP1") != null) _dONGIADBAP1 = dr.GetDecimal("DONGIADBAP1");
			if (dr.GetDecimal("DONGIADBAP2") != null) _dONGIADBAP2 = dr.GetDecimal("DONGIADBAP2");
			if (dr.GetDecimal("DONGIADBBC") != null) _dONGIADBBC = dr.GetDecimal("DONGIADBBC");
			if (dr.GetDecimal("DONGIADBBP1") != null) _dONGIADBBP1 = dr.GetDecimal("DONGIADBBP1");
			if (dr.GetDecimal("DONGIADBBP2") != null) _dONGIADBBP2 = dr.GetDecimal("DONGIADBBP2");
			if (dr.GetDecimal("DONGIADBCC") != null) _dONGIADBCC = dr.GetDecimal("DONGIADBCC");
			if (dr.GetDecimal("DONGIADBCP1") != null) _dONGIADBCP1 = dr.GetDecimal("DONGIADBCP1");
			if (dr.GetDecimal("DONGIADBCP2") != null) _dONGIADBCP2 = dr.GetDecimal("DONGIADBCP2");
			if (dr.GetDecimal("DONGIAIC") != null) _dONGIAIC = dr.GetDecimal("DONGIAIC");
			if (dr.GetDecimal("DONGIADB1P1") != null) _dONGIADB1P1 = dr.GetDecimal("DONGIADB1P1");
			if (dr.GetDecimal("DONGIAKC") != null) _dONGIAKC = dr.GetDecimal("DONGIAKC");
			if (dr.GetDecimal("DONGIAKP1") != null) _dONGIAKP1 = dr.GetDecimal("DONGIAKP1");
			if (dr.GetDecimal("DONGIANgoaiVien") != null) _dONGIANgoaiVien = dr.GetDecimal("DONGIANgoaiVien");
			if (dr.GetDecimal("DONGIAChuTri") != null) _dONGIAChuTri = dr.GetDecimal("DONGIAChuTri");
			if (dr.GetDecimal("DONGIAThuKy") != null) _dONGIAThuKy = dr.GetDecimal("DONGIAThuKy");
			if (dr.GetDecimal("DONGIABacSy") != null) _dONGIABacSy = dr.GetDecimal("DONGIABacSy");
			if (dr.GetDecimal("DONGIADD") != null) _dONGIADD = dr.GetDecimal("DONGIADD");
			if (dr.GetDecimal("DONGIANVien") != null) _dONGIANVien = dr.GetDecimal("DONGIANVien");
			if (dr.GetDecimal("DONGIADBBS") != null) _dONGIADBBS = dr.GetDecimal("DONGIADBBS");
			if (dr.GetDecimal("DONGIADBDD") != null) _dONGIADBDD = dr.GetDecimal("DONGIADBDD");
			if (dr.GetDecimal("DONGIAIBS") != null) _dONGIAIBS = dr.GetDecimal("DONGIAIBS");
			if (dr.GetDecimal("DONGIAIDD") != null) _dONGIAIDD = dr.GetDecimal("DONGIAIDD");
			if (dr.GetDecimal("DONGIAIIBS") != null) _dONGIAIIBS = dr.GetDecimal("DONGIAIIBS");
			if (dr.GetDecimal("DONGIAIIDD") != null) _dONGIAIIDD = dr.GetDecimal("DONGIAIIDD");
			if (dr.GetDecimal("DONGIAIIIBS") != null) _dONGIAIIIBS = dr.GetDecimal("DONGIAIIIBS");
			if (dr.GetDecimal("DONGIAIIIDD") != null) _dONGIAIIIDD = dr.GetDecimal("DONGIAIIIDD");
			if (dr.GetDecimal("HeSoPTHS") != null) _heSoPTHS = dr.GetDecimal("HeSoPTHS");
			if (dr.GetDecimal("DONGIAA") != null) _dONGIAA = dr.GetDecimal("DONGIAA");
			if (dr.GetDecimal("DONGIAB") != null) _dONGIAB = dr.GetDecimal("DONGIAB");
			if (dr.GetDecimal("DONGIAC") != null) _dONGIAC = dr.GetDecimal("DONGIAC");
			if (dr.GetDecimal("MucTTThue") != null) _mucTTThue = dr.GetDecimal("MucTTThue");
			if (dr.GetDecimal("HeSoLamDem") != null) _heSoLamDem = dr.GetDecimal("HeSoLamDem");
			if (dr.GetDecimal("HeSoNgoaiGio") != null) _heSoNgoaiGio = dr.GetDecimal("HeSoNgoaiGio");
			if (dr.GetDecimal("HeSoNgoaiGio7") != null) _heSoNgoaiGio7 = dr.GetDecimal("HeSoNgoaiGio7");
			if (dr.GetDecimal("HeSoNgoaiGioLe") != null) _heSoNgoaiGioLe = dr.GetDecimal("HeSoNgoaiGioLe");
			if (dr.GetDecimal("DONGIADBAC") != null) _dONGIADBAC = dr.GetDecimal("DONGIADBAC");
			if (dr.GetDecimal("DONGIADCDBAP1") != null) _dONGIADCDBAP1 = dr.GetDecimal("DONGIADCDBAP1");
			if (dr.GetDecimal("DONGIADCDBAP2") != null) _dONGIADCDBAP2 = dr.GetDecimal("DONGIADCDBAP2");
			if (dr.GetDecimal("DONGIADCDBBC") != null) _dONGIADCDBBC = dr.GetDecimal("DONGIADCDBBC");
			if (dr.GetDecimal("DONGIADCDBBP1") != null) _dONGIADCDBBP1 = dr.GetDecimal("DONGIADCDBBP1");
			if (dr.GetDecimal("DONGIADCDBBP2") != null) _dONGIADCDBBP2 = dr.GetDecimal("DONGIADCDBBP2");
			if (dr.GetDecimal("DONGIADCDBCC") != null) _dONGIADCDBCC = dr.GetDecimal("DONGIADCDBCC");
			if (dr.GetDecimal("DONGIADCDBCP1") != null) _dONGIADCDBCP1 = dr.GetDecimal("DONGIADCDBCP1");
			if (dr.GetDecimal("DONGIADCDBCP2") != null) _dONGIADCDBCP2 = dr.GetDecimal("DONGIADCDBCP2");
			if (dr.GetDecimal("DONGIADCIC") != null) _dONGIADCIC = dr.GetDecimal("DONGIADCIC");
			if (dr.GetDecimal("DONGIADCDB1P1") != null) _dONGIADCDB1P1 = dr.GetDecimal("DONGIADCDB1P1");
			if (dr.GetDecimal("DONGIADCKC") != null) _dONGIADCKC = dr.GetDecimal("DONGIADCKC");
			if (dr.GetDecimal("DONGIADCKP1") != null) _dONGIADCKP1 = dr.GetDecimal("DONGIADCKP1");
			if (dr.GetDecimal("DONGIADCDBAC") != null) _dONGIADCDBAC = dr.GetDecimal("DONGIADCDBAC");
			if (dr.GetDecimal("DONGIAGMDBAP1") != null) _dONGIAGMDBAP1 = dr.GetDecimal("DONGIAGMDBAP1");
			if (dr.GetDecimal("DONGIAGMDBAP2") != null) _dONGIAGMDBAP2 = dr.GetDecimal("DONGIAGMDBAP2");
			if (dr.GetDecimal("DONGIAGMDBBC") != null) _dONGIAGMDBBC = dr.GetDecimal("DONGIAGMDBBC");
			if (dr.GetDecimal("DONGIAGMDBBP1") != null) _dONGIAGMDBBP1 = dr.GetDecimal("DONGIAGMDBBP1");
			if (dr.GetDecimal("DONGIAGMDBBP2") != null) _dONGIAGMDBBP2 = dr.GetDecimal("DONGIAGMDBBP2");
			if (dr.GetDecimal("DONGIAGMDBCC") != null) _dONGIAGMDBCC = dr.GetDecimal("DONGIAGMDBCC");
			if (dr.GetDecimal("DONGIAGMDBCP1") != null) _dONGIAGMDBCP1 = dr.GetDecimal("DONGIAGMDBCP1");
			if (dr.GetDecimal("DONGIAGMDBCP2") != null) _dONGIAGMDBCP2 = dr.GetDecimal("DONGIAGMDBCP2");
			if (dr.GetDecimal("DONGIAGMIC") != null) _dONGIAGMIC = dr.GetDecimal("DONGIAGMIC");
			if (dr.GetDecimal("DONGIAGMDB1P1") != null) _dONGIAGMDB1P1 = dr.GetDecimal("DONGIAGMDB1P1");
			if (dr.GetDecimal("DONGIAGMKC") != null) _dONGIAGMKC = dr.GetDecimal("DONGIAGMKC");
			if (dr.GetDecimal("DONGIAGMKP1") != null) _dONGIAGMKP1 = dr.GetDecimal("DONGIAGMKP1");
			if (dr.GetDecimal("DONGIAGMDBAC") != null) _dONGIAGMDBAC = dr.GetDecimal("DONGIAGMDBAC");
			if (dr.GetDecimal("DONGIACECDBAP1") != null) _dONGIACECDBAP1 = dr.GetDecimal("DONGIACECDBAP1");
			if (dr.GetDecimal("DONGIACECDBAP2") != null) _dONGIACECDBAP2 = dr.GetDecimal("DONGIACECDBAP2");
			if (dr.GetDecimal("DONGIACECDBBC") != null) _dONGIACECDBBC = dr.GetDecimal("DONGIACECDBBC");
			if (dr.GetDecimal("DONGIACECDBBP1") != null) _dONGIACECDBBP1 = dr.GetDecimal("DONGIACECDBBP1");
			if (dr.GetDecimal("DONGIACECDBBP2") != null) _dONGIACECDBBP2 = dr.GetDecimal("DONGIACECDBBP2");
			if (dr.GetDecimal("DONGIACECDBCC") != null) _dONGIACECDBCC = dr.GetDecimal("DONGIACECDBCC");
			if (dr.GetDecimal("DONGIACECDBCP1") != null) _dONGIACECDBCP1 = dr.GetDecimal("DONGIACECDBCP1");
			if (dr.GetDecimal("DONGIACECDBCP2") != null) _dONGIACECDBCP2 = dr.GetDecimal("DONGIACECDBCP2");
			if (dr.GetDecimal("DONGIACECIC") != null) _dONGIACECIC = dr.GetDecimal("DONGIACECIC");
			if (dr.GetDecimal("DONGIACECDB1P1") != null) _dONGIACECDB1P1 = dr.GetDecimal("DONGIACECDB1P1");
			if (dr.GetDecimal("DONGIACECKC") != null) _dONGIACECKC = dr.GetDecimal("DONGIACECKC");
			if (dr.GetDecimal("DONGIACECKP1") != null) _dONGIACECKP1 = dr.GetDecimal("DONGIACECKP1");
			if (dr.GetDecimal("DONGIACECDBAC") != null) _dONGIACECDBAC = dr.GetDecimal("DONGIACECDBAC");
			if (dr.GetDecimal("DonGiaAnTrua") != null) _donGiaAnTrua = dr.GetDecimal("DonGiaAnTrua");
			if (dr.GetDecimal("DonGiaAnToi") != null) _donGiaAnToi = dr.GetDecimal("DonGiaAnToi");
			if (dr.GetDecimal("MucLuongDocHai") != null) _mucLuongDocHai = dr.GetDecimal("MucLuongDocHai");
			if (dr.GetDecimal("DONGIADCDB1P2") != null) _dONGIADCDB1P2 = dr.GetDecimal("DONGIADCDB1P2");
			if (dr.GetDecimal("DONGIADCKP2") != null) _dONGIADCKP2 = dr.GetDecimal("DONGIADCKP2");
			if (dr.GetDecimal("DONGIACECDB1P2") != null) _dONGIACECDB1P2 = dr.GetDecimal("DONGIACECDB1P2");
			if (dr.GetDecimal("DONGIACECKP2") != null) _dONGIACECKP2 = dr.GetDecimal("DONGIACECKP2");
			if (dr.GetDecimal("DONGIAGMDB1P2") != null) _dONGIAGMDB1P2 = dr.GetDecimal("DONGIAGMDB1P2");
			if (dr.GetDecimal("DONGIAGMKP2") != null) _dONGIAGMKP2 = dr.GetDecimal("DONGIAGMKP2");
			if (dr.GetDecimal("DONGIATMDBAP1") != null) _dONGIATMDBAP1 = dr.GetDecimal("DONGIATMDBAP1");
			if (dr.GetDecimal("DONGIATMDBAP2") != null) _dONGIATMDBAP2 = dr.GetDecimal("DONGIATMDBAP2");
			if (dr.GetDecimal("DONGIATMDBBC") != null) _dONGIATMDBBC = dr.GetDecimal("DONGIATMDBBC");
			if (dr.GetDecimal("DONGIATMDBBP1") != null) _dONGIATMDBBP1 = dr.GetDecimal("DONGIATMDBBP1");
			if (dr.GetDecimal("DONGIATMDBBP2") != null) _dONGIATMDBBP2 = dr.GetDecimal("DONGIATMDBBP2");
			if (dr.GetDecimal("DONGIATMDBCC") != null) _dONGIATMDBCC = dr.GetDecimal("DONGIATMDBCC");
			if (dr.GetDecimal("DONGIATMDBCP1") != null) _dONGIATMDBCP1 = dr.GetDecimal("DONGIATMDBCP1");
			if (dr.GetDecimal("DONGIATMDBCP2") != null) _dONGIATMDBCP2 = dr.GetDecimal("DONGIATMDBCP2");
			if (dr.GetDecimal("DONGIATMIC") != null) _dONGIATMIC = dr.GetDecimal("DONGIATMIC");
			if (dr.GetDecimal("DONGIATMDB1P1") != null) _dONGIATMDB1P1 = dr.GetDecimal("DONGIATMDB1P1");
			if (dr.GetDecimal("DONGIATMKC") != null) _dONGIATMKC = dr.GetDecimal("DONGIATMKC");
			if (dr.GetDecimal("DONGIATMKP1") != null) _dONGIATMKP1 = dr.GetDecimal("DONGIATMKP1");
			if (dr.GetDecimal("DONGIATMDBAC") != null) _dONGIATMDBAC = dr.GetDecimal("DONGIATMDBAC");
			if (dr.GetDecimal("DONGIATMDCDBAP1") != null) _dONGIATMDCDBAP1 = dr.GetDecimal("DONGIATMDCDBAP1");
			if (dr.GetDecimal("DONGIATMDCDBAP2") != null) _dONGIATMDCDBAP2 = dr.GetDecimal("DONGIATMDCDBAP2");
			if (dr.GetDecimal("DONGIATMDCDBBC") != null) _dONGIATMDCDBBC = dr.GetDecimal("DONGIATMDCDBBC");
			if (dr.GetDecimal("DONGIATMDCDBBP1") != null) _dONGIATMDCDBBP1 = dr.GetDecimal("DONGIATMDCDBBP1");
			if (dr.GetDecimal("DONGIATMDCDBBP2") != null) _dONGIATMDCDBBP2 = dr.GetDecimal("DONGIATMDCDBBP2");
			if (dr.GetDecimal("DONGIATMDCDBCC") != null) _dONGIATMDCDBCC = dr.GetDecimal("DONGIATMDCDBCC");
			if (dr.GetDecimal("DONGIATMDCDBCP1") != null) _dONGIATMDCDBCP1 = dr.GetDecimal("DONGIATMDCDBCP1");
			if (dr.GetDecimal("DONGIATMDCDBCP2") != null) _dONGIATMDCDBCP2 = dr.GetDecimal("DONGIATMDCDBCP2");
			if (dr.GetDecimal("DONGIATMDCIC") != null) _dONGIATMDCIC = dr.GetDecimal("DONGIATMDCIC");
			if (dr.GetDecimal("DONGIATMDCDB1P1") != null) _dONGIATMDCDB1P1 = dr.GetDecimal("DONGIATMDCDB1P1");
			if (dr.GetDecimal("DONGIATMDCKC") != null) _dONGIATMDCKC = dr.GetDecimal("DONGIATMDCKC");
			if (dr.GetDecimal("DONGIATMDCKP1") != null) _dONGIATMDCKP1 = dr.GetDecimal("DONGIATMDCKP1");
			if (dr.GetDecimal("DONGIATMDCDBAC") != null) _dONGIATMDCDBAC = dr.GetDecimal("DONGIATMDCDBAC");
			if (dr.GetDecimal("DONGIATMGMDBAP1") != null) _dONGIATMGMDBAP1 = dr.GetDecimal("DONGIATMGMDBAP1");
			if (dr.GetDecimal("DONGIATMGMDBAP2") != null) _dONGIATMGMDBAP2 = dr.GetDecimal("DONGIATMGMDBAP2");
			if (dr.GetDecimal("DONGIATMGMDBBC") != null) _dONGIATMGMDBBC = dr.GetDecimal("DONGIATMGMDBBC");
			if (dr.GetDecimal("DONGIATMGMDBBP1") != null) _dONGIATMGMDBBP1 = dr.GetDecimal("DONGIATMGMDBBP1");
			if (dr.GetDecimal("DONGIATMGMDBBP2") != null) _dONGIATMGMDBBP2 = dr.GetDecimal("DONGIATMGMDBBP2");
			if (dr.GetDecimal("DONGIATMGMDBCC") != null) _dONGIATMGMDBCC = dr.GetDecimal("DONGIATMGMDBCC");
			if (dr.GetDecimal("DONGIATMGMDBCP1") != null) _dONGIATMGMDBCP1 = dr.GetDecimal("DONGIATMGMDBCP1");
			if (dr.GetDecimal("DONGIATMGMDBCP2") != null) _dONGIATMGMDBCP2 = dr.GetDecimal("DONGIATMGMDBCP2");
			if (dr.GetDecimal("DONGIATMGMIC") != null) _dONGIATMGMIC = dr.GetDecimal("DONGIATMGMIC");
			if (dr.GetDecimal("DONGIATMGMDB1P1") != null) _dONGIATMGMDB1P1 = dr.GetDecimal("DONGIATMGMDB1P1");
			if (dr.GetDecimal("DONGIATMGMKC") != null) _dONGIATMGMKC = dr.GetDecimal("DONGIATMGMKC");
			if (dr.GetDecimal("DONGIATMGMKP1") != null) _dONGIATMGMKP1 = dr.GetDecimal("DONGIATMGMKP1");
			if (dr.GetDecimal("DONGIATMGMDBAC") != null) _dONGIATMGMDBAC = dr.GetDecimal("DONGIATMGMDBAC");
			if (dr.GetDecimal("DONGIATMCECDBAP1") != null) _dONGIATMCECDBAP1 = dr.GetDecimal("DONGIATMCECDBAP1");
			if (dr.GetDecimal("DONGIATMCECDBAP2") != null) _dONGIATMCECDBAP2 = dr.GetDecimal("DONGIATMCECDBAP2");
			if (dr.GetDecimal("DONGIATMCECDBBC") != null) _dONGIATMCECDBBC = dr.GetDecimal("DONGIATMCECDBBC");
			if (dr.GetDecimal("DONGIATMCECDBBP1") != null) _dONGIATMCECDBBP1 = dr.GetDecimal("DONGIATMCECDBBP1");
			if (dr.GetDecimal("DONGIATMCECDBBP2") != null) _dONGIATMCECDBBP2 = dr.GetDecimal("DONGIATMCECDBBP2");
			if (dr.GetDecimal("DONGIATMCECDBCC") != null) _dONGIATMCECDBCC = dr.GetDecimal("DONGIATMCECDBCC");
			if (dr.GetDecimal("DONGIATMCECDBCP1") != null) _dONGIATMCECDBCP1 = dr.GetDecimal("DONGIATMCECDBCP1");
			if (dr.GetDecimal("DONGIATMCECDBCP2") != null) _dONGIATMCECDBCP2 = dr.GetDecimal("DONGIATMCECDBCP2");
			if (dr.GetDecimal("DONGIATMCECIC") != null) _dONGIATMCECIC = dr.GetDecimal("DONGIATMCECIC");
			if (dr.GetDecimal("DONGIATMCECDB1P1") != null) _dONGIATMCECDB1P1 = dr.GetDecimal("DONGIATMCECDB1P1");
			if (dr.GetDecimal("DONGIATMCECKC") != null) _dONGIATMCECKC = dr.GetDecimal("DONGIATMCECKC");
			if (dr.GetDecimal("DONGIATMCECKP1") != null) _dONGIATMCECKP1 = dr.GetDecimal("DONGIATMCECKP1");
			if (dr.GetDecimal("DONGIATMCECDBAC") != null) _dONGIATMCECDBAC = dr.GetDecimal("DONGIATMCECDBAC");
			if (dr.GetDecimal("DONGIATMDB1P2") != null) _dONGIATMDB1P2 = dr.GetDecimal("DONGIATMDB1P2");
			if (dr.GetDecimal("DONGIATMKP2") != null) _dONGIATMKP2 = dr.GetDecimal("DONGIATMKP2");
			if (dr.GetDecimal("DONGIATMDCDB1P2") != null) _dONGIATMDCDB1P2 = dr.GetDecimal("DONGIATMDCDB1P2");
			if (dr.GetDecimal("DONGIATMDCKP2") != null) _dONGIATMDCKP2 = dr.GetDecimal("DONGIATMDCKP2");
			if (dr.GetDecimal("DONGIATMCECDB1P2") != null) _dONGIATMCECDB1P2 = dr.GetDecimal("DONGIATMCECDB1P2");
			if (dr.GetDecimal("DONGIATMCECKP2") != null) _dONGIATMCECKP2 = dr.GetDecimal("DONGIATMCECKP2");
			if (dr.GetDecimal("DONGIATMGMDB1P2") != null) _dONGIATMGMDB1P2 = dr.GetDecimal("DONGIATMGMDB1P2");
			if (dr.GetDecimal("DONGIATMGMKP2") != null) _dONGIATMGMKP2 = dr.GetDecimal("DONGIATMGMKP2");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetDecimal("DONGIADB1P2") != null) _dONGIADB1P2 = dr.GetDecimal("DONGIADB1P2");
            if (dr.GetDecimal("DONGIAKP2") != null) _dONGIAKP2 = dr.GetDecimal("DONGIAKP2");
            if (dr.GetDecimal("DONGIAGMTE") != null) _dONGIAGMTE  = dr.GetDecimal("DONGIAGMTE");
		}
		
		/// <summary>
		/// Insert the new <see cref="ThamSoLuong" /> Object to underlying database.
		/// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThamSoLuong
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //    _mucLuongCB = DataProvider.Instance().InsertThamSoLuong(_mucLuongCB, _bHYT, _bHXH, _congDoan, _heSoThamNien, _donGiaTruc, _donGiaXQuang, _donGiaM2, _donGiaNTHSCC, _donGiaNNHSCC, _donGiaNLHSCC, _donGiaQCCTNBHSCC, _donGiaND1142002HSCC, _donGiaNTCM, _donGiaNNCM, _donGiaNLCM, _donGiaQCCTNBCM, _donGiaNTLD, _donGiaNNLD, _donGiaNLLD, _donGiaCocIHSCC, _donGiaCocIIHSCC, _donGiaDDHSCC, _donGiaCocICM, _donGiaCocIICM, _donGiaDDCM, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _dONGIANVien, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _heSoPTHS, _dONGIAA, _dONGIAB, _dONGIAC, _mucTTThue, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _dONGIADBAC, _dONGIADCDBAP1, _dONGIADCDBAP2, _dONGIADCDBBC, _dONGIADCDBBP1, _dONGIADCDBBP2, _dONGIADCDBCC, _dONGIADCDBCP1, _dONGIADCDBCP2, _dONGIADCIC, _dONGIADCDB1P1, _dONGIADCKC, _dONGIADCKP1, _dONGIADCDBAC, _dONGIAGMDBAP1, _dONGIAGMDBAP2, _dONGIAGMDBBC, _dONGIAGMDBBP1, _dONGIAGMDBBP2, _dONGIAGMDBCC, _dONGIAGMDBCP1, _dONGIAGMDBCP2, _dONGIAGMIC, _dONGIAGMDB1P1, _dONGIAGMKC, _dONGIAGMKP1, _dONGIAGMDBAC, _dONGIACECDBAP1, _dONGIACECDBAP2, _dONGIACECDBBC, _dONGIACECDBBP1, _dONGIACECDBBP2, _dONGIACECDBCC, _dONGIACECDBCP1, _dONGIACECDBCP2, _dONGIACECIC, _dONGIACECDB1P1, _dONGIACECKC, _dONGIACECKP1, _dONGIACECDBAC, _donGiaAnTrua, _donGiaAnToi, _mucLuongDocHai, _dONGIADCDB1P2, _dONGIADCKP2, _dONGIACECDB1P2, _dONGIACECKP2, _dONGIAGMDB1P2, _dONGIAGMKP2, _dONGIATMDBAP1, _dONGIATMDBAP2, _dONGIATMDBBC, _dONGIATMDBBP1, _dONGIATMDBBP2, _dONGIATMDBCC, _dONGIATMDBCP1, _dONGIATMDBCP2, _dONGIATMIC, _dONGIATMDB1P1, _dONGIATMKC, _dONGIATMKP1, _dONGIATMDBAC, _dONGIATMDCDBAP1, _dONGIATMDCDBAP2, _dONGIATMDCDBBC, _dONGIATMDCDBBP1, _dONGIATMDCDBBP2, _dONGIATMDCDBCC, _dONGIATMDCDBCP1, _dONGIATMDCDBCP2, _dONGIATMDCIC, _dONGIATMDCDB1P1, _dONGIATMDCKC, _dONGIATMDCKP1, _dONGIATMDCDBAC, _dONGIATMGMDBAP1, _dONGIATMGMDBAP2, _dONGIATMGMDBBC, _dONGIATMGMDBBP1, _dONGIATMGMDBBP2, _dONGIATMGMDBCC, _dONGIATMGMDBCP1, _dONGIATMGMDBCP2, _dONGIATMGMIC, _dONGIATMGMDB1P1, _dONGIATMGMKC, _dONGIATMGMKP1, _dONGIATMGMDBAC, _dONGIATMCECDBAP1, _dONGIATMCECDBAP2, _dONGIATMCECDBBC, _dONGIATMCECDBBP1, _dONGIATMCECDBBP2, _dONGIATMCECDBCC, _dONGIATMCECDBCP1, _dONGIATMCECDBCP2, _dONGIATMCECIC, _dONGIATMCECDB1P1, _dONGIATMCECKC, _dONGIATMCECKP1, _dONGIATMCECDBAC, _dONGIATMDB1P2, _dONGIATMKP2, _dONGIATMDCDB1P2, _dONGIATMDCKP2, _dONGIATMCECDB1P2, _dONGIATMCECKP2, _dONGIATMGMDB1P2, _dONGIATMGMKP2, _huy, _ngaySD, _nguoiSD , _maMay);
        //    // public abstract Decimal InsertThamSoLuong(Decimal _mucLuongCB, Decimal _bHYT, Decimal _bHXH, Decimal _congDoan, Decimal _heSoThamNien, Decimal _donGiaTruc, Decimal _donGiaXQuang, Decimal _donGiaM2, Decimal _donGiaNTHSCC, Decimal _donGiaNNHSCC, Decimal _donGiaNLHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _donGiaND1142002HSCC, Decimal _donGiaNTCM, Decimal _donGiaNNCM, Decimal _donGiaNLCM, Decimal _donGiaQCCTNBCM, Decimal _donGiaNTLD, Decimal _donGiaNNLD, Decimal _donGiaNLLD, Decimal _donGiaCocIHSCC, Decimal _donGiaCocIIHSCC, Decimal _donGiaDDHSCC, Decimal _donGiaCocICM, Decimal _donGiaCocIICM, Decimal _donGiaDDCM, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _heSoPTHS, Decimal _dONGIAA, Decimal _dONGIAB, Decimal _dONGIAC, Decimal _mucTTThue, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _dONGIADBAC, Decimal _dONGIADCDBAP1, Decimal _dONGIADCDBAP2, Decimal _dONGIADCDBBC, Decimal _dONGIADCDBBP1, Decimal _dONGIADCDBBP2, Decimal _dONGIADCDBCC, Decimal _dONGIADCDBCP1, Decimal _dONGIADCDBCP2, Decimal _dONGIADCIC, Decimal _dONGIADCDB1P1, Decimal _dONGIADCKC, Decimal _dONGIADCKP1, Decimal _dONGIADCDBAC, Decimal _dONGIAGMDBAP1, Decimal _dONGIAGMDBAP2, Decimal _dONGIAGMDBBC, Decimal _dONGIAGMDBBP1, Decimal _dONGIAGMDBBP2, Decimal _dONGIAGMDBCC, Decimal _dONGIAGMDBCP1, Decimal _dONGIAGMDBCP2, Decimal _dONGIAGMIC, Decimal _dONGIAGMDB1P1, Decimal _dONGIAGMKC, Decimal _dONGIAGMKP1, Decimal _dONGIAGMDBAC, Decimal _dONGIACECDBAP1, Decimal _dONGIACECDBAP2, Decimal _dONGIACECDBBC, Decimal _dONGIACECDBBP1, Decimal _dONGIACECDBBP2, Decimal _dONGIACECDBCC, Decimal _dONGIACECDBCP1, Decimal _dONGIACECDBCP2, Decimal _dONGIACECIC, Decimal _dONGIACECDB1P1, Decimal _dONGIACECKC, Decimal _dONGIACECKP1, Decimal _dONGIACECDBAC, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _mucLuongDocHai, Decimal _dONGIADCDB1P2, Decimal _dONGIADCKP2, Decimal _dONGIACECDB1P2, Decimal _dONGIACECKP2, Decimal _dONGIAGMDB1P2, Decimal _dONGIAGMKP2, Decimal _dONGIATMDBAP1, Decimal _dONGIATMDBAP2, Decimal _dONGIATMDBBC, Decimal _dONGIATMDBBP1, Decimal _dONGIATMDBBP2, Decimal _dONGIATMDBCC, Decimal _dONGIATMDBCP1, Decimal _dONGIATMDBCP2, Decimal _dONGIATMIC, Decimal _dONGIATMDB1P1, Decimal _dONGIATMKC, Decimal _dONGIATMKP1, Decimal _dONGIATMDBAC, Decimal _dONGIATMDCDBAP1, Decimal _dONGIATMDCDBAP2, Decimal _dONGIATMDCDBBC, Decimal _dONGIATMDCDBBP1, Decimal _dONGIATMDCDBBP2, Decimal _dONGIATMDCDBCC, Decimal _dONGIATMDCDBCP1, Decimal _dONGIATMDCDBCP2, Decimal _dONGIATMDCIC, Decimal _dONGIATMDCDB1P1, Decimal _dONGIATMDCKC, Decimal _dONGIATMDCKP1, Decimal _dONGIATMDCDBAC, Decimal _dONGIATMGMDBAP1, Decimal _dONGIATMGMDBAP2, Decimal _dONGIATMGMDBBC, Decimal _dONGIATMGMDBBP1, Decimal _dONGIATMGMDBBP2, Decimal _dONGIATMGMDBCC, Decimal _dONGIATMGMDBCP1, Decimal _dONGIATMGMDBCP2, Decimal _dONGIATMGMIC, Decimal _dONGIATMGMDB1P1, Decimal _dONGIATMGMKC, Decimal _dONGIATMGMKP1, Decimal _dONGIATMGMDBAC, Decimal _dONGIATMCECDBAP1, Decimal _dONGIATMCECDBAP2, Decimal _dONGIATMCECDBBC, Decimal _dONGIATMCECDBBP1, Decimal _dONGIATMCECDBBP2, Decimal _dONGIATMCECDBCC, Decimal _dONGIATMCECDBCP1, Decimal _dONGIATMCECDBCP2, Decimal _dONGIATMCECIC, Decimal _dONGIATMCECDB1P1, Decimal _dONGIATMCECKC, Decimal _dONGIATMCECKP1, Decimal _dONGIATMCECDBAC, Decimal _dONGIATMDB1P2, Decimal _dONGIATMKP2, Decimal _dONGIATMDCDB1P2, Decimal _dONGIATMDCKP2, Decimal _dONGIATMCECDB1P2, Decimal _dONGIATMCECKP2, Decimal _dONGIATMGMDB1P2, Decimal _dONGIATMGMKP2, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, String _maMay);
        //    // public override Decimal InsertThamSoLuong(Decimal _mucLuongCB, Decimal _bHYT, Decimal _bHXH, Decimal _congDoan, Decimal _heSoThamNien, Decimal _donGiaTruc, Decimal _donGiaXQuang, Decimal _donGiaM2, Decimal _donGiaNTHSCC, Decimal _donGiaNNHSCC, Decimal _donGiaNLHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _donGiaND1142002HSCC, Decimal _donGiaNTCM, Decimal _donGiaNNCM, Decimal _donGiaNLCM, Decimal _donGiaQCCTNBCM, Decimal _donGiaNTLD, Decimal _donGiaNNLD, Decimal _donGiaNLLD, Decimal _donGiaCocIHSCC, Decimal _donGiaCocIIHSCC, Decimal _donGiaDDHSCC, Decimal _donGiaCocICM, Decimal _donGiaCocIICM, Decimal _donGiaDDCM, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _heSoPTHS, Decimal _dONGIAA, Decimal _dONGIAB, Decimal _dONGIAC, Decimal _mucTTThue, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _dONGIADBAC, Decimal _dONGIADCDBAP1, Decimal _dONGIADCDBAP2, Decimal _dONGIADCDBBC, Decimal _dONGIADCDBBP1, Decimal _dONGIADCDBBP2, Decimal _dONGIADCDBCC, Decimal _dONGIADCDBCP1, Decimal _dONGIADCDBCP2, Decimal _dONGIADCIC, Decimal _dONGIADCDB1P1, Decimal _dONGIADCKC, Decimal _dONGIADCKP1, Decimal _dONGIADCDBAC, Decimal _dONGIAGMDBAP1, Decimal _dONGIAGMDBAP2, Decimal _dONGIAGMDBBC, Decimal _dONGIAGMDBBP1, Decimal _dONGIAGMDBBP2, Decimal _dONGIAGMDBCC, Decimal _dONGIAGMDBCP1, Decimal _dONGIAGMDBCP2, Decimal _dONGIAGMIC, Decimal _dONGIAGMDB1P1, Decimal _dONGIAGMKC, Decimal _dONGIAGMKP1, Decimal _dONGIAGMDBAC, Decimal _dONGIACECDBAP1, Decimal _dONGIACECDBAP2, Decimal _dONGIACECDBBC, Decimal _dONGIACECDBBP1, Decimal _dONGIACECDBBP2, Decimal _dONGIACECDBCC, Decimal _dONGIACECDBCP1, Decimal _dONGIACECDBCP2, Decimal _dONGIACECIC, Decimal _dONGIACECDB1P1, Decimal _dONGIACECKC, Decimal _dONGIACECKP1, Decimal _dONGIACECDBAC, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _mucLuongDocHai, Decimal _dONGIADCDB1P2, Decimal _dONGIADCKP2, Decimal _dONGIACECDB1P2, Decimal _dONGIACECKP2, Decimal _dONGIAGMDB1P2, Decimal _dONGIAGMKP2, Decimal _dONGIATMDBAP1, Decimal _dONGIATMDBAP2, Decimal _dONGIATMDBBC, Decimal _dONGIATMDBBP1, Decimal _dONGIATMDBBP2, Decimal _dONGIATMDBCC, Decimal _dONGIATMDBCP1, Decimal _dONGIATMDBCP2, Decimal _dONGIATMIC, Decimal _dONGIATMDB1P1, Decimal _dONGIATMKC, Decimal _dONGIATMKP1, Decimal _dONGIATMDBAC, Decimal _dONGIATMDCDBAP1, Decimal _dONGIATMDCDBAP2, Decimal _dONGIATMDCDBBC, Decimal _dONGIATMDCDBBP1, Decimal _dONGIATMDCDBBP2, Decimal _dONGIATMDCDBCC, Decimal _dONGIATMDCDBCP1, Decimal _dONGIATMDCDBCP2, Decimal _dONGIATMDCIC, Decimal _dONGIATMDCDB1P1, Decimal _dONGIATMDCKC, Decimal _dONGIATMDCKP1, Decimal _dONGIATMDCDBAC, Decimal _dONGIATMGMDBAP1, Decimal _dONGIATMGMDBAP2, Decimal _dONGIATMGMDBBC, Decimal _dONGIATMGMDBBP1, Decimal _dONGIATMGMDBBP2, Decimal _dONGIATMGMDBCC, Decimal _dONGIATMGMDBCP1, Decimal _dONGIATMGMDBCP2, Decimal _dONGIATMGMIC, Decimal _dONGIATMGMDB1P1, Decimal _dONGIATMGMKC, Decimal _dONGIATMGMKP1, Decimal _dONGIATMGMDBAC, Decimal _dONGIATMCECDBAP1, Decimal _dONGIATMCECDBAP2, Decimal _dONGIATMCECDBBC, Decimal _dONGIATMCECDBBP1, Decimal _dONGIATMCECDBBP2, Decimal _dONGIATMCECDBCC, Decimal _dONGIATMCECDBCP1, Decimal _dONGIATMCECDBCP2, Decimal _dONGIATMCECIC, Decimal _dONGIATMCECDB1P1, Decimal _dONGIATMCECKC, Decimal _dONGIATMCECKP1, Decimal _dONGIATMCECDBAC, Decimal _dONGIATMDB1P2, Decimal _dONGIATMKP2, Decimal _dONGIATMDCDB1P2, Decimal _dONGIATMDCKP2, Decimal _dONGIATMCECDB1P2, Decimal _dONGIATMCECKP2, Decimal _dONGIATMGMDB1P2, Decimal _dONGIATMGMKP2, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, String _maMay);
        //    // {
        //    //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _mucLuongCB, _bHYT, _bHXH, _congDoan, _heSoThamNien, _donGiaTruc, _donGiaXQuang, _donGiaM2, _donGiaNTHSCC, _donGiaNNHSCC, _donGiaNLHSCC, _donGiaQCCTNBHSCC, _donGiaND1142002HSCC, _donGiaNTCM, _donGiaNNCM, _donGiaNLCM, _donGiaQCCTNBCM, _donGiaNTLD, _donGiaNNLD, _donGiaNLLD, _donGiaCocIHSCC, _donGiaCocIIHSCC, _donGiaDDHSCC, _donGiaCocICM, _donGiaCocIICM, _donGiaDDCM, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _dONGIANVien, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _heSoPTHS, _dONGIAA, _dONGIAB, _dONGIAC, _mucTTThue, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _dONGIADBAC, _dONGIADCDBAP1, _dONGIADCDBAP2, _dONGIADCDBBC, _dONGIADCDBBP1, _dONGIADCDBBP2, _dONGIADCDBCC, _dONGIADCDBCP1, _dONGIADCDBCP2, _dONGIADCIC, _dONGIADCDB1P1, _dONGIADCKC, _dONGIADCKP1, _dONGIADCDBAC, _dONGIAGMDBAP1, _dONGIAGMDBAP2, _dONGIAGMDBBC, _dONGIAGMDBBP1, _dONGIAGMDBBP2, _dONGIAGMDBCC, _dONGIAGMDBCP1, _dONGIAGMDBCP2, _dONGIAGMIC, _dONGIAGMDB1P1, _dONGIAGMKC, _dONGIAGMKP1, _dONGIAGMDBAC, _dONGIACECDBAP1, _dONGIACECDBAP2, _dONGIACECDBBC, _dONGIACECDBBP1, _dONGIACECDBBP2, _dONGIACECDBCC, _dONGIACECDBCP1, _dONGIACECDBCP2, _dONGIACECIC, _dONGIACECDB1P1, _dONGIACECKC, _dONGIACECKP1, _dONGIACECDBAC, _donGiaAnTrua, _donGiaAnToi, _mucLuongDocHai, _dONGIADCDB1P2, _dONGIADCKP2, _dONGIACECDB1P2, _dONGIACECKP2, _dONGIAGMDB1P2, _dONGIAGMKP2, _dONGIATMDBAP1, _dONGIATMDBAP2, _dONGIATMDBBC, _dONGIATMDBBP1, _dONGIATMDBBP2, _dONGIATMDBCC, _dONGIATMDBCP1, _dONGIATMDBCP2, _dONGIATMIC, _dONGIATMDB1P1, _dONGIATMKC, _dONGIATMKP1, _dONGIATMDBAC, _dONGIATMDCDBAP1, _dONGIATMDCDBAP2, _dONGIATMDCDBBC, _dONGIATMDCDBBP1, _dONGIATMDCDBBP2, _dONGIATMDCDBCC, _dONGIATMDCDBCP1, _dONGIATMDCDBCP2, _dONGIATMDCIC, _dONGIATMDCDB1P1, _dONGIATMDCKC, _dONGIATMDCKP1, _dONGIATMDCDBAC, _dONGIATMGMDBAP1, _dONGIATMGMDBAP2, _dONGIATMGMDBBC, _dONGIATMGMDBBP1, _dONGIATMGMDBBP2, _dONGIATMGMDBCC, _dONGIATMGMDBCP1, _dONGIATMGMDBCP2, _dONGIATMGMIC, _dONGIATMGMDB1P1, _dONGIATMGMKC, _dONGIATMGMKP1, _dONGIATMGMDBAC, _dONGIATMCECDBAP1, _dONGIATMCECDBAP2, _dONGIATMCECDBBC, _dONGIATMCECDBBP1, _dONGIATMCECDBBP2, _dONGIATMCECDBCC, _dONGIATMCECDBCP1, _dONGIATMCECDBCP2, _dONGIATMCECIC, _dONGIATMCECDB1P1, _dONGIATMCECKC, _dONGIATMCECKP1, _dONGIATMCECDBAC, _dONGIATMDB1P2, _dONGIATMKP2, _dONGIATMDCDB1P2, _dONGIATMDCKP2, _dONGIATMCECDB1P2, _dONGIATMCECKP2, _dONGIATMGMDB1P2, _dONGIATMGMKP2, _huy, _ngaySD.DBValue, _nguoiSD , _maMay), Decimal);
        //    // }
        //}
		
		/// <summary>
		/// Update all changes made on <see cref="ThamSoLuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThamSoLuong
			if (IsDirty){
                DataProvider.Instance().UpdateThamSoLuong(_mucLuongCB, _bHYT, _bHXH, _congDoan, _heSoThamNien, _donGiaTruc, _donGiaXQuang, _donGiaM2, _donGiaNTHSCC, _donGiaNNHSCC, _donGiaNLHSCC, _donGiaQCCTNBHSCC, _donGiaND1142002HSCC, _donGiaNTCM, _donGiaNNCM, _donGiaNLCM, _donGiaQCCTNBCM, _donGiaNTLD, _donGiaNNLD, _donGiaNLLD, _donGiaCocIHSCC, _donGiaCocIIHSCC, _donGiaDDHSCC, _donGiaCocICM, _donGiaCocIICM, _donGiaDDCM, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _dONGIANVien, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _heSoPTHS, _dONGIAA, _dONGIAB, _dONGIAC, _mucTTThue, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _dONGIADBAC, _dONGIADCDBAP1, _dONGIADCDBAP2, _dONGIADCDBBC, _dONGIADCDBBP1, _dONGIADCDBBP2, _dONGIADCDBCC, _dONGIADCDBCP1, _dONGIADCDBCP2, _dONGIADCIC, _dONGIADCDB1P1, _dONGIADCKC, _dONGIADCKP1, _dONGIADCDBAC, _dONGIAGMDBAP1, _dONGIAGMDBAP2, _dONGIAGMDBBC, _dONGIAGMDBBP1, _dONGIAGMDBBP2, _dONGIAGMDBCC, _dONGIAGMDBCP1, _dONGIAGMDBCP2, _dONGIAGMIC, _dONGIAGMDB1P1, _dONGIAGMKC, _dONGIAGMKP1, _dONGIAGMDBAC, _dONGIACECDBAP1, _dONGIACECDBAP2, _dONGIACECDBBC, _dONGIACECDBBP1, _dONGIACECDBBP2, _dONGIACECDBCC, _dONGIACECDBCP1, _dONGIACECDBCP2, _dONGIACECIC, _dONGIACECDB1P1, _dONGIACECKC, _dONGIACECKP1, _dONGIACECDBAC, _donGiaAnTrua, _donGiaAnToi, _mucLuongDocHai, _dONGIADCDB1P2, _dONGIADCKP2, _dONGIACECDB1P2, _dONGIACECKP2, _dONGIAGMDB1P2, _dONGIAGMKP2, _dONGIATMDBAP1, _dONGIATMDBAP2, _dONGIATMDBBC, _dONGIATMDBBP1, _dONGIATMDBBP2, _dONGIATMDBCC, _dONGIATMDBCP1, _dONGIATMDBCP2, _dONGIATMIC, _dONGIATMDB1P1, _dONGIATMKC, _dONGIATMKP1, _dONGIATMDBAC, _dONGIATMDCDBAP1, _dONGIATMDCDBAP2, _dONGIATMDCDBBC, _dONGIATMDCDBBP1, _dONGIATMDCDBBP2, _dONGIATMDCDBCC, _dONGIATMDCDBCP1, _dONGIATMDCDBCP2, _dONGIATMDCIC, _dONGIATMDCDB1P1, _dONGIATMDCKC, _dONGIATMDCKP1, _dONGIATMDCDBAC, _dONGIATMGMDBAP1, _dONGIATMGMDBAP2, _dONGIATMGMDBBC, _dONGIATMGMDBBP1, _dONGIATMGMDBBP2, _dONGIATMGMDBCC, _dONGIATMGMDBCP1, _dONGIATMGMDBCP2, _dONGIATMGMIC, _dONGIATMGMDB1P1, _dONGIATMGMKC, _dONGIATMGMKP1, _dONGIATMGMDBAC, _dONGIATMCECDBAP1, _dONGIATMCECDBAP2, _dONGIATMCECDBBC, _dONGIATMCECDBBP1, _dONGIATMCECDBBP2, _dONGIATMCECDBCC, _dONGIATMCECDBCP1, _dONGIATMCECDBCP2, _dONGIATMCECIC, _dONGIATMCECDB1P1, _dONGIATMCECKC, _dONGIATMCECKP1, _dONGIATMCECDBAC, _dONGIATMDB1P2, _dONGIATMKP2, _dONGIATMDCDB1P2, _dONGIATMDCKP2, _dONGIATMCECDB1P2, _dONGIATMCECKP2, _dONGIATMGMDB1P2, _dONGIATMGMKP2, _huy, _nguoiSD , _maMay, _dONGIADB1P2, _dONGIAKP2,_dONGIAGMTE );
				// public abstract void UpdateThamSoLuong(Decimal _mucLuongCB, Decimal _bHYT, Decimal _bHXH, Decimal _congDoan, Decimal _heSoThamNien, Decimal _donGiaTruc, Decimal _donGiaXQuang, Decimal _donGiaM2, Decimal _donGiaNTHSCC, Decimal _donGiaNNHSCC, Decimal _donGiaNLHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _donGiaND1142002HSCC, Decimal _donGiaNTCM, Decimal _donGiaNNCM, Decimal _donGiaNLCM, Decimal _donGiaQCCTNBCM, Decimal _donGiaNTLD, Decimal _donGiaNNLD, Decimal _donGiaNLLD, Decimal _donGiaCocIHSCC, Decimal _donGiaCocIIHSCC, Decimal _donGiaDDHSCC, Decimal _donGiaCocICM, Decimal _donGiaCocIICM, Decimal _donGiaDDCM, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _heSoPTHS, Decimal _dONGIAA, Decimal _dONGIAB, Decimal _dONGIAC, Decimal _mucTTThue, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _dONGIADBAC, Decimal _dONGIADCDBAP1, Decimal _dONGIADCDBAP2, Decimal _dONGIADCDBBC, Decimal _dONGIADCDBBP1, Decimal _dONGIADCDBBP2, Decimal _dONGIADCDBCC, Decimal _dONGIADCDBCP1, Decimal _dONGIADCDBCP2, Decimal _dONGIADCIC, Decimal _dONGIADCDB1P1, Decimal _dONGIADCKC, Decimal _dONGIADCKP1, Decimal _dONGIADCDBAC, Decimal _dONGIAGMDBAP1, Decimal _dONGIAGMDBAP2, Decimal _dONGIAGMDBBC, Decimal _dONGIAGMDBBP1, Decimal _dONGIAGMDBBP2, Decimal _dONGIAGMDBCC, Decimal _dONGIAGMDBCP1, Decimal _dONGIAGMDBCP2, Decimal _dONGIAGMIC, Decimal _dONGIAGMDB1P1, Decimal _dONGIAGMKC, Decimal _dONGIAGMKP1, Decimal _dONGIAGMDBAC, Decimal _dONGIACECDBAP1, Decimal _dONGIACECDBAP2, Decimal _dONGIACECDBBC, Decimal _dONGIACECDBBP1, Decimal _dONGIACECDBBP2, Decimal _dONGIACECDBCC, Decimal _dONGIACECDBCP1, Decimal _dONGIACECDBCP2, Decimal _dONGIACECIC, Decimal _dONGIACECDB1P1, Decimal _dONGIACECKC, Decimal _dONGIACECKP1, Decimal _dONGIACECDBAC, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _mucLuongDocHai, Decimal _dONGIADCDB1P2, Decimal _dONGIADCKP2, Decimal _dONGIACECDB1P2, Decimal _dONGIACECKP2, Decimal _dONGIAGMDB1P2, Decimal _dONGIAGMKP2, Decimal _dONGIATMDBAP1, Decimal _dONGIATMDBAP2, Decimal _dONGIATMDBBC, Decimal _dONGIATMDBBP1, Decimal _dONGIATMDBBP2, Decimal _dONGIATMDBCC, Decimal _dONGIATMDBCP1, Decimal _dONGIATMDBCP2, Decimal _dONGIATMIC, Decimal _dONGIATMDB1P1, Decimal _dONGIATMKC, Decimal _dONGIATMKP1, Decimal _dONGIATMDBAC, Decimal _dONGIATMDCDBAP1, Decimal _dONGIATMDCDBAP2, Decimal _dONGIATMDCDBBC, Decimal _dONGIATMDCDBBP1, Decimal _dONGIATMDCDBBP2, Decimal _dONGIATMDCDBCC, Decimal _dONGIATMDCDBCP1, Decimal _dONGIATMDCDBCP2, Decimal _dONGIATMDCIC, Decimal _dONGIATMDCDB1P1, Decimal _dONGIATMDCKC, Decimal _dONGIATMDCKP1, Decimal _dONGIATMDCDBAC, Decimal _dONGIATMGMDBAP1, Decimal _dONGIATMGMDBAP2, Decimal _dONGIATMGMDBBC, Decimal _dONGIATMGMDBBP1, Decimal _dONGIATMGMDBBP2, Decimal _dONGIATMGMDBCC, Decimal _dONGIATMGMDBCP1, Decimal _dONGIATMGMDBCP2, Decimal _dONGIATMGMIC, Decimal _dONGIATMGMDB1P1, Decimal _dONGIATMGMKC, Decimal _dONGIATMGMKP1, Decimal _dONGIATMGMDBAC, Decimal _dONGIATMCECDBAP1, Decimal _dONGIATMCECDBAP2, Decimal _dONGIATMCECDBBC, Decimal _dONGIATMCECDBBP1, Decimal _dONGIATMCECDBBP2, Decimal _dONGIATMCECDBCC, Decimal _dONGIATMCECDBCP1, Decimal _dONGIATMCECDBCP2, Decimal _dONGIATMCECIC, Decimal _dONGIATMCECDB1P1, Decimal _dONGIATMCECKC, Decimal _dONGIATMCECKP1, Decimal _dONGIATMCECDBAC, Decimal _dONGIATMDB1P2, Decimal _dONGIATMKP2, Decimal _dONGIATMDCDB1P2, Decimal _dONGIATMDCKP2, Decimal _dONGIATMCECDB1P2, Decimal _dONGIATMCECKP2, Decimal _dONGIATMGMDB1P2, Decimal _dONGIATMGMKP2, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, String _maMay);
				// public override void UpdateThamSoLuong(Decimal _mucLuongCB, Decimal _bHYT, Decimal _bHXH, Decimal _congDoan, Decimal _heSoThamNien, Decimal _donGiaTruc, Decimal _donGiaXQuang, Decimal _donGiaM2, Decimal _donGiaNTHSCC, Decimal _donGiaNNHSCC, Decimal _donGiaNLHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _donGiaND1142002HSCC, Decimal _donGiaNTCM, Decimal _donGiaNNCM, Decimal _donGiaNLCM, Decimal _donGiaQCCTNBCM, Decimal _donGiaNTLD, Decimal _donGiaNNLD, Decimal _donGiaNLLD, Decimal _donGiaCocIHSCC, Decimal _donGiaCocIIHSCC, Decimal _donGiaDDHSCC, Decimal _donGiaCocICM, Decimal _donGiaCocIICM, Decimal _donGiaDDCM, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _heSoPTHS, Decimal _dONGIAA, Decimal _dONGIAB, Decimal _dONGIAC, Decimal _mucTTThue, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _dONGIADBAC, Decimal _dONGIADCDBAP1, Decimal _dONGIADCDBAP2, Decimal _dONGIADCDBBC, Decimal _dONGIADCDBBP1, Decimal _dONGIADCDBBP2, Decimal _dONGIADCDBCC, Decimal _dONGIADCDBCP1, Decimal _dONGIADCDBCP2, Decimal _dONGIADCIC, Decimal _dONGIADCDB1P1, Decimal _dONGIADCKC, Decimal _dONGIADCKP1, Decimal _dONGIADCDBAC, Decimal _dONGIAGMDBAP1, Decimal _dONGIAGMDBAP2, Decimal _dONGIAGMDBBC, Decimal _dONGIAGMDBBP1, Decimal _dONGIAGMDBBP2, Decimal _dONGIAGMDBCC, Decimal _dONGIAGMDBCP1, Decimal _dONGIAGMDBCP2, Decimal _dONGIAGMIC, Decimal _dONGIAGMDB1P1, Decimal _dONGIAGMKC, Decimal _dONGIAGMKP1, Decimal _dONGIAGMDBAC, Decimal _dONGIACECDBAP1, Decimal _dONGIACECDBAP2, Decimal _dONGIACECDBBC, Decimal _dONGIACECDBBP1, Decimal _dONGIACECDBBP2, Decimal _dONGIACECDBCC, Decimal _dONGIACECDBCP1, Decimal _dONGIACECDBCP2, Decimal _dONGIACECIC, Decimal _dONGIACECDB1P1, Decimal _dONGIACECKC, Decimal _dONGIACECKP1, Decimal _dONGIACECDBAC, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _mucLuongDocHai, Decimal _dONGIADCDB1P2, Decimal _dONGIADCKP2, Decimal _dONGIACECDB1P2, Decimal _dONGIACECKP2, Decimal _dONGIAGMDB1P2, Decimal _dONGIAGMKP2, Decimal _dONGIATMDBAP1, Decimal _dONGIATMDBAP2, Decimal _dONGIATMDBBC, Decimal _dONGIATMDBBP1, Decimal _dONGIATMDBBP2, Decimal _dONGIATMDBCC, Decimal _dONGIATMDBCP1, Decimal _dONGIATMDBCP2, Decimal _dONGIATMIC, Decimal _dONGIATMDB1P1, Decimal _dONGIATMKC, Decimal _dONGIATMKP1, Decimal _dONGIATMDBAC, Decimal _dONGIATMDCDBAP1, Decimal _dONGIATMDCDBAP2, Decimal _dONGIATMDCDBBC, Decimal _dONGIATMDCDBBP1, Decimal _dONGIATMDCDBBP2, Decimal _dONGIATMDCDBCC, Decimal _dONGIATMDCDBCP1, Decimal _dONGIATMDCDBCP2, Decimal _dONGIATMDCIC, Decimal _dONGIATMDCDB1P1, Decimal _dONGIATMDCKC, Decimal _dONGIATMDCKP1, Decimal _dONGIATMDCDBAC, Decimal _dONGIATMGMDBAP1, Decimal _dONGIATMGMDBAP2, Decimal _dONGIATMGMDBBC, Decimal _dONGIATMGMDBBP1, Decimal _dONGIATMGMDBBP2, Decimal _dONGIATMGMDBCC, Decimal _dONGIATMGMDBCP1, Decimal _dONGIATMGMDBCP2, Decimal _dONGIATMGMIC, Decimal _dONGIATMGMDB1P1, Decimal _dONGIATMGMKC, Decimal _dONGIATMGMKP1, Decimal _dONGIATMGMDBAC, Decimal _dONGIATMCECDBAP1, Decimal _dONGIATMCECDBAP2, Decimal _dONGIATMCECDBBC, Decimal _dONGIATMCECDBBP1, Decimal _dONGIATMCECDBBP2, Decimal _dONGIATMCECDBCC, Decimal _dONGIATMCECDBCP1, Decimal _dONGIATMCECDBCP2, Decimal _dONGIATMCECIC, Decimal _dONGIATMCECDB1P1, Decimal _dONGIATMCECKC, Decimal _dONGIATMCECKP1, Decimal _dONGIATMCECDBAC, Decimal _dONGIATMDB1P2, Decimal _dONGIATMKP2, Decimal _dONGIATMDCDB1P2, Decimal _dONGIATMDCKP2, Decimal _dONGIATMCECDB1P2, Decimal _dONGIATMCECKP2, Decimal _dONGIATMGMDB1P2, Decimal _dONGIATMGMKP2, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, String _maMay);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _mucLuongCB, _bHYT, _bHXH, _congDoan, _heSoThamNien, _donGiaTruc, _donGiaXQuang, _donGiaM2, _donGiaNTHSCC, _donGiaNNHSCC, _donGiaNLHSCC, _donGiaQCCTNBHSCC, _donGiaND1142002HSCC, _donGiaNTCM, _donGiaNNCM, _donGiaNLCM, _donGiaQCCTNBCM, _donGiaNTLD, _donGiaNNLD, _donGiaNLLD, _donGiaCocIHSCC, _donGiaCocIIHSCC, _donGiaDDHSCC, _donGiaCocICM, _donGiaCocIICM, _donGiaDDCM, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _dONGIANVien, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _heSoPTHS, _dONGIAA, _dONGIAB, _dONGIAC, _mucTTThue, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _dONGIADBAC, _dONGIADCDBAP1, _dONGIADCDBAP2, _dONGIADCDBBC, _dONGIADCDBBP1, _dONGIADCDBBP2, _dONGIADCDBCC, _dONGIADCDBCP1, _dONGIADCDBCP2, _dONGIADCIC, _dONGIADCDB1P1, _dONGIADCKC, _dONGIADCKP1, _dONGIADCDBAC, _dONGIAGMDBAP1, _dONGIAGMDBAP2, _dONGIAGMDBBC, _dONGIAGMDBBP1, _dONGIAGMDBBP2, _dONGIAGMDBCC, _dONGIAGMDBCP1, _dONGIAGMDBCP2, _dONGIAGMIC, _dONGIAGMDB1P1, _dONGIAGMKC, _dONGIAGMKP1, _dONGIAGMDBAC, _dONGIACECDBAP1, _dONGIACECDBAP2, _dONGIACECDBBC, _dONGIACECDBBP1, _dONGIACECDBBP2, _dONGIACECDBCC, _dONGIACECDBCP1, _dONGIACECDBCP2, _dONGIACECIC, _dONGIACECDB1P1, _dONGIACECKC, _dONGIACECKP1, _dONGIACECDBAC, _donGiaAnTrua, _donGiaAnToi, _mucLuongDocHai, _dONGIADCDB1P2, _dONGIADCKP2, _dONGIACECDB1P2, _dONGIACECKP2, _dONGIAGMDB1P2, _dONGIAGMKP2, _dONGIATMDBAP1, _dONGIATMDBAP2, _dONGIATMDBBC, _dONGIATMDBBP1, _dONGIATMDBBP2, _dONGIATMDBCC, _dONGIATMDBCP1, _dONGIATMDBCP2, _dONGIATMIC, _dONGIATMDB1P1, _dONGIATMKC, _dONGIATMKP1, _dONGIATMDBAC, _dONGIATMDCDBAP1, _dONGIATMDCDBAP2, _dONGIATMDCDBBC, _dONGIATMDCDBBP1, _dONGIATMDCDBBP2, _dONGIATMDCDBCC, _dONGIATMDCDBCP1, _dONGIATMDCDBCP2, _dONGIATMDCIC, _dONGIATMDCDB1P1, _dONGIATMDCKC, _dONGIATMDCKP1, _dONGIATMDCDBAC, _dONGIATMGMDBAP1, _dONGIATMGMDBAP2, _dONGIATMGMDBBC, _dONGIATMGMDBBP1, _dONGIATMGMDBBP2, _dONGIATMGMDBCC, _dONGIATMGMDBCP1, _dONGIATMGMDBCP2, _dONGIATMGMIC, _dONGIATMGMDB1P1, _dONGIATMGMKC, _dONGIATMGMKP1, _dONGIATMGMDBAC, _dONGIATMCECDBAP1, _dONGIATMCECDBAP2, _dONGIATMCECDBBC, _dONGIATMCECDBBP1, _dONGIATMCECDBBP2, _dONGIATMCECDBCC, _dONGIATMCECDBCP1, _dONGIATMCECDBCP2, _dONGIATMCECIC, _dONGIATMCECDB1P1, _dONGIATMCECKC, _dONGIATMCECKP1, _dONGIATMCECDBAC, _dONGIATMDB1P2, _dONGIATMKP2, _dONGIATMDCDB1P2, _dONGIATMDCKP2, _dONGIATMCECDB1P2, _dONGIATMCECKP2, _dONGIATMGMDB1P2, _dONGIATMGMKP2, _huy, _ngaySD.DBValue, _nguoiSD , _maMay);
				// }				
			}
		}
		

		/// <summary>
		/// Delete the <see cref="ThamSoLuong" />.
		/// </summary>
		

		#endregion
	}

}
