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

    public class BenhAn_San_TKList : BusinessListBase<BenhAn_San_TKList, BenhAn_San_TK>
    {
        #region Factory Methods
        public static BenhAn_San_TKList GetAllBenhAn_San_TK(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_San_TKList>(new Criteria(MaBA, DK, Qadmin));
        }
   
        public BenhAn_San_TK NewTo()
        {
            BenhAn_San_TK obj = BenhAn_San_TK.NewBenhAn_San_TK();
            return obj;
        }
        public void NewTo(BenhAn_San_TK _BenhAn_San_TK)
        {
            try
            {
               
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_San_TK.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_San_TK);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_San_TK.STT = ++_count;
                        this.Add(_BenhAn_San_TK);
                    }
                    else
                    {
                        _BenhAn_San_TK.STT = 1;
                        this.Add(_BenhAn_San_TK);

                    }
                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }


        public void UpdatedTo(BenhAn_San_TK _BenhAn_San_TK)
        {

            _BenhAn_San_TK.STT = this.Items[this.IndexOf(_BenhAn_San_TK)].STT;
            this.Items[this.IndexOf(_BenhAn_San_TK)] = _BenhAn_San_TK;
        }
        //public void RemoveTo(BenhAn_San_TK _BenhAn_San_TK)
        //{
        //    this.Items.Remove(_BenhAn_San_TK);

        //}
        public void RemoveTo(BenhAn_San_TK obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_San_TK AssignTo(BenhAn_San_TK _BenhAn_San_TK)//add mot hang PhieuNhap_C
        {
          
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_San_TK.STT = ++_count;
                    this.Add(_BenhAn_San_TK);
                }
                else
                {
                    _BenhAn_San_TK.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_San_TK);
                }
          
            //Add(_PhieuNhap_C);
            return _BenhAn_San_TK;
        }
       
        public BenhAn_San_TK GetBenhAn_San_TKById(string MaBA, int stt)
        {
            foreach (BenhAn_San_TK item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt)
        {
            foreach (BenhAn_San_TK item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_San_TK GetTo(decimal STT) //
        {
            foreach (BenhAn_San_TK obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_San_TK item = BenhAn_San_TK.NewBenhAn_San_TK();
            Add(item);
            return item;
        }


        private BenhAn_San_TKList()
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
        private class Criteria
        {
            private String _MaBA;
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
            public Criteria(String mMaBA, String DK, Boolean QAdmin)
            {
                _MaBA = mMaBA;
                _DK = DK;
                _qadmin = QAdmin;

            }
        }
     

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San_TK(criteria.MaBA, "", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_San_TK.GetBenhAn_San_TK(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
     
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_San_TK item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_San_TK item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_San_TKList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_San_TKList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
