using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
     
    public class KhamBenh_CSTNList : BusinessListBase<KhamBenh_CSTNList, KhamBenh_CSTN>
    {
        
        #region Factory Methods
        public static KhamBenh_CSTNList GetAllKhamBenh_CSTN(Boolean qadmin, string masokham,int stt,string dk)
        {
            return DataPortal.Fetch<KhamBenh_CSTNList>(new Criteria(qadmin, masokham, stt,dk));
        }
       
        public void NewTo(KhamBenh_CSTN _KhamBenh_CSTN)
        {
            if (this.Count == 0)
                _KhamBenh_CSTN.STTTH = 1;
            else
                _KhamBenh_CSTN.STTTH = this.Items[this.Count - 1].STTTH + 1;
            this.Add(_KhamBenh_CSTN);
        }
        public void UpdatedTo(KhamBenh_CSTN _KhamBenh_CSTN)
        {

            _KhamBenh_CSTN.STTTH = this.Items[this.IndexOf(_KhamBenh_CSTN)].STTTH;
            this.Items[this.IndexOf(_KhamBenh_CSTN)] = _KhamBenh_CSTN;
        }
        public void RemoveTo(KhamBenh_CSTN _KhamBenh_CSTN)
        {
            this.Items.Remove(_KhamBenh_CSTN);

        }

        private KhamBenh_CSTNList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private int _stt;
            public int  stt
            {
                get
                {
                    return _stt;
                }
            }
            public Criteria(Boolean qadmin, string masokham, int stt, string dk)
            {
                _stt = stt;
              
                _qadmin = qadmin  ;
                _masokham = masokham;
                _DK = dk;
                
                
            }
        }


        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_CSTN(criteria.qadmin, criteria.masokham, criteria.stt, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_CSTN item = new KhamBenh_CSTN(
          dr.GetInt32("STTTH"),
           dr.GetInt32("STT"),
         dr.GetString("MaSoKham") ,
			
			 dr.GetSmartDate("NgayTH", true) ,
              dr.GetString("NoiDung"),
			 dr.GetString("GhiChu") ,
			
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetString("MaMay") ,
			 dr.GetString("Nguoihuy") ,
			 dr.GetSmartDate("Ngayhuy", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgayLap", true),
      
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy") ,
        
         dr.GetString("tenbs"),
         dr.GetString("mabs")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_CSTN  item in DeletedList)
                    item.DeleteSelf();
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_CSTN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            RaiseListChangedEvents = true;
        }
        #endregion
    }
}
