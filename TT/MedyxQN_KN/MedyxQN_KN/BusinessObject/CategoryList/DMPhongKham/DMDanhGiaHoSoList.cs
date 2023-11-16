using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
//using System.Windows.Forms;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDanhGiaHoSoList : BusinessListBase<DMDanhGiaHoSoList, DMDanhGiaHoSo>
    {
        string DatabaseOwner = "dbo.";
        String ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string ObjectQualifier = "";
        #region Factory Methods
        public static DMDanhGiaHoSoList GetAllDMDanhGiaHoSo(Boolean qadmin)
        {
            return DataPortal.Fetch<DMDanhGiaHoSoList>(new Criteria(qadmin));
        }
        // tim theo dieu kien ten
        public static DMDanhGiaHoSoList FindDMDanhGiaHoSoByTen(string TenDGHS, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDanhGiaHoSoList>(new CriteriaOther(2,TenDGHS,qadmin));
        }
        public static DMDanhGiaHoSoList FindDMDanhGiaHoSoByTenD(string TenDGHS, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDanhGiaHoSoList>(new CriteriaOther(4, TenDGHS, qadmin));
        }
        public static DMDanhGiaHoSoList FindDMDanhGiaHoSoByMa(string MaDGHS, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDanhGiaHoSoList>(new CriteriaOther(1, MaDGHS, qadmin));
        }
        public static DMDanhGiaHoSoList FindDMDanhGiaHoSoByNhomDV(string MaNhom, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDanhGiaHoSoList>(new CriteriaOther(3, MaNhom, qadmin));
        }
        public void NewTo(DMDanhGiaHoSo _DMDanhGiaHoSo)
        {
            if (this.Count == 0)
                _DMDanhGiaHoSo.OrderNumber = 1;
            else
            _DMDanhGiaHoSo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDanhGiaHoSo);
        }
        public void UpdatedTo(DMDanhGiaHoSo _DMDanhGiaHoSo)
        {

            _DMDanhGiaHoSo.OrderNumber = this.Items[this.IndexOf(_DMDanhGiaHoSo)].OrderNumber;
            this.Items[this.IndexOf(_DMDanhGiaHoSo)] = _DMDanhGiaHoSo;
        }
        public void RemoveTo(DMDanhGiaHoSo _DMDanhGiaHoSo)
        {

            //if (_DMDanhGiaHoSo.IsNew == true)
                this.Items.Remove(_DMDanhGiaHoSo);

            //else
            //    Remove(_DMDanhGiaHoSo);
        }
        public DMDanhGiaHoSo Contains(string MaDGHS)
        {
            foreach (DMDanhGiaHoSo obj in this)
                if (obj.MaDGHS == MaDGHS)
                    return obj;
            return null;
        }
        private DMDanhGiaHoSoList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
           
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Boolean mqadmin)
            {

                _qadmin = mqadmin;
            }
           
        }
        #endregion
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
            public CriteriaOther(Byte mIdFind, String mDK, Boolean qadmin)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "(MaDGHS like '" + mDK + "%' OR a.TENTAT LIKE N'" + mDK + "%')";
                else if  (mIdFind == 2) 
                        _DK = "ltrim(rtrim(TenDGHS)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All")  )
                        _DK = "ltrim(rtrim(A.MaNhom)) like N'" + mDK + "'";
                    else if (mIdFind == 4)
                        _DK = "ltrim(rtrim(TenDGHS)) like N'" + mDK + "'";
                _qadmin = qadmin;
            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_GetAll", criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGiaHoSo item = new DMDanhGiaHoSo(
 i,
 dr.GetString("MaDGHS"),
                                        dr.GetString("TenDGHS"),
                                        dr.GetString("TenNhom"),
                                        dr.GetInt32("STTNhom"),
                                        dr.GetDecimal("DiemToiDa"),
                                        dr.GetString("Ghichu"),
                                        dr.GetString("MaMay"),
                                        dr.GetSmartDate("NgayHuy", true),
                                        dr.GetString("NguoiHuy"),
                                        dr.GetSmartDate("NgayLap", true),
                                        dr.GetString("NguoiLap"),
                                        dr.GetSmartDate("NgaySD", true),
                                        dr.GetString("NguoiSD"),
                                        dr.GetBoolean("Huy"),
 dr.GetString("TenNguoiLap"),
 dr.GetString("TenNguoiSD"),
 dr.GetString("TenNguoiHuy")
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
