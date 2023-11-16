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
    public class KhamBenh_HoaChatList : BusinessListBase<KhamBenh_HoaChatList, KhamBenh_HoaChat>
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
        public KhamBenh_HoaChat this[string MaHC]
        {
            get
            {
                foreach (KhamBenh_HoaChat obj in this)
                    if (obj.MaHC.Equals(MaHC))
                        return obj;
                return null;
            }
        }
        public KhamBenh_HoaChat this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaHC)
        {
            if (!Contains(MaHC) == true)
            {
                KhamBenh_HoaChat obj = KhamBenh_HoaChat.NewKhamBenh_HoaChat(MaHC);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_HoaChat NewTo()
        {

            KhamBenh_HoaChat obj = KhamBenh_HoaChat.NewKhamBenh_HoaChat();
            return obj;

        }
        public void NewTo(KhamBenh_HoaChat _KhamBenh_HoaChat)
        {
            //if (!Contains(_KhamBenh_HoaChat.MaHC))
            //{
            //    if (this.Items.Count > 0)
            //    {
            //        byte _count=0;
            //        _count = (byte)this.Items.Count;
            //        _KhamBenh_HoaChat.STT = ++_count;
            if (this.Items.Count == 0)
                _KhamBenh_HoaChat.STT = 1;
            else
                _KhamBenh_HoaChat.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_HoaChat);
            //    }
            //    else
            //    {
            //        _KhamBenh_HoaChat.STT = 1;
            //        this.Add(_KhamBenh_HoaChat);
            //    }
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_HoaChat AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                KhamBenh_HoaChat obj = KhamBenh_HoaChat.NewKhamBenh_HoaChat(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_HoaChat AssignTo(KhamBenh_HoaChat _KhamBenh_HoaChat, KhamBenh _KhamBenh)
        {
            //if (Contains(_KhamBenh_HoaChat.MaHC) )


            // if (MessageBox.Show (  HTC.ShareVariables.VAR_ITEMEXIST,"Thong bao",MessageBoxButtons.OKCancel)== DialogResult.Cancel   ) 
            //       return null;

            if (this.Items.Count == 0)
                _KhamBenh_HoaChat.STT = 1;
            else
                _KhamBenh_HoaChat.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_HoaChat);
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_HoaChat.BHTinhTien != 0) && (_KhamBenh_HoaChat.TinhTien== 0))
            // {
            //     __TongBHCTT = decimal.Parse(_KhamBenh_HoaChat.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra))
            //     + decimal.Parse(_KhamBenh_HoaChat.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra));
            // }
            // if ((_KhamBenh_HoaChat.BHTinhTien == 0) || (_KhamBenh_HoaChat.TinhTien!= 0))
            // {
            //     __TongTTCTT = decimal.Parse(_KhamBenh_HoaChat.DongiaTT) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra));

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
            return _KhamBenh_HoaChat;
        }
        protected override object AddNewCore()
        {
            KhamBenh_HoaChat item = KhamBenh_HoaChat.NewKhamBenh_HoaChat();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(KhamBenh_HoaChat _KhamBenh_HoaChat, KhamBenh _KhamBenh)
        {
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_HoaChat.BHTinhTien != 0) && (_KhamBenh_HoaChat.TinhTien == 0))
            //{
            //    __TongBHCTT = decimal.Parse(_KhamBenh_HoaChat.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra))
            //    + decimal.Parse(_KhamBenh_HoaChat.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra));
            //}
            //if ((_KhamBenh_HoaChat.BHTinhTien == 0) || (_KhamBenh_HoaChat.TinhTien != 0))
            //{
            //    __TongTTCTT = decimal.Parse(_KhamBenh_HoaChat.DongiaTT) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - -decimal.Parse(_KhamBenh_HoaChat.SLTra));

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
            if ((_KhamBenh_HoaChat.DaTTTT != 0  && ( _KhamBenh.loai == 9 || _KhamBenh.loai == 7)) ||  (_KhamBenh_HoaChat.DaTTBH!=0 && (_KhamBenh.loai == 2 )))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_HoaChat.SoSoHD, _KhamBenh_HoaChat.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                  
                    }


            }
            if (_KhamBenh_HoaChat.IsNew == true)
                this.Items.Remove(_KhamBenh_HoaChat);
            else
                Remove(_KhamBenh_HoaChat);
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();
        }

        public bool Contains(string MaHC)
        {
            foreach (KhamBenh_HoaChat obj in this)
                if (obj.MaHC == MaHC)
                    return true;
            return false;
        }
        public KhamBenh_HoaChat Containsfind(int stt)
        {
            foreach (KhamBenh_HoaChat obj in this)
                if (obj.STT == stt)
                    return obj;
            return null;

        }

        public bool ContainsDeleted(string MaHC)
        {
            foreach (KhamBenh_HoaChat obj in DeletedList)
                if (obj.MaHC == MaHC)
                    return true;
            return false;
        }
        public bool ContainsDeleted(string sohd, string sosohd)
        {
            foreach (KhamBenh_HoaChat obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    obj.DaTra = true;
                    obj.SLTra = obj.SLMua;
                    obj.thanhtien = "0";

                }
            return false;
        }
        public bool ContainsDeleted(string sohd, string sosohd, KhamBenh_HoaDon kb_hd)
        {
            foreach (KhamBenh_HoaChat obj in this)
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

                }
            return false;
        }
        public void UpdatedTo(KhamBenh_HoaChat _KhamBenh_HoaChat, KhamBenh _KhamBenh)
        {
            KhamBenh_HoaChat _kb = this.Items[this.IndexOf(_KhamBenh_HoaChat)];
            //if (decimal.Parse(_KhamBenh_HoaChat.SLTra) > 0)
            //    _KhamBenh_HoaChat.DaTra  = true;
            //else
            //    _KhamBenh_HoaChat.DaTra = false;
            //if (_KhamBenh_HoaChat.DaTT == 0)
            //{
            //    Decimal __TongBHCTT = 0;
            //    Decimal __TongTTCTT = 0;
            //    if ((_KhamBenh_HoaChat.BHTinhTien != 0) && (_KhamBenh_HoaChat.TinhTien == 0))
            //    {
            //        __TongBHCTT = (decimal.Parse(_KhamBenh_HoaChat.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - decimal.Parse(_KhamBenh_HoaChat.SLTra))
            //        + decimal.Parse(_KhamBenh_HoaChat.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_HoaChat.CK)) / 100 * (decimal.Parse(_KhamBenh_HoaChat.slmua) - decimal.Parse(_KhamBenh_HoaChat.SLTra)))
            //        - (decimal.Parse(_kb.DonGiaBH) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra))
            //        + decimal.Parse(_kb.GiaChenhLech) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.slmua) - decimal.Parse(_kb.SLTra)));
            //    }
            //    if ((_KhamBenh_HoaChat.BHTinhTien == 0) || (_KhamBenh_HoaChat.TinhTien != 0))
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

            _KhamBenh_HoaChat.STT = _kb.STT;

            this.Items[this.IndexOf(_KhamBenh_HoaChat)] = _KhamBenh_HoaChat;
            if ((decimal.Parse(_KhamBenh_HoaChat.SLTra) > 0) && (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 7))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_HoaChat.SoSoHD, _KhamBenh_HoaChat.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                        //    int i = 0;
                        //    KhamBenh_HoaChat kb_c;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_HoaChatList.Count - 1; i++)
                        //    {
                        //        kb_c = _KhamBenh.KhamBenh_HoaChatList[i];
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
                        //    KhamBenh_HoaChat kb_m;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_HoaChatList.Count; i++)
                        //    {
                        //        kb_m = _KhamBenh.KhamBenh_HoaChatList[i];
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
        public void UpdatedTo(KhamBenh_HoaChat _KhamBenh_HoaChat)
        {
            KhamBenh_HoaChat _kb = this.Items[this.IndexOf(_KhamBenh_HoaChat)];
            _KhamBenh_HoaChat.STT = _kb.STT;
            this.Items[this.IndexOf(_KhamBenh_HoaChat)] = _KhamBenh_HoaChat;

        }
        public KhamBenh_HoaChat GetTo(int STT)
        {
            foreach (KhamBenh_HoaChat obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_HoaChatList NewKhamBenh_HoaChatList()
        {
            return new KhamBenh_HoaChatList();
        }

        internal static KhamBenh_HoaChatList GetKhamBenh_HoaChatList(SafeDataReader dr)
        {
            return new KhamBenh_HoaChatList(dr);
        }
        internal static KhamBenh_HoaChatList GetKhamBenh_HoaChatList(SafeDataReader dr, byte loai)
        {
            return new KhamBenh_HoaChatList(dr, loai);
        }
        internal static KhamBenh_HoaChatList GetKhamBenh_HoaChatList(SafeDataReader dr, byte loai, string noitt)
        {
            return new KhamBenh_HoaChatList(dr, loai, noitt);
        }
        private KhamBenh_HoaChatList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_HoaChatList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }
        private KhamBenh_HoaChatList(SafeDataReader dr, byte loai)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr, loai);
        }
        private KhamBenh_HoaChatList(SafeDataReader dr, byte loai, string noitt)
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
                this.Add(KhamBenh_HoaChat.GetKhamBenh_HoaChat(dr));

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

                this.Add(KhamBenh_HoaChat.GetKhamBenh_HoaChat(dr));
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
                this.Add(KhamBenh_HoaChat.GetKhamBenh_HoaChat(dr));
            }
            // dr.Close();
            dr = null;
            RaiseListChangedEvents = true;

        }
        internal void Update(KhamBenh packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_HoaChat item in DeletedList)
                if (!(packet.loai == 2 || packet.loai == 9))
                    item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_HoaChat item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true;
        }

        #endregion
    }
}