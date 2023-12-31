using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;
 using System.Windows.Forms;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTKiemKe_HDList : BusinessListBase<TBVTKiemKe_HDList, TBVTKiemKe_HD>
    {
        #region Business Methods

        public TBVTKiemKe_HD this[string MaKK]
        {
            get
            {
                foreach (TBVTKiemKe_HD obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                TBVTKiemKe_HD obj = TBVTKiemKe_HD.NewTBVTKiemKe_HD(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_HD NewTo()
        {

            TBVTKiemKe_HD obj = TBVTKiemKe_HD.NewTBVTKiemKe_HD();
            return obj;

        }
        public void NewTo(TBVTKiemKe_HD _TBVTKiemKe_HD)
        {
            if (!Contains(_TBVTKiemKe_HD.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _TBVTKiemKe_HD.STT = ++_count;
                    this.Add(_TBVTKiemKe_HD);
                }
                else
                {
                    _TBVTKiemKe_HD.STT = 1;
                    this.Add(_TBVTKiemKe_HD);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_HD AssignTo(DMTBVTYT _DMTBVTYT)
        {
            if (!Contains(_DMTBVTYT.MaVT))
            {
                TBVTKiemKe_HD obj = TBVTKiemKe_HD.NewTBVTKiemKe_HD(_DMTBVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_HD AssignTo(TBVTKiemKe_HD _TBVTKiemKe_HD)//add mot hang PhieuNhap_C
        {

            if (this.Items.Count > 0)
            {
                int _count = 0;
                decimal _count1 = 0;
                _count = (int)this.Items.Count;
                _count1 = (int)this.Items.Count;
                //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                _TBVTKiemKe_HD.OrderNumber = ++_count;
                _TBVTKiemKe_HD.STT = ++_count1;
                _TBVTKiemKe_HD.MAKK = this.Items[0].MAKK;
                this.Add(_TBVTKiemKe_HD);
            }
            else
            {
                _TBVTKiemKe_HD.OrderNumber = 1;
                _TBVTKiemKe_HD.STT = 1;
                //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                this.Add(_TBVTKiemKe_HD);
            }

            return _TBVTKiemKe_HD;
        }

        protected override object AddNewCore()
        {
            TBVTKiemKe_HD item = TBVTKiemKe_HD.NewTBVTKiemKe_HD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaVT)
        {
            try
            {
                foreach (TBVTKiemKe_HD obj in this)
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
               //MessageBox.Show("Lỗi ở file TBVTKiemKe_HDList " + ex.Message);
                //MsgBox("Thuốc này chưa được lưu vào CSDL  ", MsgBoxStyle.Critical, "Thong Bao");

            }


        }
        //public void RemoveTo(Int32 _index)
        //{
        //    try
        //    {
        //        foreach (TBVTKiemKe_HD obj in this)
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
            foreach (TBVTKiemKe_HD obj in this)
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
        public void RemoveTo(TBVTKiemKe_HD obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (TBVTKiemKe_HD obj in this)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (TBVTKiemKe_HD obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy = Huy))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaKK)
        {
            foreach (TBVTKiemKe_HD obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(TBVTKiemKe_HD _TBVTKiemKe_HD)
        {

            _TBVTKiemKe_HD.STT = this.Items[this.IndexOf(_TBVTKiemKe_HD)].STT;
            this.Items[this.IndexOf(_TBVTKiemKe_HD)] = _TBVTKiemKe_HD;
        }
        public TBVTKiemKe_HD GetTo(decimal STT)
        {
            foreach (TBVTKiemKe_HD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        public TBVTKiemKe_HD GetTo(decimal STT, String MaKK)
        {
            foreach (TBVTKiemKe_HD obj in this)
                if ((obj.STT == STT) && (obj.MAKK == MaKK))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static TBVTKiemKe_HDList NewTBVTKiemKe_HDList()
        {
            return new TBVTKiemKe_HDList();
        }

        internal static TBVTKiemKe_HDList GetTBVTKiemKe_HDList(SafeDataReader dr)
        {
            return new TBVTKiemKe_HDList(dr);
        }

        private TBVTKiemKe_HDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBVTKiemKe_HDList(SafeDataReader dr)
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
                this.Add(TBVTKiemKe_HD.GetTBVTKiemKe_HD(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(TBVTKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (TBVTKiemKe_HD item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (TBVTKiemKe_HD item in this)
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
