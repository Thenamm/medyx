using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKQDTriList : BusinessListBase<DMKQDTriList, DMKQDTri>
    {
        //public HTC.Common.MessageBox mb; 
        #region Factory Methods

        public static DMKQDTriList GetAllDMKQDTri(Boolean qadmin)
        {
            return DataPortal.Fetch<DMKQDTriList>(new Criteria(qadmin));
        }
        public void NewTo(DMKQDTri _DMKQDTri)
        {
            if (this.Count == 0)
                _DMKQDTri.OrderNumber = 1;
            else
            _DMKQDTri.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKQDTri);
        }
        public void UpdateTo(DMKQDTri _DMKQDTri)
        {
            _DMKQDTri.OrderNumber = this.Items[this.IndexOf(_DMKQDTri)].OrderNumber;
            this.Items[this.IndexOf(_DMKQDTri)] = _DMKQDTri;
        }
        public void RemoveTo(DMKQDTri DMKQDTri)
        {
            this.Items.Remove(DMKQDTri);
        }
        private DMKQDTriList() 
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKQDTri(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKQDTri item = new DMKQDTri(
     i,
     dr.GetString("MaKQDT"),
     dr.GetString("TenKQDT"),
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
                    DMKQDTri item = new DMKQDTri(
    i,
     dr.GetString("MaKQDT"),
     dr.GetString("TenKQDT"),
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
