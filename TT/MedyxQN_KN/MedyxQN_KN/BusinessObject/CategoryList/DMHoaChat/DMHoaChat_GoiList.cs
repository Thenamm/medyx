using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHoaChat_GoiList : BusinessListBase<DMHoaChat_GoiList, DMHoaChat_Goi>
    {
        #region Factory Methods
        public static DMHoaChat_GoiList GetAllDMHoaChat_Goi()
        {
            return DataPortal.Fetch<DMHoaChat_GoiList>(new Criteria());
        }
        public static DMHoaChat_GoiList GetAllDMHoaChat_Goi(string MaBS)
        {
            return DataPortal.Fetch<DMHoaChat_GoiList>(new OtherCriteria(MaBS, 2));
        }
        public static DMHoaChat_GoiList GetAllDMHoaChat_Goi(string MaBS,byte loai)
        {
            return DataPortal.Fetch<DMHoaChat_GoiList>(new OtherCriteria(MaBS, loai));
        }
        public void NewTo(DMHoaChat_Goi _DMHoaChat_Goi)
        {
            if (this.Count == 0)
                _DMHoaChat_Goi.OrderNumber = 1;
            else
            _DMHoaChat_Goi.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHoaChat_Goi);
        }
        public void UpdatedTo(DMHoaChat_Goi _DMHoaChat_Goi)
        {

            _DMHoaChat_Goi.OrderNumber = this.Items[this.IndexOf(_DMHoaChat_Goi)].OrderNumber;
            this.Items[this.IndexOf(_DMHoaChat_Goi)] = _DMHoaChat_Goi;
        }
        public void RemoveTo(DMHoaChat_Goi _DMHoaChat_Goi)
        {
            this.Items.Remove(_DMHoaChat_Goi);

        }

        private DMHoaChat_GoiList()
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
           
        }


        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_Goi(criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHoaChat_Goi item = new DMHoaChat_Goi(
         i,
         dr.GetString("MaGoiHC") ,
         dr.GetString("TenGoiHC"),
         dr.GetString("Ghichu") ,
         dr.GetString("MaMay") ,
         dr.GetBoolean("Huy") ,
         dr.GetSmartDate("NgayHuy", true) ,
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap") ,
         dr.GetSmartDate("NgaySD", true) ,
         dr.GetString("NguoiSD") ,
         
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy"),
         dr.GetByte ("loai"),
         dr.GetString("mabs"),
         dr.GetString("tenbs")
        
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private class OtherCriteria
        {
             private Boolean _qadmin = false ;
           
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            public OtherCriteria(String mabs,  Byte loai)
            {
                if (loai < 2)
                {
                    if (mabs != "")
                        _dk = " and (a.mabs ='" + mabs.ToString() + "' OR ISNULL(A.MABS,'')='00000') and loai =" + loai.ToString();
                    else
                        _dk = " and loai =" + loai.ToString();
                }
                else if (mabs != "")
                    _dk = " and a.mabs ='" + mabs.ToString() + "'";
              
            }
        }


        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHoaChat_Goi(criteria.dk, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHoaChat_Goi item = new DMHoaChat_Goi(
         i,
         dr.GetString("MaGoiHC") ,
         dr.GetString("TenGoiHC"),
         dr.GetString("Ghichu") ,
         dr.GetString("MaMay") ,
         dr.GetBoolean("Huy") ,
         dr.GetSmartDate("NgayHuy", true) ,
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap") ,
         dr.GetSmartDate("NgaySD", true) ,
         dr.GetString("NguoiSD") ,
         
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy"),
         dr.GetByte("loai"),
        dr.GetString("mabs"),
        dr.GetString("tenbs")
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
