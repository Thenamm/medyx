using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_San_KhamList : BusinessListBase<BenhAn_San_KhamList, BenhAn_San_Kham>
    {
        #region Factory Methods
        public static BenhAn_San_KhamList GetAllBenhAn_San_Kham(string maBA)
        {
            return DataPortal.Fetch<BenhAn_San_KhamList>(new Criteria(maBA));
        }
        
        public void NewTo(BenhAn_San_Kham _BenhAn_San_Kham)
        {
            if (this.Count == 0)
                _BenhAn_San_Kham.OrderNumber = 1;
            else
            _BenhAn_San_Kham.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_San_Kham);
        }
        public void UpdatedTo(BenhAn_San_Kham _BenhAn_San_Kham)
        {

            _BenhAn_San_Kham.OrderNumber = this.Items[this.IndexOf(_BenhAn_San_Kham)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_San_Kham)] = _BenhAn_San_Kham;
        }
        public void RemoveTo(BenhAn_San_Kham _BenhAn_San_Kham)
        {
            this.Items.Remove(_BenhAn_San_Kham);

        }

        private BenhAn_San_KhamList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
           
            
            
            public Criteria(string maBA)
            {
               
                _maBA = maBA;
             
                
                
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San_Kham(criteria.maBA)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_San_Kham item = new BenhAn_San_Kham(
         i,
         dr.GetString("MaBA"),
			dr.GetSmartDate("NgayDauKyKCC", true) ,
			dr.GetInt16("Cannangtruocthai") ,
			dr.GetDecimal("Tuoithai") ,
			dr.GetByte("ChieucaoTC") ,
			dr.GetInt16("CTC_VB") ,
            dr.GetString("Ngoithai"),
			dr.GetByte("SLThai") ,
			dr.GetString("Timthai") ,
			dr.GetByte("Tinhtrangtimthai") ,
			dr.GetSmartDate("Ngaydukiende", true) ,
			dr.GetString("Dauhieubatthuong") ,
			dr.GetString("Xutri") ,
			dr.GetString("LydoVV") ,
			dr.GetByte("Tinhthan") ,
			dr.GetByte("Phu") ,
			dr.GetString("ProteinNieu") ,
			dr.GetByte("Seomocu") ,
			dr.GetString("Concotucung") ,
			dr.GetByte("Cotucung") ,
			dr.GetString("CTCMo") ,
			dr.GetString("Bishop") ,
			dr.GetByte("Dauoi") ,
			dr.GetString("TGVooi") ,
			dr.GetByte("Nuocoi") ,
			dr.GetString("Tienluong") ,
			dr.GetByte("Dauseomo") ,
			dr.GetSmartDate("NgaydeDukienSA", true) ,
			dr.GetByte("TuanSA") ,
			dr.GetString("TinhthanKhac") ,
			dr.GetSmartDate("NgayDe", true) ,
			dr.GetString("TenConTrai") ,
			dr.GetString("TenConGai") ,
			dr.GetString("MaMay") ,
			dr.GetBoolean("Huy"),
			dr.GetSmartDate("NgaySD", true) ,
			dr.GetString("NguoiSD") ,
			dr.GetSmartDate("NgaySD1", true) ,
			dr.GetString("NguoiSD1") ,
            dr.GetString("TenNguoiSD"),
            dr.GetString("Mach") ,
		    dr.GetString("ApHuyet") ,
			dr.GetString("NhietDo") ,
			dr.GetString("NhipTho") ,
			dr.GetString("CanNang") ,
			dr.GetString("ChieuCao") ,
            dr.GetString("DieuTri"),
            dr.GetString("ChanDoan") 
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
