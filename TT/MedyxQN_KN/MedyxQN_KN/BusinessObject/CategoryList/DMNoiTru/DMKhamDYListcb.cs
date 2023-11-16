using System.Diagnostics;
using System;
 //using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKhamDYListcb : NameValueListBase<string, string>
    {

       
        #region Factory Methods
        private static DMKhamDYListcb _list;
        public static DMKhamDYListcb HanNhiet()
        {
            //if (_list == null)
            //{
            string _machungloai = "030301";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Mohoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "030302";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }


        public static DMKhamDYListcb BungNguc()
        {
            //if (_list == null)
            //{
            string _machungloai = "030304";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }


        public static DMKhamDYListcb An()
        {
            //if (_list == null)
            //{
            string _machungloai = "030305";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb TieuTien()
        {
            //if (_list == null)
            //{
            string _machungloai = "030306";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

      
        public static DMKhamDYListcb DaiTien()
        {
            //if (_list == null)
            //{
            string _machungloai = "050306";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Ngu()
        {
            //if (_list == null)
            //{
            string _machungloai = "030307";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Uong()
        {
            //if (_list == null)
            //{
            string _machungloai = "030308";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Thongkinh()
        {
            //if (_list == null)
            //{
            string _machungloai = "03030901";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Doiha()
        {
            //if (_list == null)
            //{
            string _machungloai = "03030902";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb RoiLoanNam()
        {
            //if (_list == null)
            //{
            string _machungloai = "03030903";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb RoiLoanNu()
        {
            //if (_list == null)
            //{
            string _machungloai = "03030904";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb DauDau()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031001";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XucChan_Da()
        {
            //if (_list == null)
            //{
            string _machungloai = "03040101";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XucChan_CXK()
        {
            //if (_list == null)
            //{
            string _machungloai = "03040102";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XucChan_MoHoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "03040103";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XucChan_Bung()
        {
            //if (_list == null)
            //{
            string _machungloai = "03040104";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb ThonTrai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030402";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb QuanTrai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030502";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XichTrai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030602";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb ThonPhai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030702";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb QuanPhai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030802";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb XichPhai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030902";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb KieuMach()
        {
            //if (_list == null)
            //{
            string _machungloai = "030410";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb BatCuong()
        {
            //if (_list == null)
            //{
            string _machungloai = "0402";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb TangPhu()
        {
            //if (_list == null)
            //{
            string _machungloai = "0403";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb RoiLoanKN()
        {
            //if (_list == null)
            //{
            string _machungloai = "03030905";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb KinhMach()
        {
            //if (_list == null)
            //{
            string _machungloai = "0404";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb DinhViBenhTheo()
        {
            //if (_list == null)
            //{
            string _machungloai = "0405";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb NguyenNhan()
        {
            //if (_list == null)
            //{
            string _machungloai = "0406";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Sac()
        {
            //if (_list == null)
            //{
            string _machungloai = "0502";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Mat()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031002";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb ThietChan_Bung()
        {
            //if (_list == null)
            //{
            string _machungloai = "05040101";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Than()
        {
            //if (_list == null)
            //{
            string _machungloai = "0602";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Tai()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031003";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Trach()
        {
            //if (_list == null)
            //{
            string _machungloai = "0702";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Mui()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031004";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb Hong()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031005";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb CoVai()
        {
            //if (_list == null)
            //{
            string _machungloai = "03031006";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Lung()
        {
            //if (_list == null)
            //{
            string _machungloai = "091301";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }


        public static DMKhamDYListcb KieuMui()
        {
            //if (_list == null)
            //{
            string _machungloai = "03020202";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb KieuChatThai()
        {
            //if (_list == null)
            //{
            string _machungloai = "03020201";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb Ho()
        {
            //if (_list == null)
            //{
            string _machungloai = "03020103";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb HoiTho()
        {
            //if (_list == null)
            //{
            string _machungloai = "03020102";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb GiongNoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "03020101";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }


        public static DMKhamDYListcb ReuLuoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "03010303";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb SacLuoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "03010302";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb ChatLuoi()
        {
            //if (_list == null)
            //{
            string _machungloai = "03010301";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb HinhThai()
        {
            //if (_list == null)
            //{
            string _machungloai = "030101";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }

        public static DMKhamDYListcb CheDoDinhDuong()
        {
            //if (_list == null)
            //{
            string _machungloai = "10";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }
        public static DMKhamDYListcb CheDoChamSoc()
        {
            //if (_list == null)
            //{
            string _machungloai = "11";
            _list = null;
            _list = DataPortal.Fetch<DMKhamDYListcb>(new Criteria(_machungloai)); //typeof(DMKhamDYListcb)));
            //}
            return _list;
        }


        /// <summary>
        /// Xóa PositionList trong bộ nhớ để danh sách quốc gia sẽ được
        /// reload lại.
        /// </summary>
        /// <remarks></remarks>
        public static void InvalidateCache()
        {
            _list = null;
        }

        private DMKhamDYListcb()
        {

        }
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _machungloai;
            public string machungloai
            {
                get
                {
                    return _machungloai;
                }
            }
            public Criteria(string mmachungloai)
            {

                _machungloai = mmachungloai;
            }

        }
      
        private void DataPortal_Fetch(Criteria criteria)
        {
            //this.RaiseListChangedEvents = false;
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhamDY( criteria.machungloai)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("Ma"), dr.GetString("Ten")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        #endregion
    }
}
