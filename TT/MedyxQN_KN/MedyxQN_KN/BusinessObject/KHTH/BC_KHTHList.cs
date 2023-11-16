



using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_KHTHList : BusinessListBase<BC_KHTHList, BC_KHTH>
    {
        #region Factory Methods
        public static BC_KHTHList GetAllBC_KHTH(String _nam, String _dK)
        {
            return DataPortal.Fetch<BC_KHTHList>(new Criteria(_nam ,_dK ));
        }
        public void NewTo(BC_KHTH _BC_KHTH)
        {
            if (this.Count == 0)
                _BC_KHTH.OrderNumber = 1;
            else
                _BC_KHTH.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BC_KHTH);
        }
        public void UpdatedTo(BC_KHTH _BC_KHTH)
        {

            _BC_KHTH.OrderNumber = this.Items[this.IndexOf(_BC_KHTH)].OrderNumber;
            this.Items[this.IndexOf(_BC_KHTH)] = _BC_KHTH;
        }
        public void RemoveTo(BC_KHTH _BC_KHTH)
        {
            //this.Items.Remove(_BC_KHTH);
            if (_BC_KHTH.IsNew == true)
                this.Items.Remove(_BC_KHTH);

            else
                Remove(_BC_KHTH);

        }
        public BC_KHTH Contains(string MaBC)
        {
            foreach (BC_KHTH obj in this)
                if (obj.MaBC == MaBC)
                    return obj;
            return null;
        }

        public BC_KHTH GetTo(string mabc) //
        {
            foreach (BC_KHTH obj in this)
                if (obj.MaBC == mabc)
                    return obj;
            return null;

        }
        private BC_KHTHList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
            private String _nam;
            private String _DK;
             private Boolean _qadmin = false ;
            public String Nam
            {
                get
                {
                    return _nam;
                }
            }

            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String Nam, String DK)
            {
                _nam = Nam ;
                _DK = DK;
                _qadmin = qadmin;
            }

        }

        #endregion
        
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_KHTH(criteria.Nam, criteria.DK,false )))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    BC_KHTH item = new BC_KHTH(
     i,
     dr.GetString("MaBC"),
     dr.GetSmartDate("TuNgay", true),
     dr.GetSmartDate("DenNgay", true),
     dr.GetString("TieuDeBC"),
     dr.GetInt32("SoLanKham_Phuongxa"),
     dr.GetInt32("SoLanKham_Duphong"),
     dr.GetInt32("SoNguoiKham_Khuvuc"),
     dr.GetInt32("SoNguoiKham_Phuongxa"),
     dr.GetInt32("SoNguoiKham_Duphong"),
     dr.GetString("TacHaiThuoc"),
     dr.GetString("BCChiTiet"),
     dr.GetString("CacHDCM"),
     dr.GetString("DeNghiSoYT"),
     dr.GetString("TaiBien"),
     dr.GetInt32("BenhAnKT_Tot"),
     dr.GetInt32("BenhAnKT_Kha"),
     dr.GetInt32("BenhAnKT_TB"),
     dr.GetInt32("BenhAnKT_Kem"),
     dr.GetInt32("DonThuocKT_Tot"),
     dr.GetInt32("DonThuocKT_Kha"),
     dr.GetInt32("DonThuocKT_TB"),
     dr.GetInt32("DonThuocKT_Kem"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy")               

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
