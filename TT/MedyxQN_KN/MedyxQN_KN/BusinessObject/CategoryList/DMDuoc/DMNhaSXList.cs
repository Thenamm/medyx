using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNhaSXList : ReadOnlyListBase<DMNhaSXList, DMNhaSX>
    {
        #region Factory Methods
        public static DMNhaSXList GetAllDMNhaSX(Byte loai)
        {
            return DataPortal.Fetch<DMNhaSXList>(new Criteria(loai,false ));
        }
    
        private DMNhaSXList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
            public Criteria(Byte mLoai, Boolean mqadmin)
            {
                _Loai = mLoai;
                _qadmin = mqadmin;
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "MaNSX like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNSX)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhaSX(criteria.Loai,criteria.qadmin )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    //try 
                    //{
                        DMNhaSX item = new DMNhaSX(
     i,
     dr.GetString("MaNSX"),
     dr.GetString("TenNSX"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("KhongSD"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("Tenta"),
     dr.GetString("hoten"),
     dr.GetString("maqg")
         );
                        this.Add(item);
                        i += 1;
                    //}
                    //catch (Exception ex)
                    //{
                    //    throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);  
                    //}
                    

                    
                }
                IsReadOnly = true;
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
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNhaSX(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    //try 
                    //{
                    DMNhaSX item = new DMNhaSX(
 i,
 dr.GetString("MaNSX"),
 dr.GetString("TenNSX"),
 dr.GetString("Ghichu"),
 dr.GetString("MaMay"),
 dr.GetByte("Loai"),
 dr.GetBoolean("Huy"),
 dr.GetBoolean("KhongSD"),
 dr.GetSmartDate("NgaySD",false),
 dr.GetString("NguoiSD"),
 dr.GetString("Tenta"),
 dr.GetString("hoten"),
 dr.GetString("maqg")
     );
                    this.Add(item);
                    i += 1;
                    //}
                    //catch (Exception ex)
                    //{
                    //    throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);  
                    //}



                }
                IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
