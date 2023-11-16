using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for Dzual_FunctionBase
/// </summary>
namespace Dzual.CategoryList
{
    public class FunctionBase
    {
        public FunctionBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }


        public static List<Dzual_NameField> GetFieldTable(DataTable dt)
        {
            List<Dzual_NameField> list = new List<Dzual_NameField>();
            Dzual_NameField itemValue;
            for (int order = 0; order < dt.Columns.Count; order++)
            {
                itemValue = new Dzual_NameField(order, false, dt.Columns[order].ColumnName);
                list.Add(itemValue);
            }
            return list;
        }


        public static DataTable GetBC_TBYTGetDM(Boolean Loai, String MaTBYT, String MaNhom, String MaDVSD, String MaNoiSua, String Model,
            String MaNSX, Nullable<Int32> NamSXBD, Nullable<Int32> NamSXKT, String MaNCC, String MaNguonKP, Nullable<Decimal> GiaBD, Nullable<Decimal> GiaKT,
            Nullable<DateTime> NgayMuaBD, Nullable<DateTime> NgayMuaKT, Nullable<DateTime> NgaySDBD, Nullable<DateTime> NgaySDKT, Nullable<Int32> KhauHaoBD, Nullable<Int32> KhauHaoKT, String TinhTrangTB, Nullable<Decimal> TanSuatSDBD, Nullable<Decimal> TanSuatSDKT )
        {
            DataSet ds = SqlHelper.ExecuteDataset(ConnectString, "spBC_TBYTGetDM", Loai, MaTBYT, MaNhom, MaDVSD, MaNoiSua, Model,
                MaNSX, NamSXBD, NamSXKT, MaNCC, MaNguonKP, GiaBD, GiaKT, NgayMuaBD, NgayMuaKT, NgaySDBD, NgaySDKT, KhauHaoBD, KhauHaoKT, TinhTrangTB, TanSuatSDBD, TanSuatSDKT);
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
            
        }

        public static DataTable GetBC_TBPhieuSuaChua(Boolean Loai, String MaTBYT, String MaNhom, String MaDVSD, String MaNoiSua, String Model,
            String MaNSX, Nullable<Int32> NamSXBD, Nullable<Int32> NamSXKT, String MaNCC, String MaNguonKP, Nullable<Decimal> GiaBD, Nullable<Decimal> GiaKT,
            Nullable<DateTime> NgayMuaBD, Nullable<DateTime> NgayMuaKT, Nullable<DateTime> NgaySDBD, Nullable<DateTime> NgaySDKT, Nullable<Int32> KhauHaoBD,
            Nullable<Int32> KhauHaoKT, String TinhTrangTB, Nullable<Decimal> TanSuatSDBD, Nullable<Decimal> TanSuatSDKT, String MaKhoaPhongYC, Nullable<DateTime> NgayDuyetYC,
            Nullable<Byte> MaTinhTrangYC, Boolean IsDuTru, Boolean IsKhaoSat, Nullable<Byte> KinhPhiVT, Nullable<Decimal> KinhPhiBD, Nullable<Decimal> KinhPhiKT, Nullable<Int32> NgayTH_LanBD, Nullable<Int32> NgayTH_LanKT, Nullable<Int32> NgayTH_TBBD, Nullable<Int32> NgayTB_TBKT, Nullable<Int32> LanHuHongBT, Nullable<Int32> LanHuHongKT)
        {
            DataSet ds = SqlHelper.ExecuteDataset(ConnectString, "spBC_TBYTGetSuaChua", Loai, MaTBYT, MaNhom, MaDVSD, MaNoiSua, Model, MaNSX, NamSXBD, NamSXKT,
                MaNCC, MaNguonKP, GiaBD, GiaKT, NgayMuaBD, NgayMuaKT, NgaySDBD, NgaySDKT, KhauHaoBD, KhauHaoKT, TinhTrangTB, TanSuatSDBD, TanSuatSDKT, MaKhoaPhongYC, NgayDuyetYC,
                MaTinhTrangYC, IsDuTru, IsKhaoSat, KinhPhiVT, KinhPhiBD, KinhPhiKT, NgayTH_LanBD, NgayTH_LanKT, NgayTH_TBBD, NgayTB_TBKT, LanHuHongBT, LanHuHongKT);
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        public static DataTable GetBC_TBPhieuBaoTri(Boolean Loai, String MaTBYT, String MaNhom, String MaDVSD, String MaNoiSua, String Model,
            String MaNSX, Nullable<Int32> NamSXBD, Nullable<Int32> NamSXKT, String MaNCC, String MaNguonKP, Nullable<Decimal> GiaBD, Nullable<Decimal> GiaKT,
            Nullable<DateTime> NgayMuaBD, Nullable<DateTime> NgayMuaKT, Nullable<DateTime> NgaySDBD, Nullable<DateTime> NgaySDKT, Nullable<Int32> KhauHaoBD,
            Nullable<Int32> KhauHaoKT, String TinhTrangTB, Nullable<Decimal> TanSuatSDBD, Nullable<Decimal> TanSuatSDKT, Nullable<Byte> LoaiTB, Nullable<DateTime> NgayBaoTriBD, 
            Nullable<DateTime> NgayBaoTriKT, String MaDVBaoTri, Boolean IsDuTruVatTu, String MaVT)
        {
            DataSet ds = SqlHelper.ExecuteDataset(ConnectString, "spBC_TBYTGetBaoTri", Loai, MaTBYT, MaNhom, MaDVSD, MaNoiSua, Model, MaNSX, NamSXBD, NamSXKT,
                MaNCC, MaNguonKP, GiaBD, GiaKT, NgayMuaBD, NgayMuaKT, NgaySDBD, NgaySDKT, KhauHaoBD, KhauHaoKT, TinhTrangTB, TanSuatSDBD, TanSuatSDKT, LoaiTB, NgayBaoTriBD,
            NgayBaoTriKT, MaDVBaoTri, IsDuTruVatTu, MaVT);
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        public static DataTable GetBC_DMTBVTYT(Nullable<Boolean> Loai, String MaNhom, String MaQG, String MaNSX, String MaDVT, String MaNoiSua, Nullable<Byte> LoaiVT, String MaNguonKP, Nullable<Decimal> GiaBD, Nullable<Decimal> GiaKT, Nullable<DateTime> NgaySDBD, Nullable<DateTime> NgaySDKT)
        {
            DataSet ds = SqlHelper.ExecuteDataset(ConnectString, "spBC_DMTBVTYT", Loai, MaNhom, MaQG, MaNSX, MaDVT, MaNoiSua, LoaiVT, MaNguonKP, GiaBD, GiaKT, NgaySDBD, NgaySDKT);
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }
            
    }

    [Serializable]
    public class Dzual_NameField
    {
        public int OrderNumber
        {
            get;
            set;
        }

        public Boolean Checked
        {
            get;
            set;
        }

        public String NameField
        {
            get;
            set;
        }

        public Dzual_NameField()
        {
            OrderNumber = 0;
            Checked = false;
            NameField = "";
        }

        public Dzual_NameField(int OrderNumber, Boolean Checked, String NameField)
        {
            this.OrderNumber = OrderNumber;
            this.NameField = NameField;
            this.Checked = Checked;
        }
    }    
}