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
    public class PhieuSoChe_Cs : BusinessListBase<PhieuSoChe_Cs, PhieuSoChe_C>
    {
        #region Business Methods
        public PhieuSoChe_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuSoChe_C this[Decimal STT]
        {
            get
            {
                foreach (PhieuSoChe_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
       
        public void NewTo(string MaSC)
        {
            if (!Contains(MaSC))
            {
                PhieuSoChe_C obj = PhieuSoChe_C.NewPhieuSoChe_C(MaSC);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuSoChe_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuSoChe_C obj = PhieuSoChe_C.NewPhieuSoChe_C();
            return obj;

        }

        public void NewTo(PhieuSoChe_C _PhieuSoChe_C)
        {
            if (!Contains(_PhieuSoChe_C.MaSC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _PhieuSoChe_C.STT = ++_count;
                    this.Add(_PhieuSoChe_C);
                }
                else
                {
                    _PhieuSoChe_C.STT = 1;
                    this.Add(_PhieuSoChe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuSoChe_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhieuSoChe_C obj = PhieuSoChe_C.NewPhieuSoChe_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public PhieuSoChe_C AssignTo(PhieuSoChe_C _PhieuSoChe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_PhieuSoChe_C .maThuocC ,_PhieuSoChe_C.maThuocS, _PhieuSoChe_C.Huy, _PhieuSoChe_C.SoLo ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuSoChe_C.maThuocC = _PhieuSoChe_C.maThuocC; 
                    _PhieuSoChe_C.STT = ++_count;
                    this.Add(_PhieuSoChe_C);
                }
                else
                {
                    _PhieuSoChe_C.STT = 1;
                   
                    this.Add(_PhieuSoChe_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _PhieuSoChe_C;
        }

        protected override object AddNewCore()
        {
            PhieuSoChe_C item = PhieuSoChe_C.NewPhieuSoChe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(PhieuSoChe_C obj)
        {
            //foreach (PhieuSoChe_C obj in this)
            //{
            //    if (obj.MaSC.Equals(MaSC))
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
            foreach (PhieuSoChe_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaSC)
        {
            foreach (PhieuSoChe_C obj in this)
                if ((obj.MaSC == MaSC) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuocS,String MathuocC, Boolean Huy,string solo)
        {
            foreach (PhieuSoChe_C  obj in this)
                //if (hansd !="" || obj.HanSD !="") 
                //{
                //    if ((obj.maThuocS  == MaThuoc) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System,Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))     
                //    return true;
                //}
                //else
                {
                    if ((obj.maThuocS == MaThuocS) && (obj.maThuocS  == MathuocC ) && (obj.SoLo == solo))//&&  (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day , DateTime.Parse(hansd) , DateTime.Parse(obj.HanSD),Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System)==0))      
                    return true;
                }
                
            return false;
        }

        public bool ContainsDeleted(string MaSC)
        {
            foreach (PhieuSoChe_C obj in DeletedList)
                if (obj.MaSC == MaSC)
                    return true;
            return false;
        }

        public void UpdatedTo(PhieuSoChe_C _PhieuSoChe_C)
        {

            _PhieuSoChe_C.STT = this.Items[this.IndexOf(_PhieuSoChe_C)].STT;
           this.Items[this.IndexOf(_PhieuSoChe_C)] = _PhieuSoChe_C;
        }

        public PhieuSoChe_C GetTo(decimal STT)
        {
            foreach (PhieuSoChe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static PhieuSoChe_Cs NewPhieuSoChe_Cs()
        {
            return new PhieuSoChe_Cs();
        }

        internal static PhieuSoChe_Cs GetPhieuSoChe_Cs(SafeDataReader dr)
        {
            return new PhieuSoChe_Cs(dr);
        }

        private PhieuSoChe_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuSoChe_Cs(SafeDataReader dr)
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
                this.Add(PhieuSoChe_C.GetPhieuSoChe_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(PhieuSoChe packet)
        {
            RaiseListChangedEvents = false;
            foreach (PhieuSoChe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (PhieuSoChe_C item in this)
            {
                if ((item.IsNew))// && item.MaSC == "")   //MaSC ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}