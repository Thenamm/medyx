using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKHBaoTri
    {
        public Int32 Ordernumber { get; set; }
        public Byte MaKHBaoTri { get; set; }
        public Int32 ThoigianTH { get; set; }
        public String KeHoach { get; set; }
        public Byte Loai { get; set; }
        public Boolean Huy { get; set; }

        public DMKHBaoTri()
        {
            MaKHBaoTri = 0;
            ThoigianTH = 0;
            KeHoach = "";
            Loai = 0;
            Huy = false;
            Ordernumber = 0;
        }

        public DMKHBaoTri(Byte MaKHBaoTri, Int32 ThoigianTH, String KeHoach, Byte Loai, Boolean Huy, Int32 Ordernumber)
        {
            this.MaKHBaoTri = MaKHBaoTri;
            this.ThoigianTH = ThoigianTH;
            this.KeHoach = KeHoach;
            this.Loai = Loai;
            this.Huy = Huy;
            this.Ordernumber = Ordernumber;
        }
        
        public DMKHBaoTri(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaKHBaoTri"].GetType().Name != "DBNull" && dr["MaKHBaoTri"] != null)
            { this.MaKHBaoTri = Convert.ToByte(dr["MaKHBaoTri"]); }
            else
            {
                MaKHBaoTri = 0;
            }
            if (dr["ThoigianTH"].GetType().Name != "DBNull" && dr["ThoigianTH"] != null)
            { this.ThoigianTH = Convert.ToInt32(dr["ThoigianTH"]); }
            else
            {
                ThoigianTH = 0;
            }
            if (dr["KeHoach"].GetType().Name != "DBNull" && dr["KeHoach"] != null)
            { this.KeHoach = Convert.ToString(dr["KeHoach"]); }
            else
            {
                KeHoach = "";
            }
            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            { this.Loai = Convert.ToByte(dr["Loai"]); }
            else
            {
                Loai = 0;
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
            }
            this.Ordernumber = Ordernumber;
        }
    }


    [Serializable()]
    public class DMKHBaoTriList: List<DMKHBaoTri>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMKHBaoTriList GetAll(Boolean qAdmin)
        {
            DMKHBaoTriList List = new DMKHBaoTriList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMKHBaoTri_GetAll", qAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMKHBaoTri(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
