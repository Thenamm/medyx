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
    public class DMGiuong_KhoaSoPhongListcb : NameValueListBase<string , string>
	{		
		#region Business methods
        public static string DefaultPosition(string _makhoa)
		{
            DMGiuong_KhoaSoPhongListcb list = GetList(_makhoa);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMGiuong_KhoaSoPhong_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMGiuong_KhoaSoPhongListcb _list ;
        public static DMGiuong_KhoaSoPhongListcb GetList(string _makhoa)
		{
            DMGiuong_KhoaSoPhongListcb.InvalidateCache();
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMGiuong_KhoaSoPhongListcb>(new CriteriaOther(_makhoa));
			}
			return _list;
		}
        public static DMGiuong_KhoaSoPhongListcb GetListAdd(string _makhoa)
        {
            DMGiuong_KhoaSoPhongListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMGiuong_KhoaSoPhongListcb>(new Criteria(_makhoa));
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

        private DMGiuong_KhoaSoPhongListcb()
		{
			
		}
		#endregion
		
		#region Data Access
         #region CriteriaOther

        [Serializable()]
        private class Criteria
        {

            private string _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private string _dk;
            public String dk
            {
                get
                {
                    return _dk;
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
            public Criteria(String mmakhoa)
            {

                _makhoa = mmakhoa;
                
            }
        }
        #endregion
        #region CriteriaOther
        private class CriteriaOther
        {

            private string _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private string _dk;
            public String dk
            {
                get
                {
                    return _dk;
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
            public CriteriaOther(String mmakhoa)
            {

                _makhoa = mmakhoa;
                
            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaOther criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong_KhoaSoPhong(criteria.makhoa, criteria.dk , false)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("SoPhong"), dr.GetString("SoPhong")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		       
    	private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong_KhoaSoPhong(criteria.makhoa, criteria.dk, false)))
			{
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("SoPhong"), dr.GetString("SoPhong")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
	}
}
