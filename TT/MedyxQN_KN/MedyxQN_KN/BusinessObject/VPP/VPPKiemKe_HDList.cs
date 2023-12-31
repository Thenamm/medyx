using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;
 //using System.Windows.Forms;

namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPKiemKe_HDList : BusinessListBase<VPPKiemKe_HDList, VPPKiemKe_HD>
    {
        #region Business Methods
        public VPPKiemKe_HD this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (VPPKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                VPPKiemKe_HD obj = VPPKiemKe_HD.NewVPPKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_HD NewTo()
            {
           
              VPPKiemKe_HD obj = VPPKiemKe_HD.NewVPPKiemKe_HD();
              return obj;
               
        }
        public void NewTo(VPPKiemKe_HD _VPPKiemKe_HD)
        {
            if (!Contains(_VPPKiemKe_HD.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VPPKiemKe_HD.STT = ++_count;
                    this.Add(_VPPKiemKe_HD);
                }
                else
                {
                    _VPPKiemKe_HD.STT = 1;
                    this.Add(_VPPKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_HD AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPKiemKe_HD obj = VPPKiemKe_HD.NewVPPKiemKe_HD(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_HD AssignTo(VPPKiemKe_HD _VPPKiemKe_HD)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VPPKiemKe_HD.OrderNumber = ++_count;
                    _VPPKiemKe_HD.STT = ++_count1;
                    _VPPKiemKe_HD.MAKK = this.Items[0].MAKK;
                    this.Add(_VPPKiemKe_HD);
                }
                else
                {
                    _VPPKiemKe_HD.OrderNumber = 1;
                    _VPPKiemKe_HD.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VPPKiemKe_HD);
                }
            
            return _VPPKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            VPPKiemKe_HD item = VPPKiemKe_HD.NewVPPKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaVT)
        {
            try
            {
                foreach (VPPKiemKe_HD obj in this)
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
               //MessageBox.Show("Lỗi ở file VTKiemKe_HDList "+ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (VTKiemKe_HD obj in this)
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
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);

        //    }


        //}
        public void RemoveTo(Decimal stt, string MaKK)
        {
            foreach (VPPKiemKe_HD obj in this)
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
        public void RemoveTo(VPPKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (VPPKiemKe_HD obj in this)
                if (obj.MAKK == MaKK )
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VPPKiemKe_HD obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (VPPKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(VPPKiemKe_HD _VPPKiemKe_HD)
        {

            _VPPKiemKe_HD.STT = this.Items[this.IndexOf(_VPPKiemKe_HD)].STT;
           this.Items[this.IndexOf(_VPPKiemKe_HD)] = _VPPKiemKe_HD;
        }
        public VPPKiemKe_HD GetTo(decimal STT)
        {
            foreach (VPPKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public VPPKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (VPPKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static VPPKiemKe_HDList NewVPPKiemKe_HDList()
        {
            return new VPPKiemKe_HDList();
        }

        internal static VPPKiemKe_HDList GetVPPKiemKe_HDList(SafeDataReader dr)
        {
            return new VPPKiemKe_HDList(dr);
        }

        private VPPKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPKiemKe_HDList(SafeDataReader dr)
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
                this.Add(VPPKiemKe_HD.GetVPPKiemKe_HD(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VPPKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (VPPKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VPPKiemKe_HD item in this)
            {
                if ((item.IsNew) )   //MAKK ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}
