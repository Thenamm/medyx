using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBYTModelListInfo : ReadOnlyBase<DMTBYTModelListInfo>
    {
        #region Business Methods

        
        string _MaModel = string.Empty;
        public string MaModel
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _MaModel;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_MaModel.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _MaModel = value;
                    //PropertyHasChanged();
                }
            }
        }

        string _TenModel = string.Empty;
        public string TenModel
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _TenModel;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_TenModel.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _TenModel = value;
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
            return _MaModel;
        }
        #endregion

        #region Constructors

        private DMTBYTModelListInfo()
        { /* require use of factory methods */ }

        internal DMTBYTModelListInfo(int ordernumber, string MaModel, string TenModel, string Ghichu,string idmay, bool huy, SmartDate ngaySD, string NguoiSD,string tenta,String hoten)
        {
            _OrderNumber = ordernumber;
            _MaModel = MaModel;
            _TenModel = TenModel;
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