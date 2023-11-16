using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDonvitinhListInfo : ReadOnlyBase<DMDonvitinhListInfo>
    {
        #region Business Methods

        
        string _MaDVT = string.Empty;
        public string MaDVT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _MaDVT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_MaDVT.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _MaDVT = value;
                    //PropertyHasChanged();
                }
            }
        }

        string _TenDVT = string.Empty;
        public string TenDVT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _TenDVT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_TenDVT.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _TenDVT = value;
                    //PropertyHasChanged();
                }
            }
        }
        string _tenta = string.Empty;
        public string tenta
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _tenta;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_tenta.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _tenta = value;
                    //PropertyHasChanged();
                }
            }
        }
        string _Ghichu = string.Empty;
        public string Ghichu
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Ghichu;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_Ghichu.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _Ghichu = value;
                    //PropertyHasChanged();
                }
            }
        }

        string _maMay = string.Empty;
        public string MaMay
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _maMay;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_maMay.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _maMay = value;
                    //PropertyHasChanged();
                }
            }
        }


        bool _Huy;
        /// <summary>
        /// Gioi tinh
        /// </summary>
        public bool Huy
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Huy;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_Huy.Equals(value))
                {
                    _Huy = value;
                    //PropertyHasChanged();
                }
            }
        }

        protected SmartDate _ngaySD = new SmartDate(false);
        public SmartDate NgaySD
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_ngaySD.Equals(value))
                {
                    _ngaySD = value;
                    //PropertyHasChanged();
                }
            }
        }
        string _NguoiSD = string.Empty;
        public string NguoiSD
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _NguoiSD;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_NguoiSD.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _NguoiSD = value;
                    //PropertyHasChanged();
                }
            }
        }
        string _hoten = string.Empty;
        public string hoten
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _hoten;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_hoten.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _hoten = value;
                    //PropertyHasChanged();
                }
            }
        }

        int _OrderNumber;
        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

        protected override object GetIdValue()
        {
            return _MaDVT;
        }
        #endregion

        #region Constructors

        private DMDonvitinhListInfo()
        { /* require use of factory methods */ }

        internal DMDonvitinhListInfo(int ordernumber, string MaDVT, string TenDVT, string Ghichu,string idmay, bool huy, SmartDate ngaySD, string NguoiSD,string tenta,String hoten)
        {
            _OrderNumber = ordernumber;
            _MaDVT = MaDVT;
            _TenDVT = TenDVT;
            _Ghichu = Ghichu;
            _maMay = idmay;
            _Huy = huy;
            _ngaySD = ngaySD;
            _NguoiSD = NguoiSD;
            _tenta = tenta;
            _hoten = hoten;
        }

        #endregion
    }
}