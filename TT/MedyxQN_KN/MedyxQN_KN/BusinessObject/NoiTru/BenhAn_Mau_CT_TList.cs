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

    public class BenhAn_Mau_CT_TList : BusinessListBase<BenhAn_Mau_CT_TList, BenhAn_Mau_CT_T>
    {
        #region Factory Methods
        public static BenhAn_Mau_CT_TList NewList()
        {
            return DataPortal.Fetch<BenhAn_Mau_CT_TList>(new TemCriteria());
        }
        public static BenhAn_Mau_CT_TList GetAllBenhAn_Mau_CT_T(String MaBA,Int32 sttkhoa, Int32 stt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_Mau_CT_TList>(new Criteria(MaBA,sttkhoa,stt,qadmin  ));
        }
       
        public BenhAn_Mau_CT_T NewTo() 
        {
            BenhAn_Mau_CT_T obj = BenhAn_Mau_CT_T.NewBenhAn_Mau_CT_T();
            return obj;
        }
        public void NewTo(BenhAn_Mau_CT_T _BenhAn_Mau_CT_T)
        {
            try
            {
               
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_Mau_CT_T.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_Mau_CT_T);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_Mau_CT_T.STTTruyen = ++_count;
                        this.Add(_BenhAn_Mau_CT_T);
                    }
                    else
                    {
                        _BenhAn_Mau_CT_T.STTTruyen = 1;
                        this.Add(_BenhAn_Mau_CT_T);

                    }
              
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(BenhAn_Mau_CT_T _BenhAn_Mau_CT_T)
        {

            _BenhAn_Mau_CT_T.STTTruyen = this.Items[this.IndexOf(_BenhAn_Mau_CT_T)].STTTruyen;
            this.Items[this.IndexOf(_BenhAn_Mau_CT_T)] = _BenhAn_Mau_CT_T;
        }
        //public void RemoveTo(BenhAn_Mau_CT_T _BenhAn_Mau_CT_T)
        //{
        //    this.Items.Remove(_BenhAn_Mau_CT_T);

        //}
        public void RemoveTo(BenhAn_Mau_CT_T obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public void Remove(string MaBA, int stt, int sttkhoa,int stttruyen)
        {
            foreach (BenhAn_Mau_CT_T  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa) && (item.STTTruyen == stttruyen ) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_Mau_CT_T GetTo(decimal STTtruyen) //
        {
            foreach (BenhAn_Mau_CT_T obj in this)
                if (obj.STTTruyen == STTtruyen)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_Mau_CT_T  item = BenhAn_Mau_CT_T.NewBenhAn_Mau_CT_T();
            Add(item);
            return item;
        }

      
        private BenhAn_Mau_CT_TList()
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
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
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
            public Criteria(String mMaBA,Int32 sttkhoa, Int32 stt, Boolean qadmin)
            {
                _MaBA = mMaBA;
                _qadmin = qadmin;
                _STTKhoa = sttkhoa;
                _STT = stt;
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
                    _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Mau_CT_T(criteria.MaBA,criteria.STTKhoa ,criteria.STT ,criteria.qadmin  )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Mau_CT_T.GetBenhAn_Mau_CT_T(dr,i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_Mau_CT_T  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_Mau_CT_T  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_Mau_CT_TList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_Mau_CT_TList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
