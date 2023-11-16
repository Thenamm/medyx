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
    public class DMDoituongListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
			DMDoituongListcb list = GetList();
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
		private static DMDoituongListcb _list;
		public static DMDoituongListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMDoituongListcb>(new Criteria(typeof(DMDoituongListcb)));
			}
			return _list;
		}
        public static DMDoituongListcb GetListAdd()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>();
            }
            return _list;
        }
        public static DMDoituongListcb GetListByAccount(string account)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new CriteriaOther(account));
            }
            return _list;
        }
        public static DMDoituongListcb GetListByAccountAll(string account)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new CriteriaOtherall(account));
            }
            return _list;
        }
        public static DMDoituongListcb GetListTat()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new OtherCriteria());
            }
            return _list;
        }
        public static DMDoituongListcb GetListTatDV()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new OtherCriteriaDV());
            }
            return _list;
        }
        public static DMDoituongListcb GetListDTKHO(string account)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new CriteriaOtherall_DTKHO(account));
            }
            return _list;

        }
        public static DMDoituongListcb GetListDTKHO_Add(string account)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDoituongListcb>(new Criteria_DTKHO(account));
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

        private DMDoituongListcb()
		{
			
		}
		#endregion
		
		#region Data Access

		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDoiTuong()))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaDT"), dr.GetString("TenDT")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
      
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDoiTuong()))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaDT"), dr.GetString("TenDT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class OtherCriteria
        {
           
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("0", "Nhân dân"));
            this.Add(new NameValuePair("1", "BHYT"));
           
                      
            this.Add(new NameValuePair("2", "Miễn phí"));
            this.Add(new NameValuePair("3", "Trẻ em"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private class OtherCriteriaDV
        {

        }
        private void DataPortal_Fetch(OtherCriteriaDV criteria)
        {
            this.RaiseListChangedEvents = false;
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindCBDMDoiTuong("",false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
                //this.Add(new NameValuePair("1", "BHYT"));
            
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaDT"), dr.GetString("TenDT")));
                }
                //this.Add(new NameValuePair("5", "Nhân dân và miễn phí"));
           
                IsReadOnly = true;
            }
            
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class CriteriaOther
        {
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
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

            private string _account = "";
            public String account
            {
                get
                {
                    return _account;
                }
            }

            public CriteriaOther(String acount)
            {
                //if (mloai != 4)
                //{
                _account = acount;

                _DK = "  EXISTS(SELECT B.quyendtuong FROM ACCOUNT B WHERE dbo.fgiaima(ACCOUNT) ='" + _account;
                _DK = _DK + "' AND (CHARINDEX( '' + A.madt + '' ,B.quyendtuong,1) <> 0 OR  ALLquyendtuong = 1  )) ";
                //}
                //else
                //{
                //_DK = "  loai = '" + loai + "' and EXISTS(SELECT B.MAKHOa FROM ACCOUNT B WHERE ACCOUNT ='" + _account;
                //_DK = _DK + "' AND (CHARINDEX( A.MAKHOa  ,B.MAKHOa,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                //}
            }
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindCBDMDoiTuong(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("Madt"), dr.GetString("Tendt")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class CriteriaOtherall
        {
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
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

            private string _account = "";
            public String account
            {
                get
                {
                    return _account;
                }
            }

            public CriteriaOtherall(string acount)
            {
                //if (mloai != 4)
                //{
                _account = acount;
                _DK = "  EXISTS(SELECT B.quyendtuong FROM ACCOUNT B WHERE dbo.fgiaima(ACCOUNT) ='" + _account;
                _DK = _DK + "' AND (CHARINDEX( A.madt  ,B.quyendtuong,1) <> 0 OR  ALLquyendtuong = 1  )) ";
                //}
                //else
                //{
                //_DK = "  loai = '" + loai + "' and EXISTS(SELECT B.MAKHOa FROM ACCOUNT B WHERE ACCOUNT ='" + _account;
                //_DK = _DK + "' AND (CHARINDEX( A.MAKHOa  ,B.MAKHOa,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                //}
            }
        }

        private void DataPortal_Fetch(CriteriaOtherall criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindCBDMDoiTuong(criteria.DK, false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("Madt"), dr.GetString("Tendt")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
     
        private class CriteriaOtherall_DTKHO
        {
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
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
            private string _account = "";
            public String account
            {
                get
                {
                    return _account;
                }
            }
            public CriteriaOtherall_DTKHO(string acount)
            {
                _account = acount;
                _DK = "  EXISTS(SELECT B.QUYENDTUONG FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                _DK = _DK + "' AND (CHARINDEX( '''' + A.MADT + '''' ,B.QUYENDTUONG,1) <> 0 OR  ALLQUYENDTUONG = 1  or ALLQUYENDTUONG = 1 )) ";
            }

        }

        private void DataPortal_Fetch(CriteriaOtherall_DTKHO criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDoiTuongKHO(criteria.DK, false)))
            {
                IsReadOnly = false;
                //this.Add(new NameValuePair("", Localization.GetString("")));
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("Madt"), dr.GetString("Tendt")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria_DTKHO
        {
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
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
            private string _account = "";
            public String account
            {
                get
                {
                    return _account;
                }
            }
            public Criteria_DTKHO(String acount)
            {

                _account = acount;
                _DK = "  EXISTS(SELECT B.QUYENDTUONG FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                _DK = _DK + "' AND (CHARINDEX( '''' + A.MADT + '''' ,B.QUYENDTUONG,1) <> 0 OR  ALLQUYENDTUONG = 1  or ALLQUYENDTUONG = 1 )) ";
            }

        }
        private void DataPortal_Fetch(Criteria_DTKHO criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDoiTuongKHO(criteria.DK, false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("Madt"), dr.GetString("Tendt")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
