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
    public class BenhAn_San_TK_ApgarList : BusinessListBase<BenhAn_San_TK_ApgarList, BenhAn_San_TK_Apgar>
    {
        #region Factory Methods
        //private static BenhAn_San_TK_ApgarList _list;
        public static BenhAn_San_TK_ApgarList GetAllBenhAn_San_TK_Apgar(String maBA,int STTDe)
        {
            return DataPortal.Fetch<BenhAn_San_TK_ApgarList>(new Criteria(maBA,STTDe));
        }
        public static bool CheckBenhAn_San_TK_Apgar(String maBA,int STTDe)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San_TK_Apgar( maBA,STTDe)))
            {
                if (dr.Read())
                {
                    if (dr.GetString("MaBA") != "")
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        
       
        public BenhAn_San_TK_Apgar NewTo()
        {
            BenhAn_San_TK_Apgar obj = BenhAn_San_TK_Apgar.NewBenhAn_San_TK_Apgar();
            return obj;
        }
        public void   NewTo(BenhAn_San_TK_Apgar _BenhAn_San_TK_Apgar)
        {
           
            try
            {
               
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_San_TK_Apgar.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_San_TK_Apgar);
                        int _count = 0;
                        this.Add(_BenhAn_San_TK_Apgar);
                        
                    }
                    else
                    {
                        this.Add(_BenhAn_San_TK_Apgar);

                    }
               
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(BenhAn_San_TK_Apgar _BenhAn_San_TK_Apgar)
        {

            this.Items[this.IndexOf(_BenhAn_San_TK_Apgar)] = _BenhAn_San_TK_Apgar;
        }
        public void RemoveTo(BenhAn_San_TK_Apgar _BenhAn_San_TK_Apgar)
        {
            this.Items.Remove(_BenhAn_San_TK_Apgar);

        }
        public BenhAn_San_TK_Apgar  AssignTo(BenhAn_San_TK_Apgar  _BenhAn_San_TK_Apgar)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                
                this.Add(_BenhAn_San_TK_Apgar);
            }
            else
            {
                this.Add(_BenhAn_San_TK_Apgar);
            }
            return _BenhAn_San_TK_Apgar;
        }

        //public void Remove(int id)
        //{
        //    foreach (BenhAn_San_TK_Apgar item in this)
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
        //    foreach (BenhAn_San_TK_Apgar obj in this)
        //        if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
        //            return true;
        //    return false;
        //}

        //public BenhAn_San_TK_Apgar GetBenhAn_San_TK_ApgarById(string MaBC, string ma)
        //{
        //    foreach (BenhAn_San_TK_Apgar item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        //public void Remove(string MaNV)
        //{
        //    foreach (BenhAn_San_TK_Apgar  item in this)
        //    {
        //        if (item.MaNV == MaNV) 
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public BenhAn_San_TK_Apgar GetTo(decimal STT)
        {
            foreach (BenhAn_San_TK_Apgar obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_San_TK_Apgar item = BenhAn_San_TK_Apgar.NewBenhAn_San_TK_Apgar();
            Add(item);
            return item;
        }

        public BenhAn_San_TK_ApgarList DeleteCache()
        {
            return null;
        }

        private BenhAn_San_TK_ApgarList()
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
             private int _STTDe;
            public int STTDe
            {
                get
                {
                    return _STTDe;
                }
            }
            public Criteria(String mMaBA, int STTDe)
            {
                _MaBA  = mMaBA  ;
                _STTDe = STTDe;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
           
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_San_TK_Apgar(criteria.MaBA,criteria .STTDe )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BenhAn_San_TK_Apgar.GetBenhAn_San_TK_Apgar(dr));

                } dr.Close(); dr.Dispose();
               
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //DeletedList.Clear();
            //foreach (BenhAn_San_TK_Apgar item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (BenhAn_San_TK_Apgar item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_San_TK_ApgarList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BenhAn_San_TK_ApgarList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
