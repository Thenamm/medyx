using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChePhamMau_GoiList : BusinessListBase<DMChePhamMau_GoiList, DMChePhamMau_Goi>
    {
        #region Factory Methods
        public static DMChePhamMau_GoiList GetAllDMChePhamMau_Goi()
        {
            return DataPortal.Fetch<DMChePhamMau_GoiList>(new Criteria());
        }
        public static DMChePhamMau_GoiList GetAllDMChePhamMau_Goi(string MaBS)
        {
            return DataPortal.Fetch<DMChePhamMau_GoiList>(new OtherCriteria(MaBS, 2));
        }
        public static DMChePhamMau_GoiList GetAllDMChePhamMau_Goi(string MaBS,byte loai)
        {
            return DataPortal.Fetch<DMChePhamMau_GoiList>(new OtherCriteria(MaBS, loai));
        }
        public void NewTo(DMChePhamMau_Goi _DMChePhamMau_Goi)
        {
            if (this.Count == 0)
                _DMChePhamMau_Goi.OrderNumber = 1;
            else
            _DMChePhamMau_Goi.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMChePhamMau_Goi);
        }
        public void UpdatedTo(DMChePhamMau_Goi _DMChePhamMau_Goi)
        {

            _DMChePhamMau_Goi.OrderNumber = this.Items[this.IndexOf(_DMChePhamMau_Goi)].OrderNumber;
            this.Items[this.IndexOf(_DMChePhamMau_Goi)] = _DMChePhamMau_Goi;
        }
        public void RemoveTo(DMChePhamMau_Goi _DMChePhamMau_Goi)
        {
            this.Items.Remove(_DMChePhamMau_Goi);

        }

        private DMChePhamMau_GoiList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMau_Goi(criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau_Goi item = new DMChePhamMau_Goi(
         i,
         dr.GetString("MaGoiCPMau") ,
         dr.GetString("TenGoiCPMau"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChePhamMau_Goi(criteria.dk, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau_Goi item = new DMChePhamMau_Goi(
         i,
         dr.GetString("MaGoiCPMau") ,
         dr.GetString("TenGoiCPMau"),
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
