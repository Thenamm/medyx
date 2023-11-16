using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{





    [Serializable()]
    public class BenhAn_Chamsoc_SoSinhList : BusinessListBase<BenhAn_Chamsoc_SoSinhList, BenhAn_Chamsoc_SoSinh>
    {
        #region Factory Methods
        public static BenhAn_Chamsoc_SoSinhList GetAllBenhAn_Chamsoc_SoSinh(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_Chamsoc_SoSinhList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Chamsoc_SoSinh _BenhAn_Chamsoc_SoSinh)
        {
            if (this.Count == 0)
                _BenhAn_Chamsoc_SoSinh.OrderNumber = 1;
            else
            _BenhAn_Chamsoc_SoSinh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Chamsoc_SoSinh);
        }
        public void UpdatedTo(BenhAn_Chamsoc_SoSinh _BenhAn_Chamsoc_SoSinh)
        {

            _BenhAn_Chamsoc_SoSinh.OrderNumber = this.Items[this.IndexOf(_BenhAn_Chamsoc_SoSinh)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Chamsoc_SoSinh)] = _BenhAn_Chamsoc_SoSinh;
        }
        public void RemoveTo(BenhAn_Chamsoc_SoSinh _BenhAn_Chamsoc_SoSinh)
        {
            this.Items.Remove(_BenhAn_Chamsoc_SoSinh);

        }

        private BenhAn_Chamsoc_SoSinhList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Chamsoc_SoSinh(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Chamsoc_SoSinh item = new BenhAn_Chamsoc_SoSinh(
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
         dr.GetString("an"),
         dr.GetString("non"),
         dr.GetString("vangda"),
         dr.GetString("phan"),
         dr.GetString("nuoctieu")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
