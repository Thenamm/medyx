using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
 //using System.Windows.Forms;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class ThongTinBN_TienSu_SanList : BusinessListBase<ThongTinBN_TienSu_SanList, ThongTinBN_TienSu_San>
    {
         
        #region Factory Methods
        public static ThongTinBN_TienSu_SanList GetAllThongTinBN_TienSu_San(String dk)
        {
            return DataPortal.Fetch<ThongTinBN_TienSu_SanList>(new Criteria(dk,false ));
        }
       
        public void NewTo(ThongTinBN_TienSu_San _ThongTinBN_TienSu_San)
        {
            _ThongTinBN_TienSu_San.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_ThongTinBN_TienSu_San);
        }
        public ThongTinBN_TienSu_San NewTo()
        {
             ThongTinBN_TienSu_San obj = ThongTinBN_TienSu_San.NewThongTinBN_TienSu_San();
              return obj;
        }
        public void UpdatedTo(ThongTinBN_TienSu_San _ThongTinBN_TienSu_San)
        {

            _ThongTinBN_TienSu_San.OrderNumber = this.Items[this.IndexOf(_ThongTinBN_TienSu_San)].OrderNumber;
            this.Items[this.IndexOf(_ThongTinBN_TienSu_San)] = _ThongTinBN_TienSu_San;
        }
        public void RemoveTo(ThongTinBN_TienSu_San _ThongTinBN_TienSu_San)
        {
            this.Items.Remove(_ThongTinBN_TienSu_San);

        }
        private ThongTinBN_TienSu_SanList()
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
           
            public Criteria(String dKien,Boolean qadmin)
            {
                _qadmin = qadmin;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongTinBN_TienSu_San(criteria.dk, criteria.qadmin)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        ThongTinBN_TienSu_San item = new ThongTinBN_TienSu_San(
     i,
     dr.GetString("MaBN") ,
			dr.GetBoolean("TSGDSinhdoi") ,
			dr.GetBoolean("TSGDDidang") ,
			dr.GetBoolean("TSGDBenhditruyen") ,
			dr.GetBoolean("TSGDDaiduong") ,
			dr.GetBoolean("TSGDCaoHA") ,
			dr.GetString("TSGDKhac") ,
			dr.GetBoolean("TSBTCaoHA") ,
			dr.GetBoolean("TSBTBenhTim") ,
			dr.GetBoolean("TSBTLaoPhoi") ,
			dr.GetBoolean("TSBTHenphequan") ,
			dr.GetBoolean("TSBTBenhthan") ,
			dr.GetBoolean("TSBTBasedow") ,
			dr.GetBoolean("TSBTViemtacTM") ,
			dr.GetBoolean("TSBTDongkinh") ,
			dr.GetBoolean("TSBTMoRuotthua") ,
            dr.GetBoolean("Diungthuoc"),
			dr.GetString("PTObung") ,
			dr.GetString("TuoiCokinh") ,
			dr.GetString("ChukyKinh") ,
			dr.GetString("SongayKinh") ,
			dr.GetString("TuoiLaychong") ,
			dr.GetString("Benhphukhoa") ,
			dr.GetBoolean("KhoiUBT") ,
			dr.GetBoolean("UxoTC") ,
			dr.GetBoolean("DidangSD") ,
			dr.GetBoolean("SSD") ,
			dr.GetBoolean("TSM") ,
			dr.GetBoolean("DieuTriCTC") ,
			dr.GetBoolean("CatcutCTC") ,
			dr.GetString("PhauthuatKhac") ,
			dr.GetString("PARA") ,
			dr.GetString("TSBTKhac") ,
			dr.GetByte("Solancothai") ,
			dr.GetByte("Solansaythai") ,
			dr.GetByte("Solannaothai") ,
			dr.GetByte("Solande"),
			dr.GetString("Cachde") ,
			dr.GetByte("Soconsong"),
			dr.GetString("MaMay") ,
			dr.GetBoolean("Huy") ,
			dr.GetSmartDate("NgaySD", true),
			dr.GetString("NguoiSD") ,
			dr.GetSmartDate("NgaySD1", true) ,
			dr.GetString("NguoiSD1") ,
            dr.GetString("TenNguoiSD"),
            dr.GetString("cuthe")
  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       //MessageBox.Show(ex.ToString());
                    }
                    
                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

      
        #endregion
    }
}