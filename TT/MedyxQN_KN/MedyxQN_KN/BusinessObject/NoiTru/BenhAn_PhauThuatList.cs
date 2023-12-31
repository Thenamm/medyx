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
    public class BenhAn_PhauThuatList : BusinessListBase<BenhAn_PhauThuatList, BenhAn_PhauThuat>
    {
         
        #region Factory Methods
        public static BenhAn_PhauThuatList NewList()
        {
            return DataPortal.Fetch<BenhAn_PhauThuatList>(new TemCriteria());
        }
        public static BenhAn_PhauThuatList GetAllBenhAn_PhauThuat(String _maBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_PhauThuatList>(new Criteria(_maBA, " and a.machungloai ='00011'",qadmin   ));
        }
        public static BenhAn_PhauThuatList GetAll(String _maBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_PhauThuatList>(new Criteria(_maBA, "",qadmin  ));
        }
        public static BenhAn_PhauThuatList GetAllBenhAn_ThuThuat(String _maBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_PhauThuatList>(new Criteria(_maBA, " and a.machungloai ='00012'",qadmin ));
        }
        public void NewTo(BenhAn_PhauThuat _BenhAn_PhauThuat)
        {
            if (this.Count == 0)
                _BenhAn_PhauThuat.OrderNumber = 1;
            else

                _BenhAn_PhauThuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_PhauThuat);
        }
        public BenhAn_PhauThuat NewTo()
        {
             BenhAn_PhauThuat obj = BenhAn_PhauThuat.NewBenhAn_PhauThuat();
              return obj;
        }
        public void UpdatedTo(BenhAn_PhauThuat _BenhAn_PhauThuat)
        {

            _BenhAn_PhauThuat.OrderNumber = this.Items[this.IndexOf(_BenhAn_PhauThuat)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_PhauThuat)] = _BenhAn_PhauThuat;
        }
        public void RemoveTo(BenhAn_PhauThuat _BenhAn_PhauThuat)
        {
            this.Items.Remove(_BenhAn_PhauThuat);

        }
        public BenhAn_PhauThuat GetTo(decimal STT) //
        {
            foreach (BenhAn_PhauThuat obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        private BenhAn_PhauThuatList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
      
        #region Criteria
        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
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
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
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
           
            public Criteria(String maBA,  String dKien,Boolean qadmin)
            {
                _qadmin = qadmin;
                _maBA = maBA;
                _dk = dKien;
            }
        }
        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PhauThuat(criteria.maBA, criteria.dk, criteria.qadmin)))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    try 
                    {
                        BenhAn_PhauThuat item = new BenhAn_PhauThuat(
     i,
     dr.GetString("MaBA") ,
			                                dr.GetInt32("STT") ,
			                                dr.GetInt32("STTKhoa") ,
			                                dr.GetString("MaPT") ,
                                             dr.GetString("tentat"),
			                                dr.GetString("MaBN") ,
			                                dr.GetSmartDate("NgayDK", true) ,
			                                dr.GetBoolean("DaThucHien") ,
			                                dr.GetDecimal("SLYCau") ,
			                                dr.GetDecimal("SLMua") ,
			                                dr.GetDecimal("DongiaTT") ,
			                                dr.GetDecimal("DongiaUSD") ,
			                                dr.GetDecimal("TyGia") ,
			                                dr.GetDecimal("DonGiaBH") ,
			                                dr.GetDecimal("GiaChenhLech") ,
			                                dr.GetDecimal("CK") ,
			                                dr.GetString("BSChiDinh") ,
			                                dr.GetString("CDTruocMo") ,
			                                dr.GetString("CDSauMo") ,
			                                dr.GetString("MaGPBenh") ,
     dr.GetByte("HTPhauThuat"),
			                                dr.GetBoolean("TaibienPT") ,
			                                dr.GetBoolean("Tinhtien") ,
			                                dr.GetBoolean("BHTinhtien") ,
			                                dr.GetBoolean("TinhNgoai") ,
			                                dr.GetByte("DATT") ,
			                                dr.GetString("NguoiTT") ,
			                                dr.GetSmartDate("NgayTToan", true) ,
			                                dr.GetBoolean("ADGIAUSD") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("LyDoHuy") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
     dr.GetString("TenPT"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenBSChidinh"),
     //dr.GetString("TenNguoiTra"),
     dr.GetString("TenBenhCDTruocMo"),
     dr.GetString("TenBenhCDSauMo"),
     dr.GetString("MaKhoa"),
      dr.GetString("maICDTruocMo"),
     dr.GetString("maICDSauMo"),
     dr.GetString("NoiDung"),
       dr.GetString("cachgayme"),
         dr.GetString("ppphauthuat"),
           dr.GetString("maloaipt"),
              dr.GetString("tenloaipt"),
     dr.GetString("tenkhoa"),
     dr.GetString("tenlh"),
     dr.GetString("makhoaql"),
     dr.GetByte("ca"),
     dr.GetBoolean("KTC") 
  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       //MessageBox.Show(ex.ToString());
                    }
                    
                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

      
        #endregion
    }
}