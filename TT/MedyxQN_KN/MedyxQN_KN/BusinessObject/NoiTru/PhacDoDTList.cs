using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class PhacDoDTList : BusinessListBase<PhacDoDTList, PhacDoDT >
    {
         #region Factory Methods
        public static PhacDoDTList GetAllPhacDoDT(Boolean _qadmin, String _mabenh, String _tenbenh, String _mabenhkem, String _tenbenhkem)
        {
            return DataPortal.Fetch<PhacDoDTList>(new Criteria(_qadmin, _mabenh, _tenbenh, _mabenhkem, _tenbenhkem));
        }
        public void NewTo(PhacDoDT _PhacDoDT)
        {
            _PhacDoDT.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhacDoDT);
        }
        public PhacDoDT NewTo()
        {
             PhacDoDT obj = PhacDoDT.NewPhacDoDT ();
              return obj;
        }
        public void UpdatedTo(PhacDoDT _PhacDoDT)
        {

            _PhacDoDT.OrderNumber = this.Items[this.IndexOf(_PhacDoDT)].OrderNumber;
            this.Items[this.IndexOf(_PhacDoDT)] = _PhacDoDT;
        }
        public void RemoveTo(PhacDoDT _PhacDoDT)
        {
            this.Items.Remove(_PhacDoDT);

        }
        private PhacDoDTList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
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
            private String _mabenh;
            public String mabenh
            {
                get
                {
                    return _mabenh;
                }
            }
            private String _tenbenh;
            public String tenbenh
            {
                get
                {
                    return _tenbenh;
                }
            }

            private String _mabenhkem;
            public String mabenhkem
            {
                get
                {
                    return _mabenhkem;
                }
            }
            private String _tenbenhkem;
            public String tenbenhkem
            {
                get
                {
                    return _tenbenhkem;
                }
            }
          
            public Criteria(Boolean qadmin, String mabenh, String tenbenh, String mabenhkem, String tenbenhkem)
            {
                _qadmin = qadmin;
                _mabenh = mabenh;
                _tenbenh = tenbenh;
                _mabenhkem = mabenhkem;
                _tenbenhkem = tenbenhkem;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhacDoDT_GetAll(criteria.qadmin, criteria.mabenh, criteria.tenbenh, criteria.mabenhkem, criteria.tenbenhkem,"")))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben PhacDoDT vao phuong thuc (internal PhacDoDT)
                {
                    try 
                    {
                        PhacDoDT item = new PhacDoDT(
                                            i,
                                            dr.GetString("MaPD") ,
                                            dr.GetString("mabenh") ,
                                              dr.GetString("tenbenh"),
                                                dr.GetString("maicd"),
                                                dr.GetString("mabenhkem"),
                                              dr.GetString("tenbenhkem"),
                                                dr.GetString("maicdkem"),
                                                  dr.GetString("giaidoan"),
                                                  dr.GetBoolean("GTNu"),
                                                  dr.GetBoolean("GTNam"),
                                                    dr.GetByte("TuoiTu"),
                                                    dr.GetByte("TuoiDen"),
                                            dr.GetString("VungAD") ,
                                            dr.GetString("MoTa"), 
                                         
                                            dr.GetString("XuTri"),
                                          
                                            dr.GetString("TruocPD"),
                                              dr.GetString("SauPD"),
                                           
                                            dr.GetString("Ghichu"),
                                            dr.GetBoolean("Huy"),
                                            dr.GetSmartDate("NgaySD", false),
                                            dr.GetString("NguoiSD"),
                                            dr.GetSmartDate("NgaySD1", false),
                                            dr.GetString("NguoiSD1"),
                                        
                                            dr.GetSmartDate("NgayLap", false),
                                            dr.GetString("NguoiLap"),
                                            dr.GetSmartDate("NgayHuy", false),
                                            dr.GetString("NguoiHuy"),
                                            dr.GetString("MaMay"),
                                        
                                            dr.GetString("TENNGUOILAP"),
                                            dr.GetString("TENNGUOISD"),
                                            dr.GetString("TENNGUOIHUY")
                                          
                                     );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       //MessageBox.Show(ex.ToString());
                    }
                    
                }
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
            }
          

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

    
        #endregion
    }
}
