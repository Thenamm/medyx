using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBPhieuNhap_KP_List : BusinessListBase<TBPhieuNhap_KP_List, TBPhieuNhap_KP>
    {
         #region Business Methods

        public TBPhieuNhap_KP this[string MaPN]
        {
            get
            {
                foreach (TBPhieuNhap_KP obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }
        public TBPhieuNhap_KP this[decimal STT]
        {
            get
            {
                foreach (TBPhieuNhap_KP obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                TBPhieuNhap_KP obj = TBPhieuNhap_KP.NewTBPhieuNhap_KP(MaPN);
                int _count;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_KP NewTo()
        {

              TBPhieuNhap_KP obj = TBPhieuNhap_KP.NewTBPhieuNhap_KP();
              return obj;
               
        }
        public void NewTo(TBPhieuNhap_KP _TBPhieuNhap_KP) 
        {
            if (!Containss(_TBPhieuNhap_KP.MaNguon, _TBPhieuNhap_KP.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuNhap_KP.STT = ++_count;
                    this.Add(_TBPhieuNhap_KP);
                }
                else
                {
                    _TBPhieuNhap_KP.STT = 1;
                    this.Add(_TBPhieuNhap_KP);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_KP AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBPhieuNhap_KP obj = TBPhieuNhap_KP.NewTBPhieuNhap_KP(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_KP AssignTo(TBPhieuNhap_KP _TBPhieuNhap_KP)//add mot hang TBPhieuNhap_KP
        {
            if (!Containss(_TBPhieuNhap_KP.MaNguon, _TBPhieuNhap_KP.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuNhap_KP.STT = ++_count;

                    this.Add(_TBPhieuNhap_KP);
                }
                else
                {
                    _TBPhieuNhap_KP.STT = 1;
                    this.Add(_TBPhieuNhap_KP);
                }
            }
           
           return _TBPhieuNhap_KP;
        }
        protected override object AddNewCore()
        {
            TBPhieuNhap_KP item = TBPhieuNhap_KP.NewTBPhieuNhap_KP();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void  RemoveTo(decimal stt) //xoa 1 TBPhieuNhap_KP
        {
           
            foreach (TBPhieuNhap_KP obj in this)
            {
                if (obj.STT == stt)
                {
                    this.Items.RemoveAt(this.IndexOf(obj));
                    break; 
                   
                }
            }

        //    //TBPhieuNhap_KP obj;
        //    for(int i = 0;i < this.Items.Count ;i ++ )
        //    {
        //       // obj = this.Items[i];
        //        if (this.Items[i].STT == stt)
        //        {
        //            this.Items.RemoveAt(i);
        //            break;

        //        }
        //    }
        }
        public void RemoveTo(TBPhieuNhap_KP obj) //xoa 1 TBPhieuNhap_KP
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public void RemoveTo(string MaTB)
        {
            try
            {
                foreach (TBPhieuNhap_KP obj in this)
                {
                    if (obj.MaTB.Equals(MaTB))
                    {
                        if (obj.IsNew == true)
                        {
                            this.Items.Remove(obj);
                            break;
                        }
                        else
                        {
                            Remove(obj);
                            break;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi ở file KiemKe_HDList " + ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        public bool Contains(string MaPN)
        {
            foreach (TBPhieuNhap_KP obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuNhap_KP obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuNhap_KP obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaTB, Boolean Huy)
        {
            foreach (TBPhieuNhap_KP obj in this)
                if ((obj.MaNguon == MaTB) && (obj.Huy == Huy))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (TBPhieuNhap_KP obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(TBPhieuNhap_KP _TBPhieuNhap_KP)
        {

            _TBPhieuNhap_KP.STT = this.Items[this.IndexOf(_TBPhieuNhap_KP)].STT;
            this.Items[this.IndexOf(_TBPhieuNhap_KP)] = _TBPhieuNhap_KP;
        }
        //public void UpdatedTo(TBPhieuNhap_KP_List _TBPhieuNhap_KP_List)
        //{

        //    _TBPhieuNhap_KP.STT = this.Items[this.IndexOf(_TBPhieuNhap_KP)].STT;
        //    this.Items[this.IndexOf(_TBPhieuNhap_KP)] = _TBPhieuNhap_KP;
        //}
        public TBPhieuNhap_KP GetTo(decimal STT) //
        {
            foreach (TBPhieuNhap_KP obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static TBPhieuNhap_KP_List NewTBPhieuNhap_KP_List()
        {
            return new TBPhieuNhap_KP_List();
        }

        internal static TBPhieuNhap_KP_List GetTBPhieuNhap_KP_List(SafeDataReader dr)
        {
            return new TBPhieuNhap_KP_List(dr);
        }

        private TBPhieuNhap_KP_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBPhieuNhap_KP_List(SafeDataReader dr)
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
                
                this.Add(TBPhieuNhap_KP.GetTBPhieuNhap_KP(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public void Update(TBPhieuNhap_C packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBPhieuNhap_KP item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBPhieuNhap_KP item in this)
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
