using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class KhamBenh_ThuocSD_DYDYCListInfo : ReadOnlyListBase<KhamBenh_ThuocSD_DYDYCListInfo, KhamBenh_ThuocSD_DYDYCInfo>
    {
        #region Factory Methods
        public static KhamBenh_ThuocSD_DYDYCListInfo GetAllKhamBenh_ThuocSD_DYDYCInfo(String MaSoKham, int STTKhoa, String dk, bool qadmin)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYDYCListInfo>(new Criteria(MaSoKham,  STTKhoa, dk, qadmin));
        }
        public static KhamBenh_ThuocSD_DYDYCListInfo GetAllKhamBenh_ThuocSD_DYDYCInfo(String MaSoKham, int STTKhoa, int Stt)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYDYCListInfo>(new Criteria(MaSoKham, STTKhoa, " and a.Stt= "+ Stt , false ));
        }
        public KhamBenh_ThuocSD_DYDYCInfo GetTo(String MaSoKham, int STT, int STTKhoa)
        {
            foreach (KhamBenh_ThuocSD_DYDYCInfo obj in this)
                if ((obj.MaSoKham == MaSoKham) && (obj.STT == STT) && (obj.STTKhoa == STTKhoa))
                    return obj;
            return null;

        }
        private KhamBenh_ThuocSD_DYDYCListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
                int    _STT ;
            int _STTKhoa;

	            String _MaSoKham ;
                String _dk;
            Boolean _qadmin = HTC.ShareVariables.pub_bQadmin   ;
            public int STT
            {
                get
                {
                    return _STT;
                }
            }
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public string MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
          
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            //public bool Dadung
            //{
            //    get
            //    {
            //        return _dadung;
            //    }
            //}
            public Criteria(String MaSoKham, int STTKhoa, String dk, bool qadmin)
            {
                         _STT  = STT ;
                         _MaSoKham = MaSoKham;
                         _dk = dk ;
                         _STTKhoa = STTKhoa;
                         _qadmin = qadmin;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD_DYDYCInfo(criteria.MaSoKham, criteria.STTKhoa, criteria.dk,false    )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_ThuocSD_DYDYCInfo item = new KhamBenh_ThuocSD_DYDYCInfo(
             i, 
             dr.GetSmartDate("NGAYDK", true),
			   
			 dr.GetBoolean("DUYET") ,
			 dr.GetBoolean("PHAT") ,
			 dr.GetDecimal("SLTHANG") ,
			 dr.GetDecimal("SLMUAT") ,
			 dr.GetString("MaSoKham") ,
			 dr.GetInt32("STT") ,
			
			 dr.GetInt32("STTThuoc") ,
			 dr.GetString("Mathuoc") ,
			 dr.GetDecimal("SLKeDon") ,
			 dr.GetDecimal("SLMua") ,
			 dr.GetDecimal("DongiaTT") ,
			 dr.GetDecimal("DonGiaBH") ,
			 dr.GetDecimal("GiaChenhLech") ,
			 dr.GetDecimal("CK") ,
			 dr.GetBoolean("Tinhtien") ,
			 dr.GetBoolean("BHTinhtien") ,
			 dr.GetBoolean("TinhNgoai"),
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetString("TENTM") ,
			 dr.GetString("TENDVT") ,
			 dr.GetString("TENNGUOISD") ,
			 dr.GetDecimal("TONCK") ,
			 dr.GetDecimal("TONCKDT") ,
			 dr.GetString("TENGOC") ,
			 dr.GetDecimal("QUYDOI") ,
			 dr.GetString("HAMLUONG") ,
			 dr.GetString("TENDVHL"),   
             dr.GetDecimal ("SLMUATT")   
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        #endregion
    }
}
