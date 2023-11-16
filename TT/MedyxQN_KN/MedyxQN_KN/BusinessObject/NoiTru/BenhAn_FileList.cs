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

    public class BenhAn_FileList : BusinessListBase<BenhAn_FileList, BenhAn_File>
    {
        #region Factory Methods
        public static BenhAn_FileList NewList()
        {
            return DataPortal.Fetch<BenhAn_FileList>(new TemCriteria());
        }
        public static BenhAn_FileList GetAllBenhAn_File(string MaBA , int STT,int STTKhoa)
        {
            return DataPortal.Fetch<BenhAn_FileList>(new Criteria(MaBA,  STT, STTKhoa));
        }
        public static BenhAn_FileList FindBenhAn_File(String MaBA)
        {
            return DataPortal.Fetch<BenhAn_FileList>(new OtherCriteria(MaBA ));
        }
       
        public BenhAn_File NewTo() 
        {
            BenhAn_File obj = BenhAn_File.NewBenhAn_File();
            return obj;
        }
        public void NewTo(BenhAn_File _BenhAn_File)
        {
            try
            {
               
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_File.STTF = this.Items[this.Count - 1].STTF + 1;
                        //this.Add(_BenhAn_File);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_File.STTF = ++_count;
                        this.Add(_BenhAn_File);
                    }
                    else
                    {
                        _BenhAn_File.STTF = 1;
                        this.Add(_BenhAn_File);

                    }
                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(BenhAn_File _BenhAn_File)
        {

            _BenhAn_File.STTF = this.Items[this.IndexOf(_BenhAn_File)].STTF;
            this.Items[this.IndexOf(_BenhAn_File)] = _BenhAn_File;
        }
        //public void RemoveTo(BenhAn_File _BenhAn_File)
        //{
        //    this.Items.Remove(_BenhAn_File);

        //}
        public void RemoveTo(BenhAn_File obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_File  AssignTo(BenhAn_File  _BenhAn_File)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_File.STTF = ++_count;
                    this.Add(_BenhAn_File);
                }
                else
                {
                    _BenhAn_File.STTF = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_File);
                }
           
            return _BenhAn_File;
        }
      
        public BenhAn_File  GetBenhAn_FileById(string MaBA, int sttf)
        {
            foreach (BenhAn_File  item in this)
                if ((item.MaBA == MaBA) && (item.STTF == sttf) )
                    return item;
            return null;
        }
        public void Remove(string MaBA, int sttf)
        {
            foreach (BenhAn_File  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STTF == sttf) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_File GetTo(decimal STT) //
        {
            foreach (BenhAn_File obj in this)
                if (obj.STTF == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_File  item = BenhAn_File.NewBenhAn_File();
            Add(item);
            return item;
        }

      
        private BenhAn_FileList()
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
            private int   _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
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
            private string _MABA;
            public string MABA
            {
                get
                {
                    return _MABA;
                }
            }
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(string MaBA,  int STT, int STTKhoa)
            {
                _MABA = MaBA;
                _STTKhoa = STTKhoa;
                _STT = STT;
                
                
            }
        }
        private class OtherCriteria
        {

            private string _MABA;
            public string MABA
            {
                get
                {
                    return _MABA;
                }
            }

            public OtherCriteria(String MaBA)
            {
                _MABA = MaBA;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_File(criteria.MABA, criteria.STTKhoa, criteria.STT, criteria.DK,false)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_File.GetBenhAn_File(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
           // System.Data.DataSet dr = DataProvider.Instance().GetAllBenhAn_File(criteria.MABA, criteria.STTKhoa, criteria.STT, criteria.DK);
           
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_File(criteria.MABA, 0, 0,"",false )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_File.GetBenhAn_File(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_File  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_File  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_FileList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_FileList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
