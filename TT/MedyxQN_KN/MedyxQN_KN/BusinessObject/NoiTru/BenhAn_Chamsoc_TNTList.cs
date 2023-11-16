using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_Chamsoc_TNTList : BusinessListBase<BenhAn_Chamsoc_TNTList, BenhAn_Chamsoc_TNT>
    {
        #region Factory Methods
        public static BenhAn_Chamsoc_TNTList GetAllBenhAn_Chamsoc_TNT(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_Chamsoc_TNTList>(new Criteria(maBA, STTkhoa ));
        }
        
        public void NewTo(BenhAn_Chamsoc_TNT _BenhAn_Chamsoc_TNT)
        {
            if (this.Count == 0)
                _BenhAn_Chamsoc_TNT.OrderNumber = 1;
            else
            _BenhAn_Chamsoc_TNT.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Chamsoc_TNT);
        }
        public void UpdatedTo(BenhAn_Chamsoc_TNT _BenhAn_Chamsoc_TNT)
        {

            _BenhAn_Chamsoc_TNT.OrderNumber = this.Items[this.IndexOf(_BenhAn_Chamsoc_TNT)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Chamsoc_TNT)] = _BenhAn_Chamsoc_TNT;
        }
        public void RemoveTo(BenhAn_Chamsoc_TNT _BenhAn_Chamsoc_TNT)
        {
            this.Items.Remove(_BenhAn_Chamsoc_TNT);

        }

        private BenhAn_Chamsoc_TNTList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Chamsoc_TNT(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Chamsoc_TNT item = new BenhAn_Chamsoc_TNT(
							 i,
							 dr.GetString("MaBA"),
							 dr.GetInt32("STT") ,
							 dr.GetInt32("STTKhoa") ,
							 dr.GetSmartDate("NgayLoc", true) ,
							 dr.GetString("Dienbien"),
							 dr.GetString("YLenh") ,
							 dr.GetString("Yta") ,
							 dr.GetString("MaMay"),
							 dr.GetBoolean("Huy") ,
							 dr.GetSmartDate("NgaySD", true) ,
							 dr.GetString("NguoiSD") ,
						 dr.GetString("TenYta"),
						 dr.GetString("TenNguoiSD"),

						 dr.GetString("Hepin"),
						 dr.GetString("HepinKhac"),
						 dr.GetString("KH_Loc"),
						 dr.GetString("HuyetApTruoc"),
						 dr.GetString("HuyetApSau"),
						 dr.GetString("CanNangTruoc"),
						 dr.GetString("SieuLocUF")



			   );
                    this.Add(item);
                    i += 1;
                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
