using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNoiKhamList : BusinessListBase<DMNoiKhamList, DMNoiKham>
    {
        #region Factory Methods

        public static DMNoiKhamList GetAllDMNoiKham(Boolean qadmin)
        {
            return DataPortal.Fetch<DMNoiKhamList>(new Criteria(qadmin));
        }
        public void NewTo(DMNoiKham _DMNoiKham)
        {
            if (this.Count == 0)
                _DMNoiKham.OrderNumber = 1;
            else
            _DMNoiKham.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNoiKham);
        }
        public void UpdateTo(DMNoiKham _DMNoiKham)
        {
            _DMNoiKham.OrderNumber = this.Items[this.IndexOf(_DMNoiKham)].OrderNumber;
            this.Items[this.IndexOf(_DMNoiKham)] = _DMNoiKham;
        }
        public void RemoveTo(DMNoiKham _DMNoiKham)
        {
            this.Items.Remove(_DMNoiKham);
        }
        private DMNoiKhamList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNoiKham(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiKham item = new DMNoiKham(
     i,
     dr.GetString("MaNoiKham"),
     dr.GetString("TenNoiKham"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),     
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNoiKham(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiKham item = new DMNoiKham(
    i,
     dr.GetString("MaNoiKham"),
     dr.GetString("TenNoiKham"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),    
     dr.GetString("HoTen")
     );
                    this.Add(item);
                    i += 1;

                }
                if (this.Count == 0)
                {
                   
                        //MessageBox.Show("Không tồn tại nơi khám này, bạn hãy chọn nơi khám khác!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
