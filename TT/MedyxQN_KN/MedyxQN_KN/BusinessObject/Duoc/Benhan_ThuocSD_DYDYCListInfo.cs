using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class Benhan_ThuocSD_DYDYCListInfo : ReadOnlyListBase<Benhan_ThuocSD_DYDYCListInfo, Benhan_ThuocSD_DYDYCInfo>
    {
        #region Factory Methods
        public static Benhan_ThuocSD_DYDYCListInfo GetAllBenhan_ThuocSD_DYDYCInfo(String MaBA, int STTKhoa,  String dk, bool qadmin)
        {
            return DataPortal.Fetch<Benhan_ThuocSD_DYDYCListInfo>(new Criteria(MaBA,  STTKhoa, dk, qadmin));
        }
        public static Benhan_ThuocSD_DYDYCListInfo GetAllBenhan_ThuocSD_DYDYCInfo(String MaBA, int STTKhoa, int Stt, Boolean qadmin)
        {
            return DataPortal.Fetch<Benhan_ThuocSD_DYDYCListInfo>(new Criteria(MaBA, STTKhoa, " and a.Stt= "+ Stt , qadmin ));
        }
        public Benhan_ThuocSD_DYDYCInfo GetTo(String MaBA, int STT, int STTKhoa)
        {
            foreach (Benhan_ThuocSD_DYDYCInfo obj in this)
                if ((obj.MaBA == MaBA) && (obj.STT == STT) && (obj.STTKhoa == STTKhoa))
                    return obj;
            return null;

        }
        private Benhan_ThuocSD_DYDYCListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
                int    _STT ;
            int _STTKhoa;

	            String _MaBA ;
                String _dk;
            Boolean _qadmin = false   ;
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
            public string MaBA
            {
                get
                {
                    return _MaBA;
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
            public Criteria(String MaBA, int sttKhoa, String dk, bool qadmin)
            {
                         _STT  = STT ;
                         _MaBA = MaBA;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhan_ThuocSD_DYDYCInfo(criteria.MaBA, criteria.STTKhoa, criteria.dk,false    )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    Benhan_ThuocSD_DYDYCInfo item = new Benhan_ThuocSD_DYDYCInfo(
             i, 
             dr.GetSmartDate("NGAYDK", true),
			 dr.GetSmartDate("TUNGAY", true) ,
			 dr.GetSmartDate("DENNGAY", true) ,
			 dr.GetBoolean("DUYET") ,
			 dr.GetBoolean("PHAT") ,
			 dr.GetDecimal("SLTHANG") ,
			 dr.GetDecimal("SLMUAT") ,
			 dr.GetString("MaBA") ,
			 dr.GetInt32("STT") ,
			 dr.GetInt32("STTKhoa") ,
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
			 dr.GetString("TENDVHL") ,
             dr.GetDecimal("SLMUATT")
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
