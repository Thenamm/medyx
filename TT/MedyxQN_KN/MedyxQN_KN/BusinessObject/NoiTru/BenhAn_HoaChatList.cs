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

    public class BenhAn_HoaChatList : BusinessListBase<BenhAn_HoaChatList, BenhAn_HoaChat>
    {
      
        #region Factory Methods
        

        public static BenhAn_HoaChatList NewList()
        {
            return DataPortal.Fetch<BenhAn_HoaChatList>(new TemCriteria());
        }
        public static BenhAn_HoaChatList GetAllBenhAn_HoaChat(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_HoaChatList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_HoaChatList GetAllBenhAn_HoaChatBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_HoaChatList>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin ));
        }
        public static BenhAn_HoaChatList GetAllBenhAn_HoaChat(String MaBA, string dk)
        {
            return DataPortal.Fetch<BenhAn_HoaChatList>(new OtherCriteria(MaBA, 0, dk, 5, false));
        }
        public static BenhAn_HoaChatList GetAllBenhAn_HoaChatByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_HoaChatList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin));
        }
        public BenhAn_HoaChat NewTo() 
        {
            BenhAn_HoaChat obj = BenhAn_HoaChat.NewBenhAn_HoaChat();
            return obj;
        }
        public void NewTo(BenhAn_HoaChat _BenhAn_HoaChat)
        {
            try
            {
                if (!Contains(_BenhAn_HoaChat.MaHC, _BenhAn_HoaChat.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_HoaChat.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_HoaChat);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_HoaChat.STT = ++_count;
                        this.Add(_BenhAn_HoaChat);
                    }
                    else
                    {
                        _BenhAn_HoaChat.STT = 1;
                        this.Add(_BenhAn_HoaChat);

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
       
      
        public void UpdatedTo(BenhAn_HoaChat _BenhAn_HoaChat)
        {

            _BenhAn_HoaChat.STT = this.Items[this.IndexOf(_BenhAn_HoaChat)].STT;
            this.Items[this.IndexOf(_BenhAn_HoaChat)] = _BenhAn_HoaChat;
        }
        //public void RemoveTo(BenhAn_HoaChat _BenhAn_HoaChat)
        //{
        //    this.Items.Remove(_BenhAn_HoaChat);

        //}
        public void RemoveTo(BenhAn_HoaChat obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_HoaChat  AssignTo(BenhAn_HoaChat  _BenhAn_HoaChat)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_HoaChat.MaHC,  _BenhAn_HoaChat.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_HoaChat.STT = ++_count;
                    this.Add(_BenhAn_HoaChat);
                }
                else
                {
                    _BenhAn_HoaChat.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_HoaChat);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_HoaChat;
        }
        public bool Contains(string MaHC, bool Huy)
        {
           
            //foreach (BenhAn_HoaChat  obj in this)
            //    if ((obj.MaHC == MaHC) && (obj.Huy == Huy) && ((obj.SLTra == "0") || (obj.SLTra == "")) && (obj.DATT != 0))
            //    {
                  
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel)  == DialogResult.OK)
            //        //         return false;
            //        //     else
            //        //         return true;
            //    }
            return false;
        }
        public BenhAn_HoaChat  GetBenhAn_HoaChatById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_HoaChat  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_HoaChat  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_HoaChat GetTo(decimal STT) //
        {
            foreach (BenhAn_HoaChat obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_HoaChat  item = BenhAn_HoaChat.NewBenhAn_HoaChat();
            Add(item);
            return item;
        }

      
        private BenhAn_HoaChatList()
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
                if (loai == 5)
                {
                    _DK = NgayDK ;
                }

                else if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
          
                else

                if (loai == 2)
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) =0 ";
                else
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_HoaChat(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HoaChat .GetBenhAn_HoaChat(dr,i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_HoaChatBySTTKhoa(criteria.MaBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HoaChat.GetBenhAn_HoaChat(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_HoaChat  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_HoaChat  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_HoaChatList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_HoaChatList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
