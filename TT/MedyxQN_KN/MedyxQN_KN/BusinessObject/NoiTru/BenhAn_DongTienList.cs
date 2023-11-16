using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.NoiTru
{
    [Serializable()]

    public class BenhAn_DongTienList : BusinessListBase<BenhAn_DongTienList, BenhAn_DongTien>
    {
        #region Factory Methods
        public static BenhAn_DongTienList NewList()
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new TemCriteria());
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTien(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA,1,qadmin));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienChi(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA, 2,qadmin,0));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienChi(String MaBA, Boolean qadmin,byte _loaikq)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA, 2, qadmin,_loaikq ));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienThu(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA, 3, qadmin, 0));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienThu(String MaBA, Boolean qadmin, byte loaikq = 0)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA,3,qadmin,loaikq  ));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienBySTTKhoaSTT(String MaBA, int sttKhoa,int stt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new OtherCriteria(MaBA, sttKhoa, stt.ToString () , 3,qadmin ));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {                        
            return DataPortal.Fetch<BenhAn_DongTienList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin ));
        }
        public static BenhAn_DongTienList GetAllBenhAn_DongTienChiThieu(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_DongTienList>(new Criteria(MaBA, 4, false));
        }
        public BenhAn_DongTien NewTo() 
        {
            BenhAn_DongTien obj = BenhAn_DongTien.NewBenhAn_DongTien();
            return obj;
        }
        public void NewTo(BenhAn_DongTien _BenhAn_DongTien)
        {
            try
            {
                if (!Contains(_BenhAn_DongTien.STT, _BenhAn_DongTien.MaBA, _BenhAn_DongTien.STTKhoa, _BenhAn_DongTien.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_DongTien.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_DongTien);
                       
                        _BenhAn_DongTien.STT = this.Items[this.Items.Count - 1].STT + 1;
                        this.Add(_BenhAn_DongTien);
                    }
                    else
                    {
                        _BenhAn_DongTien.STT = 1;
                        this.Add(_BenhAn_DongTien);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(BenhAn_DongTien _BenhAn_DongTien)
        {

            _BenhAn_DongTien.STT = this.Items[this.IndexOf(_BenhAn_DongTien)].STT;
            this.Items[this.IndexOf(_BenhAn_DongTien)] = _BenhAn_DongTien;
        }
        //public void RemoveTo(BenhAn_DongTien _BenhAn_DongTien)
        //{
        //    this.Items.Remove(_BenhAn_DongTien);

        //}
        public BenhAn_DongTien  AssignTo(BenhAn_DongTien  _BenhAn_DongTien)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_DongTien.STT, _BenhAn_DongTien.MaBA, _BenhAn_DongTien.STTKhoa, _BenhAn_DongTien.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_DongTien.STT = ++_count;
                   // _BenhAn_DongTien.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_BenhAn_DongTien);
                }
                else
                {
                    _BenhAn_DongTien.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_DongTien);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_DongTien;
        }
        public bool Contains(int stt,string MaBA,int sttkhoa, bool Huy)
        {
            foreach (BenhAn_DongTien  obj in this)
                if ((obj.STT == stt) && (obj.MaBA == MaBA) && (obj.STTKhoa == sttkhoa) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public BenhAn_DongTien  GetBenhAn_DongTienById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DongTien  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DongTien  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_DongTien obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_DongTien GetTo(decimal STT) //
        {
            foreach (BenhAn_DongTien obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_DongTien  item = BenhAn_DongTien.NewBenhAn_DongTien();
            Add(item);
            return item;
        }

      
        private BenhAn_DongTienList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

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
            private String  _MaBA;
            private Boolean _qadmin = false ;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private string _DK;
            public string DK
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
            private byte _loaikq;
            public byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            public Criteria(String mMaBA, byte mloai, Boolean qadmin, byte loaikq = 0)
            {
                _MaBA = mMaBA;
                _loaikq = loaikq;
                _DK = "";
                if (mloai == 2)
                    _DK = " and isnull(k.loai,0) = 1 AND ISNULL(A.DATT,0) = 0 ";
                else if (mloai == 3)
                    _DK = " and isnull(k.loai,0) = 0 AND ISNULL(A.DATT,0) = 0";
                else if (mloai == 4)
                    _DK = "  and isnull(k.loai,0) = 1 and a.MaLDThuTien <> '00020' and a.maba = '" + MaBA + "'";
                else
                _qadmin = qadmin;
            }
        }
        private class OtherCriteria
        {
            private int _STTKhoa;
             private Boolean _qadmin = false ;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            public OtherCriteria(String MaBA, int sttKhoa, string dk, byte loai, Boolean qadmin)
            {
               if (loai == 2)
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + dk + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + dk + "')) <=0";
                else if (loai == 1)
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                 else
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and stt =" + dk ;
                _STTKhoa = sttKhoa;
                _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DongTien(criteria.MaBA,criteria.DK  , criteria.qadmin,criteria .loaikq )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DongTien .GetBenhAn_DongTien(dr,i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DongTienBySTTKhoa(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DongTien.GetBenhAn_DongTien(dr, i));
                    i++;
                } 
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_DongTien  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_DongTien  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_DongTienList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_DongTienList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
