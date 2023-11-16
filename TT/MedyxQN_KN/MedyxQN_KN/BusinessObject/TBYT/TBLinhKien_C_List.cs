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
    public class TBLinhKien_C_List : BusinessListBase<TBLinhKien_C_List, TBLinhKien_C>
    {
         #region Business Methods

        public TBLinhKien_C this[string MaTBC]
        {
            get
            {
                foreach (TBLinhKien_C obj in this)
                    if (obj.MaTBC.Equals(MaTBC))
                        return obj;
                return null;
            }
        }
        public TBLinhKien_C this[decimal STT]
        {
            get
            {
                foreach (TBLinhKien_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaTBC)
        {
            if (!Contains(MaTBC))
            {
                TBLinhKien_C obj = TBLinhKien_C.NewTBLinhkien_C (MaTBC);
                int _count;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBLinhKien_C NewTo()
        {

            TBLinhKien_C obj = TBLinhKien_C.NewTBLinhkien_C();
            return obj;

        }
        public void NewTo(TBLinhKien_C _TBLinhKien_C)
        {
            if (!Containss(_TBLinhKien_C.MaLK, _TBLinhKien_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBLinhKien_C.STT = ++_count;
                    this.Add(_TBLinhKien_C);
                }
                else
                {
                    _TBLinhKien_C.STT = 1;
                    this.Add(_TBLinhKien_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBLinhKien_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBLinhKien_C obj = TBLinhKien_C.NewTBLinhkien_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBLinhKien_C AssignTo(TBLinhKien_C _TBLinhKien_C)//add mot hang TBLinhKien_C
        {
            if (!Contains(_TBLinhKien_C.MaLK  ))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBLinhKien_C.STT = ++_count;

                    this.Add(_TBLinhKien_C);
                }
                else
                {
                    _TBLinhKien_C.STT = 1;
                    this.Add(_TBLinhKien_C);
                }
            }
           
           return _TBLinhKien_C;
        }
        protected override object AddNewCore()
        {
            TBLinhKien_C item = TBLinhKien_C.NewTBLinhkien_C ();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void  RemoveTo(decimal stt) //xoa 1 TBLinhKien_C
        {
           
            foreach (TBLinhKien_C obj in this)
            {
                if (obj.STT == stt)
                {
                    this.Items.RemoveAt(this.IndexOf(obj));
                    break; 
                   
                }
            }
     
        }
        public void RemoveTo(TBLinhKien_C obj) //xoa 1 TBLinhKien_C
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
                foreach (TBLinhKien_C obj in this)
                {
                    if (obj.MaTBC.Equals(MaTB))
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
        public bool Contains(string MaTBC)
        {
            foreach (TBLinhKien_C obj in this)
                if ((obj.MaTBC == MaTBC) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaLK, Boolean Huy)
        {
            foreach (TBLinhKien_C  obj in this)
                if ((obj.MaLK == MaLK) && (obj.Huy == Huy))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaTBC)
        {
            foreach (TBLinhKien_C obj in DeletedList)
                if (obj.MaTBC == MaTBC)
                    return true;
            return false;
        }
        public void UpdatedTo(TBLinhKien_C _TBLinhKien_C)
        {

            _TBLinhKien_C.STT = this.Items[this.IndexOf(_TBLinhKien_C)].STT;
            this.Items[this.IndexOf(_TBLinhKien_C)] = _TBLinhKien_C;
        }
        //public void UpdatedTo(TBLinhKien_C_List _TBLinhKien_C_List)
        //{

        //    _TBLinhKien_C.STT = this.Items[this.IndexOf(_TBLinhKien_C)].STT;
        //    this.Items[this.IndexOf(_TBLinhKien_C)] = _TBLinhKien_C;
        //}
        public TBLinhKien_C GetTo(decimal STT) //
        {
            foreach (TBLinhKien_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static TBLinhKien_C_List NewTBLinhKien_C_List()
        {
            return new TBLinhKien_C_List();
        }

        internal static TBLinhKien_C_List GetTBLinhKien_C_List(SafeDataReader dr)
        {
            return new TBLinhKien_C_List(dr);
        }

        private TBLinhKien_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBLinhKien_C_List(SafeDataReader dr)
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

                this.Add(TBLinhKien_C.GetTBLinhkien_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public void Update(TBKiemKe_C  packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBLinhKien_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBLinhKien_C item in this)
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
