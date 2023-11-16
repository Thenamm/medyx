using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.Duoc;
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{

    [Serializable()]
    public partial class PhieuSoChe_Gia : BusinessBase<PhieuSoChe_Gia>
    {
        #region Business Methods

        #region State Fields

        private Decimal _sTT;
        private String _maThuocS = String.Empty;
        private String _maThuocC = String.Empty;

        private Decimal _soLuongS;
        private Decimal _soLuongC;

          private Decimal _donGiaS;
        private Decimal _donGiaC;
        private Decimal _giaban;
       
        private String _tenTMS = String.Empty;
        private String _tenTMC = String.Empty;
        private String _tenDVTS = String.Empty;

       
        private String _tenDVTC = String.Empty;
     


        #endregion

        #region Business Properties and Methods


       
        public Decimal STT
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
        public String maThuocS
        {
            get
            {
                CanReadProperty("maThuocS", true);
                return _maThuocS;
            }
            set
            {
                CanWriteProperty("maThuocS", true);
                if (_maThuocS != value)
                {
                    _maThuocS = value;
                    PropertyHasChanged("maThuocS");
                }
            }
        }
        public String maThuocC
        {
            get
            {
                CanReadProperty("maThuocC", true);
                return _maThuocC;
            }
            set
            {
                CanWriteProperty("maThuocC", true);
                if (_maThuocC != value)
                {
                    _maThuocC = value;
                    PropertyHasChanged("maThuocC");
                }
            }
        }
        public String soLuongS
        {
            get
            {
                CanReadProperty("soLuongS", true);
                if (_soLuongS == 0)
                    return "0";
                else if (_soLuongS - (int)(_soLuongS) != 0)
                    return _soLuongS.ToString("###,###.###");
                else
                    return _soLuongS.ToString("###,###");
            }
            set
            {
                CanWriteProperty("soLuongS", true);
                if (_soLuongS.ToString() != value)
                {
                    if (value == "")
                        _soLuongS = 0;
                    else
                        _soLuongS = decimal.Parse(value);

                    PropertyHasChanged("soLuongS");
                }
            }
        }
        public String soLuongC
        {
            get
            {
                CanReadProperty("soLuongC", true);
                if (_soLuongC == 0)
                    return "0";
                else if (_soLuongC - (int)(_soLuongC) != 0)
                    return _soLuongC.ToString("###,###.###");
                else
                    return _soLuongC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("soLuongC", true);
                if (_soLuongC.ToString() != value)
                {
                    if (value == "")
                        _soLuongC = 0;
                    else
                        _soLuongC = decimal.Parse(value);

                    PropertyHasChanged("soLuongC");
                }
            }
        }
        public String DonGiaC
        {
            get
            {
                CanReadProperty("DonGiaC", true);
                   if (_donGiaC == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGiaC.ToString("###,###.00");
                }
             
            }
            set
            {
                CanWriteProperty("DonGiaC", true);
                if (_donGiaC.ToString() != value)
                {
                    _donGiaC = decimal.Parse(value);
                    PropertyHasChanged("DonGiaC");
                }
            }
        }
        public string  DonGiaS
        {
            get
            {
                CanReadProperty("DonGiaS", true);
                if (_donGiaS == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGiaS.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("DonGiaS", true);
                if (_donGiaS.ToString() != value)
                {
                    _donGiaS = decimal.Parse(value);
                    PropertyHasChanged("DonGiaS");
                }
            }
        }
        public string giaban
        {
            get
            {
                CanReadProperty("giaban", true);
                if (_giaban == 0)
                {
                    return "0";
                }
                else
                {
                    return _giaban.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("giaban", true);
                if (_giaban.ToString() != value)
                {
                    _giaban = decimal.Parse(value);
                    PropertyHasChanged("DonGia");
                }
            }
        }
     
        public String TenTMS
        {
            get
            {
                CanReadProperty("TenTMS", true);
                return _tenTMS;
            }
            set
            {
                CanWriteProperty("TenTMS", true);
                if (_tenTMS != value)
                {
                    _tenTMS = value;
                    PropertyHasChanged("TenTMS");
                }
            }
        }
        public String TenTMC
        {
            get
            {
                CanReadProperty("TenTMC", true);
                return _tenTMC;
            }
            set
            {
                CanWriteProperty("TenTMC", true);
                if (_tenTMC != value)
                {
                    _tenTMC = value;
                    PropertyHasChanged("TenTMC");
                }
            }
        }
        public String TenDVTS
        {
            get
            {
                CanReadProperty("TenDVTS", true);
                return _tenDVTS;
            }
            set
            {
                CanWriteProperty("TenDVTS", true);
                if (_tenDVTS != value)
                {
                    _tenDVTS = value;
                    PropertyHasChanged("TenDVTS");
                }
            }
        }
        public String TenDVTC
        {
            get
            {
                CanReadProperty("TenDVTC", true);
                return _tenDVTC;
            }
            set
            {
                CanWriteProperty("TenDVTC", true);
                if (_tenDVTC != value)
                {
                    _tenDVTC = value;
                    PropertyHasChanged("TenDVTC");
                }
            }
        }
      

        protected override Object GetIdValue()
        {
            return _sTT;
        }

        #endregion
        #endregion

        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="PhieuSoChe_Gia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhieuSoChe_Gia NewPhieuSoChe_Gia()
        {
            return new PhieuSoChe_Gia();
            //return DataPortal.Create<PhieuSoChe_Gia>();
        }
        ////public static PhieuSoChe_Gia GetPhieuSoChe_Gia(String makho, Decimal sTT, String makhoa)
        ////{
        ////    return DataPortal.Fetch<PhieuSoChe_Gia>(new Criteria(makho, sTT, makhoa));
        ////}
        internal static PhieuSoChe_Gia GetPhieuSoChe_Gia(SafeDataReader dr,decimal stt)
        {
            return new PhieuSoChe_Gia(dr,stt);
        }
		/// <summary>
		/// Marks the <see cref="PhieuSoChe_Gia" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeletePhieuSoChe_Gia(String makho, Decimal sTT, String makhoa)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,makho, sTT, makhoa));
        //}
        public PhieuSoChe_Gia()
        {
            MarkAsChild();
        }
        private PhieuSoChe_Gia(SafeDataReader dr,decimal stt)
        {
            _sTT = stt;
             if (dr.GetString("maThuocS") != null) _maThuocS = dr.GetString("maThuocS");
            if (dr.GetDecimal("soLuongS") != null) _soLuongS = dr.GetDecimal("soLuongS");
            if (dr.GetString("maThuocC") != null) _maThuocC = dr.GetString("maThuocC");
            if (dr.GetDecimal("soLuongC") != null) _soLuongC = dr.GetDecimal("soLuongC");
            if (dr.GetDecimal("DonGiaS") != null) _donGiaS = dr.GetDecimal("DonGiaS");
             if (dr.GetDecimal("DonGiaC") != null) _donGiaC = dr.GetDecimal("DonGiaC");
             if (dr.GetDecimal("giaban") != null) _giaban = dr.GetDecimal("giaban");
           
            if (dr.GetString("TenTMS") != null) _tenTMS = dr.GetString("TenTMS");
            if (dr.GetString("TenTMC") != null) _tenTMC = dr.GetString("TenTMC");
            if (dr.GetString("TenDVTS") != null) _tenDVTS = dr.GetString("TenDVTS");
            if (dr.GetString("TenDVTC") != null) _tenDVTC = dr.GetString("TenDVTC");
          if (_donGiaC==0 &&_donGiaS !=0 &&_soLuongC!=0&&_soLuongS!=0)
              _donGiaC= (_donGiaS *_soLuongS)/_soLuongC;
            try
            {

            }
            catch
            {
                //
            }

        }
		#endregion
		
      
		
    }

}
