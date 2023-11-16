using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HTC.Business.CategoryList
{
    [Serializable]
    public class DMGia_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaDT { get; set; }
        public Decimal HesoDV { get; set; }
        public Decimal HesoPT { get; set; }
        public Decimal HesoGiuong { get; set; }

        public DMGia_H()
        {
            MaDT = "";
            HesoDV = new Decimal();
            HesoPT = new Decimal();
            HesoGiuong = new Decimal();
            Ordernumber = 0;
        }
        public DMGia_H(String MaDT, Decimal HesoDV, Decimal HesoPT, Decimal HesoGiuong, Int32 Ordernumber)
        {
            this.MaDT = MaDT;
            this.HesoDV = HesoDV;
            this.HesoPT = HesoPT;
            this.HesoGiuong = HesoGiuong;
            this.Ordernumber = Ordernumber;
        }
        public DMGia_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaDT"].GetType().Name != "DBNull" && dr["MaDT"] != null)
            {
                this.MaDT = Convert.ToString(dr["MaDT"]);
            }
            else
            {
                this.MaDT = "";
            }
            if (dr["HesoDV"].GetType().Name != "DBNull" && dr["HesoDV"] != null)
            {
                this.HesoDV = Convert.ToDecimal(dr["HesoDV"]);
            }
            else
            {
                this.HesoDV = new Decimal();
            }
            if (dr["HesoPT"].GetType().Name != "DBNull" && dr["HesoPT"] != null)
            {
                this.HesoPT = Convert.ToDecimal(dr["HesoPT"]);
            }
            else
            {
                this.HesoPT = new Decimal();
            }
            if (dr["HesoGiuong"].GetType().Name != "DBNull" && dr["HesoGiuong"] != null)
            {
                this.HesoGiuong = Convert.ToDecimal(dr["HesoGiuong"]);
            }
            else
            {
                this.HesoGiuong = new Decimal();
            }
            this.Ordernumber = Ordernumber;
        }
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }
        public static DMGia_H Get()
        {
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, CommandType.Text, "SELECT MaDT, HesoDV, HesoPT, HesoGiuong  From DMDoiTuong WHERE MaDT in (SELECT Top 1 MaDTTuTuc FROM ThamSo)"))
            {
                while (dr.Read())
                {
                    return new DMGia_H(dr, 0);
                }
            }
            return new DMGia_H();
        }

        public static DMGia_H GetByDT(String MaDT)
        {
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, CommandType.Text, "SELECT MaDT, HesoDV, HesoPT, HesoGiuong  From DMDoiTuong WHERE MaDT ='" + MaDT + "'"))
            {
                while (dr.Read())
                {
                    return new DMGia_H(dr, 0);
                }
            }
            return new DMGia_H();
        }
    }
}
