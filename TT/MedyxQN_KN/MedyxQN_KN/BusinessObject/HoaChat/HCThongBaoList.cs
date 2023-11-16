using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCThongBaoList : BusinessListBase<HCThongBaoList, HCThongBao >
    {
         #region Factory Methods
        public static HCThongBaoList GetHCThongBao(String _STT)
        {
            return DataPortal.Fetch<HCThongBaoList>(new Criteria(_STT ));
        }
        public static HCThongBaoList GetAllHCThongBao(Boolean _qadmin)
        {

            return DataPortal.Fetch<HCThongBaoList>(new OtherCriteria(_qadmin));
        }
        public void NewTo(HCThongBao _HCThongBao)
        {
            _HCThongBao.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HCThongBao);
        }
        public HCThongBao NewTo()
        {
             HCThongBao obj = HCThongBao.NewHCThongBao ();
              return obj;
        }
        public void UpdatedTo(HCThongBao _HCThongBao)
        {

            _HCThongBao.OrderNumber = this.Items[this.IndexOf(_HCThongBao)].OrderNumber;
            this.Items[this.IndexOf(_HCThongBao)] = _HCThongBao;
        }
        public void RemoveTo(HCThongBao _HCThongBao)
        {
            this.Items.Remove(_HCThongBao);

        }
        private HCThongBaoList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            private String _sTT;
            public String STT
            {
                get
                {
                    return _sTT;
                }
            }
            
           
            public Criteria( String sTT)
            {
                _sTT = sTT ;
            }
        }
        #endregion
        #region OtherCriteria
        [Serializable()]
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


            public OtherCriteria( Boolean qadmin)
            {
                _qadmin = qadmin;
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCThongBao_Get(criteria.STT )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben HCThongBao vao phuong thuc (internal HCThongBao)
                {
                    try 
                    {
                        HCThongBao item = new HCThongBao(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("HCThongBao"),
  dr.GetBoolean("Huy"),
  dr.GetSmartDate("TuNgay", true),
  dr.GetSmartDate("Denngay", true),
  dr.GetSmartDate("NgaySD", true),
  dr.GetString("NguoiSD"),
  dr.GetSmartDate("NgayLap", true),
  dr.GetString("NguoiLap"),
  dr.GetSmartDate("NgayHuy", true),
  dr.GetString("NguoiHuy"),
  dr.GetSmartDate("NgaySD1", true),
  dr.GetString("NguoiSD1")

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCThongBao_GetAll(OtherCriteria.qadmin )))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben HCThongBao vao phuong thuc (internal HCThongBao)
                {
                    try
                    {
                        HCThongBao item = new HCThongBao(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("HCThongBao"),
  dr.GetBoolean("Huy"),
  dr.GetSmartDate("TuNgay", true),
  dr.GetSmartDate("Denngay", true),
  dr.GetSmartDate("NgaySD", true),
  dr.GetString("NguoiSD"),
  dr.GetSmartDate("NgayLap", true),
  dr.GetString("NguoiLap"),
  dr.GetSmartDate("NgayHuy", true),
  dr.GetString("NguoiHuy"),
  dr.GetSmartDate("NgaySD1", true),
  dr.GetString("NguoiSD1")

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
