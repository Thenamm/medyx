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

    public class PhieuThuChiList : BusinessListBase<PhieuThuChiList, PhieuThuChi>
    {
        #region Factory Methods
        public static PhieuThuChiList NewList()
        {
            return DataPortal.Fetch<PhieuThuChiList>(new TemCriteria());
        }
        public static PhieuThuChiList GetAllPhieuThuChi(DateTime tungay, DateTime denngay,byte loai,string noitt)
        {
            return DataPortal.Fetch<PhieuThuChiList>(new Criteria(tungay, denngay,  noitt,loai,""));
        }
    
       
       
       
        public PhieuThuChi NewTo() 
        {
            PhieuThuChi obj = PhieuThuChi.NewPhieuThuChi();
            return obj;
        }




        public void Remove(string SoPhieu)
        {
            foreach (PhieuThuChi  item in this)
            {
                if ((item.SoPhieu == SoPhieu) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(PhieuThuChi obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public PhieuThuChi GetTo(string SoPhieu) //
        {
            foreach (PhieuThuChi obj in this)
                if (obj.SoPhieu == SoPhieu)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            PhieuThuChi  item = PhieuThuChi.NewPhieuThuChi();
            Add(item);
            return item;
        }

      
        private PhieuThuChiList()
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
           
            private Boolean _qadmin = false ;
            private DateTime _tungay;
            public DateTime tungay
            {
                get
                {
                    return _tungay;
                }
            }
            private DateTime _denngay;
            public DateTime denngay
            {
                get
                {
                    return _denngay;
                }
            }
            private String _noitt;
            public String noitt
            {
                get
                {
                    return _noitt;
                }
            }
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
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
            public Criteria(DateTime mtungay, DateTime mdenngay,String mnoitt, byte mloai, string mdk)
            {
               
                _DK = "";
                _loai = mloai;
                _noitt = mnoitt;
                    _DK = " and isnull(a.loai,0) =  "+mloai .ToString ();
                    _tungay = mtungay;
                    _denngay = mdenngay;
                
            }
        }
   
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuThuChi(criteria.tungay, criteria.denngay,criteria.loai,criteria.noitt, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(PhieuThuChi .GetPhieuThuChi(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
     
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (PhieuThuChi  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (PhieuThuChi  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override PhieuThuChiList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            PhieuThuChiList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
