using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;

namespace HTC.Security
{
    [Serializable()]
    public class HTCIdentity:ReadOnlyBase<HTCIdentity>, IIdentity
    {
        #region IIdentity Members

        private bool _IsAuthenticated;
        private string _Name = String.Empty;
        //private int _UserId = string.Empty ;

        public string AuthenticationType
        {
            get
            {
                return "Nobita";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return _IsAuthenticated;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        //public int  UserID
        //{
        //    get
        //    {
        //        return _UserId;
        //    }
        //}

        protected override object GetIdValue()
        {
            return _Name;
        }


        #endregion

        #region Factory Methods

        internal static HTCIdentity UnauthenticatedIdentity()
        {
          return new HTCIdentity();
        }

        internal static HTCIdentity GetIdentity(
          string username, string password)
        {
          return DataPortal.Fetch<HTCIdentity>
            (new Criteria(username, password));
            
        }

        private HTCIdentity()
        { /* require use of factory methods */ }
        
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _username;
            public string Username
            {
                get
                {
                    return _username;
                }
            }

            private string _password;
            public string Password
            {
                get
                {
                    return _password;
                }
            }

            public Criteria(string username, string password)
            {
                _username = username;
                _password = password;
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().Login(criteria.Username, criteria.Password)))
            {
                if (dr.Read())
                {
                    if (dr.GetString("Password") == criteria.Password)
                    {
                    _Name = dr.GetString("Account");
                    _IsAuthenticated = true;
                    //_UserId = dr.GetString("MANV");
                    //HTC.ShareVariables.pub_bQadmin = dr.GetBoolean("QAdmin");
                    //HTC.ShareVariables.pub_bSgia  = dr.GetBoolean("qsgia");
                    //HTC.ShareVariables.pub_sNguoiSD = dr.GetString("MANV");
                    //HTC.ShareVariables.pub_sQuay = dr.GetString("GhiChu");
                    //HTC.ShareVariables.pub_sTenNguoiSD = dr.GetString("Hoten");
                    //false = _Name;
                    //,_maMay , = System.Environment.MachineName;
                    //HTC.Business.CategoryList.ThamSo ts =HTC.Business.CategoryList.ThamSo.GetThamSo();
                    //HTC.ShareVariables.NgayLV = ts.NgayLV.Date;
                    //HTC.ShareVariables.,_maMay , = ts.daidien;
                    }
                    else
                    {
                        _Name = string.Empty;
                        //_UserId = "-1";
                        _IsAuthenticated = false;
                    }
                }
                else
                {
                    _Name = string.Empty;
                    //_UserId = "-1";
                    _IsAuthenticated = false;
                }
            }
        }

        #endregion
    }
}
