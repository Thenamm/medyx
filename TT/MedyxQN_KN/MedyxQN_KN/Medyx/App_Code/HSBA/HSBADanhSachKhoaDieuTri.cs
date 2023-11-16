using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HSBADanhSachKhoaDieuTri
/// </summary>
public class HSBADanhSachKhoaDieuTri
{

    public HSBADanhSachKhoaDieuTri()
    {

    }
    public static List<HSBAKhoaDieuTri> GetDanhSachKhoaDieuTri(string maBA)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())

        {
            List<HSBAKhoaDieuTri> List = new List<HSBAKhoaDieuTri>();

            var query = from p in db.BenhAnKhoas
                        join dm in db.DanhMucKhoas on p.MaKhoa equals dm.MaKhoa
                        into gr1
                        from a in gr1.DefaultIfEmpty()
                        join nv in db.DanhMucNhanViens on p.BSDieuTri equals nv.MaNV
                        into gr2
                        from b in gr2.DefaultIfEmpty()
                        where p.MaBA == maBA
                        orderby p.STTKhoa ascending
                        select new { p, a.TenKhoa, BacSyDieuTri = b.HoTen };
            var listObj = query.ToList();

            // Mục đích của đoạn code này là vì dữ liệu không được chuẩn cần convert lại

            for (int i = 0; i < listObj.Count; i++)
            {
                HSBAKhoaDieuTri obj = new HSBAKhoaDieuTri();
                obj.STT = i + 1;
                obj.MaKhoa = listObj[i].p.MaKhoa;
                obj.TenKhoa = listObj[i].TenKhoa;
                obj.NgayGioVaoKhoa = listObj[i].p.NgayVKhoa.ToString("dd-MM-yyyy HH:mm");
                if (i == listObj.Count - 1) // Ngày ra cuối cùng
                {
                    if (listObj[i].p.NgayKT != null)
                        obj.NgayGioRaKhoa = ((DateTime)listObj[i].p.NgayKT).ToString("dd-MM-yyyy HH:mm");
                }
                else // Các ngày ra tiếp
                {
                    if (listObj[i + 1].p.NgayVKhoa != null)
                        obj.NgayGioRaKhoa = listObj[i + 1].p.NgayVKhoa.ToString("dd-MM-yyyy HH:mm");
                }
                obj.BacSyDieuTri = listObj[i].BacSyDieuTri;
                obj.STTKhoa = listObj[i].p.STTKhoa;
                obj.MaBa = listObj[i].p.MaBA;
                List.Add(obj);
            }
            return List;
        }

    }



}