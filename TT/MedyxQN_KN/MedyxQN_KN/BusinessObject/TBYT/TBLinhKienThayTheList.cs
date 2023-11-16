using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBLinhKienThayTheList // Dùng cho thiết bị đi kèm
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DataTable getAll(String maTB, Boolean qAdmin)
        {
            return SqlHelper.ExecuteDataset(ConnectString, "dbo.spTBLINHKIENDIKEM_GETALL", qAdmin, maTB).Tables[0];
        }

        public static void Delete(Decimal STT)
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBLINHKIENDIKEM_DELETED", STT);
        }

        public static Decimal Update(String _maTB, Decimal STT, String TenLinhKien, Decimal soluong, String serialNo, String model, int baoHanh, String ghichu, bool huy, String NguoiSD)
        {
            return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBLINHKIENDIKEM_UPDATE", _maTB, STT, TenLinhKien, soluong, serialNo, model, baoHanh, ghichu, huy, NguoiSD)));
        }

        public static String Insert(String _maTB, String TenLinhKien, Decimal soluong, String serialNo, String model, int baoHanh, String ghichu)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBLINHKIENDIKEM_CREATE", _maTB, TenLinhKien, soluong, serialNo, model, baoHanh, ghichu));
        }

    }
}
