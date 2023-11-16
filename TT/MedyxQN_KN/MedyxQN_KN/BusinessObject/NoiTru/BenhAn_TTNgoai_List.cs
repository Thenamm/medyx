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
    public class BenhAn_TTNgoai_List : BusinessListBase<BenhAn_TTNgoai_List, BenhAn_TTNgoai>
    {
        #region Factory Methods
        public static BenhAn_TTNgoai_List NewList()
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new TemCriteria());
        }
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoai(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new Criteria(MaBA));
        }
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoaiKhoa(String MaBA, string makhoa,DateTime NgayDK,  string dk)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new CriteriaOther(MaBA,makhoa,NgayDK, dk));
        }
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoaiBySTTKhoa(String MaBA, int sttKhoa)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new OtherCriteria(MaBA, sttKhoa, "", 1));
        }
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoaiByNgayYC(String MaBA, int sttKhoa, string NgayDK)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2 ));
        }
    
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoaiByKhoaNgayYC(String MaBA, int sttKhoa, DateTime NgayDK, string makhoa)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new OtherCriteria(MaBA, sttKhoa, " and datediff(d,a.NgayDK,'" + NgayDK.Month.ToString() + "/" + NgayDK.Day.ToString()+"/" +NgayDK.Year.ToString()+ "') =0 and a.makhoa like'" + makhoa + "%'", 3));
        }
        public static BenhAn_TTNgoai_List GetAllBenhAn_TTNgoaiByKhoaNgayYCSTT(String MaBA, int sttKhoa, DateTime NgayDK, int stt)
        {
            return DataPortal.Fetch<BenhAn_TTNgoai_List>(new OtherCriteria(MaBA, sttKhoa, " and a.sttkhoa =" + sttKhoa + "  and a.stt =" + stt + " and datediff(d,a.NgayDK,'" + NgayDK.Month.ToString() + "/" + NgayDK.Day.ToString() + "/" + NgayDK.Year.ToString() + "') =0 ", 4));
        }
        public BenhAn_TTNgoai NewTo() 
        {
            BenhAn_TTNgoai obj = BenhAn_TTNgoai.NewBenhAn_TTNgoai();
            return obj;
        }
        public void NewTo(BenhAn_TTNgoai _BenhAn_TTNgoai)
        {
            try
            {
                if (!Contains(_BenhAn_TTNgoai.MaDV, _BenhAn_TTNgoai.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_TTNgoai.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_TTNgoai);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_TTNgoai.STT = ++_count;
                        this.Add(_BenhAn_TTNgoai);
                    }
                    else
                    {
                        _BenhAn_TTNgoai.STT = 1;
                        this.Add(_BenhAn_TTNgoai);

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
       
      
        public void UpdatedTo(BenhAn_TTNgoai _BenhAn_TTNgoai)
        {

            _BenhAn_TTNgoai.STT = this.Items[this.IndexOf(_BenhAn_TTNgoai)].STT;
            this.Items[this.IndexOf(_BenhAn_TTNgoai)] = _BenhAn_TTNgoai;
        }
        //public void RemoveTo(BenhAn_TTNgoai _BenhAn_TTNgoai)
        //{
        //    this.Items.Remove(_BenhAn_TTNgoai);

        //}
        public void RemoveTo(BenhAn_TTNgoai obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_TTNgoai  AssignTo(BenhAn_TTNgoai  _BenhAn_TTNgoai)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_TTNgoai.MaDV,  _BenhAn_TTNgoai.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_TTNgoai.STT = ++_count;
                    this.Add(_BenhAn_TTNgoai);
                }
                else
                {
                    _BenhAn_TTNgoai.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_TTNgoai);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_TTNgoai;
        }
        public BenhAn_TTNgoai Containsfind(int stt, int sttkhoa)
        {
            foreach (BenhAn_TTNgoai obj in this)
                if ((obj.STT == stt) && (obj.STTKhoa == sttkhoa))
                    return obj;
            return null;

        }
        public bool Contains(string MaDV, bool Huy)
        {
           //foreach (BenhAn_TTNgoai  obj in this)
           //     if ((obj.MaDV == MaDV) && (obj.Huy == Huy))
           //     {
           //         //if (MessageBox.Show("Dịch vụ này đã được chọn rồi ! Bạn chọn tiếp ?","Thongbao",MessageBoxButtons.OKCancel ) == DialogResult.OK   )
           //         //return false;
           //         //else
           //         //return true;
           //     }
            return false;
        }
        public BenhAn_TTNgoai  GetBenhAn_TTNgoaiById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_TTNgoai  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_TTNgoai  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_TTNgoai GetTo(decimal STT) //
        {
            foreach (BenhAn_TTNgoai obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_TTNgoai  item = BenhAn_TTNgoai.NewBenhAn_TTNgoai();
            Add(item);
            return item;
        }

      
        private BenhAn_TTNgoai_List()
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
            private Boolean _qadmin = HTC.ShareVariables.pub_bQadmin ;
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
            public Criteria(String mMaBA)
            {
                _MaBA = mMaBA;
                
            }
        }
        private class OtherCriteria
        {
             private Boolean _qadmin = false ;
            private int _STTKhoa;
           
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            private int _loaiphieu;

            public int loaiphieu
            {
                get
                {
                    return _loaiphieu;
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
            public OtherCriteria(String MaBA, int sttKhoa, string DK, byte loai)
            {
                if (loai == 3||loai==4)
                    _loaiphieu = 4;
                 if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(DK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(DK).ToString("MM/dd/yyyy") + "')) <=0";
                     else if (loai == 1)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                     else
                    _DK = DK;
                else
                  if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DK + "')) <=0";
                    else if (loai == 1)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                else
                    _DK = DK;

                _STTKhoa = sttKhoa;
                _MaBA = MaBA;
                
            }
        }
        private class CriteriaOther
        {
             private Boolean _qadmin = false ;
           
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
            public CriteriaOther(String MaBA, string makhoa,DateTime ngaydk , string DK)
            {
               
                _DK = _DK + DK;
               if (makhoa !="All" && makhoa !="")
                   _DK = _DK + DK;
                _MaBA = MaBA;

            }
        }
    
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TTNgoai(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                   
                    this.Add(BenhAn_TTNgoai.GetBenhAn_TTNgoai(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TTNgoaiBySTTKhoa(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    if (criteria.loaiphieu != 4)
                    {
                        this.Add(BenhAn_TTNgoai.GetBenhAn_TTNgoai(dr, i));
                    }
                    else
                    {
                        this.Add(BenhAn_TTNgoai.GetBenhAn_TTNgoai(dr, i,4));
              
                    }
                    i++;
                }
                dr.Close(); dr.Dispose(); 
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TTNgoai(criteria.MaBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {

                    this.Add(BenhAn_TTNgoai.GetBenhAn_TTNgoai(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_TTNgoai  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_TTNgoai  item in this)
            {
                
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_TTNgoai_List  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_TTNgoai_List  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}