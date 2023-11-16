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
    public class DMNhomListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(Byte _loai)
		{
            DMNhomListcb list = GetList(_loai);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMNHOM_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMNhomListcb _list;
        public static DMNhomListcb GetList(Byte _loai)
		{
            _list = null;
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMNhomListcb>(new Criteria(_loai));
			}
			return _list;
		}
        public static DMNhomListcb GetListCap1(Byte _loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNhomListcb>(new OtherCriteria(1,"",_loai));
            }
            return _list;
        }
        public static DMNhomListcb GetListCap1All(Byte _loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNhomListcb>(new OtherCriteria(5, "", _loai));
            }
            return _list;
        }
        public static DMNhomListcb GetListCap2(string ma ,Byte _loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNhomListcb>(new OtherCriteria(2,ma,_loai));
            }
            return _list;
        }
        public static DMNhomListcb GetListAll(Byte _loai)
        {
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMNhomListcb>(new CriteriaOther(_loai));
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

        private DMNhomListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        [Serializable()]
        #region OtherCriteria

        private class OtherCriteria
        {

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaict;
            public Byte loaict
            {
                get
                {
                    return _loaict;
                }
            }
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            private string _ma;
            public string ma
            {
                get
                {
                    return _ma;
                }
            }
             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public OtherCriteria(byte loai, string ma, Byte mloai)
            {

                _loai = mloai;
                _loaict = loai;
                _dk = " and cap =" + loai.ToString() +" and a.manhom like '"+ma+"%'";
            }
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNhom(criteria.dk, criteria.loai, false)))
            {
                IsReadOnly = false;
                if (criteria .loaict ==5)
                    this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaNhom"), dr.GetString("TenNhom")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
       
        #region CriteriaOther 



        private class CriteriaOther
        {

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }

             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Byte mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
		
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhom(criteria.loai, false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaNhom"), dr.GetString("TenNhom")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #region Criteria

       
        private class Criteria
        {

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhom(criteria.loai, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaNhom"), dr.GetString("TenNhom")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
