// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_PT
// Kieu doi tuong  :	Luong_PT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/29/2009 9:27:28 AM
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

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_PT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_PT : BusinessBase<Luong_PT>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Byte _vaiTro = 0;
        private Decimal _dBAC = 0;
        private Decimal _dBAP1 = 0;
        private Decimal _dBAP2 = 0;
        private Decimal _tHHANHTIENA = 0;
        private Decimal _dBBC = 0;
        private Decimal _dBBP1 = 0;
        private Decimal _dBBP2 = 0;
        private Decimal _tHHANHTIENB = 0;
        private Decimal _dBCC = 0;
        private Decimal _dBCP1 = 0;
        private Decimal _dBCP2 = 0;
        private Decimal _tHHANHTIENC = 0;
        private Decimal _ic = 0;
        private Decimal _dB1P1 = 0;
        private Decimal _dB1P2 = 0;
        private Decimal _tHHANHTIENI = 0;
        private Decimal _kc = 0;
        private Decimal _kP1 = 0;
        private Decimal _kP2 = 0;
        private Decimal _tHHANHTIENK = 0;
        private Decimal _dONGIADBAC = 0;
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
        private Decimal _dONGIADB1P2 = 0;
        private Decimal _dONGIAKC = 0;
        private Decimal _dONGIAKP1 = 0;
        private Decimal _dONGIAKP2 = 0;
        private Decimal _tong = 0;
		private String _maMay = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _huy = false;
        private String _hoten = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private SmartDate _ngaySinh = new SmartDate(true);
        private Boolean  _gioitinh = false;
        private String _gioitinhD =  String.Empty;
        private int _OrderNumber;
        private Decimal _dONGIAGMTE = 0;
        private Decimal _kTE = 0;

		#endregion
		
		#region Business Properties and Methods
		
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
				}
			}
		}
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public String Makhoa
		{
			get 
			{
				CanReadProperty("Makhoa", true);
				return _makhoa;
			}
			set 
			{
				CanWriteProperty("Makhoa", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					PropertyHasChanged("Makhoa");
				}
			}
		}
        public Byte VaiTro
        {
            get
            {
                CanReadProperty("VaiTro", true);
                return _vaiTro;
            }
            set
            {
                CanWriteProperty("VaiTro", true);
                if (_vaiTro != value)
                {
                    _vaiTro = value;
                    PropertyHasChanged("VaiTro");
                }
            }
        }
        public string  DBAC
        {
            get
            {
                CanReadProperty("DBAC", true);
                if (_dBAC  == 0)
                {
                    return "";
                }
                else if (_dBAC - (int)(_dBAC) != 0)
                    return _dBAC.ToString("###,##0.##");
                else
                    return _dBAC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DBAC", true);

                if (_dBAC.ToString() != value)
                {
                    if (value == "")
                        _dBAC = 0;
                    else
                        _dBAC = decimal .Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBAC");
                }
            }
        }
       

        public string  DBAP1
        {
            get
            {
                CanReadProperty("DBAP1", true);
                if (_dBAP1 == 0)
                {
                    return "";
                }
            
                else
                    return _dBAP1.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBAP1", true);

                if (_dBAP1.ToString() != value)
                {
                    if (value == "")
                        _dBAP1 = 0;
                    else
                        _dBAP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBAP1");
                }
            }
        }

        public string  DBAP2
        {
            get
            {
                CanReadProperty("DBAP2", true);
                if (_dBAP2 == 0)
                {
                    return "";
                }
               
                else
                    return _dBAP2.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBAP2", true);

                if (_dBAP2.ToString() != value)
                {
                    if (value == "")
                        _dBAP2 = 0;
                    else
                        _dBAP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBAP2");
                }
            }
        }
        public string THHANHTIENA
        {
           
            get
            {
                CanReadProperty("THHANHTIENA", true);
                _tHHANHTIENA = (_dBAC * _dONGIADBAC) + (_dBAP1 * _dONGIADBAP1) + (_dBAP2 * _dONGIADBAP2);
                //return _tongSoTheo.ToString("###,###");
                if (_tHHANHTIENA == 0)
                {
                    return "";
                }
                else
                {
                    return _tHHANHTIENA.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("THHANHTIENA", true);

                if (_tHHANHTIENA.ToString() != value)
                {
                    if (value == "")
                        _tHHANHTIENA = 0;
                    else
                        _tHHANHTIENA = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENA");
                }
            }
        }

        public string  DBBC
        {
            get
            {
                CanReadProperty("DBBC", true);
                if (_dBBC == 0)
                {
                    return "";
                }
              
                else
                    return _dBBC.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBBC", true);

                if (_dBBC.ToString() != value)
                {
                    if (value == "")
                        _dBBC = 0;
                    else
                        _dBBC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBBC");
                }
            }
        }

        public string  DBBP1
        {
            get
            {
                CanReadProperty("DBBP1", true);
                if (_dBBP1 == 0)
                {
                    return "";
                }
               
                else
                    return _dBBP1.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBBP1", true);

                if (_dBBP1.ToString() != value)
                {
                    if (value == "")
                        _dBBP1 = 0;
                    else
                        _dBBP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBBP1");
                }
            }
        }
        public string  DBBP2
        {
            get
            {
                CanReadProperty("DBBP2", true);
                if (_dBBP2 == 0)
                {
                    return "";
                }
              
                else
                    return _dBBP2.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBBP2", true);

                if (_dBBP2.ToString() != value)
                {
                    if (value == "")
                        _dBBP2 = 0;
                    else
                        _dBBP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBBP2");
                }
            }
        }
        public string THHANHTIENB
        {
            get
            {
                CanReadProperty("THHANHTIENB", true);
                _tHHANHTIENB = (_dBBC * _dONGIADBBC) + (_dBBP1 * _dONGIADBBP1) + (_dBBP2 * _dONGIADBBP2);
                if (_tHHANHTIENB == 0)
                {
                    return "";
                }
                else
                {
                    return _tHHANHTIENB.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("THHANHTIENB", true);

                if (_tHHANHTIENB.ToString() != value)
                {
                    if (value == "")
                        _tHHANHTIENB = 0;
                    else
                        _tHHANHTIENB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENB");
                }
            }
        }
        public string DBCC
        {
            get
            {
                CanReadProperty("DBCC", true);
                if (_dBCC == 0)
                {
                    return "";
                }
              
                else
                    return _dBCC.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DBCC", true);

                if (_dBCC.ToString() != value)
                {
                    if (value == "")
                        _dBCC = 0;
                    else
                        _dBCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBCC");
                }
            }
        }

        public string DBCP1
        {
            get
            {
                CanReadProperty("DBCP1", true);
                if (_dBCP1 == 0)
                {
                    return "";
                }
              
                else
                    return _dBCP1.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DBCP1", true);

                if (_dBCP1.ToString() != value)
                {
                    if (value == "")
                        _dBCP1 = 0;
                    else
                        _dBCP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBCP1");
                }
            }
        }
        public string DBCP2
        {
            get
            {
                CanReadProperty("DBCP2", true);
                if (_dBCP2 == 0)
                {
                    return "";
                }
               
                else
                    return _dBCP2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DBCP2", true);

                if (_dBCP2.ToString() != value)
                {
                    if (value == "")
                        _dBCP2 = 0;
                    else
                        _dBCP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DBCP2");
                }
            }
        }

        public string THHANHTIENC
        {
            get
            {
                CanReadProperty("THHANHTIENC", true);
                _tHHANHTIENC = (_dBCC * _dONGIADBCC) + (_dBCP1 * _dONGIADBCP1) + (_dBCP2 * _dONGIADBCP2);
                if (_tHHANHTIENC == 0)
                {
                    return "";
                }
                else
                {
                    return _tHHANHTIENC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("THHANHTIENC", true);

                if (_tHHANHTIENC.ToString() != value)
                {
                    if (value == "")
                        _tHHANHTIENC = 0;
                    else
                        _tHHANHTIENB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENC");
                }
            }
        }
        public string  IC
        {
            get
            {
                CanReadProperty("IC", true);
                if (_ic == 0)
                {
                    return "";
                }
                
                else
                    return _ic.ToString("###,###");
            }
            set
            {
                CanWriteProperty("IC", true);

                if (_ic.ToString() != value)
                {
                    if (value == "")
                        _ic = 0;
                    else
                        _ic = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("IC");
                }
            }
        }

        public string  DB1P1
        {
            get
            {
                CanReadProperty("DB1P1", true);
                if (_dB1P1 == 0)
                {
                    return "";
                }
              
                else
                    return _dB1P1.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DB1P1", true);

                if (_dB1P1.ToString() != value)
                {
                    if (value == "")
                        _dB1P1 = 0;
                    else
                        _dB1P1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DB1P1");
                }
            }
        }
        public string dB1P2
        {
            get
            {
                CanReadProperty("dB1P2", true);
                if (_dBBP2 == 0)
                {
                    return "";
                }

                else
                    return _dB1P2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("dB1P2", true);

                if (_dB1P2.ToString() != value)
                {
                    if (value == "")
                        _dB1P2 = 0;
                    else
                        _dB1P2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("dB1P2");
                }
            }
        }
        public string THHANHTIENI
        {
            get
            {
                CanReadProperty("THHANHTIENI", true);
                _tHHANHTIENI = (_ic * _dONGIAIC) + (_dB1P1 * _dONGIADB1P1)+ (_dB1P2*_dONGIADB1P2 );
                if (_tHHANHTIENI == 0)
                {
                    return "";
                }
                else
                {
                    return _tHHANHTIENI.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("THHANHTIENI", true);

                if (_tHHANHTIENI.ToString() != value)
                {
                    if (value == "")
                        _tHHANHTIENI = 0;
                    else
                        _tHHANHTIENI = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENI");
                }
            }
        }
        public string  KC
        {
            get
            {
                CanReadProperty("KC", true);
                if (_kc == 0)
                {
                    return "";
                }
               
                else
                    return _kc.ToString("###,###");
            }
            set
            {
                CanWriteProperty("KC", true);

                if (_kc.ToString() != value)
                {
                    if (value == "")
                        _kc = 0;
                    else
                        _kc = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KC");
                }
            }
        }


        public string  KP1
        {
            get
            {
                CanReadProperty("KP1", true);
                if (_kP1 == 0)
                {
                    return "";
                }
              
                else
                    return _kP1.ToString("###,###");
            }
            set
            {
                CanWriteProperty("KP1", true);

                if (_kP1.ToString() != value)
                {
                    if (value == "")
                        _kP1 = 0;
                    else
                        _kP1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KP1");
                }
            }
        }
        public string kp2
        {
            get
            {
                CanReadProperty("kp2", true);
                if (_kP2 == 0)
                {
                    return "";
                }

                else
                    return _kP2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("kp2", true);

                if (_kP2.ToString() != value)
                {
                    if (value == "")
                        _kP2 = 0;
                    else
                        _kP2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("kp2");
                }
            }
        }
        public string THHANHTIENK
        {
            get
            {
                CanReadProperty("THHANHTIENK", true);
                _tHHANHTIENK = (_kc * _dONGIAKC) + (_kP1 * _dONGIAKP1)+ (_kP2*_dONGIAKP2 ) + (_kTE *_dONGIAGMTE );
                if (_tHHANHTIENK == 0)
                {
                    return "";
                }
                else
                {
                    return _tHHANHTIENK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("THHANHTIENK", true);

                if (_tHHANHTIENK.ToString() != value)
                {
                    if (value == "")
                        _tHHANHTIENK = 0;
                    else
                        _tHHANHTIENK = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENK");
                }
            }
        }
        public Decimal DONGIADBAC
        {
            get
            {
                CanReadProperty("DONGIADBAC", true);
                return _dONGIADBAC;
            }
            set
            {
                CanWriteProperty("DONGIADBAC", true);
                if (_dONGIADBAC != value)
                {
                    _dONGIADBAC = value;
                    PropertyHasChanged("DONGIADBAC");
                }
            }
        }

        public Decimal DONGIADBAP1
        {
            get
            {
                CanReadProperty("DONGIADBAP1", true);
                return _dONGIADBAP1;
            }
            set
            {
                CanWriteProperty("DONGIADBAP1", true);
                if (_dONGIADBAP1 != value)
                {
                    _dONGIADBAP1 = value;
                    PropertyHasChanged("DONGIADBAP1");
                }
            }
        }

        public Decimal DONGIADBAP2
        {
            get
            {
                CanReadProperty("DONGIADBAP2", true);
                return _dONGIADBAP2;
            }
            set
            {
                CanWriteProperty("DONGIADBAP2", true);
                if (_dONGIADBAP2 != value)
                {
                    _dONGIADBAP2 = value;
                    PropertyHasChanged("DONGIADBAP2");
                }
            }
        }

        public Decimal DONGIADBBC
        {
            get
            {
                CanReadProperty("DONGIADBBC", true);
                return _dONGIADBBC;
            }
            set
            {
                CanWriteProperty("DONGIADBBC", true);
                if (_dONGIADBBC != value)
                {
                    _dONGIADBBC = value;
                    PropertyHasChanged("DONGIADBBC");
                }
            }
        }

        public Decimal DONGIADBBP1
        {
            get
            {
                CanReadProperty("DONGIADBBP1", true);
                return _dONGIADBBP1;
            }
            set
            {
                CanWriteProperty("DONGIADBBP1", true);
                if (_dONGIADBBP1 != value)
                {
                    _dONGIADBBP1 = value;
                    PropertyHasChanged("DONGIADBBP1");
                }
            }
        }

        public Decimal DONGIADBBP2
        {
            get
            {
                CanReadProperty("DONGIADBBP2", true);
                return _dONGIADBBP2;
            }
            set
            {
                CanWriteProperty("DONGIADBBP2", true);
                if (_dONGIADBBP2 != value)
                {
                    _dONGIADBBP2 = value;
                    PropertyHasChanged("DONGIADBBP2");
                }
            }
        }

        public Decimal DONGIADBCC
        {
            get
            {
                CanReadProperty("DONGIADBCC", true);
                return _dONGIADBCC;
            }
            set
            {
                CanWriteProperty("DONGIADBCC", true);
                if (_dONGIADBCC != value)
                {
                    _dONGIADBCC = value;
                    PropertyHasChanged("DONGIADBCC");
                }
            }
        }

        public Decimal DONGIADBCP1
        {
            get
            {
                CanReadProperty("DONGIADBCP1", true);
                return _dONGIADBCP1;
            }
            set
            {
                CanWriteProperty("DONGIADBCP1", true);
                if (_dONGIADBCP1 != value)
                {
                    _dONGIADBCP1 = value;
                    PropertyHasChanged("DONGIADBCP1");
                }
            }
        }

        public Decimal DONGIADBCP2
        {
            get
            {
                CanReadProperty("DONGIADBCP2", true);
                return _dONGIADBCP2;
            }
            set
            {
                CanWriteProperty("DONGIADBCP2", true);
                if (_dONGIADBCP2 != value)
                {
                    _dONGIADBCP2 = value;
                    PropertyHasChanged("DONGIADBCP2");
                }
            }
        }

        public Decimal DONGIAIC
        {
            get
            {
                CanReadProperty("DONGIAIC", true);
                return _dONGIAIC;
            }
            set
            {
                CanWriteProperty("DONGIAIC", true);
                if (_dONGIAIC != value)
                {
                    _dONGIAIC = value;
                    PropertyHasChanged("DONGIAIC");
                }
            }
        }

        public Decimal DONGIADB1P1
        {
            get
            {
                CanReadProperty("DONGIADB1P1", true);
                return _dONGIADB1P1;
            }
            set
            {
                CanWriteProperty("DONGIADB1P1", true);
                if (_dONGIADB1P1 != value)
                {
                    _dONGIADB1P1 = value;
                    PropertyHasChanged("DONGIADB1P1");
                }
            }
        }
        public Decimal DONGIADB1P2
        {
            get
            {
                CanReadProperty("DONGIADB1P2", true);
                return _dONGIADB1P2;
            }
            set
            {
                CanWriteProperty("DONGIADB1P2", true);
                if (_dONGIADB1P2 != value)
                {
                    _dONGIADB1P2 = value;
                    PropertyHasChanged("DONGIADB1P2");
                }
            }
        }

        public Decimal DONGIAKC
        {
            get
            {
                CanReadProperty("DONGIAKC", true);
                return _dONGIAKC;
            }
            set
            {
                CanWriteProperty("DONGIAKC", true);
                if (_dONGIAKC != value)
                {
                    _dONGIAKC = value;
                    PropertyHasChanged("DONGIAKC");
                }
            }
        }

        public Decimal DONGIAKP1
        {
            get
            {
                CanReadProperty("DONGIAKP1", true);
                return _dONGIAKP1;
            }
            set
            {
                CanWriteProperty("DONGIAKP1", true);
                if (_dONGIAKP1 != value)
                {
                    _dONGIAKP1 = value;
                    PropertyHasChanged("DONGIAKP1");
                }
            }
        }
        public Decimal DONGIAKP2
        {
            get
            {
                CanReadProperty("DONGIAKP2", true);
                return _dONGIAKP2;
            }
            set
            {
                CanWriteProperty("DONGIAKP2", true);
                if (_dONGIAKP2 != value)
                {
                    _dONGIAKP2 = value;
                    PropertyHasChanged("DONGIAKP2");
                }
            }
        }


        public string Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = _tHHANHTIENA + _tHHANHTIENB + _tHHANHTIENC + _tHHANHTIENI + _tHHANHTIENK;
                if (_tong == 0)
                {
                    return "";
                }
                else
                {
                    return _tong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_tong.ToString() != value)
                {
                    if (value == "")
                        _tong = 0;
                    else
                        _tong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tong");
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
				return _ngayLap.Text;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text != value) 
				{
					_ngayLap.Text = value;
					PropertyHasChanged("NgayLap");
				}
			}
		}
		
		public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
				}
			}
		}
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
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
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }
        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _tenChuyenMon;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_tenChuyenMon != value)
                {
                    _tenChuyenMon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }
        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _tenLoaiHD;
            }
            set
            {
                CanWriteProperty("TenLoaiHD", true);
                if (_tenLoaiHD != value)
                {
                    _tenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public Boolean  GioiTinh
        {
            get
            {
                
                return _gioitinh ;
            }
            set
            {
                if (_gioitinh != value)
                {
                    _gioitinh = value;
                }
            }
        }
        public String GioiTinhD
        {
            get
            {

                if (_gioitinh == true)
                {
                    return "Nam";
                }
                else
                    return "Nữ";

            }
           
        }
        public Decimal DONGIAGMTE
        {
            get
            {
                CanReadProperty("DONGIAGMTE", true);
                return _dONGIAGMTE ;
            }
            set
            {
                CanWriteProperty("DONGIAGMTE", true);
                if (_dONGIAGMTE != value)
                {
                    _dONGIAGMTE = value;
                    PropertyHasChanged("DONGIAGMTE");
                }
            }
        }
        public string KTE
        {
            get
            {
                CanReadProperty("KTE", true);
                if (_kTE  == 0)
                {
                    return "";
                }

                else
                    return _kTE.ToString("###,###");

            }
            set
            {
                CanWriteProperty("KTE", true);

                if (_kTE.ToString() != value)
                {
                    if (value == "")
                        _kTE = 0;
                    else
                        _kTE = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KTE");
                }
            }
        }
       

        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
		protected override Object GetIdValue()
		{
            return _sTT.ToString() + "!" + _thang.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_PT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_PT NewLuong_PT()
        {
            return new Luong_PT();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_PT GetLuong_PT(SafeDataReader dr, int i)
        {
            return new Luong_PT(dr, i);
        }
        //public static Luong_PT GetLuong_PT(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_PT>(new Criteria(sTT, thang));
        //}
        public Luong_PT()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_PT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_PT(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_PT()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private SmartDate _thang;
			public SmartDate Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			public Criteria(Int32 sTT, SmartDate thang)
			{
				_sTT = sTT;
				_thang = thang;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_thang.Equals(c._thang)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _thang.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class CriteriaOther
        {
            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }
           
            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public CriteriaOther(String Mamay, String Nguoisd, Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }


        } 

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
		/// Retrieve an existing <see cref="Luong_PT" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_PT(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_PT(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_PT(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_PT" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_PTCB") != null) _mucLuong_PTCB = dr.GetDecimal("MucLuong_PTCB");
        //    if (dr.GetDecimal("HeSoLuong_PT") != null) _heSoLuong_PT = dr.GetDecimal("HeSoLuong_PT");
        //    if (dr.GetDecimal("HeSoPC") != null) _heSoPC = dr.GetDecimal("HeSoPC");
        //    if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
        //    if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
        //    if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
        //    if (dr.GetDecimal("AnToi") != null) _anToi = dr.GetDecimal("AnToi");
        //    if (dr.GetDecimal("AnTrua") != null) _anTrua = dr.GetDecimal("AnTrua");
        //    if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
        //    if (dr.GetDecimal("MucPCBoiDuong") != null) _mucPCBoiDuong = dr.GetDecimal("MucPCBoiDuong");
        //    if (dr.GetDecimal("HeSoPCTrachNhiem") != null) _heSoPCTrachNhiem = dr.GetDecimal("HeSoPCTrachNhiem");
        //    if (dr.GetDecimal("TienNgoaiGio") != null) _tienNgoaiGio = dr.GetDecimal("TienNgoaiGio");
        //    if (dr.GetDecimal("TienPC") != null) _tienPC = dr.GetDecimal("TienPC");
        //    if (dr.GetDecimal("TienTruc") != null) _tienTruc = dr.GetDecimal("TienTruc");
        //    if (dr.GetDecimal("TienLamDem") != null) _tienLamDem = dr.GetDecimal("TienLamDem");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //}
        private Luong_PT(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetByte("VaiTro") != null) _vaiTro = dr.GetByte("VaiTro");
            if (dr.GetDecimal("DBAC") != null) _dBAC = dr.GetDecimal("DBAC");
            if (dr.GetDecimal("DBAP1") != null) _dBAP1 = dr.GetDecimal("DBAP1");
            if (dr.GetDecimal("DBAP2") != null) _dBAP2 = dr.GetDecimal("DBAP2");
            if (dr.GetDecimal("DBBC") != null) _dBBC = dr.GetDecimal("DBBC");
            if (dr.GetDecimal("DBBP1") != null) _dBBP1 = dr.GetDecimal("DBBP1");
            if (dr.GetDecimal("DBBP2") != null) _dBBP2 = dr.GetDecimal("DBBP2");
            if (dr.GetDecimal("DBCC") != null) _dBCC = dr.GetDecimal("DBCC");
            if (dr.GetDecimal("DBCP1") != null) _dBCP1 = dr.GetDecimal("DBCP1");
            if (dr.GetDecimal("DBCP2") != null) _dBCP2 = dr.GetDecimal("DBCP2");
            if (dr.GetDecimal("IC") != null) _ic = dr.GetDecimal("IC");
            if (dr.GetDecimal("DB1P1") != null) _dB1P1 = dr.GetDecimal("DB1P1");
            if (dr.GetDecimal("KC") != null) _kc = dr.GetDecimal("KC");
            if (dr.GetDecimal("KP1") != null) _kP1 = dr.GetDecimal("KP1");
            if (dr.GetDecimal("DONGIADBAC") != null) _dONGIADBAC = dr.GetDecimal("DONGIADBAC");
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
            if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("TenLoaiHD");
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetBoolean("GioiTinh") != null) _gioitinh = dr.GetBoolean("GioiTinh");
            if (dr.GetDecimal("DB1p2")!= null ) _dB1P2 = dr.GetDecimal("DB1P2");
            if (dr.GetDecimal("dONGIADB1P2") != null) _dONGIADB1P2 = dr.GetDecimal("dONGIADB1P2");
            if (dr.GetDecimal("kp2") != null) _kP2  = dr.GetDecimal("Kp2");
            if (dr.GetDecimal("dONGIAKP2") != null) _dONGIAKP2 = dr.GetDecimal("dONGIAKP2");
            if (dr.GetDecimal("DONGIAGMTE") != null) _dONGIAGMTE = dr.GetDecimal("DONGIAGMTE");
            if (dr.GetDecimal("KTE") != null) _kTE = dr.GetDecimal("KTE");

            //if (dr.GetSmartDate("GioiTinh", true) != null) _gioitinhD = dr.GetSmartDate("GioiTinh", true);
            

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_PT" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
             DataProvider.Instance().InsertLuong_PT(_thang, _maNV, _makhoa, _vaiTro, _dBAC, _dBAP1, _dBAP2, _dBBC, _dBBP1, _dBBP2, _dBCC, _dBCP1, _dBCP2, _ic, _dB1P1, _kc, _kP1, _dONGIADBAC, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _tong, _maMay, _nguoiSD , _dB1P2,  _kP2,  _dONGIADB1P2,  _dONGIAKP2, _dONGIAGMTE, _kTE  );
            // public abstract Int32 InsertLuong_PT(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa,Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_PT(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa,Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_PT_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa,_vaiTro, _dBAC, _dBAP1, _dBAP2, _dBBC, _dBBP1, _dBBP2, _dBCC, _dBCP1, _dBCP2, _ic, _dB1P1, _kc, _kP1, _dONGIADBAC, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _tong, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_PT" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_PT(_sTT, _thang, _maNV, _makhoa, _vaiTro, _dBAC, _dBAP1, _dBAP2, _dBBC, _dBBP1, _dBBP2, _dBCC, _dBCP1, _dBCP2, _ic, _dB1P1, _kc, _kP1, _dONGIADBAC, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _tong, _maMay, _nguoiSD , _huy, _dB1P2, _kP2, _dONGIADB1P2, _dONGIAKP2, _dONGIAGMTE ,_kTE );
                // public abstract void UpdateLuong_PT(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa,Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_PT(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa,Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_PT_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa,_vaiTro, _dBAC, _dBAP1, _dBAP2, _dBBC, _dBBP1, _dBBP2, _dBCC, _dBCP1, _dBCP2, _ic, _dB1P1, _kc, _kP1, _dONGIADBAC, _dONGIADBAP1, _dONGIADBAP2, _dONGIADBBC, _dONGIADBBP1, _dONGIADBBP2, _dONGIADBCC, _dONGIADBCP1, _dONGIADBCP2, _dONGIAIC, _dONGIADB1P1, _dONGIAKC, _dONGIAKP1, _tong, _maMay, _nguoiSD , _huy);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _sTT, _thang));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="Luong_PT" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_PT
            DataProvider.Instance().DeleteLuong_PT(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_PT(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_PT(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_PT_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
