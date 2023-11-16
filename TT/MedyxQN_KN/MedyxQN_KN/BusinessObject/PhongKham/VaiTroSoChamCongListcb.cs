using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
////

namespace HTC.Business.PhongKham
{

    [Serializable()]
    public class VaiTroSoChamCongListcb : NameValueListBase<byte, string>
    {
        #region Business methods
        public static byte DefaultSex()
        {
            VaiTroSoChamCongListcb list = GetList();
            if (list.Count > 0)
            {
                return list.Items[0].Key;
            }
            else
            {
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
        }
        public static byte DefaultSexx()
        {
            VaiTroSoChamCongListcb list = GetList();
            if (list.Count > 0)
            {
                return list.Items[0].Key;
            }
            else
            {
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
        }
        #endregion

        #region Factory Methods
        private static VaiTroSoChamCongListcb _list;
        public static VaiTroSoChamCongListcb GetList()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<VaiTroSoChamCongListcb>();
            }
            return _list;
        }
        //public static VaiTroSoChamCongListcb GetListKhac()
        //{
        //    _list = null;
        //    if (_list == null)
        //    {
        //        _list = DataPortal.Fetch<VaiTroSoChamCongListcb>(new Criteria(typeof(VaiTroSoChamCongListcb)));
        //    }
        //    return _list;
        //}
        /// <summary>
        /// Xóa SexList trong bộ nhớ để danh sách quốc gia sẽ được
        /// reload lại.
        /// </summary>
        /// <remarks></remarks>
        public static void InvalidateCache()
        {
            _list = null;
        }

        private VaiTroSoChamCongListcb()
        {

        }
        #endregion

        #region Data Access

        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(21, "Bác sỹ"));
            this.Add(new NameValuePair(22, "Điều dưỡng"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    this.RaiseListChangedEvents = false;
        //    IsReadOnly = false;
        //    this.Add(new NameValuePair(0, "Nhập kho theo thiết bị"));
        //    this.Add(new NameValuePair(1, "Nhập kho theo nhà cung cấp"));
        //    this.Add(new NameValuePair(2, "Nhập kho theo nguồn nhập"));
        //    this.Add(new NameValuePair(3, "Nhập kho theo hình thức"));
        //    this.Add(new NameValuePair(4, "Nhập khoa"));
        //}
        #endregion
    }
}
