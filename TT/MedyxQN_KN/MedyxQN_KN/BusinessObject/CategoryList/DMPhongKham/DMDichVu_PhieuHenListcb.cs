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
    public class DMDichVu_PhieuHenListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _madv)
		{
			DMDichVu_PhieuHenListcb list = GetList(_madv );
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
		private static DMDichVu_PhieuHenListcb _list;
		public static DMDichVu_PhieuHenListcb GetList(string _madv)
		{
			//if (_list == null)
			//{
                _list = DataPortal.Fetch<DMDichVu_PhieuHenListcb>(new Criteria(_madv ));
			//}
			return _list;
		}
        public static DMDichVu_PhieuHenListcb GetList(string _madv,string _maLoai)
        {
            //if (_list == null)
            //{
            _list = DataPortal.Fetch<DMDichVu_PhieuHenListcb>(new CriteriaOther(_madv,_maLoai));
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

        private DMDichVu_PhieuHenListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _madv;
            public String madv
            {
                get
                {
                    return _madv;
                }
            }
            public Criteria(string madv)
            {

                _madv  = madv;
            }
        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_PhieuHen(criteria.madv,false )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaPH"), dr.GetString("TenHT")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

        private class CriteriaOther
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _madv;
            public String madv
            {
                get
                {
                    return _madv;
                }
            }
            private String _maLoai;
            public String maLoai
            {
                get
                {
                    return _maLoai;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            public CriteriaOther(string mmadv,string mmaLoai)
            {

                _madv = mmadv;
                _maLoai = mmaLoai;
                _dk = "  and d.malh in (select malh from  dmdichvu aa where ltrim(rtrim(aa.madv)) like N'" + mmadv + "%') ";
                _dk = _dk + " and ltrim(rtrim(a.maloai)) like N'" + mmaLoai + "%'";
            }
        }
        private void DataPortal_Fetch(CriteriaOther CriteriaOther)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_PhieuHen(CriteriaOther.dk, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaPH"), dr.GetString("TenHT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            this.Add(new NameValuePair("All", "Tất cả"));
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMBenhPham()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaPH"), dr.GetString("TenHT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
