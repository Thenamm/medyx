using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HSBAQuanLyNguoiBenh
/// </summary>
public class HSBAQuanLyNguoiBenh
{
    private static HL7CoreHueDataContext db = new HL7CoreHueDataContext();
    public HSBAQuanLyNguoiBenh(string MaBa)
    {
        var query = from p in db.BenhANs
                    join bak in db.BenhAnKhoas on p.MaBA equals bak.MaBA
                    join pk in db.BenhAn_PKs on p.MaBA equals pk.MaBANoiTru
                    join noikham in db.DanhMucNoiKhams on pk.MaNoiKham equals noikham.MaNoiKham
                    into gr1
                    from a in gr1.DefaultIfEmpty()
                    join noigt in db.DanhMucNoiGTs on pk.MaNoiGT equals noigt.MaNoiGT
                    into gr2
                    from b in gr2.DefaultIfEmpty()
                    where p.MaBA == MaBa & bak.STTKhoa == 1
                    select new { p, a.MaNoiKham, a.TenNoiKham, b.MaNoiGT, b.TenNoiGT, pk.VaoLan };
        var obj = query.SingleOrDefault();
        if (obj != null)
        {
            NgayGioVaoVien = ((DateTime)obj.p.NgayVV).ToString("dd-MM-yyyy HH:mm");
            TenNoiKham = obj.TenNoiKham;
            MaNoiKham = obj.MaNoiKham;
            TenNoiGioiThieu = obj.TenNoiGT;
            MaNoiGioiThieu = obj.MaNoiGT;
            VaoVienLanThu = obj.VaoLan.ToString();
        }
    }
    public string NgayGioVaoVien { get; set; }
    public string TenNoiKham { get; set; }
    public string MaNoiKham { get; set; }
    public string TenNoiGioiThieu { get; set; }
    public string MaNoiGioiThieu { get; set; }
    public string VaoVienLanThu { get; set; }



}