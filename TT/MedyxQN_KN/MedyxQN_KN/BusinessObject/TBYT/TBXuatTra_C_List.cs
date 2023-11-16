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
    public class TBXuatTra_C_List : BusinessListBase<TBXuatTra_C_List, TBXuatTra_C>
    {
        #region Business Methods
        public TBXuatTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }

        public TBXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (TBXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }
        public TBXuatTra_C this[decimal STT]
        {
            get
            {
                foreach (TBXuatTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
       
        public TBXuatTra_C NewTo()
        {
           
              TBXuatTra_C obj = TBXuatTra_C.NewTBXuatTra_C();
              return obj;
               
        }
        public void NewTo(TBXuatTra_C _TBXuatTra_C)
        {
            if (!Contains(_TBXuatTra_C.MaTBC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _TBXuatTra_C.STT = ++_count;
                    this.Add(_TBXuatTra_C);
                }
                else
                {
                    _TBXuatTra_C.STT = 1;
                    this.Add(_TBXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
      
        public bool Containss(string MaTBC, Boolean Huy)
        {
            foreach (TBXuatTra_C obj in this)
                if ((obj.MaTBC  == MaTBC) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string MaTBC, Boolean Huy, string SerialNo, string  Model)
        {
            foreach (TBXuatTra_C obj in this)
                if (SerialNo !=""&& Model !="")
                if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy) && (obj.SerialNo == SerialNo )&& (obj.Model == Model  ))
                    return true;
                else if (SerialNo == "" && Model == "")
                    if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy))
                        return true;
            return false;
        }
        public TBXuatTra_C AssignTo(TBXuatTra_C _TBXuatTra_C)//add mot hang TBXuatTra_C
        {
            if (!Containss(_TBXuatTra_C.MaTBC, _TBXuatTra_C.Huy, _TBXuatTra_C.SerialNo ,_TBXuatTra_C.Model  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.ModelD = _PhieuNhap_C.Model;
                    _TBXuatTra_C.STT = ++_count;
                    this.Add(_TBXuatTra_C);
                }
                else
                {
                    _TBXuatTra_C.STT = 1;
                    //_PhieuNhap_C.ModelD = _PhieuNhap_C.Model;
                    this.Add(_TBXuatTra_C);
                }
            }
            return _TBXuatTra_C;
        }
        protected override object AddNewCore()
        {
            TBXuatTra_C item = TBXuatTra_C.NewTBXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _stt)
        {
            foreach (TBXuatTra_C obj in this)
            {
                if (obj.STT.Equals(_stt))
                {
                    Remove(obj);
                    break;
                }
            }
        }
        public void RemoveTo(TBXuatTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPXT)
        {
            foreach (TBXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (TBXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(TBXuatTra_C _TBXuatTra_C)
        {

            _TBXuatTra_C.STT = this.Items[this.IndexOf(_TBXuatTra_C)].STT;
           this.Items[this.IndexOf(_TBXuatTra_C)] = _TBXuatTra_C;
        }
        public TBXuatTra_C GetTo(decimal STT)
        {
            foreach (TBXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static TBXuatTra_C_List NewTBXuatTra_C_List()
        {
            return new TBXuatTra_C_List();
        }

        internal static TBXuatTra_C_List GetTBXuatTra_C_List(SafeDataReader dr)
        {
            return new TBXuatTra_C_List(dr);
        }

        private TBXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBXuatTra_C_List(SafeDataReader dr)
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
                this.Add(TBXuatTra_C.GetTBXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(TBXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (TBXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (TBXuatTra_C item in this)
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