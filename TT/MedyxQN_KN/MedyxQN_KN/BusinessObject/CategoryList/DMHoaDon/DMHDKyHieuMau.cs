using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList
{
    [Serializable]
    public class DMHDKyHieuMau
    {
        public int STT { get; set; }
        public String KyHieuMau { get; set; }
        public String MaNhom { get; set; }        
        public Boolean Huy { get; set; }
        public String TenNhom { get; set; }
        private static string strConnect { get; set; }
        public Boolean isExist { get; set; }

        public DMHDKyHieuMau()
        {
            STT = 0;
            KyHieuMau = string.Empty;
            MaNhom = string.Empty;
            TenNhom = string.Empty;
            Huy = false;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
            this.isExist = false;
        }

        public DMHDKyHieuMau(int STT, String KyHieuMau, String MaNhom, Boolean Huy, String TenNhom)
        {
            this.STT = STT;
            this.KyHieuMau = KyHieuMau;
            this.MaNhom = MaNhom;
            this.Huy = Huy;
            this.TenNhom = TenNhom;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
            this.isExist = false;
        }
        public Boolean Insert()
        {
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieuMau_Create", KyHieuMau, MaNhom).ToString() == "ERROR")
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
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieuMau_Update", KyHieuMau, MaNhom, Huy).ToString() == "ERROR")
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
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHDKyHieuMau_Delete", KyHieuMau).ToString() == "ERROR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DMHDKyHieuMau GetByMa(String KyHieuMau)
        {
            DMHDKyHieuMau obj = new DMHDKyHieuMau();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMHDKyHieuMau_Get", KyHieuMau))
            {
                while(dr.Read())
                {
                    obj = new DMHDKyHieuMau(0, dr["KyHieuMau"].ToString(), dr["MaNhom"].ToString(), string.IsNullOrEmpty(dr["Huy"].ToString()) ? false : Boolean.Parse(dr["Huy"].ToString()), dr["TenNhom"].ToString()) { isExist = true };
                    break;
                }
            }
            return obj;
        }
    }

    [Serializable]
    public class DMHDKyHieuMauList: List<DMHDKyHieuMau>
    {
        public static DMHDKyHieuMauList GetAll(Boolean QAdmin)
        {
            DMHDKyHieuMauList obj = new DMHDKyHieuMauList();
            using (IDataReader dr = SqlHelper.ExecuteReader(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spDMHDKyHieuMau_GetAll", QAdmin))
            {
                int STT = 0;
                while (dr.Read())
                {
                    obj.Add(new DMHDKyHieuMau(++STT, dr["KyHieuMau"].ToString(), dr["MaNhom"].ToString(), string.IsNullOrEmpty(dr["Huy"].ToString()) ? false : Boolean.Parse(dr["Huy"].ToString()), dr["TenNhom"].ToString()) { isExist = true });
                }
            }
            return obj;
        }

        public Boolean Save()
        {
            foreach (var item in this)
            {
                if(item.isExist)
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
