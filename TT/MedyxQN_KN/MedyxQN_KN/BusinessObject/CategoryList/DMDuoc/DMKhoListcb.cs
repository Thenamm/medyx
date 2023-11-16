using System.Diagnostics;
using System;
 //using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
	[Serializable()]
    public class DMKhoListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(byte loai)
		{
			DMKhoListcb list = GetList(loai);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMVUNGLANHTHO_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
		private static DMKhoListcb _list;
        public static DMKhoListcb GetList(Byte Loai)
		{
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoListcb>(new Criteria(Loai));
            //}
			return _list;
		}
        public static DMKhoListcb GetListFind(Byte Loai,string account)
        {
            //if (_list == null || _list.Count ==0 )
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaFilter(1,Loai,account ));
            //}
            return _list;
        }
        public static DMKhoListcb GetListKhoChinh(Byte Loai, string account)
        {
            //if (_list == null || _list.Count ==0 )
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaFilter(2,Loai,account ));
            //}
            return _list;
        }
        public static DMKhoListcb GetListKhoLe(Byte Loai,string account)
        {
            //if (_list == null || _list.Count ==0 )
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaFilter(7, Loai,account ));
            //}
            return _list;
        }
        public static DMKhoListcb GetListKhoBC(Byte Loai, string account)
        {
            //if (_list == null || _list.Count ==0 )
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaFilter(4,Loai,account ));
            //}
            return _list;
        }
        public static DMKhoListcb GetListKhoBan(Byte Loai, string account)
        {
            //if (_list == null || _list.Count ==0 )a
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaFilter(3, Loai,account ));
            //}
            return _list;
        }
        public static DMKhoListcb GetListAdd(Byte Loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMKhoListcb>(new CriteriaOther(Loai, false));
            }
            return _list;
        }
      
		/// <summary>
		/// Xóa PositionList trong bộ nhớ để danh sách quốc gia sẽ được
		/// reload lại.
		/// </summary>
		/// <remarks></remarks>
		public static void InvalidateCache()
		{
			_list = null;
		}

        private DMKhoListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

             private Boolean _qadmin = false ;
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;
               
            }
        }
        private class CriteriaOther
        {
            private Byte _Loai;         
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

             private Boolean _qadmin = false ;
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Byte mLoai, Boolean mQadmin)
            {
                _Loai = mLoai;
                _qadmin = mQadmin;
            }
        }

        [Serializable()]
        private class CriteriaFilter
        {
            
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private Byte _loai ;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _kieu;
            public Byte kieu
            {
                get
                {
                    return _kieu;
                }
            }
            private string _account = ""  ;
            public string account
            {
                get
                {
                    return _account;
                }
            }
            public CriteriaFilter(byte kieu , byte loai,string account)
            {

                _account = account; 
                _DK = " loai = '" + loai + "' and EXISTS(SELECT B.MAKHO FROM ACCOUNT B WHERE DBO.FGIAIMA(B.ACCOUNT)  ='" + _account;
                    _DK = _DK + "' AND (CHARINDEX(  '' + A.MAKHO + ''  ,B.MAKHO,1) <> 0 OR  ALLMAKHO = 1 )) ";
                    if (kieu == 2)
                        _DK = _DK + " AND ISNULL(A.kieukho,0) = 1";
                    else if  (kieu == 3) 
                        _DK = _DK + " AND ISNULL(A.KHOBAN,0) = 1";
                    else if (kieu == 7)
                        _DK = _DK + " AND ISNULL(A.kieukho,0) = 0";
                    _kieu = kieu;
                 
            }
        }

		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKho(criteria.Loai   , false )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaKho"), dr.GetString("TenKho")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

        private void DataPortal_Fetch(CriteriaFilter criteria)
		{
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKho(criteria.DK)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaKho"), dr.GetString("TenKho")));
				}
                if (criteria.kieu ==4)
                {
                    this.Add(new NameValuePair("100", "Kho tủ trực"));
                    this.Add(new NameValuePair("000", "Kho chính + Kho tủ trực"));
                }
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKho(criteria.Loai  , false )))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaKho"), dr.GetString("TenKho")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
      
		#endregion	
	}
}
