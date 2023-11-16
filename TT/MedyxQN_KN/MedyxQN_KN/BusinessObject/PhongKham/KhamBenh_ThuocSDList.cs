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
    public class KhamBenh_ThuocSDList : BusinessListBase<KhamBenh_ThuocSDList, KhamBenh_ThuocSD>
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
        public KhamBenh_ThuocSD this[string Mathuoc]
        {
            get
            {
                foreach (KhamBenh_ThuocSD obj in this)
                    if (obj.Mathuoc.Equals(Mathuoc))
                        return obj;
                return null;
            }
        }
        public KhamBenh_ThuocSD this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string Mathuoc)
        {
            if (!Contains(Mathuoc) == true)
            {
                KhamBenh_ThuocSD obj = KhamBenh_ThuocSD.NewKhamBenh_ThuocSD(Mathuoc);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public static KhamBenh_ThuocSDList GetAllKhamBenh_ThuocSD(string masokham, string makhoa, byte loai, DateTime ngayyc, byte datt, string dk)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSDList>(new CriteriaOther(masokham, makhoa, loai, ngayyc, datt, dk));
        }
        public static KhamBenh_ThuocSDList GetAllKhamBenh_ThuocSD(string _masokham)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSDList>(new Criteria(_masokham));
        }
        public KhamBenh_ThuocSD NewTo()
        {

            KhamBenh_ThuocSD obj = KhamBenh_ThuocSD.NewKhamBenh_ThuocSD();
            return obj;

        }
        public void NewTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD)
        {
            //if (!Contains(_KhamBenh_ThuocSD.Mathuoc))
            //{
            //    if (this.Items.Count > 0)
            //    {
            //        byte _count=0;
            //        _count = (byte)this.Items.Count;
            //        _KhamBenh_ThuocSD.STT = ++_count;
            if (this.Items.Count == 0)
                _KhamBenh_ThuocSD.STT = 1;
            else
                _KhamBenh_ThuocSD.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_ThuocSD);
            //    }
            //    else
            //    {
            //        _KhamBenh_ThuocSD.STT = 1;
            //        this.Add(_KhamBenh_ThuocSD);
            //    }
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_ThuocSD AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                KhamBenh_ThuocSD obj = KhamBenh_ThuocSD.NewKhamBenh_ThuocSD(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_ThuocSD AssignTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD, KhamBenh _KhamBenh)
        {
            //if (Contains(_KhamBenh_ThuocSD.Mathuoc) )


            // if (MessageBox.Show (  HTC.ShareVariables.VAR_ITEMEXIST,"Thong bao",MessageBoxButtons.OKCancel)== DialogResult.Cancel   ) 
            //       return null;

            if (this.Items.Count == 0)
                _KhamBenh_ThuocSD.STT = 1;
            else
                _KhamBenh_ThuocSD.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_ThuocSD);
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_ThuocSD.BHTinhTien != 0) && (_KhamBenh_ThuocSD.TinhTien== 0))
            // {
            //     __TongBHCTT = decimal.Parse(_KhamBenh_ThuocSD.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra))
            //     + decimal.Parse(_KhamBenh_ThuocSD.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra));
            // }
            // if ((_KhamBenh_ThuocSD.BHTinhTien == 0) || (_KhamBenh_ThuocSD.TinhTien!= 0))
            // {
            //     __TongTTCTT = decimal.Parse(_KhamBenh_ThuocSD.DongiaTT) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra));

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
            return _KhamBenh_ThuocSD;
        }
        protected override object AddNewCore()
        {
            KhamBenh_ThuocSD item = KhamBenh_ThuocSD.NewKhamBenh_ThuocSD();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD, KhamBenh _KhamBenh)
        {
            //Decimal __TongBHCTT = 0;
            //Decimal __TongTTCTT = 0;
            //if ((_KhamBenh_ThuocSD.BHTinhTien != 0) && (_KhamBenh_ThuocSD.TinhTien == 0))
            //{
            //    __TongBHCTT = decimal.Parse(_KhamBenh_ThuocSD.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra))
            //    + decimal.Parse(_KhamBenh_ThuocSD.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra));
            //}
            //if ((_KhamBenh_ThuocSD.BHTinhTien == 0) || (_KhamBenh_ThuocSD.TinhTien != 0))
            //{
            //    __TongTTCTT = decimal.Parse(_KhamBenh_ThuocSD.DongiaTT) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - -decimal.Parse(_KhamBenh_ThuocSD.SLTra));

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
            if ((_KhamBenh_ThuocSD.DaTTTT != 0 && (_KhamBenh.loai == 9 || _KhamBenh.loai == 7)) || (_KhamBenh_ThuocSD.DaTTBH != 0 && (_KhamBenh.loai == 2)))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_ThuocSD.SoSoHD, _KhamBenh_ThuocSD.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;

                    }


            } 
            if (_KhamBenh_ThuocSD.IsNew == true)
                this.Items.Remove(_KhamBenh_ThuocSD);
            else
                Remove(_KhamBenh_ThuocSD);
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();
        }

        public bool Contains(string Mathuoc)
        {
            foreach (KhamBenh_ThuocSD obj in this)
                if (obj.Mathuoc == Mathuoc)
                    return true;
            return false;
        }
        public KhamBenh_ThuocSD Containsfind(int stt)
        {
            foreach (KhamBenh_ThuocSD obj in this)
                if (obj.STT == stt)
                    return obj;
            return null;

        }

        public bool ContainsDeleted(string Mathuoc)
        {
            foreach (KhamBenh_ThuocSD obj in DeletedList)
                if (obj.Mathuoc == Mathuoc)
                    return true;
            return false;
        }
        public bool ContainsDeleted(string sohd, string sosohd)
        {
            foreach (KhamBenh_ThuocSD obj in this)
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
            foreach (KhamBenh_ThuocSD obj in this)
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
        public void UpdatedTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD, KhamBenh _KhamBenh)
        {
            KhamBenh_ThuocSD _kb = this.Items[this.IndexOf(_KhamBenh_ThuocSD)];
            //if (decimal.Parse(_KhamBenh_ThuocSD.SLTra) > 0)
            //    _KhamBenh_ThuocSD.DaTra  = true;
            //else
            //    _KhamBenh_ThuocSD.DaTra = false;
            //if (_KhamBenh_ThuocSD.DaTT == 0)
            //{
            //    Decimal __TongBHCTT = 0;
            //    Decimal __TongTTCTT = 0;
            //    if ((_KhamBenh_ThuocSD.BHTinhTien != 0) && (_KhamBenh_ThuocSD.TinhTien == 0))
            //    {
            //        __TongBHCTT = (decimal.Parse(_KhamBenh_ThuocSD.DonGiaBH) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - decimal.Parse(_KhamBenh_ThuocSD.SLTra))
            //        + decimal.Parse(_KhamBenh_ThuocSD.GiaChenhLech) * (100 - decimal.Parse(_KhamBenh_ThuocSD.CK)) / 100 * (decimal.Parse(_KhamBenh_ThuocSD.SLMua) - decimal.Parse(_KhamBenh_ThuocSD.SLTra)))
            //        - (decimal.Parse(_kb.DonGiaBH) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.SLMua) - decimal.Parse(_kb.SLTra))
            //        + decimal.Parse(_kb.GiaChenhLech) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.SLMua) - decimal.Parse(_kb.SLTra)));
            //    }
            //    if ((_KhamBenh_ThuocSD.BHTinhTien == 0) || (_KhamBenh_ThuocSD.TinhTien != 0))
            //    {
            //        __TongTTCTT = (decimal.Parse(_kb.DongiaTT) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.SLMua) - decimal.Parse(_kb.SLTra)))
            //            - (decimal.Parse(_kb.DongiaTT) * (100 - decimal.Parse(_kb.CK)) / 100 * (decimal.Parse(_kb.SLMua) - decimal.Parse(_kb.SLTra)));

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

            _KhamBenh_ThuocSD.STT = _kb.STT;

            this.Items[this.IndexOf(_KhamBenh_ThuocSD)] = _KhamBenh_ThuocSD;
            if ((decimal.Parse(_KhamBenh_ThuocSD.SLTra) > 0) && (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 7))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_ThuocSD.SoSoHD, _KhamBenh_ThuocSD.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                        //    int i = 0;
                        //    KhamBenh_ThuocSD kb_c;
                        //    for (i = 0; i < _KhamBenh.KhamBenh_ThuocSDList.Count - 1; i++)
                        //    {
                        //        kb_c = _KhamBenh.KhamBenh_ThuocSDList[i];
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
        public void UpdatedTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD)
        {
            KhamBenh_ThuocSD _kb = this.Items[this.IndexOf(_KhamBenh_ThuocSD)];
            _KhamBenh_ThuocSD.STT = _kb.STT;
            this.Items[this.IndexOf(_KhamBenh_ThuocSD)] = _KhamBenh_ThuocSD;

        }
        public KhamBenh_ThuocSD GetTo(int STT)
        {
            foreach (KhamBenh_ThuocSD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_ThuocSDList NewKhamBenh_ThuocSDList()
        {
            return new KhamBenh_ThuocSDList();
        }

        internal static KhamBenh_ThuocSDList GetKhamBenh_ThuocSDList(SafeDataReader dr)
        {
            return new KhamBenh_ThuocSDList(dr);
        }
        internal static KhamBenh_ThuocSDList GetKhamBenh_ThuocSDList(SafeDataReader dr, byte loai)
        {
            return new KhamBenh_ThuocSDList(dr, loai);
        }
        internal static KhamBenh_ThuocSDList GetKhamBenh_ThuocSDList(SafeDataReader dr, byte loai, string noitt)
        {
            return new KhamBenh_ThuocSDList(dr, loai, noitt);
        }
        private KhamBenh_ThuocSDList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_ThuocSDList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }
        private KhamBenh_ThuocSDList(SafeDataReader dr, byte loai)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr, loai);
        }
        private KhamBenh_ThuocSDList(SafeDataReader dr, byte loai, string noitt)
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
                this.Add(KhamBenh_ThuocSD.GetKhamBenh_ThuocSD(dr));

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

                this.Add(KhamBenh_ThuocSD.GetKhamBenh_ThuocSD(dr));
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
                this.Add(KhamBenh_ThuocSD.GetKhamBenh_ThuocSD(dr));
            }
            // dr.Close();
            dr = null;
            RaiseListChangedEvents = true;

        }
        internal void Update(KhamBenh packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_ThuocSD item in DeletedList)
                if (!(packet.loai == 2 || packet.loai == 9))
                    item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_ThuocSD item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true;
        }
        internal void Update(KhamBenh_Q packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_ThuocSD item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_ThuocSD item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else if (item.IsDirty)
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD(criteria.masokham, "5", false)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_ThuocSD.GetKhamBenh_ThuocSD(dr));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true;
        }

        protected class Criteria
        {
             private Boolean _qadmin = false ;
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }


            public Criteria(string masokham)
            {
                _masokham = masokham;

            }
        };
        protected void DataPortal_Fetch(Criteria criteria)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD(criteria.masokham, "5", false)))
            {
                //int i = 1;
                //IsReadOnly = false;
                //while (dr.Read())
                //    this.Add(KhamBenh_ThuocSD.GetKhamBenh_ThuocSD(dr));
                Fetch(dr);

            }
            // RaiseListChangedEvents = true; 

        }

  


        #endregion
    }
}