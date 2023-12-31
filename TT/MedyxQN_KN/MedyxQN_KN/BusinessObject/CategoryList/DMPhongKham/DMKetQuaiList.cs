using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKetQuaList : BusinessListBase<DMKetQuaList, DMKetQua>
    {
        //public HTC.Common.MessageBox mb; 
        #region Factory Methods

        public static DMKetQuaList GetAllDMKetQua(Boolean qadmin)
        {
            return DataPortal.Fetch<DMKetQuaList>(new Criteria(qadmin));
        }
        public void NewTo(DMKetQua _DMKetQua)
        {
            if (this.Count == 0)
                _DMKetQua.OrderNumber = 1;
            else
            _DMKetQua.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKetQua);
        }
        public void UpdateTo(DMKetQua _DMKetQua)
        {
            _DMKetQua.OrderNumber = this.Items[this.IndexOf(_DMKetQua)].OrderNumber;
            this.Items[this.IndexOf(_DMKetQua)] = _DMKetQua;
        }
        public void RemoveTo(DMKetQua DMKetQua)
        {
            this.Items.Remove(DMKetQua);
        }
        private DMKetQuaList() 
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKetQua(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKetQua item = new DMKetQua(
     i,
     dr.GetString("maKQ"),
     dr.GetString("tenKQ"),
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
                    DMKetQua item = new DMKetQua(
    i,
     dr.GetString("maKQ"),
     dr.GetString("tenKQ"),
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
                  
         
                   //MessageBox.Show("Không tồn tại kết quả điều trị  này, bạn hãy chọn kết quả điều trị khác khác!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
