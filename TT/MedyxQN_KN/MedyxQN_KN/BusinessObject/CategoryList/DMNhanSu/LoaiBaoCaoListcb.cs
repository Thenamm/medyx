

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class LoaiBaoCaoListcb : NameValueListBase<byte, string>
    {
        #region Business methods
        public static byte DefaultValue()
        {
            LoaiBaoCaoListcb list = GetList();
            if (list.Count > 0)
            {
                return list.Items[0].Key;
            }
            else
            {
                throw (new NullReferenceException("Không tồn tại danh sách loại"));
            }
        }
        #endregion

        #region Factory Methods
        private static LoaiBaoCaoListcb _list;
        public static LoaiBaoCaoListcb GetList()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<LoaiBaoCaoListcb>(new Criteria(typeof(LoaiBaoCaoListcb)));
            }
            return _list;
        }
        /// <summary>
        /// Xóa SexList trong bộ nhớ để danh sách quốc gia sẽ được
        /// reload lại.
        /// </summary>
        /// <remarks></remarks>
        public static void InvalidateCache()
        {
            _list = null;
        }

        private LoaiBaoCaoListcb()
        {

        }
        #endregion

        #region Data Access
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, ""));
            this.Add(new NameValuePair(1, "Theo giới tính"));
           
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
