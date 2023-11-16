using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauNhapTra_Cs : BusinessListBase<MauNhapTra_Cs, MauNhapTra_C>
    {
        #region Business Methods
        public MauNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public MauNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (MauNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public MauNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (MauNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                MauNhapTra_C obj = MauNhapTra_C.NewMauNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauNhapTra_C NewTo()
        {
           
              MauNhapTra_C obj = MauNhapTra_C.NewMauNhapTra_C();
              return obj;
               
        }
        public void NewTo(MauNhapTra_C _MauNhapTra_C)
        {
            if (!Contains(_MauNhapTra_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauNhapTra_C.STT = ++_count;
                    this.Add(_MauNhapTra_C);
                }
                else
                {
                    _MauNhapTra_C.STT = 1;
                    this.Add(_MauNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauNhapTra_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauNhapTra_C obj = MauNhapTra_C.NewMauNhapTra_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauNhapTra_C AssignTo(MauNhapTra_C _MauNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_MauNhapTra_C.MaCPMau, _MauNhapTra_C.Huy, _MauNhapTra_C.SoLo, _MauNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _MauNhapTra_C.STT = ++_count;
                    this.Add(_MauNhapTra_C);
                }
                else
                {
                    _MauNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_MauNhapTra_C);
                }
            }

            return _MauNhapTra_C;
        }

        protected override object AddNewCore()
        {
            MauNhapTra_C item = MauNhapTra_C.NewMauNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (MauNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(MauNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(MauNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (MauNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau, Boolean Huy, string solo, string hansd)
        {
            foreach (MauNhapTra_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (MauNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(MauNhapTra_C _MauNhapTra_C)
        {
            //if (!Containss(_MauNhapTra_C.MaCPMau, _MauNhapTra_C.Huy))
            //{
                _MauNhapTra_C.STT = this.Items[this.IndexOf(_MauNhapTra_C)].STT;
                this.Items[this.IndexOf(_MauNhapTra_C)] = _MauNhapTra_C;
            //}
          
        }
        public MauNhapTra_C GetTo(decimal STT)
        {
            foreach (MauNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauNhapTra_Cs NewMauNhapTra_Cs()
        {
            return new MauNhapTra_Cs();
        }

        internal static MauNhapTra_Cs GetMauNhapTra_Cs(SafeDataReader dr)
        {
            return new MauNhapTra_Cs(dr);
        }

        private MauNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauNhapTra_Cs(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(MauNhapTra_C.GetMauNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(MauNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauNhapTra_C item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}