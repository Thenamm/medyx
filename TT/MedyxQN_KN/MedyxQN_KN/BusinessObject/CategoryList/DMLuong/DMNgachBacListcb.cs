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
    public class DMNgachBacListcb : NameValueListBase<Int32 , decimal >
    {
        #region Business methods
        public static Int32  DefaultPosition(string  _MaNgach)
        {
            DMNgachBacListcb list = GetList(_MaNgach);
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
        private static DMNgachBacListcb _list;
        public static DMNgachBacListcb GetList(string  MaNgach)
        {
            DMNgachBacListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNgachBacListcb>(new Criteria(MaNgach, false));
            }
            return _list;
        }
        public static DMNgachBacListcb GetListAdd(string  MaNgach)
        {
            DMNgachBacListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNgachBacListcb>(new CriteriaOther(MaNgach, false));
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

        private DMNgachBacListcb()
        {

        }
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string  _MaNgach;
             private Boolean _qadmin = false ;
            public string  MaNgach
            {
                get
                {
                    return _MaNgach;
                }
            }
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(string  mMaNgach, Boolean mQadmin)
            {
                _MaNgach = mMaNgach;
                _qadmin = mQadmin;
            }
        }
        private class CriteriaOther
        {
            private string  _MaNgach;
             private Boolean _qadmin = false ;
            public string  MaNgach
            {
                get
                {
                    return _MaNgach;
                }
            }
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(string  mMaNgach, Boolean mQadmin)
            {
                _MaNgach = mMaNgach;
                _qadmin = mQadmin;
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
          
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNgachBac(criteria.MaNgach, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetInt32("Bac"), dr.GetDecimal("Heso")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
         
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNgachBac(criteria.MaNgach, false)))
            {
                IsReadOnly = false;
                //this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetInt32("Bac"), dr.GetDecimal("Heso")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
