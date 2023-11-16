using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

using HTC.Business;
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuKiemNghiem_VSHKs : BusinessListBase<PhieuKiemNghiem_VSHKs, PhieuKiemNghiem_VSHK>
    {
        #region Business Methods
        public PhieuKiemNghiem_VSHK this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuKiemNghiem_VSHK this[string MaKN]
        {
            get
            {
                foreach (PhieuKiemNghiem_VSHK obj in this)
                    if (obj.MaKN.Equals(MaKN))
                        return obj;
                return null;
            }
        }
        public PhieuKiemNghiem_VSHK this[decimal STT]
        {
            get
            {
                foreach (PhieuKiemNghiem_VSHK obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

      
        public PhieuKiemNghiem_VSHK NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuKiemNghiem_VSHK obj = PhieuKiemNghiem_VSHK.NewPhieuKiemNghiem_VSHK();
            return obj;

        }
        public void NewTo(PhieuKiemNghiem_VSHK _PhieuKiemNghiem_VSHK) //moi sua
        {
            if (!Containss( _PhieuKiemNghiem_VSHK.Dia, _PhieuKiemNghiem_VSHK.NgayKQ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuKiemNghiem_VSHK.STT = ++_count;
                    this.Add(_PhieuKiemNghiem_VSHK);
                }
                else
                {
                    _PhieuKiemNghiem_VSHK.STT = 1;
                    this.Add(_PhieuKiemNghiem_VSHK);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_VSHK AssignTo()
        {
            //if (!Contains(_DMThuoc.maDG))
            //{
                PhieuKiemNghiem_VSHK obj = PhieuKiemNghiem_VSHK.NewPhieuKiemNghiem_VSHK();
                return obj;
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_VSHK AssignTo(PhieuKiemNghiem_VSHK _PhieuKiemNghiem_VSHK)//add mot hang PhieuKiemNghiem_VSHK
        {
            if (!Containss( _PhieuKiemNghiem_VSHK.Dia,_PhieuKiemNghiem_VSHK.NgayKQ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;

                    _PhieuKiemNghiem_VSHK.STT = ++_count;

                    this.Add(_PhieuKiemNghiem_VSHK);
                }
                else
                {
                    _PhieuKiemNghiem_VSHK.STT = 1;

                    this.Add(_PhieuKiemNghiem_VSHK);
                }
            }

            return _PhieuKiemNghiem_VSHK;
        }
        protected override object AddNewCore()
        {
            PhieuKiemNghiem_VSHK item = PhieuKiemNghiem_VSHK.NewPhieuKiemNghiem_VSHK();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhieuKiemNghiem_VSHK
        //{

        //    //foreach (PhieuKiemNghiem_VSHK obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //PhieuKiemNghiem_VSHK obj;
        //    for(int i = 0;i < this.Items.Count ;i ++ )
        //    {
        //       // obj = this.Items[i];
        //        if (this.Items[i].STT == stt)
        //        {
        //            this.Items.RemoveAt(i);
        //            break;

        //        }
        //    }
        //}
        public void RemoveTo(PhieuKiemNghiem_VSHK obj) //xoa 1 PhieuKiemNghiem_VSHK
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Containss(string Dia,string ngaykq)
        {
            foreach (PhieuKiemNghiem_VSHK obj in this)
                if ((obj.NgayKQ == ngaykq ) && (obj.Dia == Dia) && (obj.Huy == false))
                    return true;
            return false;
        }




        public bool ContainsDeleted(string Dia, SmartDate ngaykq)
        {
            foreach (PhieuKiemNghiem_VSHK obj in DeletedList)
                if ((obj.NgayKQ == ngaykq.DBValue.ToString()) && (obj.Dia == Dia) && (obj.Huy == false))
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuKiemNghiem_VSHK _PhieuKiemNghiem_VSHK)
        {

            _PhieuKiemNghiem_VSHK.STT = this.Items[this.IndexOf(_PhieuKiemNghiem_VSHK)].STT;
            this.Items[this.IndexOf(_PhieuKiemNghiem_VSHK)] = _PhieuKiemNghiem_VSHK;
        }
        public PhieuKiemNghiem_VSHK GetTo(decimal STT) //
        {
            foreach (PhieuKiemNghiem_VSHK obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods
        public static PhieuKiemNghiem_VSHKs GetAllPhieuKiemNghiem_VSHKs(String makn)
        {
            return DataPortal.Fetch<PhieuKiemNghiem_VSHKs>(new Criteria(makn));
        }
        internal static PhieuKiemNghiem_VSHKs NewPhieuKiemNghiem_VSHKs()
        {
            return new PhieuKiemNghiem_VSHKs();
        }

        internal static PhieuKiemNghiem_VSHKs GetPhieuKiemNghiem_VSHKs(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_VSHKs(dr);
        }
       
        private PhieuKiemNghiem_VSHKs()
        {
            this.AllowNew = true;
            
        }

        private PhieuKiemNghiem_VSHKs(SafeDataReader dr)
        {
            this.AllowNew = true;
           
            Fetch(dr);
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
        private class Criteria
        {
            private String _MaKN;
             private Boolean _qadmin = false ;
            public String MaKN
            {
                get
                {
                    return _MaKN;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMakn)
            {
                _MaKN = mMakn;


            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuKiemNghiem_VSHK(criteria.MaKN, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(PhieuKiemNghiem_VSHK.GetPhieuKiemNghiem_VSHK(dr));/////////
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())

                this.Add(PhieuKiemNghiem_VSHK.GetPhieuKiemNghiem_VSHK(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
         protected override void DataPortal_Update()
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuKiemNghiem_VSHK item in DeletedList)
                item.DeleteSelf();
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuKiemNghiem_VSHK item in this)
            {
                if ((item.IsNew))// && item.NgaySD == "")   //MaKN  == ""))
                    item.Insert();
                else if (item.IsDirty==true)
                    item.Update();
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
         public override PhieuKiemNghiem_VSHKs Save()
         {
             // see if save is allowed
             if (!CanEditObject())
                 throw new System.Security.SecurityException(
                   "User not authorized to save DonviTCs");

             PhieuKiemNghiem_VSHKs result;
             result = base.Save();
             return result;
         }
        #endregion

    }
}
