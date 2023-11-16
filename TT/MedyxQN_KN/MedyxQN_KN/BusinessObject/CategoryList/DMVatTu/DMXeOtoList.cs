using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMXeOtoList : BusinessListBase<DMXeOtoList, DMXeOto>
    {
        #region Factory Methods
        public static DMXeOtoList GetAllDMXeOto()
        {
            return DataPortal.Fetch<DMXeOtoList>(new Criteria());
        }

        public static DMXeOtoList FindDMXeOtoByMa(String ma)
        {
            return DataPortal.Fetch<DMXeOtoList>(new CriteriaOther(1, ma));
        }
        public static DMXeOtoList FindDMXeOtoByTen(String ten)
        {
            return DataPortal.Fetch<DMXeOtoList>(new CriteriaOther(2, ten));
        }
        public DMXeOto NewTo()
        {
            DMXeOto obj = DMXeOto.NewDMXeOto();
            return obj;
        }
        public void NewTo(DMXeOto _DMXeOto)
        {

            try
            {
                if (!Contains(_DMXeOto.MaXeOto ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMXeOto.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMXeOto);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMXeOto.OrderNumber = ++_count;
                        this.Add(_DMXeOto);
                    }
                    else
                    {
                        _DMXeOto.OrderNumber = 1;
                        this.Add(_DMXeOto);

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
        public void UpdatedTo(DMXeOto _DMXeOto)
        {

            _DMXeOto.MaXeOto = this.Items[this.IndexOf(_DMXeOto)].MaXeOto;
            this.Items[this.IndexOf(_DMXeOto)] = _DMXeOto;
        }
        public void RemoveTo(DMXeOto _DMXeOto)
        {
          

            if (_DMXeOto.IsNew == true)

                this.Items.Remove(_DMXeOto);
            else
                Remove(_DMXeOto);

      

        }
        public DMXeOto AssignTo(DMXeOto _DMXeOto)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMXeOto.OrderNumber = ++_count;
                this.Add(_DMXeOto);
            }
            else
            {
                _DMXeOto.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMXeOto);
            }
            //Add(_PhieuNhap_C);
            return _DMXeOto;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMXeOto item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaXeOto)
        {
            foreach (DMXeOto obj in this)
                if ((obj.MaXeOto == MaXeOto) )
                    return true;
            return false;
        }

        
        public DMXeOto GetTo(decimal STT) //
        {
            foreach (DMXeOto obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            DMXeOto item = DMXeOto.NewDMXeOto();
            Add(item);
            return item;
        }

       
        //public static DMXeOtoList GetDMXeOto(String MaXeOto, String maNCC, String namThau,String dK)
        //{
        //    return DataPortal.Fetch<DMXeOtoList>(new OtherCriteria(MaXeOto ,maNCC , namThau, dK ));
        //}

        private DMXeOtoList()
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

             private Boolean _qadmin = false ;
            private string _dK;
            public string DK
            {
                get
                {
                    return _dK;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
         
          
          
            public Criteria()
            {
              

            }
        }
   

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMXeOto(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;
                while (dr.Read())
                {
                   this.Add(DMXeOto.GetDMXeOto(dr, i));         
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
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
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "(A.maxeoto like '%" + mDK + "' )";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(A.tenxeoto)) like N'" + mDK + "%'";
             
            }
        }
        #endregion

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMXeOto(criteria.DK, false)))
            {
                
              
                while (dr.Read())
                {
                    this.Add(DMXeOto.GetDMXeOto(dr, i));
                    i += 1;
                }
                
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMXeOto item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMXeOto item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMXeOtoList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMXeOtoList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
