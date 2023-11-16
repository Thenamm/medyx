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
    public class PhieuKiemNghiem_MTs : BusinessListBase<PhieuKiemNghiem_MTs, PhieuKiemNghiem_MT>
    {
        #region Business Methods
        public PhieuKiemNghiem_MT this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuKiemNghiem_MT this[string MaMT]
        {
            get
            {
                foreach (PhieuKiemNghiem_MT obj in this)
                    if (obj.MaMT.Equals(MaMT))
                        return obj;
                return null;
            }
        }
        public PhieuKiemNghiem_MT this[decimal STT]
        {
            get
            {
                foreach (PhieuKiemNghiem_MT obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

      
        public PhieuKiemNghiem_MT NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuKiemNghiem_MT obj = PhieuKiemNghiem_MT.NewPhieuKiemNghiem_MT();
            return obj;

        }
        public void NewTo(PhieuKiemNghiem_MT _PhieuKiemNghiem_MT) //moi sua
        {
            if (!Containss(_PhieuKiemNghiem_MT.MaKN, _PhieuKiemNghiem_MT.MaMT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuKiemNghiem_MT.STT = ++_count;
                    this.Add(_PhieuKiemNghiem_MT);
                }
                else
                {
                    _PhieuKiemNghiem_MT.STT = 1;
                    this.Add(_PhieuKiemNghiem_MT);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_MT AssignTo()
        {
            //if (!Contains(_DMThuoc.maDG))
            //{
                PhieuKiemNghiem_MT obj = PhieuKiemNghiem_MT.NewPhieuKiemNghiem_MT();
                return obj;
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_MT AssignTo(PhieuKiemNghiem_MT _PhieuKiemNghiem_MT)//add mot hang PhieuKiemNghiem_MT
        {
            if (!Containss(_PhieuKiemNghiem_MT.MaKN , _PhieuKiemNghiem_MT.MaMT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;

                    _PhieuKiemNghiem_MT.STT = ++_count;

                    this.Add(_PhieuKiemNghiem_MT);
                }
                else
                {
                    _PhieuKiemNghiem_MT.STT = 1;

                    this.Add(_PhieuKiemNghiem_MT);
                }
            }

            return _PhieuKiemNghiem_MT;
        }
        protected override object AddNewCore()
        {
            PhieuKiemNghiem_MT item = PhieuKiemNghiem_MT.NewPhieuKiemNghiem_MT();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhieuKiemNghiem_MT
        //{

        //    //foreach (PhieuKiemNghiem_MT obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //PhieuKiemNghiem_MT obj;
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
        public void RemoveTo(PhieuKiemNghiem_MT obj) //xoa 1 PhieuKiemNghiem_MT
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Containss(string MaKN, string MaMT)
        {
            foreach (PhieuKiemNghiem_MT obj in this)
                if ((obj.MaKN == MaKN) && (obj.MaMT == MaMT) && (obj.Huy == false))
                    return true;
            return false;
        }
     
      


        public bool ContainsDeleted(string MaKN)
        {
            foreach (PhieuKiemNghiem_MT obj in DeletedList)
                if (obj.MaKN == MaKN)
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuKiemNghiem_MT _PhieuKiemNghiem_MT)
        {

            _PhieuKiemNghiem_MT.STT = this.Items[this.IndexOf(_PhieuKiemNghiem_MT)].STT;
            this.Items[this.IndexOf(_PhieuKiemNghiem_MT)] = _PhieuKiemNghiem_MT;
        }
        public PhieuKiemNghiem_MT GetTo(decimal STT) //
        {
            foreach (PhieuKiemNghiem_MT obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods
        public static PhieuKiemNghiem_MTs GetAllPhieuKiemNghiem_MT(String makn,string macs)
        {
            return DataPortal.Fetch<PhieuKiemNghiem_MTs>(new Criteria(makn,macs));
        }
        internal static PhieuKiemNghiem_MTs NewPhieuKiemNghiem_MTs()
        {
            return new PhieuKiemNghiem_MTs();
        }

        internal static PhieuKiemNghiem_MTs GetPhieuKiemNghiem_MTs(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_MTs(dr);
        }
       
        private PhieuKiemNghiem_MTs()
        {
            this.AllowNew = true;
          
        }

        private PhieuKiemNghiem_MTs(SafeDataReader dr)
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
           
             private Boolean _qadmin = false ;
            private String _MaKN;
            public String MaKN
            {
                get
                {
                    return _MaKN;
                }
            }
            private String _MaCS;
            public String MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMakn,string mmacs)
            {
                _MaKN = mMakn;
                _MaCS = mmacs;
                

            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuKiemNghiem_MT(criteria.MaKN, criteria.MaCS, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(PhieuKiemNghiem_MT.GetPhieuKiemNghiem_MT(dr));/////////
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())

                this.Add(PhieuKiemNghiem_MT.GetPhieuKiemNghiem_MT(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
         protected override void DataPortal_Update()
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuKiemNghiem_MT item in DeletedList)
                item.DeleteSelf();
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuKiemNghiem_MT item in this)
            {
                if ((item.IsNew))// && item.NgaySD == "")   //MaKN  == ""))
                    item.Insert();
                else if (item.IsDirty==true)
                    item.Update();
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
         public override PhieuKiemNghiem_MTs Save()
         {
             // see if save is allowed
             if (!CanEditObject())
                 throw new System.Security.SecurityException(
                   "User not authorized to save DonviTCs");

             PhieuKiemNghiem_MTs result;
             result = base.Save();
             return result;
         }
        #endregion

    }
}
