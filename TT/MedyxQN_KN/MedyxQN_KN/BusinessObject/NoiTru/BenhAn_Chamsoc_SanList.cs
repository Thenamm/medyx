using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_Chamsoc_SanList : BusinessListBase<BenhAn_Chamsoc_SanList, BenhAn_Chamsoc_San>
    {
        #region Factory Methods
        public static BenhAn_Chamsoc_SanList GetAllBenhAn_Chamsoc_San(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_Chamsoc_SanList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Chamsoc_San _BenhAn_Chamsoc_San)
        {
            if (this.Count == 0)
                _BenhAn_Chamsoc_San.OrderNumber = 1;
            else
            _BenhAn_Chamsoc_San.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Chamsoc_San);
        }
        public void UpdatedTo(BenhAn_Chamsoc_San _BenhAn_Chamsoc_San)
        {

            _BenhAn_Chamsoc_San.OrderNumber = this.Items[this.IndexOf(_BenhAn_Chamsoc_San)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Chamsoc_San)] = _BenhAn_Chamsoc_San;
        }
        public void RemoveTo(BenhAn_Chamsoc_San _BenhAn_Chamsoc_San)
        {
            this.Items.Remove(_BenhAn_Chamsoc_San);

        }

        private BenhAn_Chamsoc_SanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            
            private Byte _STTKhoa;
            public Byte STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(string maBA, Byte STTKhoa)
            {
               
                _STTKhoa = STTKhoa ;
                _maBA = maBA;
             
                
                
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Chamsoc_San(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Chamsoc_San item = new BenhAn_Chamsoc_San(
         i,
         dr.GetString("MaBA"),
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
			 dr.GetSmartDate("TuNgay", true) ,
			 dr.GetSmartDate("DenNgay", true) ,
			 dr.GetString("Dienbien"),
			 dr.GetString("YLenh") ,
			 dr.GetString("Yta") ,
			 dr.GetString("MaMay"),
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
         dr.GetString("TenYta"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("mach"),
         dr.GetString("aphuyet"),
         dr.GetString("nhietdo"),
         dr.GetString("tt"),
         dr.GetString("nuoctieu")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();//IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
