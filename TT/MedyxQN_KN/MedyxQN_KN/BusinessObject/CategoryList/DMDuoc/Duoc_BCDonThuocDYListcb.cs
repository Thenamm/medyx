using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class Duoc_BCDonThuocDYListcb : NameValueListBase<byte, string>
    {
        #region Business methods
        public static byte DefaultSex()
        {
            Duoc_BCDonThuocDYListcb list = GetList();
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
        private static Duoc_BCDonThuocDYListcb _list;
        
        public static Duoc_BCDonThuocDYListcb GetList()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<Duoc_BCDonThuocDYListcb>();
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

        private Duoc_BCDonThuocDYListcb()
        {

        }
        #endregion

        #region Data Access
        
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Thuốc Tây y"));

            if (HTC.ShareVariables.pub_spC == "YH")
            {
                this.Add(new NameValuePair(1, "Cao đơn hoàn tán"));
            }
            if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "QN")
            {
                this.Add(new NameValuePair(2, "Thuốc đông y"));
            }
           // this.Add(new NameValuePair(3, "Tổng hợp thuốc tây y - cao đơn -dịch truyền"));  
                        IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
