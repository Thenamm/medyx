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
    public class BenhAn_C_List : BusinessListBase<BenhAn_C_List, BenhAn_C>
    {
        #region Factory Methods
        public static BenhAn_C_List NewList()
        {
            return DataPortal.Fetch<BenhAn_C_List>(new TemCriteria());
        }
        public static BenhAn_C_List GetAllBenhAn_C(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_C_List GetAllBenhAn_C(String MaBA,string dk, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new OtherCriteria(MaBA, 0, dk, 5, qadmin));
        }
        public static BenhAn_C_List GetAllBenhAn_CKhoa(String MaBA, string makhoa, DateTime NgayDK, string dk, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new CriteriaOther(MaBA,makhoa,NgayDK, dk,qadmin ));
        }
        public static BenhAn_C_List GetAllBenhAn_CBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin));
        }
        public static BenhAn_C_List GetAllBenhAn_CByNgayYC(String MaBA, int sttKhoa, string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin  ));
        }
    
        public static BenhAn_C_List GetAllBenhAn_CByKhoaNgayYC(String MaBA, int sttKhoa, DateTime NgayDK, string makhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new OtherCriteria(MaBA, sttKhoa, " and datediff(d,a.NgayDK,'" + NgayDK.Month.ToString() + "/" + NgayDK.Day.ToString()+"/" +NgayDK.Year.ToString()+ "') =0 and a.makhoa like'" + makhoa + "%'", 3,qadmin ));
        }
        public static BenhAn_C_List GetAllBenhAn_CByKhoaNgayYCSTT(String MaBA, int sttKhoa, DateTime NgayDK, int stt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_C_List>(new OtherCriteria(MaBA, sttKhoa, " and a.sttkhoa =" + sttKhoa + "  and a.stt =" + stt + " and datediff(d,a.NgayDK,'" + NgayDK.Month.ToString() + "/" + NgayDK.Day.ToString() + "/" + NgayDK.Year.ToString() + "') =0 ", 4,qadmin ));
        }
        public BenhAn_C NewTo() 
        {
            BenhAn_C obj = BenhAn_C.NewBenhAn_C();
            return obj;
        }
        public void NewTo(BenhAn_C _BenhAn_C)
        {
            try
            {
                if (!Contains(_BenhAn_C.MaDV, _BenhAn_C.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_C.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_C);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_C.STT = ++_count;
                        this.Add(_BenhAn_C);
                    }
                    else
                    {
                        _BenhAn_C.STT = 1;
                        this.Add(_BenhAn_C);

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
       
      
        public void UpdatedTo(BenhAn_C _BenhAn_C)
        {

            _BenhAn_C.STT = this.Items[this.IndexOf(_BenhAn_C)].STT;
            this.Items[this.IndexOf(_BenhAn_C)] = _BenhAn_C;
        }
        //public void RemoveTo(BenhAn_C _BenhAn_C)
        //{
        //    this.Items.Remove(_BenhAn_C);

        //}
        public void RemoveTo(BenhAn_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_C  AssignTo(BenhAn_C  _BenhAn_C)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_C.MaDV,  _BenhAn_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_C.STT = ++_count;
                    this.Add(_BenhAn_C);
                }
                else
                {
                    _BenhAn_C.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_C);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_C;
        }
        public BenhAn_C Containsfind(int stt, int sttkhoa)
        {
            foreach (BenhAn_C obj in this)
                if ((obj.STT == stt) && (obj.STTKhoa == sttkhoa))
                    return obj;
            return null;

        }
        public bool Contains(string MaDV, bool Huy)
        {
           //foreach (BenhAn_C  obj in this)
           //     if ((obj.MaDV == MaDV) && (obj.Huy == Huy))
           //     {
           //         //if (MessageBox.Show("Dịch vụ này đã được chọn rồi ! Bạn chọn tiếp ?","Thongbao",MessageBoxButtons.OKCancel ) == DialogResult.OK   )
           //         //return false;
           //         //else
           //         //return true;
           //     }
            return false;
        }
        public BenhAn_C  GetBenhAn_CById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_C  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_C  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_C GetTo(decimal STT) //
        {
            foreach (BenhAn_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_C  item = BenhAn_C.NewBenhAn_C();
            Add(item);
            return item;
        }

      
        private BenhAn_C_List()
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
            public Criteria(String mMaBA,Boolean qadmin)
            {
                _MaBA = mMaBA;
                _qadmin = qadmin;
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
            public OtherCriteria(String MaBA, int sttKhoa, string DK, byte loai, Boolean qadmin)
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
                _qadmin = qadmin;
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
            public CriteriaOther(String MaBA, string makhoa,DateTime ngaydk , string DK,Boolean qadmin)
            {
               
                _DK = _DK + DK;
               if (makhoa !="All" && makhoa !="")
                   _DK = _DK + " and a.makhoa like'"+makhoa +"%'";
               // if (ngaydk !=null)
               //if (ngaydk!= DateTime.MinValue )
               // if (ngaydk.CompareTo(DateTime.Parse ("12/01/1900"))>0)
               //    _DK = _DK + " and datediff(d,a.ngaydk,'"+  ngaydk.Month.ToString ()  +"/" + ngaydk.Day.ToString ()+ "/" +ngaydk.Year .ToString ("####") + "')=0";
                _MaBA = MaBA;
                _qadmin =qadmin;
            }
        }
    
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_C(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                   
                    this.Add(BenhAn_C.GetBenhAn_C(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_CBySTTKhoa(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    if (criteria.loaiphieu != 4)
                    {
                        this.Add(BenhAn_C.GetBenhAn_C(dr, i));
                    }
                    else
                    {
                        this.Add(BenhAn_C.GetBenhAn_C(dr, i,4));
              
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_C(criteria.MaBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {

                    this.Add(BenhAn_C.GetBenhAn_C(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_C  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_C  item in this)
            {
                
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_C_List  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_C_List  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}