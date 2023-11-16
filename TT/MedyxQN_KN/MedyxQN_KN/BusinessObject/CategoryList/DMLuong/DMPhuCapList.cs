using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMPhuCapList : BusinessListBase<DMPhuCapList, DMPhuCap>
    {
        #region Factory Methods
        public static DMPhuCapList GetAllDMPhuCap()
        {
            return DataPortal.Fetch<DMPhuCapList>(new Criteria() );
        }
        // tim theo dieu kien ten 
        public static DMPhuCapList FindDMPhuCapByTen(string TenPhuCap)
        {
            return DataPortal.Fetch<DMPhuCapList>(new CriteriaOther(2, TenPhuCap));
        }
        public static DMPhuCapList FindDMDichVuByMa(string MaPhuCap)
        {
            return DataPortal.Fetch<DMPhuCapList>(new CriteriaOther(1, MaPhuCap));
        }
        public static DMPhuCapList FindDMPhuCapByNhomPC(string maNhom)
        {
            return DataPortal.Fetch<DMPhuCapList>(new CriteriaOther(3, maNhom));
        }

        public void NewTo(DMPhuCap _DMPhuCap)
        {
            if (this.Count == 0)
                _DMPhuCap.OrderNumber = 1;
            else
            _DMPhuCap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMPhuCap);
        }
        public void UpdatedTo(DMPhuCap _DMPhuCap)
        {

            _DMPhuCap.OrderNumber = this.Items[this.IndexOf(_DMPhuCap)].OrderNumber;
            this.Items[this.IndexOf(_DMPhuCap)] = _DMPhuCap;
        }
        public void RemoveTo(DMPhuCap _DMPhuCap)
        {
            this.Items.Remove(_DMPhuCap);

        }

        private DMPhuCapList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
            private Boolean _qadmin = false ;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Byte mLoai)
            //{
            //    _Loai = mLoai;
                
            //}
        }

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                _DK = "";
                if (mIdFind == 1)
                    _DK = "MAPhuCap like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenPhuCap)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All"))
                    _DK = "and MaNhom like '%" + mDK + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhuCap( criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhuCap item = new DMPhuCap(
     i,
     dr.GetString("MaPhuCap"),
     dr.GetString("MaNhom"), 
     dr.GetString("TenPhuCap"),
     dr.GetBoolean("Loai"),
     dr.GetBoolean("CoBan"),
     dr.GetDecimal("HeSo"),
     dr.GetDecimal("MucLuong"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("GhiChu")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhuCap(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhuCap item = new DMPhuCap(
     i,
    dr.GetString("MaPhuCap"),
    dr.GetString("MaNhom"), 
     dr.GetString("TenPhuCap"),
     dr.GetBoolean("Loai"),
     dr.GetBoolean("CoBan"),
     dr.GetDecimal("HeSo"),
     dr.GetDecimal("MucLuong"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("GhiChu")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
