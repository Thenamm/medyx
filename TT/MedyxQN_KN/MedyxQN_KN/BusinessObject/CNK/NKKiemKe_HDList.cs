using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;
//using System.Windows.Forms;

namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKKiemKe_HDList : BusinessListBase<NKKiemKe_HDList, NKKiemKe_HD>
    {
        #region Business Methods

        public NKKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (NKKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                NKKiemKe_HD obj = NKKiemKe_HD.NewNKKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_HD NewTo()
            {
           
              NKKiemKe_HD obj = NKKiemKe_HD.NewNKKiemKe_HD();
              return obj;
               
        }
        public void NewTo(NKKiemKe_HD _NKKiemKe_HD)
        {
            if (!Contains(_NKKiemKe_HD.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKKiemKe_HD.STT = ++_count;
                    this.Add(_NKKiemKe_HD);
                }
                else
                {
                    _NKKiemKe_HD.STT = 1;
                    this.Add(_NKKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_HD AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKKiemKe_HD obj = NKKiemKe_HD.NewNKKiemKe_HD(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_HD AssignTo(NKKiemKe_HD _NKKiemKe_HD)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _NKKiemKe_HD.OrderNumber = ++_count;
                    _NKKiemKe_HD.STT = ++_count1;
                    _NKKiemKe_HD.MAKK = this.Items[0].MAKK;
                    this.Add(_NKKiemKe_HD);
                }
                else
                {
                    _NKKiemKe_HD.OrderNumber = 1;
                    _NKKiemKe_HD.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NKKiemKe_HD);
                }
            
            return _NKKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            NKKiemKe_HD item = NKKiemKe_HD.NewNKKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaVT)
        {
            try
            {
                foreach (NKKiemKe_HD obj in this)
                {
                    if (obj.MaVT.Equals(MaVT))
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
                //MessageBox.Show("Lỗi ở file NKKiemKe_HDList "+ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (NKKiemKe_HD obj in this)
        //        {
        //            if (obj.MaVT.Equals(this[_index].MaVT))
        //            {
        //                this.RemoveAt(_index);
        //                break;
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.Message);

        //    }


        //}
        public void RemoveTo(Decimal stt, string MaKK)
        {
            foreach (NKKiemKe_HD obj in this)
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
        public void RemoveTo(NKKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (NKKiemKe_HD obj in this)
                if (obj.MAKK == MaKK )
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (NKKiemKe_HD obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (NKKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(NKKiemKe_HD _NKKiemKe_HD)
        {

            _NKKiemKe_HD.STT = this.Items[this.IndexOf(_NKKiemKe_HD)].STT;
           this.Items[this.IndexOf(_NKKiemKe_HD)] = _NKKiemKe_HD;
        }
        public NKKiemKe_HD GetTo(decimal STT)
        {
            foreach (NKKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public NKKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (NKKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static NKKiemKe_HDList NewNKKiemKe_HDList()
        {
            return new NKKiemKe_HDList();
        }

        internal static NKKiemKe_HDList GetNKKiemKe_HDList(SafeDataReader dr)
        {
            return new NKKiemKe_HDList(dr);
        }

        private NKKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKKiemKe_HDList(SafeDataReader dr)
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
                this.Add(NKKiemKe_HD.GetNKKiemKe_HD(dr,i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NKKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKKiemKe_HD item in this)
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
