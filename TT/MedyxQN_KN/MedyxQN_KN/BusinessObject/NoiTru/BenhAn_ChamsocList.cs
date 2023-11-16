using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_ChamsocList : BusinessListBase<BenhAn_ChamsocList, BenhAn_Chamsoc>
    {
        #region Factory Methods
        public static BenhAn_ChamsocList GetAllBenhAn_Chamsoc(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_ChamsocList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_Chamsoc _BenhAn_Chamsoc)
        {
            if (this.Count == 0)
                _BenhAn_Chamsoc.OrderNumber = 1;
            else
                _BenhAn_Chamsoc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Chamsoc);
        }
        public void UpdatedTo(BenhAn_Chamsoc _BenhAn_Chamsoc)
        {

            _BenhAn_Chamsoc.OrderNumber = this.Items[this.IndexOf(_BenhAn_Chamsoc)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Chamsoc)] = _BenhAn_Chamsoc;
        }
        public void RemoveTo(BenhAn_Chamsoc _BenhAn_Chamsoc)
        {
            this.Items.Remove(_BenhAn_Chamsoc);

        }

        private BenhAn_ChamsocList()
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

                _STTKhoa = STTKhoa;
                _maBA = maBA;



            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Chamsoc(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Chamsoc item = new BenhAn_Chamsoc(
         i,
         dr.GetString("MaBA"),
         dr.GetInt32("STT"),
         dr.GetInt32("STTKhoa"),
         dr.GetSmartDate("TuNgay", true),
         dr.GetSmartDate("DenNgay", true),
         dr.GetString("Dienbien"),
         dr.GetString("YLenh"),
         dr.GetString("Yta"),
         dr.GetString("MaMay"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
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
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
