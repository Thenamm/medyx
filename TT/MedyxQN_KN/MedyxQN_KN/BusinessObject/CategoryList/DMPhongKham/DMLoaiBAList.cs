using System;
using System.Collections.Generic;
using System.Text;
using Csla ;
using Csla.Data;
 //using System.Windows.Forms;
 
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoaiBAList : BusinessListBase<DMLoaiBAList ,DMLoaiBA>
    {
        #region Factory Methods

        public static DMLoaiBAList GetAllDMLoaiBA(Boolean qadmin)
        {
            return DataPortal.Fetch<DMLoaiBAList>(new Criteria(qadmin));
        }
        public void NewTo(DMLoaiBA _DMLoaiBA)
        {
            if (this.Count == 0)
                _DMLoaiBA.OrderNumber = 1;
            else
            _DMLoaiBA.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLoaiBA); 
        }
        public void UpdateTo(DMLoaiBA _DMLoaiBA)
        {
            _DMLoaiBA.OrderNumber = this.Items[this.IndexOf(_DMLoaiBA)].OrderNumber;
            this.Items[this.IndexOf(_DMLoaiBA)] = _DMLoaiBA;
        }
        public void RemoveTo(DMLoaiBA _DMLoaiBA)
        {
            this.Items.Remove(_DMLoaiBA); 
        }
        private DMLoaiBAList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiBA(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiBA item = new DMLoaiBA(
     i,
     dr.GetString("MaLoaiBA"), 
     dr.GetString("TenLoaiBA"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiBA(  criteria.DK,criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiBA item = new DMLoaiBA(
    i,
     dr.GetString("MaLoaiBA"),
     dr.GetString("TenLoaiBA"),
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
                   //MessageBox.Show("Không tồn tại dịch vụ này, bạn hãy chọn dịch vụ khác!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
