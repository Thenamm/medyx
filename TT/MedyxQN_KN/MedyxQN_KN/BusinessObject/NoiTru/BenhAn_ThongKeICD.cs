using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="CslaObject" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_ThongKeICD : BusinessBase<BenhAn_ThongKeICD>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaICD = String.Empty;
		private String _TenICD = String.Empty;
		private int _SoHS = 0;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaICD
        {
			get 
			{
                CanReadProperty("MaICD", true);
				return _MaICD;
			}
			set 
			{
                CanWriteProperty("MaICD", true);
				if (_MaICD != value) 
				{
                    _MaICD = value;
                    PropertyHasChanged("MaICD");
				}
			}
		}
		public String TenICD
        {
            get
            {
                CanReadProperty("TenICD", true);
                return _TenICD;
            }
            set
            {
                CanWriteProperty("TenICD", true);
                if (_TenICD != value)
                {
                    _TenICD = value;
                    PropertyHasChanged("TenICD");
                }
            }
        }
        public int SoHS
        {
            get
            {
                CanReadProperty("SoHS", true);
                return _SoHS;
            }
            set
            {
                CanWriteProperty("SoHS", true);
                if (_SoHS != value)
                {
                    _SoHS = value;
                    PropertyHasChanged("SoHS");
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
			return _MaICD;
		}
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
				
		/// <summary>
		/// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static BenhAn_ThongKeICD NewBenhAn_ThongKeICD()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new BenhAn_ThongKeICD();
        }
		#endregion
		
		#region Constructors
		
		protected internal BenhAn_ThongKeICD()
		{	
			// Prevent direct creation
		}
        internal BenhAn_ThongKeICD(int ordernumber, string MaICD, string TenICD, int SoHS)
        {
            _OrderNumber = ordernumber;
            _MaICD  = MaICD;
            _TenICD  = TenICD;
            _SoHS = SoHS;
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
		/// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaICD") != null) _MaICD = dr.GetString("MaICD");
            if (dr.GetString("TenICD") != null) _TenICD = dr.GetString("TenICD");
			if (dr.GetInt32("SoHS") != null) _SoHS = dr.GetInt32("SoHS");
		}
		#endregion
	}

}
