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
    public class DMKhoaListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
            DMKhoaListcb list = GetList();
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
		private static DMKhoaListcb _list;
		public static DMKhoaListcb GetList()
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoaListcb>(new Criteria(typeof(DMKhoaListcb)));
            //}
			return _list;
		}
        public static DMKhoaListcb GetListCap1s(string _account)
        {
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account , "4"));
            return _list;
        }
        public static DMKhoaListcb GetListCap1sAll(string _account)
        {
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account, "17"));
            return _list;
        }
        public static DMKhoaListcb GetListAdd()
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoaListcb>();
            //}
            return _list;
        }
     
        public static DMKhoaListcb GetListByAccount(string account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account, ""));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountNgoaiTru(string account)
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account ,"1"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByTruc(string manv)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(manv, "16"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetList(string tenkhoa,string makhoa)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther( tenkhoa,makhoa));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountNgoaiTruDu(string account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account , "5"));
            //}
            return _list;
        }
       
        public static DMKhoaListcb GetListByAccountNoiTru(string account)
        {
            //if (_list == null)
            //{
            _list = null;

            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account, "2"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListNoiTruMa(string account)
        {
            //if (_list == null)
            //{
            _list = null;

            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account , "12"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListNgoaiTru(string account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account, "9"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListThemAdd(string _account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account , "11"));
            //}
            return _list;
        }
       
        public static DMKhoaListcb GetListNoiTru(string account)
        {
            //if (_list == null)
            //{
            _list = null;

            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account , "10"));
            //}
            return _list;
        }
      
        public static DMKhoaListcb GetListByAccountNoiTruAdd(string account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(account, "8"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountNoiTruDu(string _account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account , "6"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountCLS(string _account)
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account ,"3"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountCLSDu(string _account)
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther(_account , "7"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListCM()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaOther("", "15"));
            //}
            return _list;
        }
        public static DMKhoaListcb GetListByAccountMaKhoa(String MaKhoa)
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMKhoaListcb>(new CriteriaFilter(MaKhoa));
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

        private DMKhoaListcb()
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

            private string _account ;
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
            _account = mDK;
               if (mloai.Length>=3)
                    _DK = mDK;
               else if (int.Parse(mloai) == 16)
               {
                   _DK = "  a.makhoa in (select makhoa from dmnhanvien_truc where manv ='" + mDK + "' and datediff(d,tungaydk,getdate())>=0  and datediff(d,denngaydk,getdate())<=0)";
               }
               else if (int.Parse(mloai) < 9 || (int.Parse(mloai)==12 &&_account !=""))
               {
                   _DK = "  EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                   _DK = _DK + "' AND (CHARINDEX( '''' + A.MAKHOa + '''' ,B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
               };
                if (mloai == "1")
                 _DK = _DK + "  AND A.LOAI = 0 and a.cap > 1 ";
                else if (mloai=="15")
                    _DK = _DK + "  AND A.LOAI in (1,0) ";
                else if ((mloai == "2")||(mloai == "8")||mloai =="12")
                    _DK = _DK + "  AND A.LOAI = 1 ";
                else if (mloai == "3")
                    _DK = _DK + "  AND A.LOAI = 2 and a.cap > 1";
                if (mloai == "5")
                    _DK = _DK + "  AND A.LOAI = 0  ";
                else if (mloai == "6")
                    _DK = _DK + "  AND A.LOAI = 1 ";
                else if (mloai == "7")
                    _DK = _DK + "  AND A.LOAI = 2 ";
                else if (mloai == "4"||mloai =="17")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhoa(false)))           
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKhoa(criteria.DK,false )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    if (HTC .ShareVariables.pub_spC=="HU" || HTC.ShareVariables.pub_spC =="QN"   )
                        this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoaQL")+ " - " + dr.GetString("TenKhoa")));
                    else
                    this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            if ((criteria.loai.Length >= 3))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair(criteria.loai, criteria.DK));
                IsReadOnly = true;
            }
            else
            {
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKhoa(criteria.DK, false)))
                {
                    IsReadOnly = false;
                    if ((criteria.loai == "8" || criteria.loai == "15" || criteria.loai == "17"))
                    {
                        this.Add(new NameValuePair("All", "Tất cả"));
                        while (dr.Read())
                        {
                            if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN")
                                this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoaQL")+ " - " + dr.GetString("TenKhoa")));
                            else
                                this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                        }
                    }
                    else if (criteria.loai == "11")
                    {
                        this.Add(new NameValuePair("All", "Tất cả"));
                        this.Add(new NameValuePair("Ngoại trú", "NT"));
                        this.Add(new NameValuePair("Nội trú", "NoiT"));
                        while (dr.Read())
                        {
                            this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                        }
                    }
                    else if (criteria.loai == "12")
                    {
                        while (dr.Read())
                        {
                            if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN")
                                this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoaQL")+ " - " + dr.GetString("TenKhoa")));
                            else
                                 this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoa") + "-" + dr.GetString("TenKhoa")));
                        }
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN")
                                this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoaQL")+ " - " + dr.GetString("TenKhoa")));
                            else
                                this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
                        }
                    }
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch()
		{        
			this.RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhoa(false)))
			{                           
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN")
                        this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("MaKhoaQL")+ " - " + dr.GetString("TenKhoa")));
                    else
                        this.Add(new NameValuePair(dr.GetString("MaKhoa"), dr.GetString("TenKhoa")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

		#endregion	
	}
}
