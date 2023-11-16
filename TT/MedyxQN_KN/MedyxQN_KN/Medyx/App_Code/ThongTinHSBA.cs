using System.Linq;

/// <summary>
/// Summary description for ThongTinHSBA
/// </summary>
public class ThongTinHSBA
{
    public ThongTinHSBA()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private HL7CoreHueDataContext db = new HL7CoreHueDataContext();

    private object LoadThongTinHanhChinh(string MaBN, string MaBA)
    {
        var query =
            from p in db.ThongTinBenhNhans
            join n in db.DanhMucNgheNghieps on p.MaNN equals n.MaNN
            into gr1
            from a in gr1.DefaultIfEmpty()
            join t in db.DanhMucTinhs on p.MaTinh equals t.MaTinh
            into gr2
            from b in gr2.DefaultIfEmpty()
            join h in db.DanhMucQuanHuyens on p.MaHuyen equals h.MaQH
            into gr3
            from c in gr3.DefaultIfEmpty()
            join px in db.DanhMucPhuongXas on p.MaPXa equals px.MaPXa
            into gr4
            from d in gr4.DefaultIfEmpty()
            join dt in db.DanhMucDantocs on p.MaDanToc equals dt.MaDanToc
            into gr5
            from e in gr5.DefaultIfEmpty()
            join qg in db.DanhMucQuocGias on p.MaQG equals qg.MaQG
            into gr6
            from f in gr6.DefaultIfEmpty()
            join doituong in db.DanhMucDoiTuongs on p.MaDT equals doituong.MaDT
            into gr7
            from g in gr7.DefaultIfEmpty()
            join ba in db.BenhANs on p.MaBN equals ba.MaBN
            into gr8
            from h in gr8.DefaultIfEmpty()
            where p.MaBN == MaBN & h.MaBA == MaBA // hơi thừa nhưng kệ :D
            select new { p, d.TenPXa, GiaTriTheDN = (h.GiatriDN), GiaTriTheTN = (h.GiaTriTN), SoThe = (h.Sothe == null ? string.Empty : h.Sothe), TenNgheNghiep = a.TenNN, TenDanToc = e.TenDanToc, f.TenQG, g.TenDT, b.TenTinh, c.TenQH };
        var obj = query.SingleOrDefault();
        return obj;
    }

    private object LoadThongTinQuanLyNguoiBenh(string MaBN, string MaBA)
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
                    where p.MaBA == MaBA & bak.STTKhoa == 1
                    select new { p, a.MaNoiKham, a.TenNoiKham, b.MaNoiGT, b.TenNoiGT, pk.VaoLan };
        var obj = query.SingleOrDefault();
        return obj;
    }

    private object LoadQuanLyNguoiBenhRaVien(string MaBa)
    {
        var query = from p in db.BenhAn_PKs
                    join cv in db.DanhMucHuongDTs on p.MaHDT equals cv.MaHDT
                    into gr1
                    from a in gr1.DefaultIfEmpty()
                    join dmbv in db.DanhMucBenhViens on p.MaNoiChuyen equals dmbv.MaBV
                    into gr2
                    from b in gr2.DefaultIfEmpty()
                    where p.MaBANoiTru == MaBa
                    select new { p, TenNoiChuyen = (b.TenBV == null ? string.Empty : b.TenBV), TenLoaiChuyenVien = (a.TenHDT == null ? string.Empty : a.TenHDT) };
        var obj = query.SingleOrDefault();
        return obj;
    }
}