using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.CategoryList
{
    [Serializable]
    public class DMHoaDon_KhoKhoa
    {
        public Int32 Ordernumber { get; set; }
        public String MaKho { get; set; }
        public String MaKhoa { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public Boolean KhongSuDung { get; set; }
        public String TenKho { get; set; }
        public String TenKhoa { get; set; }
        private static string strConnect { get; set; }
        public Boolean IsKhoKhoaEdit { get; set; }
        public Boolean IsKhoKhoa
        {
            get
            {
                return _isKhoKhoa;
            }
        }
        private Boolean _isKhoKhoa =  false;
        public DMHoaDon_KhoKhoa()
        {
            MaKho = "";
            MaKhoa = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            KhongSuDung = new Boolean();
            TenKho = "";
            TenKhoa = "";
            Ordernumber = 0;
            _isKhoKhoa = false;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        }

        public DMHoaDon_KhoKhoa(String MaKho, String MaKhoa, Boolean Huy, String NgaySD, String NguoiSD, String MaMay, Boolean KhongSuDung, String TenKho, String TenKhoa, Boolean IsKhoKhoa, Int32 Ordernumber)
        {
            this.MaKho = MaKho;
            this.MaKhoa = MaKhoa;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.KhongSuDung = KhongSuDung;
            this.TenKho = TenKho;
            this.TenKhoa = TenKhoa;
            this._isKhoKhoa = IsKhoKhoa;
            this.Ordernumber = Ordernumber;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        }
        public DMHoaDon_KhoKhoa(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaKho"].GetType().Name != "DBNull" && dr["MaKho"] != null)
            {
                this.MaKho = Convert.ToString(dr["MaKho"]);
            }
            else
            {
                this.MaKho = "";
            }
            if (dr["MaKhoa"].GetType().Name != "DBNull" && dr["MaKhoa"] != null)
            {
                this.MaKhoa = Convert.ToString(dr["MaKhoa"]);
            }
            else
            {
                this.MaKhoa = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = new Boolean();
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["KhongSuDung"].GetType().Name != "DBNull" && dr["KhongSuDung"] != null)
            {
                this.KhongSuDung = Convert.ToBoolean(dr["KhongSuDung"]);
            }
            else
            {
                this.KhongSuDung = false;
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
            }
            if (dr["TenKhoa"].GetType().Name != "DBNull" && dr["TenKhoa"] != null)
            {
                this.TenKhoa = Convert.ToString(dr["TenKhoa"]);
            }
            else
            {
                this.TenKhoa = "";
            }

            if (dr["IsKhoKhoa"].GetType().Name != "DBNull" && dr["IsKhoKhoa"] != null)
            {
                this._isKhoKhoa = Convert.ToBoolean(dr["IsKhoKhoa"]);
            }
            else
            {
                this._isKhoKhoa = false;
            }

            this.Ordernumber = Ordernumber;
            strConnect = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        }


        public Boolean Insert()
        {
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHoaDon_KhoKhoa_Create", MaKho, MaKhoa, MaMay, KhongSuDung).ToString() == "ERROR")
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
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHoaDon_KhoKhoa_Update", MaKho, MaKhoa, Huy, NguoiSD, MaMay, KhongSuDung).ToString() == "ERROR")
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
            if (SqlHelper.ExecuteScalar(strConnect, "spDMHoaDon_KhoKhoa_Delete", MaKho, MaKhoa, MaMay).ToString() == "ERROR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DMHoaDon_KhoKhoa GetByMa(String MaKho, String MaKhoa)
        {
            DMHoaDon_KhoKhoa obj = new DMHoaDon_KhoKhoa();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMHoaDon_KhoKhoa_Get", MaKho, MaKhoa))
            {
                while (dr.Read())
                {
                    obj = new DMHoaDon_KhoKhoa(dr, 0);
                    break;
                }
            }
            return obj;
        }
    }


    [Serializable]
    public class DMHoaDon_KhoKhoaList: List<DMHoaDon_KhoKhoa>
    {
        public static DMHoaDon_KhoKhoaList GetAll(String MaKho, Boolean RoleAdmin)
        {
            DMHoaDon_KhoKhoaList obj = new DMHoaDon_KhoKhoaList();
            using (IDataReader dr = SqlHelper.ExecuteReader(ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString(), "spDMHoaDon_KhoKhoa_GetAll", MaKho, RoleAdmin))
            {
                int STT = 1;
                while (dr.Read())
                {
                    obj.Add(new DMHoaDon_KhoKhoa(dr, STT));
                    STT++;
                }
            }
            return obj;
        }

        public String SaveList()
        {
            String sError = "Không cập nhật được phiếu: ";
            Boolean bError = false;
            foreach (var item in this)
            {             
                item.Huy = !item.IsKhoKhoaEdit;
                if (!item.Update())
                {
                    sError += "có khoa là '" + item.TenKhoa + "', ";
                    bError = true;
                }
            }
            if (bError)
            {
                return sError;
            }
            else
            {
                return "";
            }
        }
    }

}
