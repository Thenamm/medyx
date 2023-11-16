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

    public class DMKetQuaTTDDList : BusinessListBase<DMKetQuaTTDDList, DMKetQuaTTDD>
    {
        #region Factory Methods
        public static DMKetQuaTTDDList GetAllDMKetQuaTTDD(Int32 Loai, Boolean Qadmin)
        {
            DMKetQuaTTDDList list = new DMKetQuaTTDDList();
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKetQuaTTDD(Loai, Qadmin)))
            {
                int i = 0;
                while (dr.Read())
                {
                    list.Add(new DMKetQuaTTDD(dr,i));
                    i++;
                }
            }
            return list;
            //return DataPortal.Fetch<DMKetQuaTTDDList>(new Criteria(Loai ,Qadmin ));
        }
        public static DMKetQuaTTDDList GetDMKetQuaTTDD(int MaKQ, int Loai)
        {
            return DataPortal.Fetch<DMKetQuaTTDDList>(new CriteriaTT(MaKQ , Loai));
        }
        public DMKetQuaTTDD NewTo() 
        {
            DMKetQuaTTDD obj = DMKetQuaTTDD.NewDMKetQuaTTDD();
            return obj;
        }
        public void NewTo(DMKetQuaTTDD _DMKetQuaTTDD)
        {
            try
            {
                if (!Contains( _DMKetQuaTTDD.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMKetQuaTTDD.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMKetQuaTTDD);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_DMKetQuaTTDD.STT = ++_count;
                        this.Add(_DMKetQuaTTDD);
                    }
                    else
                    {
                        //_DMKetQuaTTDD.STT = 1;
                        this.Add(_DMKetQuaTTDD);

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
       
      
        public void UpdatedTo(DMKetQuaTTDD _DMKetQuaTTDD)
        {
           this.Items[this.IndexOf(_DMKetQuaTTDD)] = _DMKetQuaTTDD;
        }
        public void RemoveTo(DMKetQuaTTDD obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public DMKetQuaTTDD  AssignTo(DMKetQuaTTDD  _DMKetQuaTTDD)//add mot hang PhieuNhap_C
        {
            if (!Contains( _DMKetQuaTTDD.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_DMKetQuaTTDD.STT = ++_count;
                    this.Add(_DMKetQuaTTDD);
                }
                else
                {
                    //_DMKetQuaTTDD.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_DMKetQuaTTDD);
                }
            }
            //Add(_PhieuNhap_C);
            return _DMKetQuaTTDD;
        }
        public bool Contains(bool Huy)
        {
            //foreach (DMKetQuaTTDD  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public DMKetQuaTTDD  GetDMKetQuaTTDDById(int MaKQ, int Loai)
        {
            foreach (DMKetQuaTTDD  item in this)
                if ((item.MaKQ == MaKQ) && (item.Loai == Loai))
                    return item;
            return null;
        }
        public void Remove(int MaKQ, int Loai)
        {
            foreach (DMKetQuaTTDD  item in this)
            {
                if ((item.MaKQ == MaKQ) && (item.Loai == Loai))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public DMKetQuaTTDD GetTo(int MaKQ, int Loai) //
        {
            foreach (DMKetQuaTTDD obj in this)
                if (obj.MaKQ == MaKQ&&obj.Loai==Loai)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            DMKetQuaTTDD  item = DMKetQuaTTDD.NewDMKetQuaTTDD();
            Add(item);
            return item;
        }

      
        private DMKetQuaTTDDList()
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
            private Int32  _Loai;
            private Boolean _qadmin = false ;
            public Int32 Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Int32 Loai, Boolean QAdmin)
            {
                _Loai = Loai;
                _qadmin = QAdmin;
                
            }
        }
        private class CriteriaTT
        {
            private Int32 _Loai;
            private Boolean _qadmin = false;
            public Int32 Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private Int32 _MaKQ;
            public Int32 MaKQ
            {
                get
                {
                    return _MaKQ;
                }
            }
            public CriteriaTT(Int32 MaKQ, Int32 Loai)
            {
                _Loai = Loai;
                _MaKQ = MaKQ;
            }
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMKetQuaTTDD  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMKetQuaTTDD  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMKetQuaTTDDList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMKetQuaTTDDList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
