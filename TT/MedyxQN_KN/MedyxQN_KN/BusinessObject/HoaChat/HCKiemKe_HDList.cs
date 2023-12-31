using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;
 //using System.Windows.Forms;  

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCKiemKe_HDList : BusinessListBase<HCKiemKe_HDList, HCKiemKe_HD>
    {
        #region Business Methods
        public HCKiemKe_HD this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (HCKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                HCKiemKe_HD obj = HCKiemKe_HD.NewHCKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_HD NewTo()
            {
           
              HCKiemKe_HD obj = HCKiemKe_HD.NewHCKiemKe_HD();
              return obj;
               
        }
        public void NewTo(HCKiemKe_HD _HCKiemKe_HD)
        {
            if (!Contains(_HCKiemKe_HD.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCKiemKe_HD.STT = ++_count;
                    this.Add(_HCKiemKe_HD);
                }
                else
                {
                    _HCKiemKe_HD.STT = 1;
                    this.Add(_HCKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_HD AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCKiemKe_HD obj = HCKiemKe_HD.NewHCKiemKe_HD(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_HD AssignTo(HCKiemKe_HD _HCKiemKe_HD)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _HCKiemKe_HD.OrderNumber = ++_count;
                    _HCKiemKe_HD.STT = ++_count1;
                    _HCKiemKe_HD.MAKK = this.Items[0].MAKK;
                    this.Add(_HCKiemKe_HD);
                }
                else
                {
                    _HCKiemKe_HD.OrderNumber = 1;
                    _HCKiemKe_HD.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HCKiemKe_HD);
                }
            
            return _HCKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            HCKiemKe_HD item = HCKiemKe_HD.NewHCKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaHC)
        {
            try
            {
                foreach (HCKiemKe_HD obj in this)
                {
                    if (obj.MaHC.Equals(MaHC))
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
               //MessageBox.Show("Lỗi ở file HCKiemKe_HDList "+ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (HCKiemKe_HD obj in this)
        //        {
        //            if (obj.MaHC.Equals(this[_index].MaHC))
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
            foreach (HCKiemKe_HD obj in this)
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
        public void RemoveTo(HCKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (HCKiemKe_HD obj in this)
                if (obj.MAKK == MaKK )
                    return true;
            return false;
        }
        public bool Containss(string MaHC, Boolean Huy)
        {
            foreach (HCKiemKe_HD obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (HCKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(HCKiemKe_HD _HCKiemKe_HD)
        {

            _HCKiemKe_HD.STT = this.Items[this.IndexOf(_HCKiemKe_HD)].STT;
           this.Items[this.IndexOf(_HCKiemKe_HD)] = _HCKiemKe_HD;
        }
        public HCKiemKe_HD GetTo(decimal STT)
        {
            foreach (HCKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public HCKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (HCKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static HCKiemKe_HDList NewHCKiemKe_HDList()
        {
            return new HCKiemKe_HDList();
        }

        internal static HCKiemKe_HDList GetHCKiemKe_HDList(SafeDataReader dr)
        {
            return new HCKiemKe_HDList(dr);
        }

        private HCKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCKiemKe_HDList(SafeDataReader dr)
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
                this.Add(HCKiemKe_HD.GetHCKiemKe_HD(dr,i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HCKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCKiemKe_HD item in this)
            {
                if ((item.IsNew)) // && item.MaKK == "")   //MAKK ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}
