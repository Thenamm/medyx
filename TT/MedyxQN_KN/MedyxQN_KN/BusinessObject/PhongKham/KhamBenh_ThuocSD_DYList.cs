using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.PhongKham
{
    [Serializable()]

    public class KhamBenh_ThuocSD_DYList : BusinessListBase<KhamBenh_ThuocSD_DYList, KhamBenh_ThuocSD_DY>
    {
        #region Business Methods
        #region State Fields
        public int _loai = 0;

        #endregion
        #endregion
        #region Factory Methods
        internal static KhamBenh_ThuocSD_DYList NewKhamBenh_ThuocSD_DYList()
        {
            return new KhamBenh_ThuocSD_DYList();
        }

        public static KhamBenh_ThuocSD_DYList NewList()
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYList>(new TemCriteria());
        }
        public static KhamBenh_ThuocSD_DYList GetAllKhamBenh_ThuocSD_DY(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYList>(new Criteria(MaSoKham));
        }
       
      
        public static KhamBenh_ThuocSD_DYList GetAllKhamBenh_ThuocSD_DYByNgayYCKhoa(String Makhoa,  string NgayDK)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYList>(new OtherCriteria(Makhoa, NgayDK, 5));
        }
        public static KhamBenh_ThuocSD_DYList GetAllKhamBenh_ThuocSD_DYByNgayYC(String MaSoKham, string NgayDK)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYList>(new OtherCriteria(MaSoKham, NgayDK, 2));
        }
        public static KhamBenh_ThuocSD_DYList GetAllKhamBenh_ThuocSD_DYByNgayYCDT(String MaSoKham,  string NgayDK)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DYList>(new OtherCriteria(MaSoKham, NgayDK, 3));
        }
        public KhamBenh_ThuocSD_DY this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public KhamBenh_ThuocSD_DY NewTo() 
        {
            KhamBenh_ThuocSD_DY obj = KhamBenh_ThuocSD_DY.NewKhamBenh_ThuocSD_DY();
            return obj;
        }
        public void NewTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY)
        {
            try
            {

                if (this.Items.Count > 0)
                {
                    //_KhamBenh_ThuocSD_DY.STT = this.Items[this.Count - 1].STT + 1;
                    //this.Add(_KhamBenh_ThuocSD_DY);
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_ThuocSD_DY.STT = ++_count;
                    this.Add(_KhamBenh_ThuocSD_DY);
                }
                else
                {
                    _KhamBenh_ThuocSD_DY.STT = 1;
                    this.Add(_KhamBenh_ThuocSD_DY);

                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY)
        {

            _KhamBenh_ThuocSD_DY.STT = this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)].STT;
            this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)] = _KhamBenh_ThuocSD_DY;
        }
        public void UpdatedTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY, KhamBenh _KhamBenh)
        {

            _KhamBenh_ThuocSD_DY.STT = this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)].STT;
            this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)] = _KhamBenh_ThuocSD_DY;
            if (((_KhamBenh_ThuocSD_DY.SLTra) > 0) && (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 7))
            {
                KhamBenh_HoaDon _kbhd = _KhamBenh.KhamBenh_HoaDonList.Contains(_KhamBenh_ThuocSD_DY.SoSoHD, _KhamBenh_ThuocSD_DY.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;
                  
                    }


            }
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3)
                _KhamBenh.TinhLaiTienKhamBenh();
        }
        public void UpdatedTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY, KhamBenh_Q _KhamBenh)
        {

            _KhamBenh_ThuocSD_DY.STT = this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)].STT;
            this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY)] = _KhamBenh_ThuocSD_DY;
                _KhamBenh.TinhLaiTienKhamBenh();
        }
        public KhamBenh_ThuocSD_DY  AssignTo(KhamBenh_ThuocSD_DY  _KhamBenh_ThuocSD_DY)//add mot hang PhieuNhap_C
        {
           
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _KhamBenh_ThuocSD_DY.STT = ++_count;
                   // _KhamBenh_ThuocSD_DY.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_KhamBenh_ThuocSD_DY);
                }
                else
                {
                    _KhamBenh_ThuocSD_DY.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_KhamBenh_ThuocSD_DY);
                }
           
            //Add(_PhieuNhap_C);
            return _KhamBenh_ThuocSD_DY;
        }
        public KhamBenh_ThuocSD_DY AssignTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY, KhamBenh _KhamBenh)//add mot hang PhieuNhap_C
        {

            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _KhamBenh_ThuocSD_DY.STT = ++_count;
                // _KhamBenh_ThuocSD_DY.STTKhoa = this.Items[0].STTKhoa; 
                this.Add(_KhamBenh_ThuocSD_DY);
            }
            else
            {
                _KhamBenh_ThuocSD_DY.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_KhamBenh_ThuocSD_DY);
            }
            if (_KhamBenh.loai == 2 || _KhamBenh.loai == 9 || _KhamBenh.loai == 3 || _KhamBenh.loai == 7)
                _KhamBenh.TinhLaiTienKhamBenh();
            //Add(_PhieuNhap_C);
            return _KhamBenh_ThuocSD_DY;
        }
        public KhamBenh_ThuocSD_DY AssignTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY, KhamBenh_Q _KhamBenh)//add mot hang PhieuNhap_C
        {

            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _KhamBenh_ThuocSD_DY.STT = ++_count;
                // _KhamBenh_ThuocSD_DY.STTKhoa = this.Items[0].STTKhoa; 
                this.Add(_KhamBenh_ThuocSD_DY);
            }
            else
            {
                _KhamBenh_ThuocSD_DY.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_KhamBenh_ThuocSD_DY);
            }
                _KhamBenh.TinhLaiTienKhamBenh();
            //Add(_PhieuNhap_C);
            return _KhamBenh_ThuocSD_DY;
        }
      
        public KhamBenh_ThuocSD_DY  GetKhamBenh_ThuocSD_DYById(int stt)
        {
            foreach (KhamBenh_ThuocSD_DY  item in this)
                if ( (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(string MaSoKham, int stt)
        {
            foreach (KhamBenh_ThuocSD_DY  item in this)
            {
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(KhamBenh_ThuocSD_DY obj,KhamBenh _khambenh) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if ((obj.DaTTTT != 0 && (_khambenh.loai == 9 || _khambenh.loai == 7)) || (obj.DaTTBH != 0 && (_khambenh.loai == 2)))
            {
                KhamBenh_HoaDon _kbhd = _khambenh.KhamBenh_HoaDonList.Contains(obj.SoSoHD, obj.SoHD);

                if (_kbhd != null)
                    if (_kbhd.TongChi != _kbhd.TongThu)
                    {
                        _kbhd.TongChi = _kbhd.TongThu;

                    }


            }
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public KhamBenh_ThuocSD_DY GetTo(decimal STT) //
        {
            foreach (KhamBenh_ThuocSD_DY obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            KhamBenh_ThuocSD_DY  item = KhamBenh_ThuocSD_DY.NewKhamBenh_ThuocSD_DY();
            Add(item);
            return item;
        }

      
        private KhamBenh_ThuocSD_DYList()
        {  /* Require use of factory methods */
            MarkAsChild();
            this.AllowNew = true;
        }
        internal static KhamBenh_ThuocSD_DYList GetKhamBenh_ThuocSD_DYList(SafeDataReader dr)
        {
            return new KhamBenh_ThuocSD_DYList(dr);
        }
           private KhamBenh_ThuocSD_DYList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
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
            this.RaiseListChangedEvents = true; 
        }
        private class Criteria
        {
            private String  _MaSoKham;
            private Boolean _qadmin = false ;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMaSoKham)
            {
                _MaSoKham = mMaSoKham;
                
            }
        }
        private class OtherCriteria
        {
           
             private Boolean _qadmin = false ;
           
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
            private string _MaSoKham;
            public string MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            public OtherCriteria(String MaSoKham,  string NgayDK, byte loai)
            {
                 if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                       
                        _DK = "  and a.MaSoKham = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                     
                        else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007'  and a.MaSoKham = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.MaSoKham = '" + MaSoKham + "'";
                    else if (loai == 5)
                       
                        _DK = "  and a.makhoa = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                      else
                        _DK = "  and a.MaSoKham = '" + MaSoKham + "'";

                else

                    if (loai == 2)
                      
                           _DK = "  and a.MaSoKham = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                    else if (loai == 5)
                           _DK = "  and a.makhoa = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                     
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.MaSoKham = '" + MaSoKham + "'";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007'  and a.MaSoKham = '" + MaSoKham + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                    else
                        _DK = "  and a.MaSoKham = '" + MaSoKham + "'";
         
              
                _MaSoKham = MaSoKham;
              
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD_DY(criteria.MaSoKham,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_ThuocSD_DY .GetKhamBenh_ThuocSD_DY(dr,i));
                    i++;

                }
                KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY = KhamBenh_ThuocSD_DY.NewKhamBenh_ThuocSD_DY();
                _KhamBenh_ThuocSD_DY.MaSoKham = "";
                this.Add(_KhamBenh_ThuocSD_DY);
            }
            this.RaiseListChangedEvents = true; 
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD_DY(criteria.MaSoKham,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_ThuocSD_DY.GetKhamBenh_ThuocSD_DY(dr, i));
                    i++;
                }
                dr.Close ();
            }
         
            this.RaiseListChangedEvents = true; 
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (KhamBenh_ThuocSD_DY  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (KhamBenh_ThuocSD_DY  item in this)
            {
                if ((item.SLThang != "0" || item.SLMua != "0"))
                if (item.IsNew) 
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; 
        }

        public override KhamBenh_ThuocSD_DYList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            KhamBenh_ThuocSD_DYList  result;
            result = base.Save();
            return result;
        }

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
          
            while (dr.Read())
            {
                this.Add(KhamBenh_ThuocSD_DY.GetKhamBenh_ThuocSD_DY(dr));

               
             
            }
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_ThuocSD_DY item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_ThuocSD_DY item in this)
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
            foreach (KhamBenh_ThuocSD_DY item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_ThuocSD_DY item in this)
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
