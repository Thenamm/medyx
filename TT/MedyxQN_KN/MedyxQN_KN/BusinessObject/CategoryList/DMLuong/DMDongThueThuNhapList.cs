
using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDongThueThuNhapList : BusinessListBase<DMDongThueThuNhapList, DMDongThueThuNhap>
    {
        #region Factory Methods
        public static DMDongThueThuNhapList GetAllDMDongThueThuNhap()
        {
            return DataPortal.Fetch<DMDongThueThuNhapList>(new Criteria());
        }
        public void NewTo(DMDongThueThuNhap _DMDongThueThuNhap)
        {
            if (this.Count == 0)
                _DMDongThueThuNhap.OrderNumber = 1;
            else
                _DMDongThueThuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDongThueThuNhap);
        }
        public void UpdatedTo(DMDongThueThuNhap _DMDongThueThuNhap)
        {

            _DMDongThueThuNhap.OrderNumber = this.Items[this.IndexOf(_DMDongThueThuNhap)].OrderNumber;
            this.Items[this.IndexOf(_DMDongThueThuNhap)] = _DMDongThueThuNhap;
        }
        public void RemoveTo(DMDongThueThuNhap _DMDongThueThuNhap)
        {
            this.Items.Remove(_DMDongThueThuNhap);

        }

        private DMDongThueThuNhapList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
        }

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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "TenDongThueThuNhap like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDongThueThuNhap)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDongThueThuNhap(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMDongThueThuNhap item = new DMDongThueThuNhap(
     i,
     dr.GetString("MaDongThueThuNhap") ,
     dr.GetString("TenDongThueThuNhap") ,
     dr.GetString("GhiChu") ,
     dr.GetDecimal("SoTienTu") ,
     dr.GetDecimal("SoTienDen") ,
     dr.GetDecimal("HeSo"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),                           
     dr.GetString("HoTen")

         );
                    this.Add(item);
                    i += 1;

                }
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDongThueThuNhap(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMDongThueThuNhap item = new DMDongThueThuNhap(
     i,
     dr.GetString("MaDongThueThuNhap"),
     dr.GetString("TenDongThueThuNhap"),
     dr.GetString("GhiChu"),
     dr.GetDecimal("SoTienTu"),
     dr.GetDecimal("SoTienDen"),
     dr.GetDecimal("HeSo"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("HoTen")

         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}

