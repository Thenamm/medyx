using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//using System.Windows.Forms;
 
namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKBaoCaoCongTacCNKList : BusinessListBase<NKBaoCaoCongTacCNKList, NKBaoCaoCongTacCNK>
    {
        #region Factory Methods
        public static NKBaoCaoCongTacCNKList GetAllNKBaoCaoCongTacCNK(Byte tuan,String thang, DateTime tungay, DateTime denngay)
        {
            return DataPortal.Fetch<NKBaoCaoCongTacCNKList>(new Criteria(tuan, thang, tungay, denngay));
        }

        public static NKBaoCaoCongTacCNKList FindsAllNKBaoCaoCongTacCNKH(Byte tuan, String thang)
        {
            return DataPortal.Fetch<NKBaoCaoCongTacCNKList>(new OtherCriteria(tuan, thang));
        }
        public NKBaoCaoCongTacCNK NewTo()
        {
            NKBaoCaoCongTacCNK obj = NKBaoCaoCongTacCNK.NewNKBaoCaoCongTacCNK();
            return obj;
        }
        public void NewTo(NKBaoCaoCongTacCNK _NKBaoCaoCongTacCNK)
        {
            try
            {
                if (!Contains(_NKBaoCaoCongTacCNK.Tuan, _NKBaoCaoCongTacCNK.Thang, _NKBaoCaoCongTacCNK.MaVT))
                {
                    if (this.Items.Count > 0)
                    {
                        //_NKBaoCaoCongTacCNK.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_NKBaoCaoCongTacCNK);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _NKBaoCaoCongTacCNK.OrderNumber = ++_count;
                        this.Add(_NKBaoCaoCongTacCNK);
                    }
                    else
                    {
                        _NKBaoCaoCongTacCNK.OrderNumber = 1;
                        this.Add(_NKBaoCaoCongTacCNK);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void UpdatedTo(NKBaoCaoCongTacCNK _NKBaoCaoCongTacCNK)
        {

            _NKBaoCaoCongTacCNK.OrderNumber = this.Items[this.IndexOf(_NKBaoCaoCongTacCNK)].OrderNumber;
            this.Items[this.IndexOf(_NKBaoCaoCongTacCNK)] = _NKBaoCaoCongTacCNK;
        }
        public void RemoveTo(NKBaoCaoCongTacCNK _NKBaoCaoCongTacCNK)
        {
            this.Items.Remove(_NKBaoCaoCongTacCNK);

        }
        public NKBaoCaoCongTacCNK AssignTo(NKBaoCaoCongTacCNK _NKBaoCaoCongTacCNK)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_NKBaoCaoCongTacCNK.Tuan, _NKBaoCaoCongTacCNK.Thang, _NKBaoCaoCongTacCNK.MaVT))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _NKBaoCaoCongTacCNK.OrderNumber = ++_count;
                        this.Add(_NKBaoCaoCongTacCNK);
                    }
                    else
                    {
                        _NKBaoCaoCongTacCNK.OrderNumber = 1;
                        this.Add(_NKBaoCaoCongTacCNK);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return _NKBaoCaoCongTacCNK;
        }

        //public void Remove(int id)
        //{
        //    foreach (NKBaoCaoCongTacCNK item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(Byte tuan, string thang, String MaVT)
        {
            foreach (NKBaoCaoCongTacCNK obj in this)
                if ((obj.Tuan == tuan) && (obj.Thang == thang) && (obj.MaVT == MaVT))
                    return true;
            return false;
        }

        public NKBaoCaoCongTacCNK GetNKBaoCaoCongTacCNKById(Byte tuan, string thang, String MaVT)
        {
            foreach (NKBaoCaoCongTacCNK item in this)
                if ((item.Tuan == tuan) && (item.MaVT == MaVT) && (item.Thang == thang))
                    return item;
            return null;
        }
        public void Remove(Byte tuan, string thang, String MaVT)
        {
            foreach (NKBaoCaoCongTacCNK item in this)
            {
                if ((item.Tuan == tuan) && (item.MaVT == MaVT) && (item.Thang == thang))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            NKBaoCaoCongTacCNK item = NKBaoCaoCongTacCNK.NewNKBaoCaoCongTacCNK();
            Add(item);
            return item;
        }

       

        private NKBaoCaoCongTacCNKList()
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
            private Byte _tuan;
            private String _thang;
            private DateTime _tungay;
            private DateTime _denngay;

            public Byte Tuan
            {
                get
                {
                    return _tuan;
                }
            }
            public String Thang
            {
                get
                {
                    return _thang;
                }
            }
            public DateTime  TuNgay
            {
                get
                {
                    return _tungay;
                }
            }
            public DateTime DenNgay
            {
                get
                {
                    return _denngay;
                }
            }
            public Criteria(Byte tuan,String mThang, DateTime tuNgay, DateTime denNgay)
            {
                _tuan = tuan;
                _thang = mThang;
                _tungay = tuNgay;
                _denngay = denNgay;
                
            }
        }

        private class OtherCriteria
        {
            private Byte _tuan;
            private String _thang;

            public Byte Tuan
            {
                get
                {
                    return _tuan;
                }
            }
           
            public String Thang
            {
                get
                {
                    return _thang;
                }
            }
            
            public OtherCriteria(Byte tuan, String thang)
            {
                _tuan = tuan;
                _thang = thang;
            }
        }
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKTonKhoaCNK(criteria.Tuan, criteria.Thang, criteria.TuNgay, criteria.DenNgay)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NKBaoCaoCongTacCNK.GetNKBaoCaoCongTacCNK(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindsAllNKTonKhoaCNK(criteria.Tuan, criteria.Thang)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NKBaoCaoCongTacCNK.GetNKBaoCaoCongTacCNK(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (NKBaoCaoCongTacCNK item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (NKBaoCaoCongTacCNK item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NKBaoCaoCongTacCNKList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save NKBaoCaoCongTacCNKList");
            foreach (NKBaoCaoCongTacCNK item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //NKBaoCaoCongTacCNKList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
