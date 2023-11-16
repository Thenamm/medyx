using DTT.HL7Core;
using HTC.Common.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;

/// <summary>
/// Summary description for HL7ServiceHue
/// </summary>
public abstract class HL7ServiceSan : WebBase, IDisposable
{

    private HL7CoreHueDataContext _dbContext;
    public HL7ServiceSan()
    {
        _dbContext = new HL7CoreHueDataContext();
       

    }
    private bool isDisposed;
    ~HL7ServiceSan()
    {
        Dispose(false);
    }
    public override void Dispose()
    {
        Dispose(true);
        _dbContext.Connection.Close();
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }
    private void Dispose(bool disposing)
    {
        if (!isDisposed && disposing)
        {
            // Cleanup up manager object
            
        }
        isDisposed = true;
    }
    public static string ConvertVN(string chucodau)
    {
        const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
        const string ReplText = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYY";
        int index = -1;
        char[] arrChar = FindText.ToCharArray();
        if (!string.IsNullOrEmpty(chucodau))
        {
            while ((index = chucodau.IndexOfAny(arrChar)) != -1)
            {
                int index2 = FindText.IndexOf(chucodau[index]);
                chucodau = chucodau.Replace(chucodau[index], ReplText[index2]);
            }
            return chucodau;
        }
        else
            return "";
    }
    public bool CheckViewAnhXa(string Maba)
    {
        bool Result = true;
        try
        {
            Session["ListMapping"] = null;
            DBConnectionDataContext db = new DBConnectionDataContext();
            List<emrMappingDetail> list = new List<emrMappingDetail>();
            System.Data.Linq.ISingleResult<sp_ViewMappingResult> view = db.sp_ViewMapping(Maba);
            foreach (sp_ViewMappingResult item in view)
            {
                emrMappingDetail detail = new emrMappingDetail();
                try
                {
                    detail.ID = int.Parse(item.ID.ToString());
                }
                catch (Exception)
                {
                    detail.ID = 0;
                }
                detail.DanhMucName = item.DanhMucName;
                detail.MaDTT = item.MaDTT;
                detail.MaDanhMuc = item.MaDanhMuc;
                detail.TenDTT = item.TenDTT;
                detail.TenHT = item.TenHT;
                detail.HTTableName = item.HTTableName;
                detail.HaThangCategoryItemMa = item.HaThangCategoryItemMa;
                if (!list.Contains(detail))
                {
                    list.Add(detail);
                }
            }

            foreach (emrMappingDetail item in list)
            {
                if (item != null)
                    if (item.MaDTT == null || string.IsNullOrEmpty(item.MaDTT))
                        Result = false;
            }
            return Result;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #region Hàm chỉ đúng với input 0x sai khi có dạng 0xx
    private String SapXepDESC(List<string> input)
    {
        string outPut = string.Empty;
        List<int> INPUT = new List<int>();
        foreach (string item in input)
        {
            INPUT.Add(int.Parse(item));
        }
        for (int i = 0; i < INPUT.Count - 1; i++)
        {
            for (int j = i + 1; j < INPUT.Count; j++)
            {
                int A = INPUT[j];
                int B = INPUT[j - 1];
                if (INPUT[j] < INPUT[i])
                {
                    int temp = INPUT[i];
                    INPUT[i] = INPUT[j];
                    INPUT[j] = temp;
                }
            }
        }
        foreach (int item in INPUT)
        {
            if (item < 10)
                outPut += "0" + item + "|";
            else
                outPut += item + "|";
        }
        if (outPut.Length > 0)
            return outPut.Substring(0, outPut.Length - 1);
        return string.Empty;

    }
    #endregion

    #region Hàm Convert Chuỗi ID theo danh mục trả về 1 chuỗi ID theo định dạng format của DTT cũng có  thể convert 1 id:)
    private String ConvertChuoiStringID(string str, string MaDanhMuc) // Check null empty 
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString);
        con.Open();
        String NewString = String.Empty;
        List<String> listResult = new List<string>();
        if (str != null)
        {
            string[] chuoiString = str.Split(',');
            foreach (string s in chuoiString)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    DBConnectionDataContext db = new DBConnectionDataContext();
                    System.Data.Linq.ISingleResult<sp_GetAllDetailMappingByHTKeyAndDMKeyResult> list = db.sp_GetAllDetailMappingByHTKeyAndDMKey(s.Trim(), MaDanhMuc);
                    foreach (sp_GetAllDetailMappingByHTKeyAndDMKeyResult item in list)
                    {
                        string IdConvert = item.MaKeyDTT;
                        listResult.Add(IdConvert);
                        NewString = NewString + IdConvert + "|";
                    }
                }
            }
            if (NewString.Length > 0)
            {
                return SapXepDESC(listResult);
            }
            else
            {
                return String.Empty;
            }
        }
        else
            con.Close();
        return string.Empty;
    }
    #endregion

    #region Insert history transferHSBA
    private void InserttblHSBATransferHistory(String MaHSBA, String MaYC, String MaNV, String MaLoaiBA, String DuLieu, DateTime NgayTruyen, Boolean Status)
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HTCDbContext"].ConnectionString);
        try
        {
            con.Open();
            SqlCommand com = new SqlCommand("sp_InserttblHSBATransferHistory", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaBA", SqlDbType.NVarChar).Value = MaHSBA;
            com.Parameters.Add("@MaYC", SqlDbType.NVarChar).Value = MaYC;
            com.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = MaNV;
            com.Parameters.Add("@MaLoaiBA", SqlDbType.NVarChar).Value = MaLoaiBA;
            com.Parameters.Add("@DuLieu", SqlDbType.Xml).Value = DuLieu;
            com.Parameters.Add("@NgayTruyen", SqlDbType.DateTime).Value = NgayTruyen;
            com.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;
            com.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception)
        {
            con.Close();
        }
        finally
        {
            con.Close();
        }
    }
    #endregion

    #region Convert object to XML
    public String returnObjectToXml(Object obj)
    {
        String outPut = string.Empty;
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(obj.GetType());
        x.Serialize(Console.Out, obj);
        System.IO.StringWriter sww = new System.IO.StringWriter();
        XmlWriter writer = XmlWriter.Create(sww);
        x.Serialize(writer, obj);
        var xml = sww.ToString();
        String HSBA = xml.ToString();
        outPut = xml.ToString();
        return outPut;
    }
    #endregion

    #region TransferHSBa truyền vào 1 mã hsba
    public bool TransferHSBANew(string maHSBA, string MaLoaiBenhAn)
    {
        string MaYc = string.Empty;
        emrDanhSachHoSoBenhAn hsba = new emrDanhSachHoSoBenhAn();

        HTC.Business.Officer.Account user = (HTC.Business.Officer.Account)HTC.Business.Officer.Account.GetAccount(Pub_sAccount);
        try
        {
            try
            {
                hsba = poPulateHSBA(maHSBA, MaLoaiBenhAn);
                String May = String.Empty;
                using (DTT.HL7Core.HisWebservice service = new DTT.HL7Core.HisWebservice())
                {

                    DTT.HL7Core.OpenmrsResponse Result = service.transferHSBA(hsba);

                    if (Result.status.Equals("OK"))
                    {
                        InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, true);
                        ShowMessage("Đã gửi thành công hồ sơ bệnh án sang hệ thống HL7Core bệnh viện !");
                    }
                    else
                    {
                        InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, false);
                        ShowMessage("Gửi hồ sơ bệnh án không thành công !" + Result.errormessage.ToString());
                    }
                    //  HSBALockTableAdapter hsbaAdapter = new HSBALockTableAdapter();
                    //  hsbaAdapter.TransferHSBA(maHSBA, DateTime.Now, Pub_sAccount);
                }
            }
            catch (Exception ex)
            {
                InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, false);
                Response.Write(" Error:" + ex.Message);
                // return false;
            }

            return true;
        }
        catch (Exception)
        {
            //throw;
            return false;
        }
    }
    #endregion

    #region Trả về object DanhSachHSBA
    public emrDanhSachHoSoBenhAn poPulateHSBA(string MaHSBA, string maLoaiBA)
    {

        sp_HSBATransferResult item = _dbContext.sp_HSBATransfer(MaHSBA).DefaultIfEmpty().ToArray()[0];
        emrDanhSachHoSoBenhAn Hsba = new emrDanhSachHoSoBenhAn();
        if (item != null)
        {
            int IdDanhSachHSBA = 0;

            IdDanhSachHSBA = int.Parse(item.IDDanhSachHSBA.ToString());
            if (IdDanhSachHSBA > 0)
            {

                Hsba.emrDmLoaiBenhAn = getEmrDmLoaiBenhAn(item);
                Hsba.emrBenhAn = GetemrBenhAn(IdDanhSachHSBA, MaHSBA, maLoaiBA);
                Hsba.emrQuanLyNguoiBenh = getemrQuanLyNguoiBenh(IdDanhSachHSBA);
                Hsba.emrBenhNhan = GetemrBenhNhan(IdDanhSachHSBA, maLoaiBA, MaHSBA);
                Hsba.emrTongKetRaVien = getemrTongKetRaVien(IdDanhSachHSBA);
                Hsba.emrPhauThuatThuThuats = getemrPhauThuatThuThuats(IdDanhSachHSBA);
                Hsba.emrXetNghiems = getemrXetNghiems(IdDanhSachHSBA);
                Hsba.emrChanDoan = getemrChanDoan(IdDanhSachHSBA, MaHSBA, maLoaiBA);
                Hsba.emrChanDoanHinhAnhs = getemrChanDoanHinhAnhs(IdDanhSachHSBA);
                Hsba.emrHinhAnhTonThuongs = getemrHinhAnhTonThuongs(IdDanhSachHSBA);
                Hsba.emrThamDoChucNangs = getemrThamDoChucNangs(IdDanhSachHSBA);
                Hsba.emrGiaiPhauBenhs = getemrGiaiPhauBenhs(IdDanhSachHSBA);
                Hsba.emrDonThuocs = getemrDonThuocs(IdDanhSachHSBA);
                Hsba.emrVaoKhoas = getemrVaoKhoas(IdDanhSachHSBA);
                Hsba.emrQuanLyFileDinhKemBenhAn = getemrQuanLyFileDinhKemBenhAn(IdDanhSachHSBA);
                Hsba.emrTongKetSanKhoa = getemrTongKetSanKhoa(IdDanhSachHSBA);
                Hsba.mayte = item.mayte; // Mã y tế là mabaql nội trú, ngoại trú SoRaVien

                // Hiện tại không cần truyền thông tin này, phía HL7 sẽ nhập thông tin này.
                // Hsba.maluutru = item.maluutru;
                Hsba.emrTinhTrangRaVien = getemrTinhTrangRaVien(IdDanhSachHSBA);
                Hsba.matraodoi = item.matraodoi + "|" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (_IsBVYHocCoTruyen || _IsBVTWHue)
                {
                    Hsba.emrYhctBenhAn = getemrYhctBenhAn(IdDanhSachHSBA);
                    Hsba.emrYhctNhaBa = getemrYhctNhaBa(IdDanhSachHSBA);
                    Hsba.emrYhctNhaBaGhiChus = getemrYhctNhaBaGhiChus(IdDanhSachHSBA);
                    Hsba.emrYhctDonThuocs = getEmrYhctDonThuocs(IdDanhSachHSBA);
                    //Response.Write("Có vào ");
                    Hsba.emrYhctBenhAn.motachamsoc = "";
                    Hsba.emrYhctChanDoan = GetEmrYhctChanDoan(IdDanhSachHSBA);
                }
            }
        }
        return Hsba;
    }



    private emrQuanLyFileDinhKemBenhAn[] getemrQuanLyFileDinhKemBenhAn(int IdDanhSachHSBA)
    {
        List<emrQuanLyFileDinhKemBenhAn> list = new List<emrQuanLyFileDinhKemBenhAn>();
        var tblFileDInhKemBenhAn = from p in _dbContext.tbl_ID_emrQuanLyFileDinhKemBenhAns where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listitem = tblFileDInhKemBenhAn.DefaultIfEmpty().ToArray();
        foreach (tbl_ID_emrQuanLyFileDinhKemBenhAn item in listitem)
        {
            if (item != null)
            {
                emrQuanLyFileDinhKemBenhAn emrQuanLyFileDinhKemBenhAn = new emrQuanLyFileDinhKemBenhAn();

                emrQuanLyFileDinhKemBenhAn.tenfile = ConvertVN(item.tenfile);
                if (!string.IsNullOrEmpty(item.duongdan))
                    emrQuanLyFileDinhKemBenhAn.noiDungFile = convertBase64ByFile((item.duongdan));
                list.Add(emrQuanLyFileDinhKemBenhAn);
            }

        }

        return list.ToArray();

    }

    private emrYhctDonThuoc[] getEmrYhctDonThuocs(int IdDanhSachHSBA)
    {
        List<emrYhctDonThuoc> list = new List<emrYhctDonThuoc>();
        var tblemryhctDonthuoc = from p in _dbContext.tbl_emrYhctDonThuocs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listitem = tblemryhctDonthuoc.DefaultIfEmpty().ToArray();
        int CountSoDon = 0;
        if (listitem != null)
            foreach (var item in listitem)
            {
                if (item != null)
                {
                    CountSoDon++;
                    emrYhctDonThuoc emrYhctDonThuoc = new emrYhctDonThuoc();
                    emrYhctDonThuoc.bacsikedon = item.bacsikedon;
                    emrYhctDonThuoc.chidan = item.chidan;
                    if (item.ngaybatdaudung != null)
                        emrYhctDonThuoc.ngaybatdaudung = toDateFormat(item.ngaybatdaudung); // ? Transfer by SOAP
                    if (item.ngaykedon != null)
                        emrYhctDonThuoc.ngaykedon = toDateFormat(item.ngaykedon);
                    if (item.ngayketthuc != null)
                        emrYhctDonThuoc.ngayketthuc = toDateFormat(item.ngayketthuc);
                    emrYhctDonThuoc.sodon = CountSoDon.ToString();
                    emrYhctDonThuoc.soluongthang = CheckNull(item.soluongthang);
                    emrYhctDonThuoc.emrYhctDonThuocChiTiets = getemrYhctDonThuocChiTiets(item.IdemrYHCTDonThuoc);
                    list.Add(emrYhctDonThuoc);
                }

            }
        return list.ToArray();
    }
    private emrYhctDonThuocChiTiet[] getemrYhctDonThuocChiTiets(int IdemrYHCTDonThuoc)
    {
        List<emrYhctDonThuocChiTiet> list = new List<emrYhctDonThuocChiTiet>();
        var tblemrYhctDonThuocChiTiet = from p in _dbContext.tbl_emrYHCTDonThuocChiTiets where p.IdemrYHCTDonThuoc == IdemrYHCTDonThuoc select p;
        var ListItem = tblemrYhctDonThuocChiTiet.DefaultIfEmpty().ToArray();
        if (ListItem != null)
            foreach (var item in ListItem)
            {
                if (item != null)
                {
                    emrYhctDonThuocChiTiet emrYhctDonThuocChiTiet = new emrYhctDonThuocChiTiet();
                    emrYhctDonThuocChiTiet.chidandungthuoc = item.chidandungthuoc;
                    emrYhctDonThuocChiTiet.emrDmYhctViThuoc = getemrDmYhctViThuoc(item.emrDmYhctViThuoc);
                    emrYhctDonThuocChiTiet.lieuluongdung = item.lieuluongdung.ToString();
                    emrYhctDonThuocChiTiet.emrDmDuongDungThuoc = getemrDmDuongDungThuoc(item.emrDmDuongDungThuoc);
                    emrYhctDonThuocChiTiet.emrDmTanXuatDungThuoc = getemrDmTanXuatDungThuoc(item.emrDmTanXuatDungThuoc);
                    // ? Transfer by SOAP
                    if (item.ngaybatdau != null)
                        emrYhctDonThuocChiTiet.ngaybatdau = toDateFormat(item.ngaybatdau);
                    if (item.ngaybatdau != null)
                        emrYhctDonThuocChiTiet.ngayketthuc = toDateFormat(item.ngayketthuc);
                    list.Add(emrYhctDonThuocChiTiet);
                }
            }
        // emrYhctDonThuocChiTiet.emrDmYhctViThuoc
        //emrYhctDonThuocChiTiet
        return list.ToArray();
    }

    private emrDmTanXuatDungThuoc getemrDmTanXuatDungThuoc(string emrDmTanXuatDungThuoc)
    {
        emrDmTanXuatDungThuoc dMTanXuat = new emrDmTanXuatDungThuoc();
        dMTanXuat.ma = "1";
        return dMTanXuat;
    }

    private emrDmDuongDungThuoc getemrDmDuongDungThuoc(string emrDmDuongDungThuoc)
    {
        emrDmDuongDungThuoc emrDmDuongDung = new emrDmDuongDungThuoc();
        //  emrDmDuongDungThuoc.ma = getMaDTT(item.emrDmDuongDungThuoc, "DM38");
        emrDmDuongDung.ma = "1";// Tạm thời face để truyền,phía bệnh viện chưa có dữ liệu
        return emrDmDuongDung;
    }

    private emrDmYhctViThuoc getemrDmYhctViThuoc(string p)
    {
        emrDmYhctViThuoc emrDmYhctViThuoc = new emrDmYhctViThuoc();
        emrDmYhctViThuoc.ma = getMaDTT(p, "DM88");
        return emrDmYhctViThuoc;
    }
    private emrYhctChanDoan GetEmrYhctChanDoan(int IdDanhSachHSBA)
    {
        var tbl_emrYhctChanDoan = from p in _dbContext.tbl_emrYhctChanDoans where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrYhctChanDoan.DefaultIfEmpty().ToArray()[0];
        emrYhctChanDoan emrYhctChanDoan = new emrYhctChanDoan();
        if (item != null)
        {
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctravien = getemrDmYhctBenhDanhByIdbenhdanhyhctravien(item.emrDmYhctBenhDanhByIdbenhdanhyhctravien);
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctvaovien = getemrDmYhctBenhDanhByIdbenhdanhyhctvaovien(item.emrDmYhctBenhDanhByIdbenhdanhyhctvaovien);
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctVk = getemrDmYhctBenhDanhByIdbenhdanhyhctVk(item.emrDmYhctBenhDanhByIdbenhdanhyhctVk);
            emrYhctChanDoan.lstbatcuong = ConvertChuoiStringID(item.lstbatcuong, "DM51");
            emrYhctChanDoan.lstbatcuongVv = ConvertChuoiStringID(item.lstbatcuongVv, "DM51");
            emrYhctChanDoan.lstdinhvibenh = ConvertChuoiStringID(item.lstdinhvibenh, "DM54");
            emrYhctChanDoan.lstdinhvibenhVv = ConvertChuoiStringID(item.lstdinhvibenhVv, "DM54");
            emrYhctChanDoan.lstkinhmach = ConvertChuoiStringID(item.lstkinhmach, "DM53");
            emrYhctChanDoan.lstkinhmachVv = ConvertChuoiStringID(item.lstkinhmachVv, "DM53");
            emrYhctChanDoan.lstnguyennhanbenh = ConvertChuoiStringID(item.lstnguyennhanbenh, "DM55");
            emrYhctChanDoan.lstnguyennhanbenhVv = ConvertChuoiStringID(item.lstnguyennhanbenhVv, "DM55");
            emrYhctChanDoan.lsttangphu = ConvertChuoiStringID(item.lsttangphu, "DM52");
            emrYhctChanDoan.lsttangphuVv = ConvertChuoiStringID(item.lsttangphuVv, "DM52");
            emrYhctChanDoan.motabatcuong = item.motabatcuong;
            emrYhctChanDoan.motabatcuongVv = item.motabatcuongVv;
            emrYhctChanDoan.motabenhdanhyhctravien = item.motabenhdanhyhctravien;
            emrYhctChanDoan.motabenhdanhyhctvaokhoa = item.motabenhdanhyhctvaokhoa;
            emrYhctChanDoan.motabenhdanhyhctvaovien = item.motabenhdanhyhctvaovien;
            emrYhctChanDoan.motakinhmach = item.motakinhmach;
            emrYhctChanDoan.motakinhmachVv = item.motakinhmachVv;
            emrYhctChanDoan.motanguyennhanbenh = item.motanguyennhanbenh;
            emrYhctChanDoan.motanguyennhanbenhVv = item.motanguyennhanbenhVv;
            emrYhctChanDoan.motatangphu = item.motatangphu;
            emrYhctChanDoan.motatangphuVv = item.motatangphuVv;
        }

        return emrYhctChanDoan;
    }

    private emrDmYhctBenhDanh getemrDmYhctBenhDanhByIdbenhdanhyhctVk(string p)
    {
        emrDmYhctBenhDanh emrDmYhctBenhDanh = new emrDmYhctBenhDanh();
        return emrDmYhctBenhDanh;
    }

    private emrDmYhctBenhDanh getemrDmYhctBenhDanhByIdbenhdanhyhctvaovien(string p)
    {
        emrDmYhctBenhDanh emrDmYhctBenhDanh = new emrDmYhctBenhDanh();
        return emrDmYhctBenhDanh;
    }

    private emrDmYhctBenhDanh getemrDmYhctBenhDanhByIdbenhdanhyhctravien(string p)
    {
        emrDmYhctBenhDanh emrDmYhctBenhDanh = new emrDmYhctBenhDanh();
        return emrDmYhctBenhDanh;
    }

    private emrTinhTrangRaVien getemrTinhTrangRaVien(int IdDanhSachHSBA)
    {
        emrTinhTrangRaVien emrTinhTrangRaVien = new emrTinhTrangRaVien();

        var tbl_emrTinhTrangRaVien = from p in _dbContext.tbl_emrTinhTrangRaViens where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrTinhTrangRaVien.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrTinhTrangRaVien.emrDmKetQuaDieuTri = getemrDmKetQuaDieuTri(item);
            emrTinhTrangRaVien.emrDmKetQuaGiaiPhauBenh = getemrDmKetQuaGiaiPhauBenh(item);
            emrTinhTrangRaVien.emrDmLyDoTuVong = getemrDmLyDoTuVong(item);
            emrTinhTrangRaVien.emrDmMaBenhByIdicdGiaiphaututhi = getemrDmMaBenhByIdicdGiaiphaututhi(item);
            emrTinhTrangRaVien.emrDmMaBenhByIdicdNguyennhantuvong = getemrDmMaBenhByIdicdNguyennhantuvong(item);
            emrTinhTrangRaVien.emrDmThoiDiemTuVong = getemrDmThoiDiemTuVong(item);
            emrTinhTrangRaVien.khamnghiemtuthi = CheckNullReturnTrueFalse(item.khamnghiemtuthi);
            emrTinhTrangRaVien.motagiaiphaututhi = CheckNull(item.motagiaiphaututhi);
            emrTinhTrangRaVien.motanguyennhantuvong = CheckNull(item.motanguyennhantuvong);
            emrTinhTrangRaVien.ngaygiotuvong = toDateFormat(item.ngaygiotuvong);

        }
        return emrTinhTrangRaVien;
    }

    private emrDmThoiDiemTuVong getemrDmThoiDiemTuVong(tbl_emrTinhTrangRaVien item)
    {
        emrDmThoiDiemTuVong emrDmThoiDiemTuVong = new emrDmThoiDiemTuVong();
        emrDmThoiDiemTuVong.ma = getMaDTT(item.emrDmThoiDiemTuVong, "");// Chưa biết mã:(
        return emrDmThoiDiemTuVong;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdNguyennhantuvong(tbl_emrTinhTrangRaVien item) // Thông tin này đang lấy luôn mã ICD bệnh ra viện
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = item.emrDmMaBenhByIdicdNguyennhantuvong;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdGiaiphaututhi(tbl_emrTinhTrangRaVien item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = item.emrDmMaBenhByIdicdGiaiphaututhi;
        return emrDmMaBenh;
    }

    private emrDmKetQuaGiaiPhauBenh getemrDmKetQuaGiaiPhauBenh(tbl_emrTinhTrangRaVien item)
    {
        emrDmKetQuaGiaiPhauBenh emrDmKetQuaGiaiPhauBenh = new emrDmKetQuaGiaiPhauBenh();
        emrDmKetQuaGiaiPhauBenh.ma = getMaDTT(item.emrDmKetQuaGiaiPhauBenh, "DM14");
        return emrDmKetQuaGiaiPhauBenh;
    }

    private emrDmLyDoTuVong getemrDmLyDoTuVong(tbl_emrTinhTrangRaVien item)
    {
        emrDmLyDoTuVong emrDmLyDoTuVong = new emrDmLyDoTuVong();
        emrDmLyDoTuVong.ma = getMaDTT(item.emrDmLyDoTuVong, "DM15");
        return emrDmLyDoTuVong;
    }
    private emrDmKetQuaDieuTri getemrDmKetQuaDieuTri(tbl_emrTinhTrangRaVien item)
    {
        emrDmKetQuaDieuTri emrDmKetQuaDieuTri = new emrDmKetQuaDieuTri();
        emrDmKetQuaDieuTri.ma = getMaDTT(item.emrDmKetQuaDieuTri, "DM13");
        return emrDmKetQuaDieuTri;
    }
    private string CheckNull(object input) // Đỡ mất công viết hashvalue
    {
        if (input != null)
            return input.ToString();
        else
            return string.Empty;

    }
    private string CheckNullReturnTrueFalse(object input)
    {
        if (input != null)
            return (bool)input ? "1" : "0";
        else
            return string.Empty;

    }

    private emrTongKetSanKhoa getemrTongKetSanKhoa(int IdDanhSachHSBA)
    {

        emrTongKetSanKhoa emrTongKetSanKhoa = new emrTongKetSanKhoa();
        var item = _dbContext.tbl_emrTongKetSanKhoas.Where(x => x.IdDanhSachHSBA == IdDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            emrTongKetSanKhoa.deluc = toDateFormat(item.deluc);

            emrTongKetSanKhoa.apgar01 = CheckNull(item.apgar01);
            emrTongKetSanKhoa.apgar05 = CheckNull(item.apgar05);
            emrTongKetSanKhoa.apgar10 = CheckNull(item.apgar10);

            // Bắt đầu Phần thêm mới
            emrTongKetSanKhoa.apgar1pMausacda = CheckNull(item.apgar1pMausacda);
            emrTongKetSanKhoa.apgar1pPhanxa = CheckNull(item.apgar1pPhanxa);
            emrTongKetSanKhoa.apgar1pTho = CheckNull(item.apgar1pTho);
            emrTongKetSanKhoa.apgar1pTim = CheckNull(item.apgar1pTim);
            emrTongKetSanKhoa.apgar1pTruonglucco = CheckNull(item.apgar1pTruonglucco);
            emrTongKetSanKhoa.apgar5pMausacda = CheckNull(item.apgar5pMausacda);
            emrTongKetSanKhoa.apgar5pPhanxa = CheckNull(item.apgar5pPhanxa);
            emrTongKetSanKhoa.apgar5pTho = CheckNull(item.apgar5pTho);
            emrTongKetSanKhoa.apgar5pTim = CheckNull(item.apgar5pTim);
            emrTongKetSanKhoa.apgar5pTruonglucco = CheckNull(item.apgar5pTruonglucco);
            emrTongKetSanKhoa.cannangrau = CheckNull(item.cannangrau);
            emrTongKetSanKhoa.chucdanhnguoitheodoi = CheckNull(item.chucdanhnguoitheodoi);
            // phần này sẽ fix mapping dữ liệu sẵn trong store
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaiamdao = getemrDmTrangThaiMoDeByIdtrangthaiamdao(item);
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaicotucung = getemrDmTrangThaiMoDeByIdtrangthaicotucung(item);
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaisinhmon = getemrDmTrangThaiMoDeByIdtrangthaisinhmon(item);
            emrTongKetSanKhoa.luongmaubimat = CheckNull(item.luongmaubimat);
            //loaisorau không truyền
            emrTongKetSanKhoa.loaisorau = CheckNull(item.loaisorau);
            emrTongKetSanKhoa.motamatmang = CheckNull(item.motamatmang);
            emrTongKetSanKhoa.motamatmui = CheckNull(item.motamatmui);
            emrTongKetSanKhoa.motabanhrau = CheckNull(item.motabanhrau);
            emrTongKetSanKhoa.motasorau = CheckNull(item.motasorau);// Cách sổ rau

            emrTongKetSanKhoa.lydocanthiepkhac = CheckNull(item.lydocanthiepkhac);
            emrTongKetSanKhoa.tennguoidode = CheckNull(item.tennguoidode);
            emrTongKetSanKhoa.tennguoitheodoi = CheckNull(item.tennguoitheodoi);
            emrTongKetSanKhoa.tennguoimo = CheckNull(item.tennguoimo);
            emrTongKetSanKhoa.mach = CheckNull(item.mach);

            emrTongKetSanKhoa.thoigianchuyenda = toDateFormat(item.thoigianchuyenda);

            emrTongKetSanKhoa.thoigiantheodoikhoade = toDateFormat(item.thoigiantheodoikhoade);
            // Kết thúc phần thêm mới
            emrTongKetSanKhoa.bocraunhantao = CheckNullReturnTrueFalse(item.bocraunhantao);
            emrTongKetSanKhoa.canthiepkhac = CheckNull(item.canthiepkhac);
            emrTongKetSanKhoa.chaymausauso = CheckNullReturnTrueFalse(item.chaymausauso);
            emrTongKetSanKhoa.chieudairau = CheckNull(item.chieudairau);
            if (!string.IsNullOrEmpty(item.emrDmCachDe)) // NHỌ
                emrTongKetSanKhoa.emrDmCachDe = getemrDmCachDe(item);

            emrTongKetSanKhoa.kiemsoattucung = CheckNullReturnTrueFalse(item.kiemsoattucung);
            emrTongKetSanKhoa.luongmaumat = CheckNull(item.luongmaumat);
            emrTongKetSanKhoa.lydobocrau = item.lydobocrau;
            emrTongKetSanKhoa.lydocanthiep = item.lydocanthiep;
            emrTongKetSanKhoa.lydokiemsoat = CheckNull(item.lydokiemsoat);
            //   emrTongKetSanKhoa.mach = row["Mach"] is DBNull ? null: row.Mach;
            //emrckTongKetSanNhietDo Mới thêm vào table
            emrTongKetSanKhoa.nhietdo = CheckNull(item.nhietdo);
            //  emrTongKetSanKhoa.nhietdo = row["NhietDo"] is DBNull ? null: row.NhietDo.ToString();
            //emrckTongKetSanNhipTho Mới thêm vào table
            emrTongKetSanKhoa.nhiptho = CheckNull(item.nhiptho);
            //emrTongKetSanKhoa.nhiptho = row["NhipTho"] is DBNull ? null: row.NhipTho.ToString();

            emrTongKetSanKhoa.raubongnon = CheckNullReturnTrueFalse(item.raubongnon);
            emrTongKetSanKhoa.huyetapcao = returnHuyetApCaoThap(item.huyetapcao, 1);
            emrTongKetSanKhoa.huyetapthap = returnHuyetApCaoThap(item.huyetapthap, 2);
            emrTongKetSanKhoa.raucuonso = CheckNullReturnTrueFalse(item.raucuonso);
            emrTongKetSanKhoa.rausoluc = toDateFormat(item.rausoluc);
            emrTongKetSanKhoa.somatmang = CheckNullReturnTrueFalse(item.somatmang);
            emrTongKetSanKhoa.somatmui = CheckNullReturnTrueFalse(item.somatmui);
            emrTongKetSanKhoa.ssbopbongo2 = CheckNullReturnTrueFalse(item.ssbopbongo2);
            emrTongKetSanKhoa.sscannang = CheckNull(item.sscannang); // Nếu 1 mẹ mà có > 1 con thì không biết lấy cân nặng của thằng nào:))
            emrTongKetSanKhoa.sschieucao = CheckNull(item.sschieucao);// Nếu 1 mẹ mà có > 1 con thì không biết lấy chiều cao của thằng nào:))
            emrTongKetSanKhoa.ssdathai = CheckNullReturnTrueFalse(item.ssdathai);
            emrTongKetSanKhoa.ssditathaumon = CheckNullReturnTrueFalse(item.ssditathaumon);
            emrTongKetSanKhoa.ssditatkhac = CheckNullReturnTrueFalse(item.ssditatkhac);
            emrTongKetSanKhoa.sshutdich = CheckNullReturnTrueFalse(item.sshutdich);
            emrTongKetSanKhoa.ssmotaditat = CheckNull(item.ssmotaditat);
            emrTongKetSanKhoa.ssnoikhiquan = CheckNull(item.ssnoikhiquan);
            emrTongKetSanKhoa.sssogai = CheckNull(item.sssogai);
            emrTongKetSanKhoa.sssotrai = CheckNull(item.sssotrai);
            emrTongKetSanKhoa.ssthoo2 = CheckNullReturnTrueFalse(item.ssthoo2);
            //emrTongKetSanKhoa.soluongchet
            //emrTongKetSanKhoa.soluongsong
            emrTongKetSanKhoa.sstinhtrang = CheckNull(item.sstinhtrang);
            emrTongKetSanKhoa.ssvongdau = CheckNull(item.ssvongdau);
            //String xoabopTim = "0";
            emrTongKetSanKhoa.sshoisinhkhac = CheckNullReturnTrueFalse(item.sshoisinhkhac);
            emrTongKetSanKhoa.ssxoaboptim = CheckNullReturnTrueFalse(item.ssxoaboptim);
            emrTongKetSanKhoa.thoigiansorau = CheckNull(item.thoigiansorau);
            emrTongKetSanKhoa.toantrang = CheckNull(item.toantrang);
        }
        return emrTongKetSanKhoa;
    }

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaisinhmon(tbl_emrTongKetSanKhoa item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item.emrDmTrangThaiMoDeByIdtrangthaisinhmon;
        return emrDmTrangThaiMoDe;
    }

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaicotucung(tbl_emrTongKetSanKhoa item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item.emrDmTrangThaiMoDeByIdtrangthaicotucung;
        return emrDmTrangThaiMoDe;
    }

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaiamdao(tbl_emrTongKetSanKhoa item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item.emrDmTrangThaiMoDeByIdtrangthaiamdao;
        return emrDmTrangThaiMoDe;
    }

    private emrDmCachDe getemrDmCachDe(tbl_emrTongKetSanKhoa item)
    {
        emrDmCachDe emrDmCachDe = new emrDmCachDe();
        if (_IsBVTWHue)
        {
            string maCachDe = string.Empty;
            maCachDe = getMaDTT(item.emrDmCachDe, "DM28"); // Huế mới bổ sung danh mục này:D
            if (!string.IsNullOrEmpty(maCachDe))
                emrDmCachDe.ma = maCachDe;
        }
        else
        {
            String CachDe = item.emrDmCachDe;
            if (!String.IsNullOrEmpty(CachDe))
            {
                if (CachDe.Equals("00000")) //Foócxep
                {
                    emrDmCachDe.id = 2;
                    emrDmCachDe.ma = "02";
                }
                else if (CachDe.Equals("00010")) //Mổ lấy thai
                {
                    emrDmCachDe.id = 4;
                    emrDmCachDe.ma = "04";
                }
                else if (CachDe.Equals("01000")) //Đẻ thường
                {
                    emrDmCachDe.id = 1;
                    emrDmCachDe.ma = "01";
                }
                else if (CachDe.Equals("00100")) //Giác hút
                {
                    emrDmCachDe.id = 8; // cần check lại
                    emrDmCachDe.ma = "03";
                }
                else if (CachDe.Equals("00001")) //Đẻ chỉ huy 00001
                {
                    emrDmCachDe.id = 9;
                    emrDmCachDe.ma = "05";
                }
                else
                {
                    emrDmCachDe.id = 0;
                    emrDmCachDe.ma = String.Empty;
                }
            }
        }

        return emrDmCachDe;
    }

    #region Quản Lý người bệnh
    private emrQuanLyNguoiBenh getemrQuanLyNguoiBenh(int IdDanhSachHSBA)
    {

        emrQuanLyNguoiBenh emrQuanLyNguoiBenh = new emrQuanLyNguoiBenh();
        var tblemrQuanLyNguoiBenh = from p in _dbContext.tbl_emrQuanLyNguoiBenhs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrQuanLyNguoiBenh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrQuanLyNguoiBenh.emrDmCoSoKhamBenh = getemrDmCoSoKhamBenh(item);
            emrQuanLyNguoiBenh.emrDmLoaiChuyenVien = getemrDmLoaiChuyenVien(item);
            emrQuanLyNguoiBenh.emrDmLoaiDoiTuongTaiChinh = getemrDmLoaiDoiTuongTaiChinh(item);
            emrQuanLyNguoiBenh.emrDmLoaiRaVien = getemrDmLoaiRaVien(item);
            emrQuanLyNguoiBenh.emrDmLoaiVaoVien = getemrDmLoaiVaoVien(item);
            emrQuanLyNguoiBenh.emrDmNoiGioiThieu = getemrDmNoiGioiThieu(item);
            emrQuanLyNguoiBenh.emrDmNoiTrucTiepVao = getemrDmNoiTrucTiepVao(item);
            emrQuanLyNguoiBenh.ngaygioravien = toDateFormat(item.ngaygioravien);
            emrQuanLyNguoiBenh.ngaygiovaovien = toDateFormat(item.ngaygiovaovien);
            emrQuanLyNguoiBenh.noichuyenden = item.noichuyenden;
            // Truyền cái này bị lỗi

            //emrQuanLyNguoiBenh.sovaovien = item.sovaovien;
            emrQuanLyNguoiBenh.tenbacsichoravien = item.tenbacsichoravien;
            emrQuanLyNguoiBenh.tenbacsikham = item.tenbacsikham; // Thầy thuốc khám bệnh tờ 1 bệnh án
            emrQuanLyNguoiBenh.tongsongaydieutri = CheckNull(item.tongsongaydieutri);
            emrQuanLyNguoiBenh.vaovienlanthu = CheckNull(item.vaovienlanthu);

            return emrQuanLyNguoiBenh;
        }
        return emrQuanLyNguoiBenh;

    }
    #endregion


    private emrDmNoiTrucTiepVao getemrDmNoiTrucTiepVao(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmNoiTrucTiepVao emrDmNoiTrucTiepVao = new emrDmNoiTrucTiepVao();
        if (item != null)
            emrDmNoiTrucTiepVao.ma = getMaDTT(item.emrDmNoiTrucTiepVao, "DM09");
        return emrDmNoiTrucTiepVao;
    }

    private emrDmNoiGioiThieu getemrDmNoiGioiThieu(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmNoiGioiThieu emrDmNoiGioiThieu = new emrDmNoiGioiThieu();
        if (item != null)
            emrDmNoiGioiThieu.ma = getMaDTT(item.emrDmNoiGioiThieu, "DM10");
        return emrDmNoiGioiThieu;
    }

    private emrDmLoaiVaoVien getemrDmLoaiVaoVien(tbl_emrQuanLyNguoiBenh item) // Không phải ánh xạ DM08
    {
        emrDmLoaiVaoVien emrDmLoaiVaoVien = new emrDmLoaiVaoVien();
        if (_IsBVPhuSan) // Viện phụ sản mặc định là nội trú
        {
            emrDmLoaiVaoVien.id = 0;
            emrDmLoaiVaoVien.ma = "1";
        }
        else
            if (!String.IsNullOrEmpty(item.MaLoaiBA))
        {
            if (item.MaLoaiBA.Equals("00031"))
            {
                emrDmLoaiVaoVien.id = 0;
                emrDmLoaiVaoVien.ma = "1";
            }
            else
            {
                emrDmLoaiVaoVien.id = 0;
                emrDmLoaiVaoVien.ma = "2";
            }
        }
        else
        {
            emrDmLoaiVaoVien.id = 0;
            emrDmLoaiVaoVien.ma = "2";
        }
        return emrDmLoaiVaoVien;
    }

    private emrDmLoaiRaVien getemrDmLoaiRaVien(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmLoaiRaVien emrDmLoaiRaVien = new emrDmLoaiRaVien();
        if (item != null)
            emrDmLoaiRaVien.ma = getMaDTT(item.emrDmLoaiRaVien, "DM12");
        return emrDmLoaiRaVien;
    }

    private emrDmLoaiDoiTuongTaiChinh getemrDmLoaiDoiTuongTaiChinh(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmLoaiDoiTuongTaiChinh emrDmLoaiDoiTuongTaiChinh = new emrDmLoaiDoiTuongTaiChinh();
        if (item != null)
            emrDmLoaiDoiTuongTaiChinh.ma = getMaDTT(item.emrDmLoaiDoiTuongTaiChinh, "DM11");
        return emrDmLoaiDoiTuongTaiChinh;
    }

    private emrDmLoaiChuyenVien getemrDmLoaiChuyenVien(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmLoaiChuyenVien emrDmLoaiChuyenVien = new emrDmLoaiChuyenVien();
        return emrDmLoaiChuyenVien;
    }

    private emrDmCoSoKhamBenh getemrDmCoSoKhamBenh(tbl_emrQuanLyNguoiBenh item)
    {
        emrDmCoSoKhamBenh emrDmCoSoKhamBenh = new emrDmCoSoKhamBenh();
        return emrDmCoSoKhamBenh;
    }

    private emrHinhAnhTonThuong[] getemrHinhAnhTonThuongs(int IdDanhSachHSBA)
    {

        List<emrHinhAnhTonThuong> list = new List<emrHinhAnhTonThuong>();
        var tblemrHinhAnhTonThuong = from p in _dbContext.tbl_emrHinhAnhTonThuongs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var listItem = tblemrHinhAnhTonThuong.DefaultIfEmpty().ToArray();
        if (listItem != null)
            foreach (tbl_emrHinhAnhTonThuong item in listItem)
            {
                if (item != null)
                {
                    if (item.anhtonthuong != null && item.motatonthuong != null)
                    {
                        emrHinhAnhTonThuong emrHinhAnhTonThuong = new DTT.HL7Core.emrHinhAnhTonThuong();
                        emrHinhAnhTonThuong.anhtonthuong = item.anhtonthuong;
                        emrHinhAnhTonThuong.motatonthuong = item.motatonthuong;

                        emrHinhAnhTonThuong.emrQuanLyFileDinhKemHatts = getemrQuanLyFileDinhKemHatts(item);
                        list.Add(emrHinhAnhTonThuong);
                    }
                }
            }
        return list.ToArray();
    }
    private emrQuanLyFileDinhKemHatt[] getemrQuanLyFileDinhKemHatts(tbl_emrHinhAnhTonThuong item)
    {
        List<emrQuanLyFileDinhKemHatt> list = new List<emrQuanLyFileDinhKemHatt>();
        emrQuanLyFileDinhKemHatt file = new emrQuanLyFileDinhKemHatt();
        //file.noiDungFile = convertBase64ByFile("");
        list.Add(file);
        return list.ToArray();
    }



    private emrDmYhctCheDoChamSoc getemrDmYhctCheDoChamSoc(string p)
    {
        emrDmYhctCheDoChamSoc emrDmYhctCheDoChamSoc = new emrDmYhctCheDoChamSoc();
        emrDmYhctCheDoChamSoc.ma = ConvertChuoiStringID(p, "DM87");
        return emrDmYhctCheDoChamSoc;
    }

    private emrYhctBenhanVongChan getemrYhctBenhanVongChan(int IdemrYhctBenhAn)
    {

        emrYhctBenhanVongChan emrYhctBenhanVongChan = new emrYhctBenhanVongChan();
        var tblemrYhctBenhanVongChan = from p in _dbContext.tbl_emrYhctBenhanVongChans where p.IdemrYhctBenhAn == IdemrYhctBenhAn select p;
        var item = tblemrYhctBenhanVongChan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrYhctBenhanVongChan.lstthan = ConvertChuoiStringID(item.lstthan, "DM57");

            emrYhctBenhanVongChan.lstchatluoi = ConvertChuoiStringID(item.lstchatluoi, "DM60");
            emrYhctBenhanVongChan.lsthinhthai = ConvertChuoiStringID(item.lsthinhthai, "DM56");
            emrYhctBenhanVongChan.lstsac = ConvertChuoiStringID(item.lstsac, "DM58");
            emrYhctBenhanVongChan.lstsacluoi = ConvertChuoiStringID(item.lstsacluoi, "DM61");
            emrYhctBenhanVongChan.lstreuluoi = ConvertChuoiStringID(item.lstreuluoi, "DM62");
            emrYhctBenhanVongChan.lsttrach = ConvertChuoiStringID(item.lsttrach, "DM59");
            emrYhctBenhanVongChan.motavongchan = item.motavongchan;
        }
        return emrYhctBenhanVongChan;

    }

    private emrYhctBenhanVawnChan getemrYhctBenhanVawnChan(int IdemrYhctBenhAn)
    {
        emrYhctBenhanVawnChan emrYhctBenhanVawnChan = new emrYhctBenhanVawnChan();
        var tblemrYhctBenhanVawnChan = from p in _dbContext.tbl_emrYhctBenhanVawnChans where p.IdemrYhctBenhAn == IdemrYhctBenhAn select p;
        var item = tblemrYhctBenhanVawnChan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrYhctBenhanVawnChan.lstchatthaibenhly = ConvertChuoiStringID(item.lstchatthaibenhly, "DM67");
            emrYhctBenhanVawnChan.lsthoitho = ConvertChuoiStringID(item.lsthoitho, "DM64");
            emrYhctBenhanVawnChan.lstmuicothe = ConvertChuoiStringID(item.lstmuicothe, "DM66");
            emrYhctBenhanVawnChan.lsttiengho = ConvertChuoiStringID(item.lsttiengho, "DM65");
            emrYhctBenhanVawnChan.lsttiengnoi = ConvertChuoiStringID(item.lsttiengnoi, "DM63");
            emrYhctBenhanVawnChan.amthanhnac = CheckNullReturnTrueFalse(item.amthanhnac);
            emrYhctBenhanVawnChan.amthanho = CheckNullReturnTrueFalse(item.amthanho);

            emrYhctBenhanVawnChan.motavawnchan = item.motavawnchan;
        }
        return emrYhctBenhanVawnChan;
    }

    private emrYhctBenhanVaanChan getemrYhctBenhanVaanChan(int IdemrYhctBenhAn)
    {

        emrYhctBenhanVaanChan emrYhctBenhanVaanChan = new emrYhctBenhanVaanChan();
        var tblemrYhctBenhanVaanChan = from p in _dbContext.tbl_emrYhctBenhanVaanChans where p.IdemrYhctBenhAn == IdemrYhctBenhAn select p;
        var item = tblemrYhctBenhanVaanChan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrYhctBenhanVaanChan.lstan = ConvertChuoiStringID(item.lstan, "DM73");
            emrYhctBenhanVaanChan.lstbungnguc = ConvertChuoiStringID(item.lstbungnguc, "DM72");
            emrYhctBenhanVaanChan.lstdaitien = ConvertChuoiStringID(item.lstdaitien, "DM75");
            emrYhctBenhanVaanChan.lstdaumatco = ConvertChuoiStringID(item.lstdaumatco, "DM70");
            // format theo thứ tự tăng dần
            emrYhctBenhanVaanChan.lstdoiha = ConvertChuoiStringID(item.lstdoiha, "DM80");
            emrYhctBenhanVaanChan.lsthannhiet = ConvertChuoiStringID(item.lsthannhiet, "DM68");
            // mới thêm
            // fix code Theo DM90 fix luôn trong query thì ko phải fix:)
            String lsthannhietbieuhien = String.Empty;
            String lsthannhietbieuhien1 = item.lsthannhietbieuhien;
            //        2 = Han
            //1 = Nhiet
            //0 = Khac
            //3 = Binh THuong
            if (!String.IsNullOrEmpty(lsthannhietbieuhien1))
            {
                if (lsthannhietbieuhien1.Equals("0")) // Khác
                {
                    lsthannhietbieuhien = "04";
                }
                else if (lsthannhietbieuhien1.Equals("1")) // Nhiet
                {
                    lsthannhietbieuhien = "03";
                }
                else if (lsthannhietbieuhien1.Equals("2")) // Han
                {
                    lsthannhietbieuhien = "02";
                }
                else if (lsthannhietbieuhien1.Equals("3")) // Bình thường
                {
                    lsthannhietbieuhien = "01";
                }
            }
            emrYhctBenhanVaanChan.lsthannhietbieuhien = lsthannhietbieuhien;
            emrYhctBenhanVaanChan.lstkinhnguyet = ConvertChuoiStringID(item.lstkinhnguyet, "DM78");
            emrYhctBenhanVaanChan.lstlung = ConvertChuoiStringID(item.lstlung, "DM71");
            emrYhctBenhanVaanChan.lstmohoi = ConvertChuoiStringID(item.lstmohoi, "DM69");
            // Truyền 3 không truyền 4
            emrYhctBenhanVaanChan.lstngu = ConvertChuoiStringID(item.lstngu, "DM77");
            emrYhctBenhanVaanChan.lstsinhduc = ConvertChuoiStringID(item.lstsinhduc, "DM81");
            emrYhctBenhanVaanChan.lstsinhducnu = ConvertChuoiStringID(item.lstsinhducnu, "DM91");
            emrYhctBenhanVaanChan.lstthongkinh = ConvertChuoiStringID(item.lstthongkinh, "DM79");
            emrYhctBenhanVaanChan.lsttieutien = ConvertChuoiStringID(item.lsttieutien, "DM76");
            emrYhctBenhanVaanChan.lstuong = ConvertChuoiStringID(item.lstuong, "DM74");
            emrYhctBenhanVaanChan.motavaanchan = item.motavaanchan;
            emrYhctBenhanVaanChan.lstchantay = CheckNullReturnTrueFalse(item.lstchantay);
            // Điều kiện xuất hiện bệnh
            emrYhctBenhanVaanChan.dkxuatvien = CheckNullReturnTrueFalse(item.dkxuatvien);
        }
        return emrYhctBenhanVaanChan;

    }

    private emrYhctBenhanThietChan getemrYhctBenhanThietChan(int IdemrYhctBenhAn)
    {

        emrYhctBenhanThietChan emrYhctBenhanThietChan = new emrYhctBenhanThietChan();
        var tblemrYhctBenhanThietChan = from p in _dbContext.tbl_emrYhctBenhanThietChans where p.IdemrYhctBenhAn == IdemrYhctBenhAn select p;
        var item = tblemrYhctBenhanThietChan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrYhctBenhanThietChan.lstconhuc = ConvertChuoiStringID(item.lstconhuc, "DM83");
            emrYhctBenhanThietChan.lstmachchanQuanTayphai = ConvertChuoiStringID(item.lstmachchanQuanTayphai, "DM85");
            emrYhctBenhanThietChan.lstmachchanQuanTaytrai = ConvertChuoiStringID(item.lstmachchanQuanTaytrai, "DM85");
            emrYhctBenhanThietChan.lstmachchanThonTayphai = ConvertChuoiStringID(item.lstmachchanThonTayphai, "DM85");
            emrYhctBenhanThietChan.lstmachchanThonTaytrai = ConvertChuoiStringID(item.lstmachchanThonTaytrai, "DM85");
            emrYhctBenhanThietChan.lstmachchantongquat = ConvertChuoiStringID(item.lstmachchantongquat, "DM85");
            emrYhctBenhanThietChan.lstmachchanXichTayphai = ConvertChuoiStringID(item.lstmachchanXichTayphai, "DM85");
            emrYhctBenhanThietChan.lstmachchanXichTaytrai = ConvertChuoiStringID(item.lstmachchanXichTaytrai, "DM85");
            emrYhctBenhanThietChan.lstphucchan = ConvertChuoiStringID(item.lstphucchan, "DM84");
            emrYhctBenhanThietChan.lstxucchan = ConvertChuoiStringID(item.lstxucchan, "DM82");
            emrYhctBenhanThietChan.lstxucchanmohoi = ConvertChuoiStringID(item.lstxucchanmohoi, "DM89");
            // emrYhctBenhanThietChan.lstxucchanmohoi = ConvertChuoiStringID(item.lstxucchanmohoi, "DM89");
            emrYhctBenhanThietChan.motamachchanTayphai = item.motamachchanTayphai;
            emrYhctBenhanThietChan.motamachchanTaytrai = item.motamachchanTaytrai;
            emrYhctBenhanThietChan.motathietchan = item.motathietchan;
            emrYhctBenhanThietChan.motaxucchan = item.motaxucchan;
        }
        return emrYhctBenhanThietChan;
    }

    private emrVaoKhoa[] getemrVaoKhoas(int IdDanhSachHSBA)
    {

        List<emrVaoKhoa> list = new List<emrVaoKhoa>();
        var tblemrVaoKhoa = from p in _dbContext.tbl_emrVaoKhoas where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listemrVaoKhoa = tblemrVaoKhoa.DefaultIfEmpty().ToArray();
        if (listemrVaoKhoa != null)
            foreach (tbl_emrVaoKhoa item in listemrVaoKhoa)
            {
                if (item != null)
                {
                    emrVaoKhoa emrVaoKhoa = new emrVaoKhoa();
                    // Hiện trạng không cần truyền thông tin này nữa
                    //if (!_IsBVYHocCoTruyen)
                    emrVaoKhoa.bacsidieutri = item.bacsidieutri;
                    emrVaoKhoa.emrDmKhoaDieuTri = getemrDmKhoaDieuTri(item);
                    emrVaoKhoa.giuong = item.giuong;
                    emrVaoKhoa.ngaygiovaokhoa = toDateFormat(item.ngaygiovaokhoa);
                    emrVaoKhoa.ngayketthucdieutri = toDateFormat(item.ngayketthucdieutri);
                    emrVaoKhoa.phong = item.phong;
                    // emrVaoKhoa.songaydieutri = item.songaydieutri.ToString();
                    // if (!_IsBVYHocCoTruyen)
                    emrVaoKhoa.tentruongkhoa = item.tentruongkhoa;
                    emrVaoKhoa.emrDieuTris = getemrDieuTris(item.IdemrVaoKhoa, IdDanhSachHSBA);
                    emrVaoKhoa.emrChamSocs = getemrChamSocs(item.IdemrVaoKhoa, IdDanhSachHSBA);
                    emrVaoKhoa.emrHoiChans = getemrHoiChans(item.IdemrVaoKhoa);
                    emrVaoKhoa.emrChucNangSongs = getemrChucNangSongs(item.IdemrVaoKhoa, IdDanhSachHSBA);
                    list.Add(emrVaoKhoa);
                }
            }
        return list.ToArray();
    }

    private emrChucNangSong[] getemrChucNangSongs(int IdemrVaoKhoa, int IdDanhSachHSBA)
    {

        List<emrChucNangSong> list = new List<emrChucNangSong>();
        var tblemrChucNangSong = from p in _dbContext.tbl_emrChucNangSongs where p.IdemrVaoKhoa == IdemrVaoKhoa select p;
        var listemrChucNangSong = tblemrChucNangSong.DefaultIfEmpty().ToArray();
        List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 3, IdDanhSachHSBA);
        if (listemrChucNangSong != null)
            if (result != null)
            {
                int SoPhieu = result.Count();
                for (int i = 0; i < result.Count; i++)
                {
                    emrChucNangSong emrChucNangSong = new emrChucNangSong();
                    emrChucNangSong.sophieu = result[i].ToString();
                    emrChucNangSong.emrChucNangSongChiTiets = getemrChucNangSongChiTiets(listemrChucNangSong, IdemrVaoKhoa.ToString(), result[i]);
                    list.Add(emrChucNangSong);
                }

            }


        return list.ToArray();

    }

    private emrChucNangSongChiTiet[] getemrChucNangSongChiTiets(tbl_emrChucNangSong[] listpara, string IdemrVaoKhoa, int sophieu)
    {
        List<emrChucNangSongChiTiet> list = new List<emrChucNangSongChiTiet>();
        emrChucNangSongChiTiet emrChucNangSongChiTiet = new emrChucNangSongChiTiet();
        if (listpara != null)
        {
            foreach (tbl_emrChucNangSong item in listpara)
            {
                if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa))
                {
                    if (item.SoPhieu == sophieu)
                    {
                        emrChucNangSongChiTiet.cannang = CheckNull(item.cannang);
                        emrChucNangSongChiTiet.huyetapcao = returnHuyetApCaoThap(item.huyetapcao, 1);// 1 là cao 2 là thấp vì cái này data mình gộp chung 2 thông tin thành 1
                        emrChucNangSongChiTiet.huyetapthap = returnHuyetApCaoThap(item.huyetapcao, 2);// 1 là cao 2 
                        emrChucNangSongChiTiet.mach = CheckNull(item.mach);
                        emrChucNangSongChiTiet.ngaytheodoi = toDateFormat(item.ngaytheodoi);
                        emrChucNangSongChiTiet.nhietdo = CheckNull(item.nhietdo);
                        emrChucNangSongChiTiet.nhiptho = CheckNull(item.nhiptho);
                        emrChucNangSongChiTiet.ytatheodoi = item.ytatheodoi;
                        list.Add(emrChucNangSongChiTiet);
                    }
                }
            }

        }
        return list.ToArray();
    }

    private emrHoiChan[] getemrHoiChans(int IdemrVaoKhoa)
    {

        List<emrHoiChan> list = new List<emrHoiChan>();
        var tblemrHoiChan = from p in _dbContext.tbl_emrHoiChans where p.IdemrVaoKhoa == IdemrVaoKhoa select p;
        var listemrHoiChan = tblemrHoiChan.DefaultIfEmpty().ToArray();
        if (listemrHoiChan != null)
            foreach (tbl_emrHoiChan item in listemrHoiChan)
            {
                if (item != null)
                {
                    emrHoiChan emrHoiChan = new emrHoiChan();
                    emrHoiChan.huongdieutri = item.huongdieutri;
                    emrHoiChan.ketluanhoichan = item.ketluanhoichan;
                    emrHoiChan.tomtatdienbien = item.tomtatdienbien;
                    emrHoiChan.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrHoiChan.emrHoiDongHoiChans = getemrHoiDongHoiChans(item.IdemrHoiChan);
                    list.Add(emrHoiChan);
                }
            }
        return list.ToArray();

    }

    private emrHoiDongHoiChan[] getemrHoiDongHoiChans(int IdemrHoiChan)
    {

        List<emrHoiDongHoiChan> list = new List<emrHoiDongHoiChan>();
        var tblemrHoiDongHoiChan = from p in _dbContext.tbl_emrHoiDongHoiChans where p.IdemrHoiChan == IdemrHoiChan select p;
        var listemrHoiDongHoiChan = tblemrHoiDongHoiChan.DefaultIfEmpty().ToArray();
        if (listemrHoiDongHoiChan != null)
            foreach (tbl_emrHoiDongHoiChan item in listemrHoiDongHoiChan)
            {
                if (item != null)
                {
                    emrHoiDongHoiChan emrHoiDongHoiChan = new emrHoiDongHoiChan();
                    emrHoiDongHoiChan.bacsihoichan = item.bacsihoichan;
                    emrHoiDongHoiChan.idvaitro = CheckNull(item.idvaitro);
                    list.Add(emrHoiDongHoiChan);
                }
            }
        return list.ToArray();

    }
    private List<int> SoPhieuChamSoc(int IdemrVaoKhoa, int Loai, int IdDanhSachHSBA)
    {
        List<int> listSoPhieu = new List<int>();
        string sql = string.Empty;
        string LoaiTo = string.Empty;
        if (Loai == 1)// Chăm sóc
        {
            LoaiTo = "sotochamsoc";
            sql = "select sotochamsoc from tbl_emrChamSoc where IdemrVaoKhoa = " + IdemrVaoKhoa.ToString() + " and IdDanhSachHSBa = " + IdDanhSachHSBA + " group by sotochamsoc";
        }
        else if (Loai == 2)
        {
            LoaiTo = "sotodieutri";
            sql = "select sotodieutri from tbl_emrDieuTri where IdemrVaoKhoa = " + IdemrVaoKhoa.ToString() + " and IdDanhSachHSBa = " + IdDanhSachHSBA + " group by sotodieutri";
        }
        else // Chức năng sống
        {
            LoaiTo = "SoPhieu";
            sql = "select SoPhieu from tbl_emrChucNangSong where IdemrVaoKhoa = " + IdemrVaoKhoa.ToString() + " and IdDanhSachHSBa = " + IdDanhSachHSBA + " group by SoPhieu";
        }
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString);
        con.Open();
        SqlCommand com = new SqlCommand(sql, con);

        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);


        //SqlDataAdapter da = new SqlDataAdapter(com);

        foreach (DataRow item in dt.Rows)
        {
            int SoPhieu;
            if (!string.IsNullOrEmpty(item[LoaiTo].ToString()))
            {
                SoPhieu = int.Parse(item[LoaiTo].ToString());
                listSoPhieu.Add(SoPhieu);
            }
        }
        con.Close();
        return listSoPhieu;


    }
    private emrChamSoc[] getemrChamSocs(int IdemrVaoKhoa, int IdDanhSachHSBA)
    {

        List<emrChamSoc> list = new List<emrChamSoc>();
        var tblemrChamSoc = from p in _dbContext.tbl_emrChamSocs where p.IdemrVaoKhoa == IdemrVaoKhoa select p;
        var listemrChamSoc = tblemrChamSoc.DefaultIfEmpty().ToArray();
        List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 1, IdDanhSachHSBA);
        if (result != null)
        {
            int SoPhieu = result.Count();
            for (int i = 0; i < result.Count; i++)
            {
                emrChamSoc emrChamSoc = new emrChamSoc();
                emrChamSoc.sotochamsoc = result[i].ToString();
                emrChamSoc.emrQuaTrinhChamSocs = getemrQuaTrinhChamSocs(listemrChamSoc, IdemrVaoKhoa.ToString(), result[i]);
                list.Add(emrChamSoc);
            }
        }
        return list.ToArray();

    }

    private emrQuaTrinhChamSoc[] getemrQuaTrinhChamSocs(tbl_emrChamSoc[] listchamsoc, string IdemrVaoKhoa, int SoTo)// Mấy object dạng này do DTT sai thiết kế hoặc ... có 1 item không phải nhiều item
    {

        List<emrQuaTrinhChamSoc> list = new List<emrQuaTrinhChamSoc>();

        foreach (tbl_emrChamSoc item in listchamsoc)
        {
            if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa.ToString()))
            {
                if (item.sotochamsoc == SoTo)
                {
                    emrQuaTrinhChamSoc emrQuaTrinhChamSoc = new emrQuaTrinhChamSoc();
                    emrQuaTrinhChamSoc.ngaychamsoc = toDateFormat(item.ngaychamsoc);
                    emrQuaTrinhChamSoc.theodoidienbien = item.theodoidienbien;
                    emrQuaTrinhChamSoc.thuchienylenh = item.thuchienylenh;
                    emrQuaTrinhChamSoc.ytachamsoc = item.ytachamsoc;
                    list.Add(emrQuaTrinhChamSoc);
                }
            }
        }
        return list.ToArray();

    }

    private emrDieuTri[] getemrDieuTris(int IdemrVaoKhoa, int IdDanhSachHSBA)
    {

        List<emrDieuTri> list = new List<emrDieuTri>();
        var tblemrDieuTri = from p in _dbContext.tbl_emrDieuTris where p.IdemrVaoKhoa == IdemrVaoKhoa select p;
        var listemrDieuTri = tblemrDieuTri.DefaultIfEmpty().ToArray();

        List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 2, IdDanhSachHSBA);
        if (result != null)
        {
            int SoPhieu = result.Count();
            for (int i = 0; i < result.Count; i++)
            {

                emrDieuTri emrDieuTri = new emrDieuTri();

                emrDieuTri.sotodieutri = result[i].ToString();
                emrDieuTri.emrQuaTrinhDieuTris = getemrQuaTrinhDieuTris(listemrDieuTri, IdemrVaoKhoa, result[i]);
                list.Add(emrDieuTri);


            }

        }


        return list.ToArray();

    }

    private emrQuaTrinhDieuTri[] getemrQuaTrinhDieuTris(tbl_emrDieuTri[] listDieuTri, int IdemrVaoKhoa, int SoTo)
    {

        List<emrQuaTrinhDieuTri> list = new List<emrQuaTrinhDieuTri>();

        foreach (tbl_emrDieuTri item in listDieuTri)
        {
            if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa.ToString()))
            {
                if (SoTo == item.sotodieutri)
                {
                    emrQuaTrinhDieuTri emrQuaTrinhDieuTri = new emrQuaTrinhDieuTri();
                    emrQuaTrinhDieuTri.bacsiraylenh = item.bacsiraylenh;
                    emrQuaTrinhDieuTri.dienbien = item.dienbien;
                    emrQuaTrinhDieuTri.ylenh = item.ylenh;
                    emrQuaTrinhDieuTri.chamsoc = item.ChamSoc;
                    emrQuaTrinhDieuTri.ngaydieutri = toDateFormat(item.ngaydieutri);
                    list.Add(emrQuaTrinhDieuTri);
                }
            }
        }
        return list.ToArray();
    }

    private emrDmKhoaDieuTri getemrDmKhoaDieuTri(tbl_emrVaoKhoa item)
    {
        emrDmKhoaDieuTri emrDmKhoaDieuTri = new emrDmKhoaDieuTri();
        if (item != null)
        {
            emrDmKhoaDieuTri.ma = item.emrDmKhoaDieuTri;
            emrDmKhoaDieuTri.ten = item.tenkhoa;
        }
        return emrDmKhoaDieuTri;
    }

    private emrDonThuoc[] getemrDonThuocs(int IdDanhSachHSBA)
    {
        List<emrDonThuoc> list = new List<emrDonThuoc>();
        var tblemrDonThuoc = from p in _dbContext.tbl_emrDonThuocs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var listemrDonThuoc = tblemrDonThuoc.DefaultIfEmpty().ToArray();
        int CountSoDon = 0;
        if (listemrDonThuoc != null)

            foreach (tbl_emrDonThuoc item in listemrDonThuoc)
            {
                if (item != null)
                {
                    CountSoDon++;
                    emrDonThuoc emrDonThuoc = new emrDonThuoc();
                    emrDonThuoc.bacsikedon = item.bacsikedon;
                    emrDonThuoc.ngaykedon = toDateFormat(item.ngaykedon);
                    //  emrDonThuoc.sodon = CheckNull(item.sodon);
                    emrDonThuoc.sodon = CountSoDon.ToString();// Cái này chính là đơn thuốc số : xxx
                    emrDonThuoc.emrDonThuocChiTiets = getemrDonThuocChiTiets(item.IdemrDonThuoc);
                    list.Add(emrDonThuoc);
                }
            }
        return list.ToArray();
    }

    private emrDonThuocChiTiet[] getemrDonThuocChiTiets(int IdemrDonThuoc)
    {
        List<emrDonThuocChiTiet> list = new List<emrDonThuocChiTiet>();
        var tblemrDonThuocChiTiet = from p in _dbContext.tbl_emrDonThuocChiTiets where p.IdemrDonThuoc == IdemrDonThuoc select p;
        var listemrDonThuocChiTiet = tblemrDonThuocChiTiet.DefaultIfEmpty().ToArray();
        if (listemrDonThuocChiTiet != null)
            foreach (tbl_emrDonThuocChiTiet item in listemrDonThuocChiTiet)
            {
                if (item != null)
                {
                    emrDonThuocChiTiet emrDonThuocChiTiet = new emrDonThuocChiTiet();
                    emrDonThuocChiTiet.chidandungthuoc = CheckNull(item.chidandungthuoc);
                    emrDonThuocChiTiet.emrDmDuongDungThuoc = getemrDmDuongDungThuoc(item);
                    emrDonThuocChiTiet.emrDmTanXuatDungThuoc = getemrDmTanXuatDungThuoc(item);
                    emrDonThuocChiTiet.emrDmThuoc = getemrDmThuoc(item);
                    emrDonThuocChiTiet.lieuluongdung = item.lieuluongdung;
                    emrDonThuocChiTiet.bietduoc = CheckNull(item.bietduoc);
                    emrDonThuocChiTiet.ngaybatdau = toDateFormat(item.ngaybatdau);
                    emrDonThuocChiTiet.ngayketthuc = toDateFormat(item.ngayketthuc);

                    list.Add(emrDonThuocChiTiet);
                }
            }
        return list.ToArray();
    }

    private emrDmThuoc getemrDmThuoc(tbl_emrDonThuocChiTiet item)
    {
        emrDmThuoc emrDmThuoc = new emrDmThuoc();
        if (item != null)
        {
            if (item.machungloai != null)
                if (item.machungloai.Equals("00019")) // Lấy danh mục thuốc đông y
                    emrDmThuoc.ma = getMaDTT(item.emrDmThuoc, "DM88");
                else
                    emrDmThuoc.ma = getMaDTT(item.emrDmThuoc, "DM36");
            else
                emrDmThuoc.ma = null;
        }
        return emrDmThuoc;

    }

    private emrDmTanXuatDungThuoc getemrDmTanXuatDungThuoc(tbl_emrDonThuocChiTiet item)
    {
        emrDmTanXuatDungThuoc emrDmTanXuatDungThuoc = new emrDmTanXuatDungThuoc();
        if (item != null)
            //emrDmTanXuatDungThuoc.ma = getMaDTT(item.emrDmTanXuatDungThuoc, "DM39");
            emrDmTanXuatDungThuoc.ma = "1";
        return emrDmTanXuatDungThuoc;
    }

    private emrDmDuongDungThuoc getemrDmDuongDungThuoc(tbl_emrDonThuocChiTiet item)
    {
        emrDmDuongDungThuoc emrDmDuongDungThuoc = new emrDmDuongDungThuoc();
        //  emrDmDuongDungThuoc.ma = getMaDTT(item.emrDmDuongDungThuoc, "DM38");
        emrDmDuongDungThuoc.ma = "1";// Tạm thời face để truyền,phía bệnh viện chưa có dữ liệu
        return emrDmDuongDungThuoc;
    }
    private static readonly string[] VietNamChar = new string[]
    {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
    };
    public static string LocDau(string str)
    {
        //Thay thế và lọc dấu từng char      
        for (int i = 1; i < VietNamChar.Length; i++)
        {
            for (int j = 0; j < VietNamChar[i].Length; j++)
                str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
        }
        return str;
    }
    private emrGiaiPhauBenh[] getemrGiaiPhauBenhs(int IdDanhSachHSBA)
    {

        List<emrGiaiPhauBenh> list = new List<emrGiaiPhauBenh>();
        var tblemrGiaiPhauBenh = from p in _dbContext.tbl_emrGiaiPhauBenhs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var listemrGiaiPhauBenh = tblemrGiaiPhauBenh.DefaultIfEmpty().ToArray();
        if (listemrGiaiPhauBenh != null)
            foreach (tbl_emrGiaiPhauBenh item in listemrGiaiPhauBenh)
            {
                if (item != null)
                {
                    emrGiaiPhauBenh emrGiaiPhauBenh = new emrGiaiPhauBenh();
                    emrGiaiPhauBenh.bacsichuyenkhoa = item.bacsichuyenkhoa;
                    emrGiaiPhauBenh.bacsiyeucau = item.bacsiyeucau;
                    emrGiaiPhauBenh.emrDmGiaiPhauBenh = getemrDmGiaiPhauBenh(item);
                    emrGiaiPhauBenh.emrDmKetQuaGiaiPhauBenh = getemrDmKetQuaGiaiPhauBenh(item);
                    emrGiaiPhauBenh.emrDmLoaiGiaiPhauBenh = getemrDmLoaiGiaiPhauBenh(item);
                    emrGiaiPhauBenh.emrDmViTriLayMau = getemrDmViTriLayMau(item);
                    emrGiaiPhauBenh.motachandoangiaiphau = item.motachandoangiaiphau;
                    emrGiaiPhauBenh.ngaylaymausinhthiet = toDateFormat(item.ngaylaymausinhthiet);
                    emrGiaiPhauBenh.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrGiaiPhauBenh.ngayyeucau = toDateFormat(item.ngayyeucau);
                    emrGiaiPhauBenh.nhanxetdaithe = item.nhanxetdaithe;
                    emrGiaiPhauBenh.nhanxetvithe = item.nhanxetvithe;
                    list.Add(emrGiaiPhauBenh);
                }
            }
        return list.ToArray();

    }

    private emrDmViTriLayMau getemrDmViTriLayMau(tbl_emrGiaiPhauBenh item)
    {
        emrDmViTriLayMau emrDmViTriLayMau = new emrDmViTriLayMau();
        return emrDmViTriLayMau;
    }

    private emrDmLoaiGiaiPhauBenh getemrDmLoaiGiaiPhauBenh(tbl_emrGiaiPhauBenh item)
    {
        emrDmLoaiGiaiPhauBenh emrDmLoaiGiaiPhauBenh = new emrDmLoaiGiaiPhauBenh();
        return emrDmLoaiGiaiPhauBenh;
    }

    private emrDmKetQuaGiaiPhauBenh getemrDmKetQuaGiaiPhauBenh(tbl_emrGiaiPhauBenh item)
    {
        emrDmKetQuaGiaiPhauBenh emrDmKetQuaGiaiPhauBenh = new emrDmKetQuaGiaiPhauBenh();
        emrDmKetQuaGiaiPhauBenh.ma = getMaDTT(item.emrDmKetQuaGiaiPhauBenh, "DM14");
        return emrDmKetQuaGiaiPhauBenh;
    }

    private emrDmGiaiPhauBenh getemrDmGiaiPhauBenh(tbl_emrGiaiPhauBenh item)
    {
        emrDmGiaiPhauBenh emrDmGiaiPhauBenh = new emrDmGiaiPhauBenh();
        emrDmGiaiPhauBenh.ma = getMaDTT(item.emrDmGiaiPhauBenh, "DM27");
        return emrDmGiaiPhauBenh;
    }

    private emrThamDoChucNang[] getemrThamDoChucNangs(int IdDanhSachHSBA)
    {

        List<emrThamDoChucNang> list = new List<emrThamDoChucNang>();
        var tblemrThamDoChucNang = from p in _dbContext.tbl_emrThamDoChucNangs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listemrThamDoChucNang = tblemrThamDoChucNang.DefaultIfEmpty().ToArray();
        if (listemrThamDoChucNang != null)
            foreach (tbl_emrThamDoChucNang item in listemrThamDoChucNang)
            {
                if (item != null)
                {
                    emrThamDoChucNang emrThamDoChucNang = new emrThamDoChucNang();
                    emrThamDoChucNang.bacsichuyenkhoa = item.bacsichuyenkhoa;
                    emrThamDoChucNang.bacsiyeucau = item.bacsiyeucau;
                    emrThamDoChucNang.emrDmThamDoChucNang = getemrDmThamDoChucNang(item);
                    emrThamDoChucNang.ketluan = item.ketluan;
                    if (item.LoaiKQ != null && item.LoaiKQ != 5)
                        emrThamDoChucNang.ketqua = item.ketqua;
                    emrThamDoChucNang.loidan = item.loidan;
                    emrThamDoChucNang.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrThamDoChucNang.ngayyeucau = toDateFormat(item.ngayyeucau);
                    int STT = 0;
                    if (item.STT != null)
                        STT = int.Parse(item.STT.ToString());
                    emrThamDoChucNang.emrQuanLyFileDinhKemTdcns = getemrQuanLyFileDinhKemTdcns(STT, IdDanhSachHSBA);
                    emrThamDoChucNang.noidungyeucau = item.noidungyeucau;
                    list.Add(emrThamDoChucNang);
                }
            }
        return list.ToArray();

    }

    private emrQuanLyFileDinhKemTdcn[] getemrQuanLyFileDinhKemTdcns(int STT, int idDanhSachHSBA)// Thăm dò chức năng loại =4
    {
        List<emrQuanLyFileDinhKemTdcn> list = new List<emrQuanLyFileDinhKemTdcn>();
        emrQuanLyFileDinhKemTdcn emrQuanLyFileDinhKemTdcn = new emrQuanLyFileDinhKemTdcn();
        var File = from p in _dbContext.tbl_emrQuanLyFileDinhKems where p.IdDanhSachHSBA == idDanhSachHSBA && p.STT == STT && p.IdLoaiFileDinhKem == 4 select p;
        var item = File.DefaultIfEmpty().ToArray();
        if (item[0] != null)
        {
            emrQuanLyFileDinhKemTdcn.tenfile = ConvertVN(formatTenFile(item[0].tenfile));
            // emrQuanLyFileDinhKemTdcn.tenfile = (item[0].tenfile);
            emrQuanLyFileDinhKemTdcn.noiDungFile = GetData(item[0].duongdan);
            list.Add(emrQuanLyFileDinhKemTdcn);
        }
        string tenfile = SaveFileTDCN(STT, idDanhSachHSBA);
        if (!string.IsNullOrEmpty(tenfile))
        {
            emrQuanLyFileDinhKemTdcn.tenfile = ConvertVN(tenfile);
            // emrQuanLyFileDinhKemTdcn.noiDungFile = convertBase64ByFile(Server.MapPath(formatTenFile(tenfile)));
            emrQuanLyFileDinhKemTdcn.noiDungFile = convertBase64ByFile(Server.MapPath((tenfile)));

            list.Add(emrQuanLyFileDinhKemTdcn);
        }
        return list.ToArray();
    }

    private emrDmThamDoChucNang getemrDmThamDoChucNang(tbl_emrThamDoChucNang item)
    {
        emrDmThamDoChucNang emrDmThamDoChucNang = new emrDmThamDoChucNang();
        emrDmThamDoChucNang.ma = getMaDTT(item.emrDmThamDoChucNang, "DM26");
        return emrDmThamDoChucNang;
    }

    private emrChanDoanHinhAnh[] getemrChanDoanHinhAnhs(int IdDanhSachHSBA)
    {

        List<emrChanDoanHinhAnh> listemrChanDoanHinhAnh = new List<emrChanDoanHinhAnh>();
        var tblemrChanDoanHinhAnh = from p in _dbContext.tbl_emrChanDoanHinhAnhs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var list = tblemrChanDoanHinhAnh.DefaultIfEmpty().ToArray();
        if (list != null)
            foreach (tbl_emrChanDoanHinhAnh item in list)
            {
                if (item != null)
                {
                    emrChanDoanHinhAnh emrChanDoanHinhAnh = new emrChanDoanHinhAnh();
                    // Bác sỹ chuyên khoa =bác sỹ thực hiện =BSKham benhan_c "Nội trú" KhamBenh_c "Ngoại Trú"
                    emrChanDoanHinhAnh.bacsichuyenkhoa = item.bacsichuyenkhoa;
                    emrChanDoanHinhAnh.bacsiyeucau = item.bacsiyeucau;
                    emrChanDoanHinhAnh.emrDmChanDoanHinhAnh = getemrDmChanDoanHinhAnh(item);
                    emrChanDoanHinhAnh.emrDmLoaiChanDoanHinhAnh = getemrDmLoaiChanDoanHinhAnh(item);
                    emrChanDoanHinhAnh.ketluan = item.ketluan;
                    if (item.LoaiKQ != null && item.LoaiKQ != 5)
                        emrChanDoanHinhAnh.ketqua = item.ketqua;
                    emrChanDoanHinhAnh.loidan = item.loidan;
                    emrChanDoanHinhAnh.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrChanDoanHinhAnh.ngayyeucau = toDateFormat(item.ngayyeucau);
                    if (!string.IsNullOrEmpty(item.STT.ToString()))
                        emrChanDoanHinhAnh.emrQuanLyFileDinhKemCdha = getemrQuanLyFileDinhKemCdha(int.Parse(item.STT.ToString()), IdDanhSachHSBA);
                    listemrChanDoanHinhAnh.Add(emrChanDoanHinhAnh);
                }
            }
        return listemrChanDoanHinhAnh.ToArray();

    }

    private emrQuanLyFileDinhKemCdha[] getemrQuanLyFileDinhKemCdha(int STT, int IDDanhSachHSBA)// Chẩn đoán hình ảnh loại =5
    {

        List<emrQuanLyFileDinhKemCdha> listemrQuanLyFileDinhKemCdha = new List<emrQuanLyFileDinhKemCdha>();
        string tenfile = SaveFileCDHA(STT, IDDanhSachHSBA);
        emrQuanLyFileDinhKemCdha emrQuanLyFileDinhKemCdha = new emrQuanLyFileDinhKemCdha();
        emrQuanLyFileDinhKemCdha emrQuanLyFileDinhKemCdha2 = new emrQuanLyFileDinhKemCdha();

        var File = from p in _dbContext.tbl_emrQuanLyFileDinhKems where p.IdDanhSachHSBA == IDDanhSachHSBA && p.STT == STT && p.IdLoaiFileDinhKem == 5 select p;

        var item = File.DefaultIfEmpty().ToArray();
        if (item[0] != null)
        {
            emrQuanLyFileDinhKemCdha2.tenfile = ConvertVN(formatTenFile(item[0].tenfile));
            // emrQuanLyFileDinhKemCdha2.tenfile = (item[0].tenfile);
            emrQuanLyFileDinhKemCdha2.noiDungFile = GetData(item[0].duongdan);
            listemrQuanLyFileDinhKemCdha.Add(emrQuanLyFileDinhKemCdha2);
        }
        if (!string.IsNullOrEmpty(tenfile))
        {
            emrQuanLyFileDinhKemCdha.tenfile = ConvertVN(tenfile);
            emrQuanLyFileDinhKemCdha.noiDungFile = convertBase64ByFile(Server.MapPath((tenfile)));
            //  emrQuanLyFileDinhKemCdha.noiDungFile = convertBase64ByFile(Server.MapPath((tenfile)));
            listemrQuanLyFileDinhKemCdha.Add(emrQuanLyFileDinhKemCdha);
        }
        return listemrQuanLyFileDinhKemCdha.ToArray();

    }

    private emrDmLoaiChanDoanHinhAnh getemrDmLoaiChanDoanHinhAnh(tbl_emrChanDoanHinhAnh item)
    {
        emrDmLoaiChanDoanHinhAnh emrDmLoaiChanDoanHinhAnh = new emrDmLoaiChanDoanHinhAnh();
        if (item != null)
            emrDmLoaiChanDoanHinhAnh.ma = getMaDTT(item.emrDmLoaiChanDoanHinhAnh, "DM31");
        return emrDmLoaiChanDoanHinhAnh;
    }

    private emrDmChanDoanHinhAnh getemrDmChanDoanHinhAnh(tbl_emrChanDoanHinhAnh item)
    {
        emrDmChanDoanHinhAnh emrDmChanDoanHinhAnh = new emrDmChanDoanHinhAnh();
        if (item != null)
            emrDmChanDoanHinhAnh.ma = getMaDTT(item.emrDmChanDoanHinhAnh, "DM25");
        return emrDmChanDoanHinhAnh;
    }

    private emrChanDoan getemrChanDoan(int IdDanhSachHSBA, string maHSBA, string maLoaiBA)
    {
        emrChanDoan emrChanDoan = new emrChanDoan();
        if (_IsBVTWHue)
        {
            var item = _dbContext.sp_Insert_tbl_emrChanDoan(maHSBA, maLoaiBA, IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {
                emrChanDoan.bibienchung = CheckNullReturnTrueFalse(item.bibienchung);
                emrChanDoan.bitaibien = CheckNullReturnTrueFalse(item.bitaibien);
                emrChanDoan.emrDmLyDoTaiBienBienChung = getemrDmLyDoTaiBienBienChung(item.emrDmLyDoTaiBienBienChung);
                emrChanDoan.emrDmMaBenhByIdicdChandoandieutri = getemrDmMaBenhByIdicdChandoandieutri(item.emrDmMaBenhByIdicdChandoandieutri);
                emrChanDoan.emrDmMaBenhByIdicdChandoankkb = getemrDmMaBenhByIdicdChandoankkb(item.emrDmMaBenhByIdicdChandoankkb);
                emrChanDoan.emrDmMaBenhByIdicdChandoannoiden = getemrDmMaBenhByIdicdChandoannoiden(item.emrDmMaBenhByIdicdChandoannoiden);
                emrChanDoan.emrDmMaBenhByIdicdChandoanravienchinh = getemrDmMaBenhByIdicdChandoanravienchinh(item.emrDmMaBenhByIdicdChandoanravienchinh);
                emrChanDoan.emrDmMaBenhByIdicdChandoanravienkemtheo = getemrDmMaBenhByIdicdChandoanravienkemtheo(item.emrDmMaBenhByIdicdChandoanravienkemtheo);
                emrChanDoan.emrDmMaBenhByIdicdChandoanraviennguyennhan = getemrDmMaBenhByIdicdChandoanraviennguyennhan(item.emrDmMaBenhByIdicdChandoanraviennguyennhan);
                emrChanDoan.emrDmMaBenhByIdicdChandoansaupt = getemrDmMaBenhByIdicdChandoansaupt(item.emrDmMaBenhByIdicdChandoansaupt);
                emrChanDoan.emrDmMaBenhByIdicdChandoantruocpt = getemrDmMaBenhByIdicdChandoantruocpt(item.emrDmMaBenhByIdicdChandoantruocpt);
                emrChanDoan.motachandoandieutri = item.motachandoandieutri;
                emrChanDoan.motachandoankkb = item.motachandoankkb;
                emrChanDoan.motachandoannoiden = item.motachandoannoiden;
                emrChanDoan.motachandoanravienchinh = item.motachandoanravienchinh;
                emrChanDoan.motachandoanravienkemtheo = item.motachandoanravienkemtheo;
                emrChanDoan.motachandoanraviennguyennhan = item.motachandoanraviennguyennhan;
                emrChanDoan.motachandoansaupt = item.motachandoansaupt;
                emrChanDoan.motachandoantruocpt = item.motachandoantruocpt;
                emrChanDoan.tongsolanpt = CheckNull(item.tongsolanpt);
                emrChanDoan.tongsongaysaupt = CheckNull(item.tongsongaysaupt);

            }
        }
        else
        {
            var item = _dbContext.tbl_emrChanDoans.Where(x => x.IDDanhSachHSBA == IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {
                emrChanDoan.bibienchung = CheckNullReturnTrueFalse(item.bibienchung);
                emrChanDoan.bitaibien = CheckNullReturnTrueFalse(item.bitaibien);
                emrChanDoan.emrDmLyDoTaiBienBienChung = getemrDmLyDoTaiBienBienChung(item.emrDmLyDoTaiBienBienChung);
                emrChanDoan.emrDmMaBenhByIdicdChandoandieutri = getemrDmMaBenhByIdicdChandoandieutri(item.emrDmMaBenhByIdicdChandoandieutri);
                emrChanDoan.emrDmMaBenhByIdicdChandoankkb = getemrDmMaBenhByIdicdChandoankkb(item.emrDmMaBenhByIdicdChandoankkb);
                emrChanDoan.emrDmMaBenhByIdicdChandoannoiden = getemrDmMaBenhByIdicdChandoannoiden(item.emrDmMaBenhByIdicdChandoannoiden);
                emrChanDoan.emrDmMaBenhByIdicdChandoanravienchinh = getemrDmMaBenhByIdicdChandoanravienchinh(item.emrDmMaBenhByIdicdChandoanravienchinh);
                emrChanDoan.emrDmMaBenhByIdicdChandoanravienkemtheo = getemrDmMaBenhByIdicdChandoanravienkemtheo(item.emrDmMaBenhByIdicdChandoanravienkemtheo);
                emrChanDoan.emrDmMaBenhByIdicdChandoanraviennguyennhan = getemrDmMaBenhByIdicdChandoanraviennguyennhan(item.emrDmMaBenhByIdicdChandoanraviennguyennhan);
                emrChanDoan.emrDmMaBenhByIdicdChandoansaupt = getemrDmMaBenhByIdicdChandoansaupt(item.emrDmMaBenhByIdicdChandoansaupt);
                emrChanDoan.emrDmMaBenhByIdicdChandoantruocpt = getemrDmMaBenhByIdicdChandoantruocpt(item.emrDmMaBenhByIdicdChandoantruocpt);
                emrChanDoan.motachandoandieutri = item.motachandoandieutri;
                emrChanDoan.motachandoankkb = item.motachandoankkb;
                emrChanDoan.motachandoannoiden = item.motachandoannoiden;
                emrChanDoan.motachandoanravienchinh = item.motachandoanravienchinh;
                emrChanDoan.motachandoanravienkemtheo = item.motachandoanravienkemtheo;
                emrChanDoan.motachandoanraviennguyennhan = item.motachandoanraviennguyennhan;
                emrChanDoan.motachandoansaupt = item.motachandoansaupt;
                emrChanDoan.motachandoantruocpt = item.motachandoantruocpt;
                emrChanDoan.tongsolanpt = CheckNull(item.tongsolanpt);
                emrChanDoan.tongsongaysaupt = CheckNull(item.tongsongaysaupt);

            }
        }


        return emrChanDoan;

    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoantruocpt(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoansaupt(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoanraviennguyennhan(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoanravienkemtheo(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoanravienchinh(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoannoiden(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoankkb(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoandieutri(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmLyDoTaiBienBienChung getemrDmLyDoTaiBienBienChung(string item)
    {
        emrDmLyDoTaiBienBienChung emrDmLyDoTaiBienBienChung = new emrDmLyDoTaiBienBienChung();
        if (item != null)
            emrDmLyDoTaiBienBienChung.ma = getMaDTT(item, "DM16");
        return emrDmLyDoTaiBienBienChung;
    }

    private emrXetNghiem[] getemrXetNghiems(int IdDanhSachHSBA)
    {

        List<emrXetNghiem> listItem = new List<emrXetNghiem>();
        var tblemrXetNghiem = from p in _dbContext.tbl_emrXetNghiems where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listemrXetNghiem = tblemrXetNghiem.DefaultIfEmpty().ToArray();
        if (listemrXetNghiem != null)
            foreach (tbl_emrXetNghiem item in listemrXetNghiem)
            {
                if (item != null)
                {
                    emrXetNghiem emrXetNghiem = new emrXetNghiem();
                    emrXetNghiem.bacsixetnghiem = item.bacsixetnghiem;
                    emrXetNghiem.bacsiyeucau = item.bacsiyeucau;
                    emrXetNghiem.emrDmLoaiXetNghiem = getemrDmLoaiXetNghiem(item);
                    emrXetNghiem.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrXetNghiem.ngayyeucau = toDateFormat(item.ngayyeucau);
                    emrXetNghiem.nhanxet = item.nhanxet;
                    int STT = 0;
                    if (item.STT != null)
                        STT = int.Parse(item.STT.ToString());
                    emrXetNghiem.emrQuanLyFileDinhKemXn = getemrQuanLyFileDinhKemXn(STT, item.IdemrXetNghiem, IdDanhSachHSBA);
                    emrXetNghiem.noidungyeucau = item.noidungyeucau;
                    emrXetNghiem.emrXetNghiemDichVus = getemrXetNghiemDichVus(item.IdemrXetNghiem);
                    listItem.Add(emrXetNghiem);
                }
            }
        return listItem.ToArray();

    }
    private string formatTenFile(string input)
    {
        if (input.Split('\\').Length > 0 || input.Split('/').Length > 0)
        {
            string output = string.Empty;
            List<string> list = new List<string>();
            //if (input.Split('\\').Length > 0)
            //    foreach (string item in input.Split('\\'))
            //    {
            //        list.Add(item);
            //    }

            // else

            if (input.Split('/').Length > 0)
            {
                foreach (string item in input.Split('/'))
                {
                    list.Add(item);
                }

                foreach (string item in list)
                {
                    output += item;
                }
                return output;
            }
            else
                return input;
        }
        else
            return input;
    }
    private string SaveFileXNKQ(int IdemrXetNghiem)
    {
        var FileXN = from p in _dbContext.tbl_emrQuanLyFileDinhKemXns where p.IdemrXetNghiem == IdemrXetNghiem select p;
        var itemFileXN = FileXN.DefaultIfEmpty().ToArray();
        string tenfile = string.Empty;
        if (itemFileXN[0] != null)
            tenfile += formatTenFile(itemFileXN[0].tenfile);
        // tenfile += (itemFileXN[0].tenfile);
        if (!string.IsNullOrEmpty(tenfile))
        {
            if (File.Exists(Server.MapPath(tenfile)))
            {
                File.Delete(Server.MapPath(tenfile));
                StreamWriter file = new StreamWriter(Server.MapPath(tenfile), true, Encoding.UTF8);
                file.Write(itemFileXN[0].noiDungFile);
                file.Close();
            }
        }

        return tenfile;
    }
    private string SaveFileCDHA(int STT, int IdDanhSachHSBA)
    {
        var FileXN = from p in _dbContext.tbl_emrQuanLyFileDinhKemCdhas where p.STT == STT && p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var itemFileXN = FileXN.DefaultIfEmpty().ToArray();
        string tenfile = string.Empty;
        if (itemFileXN[0] != null)
            tenfile += formatTenFile(itemFileXN[0].tenfile);
        //tenfile += (itemFileXN[0].tenfile);
        foreach (string itemFile in Directory.GetFiles(Server.MapPath("")))
        {
            if (!string.IsNullOrEmpty(tenfile))
            {
                if (tenfile.Equals(itemFile))
                    File.Delete(Server.MapPath(tenfile));
                StreamWriter file = new StreamWriter(Server.MapPath(tenfile), true, Encoding.UTF8);
                file.Write(itemFileXN[0].noidung);
                file.Close();
                break;
            }
        }


        return tenfile;
    }
    private string SaveFileTDCN(int STT, int IdDanhSachHSBA)
    {
        var FileXN = from p in _dbContext.tbl_emrQuanLyFileDinhKemTdcns where p.STT == STT && p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var itemFileXN = FileXN.DefaultIfEmpty().ToArray();
        string tenfile = string.Empty;
        if (itemFileXN[0] != null)
            tenfile += formatTenFile(itemFileXN[0].tenfile);
        //tenfile += (itemFileXN[0].tenfile);
        if (!string.IsNullOrEmpty(tenfile))
        {
            if (File.Exists(Server.MapPath(tenfile)))
                File.Delete(Server.MapPath(tenfile));
            StreamWriter file = new StreamWriter(Server.MapPath(tenfile), true, Encoding.UTF8);
            file.Write(itemFileXN[0].noiDungFile);
            file.Close();
        }

        return tenfile;
    }
    private emrQuanLyFileDinhKemXn[] getemrQuanLyFileDinhKemXn(int STT, int idemrXetNghiem, int idDanhSachHSBA)// Xét nghiệm loại =1
    {
        List<emrQuanLyFileDinhKemXn> list = new List<emrQuanLyFileDinhKemXn>();
        emrQuanLyFileDinhKemXn emrQuanLyFileDinhKemXn = new emrQuanLyFileDinhKemXn();
        string tenFilePath = SaveFileXNKQ(idemrXetNghiem);
        emrQuanLyFileDinhKemXn emrQuanLyFileDinhKemXn2 = new emrQuanLyFileDinhKemXn();
        if (STT != 0)
        {
            var File = from p in _dbContext.tbl_emrQuanLyFileDinhKems where p.IdDanhSachHSBA == idDanhSachHSBA && p.STT == STT && p.IdLoaiFileDinhKem == 1 select p;

            var item = File.DefaultIfEmpty().ToArray();
            if (item[0] != null)
            {
                emrQuanLyFileDinhKemXn2.tenfile = ConvertVN(item[0].tenfile);
                emrQuanLyFileDinhKemXn2.noiDungFile = GetData(item[0].duongdan);
                list.Add(emrQuanLyFileDinhKemXn2);
            }
        }
        if (!string.IsNullOrEmpty(tenFilePath))
        {
            emrQuanLyFileDinhKemXn.tenfile = ConvertVN(tenFilePath);
            emrQuanLyFileDinhKemXn.noiDungFile = convertBase64ByFile(Server.MapPath(formatTenFile(tenFilePath)));
            //emrQuanLyFileDinhKemXn.noiDungFile = convertBase64ByFile(Server.MapPath((tenFilePath)));
            list.Add(emrQuanLyFileDinhKemXn);
        }

        return list.ToArray();
    }

    private emrXetNghiemDichVu[] getemrXetNghiemDichVus(int IdemrXetNghiem)
    {
        List<emrXetNghiemDichVu> listItem = new List<emrXetNghiemDichVu>();
        var tbl_xetnghiemdichvu = from p in _dbContext.tbl_emrXetNghiemDichVus where p.IdemrXetNghiem == IdemrXetNghiem select p;
        var listXetNghiem = tbl_xetnghiemdichvu.DefaultIfEmpty().ToArray();
        if (listXetNghiem != null)
            foreach (tbl_emrXetNghiemDichVu item in listXetNghiem)
            {
                if (item != null)
                {
                    emrXetNghiemDichVu emrXetNghiemDichVu = new emrXetNghiemDichVu();
                    emrXetNghiemDichVu.emrDmXetNghiem = getemrDmXetNghiem(item);
                    emrXetNghiemDichVu.emrXetNghiemKetQuas = getemrXetNghiemKetQuas(item.IdemrXetNghiemDichVu);

                    listItem.Add(emrXetNghiemDichVu);
                }
            }
        return listItem.ToArray();

    }

    private emrXetNghiemKetQua[] getemrXetNghiemKetQuas(int IdemrXetNghiemDichVu)
    {

        List<emrXetNghiemKetQua> listemrXetNghiemKetQua = new List<emrXetNghiemKetQua>();
        var tbl_XetNghiemKetQua = from p in _dbContext.tbl_emrXetNghiemKetQuas where p.IdemrXetNghiemDichVu == IdemrXetNghiemDichVu select p;
        var listKetQua = tbl_XetNghiemKetQua.DefaultIfEmpty().ToArray();
        if (listKetQua != null)
            foreach (tbl_emrXetNghiemKetQua item in listKetQua)
            {
                if (item != null)
                {
                    emrXetNghiemKetQua emrXetNghiemKetQua = new emrXetNghiemKetQua();
                    emrXetNghiemKetQua.emrDmChiSoXetNghiem = getemrDmChiSoXetNghiem(item);
                    emrXetNghiemKetQua.emrDmDichKetQuaXetNghiem = getemrDmDichKetQuaXetNghiem(item);
                    emrXetNghiemKetQua.giatrido = item.giatrido;
                    listemrXetNghiemKetQua.Add(emrXetNghiemKetQua);
                }
            }

        return listemrXetNghiemKetQua.ToArray();

    }

    private emrDmDichKetQuaXetNghiem getemrDmDichKetQuaXetNghiem(tbl_emrXetNghiemKetQua item)
    {
        emrDmDichKetQuaXetNghiem emrDmDichKetQuaXetNghiem = new emrDmDichKetQuaXetNghiem();
        if (item != null)
            emrDmDichKetQuaXetNghiem.ma = getMaDTT(item.emrDmDichKetQuaXetNghiem, "DM35");
        return emrDmDichKetQuaXetNghiem;
    }

    private emrDmChiSoXetNghiem getemrDmChiSoXetNghiem(tbl_emrXetNghiemKetQua item)
    {
        emrDmChiSoXetNghiem emrDmChiSoXetNghiem = new emrDmChiSoXetNghiem();
        if (item != null)
            emrDmChiSoXetNghiem.ma = getMaDTT(item.emrDmChiSoXetNghiem, "DM34");
        return emrDmChiSoXetNghiem;
    }

    private emrDmXetNghiem getemrDmXetNghiem(tbl_emrXetNghiemDichVu item)
    {
        emrDmXetNghiem emrDmXetNghiem = new emrDmXetNghiem();
        if (item != null)
            emrDmXetNghiem.ma = getMaDTT(item.emrDmXetNghiem, "DM24");
        return emrDmXetNghiem;
    }

    private emrDmLoaiXetNghiem getemrDmLoaiXetNghiem(tbl_emrXetNghiem item)
    {
        emrDmLoaiXetNghiem emrDmLoaiXetNghiem = new emrDmLoaiXetNghiem();
        if (item != null)
            emrDmLoaiXetNghiem.ma = getMaDTT(item.emrDmLoaiXetNghiem, "DM30");
        return emrDmLoaiXetNghiem;
    }

    private emrPhauThuatThuThuat[] getemrPhauThuatThuThuats(int IdDanhSachHSBA)
    {

        List<emrPhauThuatThuThuat> list = new List<emrPhauThuatThuThuat>();
        var tbl_emrPhauThuatThuThuat = from p in _dbContext.tbl_emrPhauThuatThuThuats where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listitem = tbl_emrPhauThuatThuThuat.DefaultIfEmpty().ToArray();
        if (listitem != null)
            foreach (tbl_emrPhauThuatThuThuat item in listitem)
            {
                if (item != null)
                {
                    emrPhauThuatThuThuat emrPhauThuatThuThuat = new emrPhauThuatThuThuat();
                    emrPhauThuatThuThuat.bacsithuchien = item.bacsithuchien;
                    emrPhauThuatThuThuat.bacsygayme = item.bacsygayme;
                    emrPhauThuatThuThuat.chidinhptt = item.chidinhptt;
                    emrPhauThuatThuThuat.emrDmMaBenhByIdicdchandoansau = getemrDmMaBenhByIdicdchandoansau(item);
                    emrPhauThuatThuThuat.emrDmMaBenhByIdicdchandoantruoc = getemrDmMaBenhByIdicdchandoantruoc(item);
                    emrPhauThuatThuThuat.emrDmPhauThuThuat = getemrDmPhauThuThuat(item);
                    emrPhauThuatThuThuat.luocdoptt = item.luocdoptt;
                    emrPhauThuatThuThuat.motachandoansaupt = item.motachandoansaupt;
                    emrPhauThuatThuThuat.motachandoantruocpt = item.motachandoantruocpt;
                    emrPhauThuatThuThuat.ngaygiopttt = toDateFormat(item.ngaygiopttt);
                    emrPhauThuatThuThuat.phuongphapvocam = item.phuongphapvocam;
                    emrPhauThuatThuThuat.trinhtuptt = item.trinhtuptt;
                    // Tạm thời rào code lại DTT chưa deploy object này cho Huế và YHCT
                    emrPhauThuatThuThuat.loaiMo = CheckNull(item.loaimo_chklist);
                    // emrPhauThuatThuThuat.loaiMo = "1";// CheckNull(item.loaimo_chklist);
                    emrPhauThuatThuThuat.emrHoiDongPttts = getemrHoiDongPttts(item.IdemrPhauThuatThuThuat);
                    list.Add(emrPhauThuatThuThuat);
                }
            }
        return list.ToArray();

    }

    private emrHoiDongPttt[] getemrHoiDongPttts(int IdemrPhauThuatThuThuat)
    {

        List<emrHoiDongPttt> list = new List<emrHoiDongPttt>();
        var tblemrHoiDongPttt = from p in _dbContext.tbl_emrHoiDongPttts where p.IdemrPhauThuatThuThuat == IdemrPhauThuatThuThuat select p;
        var listItem = tblemrHoiDongPttt.DefaultIfEmpty().ToArray();
        if (listItem != null)
            foreach (tbl_emrHoiDongPttt item in listItem)
            {
                if (item != null)
                {
                    emrHoiDongPttt emrHoiDongPttt = new emrHoiDongPttt();
                    emrHoiDongPttt.idvaitro = CheckNull(item.idvaitro);
                    emrHoiDongPttt.tenbacsi = item.tenbacsi;
                    list.Add(emrHoiDongPttt);
                }
            }
        return list.ToArray();

    }

    private emrDmPhauThuThuat getemrDmPhauThuThuat(tbl_emrPhauThuatThuThuat item)
    {
        emrDmPhauThuThuat emrDmPhauThuThuat = new emrDmPhauThuThuat();
        if (item != null)
            emrDmPhauThuThuat.ma = getMaDTT(item.emrDmPhauThuThuat, "DM22");
        return emrDmPhauThuThuat;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdchandoantruoc(tbl_emrPhauThuatThuThuat item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item.emrDmMaBenhByIdicdchandoantruoc;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdchandoansau(tbl_emrPhauThuatThuThuat item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item.emrDmMaBenhByIdicdchandoansau;
        return emrDmMaBenh;

    }

    private emrTongKetRaVien getemrTongKetRaVien(int IdDanhSachHSBA)
    {

        emrTongKetRaVien emrTongKetRaVien = new emrTongKetRaVien();
        var tbl_emrTongKetRaVien = from p in _dbContext.tbl_emrTongKetRaViens where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrTongKetRaVien.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrTongKetRaVien.bacsydieutri = item.bacsydieutri;
            emrTongKetRaVien.canlamsang = item.canlamsang;
            emrTongKetRaVien.chidandieutri = item.chidandieutri;
            emrTongKetRaVien.dienbienlamsang = item.dienbienlamsang;
            emrTongKetRaVien.ngaybacsydieutriky = toDateFormat(item.ngaybacsydieutriky);
            emrTongKetRaVien.ngaygiaohoso = toDateFormat(item.ngaygiaohoso);
            emrTongKetRaVien.ngaynhanhoso = toDateFormat(item.ngaynhanhoso);
            emrTongKetRaVien.nguoigiaohoso = item.nguoigiaohoso;
            emrTongKetRaVien.nguoinhanhoso = item.nguoinhanhoso;
            emrTongKetRaVien.phuongphapdieutri = item.phuongphapdieutri;
            emrTongKetRaVien.tinhtrangnguoibenh = item.tinhtrangnguoibenh;
            emrTongKetRaVien.emrCkPhuongPhapDieuTriUngBuou = getemrCkPhuongPhapDieuTriUngBuou(IdDanhSachHSBA);
            if (!_IsBVPhuSan && !_IsBVYHocCoTruyen)
                emrTongKetRaVien.emrCkTinhTrangRaVienMat = getemrCkTinhTrangRaVienMat(IdDanhSachHSBA);
        }
        return emrTongKetRaVien;

    }

    private emrCkTinhTrangRaVienMat getemrCkTinhTrangRaVienMat(int IdDanhSachHSBA)
    {
        emrCkTinhTrangRaVienMat emrCkTinhTrangRaVienMat = new emrCkTinhTrangRaVienMat();
        var item = _dbContext.tbl_emrCkTinhTrangRaVienMats.Where(x => x.IdDanhSachHSBA == IdDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            emrCkTinhTrangRaVienMat.nhanapphai = item.nhanapphai;
            emrCkTinhTrangRaVienMat.nhanaptrai = item.nhanaptrai;
            emrCkTinhTrangRaVienMat.thiluccokinhphai = item.thiluccokinhphai;
            emrCkTinhTrangRaVienMat.thiluccokinhtrai = item.thiluccokinhtrai;
            emrCkTinhTrangRaVienMat.thiluckhongkinhphai = item.thiluckhongkinhphai;
            emrCkTinhTrangRaVienMat.thiluckhongkinhtrai = item.thiluckhongkinhtrai;
        }

        return emrCkTinhTrangRaVienMat;
    }

    private emrCkPhuongPhapDieuTriUngBuou getemrCkPhuongPhapDieuTriUngBuou(int IdDanhSachHSBA)
    {

        emrCkPhuongPhapDieuTriUngBuou emrCkPhuongPhapDieuTriUngBuou = new emrCkPhuongPhapDieuTriUngBuou();
        var tbl_emrckPhuongPhapDieuTriUngBuou = from p in _dbContext.tbl_emrCkPhuongPhapDieuTriUngBuous where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrckPhuongPhapDieuTriUngBuou.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkPhuongPhapDieuTriUngBuou.dapung = item.dapung;
            emrCkPhuongPhapDieuTriUngBuou.dieutrikhac = item.dieutrikhac;
            emrCkPhuongPhapDieuTriUngBuou.hoachat = item.hoachat;
            emrCkPhuongPhapDieuTriUngBuou.kieudieutri = item.kieudieutri;
            emrCkPhuongPhapDieuTriUngBuou.phauthuatu = item.phauthuatu;
            emrCkPhuongPhapDieuTriUngBuou.sodot = CheckNull(item.sodot);
            emrCkPhuongPhapDieuTriUngBuou.tiaxadonthuantaihach = item.tiaxadonthuantaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxadonthuantaiu = item.tiaxadonthuantaiu;
            emrCkPhuongPhapDieuTriUngBuou.tiaxahauphautaihach = item.tiaxahauphautaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxahauphautaiu = item.tiaxahauphautaiu;
            emrCkPhuongPhapDieuTriUngBuou.tiaxatienphautaihach = item.tiaxatienphautaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxatienphautaiu = item.tiaxatienphautaiu;
        }
        return emrCkPhuongPhapDieuTriUngBuou;

    }

    private emrDmLoaiBenhAn getEmrDmLoaiBenhAn(sp_HSBATransferResult item)
    {
        emrDmLoaiBenhAn emrDmLoaiBenhAn = new emrDmLoaiBenhAn();
        if (item != null)
            emrDmLoaiBenhAn.ma = getMaDTT(item.emrDmLoaiBenhAn, "DM17");
        return emrDmLoaiBenhAn;
    }
    private string toDateFormat(DateTime? date)
    {
        return date.HasValue == true ? date.Value.ToString("yyyy-MM-dd HH:mm:ss") : string.Empty;
    }
    private emrBenhNhan GetemrBenhNhan(int IdDanhSachHSBA, string maLoaiBA, string maHSBA)
    {
        emrBenhNhan emrBenhNhan = new emrBenhNhan();
        if (_IsBVTWHue)
        {
            var item = _dbContext.sp_Insert_tbl_emrBenhNhan(maHSBA, maLoaiBA, IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {
                emrBenhNhan.diachi = item.diachi;
                emrBenhNhan.diachinguoibaotin = item.diachinguoibaotin;
                emrBenhNhan.emrDmDanToc = getemrDmDanToc(item.emrDmDanToc);
                emrBenhNhan.emrDmDonViHanhChinhByIdphuongxa = getemrDmDonViHanhChinhByIdphuongxa(item.emrDmDonViHanhChinhByIdphuongxa);
                emrBenhNhan.emrDmDonViHanhChinhByIdquanhuyen = getemrDmDonViHanhChinhByIdquanhuyen(item.emrDmDonViHanhChinhByIdquanhuyen);
                emrBenhNhan.emrDmDonViHanhChinhByIdtinhthanh = getemrDmDonViHanhChinhByIdtinhthanh(item.emrDmDonViHanhChinhByIdtinhthanh);
                emrBenhNhan.emrDmGioiTinh = getemrDmGioiTinh(item.emrDmGioiTinh);
                emrBenhNhan.emrDmNgheNghiepByIdnghebo = getemrDmNgheNghiepByIdnghebo(item.emrDmNgheNghiepByIdnghebo);
                emrBenhNhan.emrDmNgheNghiepByIdngheme = getemrDmNgheNghiepByIdngheme(item.emrDmNgheNghiepByIdngheme);
                emrBenhNhan.emrDmNgheNghiepByIdnghenghiep = getemrDmNgheNghiepByIdnghenghiep(item.emrDmNgheNghiepByIdnghenghiep);
                emrBenhNhan.emrDmQuocGia = getemrDmQuocGia(item.emrDmQuocGia);
                emrBenhNhan.hotenbo = item.hotenbo;
                emrBenhNhan.hotenme = item.hotenme;
                emrBenhNhan.iddinhdanhchinh = item.emrBenhNhaniddinhdanhchinh;
                emrBenhNhan.iddinhdanhphu = item.emrBenhNhaniddinhdanhphu;
                emrBenhNhan.idhis = item.emrBenhNhanidhis;
                emrBenhNhan.ngayhethanthebhyt = toDateFormat(item.ngayhethanthebhyt);
                emrBenhNhan.ngaysinh = toDateFormat(item.NgaySinh);
                emrBenhNhan.ngaySinhCuaMe = toDateFormat(item.ngaySinhCuaMe);
                emrBenhNhan.ngaySinhCuaBo = toDateFormat(item.ngaySinhCuaBo);
                emrBenhNhan.noilamviec = item.noilamviec;
                if (!string.IsNullOrEmpty(item.sobhyt))
                    emrBenhNhan.sobhyt = item.sobhyt.ToUpper();
                emrBenhNhan.sodienthoainguoibaotin = item.sodienthoainguoibaotin;
                emrBenhNhan.tendaydu = item.tendaydu;
                emrBenhNhan.tennguoibaotin = item.tennguoibaotin;
                emrBenhNhan.trinhDoVanHoaCuaBo = item.trinhDoVanHoaCuaBo;
                emrBenhNhan.trinhDoVanHoaCuaMe = item.trinhDoVanHoaCuaMe;
                emrBenhNhan.tuoi = CheckNull(item.Tuoi);
            }
        }
        else
        {
            var item = _dbContext.tbl_emrBenhNhans.Where(x => x.IDDanhSachHSBA == IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {
                emrBenhNhan.diachi = item.diachi;
                emrBenhNhan.diachinguoibaotin = item.diachinguoibaotin;
                emrBenhNhan.emrDmDanToc = getemrDmDanToc(item.emrDmDanToc);
                emrBenhNhan.emrDmDonViHanhChinhByIdphuongxa = getemrDmDonViHanhChinhByIdphuongxa(item.emrDmDonViHanhChinhByIdphuongxa);
                emrBenhNhan.emrDmDonViHanhChinhByIdquanhuyen = getemrDmDonViHanhChinhByIdquanhuyen(item.emrDmDonViHanhChinhByIdquanhuyen);
                emrBenhNhan.emrDmDonViHanhChinhByIdtinhthanh = getemrDmDonViHanhChinhByIdtinhthanh(item.emrDmDonViHanhChinhByIdtinhthanh);
                emrBenhNhan.emrDmGioiTinh = getemrDmGioiTinh(item.emrDmGioiTinh);
                emrBenhNhan.emrDmNgheNghiepByIdnghebo = getemrDmNgheNghiepByIdnghebo(item.emrDmNgheNghiepByIdnghebo);
                emrBenhNhan.emrDmNgheNghiepByIdngheme = getemrDmNgheNghiepByIdngheme(item.emrDmNgheNghiepByIdngheme);
                emrBenhNhan.emrDmNgheNghiepByIdnghenghiep = getemrDmNgheNghiepByIdnghenghiep(item.emrDmNgheNghiepByIdnghenghiep);
                emrBenhNhan.emrDmQuocGia = getemrDmQuocGia(item.emrDmQuocGia);
                emrBenhNhan.hotenbo = item.hotenbo;
                emrBenhNhan.hotenme = item.hotenme;
                emrBenhNhan.iddinhdanhchinh = item.iddinhdanhchinh;
                emrBenhNhan.iddinhdanhphu = item.iddinhdanhphu;
                emrBenhNhan.idhis = item.idhis;
                emrBenhNhan.ngayhethanthebhyt = toDateFormat(item.ngayhethanthebhyt);
                emrBenhNhan.ngaysinh = toDateFormat(item.ngaysinh);
                emrBenhNhan.ngaySinhCuaMe = toDateFormat(item.ngaySinhCuaMe);
                emrBenhNhan.ngaySinhCuaBo = toDateFormat(item.ngaySinhCuaBo);
                emrBenhNhan.noilamviec = item.noilamviec;
                if (!string.IsNullOrEmpty(item.sobhyt))
                    emrBenhNhan.sobhyt = item.sobhyt.ToUpper();
                emrBenhNhan.sodienthoainguoibaotin = item.sodienthoainguoibaotin;
                emrBenhNhan.tendaydu = item.tendaydu;
                emrBenhNhan.tennguoibaotin = item.tennguoibaotin;
                emrBenhNhan.trinhDoVanHoaCuaBo = item.trinhDoVanHoaCuaBo;
                emrBenhNhan.trinhDoVanHoaCuaMe = item.trinhDoVanHoaCuaMe;
                emrBenhNhan.tuoi = CheckNull(item.tuoi);
            }

        }
        return emrBenhNhan;
    }

    private emrDmQuocGia getemrDmQuocGia(string itememrDmQuocGia)
    {
        emrDmQuocGia emrDmQuocGia = new emrDmQuocGia();
        if (string.IsNullOrEmpty(itememrDmQuocGia))
            emrDmQuocGia.ma = getMaDTT(itememrDmQuocGia, "DM40");
        return emrDmQuocGia;

    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdnghenghiep(string itememrDmNgheNghiepByIdnghenghiep)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (string.IsNullOrEmpty(itememrDmNgheNghiepByIdnghenghiep))
            emrDmNgheNghiep.ma = getMaDTT(itememrDmNgheNghiepByIdnghenghiep, "DM04");
        return emrDmNgheNghiep;
    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdngheme(string itememrDmNgheNghiepByIdngheme)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (string.IsNullOrEmpty(itememrDmNgheNghiepByIdngheme))
            emrDmNgheNghiep.ma = getMaDTT(itememrDmNgheNghiepByIdngheme, "DM04");
        return emrDmNgheNghiep;
    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdnghebo(string itememrDmNgheNghiepByIdnghebo)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (string.IsNullOrEmpty(itememrDmNgheNghiepByIdnghebo))
            emrDmNgheNghiep.ma = getMaDTT(itememrDmNgheNghiepByIdnghebo, "DM04");
        return emrDmNgheNghiep;
    }

    private emrDmGioiTinh getemrDmGioiTinh(string itememrDmGioiTinh)
    {
        emrDmGioiTinh emrDmGioiTinh = new emrDmGioiTinh();
        if (!string.IsNullOrEmpty(itememrDmGioiTinh))
            emrDmGioiTinh.ma = itememrDmGioiTinh;
        return emrDmGioiTinh;
    }

    private emrDmDonViHanhChinh getemrDmDonViHanhChinhByIdtinhthanh(string itememrDmDonViHanhChinhByIdtinhthanh)
    {
        emrDmDonViHanhChinh emrDmDonViHanhChinh = new emrDmDonViHanhChinh();
        if (string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdtinhthanh))
            emrDmDonViHanhChinh.ma = getMaDTT(itememrDmDonViHanhChinhByIdtinhthanh, "DM05");
        return emrDmDonViHanhChinh;
    }

    private emrDmDonViHanhChinh getemrDmDonViHanhChinhByIdquanhuyen(string itememrDmDonViHanhChinhByIdquanhuyen)
    {
        emrDmDonViHanhChinh emrDmDonViHanhChinh = new emrDmDonViHanhChinh();
        if (!string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdquanhuyen))
            emrDmDonViHanhChinh.ma = getMaDTT(itememrDmDonViHanhChinhByIdquanhuyen, "DM05");
        return emrDmDonViHanhChinh;
    }

    private emrDmDonViHanhChinh getemrDmDonViHanhChinhByIdphuongxa(string itememrDmDonViHanhChinhByIdphuongxa)
    {
        emrDmDonViHanhChinh emrDmDonViHanhChinh = new emrDmDonViHanhChinh();
        if (string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdphuongxa))
            emrDmDonViHanhChinh.ma = getMaDTT(itememrDmDonViHanhChinhByIdphuongxa, "DM05");
        return emrDmDonViHanhChinh;
    }

    private emrDmDanToc getemrDmDanToc(string itememrDmDanToc)
    {
        emrDmDanToc emrDmDanToc = new emrDmDanToc();
        if (itememrDmDanToc != null)
            emrDmDanToc.ma = getMaDTT(itememrDmDanToc, "DM03"); ;
        return emrDmDanToc;
    }

    #region getMapping
    private string getMaDTT(String HaThangKey, String DMKey)
    {
        //    Connection con = new Connection();
        string MaDTT = string.Empty;
        if (!String.IsNullOrEmpty(HaThangKey) && !String.IsNullOrEmpty(DMKey))
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand("sp_GetAllDetailMappingByHTKeyAndDMKey", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@HaThangKey", SqlDbType.NVarChar).Value = HaThangKey;
            com.Parameters.Add("@DMKey", SqlDbType.NVarChar).Value = DMKey;
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(com);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
                MaDTT = dr["MaKeyDTT"].ToString();
            return MaDTT;
            dr.Close();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    DataRow row = dt.Rows[0];
            //    MaDTT = row["MaKeyDTT"] is DBNull ? null: row["MaKeyDTT"].ToString();
            //    return MaDTT;
            //}
            //else
            //{
            //    return null;
            //}
            con.Close();
        }
        else
        {
            return null;
        }

    }
    #endregion

    #region Huyết áp
    private string formatNhietDo(string input)
    {
        string output = string.Empty;
        if (!string.IsNullOrEmpty(input))
        {

            if (input.Split(',').Count() > 1)
            {
                string[] list = input.Split(',');
                if (list.Count() > 0)
                    output = list[0] + "." + list[1];
            }
            else
                output = input;
        }
        return output;
    }
    private string returnHuyetApCaoThap(object input, int typeHuyetAp)
    {
        string output = string.Empty;
        string HuyetAp = string.Empty;
        if (input != null)
            HuyetAp = (string)input.ToString();
        if (!String.IsNullOrEmpty(HuyetAp))
        {
            int number1 = HuyetAp.IndexOf("/", 0);
            int number2 = HuyetAp.IndexOf("\\", 0);
            int length = int.Parse(HuyetAp.Length.ToString());
            if (number1 > 0)
            {
                // kiểu ký tự /    
                string[] CaoThap = HuyetAp.Split('/');
                if (typeHuyetAp == 1)
                    output = CaoThap[0];// Huyết áp cao
                else
                    output = CaoThap[1];// Huyết áp thấp
            }
            if (number2 > 0)
            {
                // kiểu ký tự \
                string[] CaoThap = HuyetAp.Split('\\');
                if (typeHuyetAp == 1)
                    output = CaoThap[0];// Huyết áp cao
                else
                    output = CaoThap[1];// Huyết áp thấp
            }
        }
        return output;
    }
    #endregion
    private emrBenhAn GetemrBenhAn(int IdDanhSachHSBA, string maBA, string maLoaiBA)
    {

        emrBenhAn emrBenhAn = new emrBenhAn();
        if (_IsBVTWHue) // Sau này sửa tất cả sau
        {
            var item = _dbContext.sp_Insert_tbl_emrBenhAn(maBA, maLoaiBA, IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {

                emrBenhAn.bacsylambenhan = item.bacsylambenhan;
                emrBenhAn.cannang = item.cannang;
                emrBenhAn.chieucao = item.chieucao;
                emrBenhAn.chucnangsinhhoat = item.chucnangsinhhoat;
                emrBenhAn.coquankhac = item.coquankhac;
                emrBenhAn.coxuongkhop = item.coxuongkhop;
                emrBenhAn.dacdiemkhac = CheckNull(item.dacdiemkhac);
                emrBenhAn.dalieu = item.dalieu;

                emrBenhAn.dungTuyen = CheckNullReturnTrueFalse(item.dungtuyen);
                emrBenhAn.tyLeBaoHiem = CheckNull(item.tylebaohiem);

                emrBenhAn.dichte = item.dichte;
                emrBenhAn.diung = CheckNull(item.diung);
                emrBenhAn.emrDmMaBenhByIdicdChandoanbenhchinh = getemrDmMaBenhByIdicdChandoanbenhchinh(item.emrDmMaBenhByIdicdChandoanbenhchinh);
                emrBenhAn.emrDmMaBenhByIdicdChandoankemtheo = getemrDmMaBenhByIdicdChandoankemtheo(item.emrDmMaBenhByIdicdChandoankemtheo);
                emrBenhAn.emrDmMaBenhByIdicdChandoanphanbiet = getemrDmMaBenhByIdicdChandoanphanbiet(item.emrDmMaBenhByIdicdChandoankemtheo);
                emrBenhAn.hohap = item.hohap;
                emrBenhAn.huongdieutri = item.huongdieutri;
                emrBenhAn.huyetapcao = returnHuyetApCaoThap(item.huyetapcao, 1);
                emrBenhAn.huyetapthap = returnHuyetApCaoThap(item.huyetapthap, 2);
                emrBenhAn.khamphukhoa = item.khamphukhoa;
                emrBenhAn.khamsankhoa = item.khamsankhoa;
                emrBenhAn.khamsosinh = item.khamsosinh;
                emrBenhAn.lydovaovien = item.lydovaovien;
                emrBenhAn.mach = item.mach;
                emrBenhAn.mat = item.mat;
                emrBenhAn.matuy = CheckNull(item.matuy);
                emrBenhAn.motachandoanbenhchinh = item.motachandoanbenhchinh;
                emrBenhAn.motachandoankemtheo = item.motachandoankemtheo;
                emrBenhAn.motachandoanphanbiet = item.motachandoanphanbiet;
                emrBenhAn.ngaykybenhan = toDateFormat(item.ngaykybenhan);
                emrBenhAn.nguonlay = item.nguonlay;
                emrBenhAn.nhietdo = formatNhietDo(item.nhietdo);
                emrBenhAn.nhiptho = item.nhiptho;
                emrBenhAn.noitietdinhduong = item.noitietdinhduong;
                emrBenhAn.phuongphaphoisinh = item.phuongphaphoisinh;
                emrBenhAn.quatrinhbenhly = item.quatrinhbenhly;
                emrBenhAn.quatrinhsinhtruong = CheckNull(item.quatrinhsinhtruong);
                emrBenhAn.ranghammat = CheckNull(item.ranghammat);
                emrBenhAn.ruoubia = CheckNull(item.ruoubia);
                emrBenhAn.taimuihong = item.taimuihong;
                emrBenhAn.tamthan = item.tamthan;
                emrBenhAn.taychanmieng = item.taychanmieng;
                emrBenhAn.thankinh = item.thankinh;
                emrBenhAn.thuocla = CheckNull(item.thuocla);
                emrBenhAn.thuoclao = CheckNull(item.thuoclao);
                emrBenhAn.tiemchung = item.tiemchung;
                emrBenhAn.tienluong = item.tienluong;
                emrBenhAn.tiensubanthan = item.tiensubanthan;
                emrBenhAn.tiensugiadinh = item.tiensugiadinh;
                emrBenhAn.tiensuphukhoa = item.tiensuphukhoa;
                emrBenhAn.tiensusankhoa = item.tiensusankhoa;
                emrBenhAn.tietnieusinhduc = item.tietnieusinhduc;
                emrBenhAn.tieuhoa = item.tieuhoa;
                emrBenhAn.tinhtrangsanphu = item.tinhtrangsanphu;
                emrBenhAn.tinhtrangsosinh = item.tinhtrangsosinh;
                emrBenhAn.toanthan = item.toanthan;
                emrBenhAn.tomtat = item.tomtat;
                emrBenhAn.tuanhoan = item.tuanhoan;
                emrBenhAn.vaongaythu = item.vaongaythu.HasValue == true ? (item.vaongaythu.Value.ToString().Equals("0") == true ? string.Empty : item.vaongaythu.Value.ToString()) : "";
                emrBenhAn.vongdau = item.vongdau;
                emrBenhAn.vongnguc = item.vongnguc;
                emrBenhAn.xetnghiemcanlamsang = item.xetnghiemcanlamsang;
                if (!_IsBVPhuSan && !_IsBVYHocCoTruyen)
                    emrBenhAn.emrCkMat = getemrCkMat(IdDanhSachHSBA);
                emrBenhAn.emrCkThanKinh = getemrCkThanKinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTamThan = getemrCkTamThan(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamSanKhoa = getemrCkKhamSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamPhuKhoa = getemrCkKhamPhuKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamSoSinh = getemrCkKhamSoSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTinhTrangSoSinh = getemrCkTinhTrangSoSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuSanKhoa = getemrCkTienSuSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkSkTinhTrangSanPhu = getemrCkSkTinhTrangSanPhu(IdDanhSachHSBA);
                emrBenhAn.emrCkTinhTrangSanPhu = getemrCkTinhTrangSanPhu(IdDanhSachHSBA);
                emrBenhAn.emrCkQuaTrinhSinhTruong = getemrCkQuaTrinhSinhTruong(IdDanhSachHSBA);
                emrBenhAn.emrCkToanThan = getemrCkToanThan(IdDanhSachHSBA);
                emrBenhAn.emrCkPhuongPhapHoiSinh = getemrCkPhuongPhapHoiSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTiemChung = getemrCkTiemChung(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuGiaDinh = getemrCkTienSuGiaDinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuBanThanSanKhoa = getemrCkTienSuBanThanSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuPhuKhoa = getemrCkTienSuPhuKhoa(IdDanhSachHSBA);
                emrBenhAn.tyletonthuongloai1 = CheckNull(item.tyletonthuongloai1);
                emrBenhAn.tyletonthuongloai2 = CheckNull(item.tyletonthuongloai2);
                emrBenhAn.tyletonthuongloai3 = CheckNull(item.tyletonthuongloai3);
                emrBenhAn.tyletonthuongloai4 = CheckNull(item.tyletonthuongloai4);
                emrBenhAn.tyletonthuongloai5 = CheckNull(item.tyletonthuongloai5);
                // Dành riêng bệnh án truyền nhiễm
                emrBenhAn.emrCkMoiSinh = getemrCkMoiSinh(IdDanhSachHSBA);
                // Dành riêng cho bệnh án PHCN
                emrBenhAn.emrCkChucNangSinhHoat = getemrCkChucNangSinhHoat(IdDanhSachHSBA);
                emrBenhAn.emrCkTuanHoan = getemrCkTuanHoan(IdDanhSachHSBA);
                emrBenhAn.emrCkTieuHoa = getemrCkTieuHoa(IdDanhSachHSBA);
                emrBenhAn.emrCkCoXuongKhop = getemrCkCoXuongKhop(IdDanhSachHSBA);
                emrBenhAn.emrCkHoHap = getemrCkHoHap(IdDanhSachHSBA);
                // Huyết học truyền máu
                emrBenhAn.emrCkHuongDieuTriHuyetHoc = getemrCkHuongDieuTriHuyetHoc(maBA,maLoaiBA);

            }
        }
        else
        {
            var item = _dbContext.tbl_emrBenhAns.Where(x => x.IDDanhSachHSBA == IdDanhSachHSBA).SingleOrDefault();
            if (item != null)
            {

                emrBenhAn.bacsylambenhan = item.bacsylambenhan;
                emrBenhAn.cannang = item.cannang;
                emrBenhAn.chieucao = item.chieucao;
                emrBenhAn.chucnangsinhhoat = item.chucnangsinhhoat;
                emrBenhAn.coquankhac = item.coquankhac;
                emrBenhAn.coxuongkhop = item.coxuongkhop;
                emrBenhAn.dacdiemkhac = item.dacdiemkhac;
                emrBenhAn.dalieu = item.dalieu;
                // Tạm thời rào code lại DTT chưa deploy object này cho Huế và YHCT
                emrBenhAn.dungTuyen = CheckNullReturnTrueFalse(item.dungtuyen);
                emrBenhAn.tyLeBaoHiem = CheckNull(item.tylebaohiem);
                //emrBenhAn.dungTuyen = "1";
                //emrBenhAn.tyLeBaoHiem = "100";
                emrBenhAn.dichte = item.dichte;
                emrBenhAn.diung = item.diung;
                emrBenhAn.emrDmMaBenhByIdicdChandoanbenhchinh = getemrDmMaBenhByIdicdChandoanbenhchinh(item.emrDmMaBenhByIdicdChandoanbenhchinh);
                emrBenhAn.emrDmMaBenhByIdicdChandoankemtheo = getemrDmMaBenhByIdicdChandoankemtheo(item.emrDmMaBenhByIdicdChandoankemtheo);
                emrBenhAn.emrDmMaBenhByIdicdChandoanphanbiet = getemrDmMaBenhByIdicdChandoanphanbiet(item.emrDmMaBenhByIdicdChandoanphanbiet);
                emrBenhAn.hohap = item.hohap;
                emrBenhAn.huongdieutri = item.huongdieutri;
                emrBenhAn.huyetapcao = returnHuyetApCaoThap(item.huyetapcao, 1);
                emrBenhAn.huyetapthap = returnHuyetApCaoThap(item.huyetapthap, 2);
                emrBenhAn.khamphukhoa = item.khamphukhoa;
                emrBenhAn.khamsankhoa = item.khamsankhoa;
                emrBenhAn.khamsosinh = item.khamsosinh;
                emrBenhAn.lydovaovien = item.lydovaovien;
                emrBenhAn.mach = item.mach;
                emrBenhAn.mat = item.mat;
                emrBenhAn.matuy = item.matuy;
                emrBenhAn.motachandoanbenhchinh = item.motachandoanbenhchinh;
                emrBenhAn.motachandoankemtheo = item.motachandoankemtheo;
                emrBenhAn.motachandoanphanbiet = item.motachandoanphanbiet;
                emrBenhAn.ngaykybenhan = toDateFormat(item.ngaykybenhan);
                emrBenhAn.nguonlay = item.nguonlay;
                emrBenhAn.nhietdo = formatNhietDo(item.nhietdo);
                emrBenhAn.nhiptho = item.nhiptho;
                emrBenhAn.noitietdinhduong = item.noitietdinhduong;
                emrBenhAn.phuongphaphoisinh = item.phuongphaphoisinh;
                emrBenhAn.quatrinhbenhly = item.quatrinhbenhly;
                emrBenhAn.quatrinhsinhtruong = item.quatrinhsinhtruong;
                emrBenhAn.ranghammat = item.ranghammat;
                emrBenhAn.ruoubia = item.ruoubia;
                emrBenhAn.taimuihong = item.taimuihong;
                emrBenhAn.tamthan = item.tamthan;
                emrBenhAn.taychanmieng = item.taychanmieng;
                emrBenhAn.thankinh = item.thankinh;
                emrBenhAn.thuocla = item.thuocla;
                emrBenhAn.thuoclao = item.thuoclao;
                emrBenhAn.tiemchung = item.tiemchung;
                emrBenhAn.tienluong = item.tienluong;
                emrBenhAn.tiensubanthan = item.tiensubanthan;
                emrBenhAn.tiensugiadinh = item.tiensugiadinh;
                emrBenhAn.tiensuphukhoa = item.tiensuphukhoa;
                emrBenhAn.tiensusankhoa = item.tiensusankhoa;
                emrBenhAn.tietnieusinhduc = item.tietnieusinhduc;
                emrBenhAn.tieuhoa = item.tieuhoa;
                emrBenhAn.tinhtrangsanphu = item.tinhtrangsanphu;
                emrBenhAn.tinhtrangsosinh = item.tinhtrangsosinh;
                emrBenhAn.toanthan = item.toanthan;
                emrBenhAn.tomtat = item.tomtat;
                emrBenhAn.tuanhoan = item.tuanhoan;
                emrBenhAn.vaongaythu = CheckNull(item.vaongaythu) == "0" ? string.Empty : item.vaongaythu;
                emrBenhAn.vongdau = item.vongdau;
                emrBenhAn.vongnguc = item.vongnguc;
                emrBenhAn.xetnghiemcanlamsang = item.xetnghiemcanlamsang;
                if (!_IsBVPhuSan && !_IsBVYHocCoTruyen)
                    emrBenhAn.emrCkMat = getemrCkMat(IdDanhSachHSBA);
                emrBenhAn.emrCkThanKinh = getemrCkThanKinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTamThan = getemrCkTamThan(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamSanKhoa = getemrCkKhamSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamPhuKhoa = getemrCkKhamPhuKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkKhamSoSinh = getemrCkKhamSoSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTinhTrangSoSinh = getemrCkTinhTrangSoSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuSanKhoa = getemrCkTienSuSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkSkTinhTrangSanPhu = getemrCkSkTinhTrangSanPhu(IdDanhSachHSBA);
                emrBenhAn.emrCkTinhTrangSanPhu = getemrCkTinhTrangSanPhu(IdDanhSachHSBA);
                emrBenhAn.emrCkQuaTrinhSinhTruong = getemrCkQuaTrinhSinhTruong(IdDanhSachHSBA);
                emrBenhAn.emrCkToanThan = getemrCkToanThan(IdDanhSachHSBA);
                emrBenhAn.emrCkPhuongPhapHoiSinh = getemrCkPhuongPhapHoiSinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTiemChung = getemrCkTiemChung(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuGiaDinh = getemrCkTienSuGiaDinh(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuBanThanSanKhoa = getemrCkTienSuBanThanSanKhoa(IdDanhSachHSBA);
                emrBenhAn.emrCkTienSuPhuKhoa = getemrCkTienSuPhuKhoa(IdDanhSachHSBA);
                emrBenhAn.tyletonthuongloai1 = CheckNull(item.tyletonthuongloai1);
                emrBenhAn.tyletonthuongloai2 = CheckNull(item.tyletonthuongloai2);
                emrBenhAn.tyletonthuongloai3 = CheckNull(item.tyletonthuongloai3);
                emrBenhAn.tyletonthuongloai4 = CheckNull(item.tyletonthuongloai4);
                emrBenhAn.tyletonthuongloai5 = CheckNull(item.tyletonthuongloai5);
                // Dành riêng bệnh án truyền nhiễm
                emrBenhAn.emrCkMoiSinh = getemrCkMoiSinh(IdDanhSachHSBA);
                // Dành riêng cho bệnh án PHCN
                emrBenhAn.emrCkChucNangSinhHoat = getemrCkChucNangSinhHoat(IdDanhSachHSBA);
                emrBenhAn.emrCkTuanHoan = getemrCkTuanHoan(IdDanhSachHSBA);
                emrBenhAn.emrCkTieuHoa = getemrCkTieuHoa(IdDanhSachHSBA);
                emrBenhAn.emrCkCoXuongKhop = getemrCkCoXuongKhop(IdDanhSachHSBA);
                emrBenhAn.emrCkHoHap = getemrCkHoHap(IdDanhSachHSBA);
                // Huyết học truyền máu
                emrBenhAn.emrCkHuongDieuTriHuyetHoc = getemrCkHuongDieuTriHuyetHoc(maBA,maLoaiBA);

            }
        }


        return emrBenhAn;
    }

    private emrCkHuongDieuTriHuyetHoc getemrCkHuongDieuTriHuyetHoc(string maBA,string maLoaiBA)
    {
        emrCkHuongDieuTriHuyetHoc itememrCkHuongDieuTriHuyetHoc = new emrCkHuongDieuTriHuyetHoc();
        var item = _dbContext.sp_GetAllSoLuongTruyenMauByMaBa(maBA, maLoaiBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkHuongDieuTriHuyetHoc.bachcauSolan = CheckNull(item.SoLanBachCauHat);
            itememrCkHuongDieuTriHuyetHoc.bachcauTongluong = CheckNull(item.TongSoLuongBachCauHat);
            itememrCkHuongDieuTriHuyetHoc.hongcauruaSolan = CheckNull(item.SoLanHongCauRua);
            itememrCkHuongDieuTriHuyetHoc.hongcauruaTongluong = CheckNull(item.TongSoLuongHongCauRua);
            itememrCkHuongDieuTriHuyetHoc.hongcauSolan = CheckNull(item.SoLanHongCau);
            itememrCkHuongDieuTriHuyetHoc.hongcauTongluong = CheckNull(item.TongSoLuongHongCau);
            itememrCkHuongDieuTriHuyetHoc.huyettuongSolan = CheckNull(item.SoLanHuyetTuong);
            itememrCkHuongDieuTriHuyetHoc.huyettuongTongluong = CheckNull(item.TongSoLuongHuyetTuong);
            itememrCkHuongDieuTriHuyetHoc.huyettuongtuoiSolan = CheckNull(item.SoLanHTTuoiDongLach);
            itememrCkHuongDieuTriHuyetHoc.huyettuongtuoiTongluong = CheckNull(item.TongSoLuongHTTuoiDongLach);
            itememrCkHuongDieuTriHuyetHoc.mautoanphanSolan = CheckNull(item.SoLanMauToanPhan);
            itememrCkHuongDieuTriHuyetHoc.mautoanphanTongluong = CheckNull(item.TongSoLuongMauToanPhan);
            itememrCkHuongDieuTriHuyetHoc.phanungtruyenmau = string.Empty;
            itememrCkHuongDieuTriHuyetHoc.tieucauSolan = CheckNull(item.SoLanTieuCau);
            itememrCkHuongDieuTriHuyetHoc.tieucauTongluong = CheckNull(item.TongSoLuongTieuCau);
            itememrCkHuongDieuTriHuyetHoc.tualanhSolan = CheckNull(item.SoLanTuaLanh);
            itememrCkHuongDieuTriHuyetHoc.tualanhTongluong = CheckNull(item.TongSoLuongTuaLanh);
        }
        return itememrCkHuongDieuTriHuyetHoc;
    }

    private emrCkHoHap getemrCkHoHap(int idDanhSachHSBA)
    {
        emrCkHoHap itememrCkHoHap = new emrCkHoHap();
        var item = _dbContext.tbl_emrCkHoHaps.Where(x => x.IdDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkHoHap.conngungtho = CheckNull(item.conngungtho);
            itememrCkHoHap.longnguc = CheckNull(item.longnguc);
            itememrCkHoHap.roiloan = CheckNull(item.roiloan);
            itememrCkHoHap.silverman = CheckNull(item.silverman);
            itememrCkHoHap.thetichkhi = CheckNull(item.thetichkhi);
            itememrCkHoHap.thobung = CheckNull(item.thobung);
            itememrCkHoHap.thokhokhe = CheckNull(item.thokhokhe);
            itememrCkHoHap.tholomnguc = CheckNull(item.tholomnguc);
            itememrCkHoHap.thonong = CheckNull(item.thonong);
            itememrCkHoHap.thoranphoi = CheckNull(item.thoranphoi);
            itememrCkHoHap.thoranphoichitiet = CheckNull(item.thoranphoichitiet);
            itememrCkHoHap.thoritphequan = CheckNull(item.thoritphequan);
            itememrCkHoHap.thoritthanhquan = CheckNull(item.thoritthanhquan);
            itememrCkHoHap.tinhtrangbenhly = CheckNull(item.tinhtrangbenhly);
        }
        return itememrCkHoHap;
    }

    private emrCkCoXuongKhop getemrCkCoXuongKhop(int idDanhSachHSBA)
    {
        emrCkCoXuongKhop itememrCkCoXuongKhop = new emrCkCoXuongKhop();
        var item = _dbContext.tbl_emrCkCoXuongKhops.Where(x => x.IdDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkCoXuongKhop.baccothu = CheckNull(item.baccothu);
            itememrCkCoXuongKhop.cotsongroiloancn = CheckNull(item.cotsongroiloancn);
            itememrCkCoXuongKhop.cotsongschober = CheckNull(item.cotsongschober);
            itememrCkCoXuongKhop.cotsongstibor = CheckNull(item.cotsongstibor);
            itememrCkCoXuongKhop.cotsongttbly = CheckNull(item.cotsongttbly);
            itememrCkCoXuongKhop.hinhthekhop = CheckNull(item.hinhthekhop);
            itememrCkCoXuongKhop.roiloanco = CheckNull(item.roiloanco);
            itememrCkCoXuongKhop.tamhoatdongvaovien = CheckNull(item.tamhoatdongvaovien);
            itememrCkCoXuongKhop.tamhoatdonravien = CheckNull(item.tamhoatdonravien);
            itememrCkCoXuongKhop.tencothu = CheckNull(item.tencothu);
            itememrCkCoXuongKhop.ttbenhlyco = CheckNull(item.ttbenhlyco);
        }
        return itememrCkCoXuongKhop;
    }

    private emrCkTieuHoa getemrCkTieuHoa(int idDanhSachHSBA)
    {
        emrCkTieuHoa itememrCkTieuHoa = new emrCkTieuHoa();
        var item = _dbContext.tbl_emrCkTieuHoas.Where(x => x.IdDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkTieuHoa.gandacdiem = CheckNull(item.gandacdiem);
            itememrCkTieuHoa.gankichthuoc = CheckNull(item.gankichthuoc);
            itememrCkTieuHoa.ganto = CheckNull(item.ganto);
            itememrCkTieuHoa.motakhac = CheckNull(item.motakhac);
            itememrCkTieuHoa.roiloanchucnang = CheckNull(item.roiloanchucnang);
            itememrCkTieuHoa.tinhtrangbenhly = CheckNull(item.tinhtrangbenhly);
        }
        return itememrCkTieuHoa;
    }

    private emrCkTuanHoan getemrCkTuanHoan(int idDanhSachHSBA)
    {
        emrCkTuanHoan itememrCkTuanHoan = new emrCkTuanHoan();
        var item = _dbContext.tbl_emrCkTuanHoans.Where(x => x.IdDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkTuanHoan.danoibong = CheckNull(item.danoibong);
            itememrCkTuanHoan.nhiptim = CheckNull(item.nhiptim);
            itememrCkTuanHoan.roiloantim = CheckNull(item.roiloantim);
            itememrCkTuanHoan.thoigiandaymaomach = CheckNull(item.thoigiandaymaomach);
            itememrCkTuanHoan.timamthoi = CheckNull(item.timamthoi);
            itememrCkTuanHoan.timchitiet = CheckNull(item.timchitiet);
            itememrCkTuanHoan.timgallop = CheckNull(item.timgallop);
            itememrCkTuanHoan.timmo = CheckNull(item.timmo);
            itememrCkTuanHoan.timro = CheckNull(item.timro);
            itememrCkTuanHoan.tinhmachconoi = CheckNull(item.tinhmachconoi);
            itememrCkTuanHoan.vamohoi = CheckNull(item.vamohoi);
        }

        return itememrCkTuanHoan;
    }

    private emrCkChucNangSinhHoat getemrCkChucNangSinhHoat(int idDanhSachHSBA)
    {
        emrCkChucNangSinhHoat itememrCkChucNangSinhHoat = new emrCkChucNangSinhHoat();
        var item = _dbContext.tbl_emrCkChucNangSinhHoats.Where(x => x.idDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itememrCkChucNangSinhHoat.anuong = CheckNull(item.anuong);
            itememrCkChucNangSinhHoat.chaitoc = CheckNull(item.chaitoc);
            itememrCkChucNangSinhHoat.danhrang = CheckNull(item.danhrang);
            itememrCkChucNangSinhHoat.dichuyen = CheckNull(item.dichuyen);
            itememrCkChucNangSinhHoat.divesinh = CheckNull(item.divesinh);
            itememrCkChucNangSinhHoat.dungcu = CheckNull(item.dungcu);
            itememrCkChucNangSinhHoat.dunglen = CheckNull(item.dunglen);
            itememrCkChucNangSinhHoat.dungNgoi = CheckNull(item.dungNgoi);
            itememrCkChucNangSinhHoat.macquanao = CheckNull(item.macquanao);
            itememrCkChucNangSinhHoat.namguaSap = CheckNull(item.namguaSap);
            itememrCkChucNangSinhHoat.namnguaNgoi = CheckNull(item.namnguaNgoi);
            itememrCkChucNangSinhHoat.sinhhoatkhac = CheckNull(item.sinhhoatkhac);
            itememrCkChucNangSinhHoat.tam = CheckNull(item.tam);
        }
        return itememrCkChucNangSinhHoat;
    }

    private emrCkMoiSinh getemrCkMoiSinh(int idDanhSachHSBA)
    {
        emrCkMoiSinh itemEmrCkMoiSinh = new emrCkMoiSinh();
        var item = _dbContext.tbl_emrCkMoiSinhs.Where(x => x.IDDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (item != null)
        {
            itemEmrCkMoiSinh.benhdichTruonghoc = CheckNull(item.benhdichTruonghoc);
            itemEmrCkMoiSinh.khuvucbenhcaptinh = CheckNull(item.khuvucbenhcaptinh);
            itemEmrCkMoiSinh.khuvucsong = CheckNull(item.khuvucsong);
            itemEmrCkMoiSinh.moisinh = CheckNull(item.moisinh);
            itemEmrCkMoiSinh.thoigiansong = toDateFormat(item.thoigiansong);
            itemEmrCkMoiSinh.treCungnha = CheckNull(item.treCungnha);
            itemEmrCkMoiSinh.treCungtruong = CheckNull(item.treCungtruong);
            itemEmrCkMoiSinh.treGannha = CheckNull(item.treGannha);
        }
        return itemEmrCkMoiSinh;
    }

    private emrCkTienSuPhuKhoa getemrCkTienSuPhuKhoa(int IdDanhSachHSBA)
    {
        emrCkTienSuPhuKhoa emrCkTienSuPhuKhoa = new emrCkTienSuPhuKhoa();
        var tblemrCkTienSuPhuKhoa = from p in _dbContext.tbl_emrCkTienSuPhuKhoas where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrCkTienSuPhuKhoa.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTienSuPhuKhoa.tuoicokinh = CheckNull(item.tuoicokinh);
            emrCkTienSuPhuKhoa.chukikinh = CheckNull(item.chukikinh); // kiểu int
            emrCkTienSuPhuKhoa.ngaythaykinh = CheckNull(item.ngaythaykinh);// Số ngày thấy kinh
            emrCkTienSuPhuKhoa.tuoilaychong = CheckNull(item.tuoilaychong);
            emrCkTienSuPhuKhoa.ngaykinhcuoi = toDateFormat(item.ngaykinhcuoi);
            emrCkTienSuPhuKhoa.tuoihetkinh = CheckNull(item.tuoihetkinh);

            emrCkTienSuPhuKhoa.benhphukhoa = CheckNull(item.benhphukhoa);
            emrCkTienSuPhuKhoa.khoiubt = CheckNullReturnTrueFalse(item.khoiubt);
            emrCkTienSuPhuKhoa.uxotc = CheckNullReturnTrueFalse(item.uxotc);
            emrCkTienSuPhuKhoa.didangsd = CheckNullReturnTrueFalse(item.didangsd);
            emrCkTienSuPhuKhoa.ssd = CheckNullReturnTrueFalse(item.ssd);
            emrCkTienSuPhuKhoa.luongkinh = CheckNull(item.luongkinh);
            emrCkTienSuPhuKhoa.tinhchatkinhnguyet = CheckNull(item.tinhchatkinhnguyet);
            emrCkTienSuPhuKhoa.daubung = CheckNull(item.daubung);

            emrCkTienSuPhuKhoa.thoidiemdaubung = CheckNull(item.thoidiemdaubung);// 1 =Trước kỳ, 2 =Trong, 3= Sau
            emrCkTienSuPhuKhoa.tsm = CheckNullReturnTrueFalse(item.tsm);
            emrCkTienSuPhuKhoa.dieutrictc = CheckNullReturnTrueFalse(item.dieutrictc);
            emrCkTienSuPhuKhoa.catcutctc = CheckNullReturnTrueFalse(item.catcutctc);
        }
        return emrCkTienSuPhuKhoa;
    }
    private emrCkTienSuBanThanSanKhoa getemrCkTienSuBanThanSanKhoa(int IdDanhSachHSBA)
    {
        emrCkTienSuBanThanSanKhoa emrCkTienSuBanThanSanKhoa = new emrCkTienSuBanThanSanKhoa();
        var tblemrCkTienSuBanThanSanKhoa = from p in _dbContext.tbl_emrCkTienSuBanThanSanKhoas where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrCkTienSuBanThanSanKhoa.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTienSuBanThanSanKhoa.basedow = CheckNullReturnTrueFalse(item.basedow);
            emrCkTienSuBanThanSanKhoa.benhthan = CheckNullReturnTrueFalse(item.benhthan);
            emrCkTienSuBanThanSanKhoa.benhtim = CheckNullReturnTrueFalse(item.benhtim);
            emrCkTienSuBanThanSanKhoa.caohuyetap = CheckNullReturnTrueFalse(item.caohuyetap);
            emrCkTienSuBanThanSanKhoa.diungthuoc = CheckNullReturnTrueFalse(item.diungthuoc);
            emrCkTienSuBanThanSanKhoa.dongkinh = CheckNullReturnTrueFalse(item.dongkinh);
            emrCkTienSuBanThanSanKhoa.henphequan = CheckNullReturnTrueFalse(item.henphequan);
            emrCkTienSuBanThanSanKhoa.laophoi = CheckNullReturnTrueFalse(item.laophoi);
            emrCkTienSuBanThanSanKhoa.moruotthua = CheckNullReturnTrueFalse(item.moruotthua);
            emrCkTienSuBanThanSanKhoa.phauthuatobung = CheckNull(item.phauthuatobung);
            emrCkTienSuBanThanSanKhoa.thongtincuthe = CheckNull(item.thongtincuthe);
            emrCkTienSuBanThanSanKhoa.viemtactinhmach = CheckNullReturnTrueFalse(item.viemtactinhmach);

        }
        return emrCkTienSuBanThanSanKhoa;
    }

    private emrCkTienSuGiaDinh getemrCkTienSuGiaDinh(int IdDanhSachHSBA)
    {
        emrCkTienSuGiaDinh emrCkTienSuGiaDinh = new emrCkTienSuGiaDinh();
        var tblemremrCkTienSuGiaDinh = from p in _dbContext.tbl_emrCkTienSuGiaDinhs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemremrCkTienSuGiaDinh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTienSuGiaDinh.benhditruyen = CheckNullReturnTrueFalse(item.benhditruyen);
            emrCkTienSuGiaDinh.benhkhac = CheckNull(item.benhkhac);
            emrCkTienSuGiaDinh.caohuyetap = CheckNullReturnTrueFalse(item.benhditruyen);
            emrCkTienSuGiaDinh.daiduong = CheckNullReturnTrueFalse(item.daiduong);
            emrCkTienSuGiaDinh.didang = CheckNullReturnTrueFalse(item.didang);
            emrCkTienSuGiaDinh.sinhdoi = CheckNullReturnTrueFalse(item.sinhdoi);
        }
        return emrCkTienSuGiaDinh;
    }

    private emrCkSkTinhTrangSanPhu getemrCkSkTinhTrangSanPhu(int IdDanhSachHSBA)
    {

        emrCkSkTinhTrangSanPhu emrCkSkTinhTrangSanPhu = new emrCkSkTinhTrangSanPhu();
        var tblemrCkSkTinhTrangSanPhu = from p in _dbContext.tbl_emrCkSkTinhTrangSanPhus where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrCkSkTinhTrangSanPhu.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkSkTinhTrangSanPhu.chieucaotucung = CheckNull(item.chieucaotucung);
            emrCkSkTinhTrangSanPhu.chisobishop = CheckNull(item.chisobishop);
            emrCkSkTinhTrangSanPhu.concotucung = CheckNull(item.concotucung);
            emrCkSkTinhTrangSanPhu.cotucung = CheckNull(item.cotucung);
            emrCkSkTinhTrangSanPhu.dauoi = CheckNull(item.dauoi);
            emrCkSkTinhTrangSanPhu.maunuocoi = CheckNull(item.maunuocoi);
            emrCkSkTinhTrangSanPhu.ngoithai = CheckNull(item.ngoithai);
            emrCkSkTinhTrangSanPhu.nhietdo = CheckNull(item.nhietdo);
            emrCkSkTinhTrangSanPhu.nhiptho = CheckNull(item.nhiptho);
            emrCkSkTinhTrangSanPhu.phu = CheckNullReturnTrueFalse(item.phu);
            emrCkSkTinhTrangSanPhu.proteinnieu = CheckNull(item.proteinnieu);
            emrCkSkTinhTrangSanPhu.seomocu = CheckNullReturnTrueFalse(item.seomocu);
            emrCkSkTinhTrangSanPhu.dauvetmo = CheckNullReturnTrueFalse(item.dauvetmo);
            emrCkSkTinhTrangSanPhu.timthai = CheckNull(item.timthai);
            emrCkSkTinhTrangSanPhu.tinhthan = CheckNull(item.tinhthan);
            emrCkSkTinhTrangSanPhu.thoidiemvooi = toDateFormat(item.thoidiemvooi);
            emrCkSkTinhTrangSanPhu.tinhtrangtimthai = CheckNull(item.tinhtrangtimthai);
            emrCkSkTinhTrangSanPhu.vongbung = CheckNull(item.vongbung);
            emrCkSkTinhTrangSanPhu.huyetap = CheckNull(item.huyetap);
            emrCkSkTinhTrangSanPhu.mach = CheckNull(item.mach);
            emrCkSkTinhTrangSanPhu.domo = CheckNull(item.domo);

        }
        return emrCkSkTinhTrangSanPhu;

    }

    private emrCkPhuongPhapHoiSinh getemrCkPhuongPhapHoiSinh(int IdDanhSachHSBA)
    {

        emrCkPhuongPhapHoiSinh emrCkPhuongPhapHoiSinh = new emrCkPhuongPhapHoiSinh();
        var tblemrCkPhuongPhapHoiSinh = from p in _dbContext.tbl_emrCkPhuongPhapHoiSinhs where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrCkPhuongPhapHoiSinh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkPhuongPhapHoiSinh.bopbongoxy = CheckNullReturnTrueFalse(item.bopbongoxy);
            emrCkPhuongPhapHoiSinh.hutdich = CheckNullReturnTrueFalse(item.hutdich);
            emrCkPhuongPhapHoiSinh.khac = CheckNullReturnTrueFalse(item.khac);
            emrCkPhuongPhapHoiSinh.noikhiquan = CheckNullReturnTrueFalse(item.noikhiquan);
            emrCkPhuongPhapHoiSinh.thooxy = CheckNullReturnTrueFalse(item.thooxy);
            emrCkPhuongPhapHoiSinh.xoaboptim = CheckNullReturnTrueFalse(item.xoaboptim);
            emrCkPhuongPhapHoiSinh.mota = CheckNull(item.mota);

        }
        return emrCkPhuongPhapHoiSinh;

    }

    private emrCkTinhTrangSoSinh getemrCkTinhTrangSoSinh(int IdDanhSachHSBA)
    {

        emrCkTinhTrangSoSinh emrCkTinhTrangSoSinh = new emrCkTinhTrangSoSinh();
        var tblemrCkTinhTrangSoSinh = from p in _dbContext.tbl_emrCkTinhTrangSoSinhs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrCkTinhTrangSoSinh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTinhTrangSoSinh.apgar01 = CheckNull(item.apgar01);
            emrCkTinhTrangSoSinh.apgar05 = CheckNull(item.apgar05);
            emrCkTinhTrangSoSinh.apgar10 = CheckNull(item.apgar10);
            emrCkTinhTrangSoSinh.cannang = CheckNull(item.cannang);
            emrCkTinhTrangSoSinh.nguoidode = CheckNull(item.nguoidode);
            emrCkTinhTrangSoSinh.sskhac = CheckNull(item.sskhac);
            emrCkTinhTrangSoSinh.sskhocngay = CheckNullReturnTrueFalse(item.sskhocngay);
            emrCkTinhTrangSoSinh.ssngat = CheckNull(item.ssngat);
            emrCkTinhTrangSoSinh.tennguoichuyensosinh = CheckNull(item.tennguoichuyensosinh);
            emrCkTinhTrangSoSinh.tinhtrangdinhduong = CheckNull(item.tinhtrangdinhduong);
            emrCkTinhTrangSoSinh.tuoi = CheckNull(item.tuoi);

        }
        return emrCkTinhTrangSoSinh;

    }

    private emrCkTiemChung getemrCkTiemChung(int IdDanhSachHSBA)
    {

        emrCkTiemChung emrCkTiemChung = new emrCkTiemChung();
        var tbl_emrckTiemChung = from p in _dbContext.tbl_emrCkTiemChungs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrckTiemChung.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTiemChung.tcbachhau = item.tcbachhau;
            emrCkTiemChung.tcbailiet = item.tcbailiet;
            emrCkTiemChung.tchoga = item.tchoga;
            emrCkTiemChung.tckhac = item.tckhac;
            emrCkTiemChung.tclao = item.tclao;
            emrCkTiemChung.tcmotakhac = item.tcmotakhac;
            emrCkTiemChung.tcsoi = item.tcsoi;
            emrCkTiemChung.tcuonvan = item.tcuonvan;
        }
        return emrCkTiemChung;

    }

    private emrCkToanThan getemrCkToanThan(int IdDanhSachHSBA)
    {

        emrCkToanThan emrCkToanThan = new emrCkToanThan();
        var tbl_emrckToanThan = from p in _dbContext.tbl_emrCkToanThans where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrckToanThan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkToanThan.biphu = CheckNullReturnTrueFalse(item.biphu);
            emrCkToanThan.da = CheckNull(item.da);
            emrCkToanThan.ganBogan = CheckNull(item.ganBogan);
            emrCkToanThan.ganDau = CheckNull(item.ganDau);
            emrCkToanThan.ganKichthuoc = CheckNull(item.ganKichthuoc);
            emrCkToanThan.ganMatdo = CheckNull(item.ganMatdo);
            emrCkToanThan.ganThongtinbosung = CheckNull(item.ganThongtinbosung);
            emrCkToanThan.hachDodauhach = CheckNull(item.hachDodauhach);
            emrCkToanThan.hachDodidong = CheckNull(item.hachDodidong);
            emrCkToanThan.hachKichthuoc = CheckNull(item.hachKichthuoc);
            emrCkToanThan.hachSoluong = CheckNull(item.hachSoluong);
            emrCkToanThan.hachThongtinbosung = CheckNull(item.hachThongtinbosung);
            emrCkToanThan.hinhdang = CheckNull(item.hinhdang);
            emrCkToanThan.lachBolach = CheckNull(item.lachBolach);
            emrCkToanThan.lachDaulach = CheckNull(item.lachDaulach);
            emrCkToanThan.lachKichthuoc = CheckNull(item.lachKichthuoc);
            emrCkToanThan.lachMatdo = CheckNull(item.lachMatdo);
            emrCkToanThan.lachMatlach = CheckNull(item.lachMatlach);
            emrCkToanThan.lachThongtinbosung = CheckNull(item.lachThongtinbosung);
            emrCkToanThan.longtocmong = CheckNull(item.longtocmong);
            emrCkToanThan.niemmac = CheckNull(item.niemmac);
            emrCkToanThan.phoiMota = CheckNull(item.phoiMota);
            emrCkToanThan.phutoanthan = CheckNullReturnTrueFalse(item.phutoanthan);
            emrCkToanThan.thanMota = CheckNull(item.thanMota);
            emrCkToanThan.thetrang = CheckNull(item.thetrang);
            emrCkToanThan.thieumau = CheckNull(item.thieumau);
            emrCkToanThan.timMota = CheckNull(item.timMota);
            emrCkToanThan.tinhthan = CheckNull(item.tinhthan);
            emrCkToanThan.vuMota = CheckNull(item.vuMota);
            // Phần bệnh án phụ

            emrCkToanThan.hachViTri = CheckNull(item.hachViTri);
            emrCkToanThan.khuyetTatDacBiet = CheckNull(item.khuyetTatDacBiet);
            emrCkToanThan.matGan = CheckNull(item.matGan);
            emrCkToanThan.trieuchungphu = CheckNull(item.trieuchungphu);
            emrCkToanThan.trieuchungxuathuyet = CheckNull(item.trieuchungxuathuyet);
            emrCkToanThan.tuyengiap = CheckNull(item.tuyengiap);
        }
        return emrCkToanThan;
    }

    private emrCkQuaTrinhSinhTruong getemrCkQuaTrinhSinhTruong(int IdDanhSachHSBA)
    {

        emrCkQuaTrinhSinhTruong emrCkQuaTrinhSinhTruong = new emrCkQuaTrinhSinhTruong();
        var tbl_emrQuaTrinhSinhTruong = from p in _dbContext.tbl_emrCkQuaTrinhSinhTruongs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrQuaTrinhSinhTruong.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkQuaTrinhSinhTruong.benhlykhac = CheckNull(item.benhlykhac);// Hiện tại object này chỉ đang truyền có vậy
        }
        return emrCkQuaTrinhSinhTruong;

    }

    private emrCkTinhTrangSanPhu getemrCkTinhTrangSanPhu(int IdDanhSachHSBA)
    {

        emrCkTinhTrangSanPhu emrCkTinhTrangSanPhu = new emrCkTinhTrangSanPhu();
        var tbl_emrCkTinhTrangSanPhu = from p in _dbContext.tbl_emrCkTinhTrangSanPhus where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrCkTinhTrangSanPhu.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTinhTrangSanPhu.benhcuame = CheckNull(item.benhcuame);
            emrCkTinhTrangSanPhu.canthiep = CheckNullReturnTrueFalse(item.canthiep);
            emrCkTinhTrangSanPhu.dethuong = CheckNullReturnTrueFalse(item.dethuong);
            emrCkTinhTrangSanPhu.dieutribenhcuame = item.dieutribenhcuame;
            emrCkTinhTrangSanPhu.huyetap = CheckNull(item.huyetap);
            emrCkTinhTrangSanPhu.kiemsoattucung = item.kiemsoattucung;
            emrCkTinhTrangSanPhu.lydo = CheckNull(item.lydo);
            emrCkTinhTrangSanPhu.mach = CheckNull(item.mach);
            emrCkTinhTrangSanPhu.mauoi = CheckNull(item.mauoi);
            emrCkTinhTrangSanPhu.meNoinam = CheckNull(item.meNoinam);
            emrCkTinhTrangSanPhu.meSogiuong = CheckNull(item.meSogiuong);
            emrCkTinhTrangSanPhu.motacachde = CheckNull(item.motacachde);
            emrCkTinhTrangSanPhu.motakiemsoattucung = CheckNull(item.motakiemsoattucung);
            emrCkTinhTrangSanPhu.ngaycanthiep = toDateFormat(item.ngaycanthiep);
            emrCkTinhTrangSanPhu.ngayvooi = toDateFormat(item.ngayvooi);
            emrCkTinhTrangSanPhu.ngoithai = CheckNull(item.ngoithai);
            emrCkTinhTrangSanPhu.nhietdo = CheckNull(item.nhietdo);
            emrCkTinhTrangSanPhu.nhommau = CheckNull(item.nhommau);
            emrCkTinhTrangSanPhu.paraDenon = CheckNull(item.paraDenon);
            emrCkTinhTrangSanPhu.paraDuthang = CheckNull(item.paraDuthang);
            emrCkTinhTrangSanPhu.paraSay = CheckNull(item.paraSay);
            emrCkTinhTrangSanPhu.paraSong = CheckNull(item.paraSong);
            emrCkTinhTrangSanPhu.sobenhanme = CheckNull(item.sobenhanme);
            emrCkTinhTrangSanPhu.socon = CheckNull(item.socon);
            emrCkTinhTrangSanPhu.thoidiemmode = toDateFormat(item.thoidiemmode);
            emrCkTinhTrangSanPhu.thoidiemvaode = toDateFormat(item.thoidiemvaode);
            emrCkTinhTrangSanPhu.toantrang = CheckNull(item.toantrang);
        }
        return emrCkTinhTrangSanPhu;

    }

    private emrCkTienSuSanKhoa getemrCkTienSuSanKhoa(int IdDanhSachHSBA)
    {

        emrCkTienSuSanKhoa emrCkTienSuSanKhoa = new emrCkTienSuSanKhoa();
        var tbl_emrCkTienSuSanKhoa = from p in _dbContext.tbl_emrCkTienSuSanKhoas where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrCkTienSuSanKhoa.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTienSuSanKhoa.cachde = item.cachde;
            emrCkTienSuSanKhoa.dienbienthai = item.dienbienthai;
            emrCkTienSuSanKhoa.hausan = item.hausan;
            emrCkTienSuSanKhoa.paraDenon = CheckNull(item.paraDenon); // sớm
            emrCkTienSuSanKhoa.paraDuthang = CheckNull(item.paraDuthang); // Sinh
            emrCkTienSuSanKhoa.paraSay = CheckNull(item.paraSay); // Sảy
            emrCkTienSuSanKhoa.paraSong = CheckNull(item.paraSong); // Sống
            emrCkTienSuSanKhoa.thoigiandiadiem = toDateFormat(item.thoigiandiadiem);
            //emrCkTienSuSanKhoa
            emrCkTienSuSanKhoa.tresosinh = item.tresosinh;
            emrCkTienSuSanKhoa.tuoithai = CheckNull(item.tuoithai);
            emrCkTienSuSanKhoa.emrCkTienSuSanKhoaChiTiets = getemrCkTienSuSanKhoaChiTiets(IdDanhSachHSBA);
        }
        return emrCkTienSuSanKhoa;
    }

    private emrCkTienSuSanKhoaChiTiet[] getemrCkTienSuSanKhoaChiTiets(int IdDanhSachHSBA)
    {
        emrCkTienSuSanKhoa emrCkTienSuSanKhoa = new emrCkTienSuSanKhoa();
        var tbl_emrCkTienSuSanKhoa = from p in _dbContext.tbl_emrCkTienSuSanKhoas where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var listArray = tbl_emrCkTienSuSanKhoa.DefaultIfEmpty().ToArray();
        List<emrCkTienSuSanKhoaChiTiet> list = new List<emrCkTienSuSanKhoaChiTiet>();

        for (int i = 0; i < listArray.Length; i++)
        {

            emrCkTienSuSanKhoaChiTiet emrCkTienSuSanKhoaChiTiet = new emrCkTienSuSanKhoaChiTiet();
            emrCkTienSuSanKhoaChiTiet.ngayketthucthainghen = toDateFormat(listArray[i].thoigiandiadiem);
            emrCkTienSuSanKhoaChiTiet.tuoithai = CheckNull(listArray[i].tuoithai);
            emrCkTienSuSanKhoaChiTiet.phuongphapde = listArray[i].cachde;

            emrCkTienSuSanKhoaChiTiet.dienbien = listArray[i].dienbienthai;
            emrCkTienSuSanKhoaChiTiet.cannang = CheckNull(listArray[i].cannang);// 
            emrCkTienSuSanKhoaChiTiet.hausan = listArray[i].hausan;
            list.Add(emrCkTienSuSanKhoaChiTiet);
        }
        return list.ToArray();

    }

    private emrCkKhamSoSinh getemrCkKhamSoSinh(int IdDanhSachHSBA)
    {
        emrCkKhamSoSinh emrCkKhamSoSinh = new emrCkKhamSoSinh();
        var tbl_emrCkKhamSoSinh = from p in _dbContext.tbl_emrCkKhamSoSinhs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrCkKhamSoSinh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkKhamSoSinh.ditatbamsinh = CheckNullReturnTrueFalse(item.ditatbamsinh);
            emrCkKhamSoSinh.ditathaumon = CheckNullReturnTrueFalse(item.ditathaumon);
            emrCkKhamSoSinh.mausacda = CheckNull(item.mausacda);
            emrCkKhamSoSinh.motaditat = CheckNull(item.motaditat);
            emrCkKhamSoSinh.nhiptho = CheckNull(item.nhiptho);
            emrCkKhamSoSinh.nhiptim = CheckNull(item.nhiptim);
            emrCkKhamSoSinh.silverman = item.silverman;
            emrCkKhamSoSinh.tinhhinhsosinhvaokhoa = item.tinhhinhsosinhvaokhoa;
            emrCkKhamSoSinh.tinhtranghohap = item.tinhtranghohap;
            emrCkKhamSoSinh.tinhtrangtoanthan = item.tinhtrangtoanthan;
        }
        return emrCkKhamSoSinh;
    }

    private emrCkKhamPhuKhoa getemrCkKhamPhuKhoa(int IdDanhSachHSBA)
    {

        emrCkKhamPhuKhoa emrCkKhamPhuKhoa = new emrCkKhamPhuKhoa();
        var tbl_emrCkKhamPhuKhoa = from p in _dbContext.tbl_emrCkKhamPhuKhoas where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrCkKhamPhuKhoa.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkKhamPhuKhoa.amdao = item.amdao;
            emrCkKhamPhuKhoa.amho = item.amho;
            emrCkKhamPhuKhoa.amvat = item.amvat;
            emrCkKhamPhuKhoa.cactuicung = item.cactuicung;
            emrCkKhamPhuKhoa.cotucung = item.cotucung;
            emrCkKhamPhuKhoa.dauhieusinhducthuphat = item.dauhieusinhducthuphat;
            emrCkKhamPhuKhoa.mangtrinh = item.mangtrinh;
            emrCkKhamPhuKhoa.moibe = item.moibe;
            emrCkKhamPhuKhoa.moilon = item.moilon;
            emrCkKhamPhuKhoa.phanphu = item.phanphu;
            emrCkKhamPhuKhoa.tangsinhmon = item.tangsinhmon;
            emrCkKhamPhuKhoa.thantucung = item.thantucung;

            emrCkKhamPhuKhoa.thongtinkhac = item.thongtinkhac;

        }
        return emrCkKhamPhuKhoa;

    }

    private emrCkKhamSanKhoa getemrCkKhamSanKhoa(int IdDanhSachHSBA)
    {

        emrCkKhamSanKhoa emrCkKhamSanKhoa = new emrCkKhamSanKhoa();
        var tbl_emrckKhamSanKhoa = from p in _dbContext.tbl_emrCkKhamSanKhoas where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrckKhamSanKhoa.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkKhamSanKhoa.amdao = item.amdao;
            emrCkKhamSanKhoa.amho = item.amho;
            emrCkKhamSanKhoa.bamoi = CheckNullReturnTrueFalse(item.bamoi);
            emrCkKhamSanKhoa.bamoiluc = toDateFormat(item.bamoiluc);
            emrCkKhamSanKhoa.bishop = item.bishop;
            emrCkKhamSanKhoa.chieucaotc = CheckNull(item.chieucaotc);
            emrCkKhamSanKhoa.chuyendaluc = toDateFormat(item.chuyendaluc);
            emrCkKhamSanKhoa.concotc = item.concotc;
            emrCkKhamSanKhoa.ctcdangxoa = CheckNullReturnTrueFalse(item.ctcdangxoa);
            emrCkKhamSanKhoa.ctcdongkin = CheckNullReturnTrueFalse(item.ctcdongkin);
            emrCkKhamSanKhoa.ctcmo = item.ctcmo;
            emrCkKhamSanKhoa.dauhieusaudo = item.dauhieusaudo;
            emrCkKhamSanKhoa.dauoi = CheckNull(item.dauoi);
            emrCkKhamSanKhoa.dauvetmo = CheckNullReturnTrueFalse(item.dauvetmo);
            emrCkKhamSanKhoa.dbodeloque = CheckNull(item.dbodeloque);
            emrCkKhamSanKhoa.dluonggai = CheckNull(item.dluonggai);
            emrCkKhamSanKhoa.dluongmao = CheckNull(item.dluongmao);
            emrCkKhamSanKhoa.dluongmau = CheckNull(item.dluongmau);
            emrCkKhamSanKhoa.dluongungoi = CheckNull(item.dluongungoi);
            emrCkKhamSanKhoa.dnhohauve = CheckNull(item.dnhohauve);
            emrCkKhamSanKhoa.dolot = CheckNull(item.dolot);
            emrCkKhamSanKhoa.hinhdangtc = CheckNull(item.hinhdangtc);
            emrCkKhamSanKhoa.khamthaitai = CheckNull(item.khamthaitai);
            emrCkKhamSanKhoa.khungchau = CheckNull(item.khungchau);
            emrCkKhamSanKhoa.kieuthe = CheckNull(item.kieuthe);
            emrCkKhamSanKhoa.kykinhcuoidenngay = toDateFormat(item.kykinhcuoidenngay);
            emrCkKhamSanKhoa.kykinhcuoitungay = toDateFormat(item.kykinhcuoitungay);
            emrCkKhamSanKhoa.mauoi = CheckNull(item.mauoi);
            emrCkKhamSanKhoa.motau = item.motau;
            emrCkKhamSanKhoa.muiuonvanthu = CheckNull(item.muiuonvanthu.HasValue == true ? item.muiuonvanthu.Value.ToString() : ""); // Kiểu int
            emrCkKhamSanKhoa.ngoi = item.ngoi;
            emrCkKhamSanKhoa.ngoithai = item.ngoithai;
            emrCkKhamSanKhoa.nuocoi = item.nuocoi;
            emrCkKhamSanKhoa.phanphu = item.phanphu;
            emrCkKhamSanKhoa.phonguonvan = CheckNullReturnTrueFalse(item.phonguonvan);
            emrCkKhamSanKhoa.seomocu = CheckNullReturnTrueFalse(item.seomocu);
            emrCkKhamSanKhoa.tangsinhmon = item.tangsinhmon;
            emrCkKhamSanKhoa.tenbo = item.tenbo;
            emrCkKhamSanKhoa.tencondukien = item.tencondukien;
            emrCkKhamSanKhoa.tengai = item.tengai;
            emrCkKhamSanKhoa.tentrai = item.tentrai;
            emrCkKhamSanKhoa.the = item.the;
            emrCkKhamSanKhoa.timthai = CheckNull(item.timthai);
            emrCkKhamSanKhoa.trieuchungbandau = item.trieuchungbandau;
            emrCkKhamSanKhoa.tuoithai = CheckNull(item.tuoithai);
            emrCkKhamSanKhoa.tuthetc = item.tuthetc;
            emrCkKhamSanKhoa.utiendao = item.utiendao;
            emrCkKhamSanKhoa.vongbung = item.vongbung;
            emrCkKhamSanKhoa.vu = item.vu;
        }
        return emrCkKhamSanKhoa;



    }

    private emrCkTamThan getemrCkTamThan(int IdDanhSachHSBA)
    {

        emrCkTamThan emrCkTamThan = new emrCkTamThan();
        var tbl_emrCkTamThan = from p in _dbContext.tbl_emrCkTamThans where p.IDDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrCkTamThan.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkTamThan.bieuhienchung = item.bieuhienchung;
            emrCkTamThan.camxuc = item.camxuc;
            emrCkTamThan.dinhhuongbanthan = item.dinhhuongbanthan;
            emrCkTamThan.dinhhuongkhonggian = item.dinhhuongkhonggian;
            emrCkTamThan.dinhhuongthoigian = item.dinhhuongthoigian;
            emrCkTamThan.hoatdongbannang = item.hoatdongbannang;
            emrCkTamThan.hoatdongcoychi = item.hoatdongcoychi;
            emrCkTamThan.khanangchuy = item.khanangchuy;
            emrCkTamThan.trigiac = item.trigiac;
            emrCkTamThan.trinangphantich = item.trinangphantich;
            emrCkTamThan.trinangtonghop = item.trinangtonghop;
            emrCkTamThan.trinhomaymoc = item.trinhomaymoc;
            emrCkTamThan.trinhothonghieu = item.trinhothonghieu;
            emrCkTamThan.tuduyhinhthuc = item.tuduyhinhthuc;
            emrCkTamThan.tuduynoidung = item.tuduynoidung;
        }
        return emrCkTamThan;


    }

    private emrCkThanKinh getemrCkThanKinh(int IdDanhSachHSBA)
    {

        emrCkThanKinh emrCkThanKinh = new emrCkThanKinh();
        var tbl_emrckThanKinh = from p in _dbContext.tbl_emrCkThanKinhs where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tbl_emrckThanKinh.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkThanKinh.camgiac = item.camgiac;
            emrCkThanKinh.coguong = item.coguong;
            emrCkThanKinh.daymat = item.daymat;
            emrCkThanKinh.daythankinhsonao = item.daythankinhsonao;
            emrCkThanKinh.giatminhluckham = item.giatminhluckham;
            emrCkThanKinh.kichthuocDongtu = item.kichthuocDongtu;
            emrCkThanKinh.le = item.le;
            emrCkThanKinh.lietthankinhso = item.lietthankinhso;
            emrCkThanKinh.nguga = item.nguga;
            emrCkThanKinh.phanxa = item.phanxa;
            emrCkThanKinh.phanxaAnhsang = item.phanxaAnhsang;
            emrCkThanKinh.roiloanchucnang = item.roiloanchucnang;
            emrCkThanKinh.thatdieu = item.thatdieu;
            emrCkThanKinh.truonglucco = item.truonglucco;

            emrCkThanKinh.vandong = item.vandong;
            emrCkThanKinh.yeuchi = item.yeuchi;
        }
        return emrCkThanKinh;



    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoanphanbiet(string emrDmMaBenhByIdicdChandoanphanbiet)// Gửi theo ICD 10 nên không cần ánh xạ
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = emrDmMaBenhByIdicdChandoanphanbiet;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoankemtheo(string emrDmMaBenhByIdicdChandoankemtheo)// Gửi theo ICD 10 nên không cần ánh xạ
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = emrDmMaBenhByIdicdChandoankemtheo;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdChandoanbenhchinh(string emrDmMaBenhByIdicdChandoanbenhchinh)// Gửi theo ICD 10 nên không cần ánh xạ
    {
        emrDmMaBenh emrDmMaBenh = new DTT.HL7Core.emrDmMaBenh();
        emrDmMaBenh.ma = emrDmMaBenhByIdicdChandoanbenhchinh;
        return emrDmMaBenh;

    }
    #region Lấy thông tin chuyên khoa mắt cho bệnh án mắt
    private emrCkMat getemrCkMat(int IdDanhSachHSBA)
    {

        emrCkMat emrCkMat = new emrCkMat();
        var tbl_emrCkMat = from p in _dbContext.tbl_emrCkMats where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        tbl_emrCkMat item = tbl_emrCkMat.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrCkMat.chaynuocmatphai = item.chaynuocmatphai;
            emrCkMat.chaynuocmattrai = item.chaynuocmattrai;
            emrCkMat.choimatphai = item.choimatphai;
            emrCkMat.choimattrai = item.choimattrai;
            emrCkMat.cungmacmatphai = item.cungmacmatphai;
            emrCkMat.cungmacmattrai = item.cungmacmattrai;
            emrCkMat.daymatphai = item.daymatphai;
            emrCkMat.dichkinhmatphai = item.dichkinhmatphai;
            emrCkMat.dichkinhmattrai = item.dichkinhmattrai;
            emrCkMat.dongtumatphai = item.dongtumatphai;
            emrCkMat.dongtumattrai = item.dongtumattrai;
            emrCkMat.giaccungmacmatphai = item.giaccungmacmatphai;
            emrCkMat.giaccungmacmattrai = item.giaccungmacmattrai;
            emrCkMat.goctienphongmatphai = item.goctienphongmatphai;
            emrCkMat.goctienphongmattrai = item.goctienphongmattrai;
            emrCkMat.homatphai = item.homatphai;
            emrCkMat.homattrai = item.homattrai;
            emrCkMat.ketmacmatphai = item.ketmacmatphai;
            emrCkMat.ketmacmattrai = item.ketmacmattrai;
            emrCkMat.ledaophai = item.ledaophai;
            emrCkMat.ledaotrai = item.ledaotrai;
            emrCkMat.mathoiphai = item.mathoiphai;
            emrCkMat.mathoitrai = item.mathoitrai;
            emrCkMat.mimatphai = item.mimatphai;
            emrCkMat.mimattrai = item.mimattrai;
            emrCkMat.momatphai = item.momatphai;
            emrCkMat.momattrai = item.momattrai;
            emrCkMat.mongmatphai = item.mongmatphai;
            emrCkMat.mongmattrai = item.mongmattrai;
            emrCkMat.nhanapphai = item.nhanapphai;
            emrCkMat.nhanaptrai = item.nhanaptrai;
            emrCkMat.nhancaumatphai = item.nhancaumatphai;
            emrCkMat.nhancaumattrai = item.nhancaumattrai;
            emrCkMat.rucmatphai = item.rucmatphai;
            emrCkMat.rucmattrai = item.rucmattrai;
            emrCkMat.soisangdongtumatphai = item.soisangdongtumatphai;
            emrCkMat.soisangdongtumattrai = item.sosangmattrai;
            emrCkMat.sosangmatphai = item.sosangmatphai;
            emrCkMat.sosangmattrai = item.sosangmattrai;
            emrCkMat.thethuytinhmatphai = item.thethuytinhmatphai;
            emrCkMat.thethuytinhmattrai = item.thethuytinhmattrai;
            emrCkMat.thiluccokinhphai = item.thiluccokinhphai;
            emrCkMat.thiluccokinhtrai = item.thiluccokinhtrai;
            emrCkMat.thiluckhongkinhphai = item.thiluckhongkinhphai;
            emrCkMat.thiluckhongkinhtrai = item.thiluckhongkinhtrai;
            emrCkMat.thitruongphai = item.thitruongphai;
            emrCkMat.thitruongtrai = item.thitruongtrai;
            emrCkMat.tienphongmatphai = item.tienphongmatphai;
            emrCkMat.tienphongmattrai = item.tienphongmattrai;
            emrCkMat.trieuchungmatphai = item.trieuchungmatphai;
            emrCkMat.trieuchungmattrai = item.trieuchungmattrai;
            emrCkMat.vannhanmatphai = item.vannhanmatphai;
            emrCkMat.vannhanmattrai = item.vannhanmattrai;
        }
        return emrCkMat;


    }
    #endregion
    #endregion

    #region Bệnh án Nha Bạ
    private emrYhctNhaBa getemrYhctNhaBa(int idDanhSachHSBA)
    {
        emrYhctNhaBa yhctNhaBa = new emrYhctNhaBa();
        var result = _dbContext.tbl_emrYhctNhaBas.Where(x => x.IDDanhSachHSBA == idDanhSachHSBA).SingleOrDefault();
        if (result != null)
        {
            yhctNhaBa.chandoan_nhaba = result.chandoan_nhaba;
            yhctNhaBa.ngaybatdauchua_nhaba = result.ngaybatdauchua_nhaba.HasValue == true ? toDateFormat(result.ngaybatdauchua_nhaba.Value) : "";
            yhctNhaBa.tenbacsichua_nhaba = result.tenbacsichua_nhaba;
        }
        return yhctNhaBa;
    }
    private emrYhctNhaBaGhiChu[] getemrYhctNhaBaGhiChus(int idDanhSachHSBA)
    {
        List<emrYhctNhaBaGhiChu> list = new List<emrYhctNhaBaGhiChu>();
        var listGhiChu = _dbContext.tbl_emrYhctNhaBaGhiChus.Where(x => x.IDDanhSachHSBA == idDanhSachHSBA).ToList();
        if (listGhiChu.Count > 0)
        {
            foreach (var item in listGhiChu)
            {
                emrYhctNhaBaGhiChu ghiChu = new emrYhctNhaBaGhiChu();
                ghiChu.ghichu = item.ghichu;
                if (item.ngayhgiohen.HasValue)
                    ghiChu.ngayhgiohen = toDateFormat(item.ngayhgiohen.Value);
                list.Add(ghiChu);
            }

        }
        return list.ToArray();
    }
    #endregion

    #region Bệnh án YHCT
    private emrYhctBenhAn getemrYhctBenhAn(int IdDanhSachHSBA)
    {

        emrYhctBenhAn emrYhctBenhAn = new emrYhctBenhAn();
        var tblemrYhctBenhAn = from p in _dbContext.tbl_emrYhctBenhAns where p.IdDanhSachHSBA == IdDanhSachHSBA select p;
        var item = tblemrYhctBenhAn.DefaultIfEmpty().ToArray()[0];
        if (item != null)
        {
            emrYhctBenhAn.dieutriKethopyhhd = CheckNull(item.dieutriKethopyhhd);
            emrYhctBenhAn.dieutriXoabopbamhuyet = item.dieutriXoabopbamhuyet;
            emrYhctBenhAn.lstchedodinhduong = ConvertChuoiStringID(item.lstchedodinhduong, "DM86");
            emrYhctBenhAn.luantri = item.luantri;
            emrYhctBenhAn.motachamsoc = item.motachamsoc;
            emrYhctBenhAn.motachedodinhduong = item.motachedodinhduong;
            emrYhctBenhAn.phapdieutri = item.phapdieutri;
            emrYhctBenhAn.phuonghuyet = item.phuonghuyet;
            emrYhctBenhAn.phuongphapkhac = item.phuongphapkhac;
            emrYhctBenhAn.phuongthuoc = item.phuongthuoc;
            emrYhctBenhAn.tienluong = item.tienluong;
            emrYhctBenhAn.emrDmYhctCheDoChamSoc = getemrDmYhctCheDoChamSoc(item.emrDmYhctCheDoChamSoc);
            emrYhctBenhAn.tomtattuchan = item.tomtattuchan;
            emrYhctBenhAn.emrYhctBenhanThietChan = getemrYhctBenhanThietChan(item.IdemrYhctBenhAn);
            emrYhctBenhAn.emrYhctBenhanVaanChan = getemrYhctBenhanVaanChan(item.IdemrYhctBenhAn);
            emrYhctBenhAn.emrYhctBenhanVawnChan = getemrYhctBenhanVawnChan(item.IdemrYhctBenhAn);
            emrYhctBenhAn.emrYhctBenhanVongChan = getemrYhctBenhanVongChan(item.IdemrYhctBenhAn);
        }
        return emrYhctBenhAn;

    }
    #endregion

    #region Lấy byte file
    public byte[] GetData(String Path)
    {
        FileStream stream = File.OpenRead(Path);
        byte[] fileBytes = new byte[stream.Length];
        return fileBytes;
    }
    public byte[] convertBase64ByFile(string Path)
    {

        using (StreamReader sr = new StreamReader(Path))
        {
            byte[] AsBytes = File.ReadAllBytes(Path);
            String AsBase64String = Convert.ToBase64String(AsBytes);
            byte[] tempBytes = Convert.FromBase64String(AsBase64String);
            //Random r = new Random();
            //string name = "LeLoiNgoc" + r.Next().ToString() + ".html";
            //File.WriteAllBytes(Server.MapPath(name), tempBytes);
            return tempBytes;
        }

    }
    #endregion

    #region get Tên file
    private String ReturnFileName(String Input)
    {
        if (Input != null)
        {
            String Name = String.Empty;
            string[] pathArr = Input.Split('\\');
            return pathArr.Last().ToString();
        }
        else
            return string.Empty;
    }
    #endregion


}
