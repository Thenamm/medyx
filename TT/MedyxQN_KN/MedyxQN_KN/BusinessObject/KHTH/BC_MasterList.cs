using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_MasterList : BusinessListBase<BC_MasterList, BC_Master>
    {
        #region Factory Methods
        public static BC_MasterList GetAllBC_Master(string loaiBC)
        {
            return DataPortal.Fetch<BC_MasterList>(new Criteria( loaiBC,  ""));
        }
        // tim theo dieu kien ten
        public static BC_MasterList GetAllBC_Master(String loaiBC, DateTime tungay, DateTime denngay)
        {

            string _dk = "";
            if (tungay > DateTime.Parse("01/01/1900"))
                _dk = _dk + " and (datediff(d,denngay,'" + tungay.Month.ToString() + "/" + tungay.Day.ToString() + "/" + tungay.Year.ToString() +  "') <=0";

            if (denngay > DateTime.Parse("01/01/1900"))
                _dk = _dk + " or datediff(d,tungay,'" + denngay.Month.ToString() + "/" + denngay.Day.ToString() + "/" + denngay.Year.ToString() + "') <=0)";
            return DataPortal.Fetch<BC_MasterList>(new Criteria(loaiBC, _dk));
        }
        public static BC_MasterList GetAllBC_Master(String loaiBC, string nam)
        {

            string _dk = "";
            if (nam !="")
                _dk = _dk + " and year(tungay)="+nam;

            return DataPortal.Fetch<BC_MasterList>(new Criteria(loaiBC, _dk));
        }
        public void NewTo(BC_Master _BC_Master)
        {
            if (this.Count == 0)
                _BC_Master.OrderNumber = 1;
            else
            _BC_Master.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BC_Master);
        }
        public void UpdatedTo(BC_Master _BC_Master)
        {

            _BC_Master.OrderNumber = this.Items[this.IndexOf(_BC_Master)].OrderNumber;
            this.Items[this.IndexOf(_BC_Master)] = _BC_Master;
        }
        public void RemoveTo(BC_Master _BC_Master)
        {
            this.Items.Remove(_BC_Master);

        }

        private BC_MasterList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _LoaiBC;
            private Boolean _qadmin = false ;
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            public string LoaiBC
            {
                get
                {
                    return _LoaiBC;
                }
            }
           
            public Criteria(string mLoaiBC,string mdk)
            {
                _LoaiBC = mLoaiBC;
                _DK = mdk;
                
            }
        }

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_Master(criteria.LoaiBC, criteria.DK,false )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BC_Master item = new BC_Master(
     i,
     dr.GetString("MaBC") ,
			                                dr.GetString("LoaiBC") ,
			                                dr.GetSmartDate("NgayBC", true) ,
			                                dr.GetSmartDate("TuNgay", true) ,
			                                dr.GetSmartDate("DenNgay", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("Ngaylap", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("Ngaysd", true) ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetBoolean("Huy") ,
     dr.GetString("tenNguoiSD"),
      dr.GetString("tenNguoiHuy"),
      dr.GetString("tenNguoiLap"),

	  dr.GetInt32("Thutu"),
	 dr.GetSmartDate("Thang"),
	dr.GetByte("PhanloaiBC")
    
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
