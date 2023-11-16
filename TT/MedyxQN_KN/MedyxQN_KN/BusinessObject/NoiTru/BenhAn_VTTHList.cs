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

    public class BenhAn_VTTHList : BusinessListBase<BenhAn_VTTHList, BenhAn_VTTH>
    {
        //public HTC.Common.MessageBox mb; 
        #region Factory Methods
        public static BenhAn_VTTHList NewList()
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new TemCriteria());
        }
        public static BenhAn_VTTHList GetAllBenhAn_VTTH(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_VTTHList GetAllBenhAn_VTTHBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin ));
        }
        public static BenhAn_VTTHList GetAllBenhAn_VTTH(String MaBA, string dk)
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new OtherCriteria(MaBA, 0, dk, 5,false ));
        }
        public static BenhAn_VTTHList GetAllBenhAn_VTTHByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin));
        }
        public static BenhAn_VTTHList GetAllBenhAn_VTTHByMaPT(String MaBA, int sttKhoa, string mapt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_VTTHList>(new OtherCriteria(MaBA, sttKhoa, mapt, 3,qadmin ));
        }
        public BenhAn_VTTH NewTo() 
        {
            BenhAn_VTTH obj = BenhAn_VTTH.NewBenhAn_VTTH();
            return obj;
        }
        public void NewTo(BenhAn_VTTH _BenhAn_VTTH)
        {
            try
            {
                if (!Contains(_BenhAn_VTTH.MaVT,  _BenhAn_VTTH.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_VTTH.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_VTTH);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_VTTH.STT = ++_count;
                        this.Add(_BenhAn_VTTH);
                    }
                    else
                    {
                        _BenhAn_VTTH.STT = 1;
                        this.Add(_BenhAn_VTTH);

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
       
      
        public void UpdatedTo(BenhAn_VTTH _BenhAn_VTTH)
        {

            _BenhAn_VTTH.STT = this.Items[this.IndexOf(_BenhAn_VTTH)].STT;
            this.Items[this.IndexOf(_BenhAn_VTTH)] = _BenhAn_VTTH;
        }
        //public void RemoveTo(BenhAn_VTTH _BenhAn_VTTH)
        //{
        //    this.Items.Remove(_BenhAn_VTTH);

        //}
        public void RemoveTo(BenhAn_VTTH obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_VTTH  AssignTo(BenhAn_VTTH  _BenhAn_VTTH)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_VTTH.MaVT, _BenhAn_VTTH.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_VTTH.STT = ++_count;
                    this.Add(_BenhAn_VTTH);
                }
                else
                {
                    _BenhAn_VTTH.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_VTTH);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_VTTH;
        }
        public bool Contains(string MaVT, bool Huy)
        {
          
            //foreach (BenhAn_VTTH  obj in this)
            //    if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && ((obj.SLTra == "0") || (obj.SLTra == "")) && (obj.DATT != 0))
            //    {
            //        if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //            return false;
            //        else
            //            return true;
            //    }
            return false;
        }
        public BenhAn_VTTH  GetBenhAn_VTTHById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_VTTH  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_VTTH  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_VTTH  GetTo(decimal STT) //
        {
            foreach (BenhAn_VTTH obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_VTTH  item = BenhAn_VTTH.NewBenhAn_VTTH();
            Add(item);
            return item;
        }

      
        private BenhAn_VTTHList()
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
            private int _STTKhoa;
             private Boolean _qadmin = false ;
            private String _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
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
            public OtherCriteria(String MaBA, int sttKhoa, string NgayDK, byte loai, Boolean qadmin)
            {
                if (loai == 3)
                {
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and a.mapttt ='"+ NgayDK +"'";
                }
                else if (loai == 5)
                {
                    _DK =  NgayDK ;
                }
                else if (DateTime.Now.ToString("dd/MM/yyyy") == DateTime.Now.ToShortDateString())
                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) =0 ";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                if (loai == 2 && HTC.ShareVariables.pub_spC == "HU")
                    _DK = _DK + " and isnull(a.mapttt,'') =''"; 
                _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_VTTH(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_VTTH .GetBenhAn_VTTH(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_VTTHBySTTKhoa(criteria.MaBA,criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_VTTH.GetBenhAn_VTTH(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_VTTH  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_VTTH  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew)  
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_VTTHList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_VTTHList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
