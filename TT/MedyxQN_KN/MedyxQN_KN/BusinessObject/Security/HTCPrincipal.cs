using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Csla.Data;
using HTC.Business;

namespace HTC.Security
{
    [Serializable()]
    public class HTCPrincipal:Csla.Security.BusinessPrincipalBase
    {
        private HTCPrincipal(IIdentity identity): base(identity)
        {
        }

        public static bool Login(string username, string password)
        {
            HTCIdentity identity = HTCIdentity.GetIdentity(username, password);
            if (identity.IsAuthenticated)
            {
                HTCPrincipal principal = new HTCPrincipal(identity);
                Csla.ApplicationContext.User = principal;
                
            }
            return identity.IsAuthenticated;
        }

        public static void Logout()
        {
            HTCIdentity identity = HTCIdentity.UnauthenticatedIdentity();
            HTCPrincipal principal = new HTCPrincipal(identity);
            Csla.ApplicationContext.User = principal;
        }

        public override bool IsInRole(string role)
        {
            HTCIdentity identity = (HTCIdentity)this.Identity;
            return true;
        }

        /// <summary>
        /// Kiem tra quyen hien thi FormName cua User.
        /// </summary>
        /// <param name="FormName"></param>
        /// <returns></returns>
        public static bool CanShowForm(string FormName)
        {
            bool result = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPermission(Csla.ApplicationContext.User.Identity.Name, FormName)))
            {
                dr.Read();
                result = System.Convert.ToBoolean(dr.GetByte("Read"));
            }
            return result;
        }

        public static bool CanModifyForm(string FormName)
        {
            bool result = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPermission(Csla.ApplicationContext.User.Identity.Name, FormName)))
            {
                dr.Read();
                result = System.Convert.ToBoolean(dr.GetByte("Modify"));
            }
            return result;
        }

        public static bool CanCreateForm(string FormName)
        {
            bool result = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPermission(Csla.ApplicationContext.User.Identity.Name, FormName)))
            {
                dr.Read();
                result = System.Convert.ToBoolean(dr.GetByte("Insert"));
            }
            return result;
        }

        public static bool CanDeleteForm(string FormName)
        {
            bool result = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPermission(Csla.ApplicationContext.User.Identity.Name, FormName)))
            {
                dr.Read();
                result = System.Convert.ToBoolean(dr.GetByte("Delete"));
            }
            return result;
        }
       
        public static bool IsSuperUser()
        {
            try
            {
                return Csla.ApplicationContext.User.Identity.Name == "admin";
            }
            catch (Exception  ex)
            {
                return false;
            }
        }
        
    }
}
