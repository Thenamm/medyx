using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
//using System.Windows.Forms;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhNhan_TienSu_SanList : BusinessListBase<BenhNhan_TienSu_SanList, BenhNhan_TienSu_San>
    {

        #region Factory Methods
        public static BenhNhan_TienSu_SanList GetAllBenhNhan_TienSu_San(String dk)
        {
            return DataPortal.Fetch<BenhNhan_TienSu_SanList>(new Criteria(dk,false ));
        }

        public void NewTo(BenhNhan_TienSu_San _BenhNhan_TienSu_San)
        {
            _BenhNhan_TienSu_San.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhNhan_TienSu_San);
        }
        public BenhNhan_TienSu_San NewTo()
        {
            BenhNhan_TienSu_San obj = BenhNhan_TienSu_San.NewBenhNhan_TienSu_San();
            return obj;
        }
        public void UpdatedTo(BenhNhan_TienSu_San _BenhNhan_TienSu_San)
        {

            _BenhNhan_TienSu_San.OrderNumber = this.Items[this.IndexOf(_BenhNhan_TienSu_San)].OrderNumber;
            this.Items[this.IndexOf(_BenhNhan_TienSu_San)] = _BenhNhan_TienSu_San;
        }
        public void RemoveTo(BenhNhan_TienSu_San _BenhNhan_TienSu_San)
        {
            this.Items.Remove(_BenhNhan_TienSu_San);

        }
        private BenhNhan_TienSu_SanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }


            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }

            public Criteria(String dKien, Boolean qadmin)
            {
                _qadmin = qadmin;
                _dk = dKien;
            }
        }
        #endregion


        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhNhan_TienSu_San(criteria.dk, criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try
                    {
                        BenhNhan_TienSu_San item = new BenhNhan_TienSu_San(
     i,
     dr.GetString("MaBN"),
            dr.GetBoolean("TSGDSinhdoi"),
            dr.GetBoolean("TSGDDidang"),
            dr.GetBoolean("TSGDBenhditruyen"),
            dr.GetBoolean("TSGDDaiduong"),
            dr.GetBoolean("TSGDCaoHA"),
            dr.GetString("TSGDKhac"),
            dr.GetBoolean("TSBTCaoHA"),
            dr.GetBoolean("TSBTBenhTim"),
            dr.GetBoolean("TSBTLaoPhoi"),
            dr.GetBoolean("TSBTHenphequan"),
            dr.GetBoolean("TSBTBenhthan"),
            dr.GetBoolean("TSBTBasedow"),
            dr.GetBoolean("TSBTViemtacTM"),
            dr.GetBoolean("TSBTDongkinh"),
            dr.GetBoolean("TSBTMoRuotthua"),
            dr.GetBoolean("Diungthuoc"),
            dr.GetString("PTObung"),
            dr.GetString("TuoiCokinh"),
            dr.GetString("ChukyKinh"),
            dr.GetString("SongayKinh"),
            dr.GetString("TuoiLaychong"),
            dr.GetString("Benhphukhoa"),
            dr.GetBoolean("KhoiUBT"),
            dr.GetBoolean("UxoTC"),
            dr.GetBoolean("DidangSD"),
            dr.GetBoolean("SSD"),
            dr.GetBoolean("TSM"),
            dr.GetBoolean("DieuTriCTC"),
            dr.GetBoolean("CatcutCTC"),
            dr.GetString("PhauthuatKhac"),
            dr.GetString("PARA"),
            dr.GetString("TSBTKhac"),
            dr.GetByte("Solancothai"),
            dr.GetByte("Solansaythai"),
            dr.GetByte("Solannaothai"),
            dr.GetByte("Solande"),
            dr.GetString("Cachde"),
            dr.GetByte("Soconsong"),
            dr.GetString("MaMay"),
            dr.GetBoolean("Huy"),
            dr.GetSmartDate("NgaySD", true),
            dr.GetString("NguoiSD"),
            dr.GetSmartDate("NgaySD1", true),
            dr.GetString("NguoiSD1"),
            dr.GetString("TenNguoiSD"),
            dr.GetString("cuthe")
  );

                        this.Add(item);
                        i += 1;
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.ToString());
                    }

                }
                dr.Close(); dr.Dispose();//IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }


        #endregion
    }
}