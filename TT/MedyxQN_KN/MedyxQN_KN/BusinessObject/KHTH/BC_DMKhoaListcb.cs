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

namespace HTC.Business.KHTH
{
	[Serializable()]
    public class BC_DMKhoaListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
            BC_DMKhoaListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMDICHVU_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
		private static BC_DMKhoaListcb _list;
		public static BC_DMKhoaListcb GetList()
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>(new Criteria(typeof(BC_DMKhoaListcb)));
            //}
			return _list;
		}
        public static BC_DMKhoaListcb GetListCap1s()
        {
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "4"));
            return _list;
        }
        public static BC_DMKhoaListcb GetListAdd()
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>();
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccount()
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("","" ));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccount(string account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther(account, ""));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountNgoaiTru()
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("","1"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountNgoaiTruDu()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "5"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountNoiTru()
        {
            //if (_list == null)
            //{
            _list = null;
          
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("","2"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListNgoaiTru()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "9"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListThemAdd()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "11"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListNoiTru()
        {
            //if (_list == null)
            //{
            _list = null;

            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "10"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountNoiTruAdd()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "8"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountNoiTruDu()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "6"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountCLS()
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("","3"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountCLSDu()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaOther("", "7"));
            //}
            return _list;
        }
        public static BC_DMKhoaListcb GetListByAccountMaKhoa(String MaKhoa)
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<BC_DMKhoaListcb>(new CriteriaFilter(MaKhoa));
            //}
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

        private BC_DMKhoaListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        [Serializable()]
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
            private string _loai;
            public string loai
            {
                get
                {
                    return _loai;
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

            public CriteriaOther(String mDK,String mloai)
            {
                //if (mloai != 4)
                //{
                if (mloai=="") 
                mloai ="0";
            _DK = " 1 =1 ";
                if (int.Parse (mloai ) <9)
                    {
                        _DK = "  EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                _DK = _DK + "' AND (CHARINDEX( '' + '''' + A.khoadt + '' ,B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
            };
                    if (mloai == "1")
                 _DK = _DK + "  AND A.LOAI = 0 and a.cap > 1 ";
                else if ((mloai == "2")||(mloai == "8"))
                    _DK = _DK + "  AND A.LOAI = 1 ";
                else if (mloai == "3")
                    _DK = _DK + "  AND A.LOAI = 2 and a.cap > 1";
                if (mloai == "5")
                    _DK = _DK + "  AND A.LOAI = 0  ";
                else if (mloai == "6")
                    _DK = _DK + "  AND A.LOAI = 1 ";
                else if (mloai == "7")
                    _DK = _DK + "  AND A.LOAI = 2 ";
                else if (mloai == "4")
                    _DK = _DK + "  AND  a.cap = 1";
                if (mloai == "9")
                    _DK = _DK + "  AND A.LOAI = 0 and a.cap > 1 ";
                else if ((mloai == "10"))
                    _DK = _DK + "  AND A.LOAI = 1 ";
                _loai = mloai;
                //else
                //{
                //    if (mloai != "")
                //        _DK = "  loai = '" + mloai  + "' and ";
                //    _DK = _DK + "'  EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE ACCOUNT ='" + _account;
                //    _DK = _DK + "' AND (CHARINDEX( A.MAKHOa  ,B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                //}
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
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private string _account = "";
            public string account
            {
                get
                {
                    return _account;
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
            public CriteriaFilter(String mMaKhoa)
            {
 
                _DK = " a.MaKhoa = '" + mMaKhoa  + "%'";

            }
        }

		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DMKhoa(false)))           
			{                  
				IsReadOnly = false;
                this.Add(new NameValuePair("", ""));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBC_DMKhoa(criteria.DK,criteria.Qadmin )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBC_DMKhoa(criteria.DK , criteria.Qadmin)))
            {
                IsReadOnly = false;
                if (criteria.loai =="8")
                    this.Add(new NameValuePair("All", "Tất cả"));
                else if (criteria.loai == "11")
                {
                    this.Add(new NameValuePair("All", "Tất cả"));
                    this.Add(new NameValuePair("Ngoại trú", "NT"));
                    this.Add(new NameValuePair("Nội trú", "NoiT"));
                }
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch()
		{        
			this.RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DMKhoa(false)))
			{                           
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

		#endregion	
	}
}
