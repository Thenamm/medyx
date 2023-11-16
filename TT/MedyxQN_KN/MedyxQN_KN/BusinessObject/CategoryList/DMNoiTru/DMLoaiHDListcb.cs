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
    public class DMLoaiHDListcb : NameValueListBase<Int16, string>
    {
        #region Business methods
        public static Int16 DefaultPosition(byte loaiBC)
        {
            DMLoaiHDListcb list = GetList(loaiBC);
            if (list.Count > 0)
            {
                return list.Items[0].Key;
            }
            else
            {
                throw (new NullReferenceException("NO_EXIST_DMVUNGLANHTHO_CATALOG"));
            }

        }
        #endregion

        #region Factory Methods
        private static DMLoaiHDListcb _list;
        public static DMLoaiHDListcb GetList(byte LoaiBC)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLoaiHDListcb>(new Criteria(LoaiBC));
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

        private DMLoaiHDListcb()
        {

        }
        #endregion

        #region Data Access
        [Serializable()]
        private class Criteria
        {

            private Byte _loaiBC;
            public Byte loaiBC
            {
                get
                {
                    return _loaiBC;
                }
            }


            public Criteria(Byte mloaiBC)
            {

                _loaiBC = mloaiBC;

            }
        }



        private void DataPortal_Fetch(Criteria crit)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiHDListcb(crit.loaiBC)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetInt16("LoaiBC"), dr.GetString("TenBC")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
