using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;
using HTC.Business.CategoryList;
////

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_XNList : BusinessListBase<BenhAn_XNList, BenhAn_XN >
    {
        #region Business Methods
        public BenhAn_XN Containsfind(int sttkhoa, int stt)
        {
            foreach (BenhAn_XN obj in this)
                if ((obj.STT == stt) && (obj.STTKhoa == sttkhoa))
                    return obj;
            return null;
        }
         public BenhAn_XN AssignTo(string maba,int sttkhoa,int stt,string madv)
        {
            if (true)
            {
                BenhAn_XN obj = BenhAn_XN.NewBenhAn_XN();
                //obj.BSChiDinh = bschidinh;
                //obj.MaBenhBD  = mabenhbd ;
                //obj.MaBP =mabp;
                //obj.MaDV = madv;
                obj.MaBA = maba;
                obj.STT = stt;
                obj.STTKhoa = sttkhoa;
                obj.MaDV = madv;
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public BenhAn_XN AssignTo(BenhAn_XN obj)
        {
            if (true)
            {
                
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public BenhAn_XN AssignTo(string madv, string MaBA, int stt)
        {
            if (true)
            {
                BenhAn_XN obj = BenhAn_XN.NewBenhAn_XN();
               
                obj.MaDV = madv;
                obj.MaBA = MaBA;
                obj.STT = stt;
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public BenhAn_XN AssignTo(string madv)
        {
            if (true)
            {
                BenhAn_XN obj = BenhAn_XN.NewBenhAn_XN();
               
                obj.MaDV = madv;
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
       

        #endregion
        #region Factory Methods
        internal static BenhAn_XNList NewBenhAn_XNList()
        {
            return new BenhAn_XNList();
        }
        public static BenhAn_XNList GetBenhAn_XN_GetAll(String _maBA, int sttKhoa, String _dKien)
        {
            return DataPortal.Fetch<BenhAn_XNList>(new Criteria(_maBA, sttKhoa, _dKien,false    ));
        }
        public void NewTo(BenhAn_XN _BenhAn_XN)
        {
            if (this.Count == 0)
                _BenhAn_XN.OrderNumber = 1;
            else
                _BenhAn_XN.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_XN);
        }
        public BenhAn_XN NewTo()
        {
             BenhAn_XN obj = BenhAn_XN.NewBenhAn_XN();
              return obj;
        }
       
        public void UpdatedTo(BenhAn_XN _BenhAn_XN)
        {

            _BenhAn_XN.OrderNumber = this.Items[this.IndexOf(_BenhAn_XN)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_XN)] = _BenhAn_XN;
        }
        public void RemoveTo(BenhAn_XN _BenhAn_XN)
        {
            this.Items.Remove(_BenhAn_XN);

        }
        private BenhAn_XNList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
            private int _sTTKhoa;
            public int sTTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
           
            public Criteria(String maba, int sttKhoa, String dKien,Boolean qadmin )
            {
                _qadmin = qadmin;
                _maBA = maba;
                _sTTKhoa = sttKhoa ;
                _qadmin = qadmin;
                _dk = dKien;
            }
        }
        #endregion


        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_XN_GetAll(criteria.maBA, criteria.sTTKhoa, criteria.dk, criteria.qadmin)))
        //    {

        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            try
        //            {
        //                BenhAn_XN item = new BenhAn_XN(
        // i,
        // dr.GetInt32("STT"),
        // dr.GetString("MaBA"),
        // dr.GetInt32("STTKhoa"),
        // dr.GetString("MaDV"),
        // dr.GetString("BSChiDinh"),
        // dr.GetString("MaBP"),
        // dr.GetSmartDate("NgayKQ", true),
        // (Byte[])dr.GetValue("FileKQ"),
        // dr.GetString("KQ"),
        // dr.GetString("SID"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetSmartDate("NgaySD", true),
        // dr.GetString("NguoiSD"),
        // dr.GetSmartDate("NgaySD1", true),
        // dr.GetString("NguoiSD1"),
        // dr.GetByte("LoaiKQ"),
        // dr.GetBoolean("DiDong"),
        // dr.GetString("MaBenhBD"),
        // dr.GetString("ChisocaoNu"),
        // dr.GetString("ChisocaoNam"),
        // dr.GetString("ChisothapNu"),
        // dr.GetString("ChisothapNam"),
        // dr.GetString("TenDV"),
        // dr.GetString("TenBenh"),
        // dr.GetString("tenBS"),
        // dr.GetString("tenBP"),
        // dr.GetString("Donvi")
        //                             );

        //                this.Add(item);
        //                i += 1;
        //            }
        //            catch (Exception ex)
        //            {
        //               //MessageBox.Show(ex.ToString());
        //            }

        //        }
        //    }
        //    RaiseListChangedEvents = true; 
        //}
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_XN_GetAll(criteria.maBA, criteria.sTTKhoa, criteria.dk, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_XN.GetBenhAn_XN(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; 
        }
        internal void Update(BenhAn_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (BenhAn_XN item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (BenhAn_XN item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; 
        }
        #endregion
    }
}
