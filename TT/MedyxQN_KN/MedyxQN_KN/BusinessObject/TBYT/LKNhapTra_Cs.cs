using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class LKNhapTra_Cs : BusinessListBase<LKNhapTra_Cs, LKNhapTra_C>
    {
        #region Business Methods
        public LKNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public LKNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (LKNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public LKNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (LKNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                LKNhapTra_C obj = LKNhapTra_C.NewLKNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKNhapTra_C NewTo()
        {
           
              LKNhapTra_C obj = LKNhapTra_C.NewLKNhapTra_C();
              return obj;
               
        }
        public void NewTo(LKNhapTra_C _LKNhapTra_C)
        {
            if (!Contains(_LKNhapTra_C.MaLK))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _LKNhapTra_C.STT = ++_count;
                    this.Add(_LKNhapTra_C);
                }
                else
                {
                    _LKNhapTra_C.STT = 1;
                    this.Add(_LKNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKNhapTra_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                LKNhapTra_C obj = LKNhapTra_C.NewLKNhapTra_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKNhapTra_C AssignTo(LKNhapTra_C _LKNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (_LKNhapTra_C.HanSD == "01/01/0001")
                _LKNhapTra_C.HanSD = "";
            if (!Containss(_LKNhapTra_C.MaLK, _LKNhapTra_C.Huy,_LKNhapTra_C.SoLo ,_LKNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _LKNhapTra_C.STT = ++_count;
                    this.Add(_LKNhapTra_C);
                }
                else
                {
                    _LKNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_LKNhapTra_C);
                }
            }

            return _LKNhapTra_C;
        }

        protected override object AddNewCore()
        {
            LKNhapTra_C item = LKNhapTra_C.NewLKNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (LKNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(LKNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(LKNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (LKNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaLK, Boolean Huy,string solo, string hansd)
        {
            //foreach (LKNhapTra_C obj in this)
            //    if ((obj.MaLK == MaLK) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
            
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (LKNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(LKNhapTra_C _LKNhapTra_C)
        {
            //if (!Containss(_LKNhapTra_C.MaLK, _LKNhapTra_C.Huy))
            //{
                _LKNhapTra_C.STT = this.Items[this.IndexOf(_LKNhapTra_C)].STT;
                this.Items[this.IndexOf(_LKNhapTra_C)] = _LKNhapTra_C;
            //}
          
        }
        public LKNhapTra_C GetTo(decimal STT)
        {
            foreach (LKNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static LKNhapTra_Cs NewLKNhapTra_Cs()
        {
            return new LKNhapTra_Cs();
        }

        internal static LKNhapTra_Cs GetLKNhapTra_Cs(SafeDataReader dr)
        {
            return new LKNhapTra_Cs(dr);
        }

        private LKNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private LKNhapTra_Cs(SafeDataReader dr)
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
                this.Add(LKNhapTra_C.GetLKNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(LKNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (LKNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (LKNhapTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPNT == "")   //MaPNT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}