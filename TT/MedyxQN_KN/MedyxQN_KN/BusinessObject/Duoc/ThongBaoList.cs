using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class ThongBaoList : BusinessListBase<ThongBaoList, ThongBao >
    {
         #region Factory Methods
        public static ThongBaoList GetThongBao(String _STT)
        {
            return DataPortal.Fetch<ThongBaoList>(new Criteria(_STT ));
        }
        public static ThongBaoList GetAllThongBao(Boolean _qadmin)
        {

            return DataPortal.Fetch<ThongBaoList>(new OtherCriteria(_qadmin));
        }
        public void NewTo(ThongBao _ThongBao)
        {
            _ThongBao.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_ThongBao);
        }
        public ThongBao NewTo()
        {
             ThongBao obj = ThongBao.NewThongBao ();
              return obj;
        }
        public void UpdatedTo(ThongBao _ThongBao)
        {

            _ThongBao.OrderNumber = this.Items[this.IndexOf(_ThongBao)].OrderNumber;
            this.Items[this.IndexOf(_ThongBao)] = _ThongBao;
        }
        public void RemoveTo(ThongBao _ThongBao)
        {
            this.Items.Remove(_ThongBao);

        }
        private ThongBaoList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongBao_Get(criteria.STT )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben ThongBao vao phuong thuc (internal ThongBao)
                {
                    try 
                    {
                        ThongBao item = new ThongBao(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("Thongbao"),
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
  dr.GetString("NguoiSD1"),
  dr.GetString("conhan"),
  dr.GetString("hethan")

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongBao_GetAll(OtherCriteria.qadmin )))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben ThongBao vao phuong thuc (internal ThongBao)
                {
                    try
                    {
                        ThongBao item = new ThongBao(
     i,
  dr.GetString("Makho"),
  dr.GetString("STT"),
  dr.GetString("Thongbao"),
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
  dr.GetString("NguoiSD1"),
  dr.GetString("conhan"),
  dr.GetString("hethan")

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
