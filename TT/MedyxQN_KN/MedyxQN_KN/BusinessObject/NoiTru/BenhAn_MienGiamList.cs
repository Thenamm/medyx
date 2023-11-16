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

    public class BenhAn_MienGiamList : BusinessListBase<BenhAn_MienGiamList, BenhAn_MienGiam>
    {
        #region Factory Methods
        public static BenhAn_MienGiamList NewList()
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new TemCriteria());
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiam(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new Criteria(MaBA,1));
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiamBySTTKhoa(String MaBA, int sttKhoa)
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new OtherCriteria(MaBA, sttKhoa, "", 1));
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiamChi(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new Criteria(MaBA, 2));
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiamThu(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new Criteria(MaBA,3));
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiamBySTTKhoaSTT(String MaBA, int sttKhoa,int stt )
        {
            return DataPortal.Fetch<BenhAn_MienGiamList>(new OtherCriteria(MaBA, sttKhoa, stt.ToString () , 3));
        }
        public static BenhAn_MienGiamList GetAllBenhAn_MienGiamByNgayYC(String MaBA, int sttKhoa,string NgayDK)
        {                        
            return DataPortal.Fetch<BenhAn_MienGiamList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2));
        }
        public BenhAn_MienGiam NewTo() 
        {
            BenhAn_MienGiam obj = BenhAn_MienGiam.NewBenhAn_MienGiam();
            return obj;
        }
        public void NewTo(BenhAn_MienGiam _BenhAn_MienGiam)
        {
            try
            {
                if (!Contains(_BenhAn_MienGiam.STT, _BenhAn_MienGiam.MaBA, _BenhAn_MienGiam.STTKhoa, _BenhAn_MienGiam.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_MienGiam.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_MienGiam);
                       
                        _BenhAn_MienGiam.STT = this.Items[this.Items.Count - 1].STT + 1;
                        this.Add(_BenhAn_MienGiam);
                    }
                    else
                    {
                        _BenhAn_MienGiam.STT = 1;
                        this.Add(_BenhAn_MienGiam);

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
       
      
        public void UpdatedTo(BenhAn_MienGiam _BenhAn_MienGiam)
        {

            _BenhAn_MienGiam.STT = this.Items[this.IndexOf(_BenhAn_MienGiam)].STT;
            this.Items[this.IndexOf(_BenhAn_MienGiam)] = _BenhAn_MienGiam;
        }
        //public void RemoveTo(BenhAn_MienGiam _BenhAn_MienGiam)
        //{
        //    this.Items.Remove(_BenhAn_MienGiam);

        //}
        public BenhAn_MienGiam  AssignTo(BenhAn_MienGiam  _BenhAn_MienGiam)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_MienGiam.STT, _BenhAn_MienGiam.MaBA, _BenhAn_MienGiam.STTKhoa, _BenhAn_MienGiam.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_MienGiam.STT = ++_count;
                   // _BenhAn_MienGiam.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_BenhAn_MienGiam);
                }
                else
                {
                    _BenhAn_MienGiam.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_MienGiam);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_MienGiam;
        }
        public bool Contains(int stt,string MaBA,int sttkhoa, bool Huy)
        {
            foreach (BenhAn_MienGiam  obj in this)
                if ((obj.STT == stt) && (obj.MaBA == MaBA) && (obj.STTKhoa == sttkhoa) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public BenhAn_MienGiam  GetBenhAn_MienGiamById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_MienGiam  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_MienGiam  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_MienGiam obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_MienGiam GetTo(decimal STT) //
        {
            foreach (BenhAn_MienGiam obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_MienGiam  item = BenhAn_MienGiam.NewBenhAn_MienGiam();
            Add(item);
            return item;
        }

      
        private BenhAn_MienGiamList()
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
            public Criteria(String mMaBA,byte mloai)
            {
                _MaBA = mMaBA;
                _DK = "";
                //if (mloai == 2)
                //    _DK = " and isnull(k.loai,0) = 1";
                //else if (mloai == 3)
                //    _DK = " and isnull(k.loai,0) = 0";
                
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
            public OtherCriteria(String MaBA, int sttKhoa, string dk, byte loai)
            {
                if (loai == 2)
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + dk + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + dk + "')) <=0";
                else if (loai == 1)
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                 else
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and stt =" + dk ;
                _STTKhoa = sttKhoa;
                _MaBA = MaBA;
                
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_MienGiam(criteria.MaBA,criteria.DK  , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_MienGiam .GetBenhAn_MienGiam(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_MienGiamBySTTKhoa(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_MienGiam.GetBenhAn_MienGiam(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_MienGiam  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_MienGiam  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_MienGiamList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_MienGiamList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
