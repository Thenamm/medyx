using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoaiBNList : BusinessListBase<DMLoaiBNList, DMLoaiBN>
    {
        #region Factory Methods

        public static DMLoaiBNList GetAllDMLoaiBN(Boolean qadmin)
        {
            return DataPortal.Fetch<DMLoaiBNList>(new Criteria(qadmin));
        }
        public void NewTo(DMLoaiBN _DMLoaiBN)
        {
            if (this.Count == 0)
                _DMLoaiBN.OrderNumber = 1;
            else
            _DMLoaiBN.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLoaiBN);
        }
        public void UpdateTo(DMLoaiBN _DMLoaiBN)
        {
            _DMLoaiBN.OrderNumber = this.Items[this.IndexOf(_DMLoaiBN)].OrderNumber;
            this.Items[this.IndexOf(_DMLoaiBN)] = _DMLoaiBN;
        }
        public void RemoveTo(DMLoaiBN _DMLoaiBN)
        {
            this.Items.Remove(_DMLoaiBN);
        }
        private DMLoaiBNList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiBN(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiBN item = new DMLoaiBN(
     i,
     dr.GetString("MaLoaiBN"),
     dr.GetString("TenLoaiBN"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiBN(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiBN item = new DMLoaiBN(
     i,
     dr.GetString("MaLoaiBN"),
     dr.GetString("TenLoaiBN"),
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
