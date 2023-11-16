using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKyHieuList : BusinessListBase<DMKyHieuList, DMKyHieu >
    {
         #region Factory Methods
        public static DMKyHieuList GetDMKyHieu(string _MaKho, String _STT, bool Qadmin)
        {
            return DataPortal.Fetch<DMKyHieuList>(new Criteria(_MaKho,  _STT, Qadmin  ));
        }
        public static DMKyHieuList GetAllDMKyHieu(String _maKho, bool Qadmin )
        {

            return DataPortal.Fetch<DMKyHieuList>(new OtherCriteria(_maKho, Qadmin ));
        }
        public void NewTo(DMKyHieu _DMKyHieu)
        {
            _DMKyHieu.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKyHieu);
        }
        //public DMKyHieu NewTo()
        //{
        //     DMKyHieu obj = DMKyHieu.NewDMKyHieu ();
        //      return obj;
        //}
        public void UpdatedTo(DMKyHieu _DMKyHieu)
        {

            _DMKyHieu.OrderNumber = this.Items[this.IndexOf(_DMKyHieu)].OrderNumber;
            this.Items[this.IndexOf(_DMKyHieu)] = _DMKyHieu;
        }
        public void RemoveTo(DMKyHieu _DMKyHieu)
        {
            this.Items.Remove(_DMKyHieu);

        }
        private DMKyHieuList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
             private String _MaKho;
            public String MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
            private String _sTT;
            public String STT
            {
                get
                {
                    return _sTT;
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
            public Criteria( String maKho, string sTT, bool Qadmin)
            {
                _MaKho = maKho;
                _sTT = sTT ;
                _qadmin = Qadmin;
            }
        }
        #endregion
        #region OtherCriteria
        [Serializable()]
        private class OtherCriteria
        {
            private string _maKho;
            public string MaKho
            {
                get
                {
                    return _maKho;
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
            public OtherCriteria( string maKho, bool Qadmin)
            {
                _maKho= maKho ;
                _qadmin = Qadmin;
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKyHieu_Get(criteria.MaKho ,criteria.STT   )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben DMKyHieu vao phuong thuc (internal DMKyHieu)
                {
                    try 
                    {
                        DMKyHieu item = new DMKyHieu(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("DMKyHieu"),
  dr.GetBoolean("Huy"),        
  dr.GetSmartDate("NgaySD", true),
  dr.GetString("NguoiSD"),
  dr.GetSmartDate("NgayLap", true),
  dr.GetString("NguoiLap"),
  dr.GetSmartDate("NgayHuy", true),
  dr.GetString("NguoiHuy"),
  dr.GetSmartDate("NgaySD1", true),
  dr.GetString("NguoiSD1"),
  dr.GetString ("TenNguoiLap"),
  dr.GetString ("TenNguoiHuy"),
  dr.GetString("TenNguoiSD"),
  dr.GetString ("TenNguoiSD1")

  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       //MessageBox.Show(ex.ToString());
                    }
                    
                }
               
            }           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria OtherCriteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKyHieu_GetAll(OtherCriteria.MaKho,HTC.ShareVariables .pub_bQadmin   )))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben DMKyHieu vao phuong thuc (internal DMKyHieu)
                {
                    try
                    {
                        DMKyHieu item = new DMKyHieu(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("KyHieu"),
  dr.GetBoolean("Huy"),                      
  dr.GetSmartDate("NgaySD", true),
  dr.GetString("NguoiSD"),
  dr.GetSmartDate("NgayLap", true),
  dr.GetString("NguoiLap"),
  dr.GetSmartDate("NgayHuy", true),
  dr.GetString("NguoiHuy"),
  dr.GetSmartDate("NgaySD1", true),
  dr.GetString("NguoiSD1"),
  dr.GetString("TenNguoiLap"),
  dr.GetString("TenNguoiHuy"),
  dr.GetString("TenNguoiSD"),
  dr.GetString("TenNguoiSD1")


  );

                        this.Add(item);
                        i += 1;
                    }
                    catch (Exception ex)
                    {
                       //MessageBox.Show(ex.ToString());
                    }

                }

            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
