using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;
 //using System.Windows.Forms;  

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class KiemKe_HDList : BusinessListBase<KiemKe_HDList, KiemKe_HD>
    {
        #region Business Methods
        public KiemKe_HD this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public KiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (KiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                KiemKe_HD obj = KiemKe_HD.NewKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_HD NewTo()
            {
           
              KiemKe_HD obj = KiemKe_HD.NewKiemKe_HD();
              return obj;
               
        }
        public void NewTo(KiemKe_HD _KiemKe_HD)
        {
            if (!Contains(_KiemKe_HD.MaThuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _KiemKe_HD.STT = ++_count;
                    this.Add(_KiemKe_HD);
                }
                else
                {
                    _KiemKe_HD.STT = 1;
                    this.Add(_KiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_HD AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                KiemKe_HD obj = KiemKe_HD.NewKiemKe_HD(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_HD AssignTo(KiemKe_HD _KiemKe_HD)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _KiemKe_HD.OrderNumber = ++_count;
                    _KiemKe_HD.STT = ++_count1;
                    _KiemKe_HD.MAKK = this.Items[0].MAKK;
                    this.Add(_KiemKe_HD);
                }
                else
                {
                    _KiemKe_HD.OrderNumber = 1;
                    _KiemKe_HD.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_KiemKe_HD);
                }
            
            return _KiemKe_HD;
        }

        protected override object AddNewCore()
        {
            KiemKe_HD item = KiemKe_HD.NewKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaThuoc)
        {
            try
            {
                foreach (KiemKe_HD obj in this)
                {
                    if (obj.MaThuoc.Equals(MaThuoc))
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
               //MessageBox.Show("Lỗi ở file KiemKe_HDList "+ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (KiemKe_HD obj in this)
        //        {
        //            if (obj.MaThuoc.Equals(this[_index].MaThuoc))
        //            {
        //                this.RemoveAt(_index);
        //                break;
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);

        //    }


        //}
        public void RemoveTo(Decimal stt, string MaKK)
        {
            foreach (KiemKe_HD obj in this)
            {
                if (obj.MAKK.Equals(MaKK) && obj.STT == stt)
                {
                   //this.Items.Remove(obj);
                    Remove(obj);
                    break;
                }
            }
        }
        
        //public void Remove(string madv, int stt)
        //{
        //    foreach (DMDichVu_VT item in this)
        //    {
        //        if ((item.MaDV == madv) && (item.STT == stt))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public void RemoveTo(KiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (KiemKe_HD obj in this)
                if (obj.MAKK == MaKK )
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            foreach (KiemKe_HD obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (KiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(KiemKe_HD _KiemKe_HD)
        {

            _KiemKe_HD.STT = this.Items[this.IndexOf(_KiemKe_HD)].STT;
           this.Items[this.IndexOf(_KiemKe_HD)] = _KiemKe_HD;
        }
        public KiemKe_HD GetTo(decimal STT)
        {
            foreach (KiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public KiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (KiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KiemKe_HDList NewKiemKe_HDList()
        {
            return new KiemKe_HDList();
        }

        internal static KiemKe_HDList GetKiemKe_HDList(SafeDataReader dr)
        {
            return new KiemKe_HDList(dr);
        }

        private KiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KiemKe_HDList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                this.Add(KiemKe_HD.GetKiemKe_HD(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(KiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (KiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (KiemKe_HD item in this)
            {
                if ((item.IsNew) )
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(KiemKeDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (KiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (KiemKe_HD item in this)
            {
                if ((item.IsNew== true)) // && item.MaKK
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

       

        #endregion
    }
}
