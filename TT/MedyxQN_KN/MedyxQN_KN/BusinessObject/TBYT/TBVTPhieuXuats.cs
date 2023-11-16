using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using System.Data;
using HTC.Business;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTPhieuXuats : List<TBVTPhieuXuat>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBVTPhieuXuats()
        {

        }

        public static TBVTPhieuXuats GetAll(String Account, String MaKho, Byte Loai, Boolean Daduyet, Boolean DaPhat, DateTime TuNgay, DateTime DenNgay)
        {
            TBVTPhieuXuats List = new TBVTPhieuXuats();
            int STT = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_GETALL", Account, MaKho, Loai, Daduyet, DaPhat, TuNgay, DenNgay)))
            {
                while (dr.Read())
                {
                    STT++;
                    List.Add(new TBVTPhieuXuat(dr, STT));
                }
            }
            return List;
        }

        public static TBVTPhieuXuats GetAll(String Account, String MaKho, Byte Loai, Boolean Daduyet, Boolean DaPhat, DateTime TuNgay, DateTime DenNgay, Boolean isDoniSuaChua)
        {
            TBVTPhieuXuats List = new TBVTPhieuXuats();
            int STT = 0;
            int STT1 = 0;
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_GETALL", Account, MaKho, Loai, Daduyet, DaPhat, TuNgay, DenNgay)))
            {
                while (dr.Read())
                {
                    if (Loai / 10 == 3 || Loai / 10 == 6 || Loai / 10 == 4)
                    {
                        if (isDoniSuaChua && Convert.ToString(dr["Noixuat"]).Length >= 3 && Convert.ToString(dr["Noixuat"]).Substring(0, 3) == "017")
                        {
                            STT1++;
                            List.Add(new TBVTPhieuXuat(dr, STT1));
                        }
                        else if (!isDoniSuaChua && (Convert.ToString(dr["Noixuat"]).Length < 3 || Convert.ToString(dr["Noixuat"]).Substring(0, 3) != "017"))
                        {
                            STT++;
                            List.Add(new TBVTPhieuXuat(dr, STT));
                        }
                    }
                    else if (Loai / 10 == 2)
                    {
                        if (isDoniSuaChua && Convert.ToString(dr["Noinhap"]).Length >= 3 && Convert.ToString(dr["Noinhap"]).Substring(0, 3) == "017")
                        {
                            STT1++;
                            List.Add(new TBVTPhieuXuat(dr, STT1));
                        }
                        else if (!isDoniSuaChua && (Convert.ToString(dr["Noinhap"]).Length < 3 || Convert.ToString(dr["Noinhap"]).Substring(0, 3) != "017"))
                        {
                            STT++;
                            List.Add(new TBVTPhieuXuat(dr, STT));
                        }
                    }
                    else // chưa có chức năng xuất từ đơn vị sửa chữa cho đơn vị sửa chữa
                    {
                            STT++;
                            List.Add(new TBVTPhieuXuat(dr, STT));                        
                    }
                    
                }
            }
            return List;
        }
    }
}
