using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_HoaDonList : BusinessListBase<KhamBenh_HoaDonList, KhamBenh_HoaDon>
    {
        #region Business Methods
        #region State Fields
        public decimal _TongTT = 0;

        #endregion
        public static KhamBenh_HoaDonList GetAllKhamBenh_HoaDon(DateTime tungay, DateTime denngay, byte loai, string dk)
        {
            return DataPortal.Fetch<KhamBenh_HoaDonList>(new CriteriaOther(tungay, denngay, loai, dk));
        }
        public static KhamBenh_HoaDonList GetAllKhamBenh_HoaDon(string sosohd , string sohd)
        {
            return DataPortal.Fetch<KhamBenh_HoaDonList>(new OtherCriteria(sosohd ,sohd));
        }
        public KhamBenh_HoaDon this[int  stt]
        {
            get
            {
                //foreach (KhamBenh_HoaDon obj in this)
                //    if (obj.STT.Equals(stt))
                //        return obj;
                
                return this.Items[stt];
            }
        }

       
        public KhamBenh_HoaDon NewTo()
        {
           
              KhamBenh_HoaDon obj = KhamBenh_HoaDon.NewKhamBenh_HoaDon();
              return obj;
               
        }

     

       
        public KhamBenh_HoaDon AssignTo(string sosohd, string sohd, decimal tongthu, byte loai)
        {
            KhamBenh_HoaDon obj = KhamBenh_HoaDon.NewKhamBenh_HoaDon();
            obj.SoSoHD = sosohd;
            obj.SoHD = sohd;
            obj.TongThu = tongthu;
            obj.loai = loai;
            obj.lanin = 1;
            obj.NgayThu = DateTime.Now.ToShortDateString();
           
            if (this.Items.Count == 0)
                obj.STT = 1;
            else
                obj.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(obj);
            return obj;
        }
        public KhamBenh_HoaDon AssignTo(KhamBenh_HoaDon _KhamBenh_HoaDon)
        {
            
            if (this.Items.Count == 0)
                _KhamBenh_HoaDon.STT = 1;
            else
                _KhamBenh_HoaDon.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_KhamBenh_HoaDon);
            return _KhamBenh_HoaDon;
        }
        protected override object AddNewCore()
        {
            KhamBenh_HoaDon item = KhamBenh_HoaDon.NewKhamBenh_HoaDon();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int stt)
        {
            foreach (KhamBenh_HoaDon obj in this)
            {
                if (obj.STT.Equals(stt))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(int stt)
        {
            foreach (KhamBenh_HoaDon obj in this)
                if (obj.STT  == stt )
                    return true;
            return false;
        }

        public KhamBenh_HoaDon Contains(string sosohd, string sohd)
        {
            foreach (KhamBenh_HoaDon obj in this)
                if ((obj.SoSoHD   == sosohd )&& (obj.SoHD == sohd)) 
                    return obj;
            return null;
        }
        public KhamBenh_HoaDon ContainsCIn()
        {
            foreach (KhamBenh_HoaDon obj in this)
                if ((obj.lanin == 0))
                    return obj;
            return null;
        }
        public Boolean   ContainsDeleted(string sosohd, string sohd,KhamBenh _KhamBenh)
        {
            foreach (KhamBenh_HoaDon obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    _KhamBenh.KhamBenh_C_List.ContainsDeleted(sosohd, sohd);
                    _KhamBenh.KhamBenh_ThuocSDList.ContainsDeleted(sosohd, sohd);
                    _KhamBenh.KhamBenh_MauList.ContainsDeleted(sosohd, sohd);
                    _KhamBenh.KhamBenh_VTTHList.ContainsDeleted(sosohd, sohd);

                    _KhamBenh.KhamBenh_GetsDichVuList.ContainsDeleted(sosohd, sohd);  
                    _KhamBenh.TongTienBHDTT = _KhamBenh.TongTienBHDTT - obj.TongTienBH; 
                           obj.TongChi =obj.TongThu  ;
                           obj.NgayChi = DateTime.Now .ToString () ; 
                    return true;
                }
            return false;
        }
        public Boolean ContainsDeleted(string sosohd, string sohd,string sosohdcu, string sohdcu, KhamBenh _KhamBenh,byte loaiphieu  )
        {
            foreach (KhamBenh_HoaDon obj in this)
                if ((obj.SoSoHD == sosohdcu) && (obj.SoHD == sohdcu))
                {
                    KhamBenh_HoaDon obj1 = Contains(sosohd, sohd);
                    if ((obj1 != null) && (obj1.lanin > 1))
                        return false;
                    else
                    {
                        if (obj1 == null)
                        {
                            obj1 = NewTo();
                            obj1.SoSoHD = sosohd;
                            obj1.SoHD = sohd;
                            obj1.loai = loaiphieu;
                            obj1.lanin = 1;
                            obj1.NgayThu = DateTime.Now.ToShortDateString();  
                                //obj1.NguoiThu  = HTC.ShareVariables.pub_sNguoiSD;
                            _KhamBenh.KhamBenh_C_List.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_ThuocSDList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_MauList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_VTTHList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            Add (obj1);
                        }
                        else
                        {
                            obj1.SoSoHD = sosohd;
                            obj1.SoHD = sohd;
                            _KhamBenh.KhamBenh_C_List.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_ThuocSDList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_MauList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            _KhamBenh.KhamBenh_VTTHList.ContainsDeleted(sosohdcu, sohdcu, obj1);
                            
                        }

                        //_KhamBenh.KhamBenh_GetsDichVuList.ContainsDeleted(sosohd, sohd,obj1);
                       // _KhamBenh.TongTienBHDTT = _KhamBenh.TongTienBHDTT - obj.TongTienBH;
                    }
                    obj.TongChi = obj.TongThu;
                    return true;
                }
            return false;
        }
        public bool ContainsDeleted(int stt)
        {
            foreach (KhamBenh_HoaDon obj in DeletedList)
                if (obj.STT == stt)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_HoaDon _KhamBenh_HoaDon)
        {

            _KhamBenh_HoaDon.STT = this.Items[this.IndexOf(_KhamBenh_HoaDon)].STT;
            this.Items[this.IndexOf(_KhamBenh_HoaDon)] = _KhamBenh_HoaDon;
        }
        public KhamBenh_HoaDon GetTo(Byte STT)
        {
            foreach (KhamBenh_HoaDon obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_HoaDonList NewKhamBenh_HoaDonList()
        {
            return new KhamBenh_HoaDonList();
        }

        internal static KhamBenh_HoaDonList GetKhamBenh_HoaDonList(SafeDataReader dr)
        {
            return new KhamBenh_HoaDonList(dr);
        }
     
        private KhamBenh_HoaDonList()
        {
            this.AllowNew = true;
           // MarkAsChild();
        }

        private KhamBenh_HoaDonList(SafeDataReader dr)
        {
            this.AllowNew = true;
           // MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access
        private class CriteriaOther
        {
            private DateTime _TuNgay;
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
            private byte _Loai;
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

            public CriteriaOther(DateTime tungay, DateTime denngay, byte loai, string dk)
            {
                _TuNgay = tungay;
                _DenNgay = denngay;
                _Loai = loai;
                _DK = dk;

            }
        }
        private class OtherCriteria
        {
           
            private string _sosohd;
            public string sosohd
            {
                get
                {
                    return _sosohd;
                }
            }
             private string _sohd;
            public string sohd
            {
                get
                {
                    return _sohd;
                }
            }
            public OtherCriteria(string sosohd,string sohd)
            {
               _sosohd =sosohd ;
                _sohd =sohd ;

            }
        }
     
             private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_HoaDon (criteria.TuNgay, criteria.DenNgay, criteria.Loai, criteria.DK,HTC.ShareVariables.pub_bQadmin  )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_HoaDon.GetKhamBenh_HoaDon(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; 
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
           


            foreach (KhamBenh_HoaDon item in this)
            {
                             
                    item.Update();
            }

            this.RaiseListChangedEvents = true; 
        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
           _TongTT = 0;
            while (dr.Read())
            {
               
                this.Add(KhamBenh_HoaDon.GetKhamBenh_HoaDon(dr));
                //if ((dr.GetDecimal("Tongthu") - dr.GetDecimal("tongchi") != 0) && dr.GetBoolean("huy") == false)
                //    _TongTT = _TongTT + dr.GetDecimal("Tongthu") - dr.GetDecimal("tongchi");
                _TongTT = _TongTT + dr.GetDecimal("Tongthu") - dr.GetDecimal("tongchi");
            }
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_HoaDon item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_HoaDon item in this)
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
            foreach (KhamBenh_HoaDon item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_HoaDon item in this)
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