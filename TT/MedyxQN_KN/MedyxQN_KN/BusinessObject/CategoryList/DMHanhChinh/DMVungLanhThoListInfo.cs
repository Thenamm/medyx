using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVungLanhThoListInfo : ReadOnlyBase<DMVungLanhThoListInfo>
    {
        #region Business Methods

        string _MaVungLT = string.Empty;
        public string MaVungLT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _MaVungLT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_MaVungLT.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _MaVungLT = value;
                    //PropertyHasChanged();
                }
            }
        }

        string _TenVungLT = string.Empty;
        public string TenVungLT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _TenVungLT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (value == null)
                    value = string.Empty;
                if (!_TenVungLT.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _TenVungLT = value;
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
                return _ngaySD ;
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
            return _MaVungLT;
        }
        #endregion

        #region Constructors

        private DMVungLanhThoListInfo()
        { /* require use of factory methods */ }

        internal DMVungLanhThoListInfo(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _MaVungLT = MaQG;
            _TenVungLT = TenQG;
            _maMay = idmay;
            _Huy = huy;
            _ngaySD = ngaySD;
            _NguoiSD = NguoiSD;
        }

        #endregion
    }
}