// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongKe_BenhNhan_NgoaiTru_Info
// Kieu doi tuong  :	ThongKe_BenhNhan_NgoaiTru_Info
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongKe_BenhNhan_NgoaiTru_Info" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class ThongKe_BenhNhan_NgoaiTru_Info : BusinessBase<ThongKe_BenhNhan_NgoaiTru_Info>
	{
		#region Business Methods
		private String _maKhoa= String.Empty ;
        private String _tenKhoa = String.Empty;
        private Int32  _soLuotDK = 0;
        private Int32 _soLuotDKC = 0;
        private Int32 _soLuotTTC = 0;
        private Int32 _soLuotTT = 0;
        private Int32 _soLuotCK = 0;
        private Int32  _soLuotCKC = 0;
        private Int32 _soLuotTD = 0;
        private Int32 _soLuotTDC = 0;
        private Int32 _soLuotDangK = 0;
        private int _OrderNumber;

		#region State Fields
		#endregion
		
		#region Business Properties and Methods
       
        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _maKhoa;
            }
            set
            {
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                }
            }
        }
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                }
            }
        }


        public string SoLuotDK
        {
            get
            {
                CanReadProperty("SoLuotDK", true);
                if (_soLuotDK == 0)
                {
                    return "";
                    }

                else

                        return _soLuotDK.ToString("###,###");
            }
            set
            {
                if (_soLuotDK.ToString() != value)
                {
                    _soLuotDK = int .Parse(value);
                }
            }
        }

        public string SoLuotDKC
        {
            get
            {
                CanReadProperty("SoLuotDKC", true);
                if (_soLuotDKC == 0)
                {
                    return "";
                }

                else

                    return _soLuotDKC.ToString("###,###");
            }
            set
            {
                if (_soLuotDKC.ToString() != value)
                {
                    _soLuotDKC = int.Parse(value);
                }
            }
        }

        public string SoLuotDangK
        {
            get
            {
                CanReadProperty("SoLuotDangK", true);
                if (_soLuotDangK == 0)
                {
                    return "";
                }

                else

                    return _soLuotDangK.ToString("###,###");
            }
            set
            {
                if (_soLuotDangK.ToString() != value)
                {
                    _soLuotDangK = int.Parse(value);
                }
            }
        }
        public string SoLuotCK
        {
            get
            {
                CanReadProperty("SoLuotCK", true);
                if (_soLuotCK == 0)
                {
                    return "";
                }

                else

                    return _soLuotCK.ToString("###,###");
            }
            set
            {
                if (_soLuotCK.ToString() != value)
                {
                    _soLuotCK = int .Parse(value);
                }
            }
        }
        public string SoLuotCKC
        {
            get
            {
                CanReadProperty("SoLuotCKC", true);
                if (_soLuotCKC == 0)
                {
                    return "";
                }

                else

                    return _soLuotCKC.ToString("###,###");
            }
            set
            {
                if (_soLuotCKC.ToString() != value)
                {
                    _soLuotCKC = int.Parse(value);
                }
            }
        }
        public string SoLuotTD
        {
            get
            {
                CanReadProperty("SoLuotTD", true);
                if (_soLuotTD == 0)
                {
                    return "";
                }

                else

                    return _soLuotTD.ToString("###,###");
            }
            set
            {
                if (_soLuotTD.ToString() != value)
                {
                    _soLuotTD = int.Parse(value);
                }
            }
        }
        public string SoLuotTDC
        {
            get
            {
                CanReadProperty("SoLuotTDC", true);
                if (_soLuotTDC == 0)
                {
                    return "";
                }

                else

                    return _soLuotTDC.ToString("###,###");
            }
            set
            {
                if (_soLuotTDC.ToString() != value)
                {
                    _soLuotTDC = int.Parse(value);
                }
            }
        }


        public string SoLuotTT
        {
            get
            {
                CanReadProperty("SoLuotTT", true);
                if (_soLuotTT == 0)
                {
                    return "";
                }

                else

                    return _soLuotTT.ToString("###,###");
            }
            set
            {
                if (_soLuotTT.ToString() != value)
                {
                    _soLuotTT = int.Parse(value);
                }
            }
        }
        public string SoLuotTTC
        {
            get
            {
                CanReadProperty("SoLuotTTC", true);
                if (_soLuotTTC == 0)
                {
                    return "";
                }

                else

                    return _soLuotTTC.ToString("###,###");
            }
            set
            {
                if (_soLuotTTC.ToString() != value)
                {
                    _soLuotTTC = int.Parse(value);
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }


        protected override Object GetIdValue()
        {
            return _maKhoa;
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
        protected internal ThongKe_BenhNhan_NgoaiTru_Info()
        {
            // Prevent direct creation
        }
        internal ThongKe_BenhNhan_NgoaiTru_Info (int ordernumber,
 String maKhoa,
 String TenKhoa,
 Int32  SoLuotCK,
 Int32 SoLuotDK,
             Int32 SoLuotCKC,
 Int32 SoLuotDKC,
 Int32 SoLuotTD,
 Int32 SoLuotTDC,
 Int32 SoLuotTT,
 Int32 SoLuotTTC,
 Int32 SoLuotDangK)
        {
            _OrderNumber = ordernumber;
            _maKhoa = maKhoa;
            _tenKhoa = TenKhoa;
            _soLuotCK = SoLuotCK;
            _soLuotDK = SoLuotDK;
            _soLuotCKC = SoLuotCKC;
            _soLuotDKC = SoLuotDKC ;
            _soLuotTDC = SoLuotTDC;
            _soLuotTD = SoLuotTD;
            _soLuotTTC = SoLuotTTC;
            _soLuotTT = SoLuotTT;
            _soLuotDangK = SoLuotDangK;      
        }
		/// <summary>
		/// Factory method. New <see cref="ThongKe_BenhNhan_NgoaiTru_Info" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

      

		#endregion
	}

}
