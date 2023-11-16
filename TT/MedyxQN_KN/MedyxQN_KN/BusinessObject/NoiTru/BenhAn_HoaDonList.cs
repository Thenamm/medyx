using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.NoiTru
{
    [Serializable()]

    public class BenhAn_HoaDonList : BusinessListBase<BenhAn_HoaDonList, BenhAn_HoaDon>
    {
        #region Factory Methods
        public static BenhAn_HoaDonList NewList()
        {
            return DataPortal.Fetch<BenhAn_HoaDonList>(new TemCriteria());
        }
        public static BenhAn_HoaDonList GetAllBenhAn_HoaDon(DateTime tungay, DateTime denngay, byte loai ,string   dk)
        {
            return DataPortal.Fetch<BenhAn_HoaDonList>(new Criteria( tungay,  denngay,  loai ,   dk));
        }
        public static BenhAn_HoaDonList FindBenhAn_HoaDon(String SosoHD, String SoHD)
        {
            return DataPortal.Fetch<BenhAn_HoaDonList>(new OtherCriteria(SosoHD, SoHD));
        }
       
        public BenhAn_HoaDon NewTo() 
        {
            BenhAn_HoaDon obj = BenhAn_HoaDon.NewBenhAn_HoaDon();
            return obj;
        }
        public void NewTo(BenhAn_HoaDon _BenhAn_HoaDon)
        {
            try
            {
                if (!Contains(_BenhAn_HoaDon.SoSoHD , _BenhAn_HoaDon.SoHD ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_HoaDon.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_HoaDon);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_HoaDon.STT = ++_count;
                        this.Add(_BenhAn_HoaDon);
                    }
                    else
                    {
                        _BenhAn_HoaDon.STT = 1;
                        this.Add(_BenhAn_HoaDon);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(BenhAn_HoaDon _BenhAn_HoaDon)
        {

            _BenhAn_HoaDon.STT = this.Items[this.IndexOf(_BenhAn_HoaDon)].STT;
            this.Items[this.IndexOf(_BenhAn_HoaDon)] = _BenhAn_HoaDon;
        }
        //public void RemoveTo(BenhAn_HoaDon _BenhAn_HoaDon)
        //{
        //    this.Items.Remove(_BenhAn_HoaDon);

        //}
        public void RemoveTo(BenhAn_HoaDon obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_HoaDon  AssignTo(BenhAn_HoaDon  _BenhAn_HoaDon)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_HoaDon.SoSoHD, _BenhAn_HoaDon.SoHD))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_HoaDon.STT = ++_count;
                    this.Add(_BenhAn_HoaDon);
                }
                else
                {
                    _BenhAn_HoaDon.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_HoaDon);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_HoaDon;
        }
        public bool Contains(string sosohd, string sohd)
        {
            foreach (BenhAn_HoaDon  obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    return false;
                }
            return false;
        }
        public BenhAn_HoaDon  GetBenhAn_HoaDonById(string MaBA, int stt)
        {
            foreach (BenhAn_HoaDon  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt)
        {
            foreach (BenhAn_HoaDon  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_HoaDon GetTo(decimal STT) //
        {
            foreach (BenhAn_HoaDon obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_HoaDon  item = BenhAn_HoaDon.NewBenhAn_HoaDon();
            Add(item);
            return item;
        }

      
        private BenhAn_HoaDonList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria
        {
            private DateTime   _TuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            private DateTime _DenNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _DenNgay;
                }
            }
            private byte  _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
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

            public Criteria(DateTime tungay, DateTime denngay, byte loai, string dk)
            {
                _TuNgay = tungay;
                _DenNgay = denngay;
                _Loai = loai;
                _DK = dk;
                
            }
        }
        private class OtherCriteria
        {
           
            private String _SoSoHD;
            public String SoSoHD
            {
                get
                {
                    return _SoSoHD;
                }
            }

            private String _SoHD;
            public String SoHD
            {
                get
                {
                    return _SoHD;
                }
            }

            public OtherCriteria(String SoSoHD,String SoHD)
            {
                _SoHD = SoHD;
                _SoSoHD = SoSoHD;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_HoaDon(criteria.TuNgay, criteria.DenNgay,criteria.Loai , criteria.DK  )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HoaDon.GetBenhAn_HoaDon(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBenhAn_HoaDon(criteria.SoSoHD , criteria.SoHD)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HoaDon.GetBenhAn_HoaDon(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_HoaDon  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_HoaDon  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_HoaDonList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_HoaDonList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
