using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLDTVongList : BusinessListBase<DMLDTVongList, DMLDTVong>
    {
        //public HTC.Common.MessageBox mb; 
        #region Factory Methods

        public static DMLDTVongList GetAllDMLDTVong(Boolean qadmin)
        {
            return DataPortal.Fetch<DMLDTVongList>(new Criteria(qadmin));
        }
        public void NewTo(DMLDTVong _DMLDTVong)
        {
            if (this.Count == 0)
                _DMLDTVong.OrderNumber = 1;
            else
            _DMLDTVong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLDTVong);
        }
        public void UpdateTo(DMLDTVong _DMLDTVong)
        {
            _DMLDTVong.OrderNumber = this.Items[this.IndexOf(_DMLDTVong)].OrderNumber;
            this.Items[this.IndexOf(_DMLDTVong)] = _DMLDTVong;
        }
        public void RemoveTo(DMLDTVong _DMLDTVong)
        {
            this.Items.Remove(_DMLDTVong);
        }
        private DMLDTVongList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDTVong(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDTVong item = new DMLDTVong(
     i,
     dr.GetString("MaLDTVong"),
     dr.GetString("TenLDTVong"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDTVong(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDTVong item = new DMLDTVong(
    i,
     dr.GetString("MaLDTVong"),
     dr.GetString("TenLDTVong"),
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
                   //MessageBox.Show("Không tồn tại lý do tử vong này, bạn hãy chọn lý do tử vong khác!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
