using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;


namespace HTC.Business.CategoryList
{
    [Serializable]
    public class DMHDKyHieu
    {
        public int STT { get; set; }
        public String KyHieu { get; set; }
        public Boolean Huy { get; set; }
        private static string strConnect { get; set; }
        public Boolean isExist { get; set; }

        public DMHDKyHieu()
        {
            STT = 0;
            KyHieu = string.Empty;
            Huy = false;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
            this.isExist = false;
        }

        public DMHDKyHieu(int STT, String KyHieu, Boolean Huy)
        {
            this.STT = STT;
            this.KyHieu = KyHieu;
            this.Huy = Huy;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
            this.isExist = false;
        }
        public Boolean Insert()
        {
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieu_Create", KyHieu).ToString() == "ERROR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Update()
        {
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieu_Update", KyHieu, Huy).ToString() == "ERROR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public Boolean Delete()
        {
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieu_Delete", KyHieu).ToString() == "ERROR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DMHDKyHieu GetByMa(String KyHieu)
        {
            DMHDKyHieu obj = new DMHDKyHieu();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMHDKyHieu_Get", KyHieu))
            {
                while (dr.Read())
                {
                    obj = new DMHDKyHieu(0, dr["KyHieu"].ToString(), string.IsNullOrEmpty(dr["Huy"].ToString()) ? false : Boolean.Parse(dr["Huy"].ToString())) { isExist = true };
                    break;
                }
            }
            return obj;
        }
    }

    [Serializable]
    public class DMHDKyHieuList : List<DMHDKyHieu>
    {
        public static DMHDKyHieuList GetAll(Boolean QAdmin)
        {
            DMHDKyHieuList obj = new DMHDKyHieuList();
            using (IDataReader dr = SqlHelper.ExecuteReader(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spDMHDKyHieu_GetAll", QAdmin))
            {
                int STT = 0;
                while (dr.Read())
                {
                    obj.Add(new DMHDKyHieu(++STT, dr["KyHieu"].ToString(), string.IsNullOrEmpty(dr["Huy"].ToString()) ? false : Boolean.Parse(dr["Huy"].ToString())) { isExist = true });
                }
            }
            return obj;
        }

        public Boolean Save()
        {
            foreach (var item in this)
            {
                if (item.isExist)
                {
                    if (!item.Update()) return false;
                }
                else
                {
                    if (!item.Insert()) return false;
                }
            }
            return true;
        }
    }
}
