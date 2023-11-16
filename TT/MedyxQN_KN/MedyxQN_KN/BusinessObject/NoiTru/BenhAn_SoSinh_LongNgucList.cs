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
    public class BenhAn_SoSinh_LongNgucList : BusinessListBase<BenhAn_SoSinh_LongNgucList, BenhAn_SoSinh_LongNguc>
    {
        #region Factory Methods
        //private static BenhAn_SoSinh_LongNgucList _list;
        public static BenhAn_SoSinh_LongNgucList GetAllBenhAn_SoSinh_LongNguc(String MaBA, int STTKhoa, int STTK)
        {
            return DataPortal.Fetch<BenhAn_SoSinh_LongNgucList>(new Criteria(MaBA,STTKhoa, STTK));
        }
        public static bool CheckBenhAn_SoSinh_LongNguc(String MaBA, int sttKhoa,  int STTK)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_SoSinh_LongNguc(MaBA,sttKhoa , STTK)))
            {
                if (dr.Read())
                {
                    if (dr.GetString("MaBA") != "")
                    {
                        return true;
                    }
                    if (dr.GetInt32("sttkhoa") != 0)
                    {
                        return true;
                    }
                    if (dr.GetInt32("sttk") != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public BenhAn_SoSinh_LongNguc NewTo()
        {
            BenhAn_SoSinh_LongNguc obj = BenhAn_SoSinh_LongNguc.NewBenhAn_SoSinh_LongNguc();
            return obj;
        }
        public void NewTo(BenhAn_SoSinh_LongNguc _BenhAn_SoSinh_LongNguc)
        {

            try
            {

                if (this.Items.Count > 0)
                {
                    //_BenhAn_SoSinh_LongNguc.STT = this.Items[this.Count - 1].STT + 1;
                    //this.Add(_BenhAn_SoSinh_LongNguc);
                    int _count = 0;
                    this.Add(_BenhAn_SoSinh_LongNguc);

                }
                else
                {
                    this.Add(_BenhAn_SoSinh_LongNguc);

                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(BenhAn_SoSinh_LongNguc _BenhAn_SoSinh_LongNguc)
        {

            this.Items[this.IndexOf(_BenhAn_SoSinh_LongNguc)] = _BenhAn_SoSinh_LongNguc;
        }
        public void RemoveTo(BenhAn_SoSinh_LongNguc _BenhAn_SoSinh_LongNguc)
        {
            this.Items.Remove(_BenhAn_SoSinh_LongNguc);

        }
        public BenhAn_SoSinh_LongNguc AssignTo(BenhAn_SoSinh_LongNguc _BenhAn_SoSinh_LongNguc)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {

                this.Add(_BenhAn_SoSinh_LongNguc);
            }
            else
            {
                this.Add(_BenhAn_SoSinh_LongNguc);
            }
            return _BenhAn_SoSinh_LongNguc;
        }

        //public void Remove(int id)
        //{
        //    foreach (BenhAn_SoSinh_LongNguc item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        //public bool Contains(string MaNV, DateTime thang,  bool Huy)
        //{
        //    foreach (BenhAn_SoSinh_LongNguc obj in this)
        //        if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
        //            return true;
        //    return false;
        //}

        //public BenhAn_SoSinh_LongNguc GetBenhAn_SoSinh_LongNgucById(string MaBC, string ma)
        //{
        //    foreach (BenhAn_SoSinh_LongNguc item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        //public void Remove(string MaNV)
        //{
        //    foreach (BenhAn_SoSinh_LongNguc  item in this)
        //    {
        //        if (item.MaNV == MaNV) 
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public BenhAn_SoSinh_LongNguc GetTo(decimal STT)
        {
            foreach (BenhAn_SoSinh_LongNguc obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_SoSinh_LongNguc item = BenhAn_SoSinh_LongNguc.NewBenhAn_SoSinh_LongNguc();
            Add(item);
            return item;
        }

        public BenhAn_SoSinh_LongNgucList DeleteCache()
        {
            return null;
        }

        private BenhAn_SoSinh_LongNgucList()
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
        private class Criteria
        {
            private String _MaBA;



            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private int _STTK;
            public int STTK
            {
                get
                {
                    return _STTK;
                }
            }
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(String mMaBA, int _STTKhoa, int STTK)
            {
                _MaBA = mMaBA;
                _STTK = STTK;
                _STTKhoa = _STTKhoa;
            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {

            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_SoSinh_LongNguc(criteria.MaBA, criteria.STTKhoa, criteria.STTK)))
            {
                while (dr.Read())
                {

                    this.Add(BenhAn_SoSinh_LongNguc.GetBenhAn_SoSinh_LongNguc(dr));

                } dr.Close(); dr.Dispose();

            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //DeletedList.Clear();
            //foreach (BenhAn_SoSinh_LongNguc item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (BenhAn_SoSinh_LongNguc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_SoSinh_LongNgucList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BenhAn_SoSinh_LongNgucList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
