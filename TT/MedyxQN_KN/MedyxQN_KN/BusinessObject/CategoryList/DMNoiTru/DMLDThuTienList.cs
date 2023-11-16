using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLDThuTienList : BusinessListBase<DMLDThuTienList, DMLDThuTien>
    {
        #region Factory Methods
        public static DMLDThuTienList GetAllDMLDThuTien()
        {
            return DataPortal.Fetch<DMLDThuTienList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMLDThuTienList FindDMLDThuTienByTen(string TenLDThuTien)
        {
            return DataPortal.Fetch<DMLDThuTienList>(new CriteriaOther(2, TenLDThuTien));
        }
        public static DMLDThuTienList FindDMDichVuByMa(string MaLDThuTien)
        {
            return DataPortal.Fetch<DMLDThuTienList>(new CriteriaOther(1, MaLDThuTien));
        }
        public void NewTo(DMLDThuTien _DMLDThuTien)
        {
            if (this.Count == 0)
                _DMLDThuTien.OrderNumber = 1;
            else
            _DMLDThuTien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLDThuTien);
        }
        public void UpdatedTo(DMLDThuTien _DMLDThuTien)
        {

            _DMLDThuTien.OrderNumber = this.Items[this.IndexOf(_DMLDThuTien)].OrderNumber;
            this.Items[this.IndexOf(_DMLDThuTien)] = _DMLDThuTien;
        }
        public void RemoveTo(DMLDThuTien _DMLDThuTien)
        {
            this.Items.Remove(_DMLDThuTien);

        }

        private DMLDThuTienList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

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
                if (mIdFind == 1)
                    _DK = "MaLDThuTien like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLDThuTien)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDThuTien(criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDThuTien item = new DMLDThuTien(
                                            i,
                                            dr.GetString("MaLDThuTien") ,
			                                dr.GetString("TenLDThuTien") ,
			                                dr.GetString("GhiChu") ,
			                                dr.GetBoolean("Loai") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy")  ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
                                            dr.GetString("hoten"),
                                            dr.GetDecimal("SoNgay"),
                                            dr.GetDecimal("SoTien"),
                                             dr.GetBoolean("kieutinh")
                                                );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true;
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDThuTien(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDThuTien item = new DMLDThuTien(
                                            i,
                                           dr.GetString("MaLDThuTien"),
                                            dr.GetString("TenLDThuTien"),
                                            dr.GetString("GhiChu"),
                                            dr.GetBoolean("Loai"),
                                            dr.GetString("MaMay"),
                                            dr.GetBoolean("Huy"),
                                            dr.GetSmartDate("NgaySD", true),
                                            dr.GetString("NguoiSD"),
                                            dr.GetString("hoten"),
                                            dr.GetDecimal("SoNgay"),
                                            dr.GetDecimal("SoTien"),
                                             dr.GetBoolean("kieutinh")
                                                );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true;
        }

        #endregion
    }
}
