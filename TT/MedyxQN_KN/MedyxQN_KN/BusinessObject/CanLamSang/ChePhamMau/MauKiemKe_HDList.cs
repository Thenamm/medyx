using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;
 //using System.Windows.Forms;  

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauKiemKe_HDList : BusinessListBase<MauKiemKe_HDList, MauKiemKe_HD>
    {
        #region Business Methods

        public MauKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (MauKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                MauKiemKe_HD obj = MauKiemKe_HD.NewMauKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_HD NewTo()
            {
           
              MauKiemKe_HD obj = MauKiemKe_HD.NewMauKiemKe_HD();
              return obj;
               
        }
        public void NewTo(MauKiemKe_HD _MauKiemKe_HD)
        {
            if (!Contains(_MauKiemKe_HD.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauKiemKe_HD.STT = ++_count;
                    this.Add(_MauKiemKe_HD);
                }
                else
                {
                    _MauKiemKe_HD.STT = 1;
                    this.Add(_MauKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_HD AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauKiemKe_HD obj = MauKiemKe_HD.NewMauKiemKe_HD(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_HD AssignTo(MauKiemKe_HD _MauKiemKe_HD)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _MauKiemKe_HD.OrderNumber = ++_count;
                    _MauKiemKe_HD.STT = ++_count1;
                    _MauKiemKe_HD.MAKK = this.Items[0].MAKK;
                    this.Add(_MauKiemKe_HD);
                }
                else
                {
                    _MauKiemKe_HD.OrderNumber = 1;
                    _MauKiemKe_HD.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_MauKiemKe_HD);
                }
            
            return _MauKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            MauKiemKe_HD item = MauKiemKe_HD.NewMauKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaCPMau)
        {
            try
            {
                foreach (MauKiemKe_HD obj in this)
                {
                    if (obj.MaCPMau.Equals(MaCPMau))
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
               //MessageBox.Show("Lỗi ở file MauKiemKe_HDList "+ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (MauKiemKe_HD obj in this)
        //        {
        //            if (obj.MaCPMau.Equals(this[_index].MaCPMau))
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
            foreach (MauKiemKe_HD obj in this)
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
        public void RemoveTo(MauKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (MauKiemKe_HD obj in this)
                if (obj.MAKK == MaKK )
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau, Boolean Huy)
        {
            foreach (MauKiemKe_HD obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (MauKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(MauKiemKe_HD _MauKiemKe_HD)
        {

            _MauKiemKe_HD.STT = this.Items[this.IndexOf(_MauKiemKe_HD)].STT;
           this.Items[this.IndexOf(_MauKiemKe_HD)] = _MauKiemKe_HD;
        }
        public MauKiemKe_HD GetTo(decimal STT)
        {
            foreach (MauKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public MauKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (MauKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static MauKiemKe_HDList NewMauKiemKe_HDList()
        {
            return new MauKiemKe_HDList();
        }

        internal static MauKiemKe_HDList GetMauKiemKe_HDList(SafeDataReader dr)
        {
            return new MauKiemKe_HDList(dr);
        }

        private MauKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauKiemKe_HDList(SafeDataReader dr)
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
                this.Add(MauKiemKe_HD.GetMauKiemKe_HD(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(MauKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauKiemKe_HD item in this)
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
