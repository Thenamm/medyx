using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuXuat_Cs : BusinessListBase<PhieuXuat_Cs, PhieuXuat_C>
    {
        #region Business Methods
        public PhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (PhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
       
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                PhieuXuat_C obj = PhieuXuat_C.NewPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuXuat_C obj = PhieuXuat_C.NewPhieuXuat_C();
            return obj;

        }

        public void NewTo(PhieuXuat_C _PhieuXuat_C)
        {
            if (!Contains(_PhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _PhieuXuat_C.STT = ++_count;
                    this.Add(_PhieuXuat_C);
                }
                else
                {
                    _PhieuXuat_C.STT = 1;
                    this.Add(_PhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuXuat_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhieuXuat_C obj = PhieuXuat_C.NewPhieuXuat_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuXuat_C AssignTo(PhieuXuat_C _PhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_PhieuXuat_C.MaThuoc, _PhieuXuat_C.Huy, _PhieuXuat_C.SoLo, _PhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuXuat_C.HanSD = _PhieuXuat_C.HanSD;
                    _PhieuXuat_C.STT = ++_count;
                    this.Add(_PhieuXuat_C);
                }
                else
                {
                    _PhieuXuat_C.STT = 1;
                    _PhieuXuat_C.HanSD = _PhieuXuat_C.HanSD;
                    this.Add(_PhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _PhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            PhieuXuat_C item = PhieuXuat_C.NewPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(PhieuXuat_C obj)
        {
            //foreach (PhieuXuat_C obj in this)
            //{
            //    if (obj.MaPX.Equals(MaPX))
            //    {
            //        Remove(obj);
            //        break;
            //    }
            //}
            if (obj.IsNew==true) 
                this.Items.Remove(obj);
            else Remove(obj );
        }
        public void RemoveTo(decimal  STT)
        {
            foreach (PhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (PhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy,string solo, string hansd)
        {
            //foreach (PhieuXuat_C  obj in this)
            //    if (hansd !="" || obj.HanSD !="") 
            //    {
            //        if ((obj.MaThuoc == MaThuoc) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System,Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))     
            //        return true;
            //    }
            //    else
            //    {
            //         if ((obj.MaThuoc == MaThuoc) && ( obj.SoLo == solo) &&  (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day , DateTime.Parse(hansd) , DateTime.Parse(obj.HanSD),Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System)==0))      
            //        return true;
            //    }
                
            return false;
            
        }

        public bool ContainsDeleted(string MaPX)
        {
            foreach (PhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(PhieuXuat_C _PhieuXuat_C)
        {

            _PhieuXuat_C.STT = this.Items[this.IndexOf(_PhieuXuat_C)].STT;
           this.Items[this.IndexOf(_PhieuXuat_C)] = _PhieuXuat_C;
        }

        public PhieuXuat_C GetTo(decimal STT)
        {
            foreach (PhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static PhieuXuat_Cs NewPhieuXuat_Cs()
        {
            return new PhieuXuat_Cs();
        }

        internal static PhieuXuat_Cs GetPhieuXuat_Cs(SafeDataReader dr)
        {
            return new PhieuXuat_Cs(dr);
        }

        private PhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(PhieuXuat_C.GetPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(PhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (PhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (PhieuXuat_C item in this)
            {
                if ((item.IsNew))// && item.MaPX == "")   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(PhieuXuatDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (PhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (PhieuXuat_C item in this)
            {
                if ((item.IsNew))// && item.MaPX == "")   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}