using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class Dzual_DMKho:IDisposable
    {
        #region State Fields
	    private String _maKho;
	    private String _tenKho;
	    private Byte _loai;
	    private Boolean _kieukho;
	    private Boolean _khoban;
	    private String _ghichu;
	    private String _maMay;
	    private Boolean _huy;
	    private DateTime _ngaySD;
	    private String _nguoiSD;
	    private String _hOTEN;
	    private int _ordernumber;
        #endregion

        #region Business Properties and Methods
	        public String MaKho
	        {
		        get
		        {
			        return _maKho;
		        }
		        set
		        {
			        _maKho = value;
		        }
	        }
	        public String TenKho
	        {
		        get
		        {
			        return _tenKho;
		        }
		        set
		        {
			        _tenKho = value;
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
	        public Boolean Kieukho
	        {
		        get
		        {
			        return _kieukho;
		        }
		        set
		        {
			        _kieukho = value;
		        }
	        }
	        public Boolean Khoban
	        {
		        get
		        {
			        return _khoban;
		        }
		        set
		        {
			        _khoban = value;
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
	        public String HOTEN
	        {
		        get
		        {
			        return _hOTEN;
		        }
		        set
		        {
			        _hOTEN = value;
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
            public void Dispose()
            {
                if (this != null)
                {
                    MaKho = null;
                    TenKho = null;                   
                }
            }
	        public Dzual_DMKho()
	        {

	        }
        public Dzual_DMKho(IDataReader dr, int Ordernumber)
	        {
		        _ordernumber = Ordernumber;
		        if(dr["MaKho"] != null && dr["MaKho"].GetType().Name != "DBNull") _maKho = Convert.ToString(dr["MaKho"]);
		        if(dr["TenKho"] != null && dr["TenKho"].GetType().Name != "DBNull") _tenKho = Convert.ToString(dr["TenKho"]);
		        if(dr["Loai"] != null && dr["Loai"].GetType().Name != "DBNull") _loai = Convert.ToByte(dr["Loai"]);
		        if(dr["Kieukho"] != null && dr["Kieukho"].GetType().Name != "DBNull") _kieukho = Convert.ToBoolean(dr["Kieukho"]);
		        if(dr["Khoban"] != null && dr["Khoban"].GetType().Name != "DBNull") _khoban = Convert.ToBoolean(dr["Khoban"]);
		        if(dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
		        if(dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
		        if(dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
		        if(dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]);
		        if(dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
		        if(dr["HOTEN"] != null && dr["HOTEN"].GetType().Name != "DBNull") _hOTEN = Convert.ToString(dr["HOTEN"]);
	        }

        private static string ConnectString
		{
			get
			{
				return HTC.Business.DataProvider.Instance().DuanConnectString();
			}
		}
        #endregion
    }
}
