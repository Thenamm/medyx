using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTGTVongList : BusinessListBase<DMTGTVongList, DMTGTVong>
    {
        //private  HTC.Common.MessageBox mb;
        #region Factory Methods

        public static DMTGTVongList GetAllDMTGTVong(Boolean qadmin)
        {
            return DataPortal.Fetch<DMTGTVongList>(new Criteria(qadmin));
        }
        public void NewTo(DMTGTVong _DMTGTVong)
        {
            if (this.Count == 0)
                _DMTGTVong.OrderNumber = 1;
            else
            _DMTGTVong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTGTVong);
        }
        public void UpdateTo(DMTGTVong _DMTGTVong)
        {
            _DMTGTVong.OrderNumber = this.Items[this.IndexOf(_DMTGTVong)].OrderNumber;
            this.Items[this.IndexOf(_DMTGTVong)] = _DMTGTVong;
        }
        public void RemoveTo(DMTGTVong _DMTGTVong)
        {
            this.Items.Remove(_DMTGTVong);
        }
        private DMTGTVongList()
        {
            //
        }


        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
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
            public Criteria(Boolean qadmin)
            {
                _qadmin = qadmin;
            }
        }

        #endregion

        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
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
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTGTVong(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTGTVong item = new DMTGTVong(
     i,
     dr.GetString("MaTGTVong"),
     dr.GetString("TenTGTVong"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen")
         );
                    this.Add(item);
                    i += 1;

                }

                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTGTVong(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTGTVong item = new DMTGTVong(
     i,
     dr.GetString("MaTGTVong"),
     dr.GetString("TenTGTVong"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen")
         );
                    this.Add(item);
                    i += 1;

                }
                if (this.Count == 0)
                {
                    
                        //MessageBox.Show("Không tồn tại thời gian tử vong này, bạn hãy chọn thời gian tử vong khác!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
