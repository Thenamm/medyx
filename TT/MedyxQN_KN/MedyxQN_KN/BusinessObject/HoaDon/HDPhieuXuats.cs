using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuXuats : List<HDPhieuXuat>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static HDPhieuXuats GetALL(DateTime TUNGAY, DateTime DENNGAY, String MAKHO, Byte LOAI, Boolean DAPHAT, Boolean DADUYET, String DK, Boolean QADMIN)
        {
            HDPhieuXuats obj = new HDPhieuXuats();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuXuat_GETALL", TUNGAY, DENNGAY, MAKHO, LOAI, DAPHAT, DADUYET, DK, QADMIN))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new HDPhieuXuat(dr, stt));
                    stt++;
                }
            }
            return obj;
        }


        public static void HDImportXNTKho(DateTime TuNgay, DateTime DenNgay, String MaKho, Byte Loai)
        {
            DateTime i = TuNgay;
            while ( i <= DenNgay)
            {
                HDImportXNTKhoCT(i, MaKho, Loai);
                i = i.AddDays(1);
            }
        }

        public static void HDImportXNTKhoCT(DateTime TuNgay, String MaKho, Byte Loai)
        {
            //Xóa file cũ đi
            //SqlHelper.ExecuteNonQuery(strConnect, "spHDImportXNTKho", TuNgay, TuNgay, MaKho, Loai);

            List<hdImport> ds1 = spKHAMBENH_HoaDon_GETshd(TuNgay, TuNgay);
            List<hdImport> ds2 = spBenhAn_HoaDon_GETAll(TuNgay, TuNgay);
            Boolean Start = true;
            HDPhieuXuat _hdPhieuXuat = new HDPhieuXuat();
            if ((ds1 != null && ds1.Count > 0) || (ds2 != null && ds2.Count > 0))
            {
                _hdPhieuXuat = new HDPhieuXuat()
                {
                    NoiXuat = MaKho,
                    Loaiphieu = Loai,
                    NgayXuat = DateTime.Now.ToString("dd/MM/yyyy"),
                    IsDuTru = false,
                    DaPhat = true,
                    DaDuyet = true,
                    NgayXuatTT = DateTime.Now.ToString("dd/MM/yyyy"),
                    NoiNhap = "",
                    SoCT = "",
                    NVXuat = "",
                    NVNhan = "",
                    Ghichu = "Xuất sử dụng",
                    MaMay = "",
                    NguoiLap = ""
                };
                _hdPhieuXuat.MaPX = _hdPhieuXuat.Insert();
            }
            else
            {
                return;
            }

            HDPhieuXuat_C _hdPhieuXuat_C = new HDPhieuXuat_C();
            foreach (var row in ds1)
            {
                if(Start)               
                {
                    _hdPhieuXuat_C.MaPX = _hdPhieuXuat.MaPX;
                    _hdPhieuXuat_C.KyHieuMau = "";
                    _hdPhieuXuat_C.KyHieu = row.KyHieu;
                    _hdPhieuXuat_C.TuSo = row.SoHD;
                    _hdPhieuXuat_C.DenSo = row.SoHD;
                    _hdPhieuXuat_C.SLYC = 1;
                    _hdPhieuXuat_C.GiaBan = 1;
                    _hdPhieuXuat_C.Ghichu = "";
                    _hdPhieuXuat_C.NguoiLap = "";
                    _hdPhieuXuat_C.MaMay = "";
                    Start = false;
                }
                else
                {
                    if(row.SoHD == _hdPhieuXuat_C.DenSo + 1 && row.KyHieu == _hdPhieuXuat_C.KyHieu)
                    {
                        _hdPhieuXuat_C.DenSo = row.SoHD;
                        Start = false;
                    }
                    else
                    {
                        _hdPhieuXuat_C.Insert();

                        _hdPhieuXuat_C = new HDPhieuXuat_C();
                        _hdPhieuXuat_C.MaPX = _hdPhieuXuat.MaPX;
                        _hdPhieuXuat_C.KyHieuMau = "";
                        _hdPhieuXuat_C.KyHieu = row.KyHieu;
                        _hdPhieuXuat_C.TuSo = row.SoHD;
                        _hdPhieuXuat_C.DenSo = row.SoHD;
                        _hdPhieuXuat_C.SLYC = 1;
                        _hdPhieuXuat_C.GiaBan = 1;
                        _hdPhieuXuat_C.Ghichu = "";
                        _hdPhieuXuat_C.NguoiLap = "";
                        _hdPhieuXuat_C.MaMay = "";
                        Start = false;

                    }
                }
            }
            _hdPhieuXuat_C.Insert();

            _hdPhieuXuat_C = new HDPhieuXuat_C();
            foreach (var row in ds2)
            {
                if (Start)
                {
                    _hdPhieuXuat_C.MaPX = _hdPhieuXuat.MaPX;
                    _hdPhieuXuat_C.KyHieuMau = "";
                    _hdPhieuXuat_C.KyHieu = row.KyHieu;
                    _hdPhieuXuat_C.TuSo = row.SoHD;
                    _hdPhieuXuat_C.DenSo = row.SoHD;
                    _hdPhieuXuat_C.SLYC = 1;
                    _hdPhieuXuat_C.GiaBan = 1;
                    _hdPhieuXuat_C.Ghichu = "";
                    _hdPhieuXuat_C.NguoiLap = "";
                    _hdPhieuXuat_C.MaMay = "";
                    Start = false;
                }
                else
                {
                    if (row.SoHD == _hdPhieuXuat_C.DenSo + 1 && row.KyHieu == _hdPhieuXuat_C.KyHieu)
                    {
                        _hdPhieuXuat_C.DenSo = row.SoHD;
                        Start = false;
                    }
                    else
                    {
                        _hdPhieuXuat_C.Insert();

                        _hdPhieuXuat_C = new HDPhieuXuat_C();
                        _hdPhieuXuat_C.MaPX = _hdPhieuXuat.MaPX;
                        _hdPhieuXuat_C.KyHieuMau = "";
                        _hdPhieuXuat_C.KyHieu = row.KyHieu;
                        _hdPhieuXuat_C.TuSo = row.SoHD;
                        _hdPhieuXuat_C.DenSo = row.SoHD;
                        _hdPhieuXuat_C.SLYC = 1;
                        _hdPhieuXuat_C.GiaBan = 1;
                        _hdPhieuXuat_C.Ghichu = "";
                        _hdPhieuXuat_C.NguoiLap = "";
                        _hdPhieuXuat_C.MaMay = "";
                        Start = false;

                    }
                }
            }
            _hdPhieuXuat_C.Insert();
        }

        public static List<hdImport> spKHAMBENH_HoaDon_GETshd(DateTime TuNgay, DateTime DenNgay)
        {        
            var list = new List<hdImport>();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spKHAMBENH_HoaDon_GETshd", TuNgay, DenNgay, (Byte)9, (Byte)0, ""))
            {
                while (dr.Read())
                {
                    list.Add(new hdImport() { SoHD = Convert.ToDecimal(dr["SoHD"]), KyHieu = Convert.ToString(dr["SoSoHD"]) });
                }
            }

            for(int i =0; i< list.Count - 1; i ++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if(list[i].SoHD > list[j].SoHD)
                    {
                        hdImport tg = list[i];
                        list[i] = list[j];
                        list[j] = tg;
                    }
                }
            }
            return list;
        }

        public static List<hdImport> spBenhAn_HoaDon_GETAll(DateTime TuNgay, DateTime DenNgay)
        {
            var list = new List<hdImport>();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spBenhAn_HoaDon_GETAll", TuNgay, DenNgay, (Byte)2, ""))
            {
                while (dr.Read())
                {
                    list.Add(new hdImport() { SoHD = Convert.ToDecimal(dr["SoHD"]), KyHieu = Convert.ToString(dr["SoSoHD"])});
                }
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].SoHD > list[j].SoHD)
                    {
                        hdImport tg = list[i];
                        list[i] = list[j];
                        list[j] = tg;
                    }
                }
            }
            return list;
        }

        [Serializable()]
       public class hdImport
        {
            public Decimal SoHD { get; set; }
            public String KyHieu { get; set; }
            public hdImport()
            {

            }

            public hdImport(Decimal SoHD, String KyHieu)
            {
                this.SoHD = SoHD;
                this.KyHieu = KyHieu;
            }
        }
    }
}