using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class RoleByUserList: NameValueListBase<int, string>
    {
        #region Business methods
        //public static int DefaultRole()
        //{
        //    RoleByUserList list = GetList();
        //    if (list.Count > 0)
        //    {
        //        return list.Items[0].Key;
        //    }
        //    else
        //    {
        //        throw (new NullReferenceException("No role available."));
        //    }
        //}
       
        #endregion

		#region Factory Methods
		private static RoleByUserList _list;
        //public static RoleByUserList GetList(int idEmployee)
        //{
        //    if (_list == null)
        //    {
        //        _list = DataPortal.Fetch<RoleByUserList>(new Criteria(idEmployee));
        //    }
        //    return _list;
        //}
        public static RoleByUserList GetList(string  idEmployee)// sua int sang string idemployee
        {
            if (_list == null)
            {
                _list = DataPortal.Fetch<RoleByUserList>(new Criteria(idEmployee));
            }
            return _list;
        }
		/// <summary>
        /// Xóa RoleByUserList trong bộ nhớ để danh sách quốc gia sẽ được
		/// reload lại.
		/// </summary>
		/// <remarks></remarks>
		public static void InvalidateCache()
		{
			_list = null;
		}

        public void AddItem(Csla.NameValueListBase<int, string>.NameValuePair item)
        {
            this.Add(item);
        }

        private RoleByUserList()
		{
			
		}
		#endregion

        #region Data Access
        [Serializable()]
        private class Criteria
        {
            private string  _id;
            public string ID
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }
            public Criteria(string id)
            {
                _id = id;
            }
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetRoleByUserList(criteria.ID)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetInt32("idRole"), dr.GetString("RoleName")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion	

    }
}
