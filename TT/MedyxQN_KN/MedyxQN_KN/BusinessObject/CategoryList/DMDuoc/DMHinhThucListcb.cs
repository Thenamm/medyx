﻿using System.Diagnostics;
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
    public class DMHinhThucListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(Byte _loai)
		{
            DMHinhThucListcb list = GetList(_loai);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMHinhThuc_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMHinhThucListcb _list;
        public static DMHinhThucListcb GetList(Byte _loai)
		{
            _list = null;
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMHinhThucListcb>(new CriteriaOther(_loai));
			}
			return _list;
		}
        public static DMHinhThucListcb GetListAll(Byte _loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMHinhThucListcb>(new Criteria(_loai));
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

        private DMHinhThucListcb()
		{
			
		}
		#endregion
		
		#region Data Access
         #region CriteriaOther

        [Serializable()]
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
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHinhThuc(criteria.loai,false )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaHinhThuc"), dr.GetString("TenHinhThuc")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		       
    	private void DataPortal_Fetch(Criteria criteria)
		{
        //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHinhThuc(criteria.loai, false)))
			{
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaHinhThuc"), dr.GetString("TenHinhThuc")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
	}
}