using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMBaiThuocList : BusinessListBase<DMBaiThuocList, DMBaiThuoc>
    {
        #region Factory Methods
        public static DMBaiThuocList GetAllDMBaiThuoc()
        {
            return DataPortal.Fetch<DMBaiThuocList>(new Criteria());
        }
        public static DMBaiThuocList GetAllDMBaiThuoc(string MaBS)
        {
            return DataPortal.Fetch<DMBaiThuocList>(new OtherCriteria(MaBS, 2));
        }
        public static DMBaiThuocList GetAllDMBaiThuoc(string MaBS,byte loai)
        {
            return DataPortal.Fetch<DMBaiThuocList>(new OtherCriteria(MaBS, loai));
        }
        public void NewTo(DMBaiThuoc _DMBaiThuoc)
        {
            if (this.Count == 0)
                _DMBaiThuoc.OrderNumber = 1;
            else
            _DMBaiThuoc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMBaiThuoc);
        }
        public void UpdatedTo(DMBaiThuoc _DMBaiThuoc)
        {

            _DMBaiThuoc.OrderNumber = this.Items[this.IndexOf(_DMBaiThuoc)].OrderNumber;
            this.Items[this.IndexOf(_DMBaiThuoc)] = _DMBaiThuoc;
        }
        public void RemoveTo(DMBaiThuoc _DMBaiThuoc)
        {
            this.Items.Remove(_DMBaiThuoc);

        }

        private DMBaiThuocList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMBaiThuoc(criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMBaiThuoc item = new DMBaiThuoc(
         i,
         dr.GetString("MaBThuoc") ,
         dr.GetString("TenBThuoc"),
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
                else
                        _dk = " and loai =" + loai.ToString();
              
            }
        }


        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMBaiThuoc(criteria.dk, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMBaiThuoc item = new DMBaiThuoc(
         i,
         dr.GetString("MaBThuoc") ,
         dr.GetString("TenBThuoc"),
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
