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
    public class DMDanhGia_CS_KQListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _MaCS)
		{
			DMDanhGia_CS_KQListcb list = GetList(_MaCS );
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
		private static DMDanhGia_CS_KQListcb _list;
		public static DMDanhGia_CS_KQListcb GetList(string _MaCS)
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMDanhGia_CS_KQListcb>(new Criteria(_MaCS)); //typeof(DMDanhGia_CS_KQListcb)));
            //}
			return _list;
		}
      
        public static DMDanhGia_CS_KQListcb GetListAdd(string _MaCS)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDanhGia_CS_KQListcb>(new CriteriaOther(false, _MaCS));
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

        private DMDanhGia_CS_KQListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _MaCS;
            public string MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public Criteria(string mMaCS)
            {
                       
                _MaCS = mMaCS;
            }

        }
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _MaCS ;
            public string MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public CriteriaOther(Boolean mqadmin, string mMaCS)
            {

                _qadmin = mqadmin;
                _MaCS = mMaCS;
            }

        }
        private class OtherCriteria
        {
           
           

        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS_KQ(criteria.MaCS,false )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaKQ"), dr.GetString("TenKQ")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS_KQ( criteria.MaCS,false )))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaKQ"), dr.GetString("TenKQ")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
