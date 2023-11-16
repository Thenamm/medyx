using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
////

namespace HTC.Business.Luong
{

    [Serializable()]
    public class PhanLoaiLuong_TTTMListcb : NameValueListBase<byte, string>
    {
        #region Business methods
        public static byte DefaultSex()
        {
            PhanLoaiLuong_TTTMListcb list = GetList();
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
            PhanLoaiLuong_TTTMListcb list = GetList();
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
        private static PhanLoaiLuong_TTTMListcb _list;
        public static PhanLoaiLuong_TTTMListcb GetList()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<PhanLoaiLuong_TTTMListcb>();
            }
            return _list;
        }
        //public static PhanLoaiLuong_TTTMListcb GetListKhac()
        //{
        //    _list = null;
        //    if (_list == null)
        //    {
        //        _list = DataPortal.Fetch<PhanLoaiLuong_TTTMListcb>(new Criteria(typeof(PhanLoaiLuong_TTTMListcb)));
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

        private PhanLoaiLuong_TTTMListcb()
        {

        }
        #endregion

        #region Data Access

        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Phẫu thuật viên"));
            this.Add(new NameValuePair(1, "Dụng cụ"));
            this.Add(new NameValuePair(2, "Gây mê"));
            this.Add(new NameValuePair(3, "CEC"));
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
