using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMQuocGiaListInfo : ReadOnlyBase<DMQuocGiaListInfo>
    {
        #region Business Methods

        string _MaQG = string.Empty;
        public string MaQG
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _MaQG;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_MaQG.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _MaQG = value;
                    //PropertyHasChanged();
                }
            }
        }

        string _TenQG = string.Empty;
        public string TenQG
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _TenQG;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_TenQG.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _TenQG = value;
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
        protected override object GetIdValue()
        {
            return _MaQG;
        }
        #endregion
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

        #region Constructors

        private DMQuocGiaListInfo()
        { /* require use of factory methods */ }

        internal DMQuocGiaListInfo(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _MaQG = MaQG;
            _TenQG = TenQG;
            _maMay = idmay;
            _Huy = huy;
            _ngaySD = ngaySD;
            _NguoiSD = NguoiSD;
        }

        #endregion
    }
}