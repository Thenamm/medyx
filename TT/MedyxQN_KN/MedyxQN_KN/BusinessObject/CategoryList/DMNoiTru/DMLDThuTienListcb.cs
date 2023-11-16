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
    public class DMLDThuTienListcb : NameValueListBase<string , string>
	{		
		#region Business methods
        public static string DefaultPosition(Boolean _loai)
		{
            DMLDThuTienListcb list = GetList(_loai);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMLDThuTien_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMLDThuTienListcb _list ;
        public static DMLDThuTienListcb GetList(Boolean _loai)
		{
            DMLDThuTienListcb.InvalidateCache();
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMLDThuTienListcb>(new CriteriaOther(_loai));
			}
			return _list;
		}
        public static DMLDThuTienListcb GetListKHD(Boolean _loai)
        {
            DMLDThuTienListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLDThuTienListcb>(new OtherCriteria(_loai));
            }
            return _list;
        }
        public static DMLDThuTienListcb GetListHD(Boolean _loai)
        {
            DMLDThuTienListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLDThuTienListcb>(new CriteriaHD(_loai));
            }
            return _list;
        }
        public static DMLDThuTienListcb GetListAdd(Boolean _loai)
        {
            DMLDThuTienListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLDThuTienListcb>(new Criteria(_loai));
            }
            return _list;
        }
        public static DMLDThuTienListcb GetListAdd()
        {
            DMLDThuTienListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLDThuTienListcb>(new CriteriaDu());
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

        private DMLDThuTienListcb()
		{
			
		}
		#endregion
		
		#region Data Access
         #region Criteria

        [Serializable()]
        private class Criteria
        {

            private Boolean _loai;
            public Boolean loai
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
            public Criteria(Boolean mloai)
            {

                _loai = mloai;
                
            }
        }
        #endregion
        #region CriteriaDu

        [Serializable()]
        private class CriteriaDu
        {

         
            private Boolean _qadmin = false;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaDu()
            {

               

            }
        }
        #endregion
        #region CriteriaOther
        private class CriteriaOther
        {

            private Boolean _loai;
            public Boolean loai
            {
                get
                {
                    return _loai;
                }
            }
            private Boolean _qadmin = false;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Boolean mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDThuTien(criteria.loai, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLDThuTien"), dr.GetString("TenLDThuTien")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaDu criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDThuTien(false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLDThuTien"), dr.GetString("TenLDThuTien")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #region CriteriaHD
        private class CriteriaHD
        {

            private Boolean _loai;
            public Boolean loai
            {
                get
                {
                    return _loai;
                }
            }
            private Boolean _qadmin = false;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaHD(Boolean mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaHD criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            string dk = " isnull(a.songay,0) >0";
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDThuTien(dk, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLDThuTien"), dr.GetString("TenLDThuTien")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #region OtherCriteria
        private class OtherCriteria
        {

            private Boolean _loai;
            public Boolean loai
            {
                get
                {
                    return _loai;
                }
            }
            private Boolean _qadmin = false;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public OtherCriteria(Boolean mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            string dk = " isnull(a.songay,0) =0";
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDThuTien(dk, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLDThuTien"), dr.GetString("TenLDThuTien")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
    	private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDThuTien(criteria.loai, false )))
			{
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaLDThuTien"), dr.GetString("TenLDThuTien")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
	}
}
