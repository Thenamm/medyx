using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_THChuyenMon_ListInfo : BusinessListBase<BC_THChuyenMon_ListInfo, BC_THChuyenMon_Info>
    {
        #region Factory Methods

        public static BC_THChuyenMon_ListInfo GetAllChuyenMon(DateTime tuthang, DateTime denthang,  String dk)
        {
            return DataPortal.Fetch<BC_THChuyenMon_ListInfo>(new Criteria(tuthang ,denthang ,dk ));
        }

        public void NewTo(BC_THChuyenMon_Info _BC_THChuyenMon_Info)
        {
            _BC_THChuyenMon_Info.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BC_THChuyenMon_Info);
        }
        public void UpdatedTo(BC_THChuyenMon_Info _BC_THChuyenMon_Info)
        {

            _BC_THChuyenMon_Info.OrderNumber = this.Items[this.IndexOf(_BC_THChuyenMon_Info)].OrderNumber;
            this.Items[this.IndexOf(_BC_THChuyenMon_Info)] = _BC_THChuyenMon_Info;
        }

        public void RemoveTo(BC_THChuyenMon_Info _BC_THChuyenMon_Info)
        {
            this.Items.Remove(_BC_THChuyenMon_Info);

        }

             
        private BC_THChuyenMon_ListInfo()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion


        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private DateTime _TuThang;
            private DateTime _DenThang;
            private String _DK;
           
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
           
            public DateTime TuThang
            {
                get
                {
                    return _TuThang;
                }
            }
            public DateTime DenThang
            {
                get
                {
                    return _DenThang;
                }
            }
            public Criteria(DateTime mTuThang, DateTime mDenThang,  String dk)
            {
                _TuThang = mTuThang ;
                _DenThang = mDenThang;
                _DK  = dk  ;
               
                
            }
        }
                     
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_THChuyenMon(SmartDate.Parse(criteria.TuThang.ToString()), SmartDate.Parse(criteria.DenThang.ToString()), criteria.DK,false )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BC_THChuyenMon_Info item = new BC_THChuyenMon_Info(
     i,
      dr.GetString("mabc"),
     dr.GetSmartDate("tungay",true ),
     dr.GetSmartDate("denngay", true) ,
     dr.GetByte("loaibc") ,
     dr.GetSmartDate("NGAYSD", true) ,
     dr.GetString("tennguoisd"),
     dr.GetBoolean("Huy"),
     dr.GetString("MAMAY") 
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
