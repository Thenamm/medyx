using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHuongDTList : BusinessListBase<DMHuongDTList, DMHuongDT>
    {
        #region Factory Methods
        public static DMHuongDTList GetAllDMHuongDT(Byte loai, string nguoisd)
        {
            return DataPortal.Fetch<DMHuongDTList>(new Criteria(loai, nguoisd  ));
        }
        public void NewTo(DMHuongDT _DMHuongDT)
        {
            if (this.Count == 0)
                _DMHuongDT.OrderNumber = 1;
            else
            _DMHuongDT.OrderNumber  = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHuongDT);            
        }
        public void UpdatedTo(DMHuongDT _DMHuongDT)
        {
            _DMHuongDT.OrderNumber = this.Items[this.IndexOf(_DMHuongDT)].OrderNumber; 
            this.Items[this.IndexOf(_DMHuongDT)] = _DMHuongDT;
        }
        public void RemoveTo(DMHuongDT _DMHuongDT)
        {
            this.Items.Remove(_DMHuongDT);
            
        }
        private DMHuongDTList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
            private string _NguoiSD = "" ;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public string NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public Criteria(Byte mLoai, string mNguoiSD)
            {
                _Loai = mLoai;
                _NguoiSD = mNguoiSD;
            }
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
                    _DK = "MaHDT like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHDT)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHuongDT(criteria.Loai,false )))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHuongDT item = new DMHuongDT(
     i,
     dr.GetString("MaHDT"), 
     dr.GetString ("TenHDT"),
     dr.GetString("Ghichu"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetByte("Loai"), 
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("HoTen")
    
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }


        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHuongDT(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHuongDT item = new DMHuongDT(
     i,
     dr.GetString("MaHDT"),
     dr.GetString("TenHDT"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetByte("Loai"),
     dr.GetSmartDate("NgaySD",false),
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
        #endregion
    }
}
