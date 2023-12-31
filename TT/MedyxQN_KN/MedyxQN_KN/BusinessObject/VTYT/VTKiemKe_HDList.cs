using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;
 //using System.Windows.Forms;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTKiemKe_HDList : BusinessListBase<VTKiemKe_HDList, VTKiemKe_HD>
    {
        #region Business Methods

        public VTKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (VTKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                VTKiemKe_HD obj = VTKiemKe_HD.NewVTKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_HD NewTo()
        {

            VTKiemKe_HD obj = VTKiemKe_HD.NewVTKiemKe_HD();
            return obj;

        }
        public void NewTo(VTKiemKe_HD _VTKiemKe_HD)
        {
            if (!Contains(_VTKiemKe_HD.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VTKiemKe_HD.STT = ++_count;
                    this.Add(_VTKiemKe_HD);
                }
                else
                {
                    _VTKiemKe_HD.STT = 1;
                    this.Add(_VTKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_HD AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTKiemKe_HD obj = VTKiemKe_HD.NewVTKiemKe_HD(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_HD AssignTo(VTKiemKe_HD _VTKiemKe_HD)//add mot hang PhieuNhap_C
        {

            if (this.Items.Count > 0)
            {
                int _count = 0;
                decimal _count1 = 0;
                _count = (int)this.Items.Count;
                _count1 = (int)this.Items.Count;
                //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                _VTKiemKe_HD.OrderNumber = ++_count;
                _VTKiemKe_HD.STT = ++_count1;
                _VTKiemKe_HD.MAKK = this.Items[0].MAKK;
                this.Add(_VTKiemKe_HD);
            }
            else
            {
                _VTKiemKe_HD.OrderNumber = 1;
                _VTKiemKe_HD.STT = 1;
                //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                this.Add(_VTKiemKe_HD);
            }

            return _VTKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            VTKiemKe_HD item = VTKiemKe_HD.NewVTKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaVT)
        {
            try
            {
                foreach (VTKiemKe_HD obj in this)
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
               //MessageBox.Show("Lỗi ở file VTKiemKe_HDList " + ex.Message);
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
            foreach (VTKiemKe_HD obj in this)
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
        public void RemoveTo(VTKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (VTKiemKe_HD obj in this)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VTKiemKe_HD obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (VTKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(VTKiemKe_HD _VTKiemKe_HD)
        {

            _VTKiemKe_HD.STT = this.Items[this.IndexOf(_VTKiemKe_HD)].STT;
            this.Items[this.IndexOf(_VTKiemKe_HD)] = _VTKiemKe_HD;
        }
        public VTKiemKe_HD GetTo(decimal STT)
        {
            foreach (VTKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        public VTKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (VTKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static VTKiemKe_HDList NewVTKiemKe_HDList()
        {
            return new VTKiemKe_HDList();
        }

        internal static VTKiemKe_HDList GetVTKiemKe_HDList(SafeDataReader dr)
        {
            return new VTKiemKe_HDList(dr);
        }

        private VTKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTKiemKe_HDList(SafeDataReader dr)
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
                this.Add(VTKiemKe_HD.GetVTKiemKe_HD(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTKiemKe_HD item in this)
            {
                if (item.IsNew == true )//&& item.MAKK == "")
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }




        #endregion
    }
}
