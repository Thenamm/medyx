using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
//using System.Windows.Forms;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_C_List : BusinessListBase<KhamBenh_C_List, KhamBenh_C>
    {

        #region Business Methods
        #region State Fields
        public decimal _TongTT = 0;
        public decimal _TongTTCTT = 0;
        public decimal _TongBH = 0;
        public decimal _TongBHCTT = 0;
        public int _loai = 0;
        public string _noitt = "";

        #endregion
        public KhamBenh_C this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_C obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }
        public KhamBenh_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaDV)
        {
            if (!Contains(MaDV) == true)
            {
                KhamBenh_C obj = KhamBenh_C.NewKhamBenh_C(MaDV);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public static KhamBenh_C_List GetAllKhamBenh_C(string masokham, string makhoa, byte loai, DateTime ngayyc, byte datt, string dk)
        {
            return DataPortal.Fetch<KhamBenh_C_List>(new CriteriaOther(masokham, makhoa, loai, ngayyc, datt, dk));
        }
        public KhamBenh_C NewTo()
        {

            KhamBenh_C obj = KhamBenh_C.NewKhamBenh_C();
            return obj;

        }
        public void NewTo(KhamBenh_C _KhamBenh_C)
        {
            //if (!Contains(_KhamBenh_C.MaDV))
            //{
            //    if (this.Items.Count > 0)
            //    {
            //        byte _count=0;
            //        _count = (byte)this.Items.Count;
            //        _KhamBenh_C.STT = ++_count;
            if (this.Items.Count == 0)
                _KhamBenh_C.STT = 1;
            else
                _KhamBenh_C.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_C);
            //    }
            //    else
            //    {
            //        _KhamBenh_C.STT = 1;
            //        this.Add(_KhamBenh_C);
            //    }
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_C AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_C obj = KhamBenh_C.NewKhamBenh_C(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_C AssignTo(KhamBenh_C _KhamBenh_c, KhamBenh _KhamBenh)
        {
            //if (Contains(_KhamBenh_c.MaDV) )


            // if (MessageBox.Show (  HTC.ShareVariables.VAR_ITEMEXIST,"Thong bao",MessageBoxButtons.OKCancel)== DialogResult.Cancel   ) 
            //       return null;

            if (this.Items.Count == 0)
                _KhamBenh_c.STT = 1;
            else
                _KhamBenh_c.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_c);
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_c.BHTinhTien != 0) && (_KhamBenh_c.TinhTien== 0))
            // {
            //     __TongBHCTT = decimal.Parse(_KhamBenh_c.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra))
            //     + decimal.Parse(_KhamBenh_c.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra));
            // }
            // if ((_KhamBenh_c.BHTinhTien == 0) || (_KhamBenh_c.TinhTien!= 0))
            // {
            //     __TongTTCTT = decimal.Parse(_KhamBenh_c.DongiaTT) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra));

            // }
            // _TongBHCTT = _TongBHCTT + __TongBHCTT;
            // _TongTTCTT = _TongTTCTT + __TongTTCTT;
            //_KhamBenh._TongTienTTCTT = _KhamBenh._TongTienTTCTT + __TongTTCTT ;
            //_KhamBenh._TongTienBHCTT  =  _KhamBenh._TongTienBHCTT + __TongBHCTT ;
            //_KhamBenh._TongTienCTT =_KhamBenh._TongTienTTCTT +_KhamBenh._TongTienBHCTT;
            //if (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT <= _KhamBenh.sotienbhtra)
            //    _KhamBenh._TongThanhToan = _KhamBenh._TongTienTTCTT;
            //else
            //    _KhamBenh._TongThanhToan = (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT) * (100 - _KhamBenh.bhtra) / decimal.Parse("100") + _KhamBenh._TongTienTTCTT;
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();
            return _KhamBenh_c;
        }
        protected override object AddNewCore()
        {
            KhamBenh_C item = KhamBenh_C.NewKhamBenh_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
           
            return item;
        }

        public void RemoveTo(KhamBenh_C _KhamBenh_c, KhamBenh _KhamBenh)
        {
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_c.BHTinhTien != 0) && (_KhamBenh_c.TinhTien == 0))
            //{
            //    __TongBHCTT = decimal.Parse(_KhamBenh_c.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra))
            //    + decimal.Parse(_KhamBenh_c.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra));
            //}
            //if ((_KhamBenh_c.BHTinhTien == 0) || (_KhamBenh_c.TinhTien != 0))
            //{
            //    __TongTTCTT = decimal.Parse(_KhamBenh_c.DongiaTT) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - -decimal.Parse(_KhamBenh_c.SLTra));

            //}
            //_TongBHCTT = _TongBHCTT - __TongBHCTT;
            //_TongTTCTT = _TongTTCTT - __TongTTCTT;
            //_KhamBenh._TongTienTTCTT = _KhamBenh._TongTienTTCTT - __TongTTCTT;
            //_KhamBenh._TongTienBHCTT = _KhamBenh._TongTienBHCTT - __TongBHCTT;
            //_KhamBenh._TongTienCTT = _KhamBenh._TongTienTTCTT + _KhamBenh._TongTienBHCTT;
            //if (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT <= _KhamBenh.sotienbhtra)
            //    _KhamBenh._TongThanhToan = _KhamBenh._TongTienTTCTT;
            //else
            //    _KhamBenh._TongThanhToan = (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT) * (100 - _KhamBenh.bhtra) / decimal.Parse("100") + _KhamBenh._TongTienTTCTT;
            if ((_KhamBenh_c.DaTTTT != 0  && ( _KhamBenh.loai == 9 || _KhamBenh.loai == 7)) ||  (_KhamBenh_c.DaTTBH!=0 && (_KhamBenh.loai == 2 )))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_c.SoSoHD, _KhamBenh_c.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                  
                    }


            }
            if (_KhamBenh_c.IsNew == true)
                this.Items.Remove(_KhamBenh_c);
            else
                Remove(_KhamBenh_c);
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();
        }

        public bool Contains(string MaDV)
        {
            foreach (KhamBenh_C obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public KhamBenh_C Containsfind(int stt)
        {
            foreach (KhamBenh_C obj in this)
                if (obj.STT == stt)
                    return obj;
            return null;

        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_C obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public bool ContainsDeleted(string sohd, string sosohd)
        {
            foreach (KhamBenh_C obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    obj.DaTra = true;
                    obj.SLTra = obj.slmua;
                    obj.thanhtien = "0";

                }
            return false;
        }
        public bool ContainsDeleted(string sohd, string sosohd, KhamBenh_HoaDon kb_hd)
        {
            foreach (KhamBenh_C obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    obj.SoHDTra = obj.SoHD;
                    obj.SoSoHDTra = obj.SoSoHD;
                    obj.SoSoHD = sosohd;
                    obj.SoHD = sohd;
                    if ((obj.BHTinhtien == false) || (obj.Tinhtien == true))
                        kb_hd.TongThu = kb_hd.TongThu + decimal.Parse(obj.DongiaTT);
                    if ((obj.BHTinhtien == true) || (obj.Tinhtien == false))
                        kb_hd.TongThu = kb_hd.TongThu + decimal.Parse(obj.GiaChenhLech);
                    if (kb_hd.LydoThu.CompareTo(obj.tentat + "(" + obj.tenkhoa + ")") == 0)

                        kb_hd.LydoThu = kb_hd.LydoThu + kb_hd.LydoThu.Substring(kb_hd.LydoThu.CompareTo(obj.tentat + "(" + obj.tenkhoa + ")"), obj.tentat.Length + "(".Length + obj.tenkhoa.Length + ")".Length);

                }
            return false;
        }
        public void UpdatedTo(KhamBenh_C _KhamBenh_c, KhamBenh _KhamBenh)
        {
            KhamBenh_C _kb = this.Items[this.IndexOf(_KhamBenh_c)];
            //if (decimal.Parse(_KhamBenh_c.SLTra) > 0)
            //    _KhamBenh_c.DaTra  = true;
            //else
            //    _KhamBenh_c.DaTra = false;
            //if (_KhamBenh_c.DaTT == 0)
            //{
            //    Decimal __TongBHCTT = 0;
            //    Decimal __TongTTCTT = 0;
            //    if ((_KhamBenh_c.BHTinhTien != 0) && (_KhamBenh_c.TinhTien == 0))
            //    {
            //        __TongBHCTT = (decimal.Parse(_KhamBenh_c.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - decimal.Parse(_KhamBenh_c.SLTra))
            //        + decimal.Parse(_KhamBenh_c.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_c.CK)) / 100 * (decimal.Parse(_KhamBenh_c.slmua) - decimal.Parse(_KhamBenh_c.SLTra)))
            //        - (decimal.Parse(_kb.DonGiaBH) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra))
            //        + decimal.Parse(_kb.GiaChenhLech) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra)));
            //    }
            //    if ((_KhamBenh_c.BHTinhTien == 0) || (_KhamBenh_c.TinhTien != 0))
            //    {
            //        __TongTTCTT = (decimal.Parse(_kb.DongiaTT) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra)))
            //            - (decimal.Parse(_kb.DongiaTT) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra)));

            //    }
            //    _TongBHCTT = _TongBHCTT + __TongBHCTT;
            //    _TongTTCTT = _TongTTCTT + __TongTTCTT;
            //    _KhamBenh._TongTienTTCTT = _KhamBenh._TongTienTTCTT + __TongTTCTT;
            //    _KhamBenh._TongTienBHCTT = _KhamBenh._TongTienBHCTT + __TongBHCTT;
            //    _KhamBenh._TongTienCTT = _KhamBenh._TongTienTTCTT + _KhamBenh._TongTienBHCTT;
            //}
            //    if (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT <= _KhamBenh.sotienbhtra)
            //        _KhamBenh._TongThanhToan = _KhamBenh._TongTienTTCTT;
            //    else
            //        _KhamBenh._TongThanhToan = (_KhamBenh._TongTienBHCTT + _KhamBenh._TongTienBHDTT) * (100 - _KhamBenh.bhtra) / decimal.Parse("100") + _KhamBenh._TongTienTTCTT;

            _KhamBenh_c.STT = _kb.STT;

            this.Items[this.IndexOf(_KhamBenh_c)] = _KhamBenh_c;
            if ((decimal.Parse(_KhamBenh_c.SLTra) > 0) && (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 7))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_c.SoSoHD, _KhamBenh_c.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                        //    int i = 0;
                        //    KhamBenh_C kb_c;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_C_List.Count - 1; i++)
                        //    {
                        //        kb_c = _KhamBenh.KhamBenh_C_List[i];
                        //        if ((kb_c.SLTra == "") || (_kbhd.SoHD == kb_c.SoHD) || (_kbhd.SoSoHD == kb_c.SoSoHD) || (kb_c.DaTTBH != 0) || (_KhamBenh.loai == 2))
                        //            kb_c.DaTTBH = 0;
                        //        else if ((kb_c.SLTra == "") || (_kbhd.SoHD == kb_c.SoHD) || (_kbhd.SoSoHD == kb_c.SoSoHD) || (kb_c.DaTTTT != 0) || (_KhamBenh.loai == 9))
                        //            kb_c.DaTTTT = 0;
                        //    }
                        //    kb_c = null;
                        //    KhamBenh_ThuocSD kb_t;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_ThuocSDList.Count; i++)
                        //    {
                        //        kb_t = _KhamBenh.KhamBenh_ThuocSDList[i];
                        //        if ((kb_t.SLTra == "") || (_kbhd.SoHD == kb_t.SoHD) || (_kbhd.SoSoHD == kb_t.SoSoHD) || (kb_t.DaTTBH != 0) || (_KhamBenh.loai == 2))
                        //            kb_t.DaTTBH = 0;
                        //        else if ((kb_t.SLTra == "") || (_kbhd.SoHD == kb_t.SoHD) || (_kbhd.SoSoHD == kb_t.SoSoHD) || (kb_t.DaTTTT != 0) || (_KhamBenh.loai == 9))
                        //            kb_t.DaTTTT = 0;
                        //    }
                        //    kb_t = null;

                        //    KhamBenh_VTTH kb_vt;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_VTTHList.Count; i++)
                        //    {
                        //        kb_vt = _KhamBenh.KhamBenh_VTTHList[i];
                        //        if ((kb_vt.SLTra == "") || (_kbhd.SoHD == kb_vt.SoHD) || (_kbhd.SoSoHD == kb_vt.SoSoHD) || (kb_vt.DaTTBH != 0) || (_KhamBenh.loai == 2))
                        //            kb_vt.DaTTBH = 0;
                        //        else if ((kb_vt.SLTra == "") || (_kbhd.SoHD == kb_vt.SoHD) || (_kbhd.SoSoHD == kb_vt.SoSoHD) || (kb_vt.DaTTTT != 0) || (_KhamBenh.loai == 9))
                        //            kb_vt.DaTTTT = 0;
                        //    }
                        //    kb_vt = null;
                        //    KhamBenh_Mau kb_m;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_MauList.Count; i++)
                        //    {
                        //        kb_m = _KhamBenh.KhamBenh_MauList[i];
                        //        if ((kb_m.SLTra == "") || (_kbhd.SoHD == kb_m.SoHD) || (_kbhd.SoSoHD == kb_m.SoSoHD) || (kb_m.DaTTBH != 0) || (_KhamBenh.loai == 2))
                        //            kb_m.DaTTBH = 0;
                        //        else if ((kb_m.SLTra == "") || (_kbhd.SoHD == kb_m.SoHD) || (_kbhd.SoSoHD == kb_m.SoSoHD) || (kb_m.DaTTTT != 0) || (_KhamBenh.loai == 9))
                        //            kb_t.DaTTTT = 0;
                        //    }
                        //    kb_m = null;
                    }


            }
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();

        }
        public void UpdatedTo(KhamBenh_C _KhamBenh_c)
        {
            KhamBenh_C _kb = this.Items[this.IndexOf(_KhamBenh_c)];
            _KhamBenh_c.STT = _kb.STT;
            this.Items[this.IndexOf(_KhamBenh_c)] = _KhamBenh_c;

        }
        public KhamBenh_C GetTo(int STT)
        {
            foreach (KhamBenh_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_C_List NewKhamBenh_C_List()
        {
            return new KhamBenh_C_List();
        }

        internal static KhamBenh_C_List GetKhamBenh_C_List(SafeDataReader dr)
        {
            return new KhamBenh_C_List(dr);
        }
        internal static KhamBenh_C_List GetKhamBenh_C_List(SafeDataReader dr, byte loai)
        {
            return new KhamBenh_C_List(dr, loai);
        }
        internal static KhamBenh_C_List GetKhamBenh_C_List(SafeDataReader dr, byte loai, string noitt)
        {
            return new KhamBenh_C_List(dr, loai, noitt);
        }
        private KhamBenh_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_C_List(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }
        private KhamBenh_C_List(SafeDataReader dr, byte loai)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr, loai);
        }
        private KhamBenh_C_List(SafeDataReader dr, byte loai, string noitt)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr, loai, noitt);
        }
        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            _TongBH = 0;
            _TongBHCTT = 0;
            _TongTT = 0;
            _TongTTCTT = 0;
            while (dr.Read())
            {
                this.Add(KhamBenh_C.GetKhamBenh_C(dr));

                //if ((dr.GetByte("DATTTT") != 0) && (_loai == 9))
                //{
                //    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                //    {
                //        _TongTT = _TongTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
                //    }
                //    else if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                //        _TongTT = _TongTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));

                //}
                //else if ((dr.GetByte("DATTbh") != 0) && (_loai == 2))
                //{
                //    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                //    {
                //        _TongBH = _TongBH + dr.GetDecimal("DongiaBH") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
                //    }
                //}
                //else if ((dr.GetByte("DATTTT") == 0) && (_loai==9))
                //{
                //    if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                //        _TongTTCTT = _TongTTCTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
                //    else
                //        _TongTTCTT = _TongTTCTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));

                //}
                //else if ((dr.GetByte("DATTbh") == 0) && (_loai == 2))
                //{
                //    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                //        _TongBHCTT = _TongBHCTT + dr.GetDecimal("DongiaBH") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));

                //}
            }
            RaiseListChangedEvents = true;
            // dr.Close();
            dr = null;

        }
        private void Fetch(SafeDataReader dr, byte loai, string noitt)
        {
            RaiseListChangedEvents = false;
            _TongBH = 0;
            _TongBHCTT = 0;
            _TongTT = 0;
            _TongTTCTT = 0;
            _noitt = noitt;
            while (dr.Read())
            {

                if ((dr.GetByte("DATTTT") != 0) && (_loai == 7))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongTT = _TongTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                    else if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                        _TongTT = _TongTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;

                }

                else if ((dr.GetByte("DATTTT") == 0) && (_loai == 7))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongTTCTT = _TongTTCTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                    else if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                        _TongTTCTT = _TongTTCTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                }

                this.Add(KhamBenh_C.GetKhamBenh_C(dr, loai));
            }
            // dr.Close();
            dr = null;
            RaiseListChangedEvents = true;

        }
        private void Fetch(SafeDataReader dr, byte loai)
        {
            RaiseListChangedEvents = false;
            _TongBH = 0;
            _TongBHCTT = 0;
            _TongTT = 0;
            _TongTTCTT = 0;
            while (dr.Read())
            {

                if ((dr.GetByte("DATTTT") != 0) && (_loai == 9))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongTT = _TongTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                    else if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                        _TongTT = _TongTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;

                }
                else if ((dr.GetByte("DATTbh") != 0) && (_loai == 2))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongBH = _TongBH + dr.GetDecimal("DongiaBH") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                }
                else if ((dr.GetByte("DATTTT") == 0) && (_loai == 9))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongTTCTT = _TongTTCTT + dr.GetDecimal("giachenhlech") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                    else if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                        _TongTTCTT = _TongTTCTT + dr.GetDecimal("DongiaTT") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                }
                else if ((dr.GetByte("DATTbh") == 0) && (_loai == 2))
                {
                    if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                    {
                        _TongBHCTT = _TongBHCTT + dr.GetDecimal("DongiaBH") * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra")) * (100 - dr.GetDecimal("ck")) / 100;
                    }
                }
                this.Add(KhamBenh_C.GetKhamBenh_C(dr, loai));
            }
            // dr.Close();
            dr = null;
            RaiseListChangedEvents = true;

        }
        internal void Update(KhamBenh packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_C item in DeletedList)
                if (!(packet.loai == 2 || packet.loai == 9))
                    item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_C item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true;
        }
        private class CriteriaOther
        {
            private string _masokham;
            public string masokham
            {
                get
                {
                    return _masokham;
                }
            }
            private DateTime _NgayYC;
            public DateTime NgayYC
            {
                get
                {
                    return _NgayYC;
                }
            }
            private byte _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private byte _datt;
            public byte datt
            {
                get
                {
                    return _datt;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private string _makhoa;
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            public CriteriaOther(string masokham, string makhoa, byte loai, DateTime ngayyc, byte datt, string dk)
            {
                _NgayYC = ngayyc;
                _masokham = masokham;
                _makhoa = makhoa;
                _Loai = loai;
                _DK = dk;
                _datt = datt;

            }
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_C(HTC.ShareVariables.pub_bQadmin, criteria.masokham, criteria.makhoa, criteria.Loai, criteria.NgayYC, criteria.datt, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_C.GetKhamBenh_C(dr));
                    i++;
                }
                //KhamBenh_C _KhamBenh_C = KhamBenh_C.NewKhamBenh_C();
                //_KhamBenh_C.MaSoKham = "";
                //this.Add(_KhamBenh_C);
            }
            this.RaiseListChangedEvents = true;
        }
        #endregion
    }
}