using DTT.HL7Core;
using HTC;
using HTC.Common.Web;
using Infrastructure.Core;
using Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

/// <summary>
/// Summary description for HL7Service
/// </summary>
public class HL7Service: WebBase
{
    private readonly HTCDbContext DbContext = new HTCDbContext();
    //private readonly IDbFactory dbFactory;

    //public HL7Service(IDbFactory dbFactory) : base(dbFactory)
    //    {
    //    this.dbFactory = dbFactory;
    //}
    public String _DuoiMaKhoaHue
    {
        get
        {
            switch(System.Configuration.ConfigurationManager.AppSettings["BVTUHue"] ?? "")
            {
                case "BVTUHue": return "-TW";
                case "BVQTHue": return "-QT";
                default: return "";
            }
        }
    }

    public String _DuoiTenKhoaHue
    {
        get
        {
            switch (System.Configuration.ConfigurationManager.AppSettings["BVTUHue"] ?? "")
            {
                case "BVTUHue": return "-BVTW";
                case "BVQTHue": return "-BVQT";
                default: return "";
            }
        }
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
            object[] paras ={
                new SqlParameter("@MaBa",Maba)
             };
            List<emrMappingDetail> list = DbContext.Database.SqlQuery<emrMappingDetail>("sp_ViewMapping @MaBa", paras).ToList();

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

    private String SapXepDESC(string str)// Chuỗi truyền vào có ngăn cách giá trị = |
    {
        if (!string.IsNullOrEmpty(str))
        {
            List<string> input = new List<string>();
            string[] strNew = str.Split('|');
            string outPut = string.Empty;
            List<int> INPUT = new List<int>();
            if (strNew.Length > 0)
            {
                foreach (string item in strNew)
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
            else
                return string.Empty;


        }
        else
            return string.Empty;

    }

    #endregion Hàm chỉ đúng với input 0x sai khi có dạng 0xx

    #region Hàm Convert Chuỗi ID theo danh mục trả về 1 chuỗi ID theo định dạng format của DTT cũng có  thể convert 1 id:)


    #endregion Hàm Convert Chuỗi ID theo danh mục trả về 1 chuỗi ID theo định dạng format của DTT cũng có  thể convert 1 id:)

    #region Insert history transferHSBA

    private void InserttblHSBATransferHistory(String MaHSBA, String MaYC, String MaNV, String MaLoaiBA, String DuLieu, DateTime NgayTruyen, Boolean Status)
    {
        object[] paras ={
            new SqlParameter("@MaBA",MaHSBA),
            new SqlParameter("@MaYC",MaYC),
            new SqlParameter("@MaNV",MaNV),
            new SqlParameter("@MaLoaiBA",MaLoaiBA),
            new SqlParameter("@DuLieu",DuLieu),
            new SqlParameter("@NgayTruyen",NgayTruyen),
            new SqlParameter("@Status",Status)
        };

        DbContext.Database.ExecuteSqlCommand("sp_InserttblHSBATransferHistory @MaBA,@MaYC,@MaNV,@MaLoaiBA,@DuLieu,@NgayTruyen,@Status", paras);
    }

    #endregion Insert history transferHSBA

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

    #endregion Convert object to XML

    #region TransferHSBa truyền vào 1 mã hsba

    public string TransferHSBANew(string maHSBA, string MaLoaiBenhAn, string currentPathServer, string Pub_sAccount)
    {
        string outPut = string.Empty;
        string MaYc = string.Empty;
        emrDanhSachHoSoBenhAn hsba = new emrDanhSachHoSoBenhAn();

        HTC.Business.Officer.Account user = (HTC.Business.Officer.Account)HTC.Business.Officer.Account.GetAccount(Pub_sAccount);
        try
        {
            try
            {
                hsba = poPulateHSBA(maHSBA, MaLoaiBenhAn, currentPathServer);
                String May = String.Empty;
                using (DTT.HL7Core.HisWebservice service = new DTT.HL7Core.HisWebservice())
                {
                    DTT.HL7Core.OpenmrsResponse Result = service.transferHSBA(hsba);
                    if (Result.status.Equals("OK"))
                    {
                        InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, true);
                        outPut = "Đã gửi thành công hồ sơ bệnh án sang hệ thống HL7Core bệnh viện !";
                    }
                    else
                    {
                        InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, false);
                        outPut = "Gửi hồ sơ bệnh án không thành công !" + Result.errormessage.ToString();
                    }
                    //  HSBALockTableAdapter hsbaAdapter = new HSBALockTableAdapter();
                    //  hsbaAdapter.TransferHSBA(maHSBA, DateTime.Now, Pub_sAccount);
                }
            }
            catch (Exception ex)
            {
                outPut = " Error:" + ex.Message;
                InserttblHSBATransferHistory(maHSBA, MaYc, user.MaNV, MaLoaiBenhAn, returnObjectToXml(hsba), DateTime.Now, false);
                
                // return false;
            }

            return outPut;
        }
        catch (Exception)
        {
            //throw;
            return outPut;
        }
    }

    #endregion TransferHSBa truyền vào 1 mã hsba

    #region Trả về object DanhSachHSBA

    public emrDanhSachHoSoBenhAn poPulateHSBA(string maHSBA, string maLoaiBA, string currentPathServer)
    {
        object[] paras =
          {
                 new SqlParameter("@MaBA",maHSBA)
          };

        var cmd = this.DbContext.Database.Connection.CreateCommand();
        cmd.CommandText = "sp_HSBATransfer";
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (var para in paras)
        {
            cmd.Parameters.Add(para);
        }
        if (DbContext.Database.Connection.State == ConnectionState.Closed)
            DbContext.Database.Connection.Open();
        var reader = cmd.ExecuteReader();
        ((IObjectContextAdapter)DbContext).ObjectContext.CommandTimeout = 1000;
        // 1
        var item = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrDanhSachHoSoBenhAnVM>(reader).SingleOrDefault();

        emrDanhSachHoSoBenhAn Hsba = new emrDanhSachHoSoBenhAn();
        if (item != null)
        {
            int IdDanhSachHSBA = 0;

            IdDanhSachHSBA = int.Parse(item.IDDanhSachHSBA.ToString());
            if (IdDanhSachHSBA > 0)
            {
                // Chú ý thứ tự lấy dữ liệu tuần tự theo stored
                Hsba.emrDmLoaiBenhAn = getEmrDmLoaiBenhAn(item.emrDmLoaiBenhAn);
                reader.NextResult(); //2 emrBenhNhan
                var itemEmrBenhNhan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrBenhNhanVM>(reader).SingleOrDefault();
                reader.NextResult(); //3 emrBenhAn
                var itemEmrBenhAn = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrBenhAnVM>(reader).SingleOrDefault();
                reader.NextResult(); //4 Vào Khoa
                var listEmrVaoKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrVaoKhoaVM>(reader).ToList();
                reader.NextResult();// 5 Hội chẩn
                var listEmrHoiChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrHoiChanVM>(reader).ToList();
                reader.NextResult();// 6 Hội đồng hội chẩn
                var listEmrHoiDongHoiChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrHoiDongHoiChanVM>(reader).ToList();
                reader.NextResult();// 7 Chăm sóc
                var listEmrChamSoc = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrChamSocVM>(reader).ToList();
                reader.NextResult();// 8 Điều trị
                var listEmrDieuTri = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrDieuTriVM>(reader).ToList();
                reader.NextResult();// 9 Chức năng sống
                var listEmrChucNangSong = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrChucNangSongVM>(reader).ToList();

                reader.NextResult(); // 10 Đơn thuốc
                var listEmrDonThuoc = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrDonThuocVM>(reader).ToList();
                reader.NextResult(); // 11 Đơn thuốc chi tiết
                var listEmrDonThuocChiTiet = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrDonThuocChiTietVM>(reader).ToList();
                reader.NextResult(); // 12 Giải phẫu bệnh
                var listEmrGiaiPhauBenh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrGiaiPhauBenhVM>(reader).ToList();
                reader.NextResult(); // 13 Hình ảnh tổn thương // Chưa có dữ liệu
                var listEmrHinhAnhTonThuong = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrHinhAnhTonThuongVM>(reader).ToList();
                reader.NextResult(); // 14 emrChanDoan
                var itemEmrChanDoan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrChanDoanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 15 Phẫu thuật thủ thuật
                var listEmrPhauThuatThuThuat = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrPhauThuatThuThuatVM>(reader).ToList();
                reader.NextResult(); // 16 Phẫu thuật thủ thuật
                var listHoiDongPhauThuat = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrHoiDongPtttsVM>(reader).ToList();


                reader.NextResult(); // 17 Chẩn đoán hình ảnh
                var listEmrChanDoanHinhAnh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrChanDoanHinhAnhVM>(reader).ToList();
                reader.NextResult(); // 18 Chẩn đoán hình ảnh
                var listEmrFileDinhKemChanDoanHinhAnh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemVM>(reader).ToList();

                reader.NextResult(); // 19 Chẩn đoán hình ảnh
                var listEmrSaveFileDinhKemChanDoanHinhAnh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemCdhaVM>(reader).ToList();


                reader.NextResult(); // 20 Thăm dò chức năng
                var listEmrThamDoChucNang = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrThamDoChucNangVM>(reader).ToList();
                reader.NextResult(); // 21 File đính kèm Thăm dò chức năng
                var listFileEmrThamDoChucNang = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemVM>(reader).ToList();
                reader.NextResult(); // 22 File đính kèm Thăm dò chức năng
                var listFileSaveEmrThamDoChucNang = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemTdcnVM>(reader).ToList();
                reader.NextResult(); // 23 Xét nghiệm
                var listEmrXetNghiem = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrXetNghiemVM>(reader).ToList();
                reader.NextResult(); // 24 Xét nghiệm dịch vụ
                var listEmrXetNghiemDichVu = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrXetNghiemDichVuVM>(reader).ToList();
                reader.NextResult(); // 25 Xét nghiệm kết quả
                var listEmrXetNghiemKetQua = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrXetNghiemKetQuaVM>(reader).ToList();
                reader.NextResult(); // 26 File đính kèm xét nghiệm
                var listEmrQuanLyFileDinhKemXN = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemVM>(reader).ToList();
                reader.NextResult(); // 27 File đính kèm xét nghiệm
                var listEmrQuanLySaveFileDinhKemXN = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyFileDinhKemXnVM>(reader).ToList();

                reader.NextResult(); // 28 File đính kèm xét nghiệm
                var itemEmrQuanLyNguoiBenh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrQuanLyNguoiBenhVM>(reader).SingleOrDefault();
                reader.NextResult(); // 29 Tình trạng ra viện
                var itemEmrTinhTrangRaVien = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrTinhTrangRaVienVM>(reader).SingleOrDefault();
                reader.NextResult(); // 30 Tổng kết ra viện
                var itemEmrTongKetRaVien = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrTongKetRaVienVM>(reader).SingleOrDefault();
                reader.NextResult(); // 31 Tổng kết sản khoa
                var itemEmrTongKetSanKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrTongKetSanKhoaVM>(reader).SingleOrDefault();
                reader.NextResult(); // 32 Toàn thân
                var itemEmrCkToanThan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkToanThanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 33 Thần kinh
                var itemEmrCkThanKinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkThanKinhVM>(reader).SingleOrDefault();
                reader.NextResult(); // 34 Tâm thần
                var itemEmrCkTamThan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTamThanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 35 Tiêm chủng
                var itemEmrCkTiemChung = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTiemChungVM>(reader).SingleOrDefault();
                reader.NextResult(); // 36 Quá trình sinh trưởng
                var itemEmrCkQuaTrinhSinhTruong = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkQuaTrinhSinhTruongVM>(reader).SingleOrDefault();
                reader.NextResult(); // 37 Phương pháp hồi sinh
                var itemEmrCkPhuongPhapHoiSinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkPhuongPhapHoiSinhVM>(reader).SingleOrDefault();
                reader.NextResult(); // 38 Tiền sử gia đình
                var itemEmrCkTienSuGiaDinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTienSuGiaDinhVM>(reader).SingleOrDefault();
                reader.NextResult(); // 39 YHCT Bệnh án
                var itemEmrYhctBenhAn = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctBenhAnVM>(reader).SingleOrDefault();
                reader.NextResult(); // 40 YHCT thiết chẩn
                var itemEmrYhctBenhanThietChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctBenhanThietChanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 38 YHCT vấn chẩn
                var itemEmrYhctBenhanVaanChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctBenhanVaanChanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 41 YHCT văn chẩn
                var itemEmrYhctBenhanVawnChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctBenhanVawnChanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 42 YHCT vọng chẩn
                var itemEmrYhctBenhanVongChan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctBenhanVongChanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 43 YHCT chẩn đoán
                var itemEmrYhctChanDoan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctChanDoanVM>(reader).SingleOrDefault();
                reader.NextResult(); // 44 YHCT đơn thuốc
                var listYhctDonThuoc = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctDonThuocVM>(reader).ToList();
                reader.NextResult(); // 45 YHCT đơn thuốc chi tiết
                var listYhctDonThuocChiTiet = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYHCTDonThuocChiTietVM>(reader).ToList();

                reader.NextResult();//46 File đính kèm bệnh án
                var listEmrQuanLyFileDinhKemBenhAnVM = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_ID_emrQuanLyFileDinhKemBenhAnVM>(reader).ToList();

                reader.NextResult();//47 Nha bạ
                var listEmrYhctNhaBa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctNhaBaVM>(reader).SingleOrDefault();
                reader.NextResult();//48 Nha bạ ghi chú
                var listEmrYhctNhaBaGhiChu = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrYhctNhaBaGhiChuVM>(reader).ToList();
                reader.NextResult(); // 49 Khám sản khoa
                var itemEmrCkKhamSanKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkKhamSanKhoaVM>(reader).SingleOrDefault();
                reader.NextResult(); // 50 Khám phụ
                var itemEmrCkKhamPhuKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkKhamPhuKhoaVM>(reader).SingleOrDefault();
                reader.NextResult(); //51 Khám sơ sinh
                var itemEmrCkKhamSoSinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkKhamSoSinhVM>(reader).SingleOrDefault();
                reader.NextResult();// 52 Tình trạng sơ sinh
                var itemEmrCkTinhTrangSoSinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTinhTrangSoSinhVM>(reader).SingleOrDefault();
                reader.NextResult();// 53 Tiền sử sản khoa
                var listEmrCkTienSuSanKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTienSuSanKhoaVM>(reader).ToList();
                reader.NextResult();// 54 Tình trạng sản phụ // sản khoa
                var itemEmrCkSkTinhTrangSanPhu = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkSkTinhTrangSanPhuVM>(reader).SingleOrDefault();
                reader.NextResult(); // 55 Tình trạng sản phụ // Phụ khoa
                var itemEmrCkTinhTrangSanPhu = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTinhTrangSanPhuVM>(reader).SingleOrDefault();
                reader.NextResult();// 56 Tiền sửa bản thân sản
                var itemEmrCkTienSuBanThanSanKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTienSuBanThanSanKhoaVM>(reader).SingleOrDefault();
                reader.NextResult();// 57 Bệnh án mắt
                var itemEmrCkMat = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkMatVM>(reader).SingleOrDefault();
                reader.NextResult();// 58 Huế ra viện mắt
                var itemEmrCkTinhTrangRaVienMat = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTinhTrangRaVienMatVM>(reader).SingleOrDefault();
                reader.NextResult();// 59 Huế điều trị ung bướu
                var itemEmrCkPhuongPhapDieuTriUngBuou = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkPhuongPhapDieuTriUngBuouVM>(reader).SingleOrDefault();

                reader.NextResult(); // 60 Tiền sửa phụ khoa
                var itemEmrCkTienSuPhuKhoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTienSuPhuKhoaVM>(reader).SingleOrDefault();
                reader.NextResult();// 61 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkMoiSinh = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkMoiSinhVM>(reader).SingleOrDefault();
                reader.NextResult();// 62 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkChucNangSinhHoat = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkChucNangSinhHoatVM>(reader).SingleOrDefault();
                reader.NextResult();// 63 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkTuanHoan = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTuanHoanVM>(reader).SingleOrDefault();
                reader.NextResult();// 64 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkTieuHoa = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkTieuHoaVM>(reader).SingleOrDefault();
                reader.NextResult();// 65 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkCoXuongKhop = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkCoXuongKhopVM>(reader).SingleOrDefault();
                reader.NextResult();// 66 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkHoHapVM = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkHoHapVM>(reader).SingleOrDefault();
                reader.NextResult();// 67 Chỉ của Huế, các viện khác truyền =null
                var itemEmrCkHuongDieuTriHuyetHoc = ((IObjectContextAdapter)DbContext).ObjectContext.Translate<tbl_emrCkHuongDieuTriHuyetHocVM>(reader).SingleOrDefault();


                if (this.DbContext.Database.Connection.State == ConnectionState.Open)
                    this.DbContext.Database.Connection.Close();

                Hsba.emrBenhAn = getemrBenhAn(itemEmrBenhAn,
                    itemEmrCkMat, itemEmrCkThanKinh,
                    itemEmrCkTamThan, itemEmrCkKhamSanKhoa,
                    itemEmrCkKhamPhuKhoa, itemEmrCkKhamSoSinh,
                    itemEmrCkTinhTrangSoSinh, listEmrCkTienSuSanKhoa,
                    itemEmrCkSkTinhTrangSanPhu, itemEmrCkTinhTrangSanPhu,
                    itemEmrCkQuaTrinhSinhTruong, itemEmrCkToanThan,
                    itemEmrCkPhuongPhapHoiSinh, itemEmrCkTiemChung,
                    itemEmrCkTienSuGiaDinh, itemEmrCkTienSuBanThanSanKhoa,
                    itemEmrCkTienSuPhuKhoa, itemEmrCkMoiSinh,
                    itemEmrCkChucNangSinhHoat, itemEmrCkTuanHoan,
                    itemEmrCkTieuHoa, itemEmrCkCoXuongKhop,
                    itemEmrCkHoHapVM, itemEmrCkHuongDieuTriHuyetHoc
                    );

                Hsba.emrQuanLyNguoiBenh = getemrQuanLyNguoiBenh(itemEmrQuanLyNguoiBenh);
                Hsba.emrBenhNhan = getemrBenhNhan(itemEmrBenhNhan);
                Hsba.emrTongKetRaVien = getemrTongKetRaVien(itemEmrTongKetRaVien, itemEmrCkPhuongPhapDieuTriUngBuou, itemEmrCkTinhTrangRaVienMat);
                Hsba.emrPhauThuatThuThuats = getemrPhauThuatThuThuats(listEmrPhauThuatThuThuat, listHoiDongPhauThuat);
                Hsba.emrXetNghiems = getemrXetNghiems(listEmrXetNghiem, listEmrXetNghiemDichVu, listEmrXetNghiemKetQua, listEmrQuanLyFileDinhKemXN, listEmrQuanLySaveFileDinhKemXN, currentPathServer);
                Hsba.emrChanDoan = getemrChanDoan(itemEmrChanDoan);
                Hsba.emrChanDoanHinhAnhs = getemrChanDoanHinhAnhs(listEmrChanDoanHinhAnh, listEmrFileDinhKemChanDoanHinhAnh, listEmrSaveFileDinhKemChanDoanHinhAnh, currentPathServer);
                Hsba.emrHinhAnhTonThuongs = getemrHinhAnhTonThuongs(maHSBA, maLoaiBA, IdDanhSachHSBA, currentPathServer);
                Hsba.emrThamDoChucNangs = getemrThamDoChucNangs(listEmrThamDoChucNang, listFileEmrThamDoChucNang, listFileSaveEmrThamDoChucNang, currentPathServer);
                Hsba.emrGiaiPhauBenhs = getemrGiaiPhauBenhs(listEmrGiaiPhauBenh);
                Hsba.emrDonThuocs = getemrDonThuocs(listEmrDonThuoc, listEmrDonThuocChiTiet);
                Hsba.emrVaoKhoas = getemrVaoKhoas(listEmrVaoKhoa, listEmrDieuTri, listEmrChamSoc, listEmrHoiChan, listEmrHoiDongHoiChan, listEmrChucNangSong);
                Hsba.emrQuanLyFileDinhKemBenhAn = getemrQuanLyFileDinhKemBenhAn(listEmrQuanLyFileDinhKemBenhAnVM);
                Hsba.emrTongKetSanKhoa = getemrTongKetSanKhoa(itemEmrTongKetSanKhoa);
                Hsba.mayte = item.mayte; // Mã y tế là mabaql nội trú, ngoại trú SoRaVien
                // Hiện tại không cần truyền thông tin này, phía HL7 sẽ nhập thông tin này.
                // Hsba.maluutru = item.maluutru;
                Hsba.emrTinhTrangRaVien = getemrTinhTrangRaVien(maHSBA, maLoaiBA, IdDanhSachHSBA);
                Hsba.matraodoi = item.matraodoi + "|" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (ShareVariables.pub_spC.Equals("YH"))
                {
                    Hsba.emrYhctNhaBa = getemrYhctNhaBa(listEmrYhctNhaBa);
                    Hsba.emrYhctNhaBaGhiChus = getemrYhctNhaBaGhiChus(listEmrYhctNhaBaGhiChu);
                }
                if (!ShareVariables.pub_spC.Equals("PS")) // && !ShareVariables.pub_spC.Equals("HU") // Huế cũng dùng YHCT
                {
                    Hsba.emrYhctBenhAn = getemrYhctBenhAn(itemEmrYhctBenhAn, itemEmrYhctBenhanThietChan, itemEmrYhctBenhanVaanChan, itemEmrYhctBenhanVawnChan, itemEmrYhctBenhanVongChan);
                    Hsba.emrYhctDonThuocs = getEmrYhctDonThuocs(listYhctDonThuoc, listYhctDonThuocChiTiet);
                    //Response.Write("Có vào ");
                    Hsba.emrYhctBenhAn.motachamsoc = "";
                    Hsba.emrYhctChanDoan = GetEmrYhctChanDoan(itemEmrYhctChanDoan);
                }
            }
        }
        return Hsba;
    }

    private emrQuanLyFileDinhKemBenhAn[] getemrQuanLyFileDinhKemBenhAn(List<tbl_ID_emrQuanLyFileDinhKemBenhAnVM> listEmrQuanLyFileDinhKemBenhAnVM)
    {
        List<emrQuanLyFileDinhKemBenhAn> list = new List<emrQuanLyFileDinhKemBenhAn>();

        foreach (tbl_ID_emrQuanLyFileDinhKemBenhAnVM item in listEmrQuanLyFileDinhKemBenhAnVM)
        {
            if (item != null)
            {
                emrQuanLyFileDinhKemBenhAn emrQuanLyFileDinhKemBenhAn = new emrQuanLyFileDinhKemBenhAn();

                emrQuanLyFileDinhKemBenhAn.tenfile = ConvertVN(item.TenFile);
                if (!string.IsNullOrEmpty(item.DuongDan))
                    emrQuanLyFileDinhKemBenhAn.noiDungFile = convertBase64ByFile((item.DuongDan));
                list.Add(emrQuanLyFileDinhKemBenhAn);
            }
        }

        return list.ToArray();
    }

    private emrYhctDonThuoc[] getEmrYhctDonThuocs(List<tbl_emrYhctDonThuocVM> listDonThuoc, List<tbl_emrYHCTDonThuocChiTietVM> listDonThuocChiTiet)
    {
        List<emrYhctDonThuoc> list = new List<emrYhctDonThuoc>();


        int CountSoDon = 0;
        if (listDonThuoc != null)
            foreach (var item in listDonThuoc)
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
                    emrYhctDonThuoc.emrYhctDonThuocChiTiets = getemrYhctDonThuocChiTiets(item.IdemrYHCTDonThuoc??0, listDonThuocChiTiet);
                    list.Add(emrYhctDonThuoc);
                }
            }
        return list.ToArray();
    }

    private emrYhctDonThuocChiTiet[] getemrYhctDonThuocChiTiets(int IdemrYHCTDonThuoc, List<tbl_emrYHCTDonThuocChiTietVM> listDonThuocChiTiet)
    {
        List<emrYhctDonThuocChiTiet> list = new List<emrYhctDonThuocChiTiet>();


        if (listDonThuocChiTiet != null)
            foreach (var item in listDonThuocChiTiet)
            {
                if (item != null && item.IdemrYHCTDonThuoc == IdemrYHCTDonThuoc)
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
        dMTanXuat.ma = emrDmTanXuatDungThuoc;
        return dMTanXuat;
    }

    private emrDmDuongDungThuoc getemrDmDuongDungThuoc(string emrDmDuongDungThuoc)
    {
        emrDmDuongDungThuoc emrDmDuongDung = new emrDmDuongDungThuoc();
        //  emrDmDuongDungThuoc.ma = getMaDTT(item.emrDmDuongDungThuoc, "DM38");
        emrDmDuongDung.ma = emrDmDuongDungThuoc;// Tạm thời face để truyền,phía bệnh viện chưa có dữ liệu
        return emrDmDuongDung;
    }

    private emrDmYhctViThuoc getemrDmYhctViThuoc(string ma)
    {
        emrDmYhctViThuoc emrDmYhctViThuoc = new emrDmYhctViThuoc();
        emrDmYhctViThuoc.ma = ma;// getMaDTT(p, "DM88");
        return emrDmYhctViThuoc;
    }

    private emrYhctChanDoan GetEmrYhctChanDoan(tbl_emrYhctChanDoanVM item)
    {
        emrYhctChanDoan emrYhctChanDoan = new emrYhctChanDoan();
        if (item != null)
        {
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctravien = getemrDmYhctBenhDanhByIdbenhdanhyhctravien(item.emrDmYhctBenhDanhByIdbenhdanhyhctravien);
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctvaovien = getemrDmYhctBenhDanhByIdbenhdanhyhctvaovien(item.emrDmYhctBenhDanhByIdbenhdanhyhctvaovien);
            emrYhctChanDoan.emrDmYhctBenhDanhByIdbenhdanhyhctVk = getemrDmYhctBenhDanhByIdbenhdanhyhctVk(item.emrDmYhctBenhDanhByIdbenhdanhyhctVk);
            emrYhctChanDoan.lstbatcuong = SapXepDESC(item.lstbatcuong);//  "DM51"
            emrYhctChanDoan.lstbatcuongVv = SapXepDESC(item.lstbatcuongVv); //"DM51"
            emrYhctChanDoan.lstdinhvibenh = SapXepDESC(item.lstdinhvibenh);//  "DM54" 
            emrYhctChanDoan.lstdinhvibenhVv = SapXepDESC(item.lstdinhvibenhVv);// "DM54"
            emrYhctChanDoan.lstkinhmach = SapXepDESC(item.lstkinhmach);// "DM53"
            emrYhctChanDoan.lstkinhmachVv = SapXepDESC(item.lstkinhmachVv);// "DM53"
            emrYhctChanDoan.lstnguyennhanbenh = SapXepDESC(item.lstnguyennhanbenh);//"DM55"
            emrYhctChanDoan.lstnguyennhanbenhVv = SapXepDESC(item.lstnguyennhanbenhVv);//"DM55"
            emrYhctChanDoan.lsttangphu = SapXepDESC(item.lsttangphu);//"DM52"
            emrYhctChanDoan.lsttangphuVv = SapXepDESC(item.lsttangphuVv);// "DM52"
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

    private emrTinhTrangRaVien getemrTinhTrangRaVien(string maBA, string maLoaiBA, int IdDanhSachHSBA)
    {
        emrTinhTrangRaVien emrTinhTrangRaVien = new emrTinhTrangRaVien();
        object[] paras =
        {
            new SqlParameter("@MaBa",maBA),
            new SqlParameter("@MaLoaiBa",maLoaiBA),
            new SqlParameter("@IdDanhSachHSBA",IdDanhSachHSBA)
        };
        var item = DbContext.Database.SqlQuery<tbl_emrTinhTrangRaVienVM>("sp_Insert_tbl_emrTinhTrangRaVien @MaBa,@MaLoaiBa,@IdDanhSachHSBA", paras).SingleOrDefault();

        if (item != null)
        {
            emrTinhTrangRaVien.emrDmKetQuaDieuTri = getemrDmKetQuaDieuTri(item.emrDmKetQuaDieuTri);
            emrTinhTrangRaVien.emrDmKetQuaGiaiPhauBenh = getemrDmKetQuaGiaiPhauBenh(item.emrDmKetQuaGiaiPhauBenh);
            emrTinhTrangRaVien.emrDmLyDoTuVong = getemrDmLyDoTuVong(item.emrDmLyDoTuVong);
            emrTinhTrangRaVien.emrDmMaBenhByIdicdGiaiphaututhi = getemrDmMaBenhByIdicdGiaiphaututhi(item.emrDmMaBenhByIdicdGiaiphaututhi);
            emrTinhTrangRaVien.emrDmMaBenhByIdicdNguyennhantuvong = getemrDmMaBenhByIdicdNguyennhantuvong(item.emrDmMaBenhByIdicdNguyennhantuvong);
            emrTinhTrangRaVien.emrDmThoiDiemTuVong = getemrDmThoiDiemTuVong(item.emrDMThoiDiemTuVong);
            emrTinhTrangRaVien.khamnghiemtuthi = CheckNullReturnTrueFalse(item.khamnghiemtuthi);
            emrTinhTrangRaVien.motagiaiphaututhi = CheckNull(item.motagiaiphaututhi);
            emrTinhTrangRaVien.motanguyennhantuvong = CheckNull(item.motanguyennhantuvong);
            emrTinhTrangRaVien.ngaygiotuvong = toDateFormat(item.ngaygiotuvong);
        }
        return emrTinhTrangRaVien;
    }

    private emrDmThoiDiemTuVong getemrDmThoiDiemTuVong(string maThoiDiemTuVong)
    {
        emrDmThoiDiemTuVong emrDmThoiDiemTuVong = new emrDmThoiDiemTuVong();
        emrDmThoiDiemTuVong.ma = maThoiDiemTuVong;
        return emrDmThoiDiemTuVong;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdNguyennhantuvong(string item) // Thông tin này đang lấy luôn mã ICD bệnh ra viện
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdGiaiphaututhi(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmKetQuaGiaiPhauBenh getemrDmKetQuaGiaiPhauBenh(string item)
    {
        emrDmKetQuaGiaiPhauBenh emrDmKetQuaGiaiPhauBenh = new emrDmKetQuaGiaiPhauBenh();
        emrDmKetQuaGiaiPhauBenh.ma = item;
        return emrDmKetQuaGiaiPhauBenh;
    }

    private emrDmLyDoTuVong getemrDmLyDoTuVong(string item)
    {
        emrDmLyDoTuVong emrDmLyDoTuVong = new emrDmLyDoTuVong();
        emrDmLyDoTuVong.ma = item;
        return emrDmLyDoTuVong;
    }

    private emrDmKetQuaDieuTri getemrDmKetQuaDieuTri(string itememrDmKetQuaDieuTri)
    {
        emrDmKetQuaDieuTri emrDmKetQuaDieuTri = new emrDmKetQuaDieuTri();
        emrDmKetQuaDieuTri.ma = itememrDmKetQuaDieuTri;
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

    private emrTongKetSanKhoa getemrTongKetSanKhoa(tbl_emrTongKetSanKhoaVM item)
    {
        emrTongKetSanKhoa emrTongKetSanKhoa = new emrTongKetSanKhoa();
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
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaiamdao = getemrDmTrangThaiMoDeByIdtrangthaiamdao(item.emrDmTrangThaiMoDeByIdtrangthaiamdao);
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaicotucung = getemrDmTrangThaiMoDeByIdtrangthaicotucung(item.emrDmTrangThaiMoDeByIdtrangthaicotucung);
            emrTongKetSanKhoa.emrDmTrangThaiMoDeByIdtrangthaisinhmon = getemrDmTrangThaiMoDeByIdtrangthaisinhmon(item.emrDmTrangThaiMoDeByIdtrangthaisinhmon);
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
                emrTongKetSanKhoa.emrDmCachDe = getemrDmCachDe(item.emrDmCachDe);

            emrTongKetSanKhoa.kiemsoattucung = CheckNullReturnTrueFalse(item.kiemsoattucung);
            emrTongKetSanKhoa.luongmaumat = CheckNull(item.luongmaumat);
            emrTongKetSanKhoa.lydobocrau = item.lydobocrau;
            emrTongKetSanKhoa.lydocanthiep = item.lydocanthiep;
            emrTongKetSanKhoa.lydokiemsoat = CheckNull(item.lydokiemsoat);
            //   emrTongKetSanKhoa.mach = row["Mach"] is DBNull ? null: row.Mach;
            //emrckTongKetSanNhietDo Mới thêm vào table
            emrTongKetSanKhoa.nhietdo = formatNhietDo(item.nhietdo);
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
            emrTongKetSanKhoa.soluongchet = CheckNull(item.soluongchet);
            emrTongKetSanKhoa.soluongsong = CheckNull(item.soluongsong);
            emrTongKetSanKhoa.somuikhau = CheckNull(item.somuikhau);
            emrTongKetSanKhoa.phuongphapkhauloaichi = CheckNull(item.phuongphapkhauloaichi);
            emrTongKetSanKhoa.xulysorau = CheckNull(item.xulysorau);
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

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaisinhmon(string item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item;
        return emrDmTrangThaiMoDe;
    }

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaicotucung(string item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item;
        return emrDmTrangThaiMoDe;
    }

    private emrDmTrangThaiMoDe getemrDmTrangThaiMoDeByIdtrangthaiamdao(string item)
    {
        emrDmTrangThaiMoDe emrDmTrangThaiMoDe = new emrDmTrangThaiMoDe();
        if (item != null)
            emrDmTrangThaiMoDe.ma = item;
        return emrDmTrangThaiMoDe;
    }

    private emrDmCachDe getemrDmCachDe(string item)
    {
        emrDmCachDe emrDmCachDe = new emrDmCachDe();
        if (ShareVariables.pub_spC.Equals("HU"))
        {
            string maCachDe = string.Empty;
            maCachDe = item; // Huế mới bổ sung danh mục này:D tự mapping trong store
            if (!string.IsNullOrEmpty(maCachDe))
                emrDmCachDe.ma = maCachDe;
        }
        else
        {
            String CachDe = item;
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

    private emrQuanLyNguoiBenh getemrQuanLyNguoiBenh(tbl_emrQuanLyNguoiBenhVM item)
    {
        emrQuanLyNguoiBenh emrQuanLyNguoiBenh = new emrQuanLyNguoiBenh();


        if (item != null)
        {
            emrQuanLyNguoiBenh.emrDmCoSoKhamBenh = getemrDmCoSoKhamBenh(item.emrDmCoSoKhamBenh);// Chưa truyền
            emrQuanLyNguoiBenh.emrDmLoaiChuyenVien = getemrDmLoaiChuyenVien(item.emrDmLoaiChuyenVien);// Chưa truyền
            emrQuanLyNguoiBenh.emrDmLoaiDoiTuongTaiChinh = getemrDmLoaiDoiTuongTaiChinh(item.emrDmLoaiDoiTuongTaiChinh);
            emrQuanLyNguoiBenh.emrDmLoaiRaVien = getemrDmLoaiRaVien(item.emrDmLoaiRaVien);
            emrQuanLyNguoiBenh.emrDmLoaiVaoVien = getemrDmLoaiVaoVien(item.emrDmLoaiVaoVien);// fix 01 trong store
            emrQuanLyNguoiBenh.emrDmNoiGioiThieu = getemrDmNoiGioiThieu(item.emrDmNoiGioiThieu);
            emrQuanLyNguoiBenh.emrDmNoiTrucTiepVao = getemrDmNoiTrucTiepVao(item.emrDmNoiTrucTiepVao);
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

    #endregion Quản Lý người bệnh

    private emrDmNoiTrucTiepVao getemrDmNoiTrucTiepVao(string item)
    {
        emrDmNoiTrucTiepVao emrDmNoiTrucTiepVao = new emrDmNoiTrucTiepVao();
        if (item != null)
            emrDmNoiTrucTiepVao.ma = item;
        return emrDmNoiTrucTiepVao;
    }

    private emrDmNoiGioiThieu getemrDmNoiGioiThieu(string item)
    {
        emrDmNoiGioiThieu emrDmNoiGioiThieu = new emrDmNoiGioiThieu();
        if (item != null)
            emrDmNoiGioiThieu.ma = item;
        return emrDmNoiGioiThieu;
    }

    private emrDmLoaiVaoVien getemrDmLoaiVaoVien(string item) // Không phải ánh xạ DM08
    {
        emrDmLoaiVaoVien emrDmLoaiVaoVien = new emrDmLoaiVaoVien();
        if (ShareVariables.pub_spC.Equals("PS")) // Viện phụ sản mặc định là nội trú
        {
            emrDmLoaiVaoVien.id = 0;
            emrDmLoaiVaoVien.ma = "1";
        }
        else
            if (!String.IsNullOrEmpty(item))
        {
            if (item.Equals("00031"))
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

    private emrDmLoaiRaVien getemrDmLoaiRaVien(string item)
    {
        emrDmLoaiRaVien emrDmLoaiRaVien = new emrDmLoaiRaVien();
        if (item != null)
            emrDmLoaiRaVien.ma = item;
        return emrDmLoaiRaVien;
    }

    private emrDmLoaiDoiTuongTaiChinh getemrDmLoaiDoiTuongTaiChinh(string item)
    {
        emrDmLoaiDoiTuongTaiChinh emrDmLoaiDoiTuongTaiChinh = new emrDmLoaiDoiTuongTaiChinh();
        if (item != null)
            emrDmLoaiDoiTuongTaiChinh.ma = item;
        return emrDmLoaiDoiTuongTaiChinh;
    }

    private emrDmLoaiChuyenVien getemrDmLoaiChuyenVien(string item)
    {
        emrDmLoaiChuyenVien emrDmLoaiChuyenVien = new emrDmLoaiChuyenVien();
        emrDmLoaiChuyenVien.ma = item;
        return emrDmLoaiChuyenVien;
    }

    private emrDmCoSoKhamBenh getemrDmCoSoKhamBenh(string item)
    {
        emrDmCoSoKhamBenh emrDmCoSoKhamBenh = new emrDmCoSoKhamBenh();
        emrDmCoSoKhamBenh.ma = item;
        return emrDmCoSoKhamBenh;
    }

    private emrHinhAnhTonThuong[] getemrHinhAnhTonThuongs(string maBA, string maLoaiBA, int IdDanhSachHSBA, string currentPathServer)
    {
        // Hiên tại chưa có hình ảnh tổn thương cho HIS
        List<emrHinhAnhTonThuong> list = new List<emrHinhAnhTonThuong>();

        //object[] paras =
        // {
        //};
        //var listItem = DbContext.Database.SqlQuery<tbl_emrHinhAnhTonThuongVM>("sp_Insert_tbl_emrHinhAnhTonThuong ", paras).ToList();

        //if (listItem != null)
        //    foreach (tbl_emrHinhAnhTonThuongVM item in listItem)
        //    {
        //        if (item != null)
        //        {
        //            if (item.anhtonthuong != null && item.motatonthuong != null)
        //            {
        //                emrHinhAnhTonThuong emrHinhAnhTonThuong = new DTT.HL7Core.emrHinhAnhTonThuong();
        //                emrHinhAnhTonThuong.anhtonthuong = item.anhtonthuong;
        //                emrHinhAnhTonThuong.motatonthuong = item.motatonthuong;

        //                emrHinhAnhTonThuong.emrQuanLyFileDinhKemHatts = getemrQuanLyFileDinhKemHatts(item, currentPathServer);
        //                list.Add(emrHinhAnhTonThuong);
        //            }
        //        }
        //    }
        return list.ToArray();
    }

    private emrQuanLyFileDinhKemHatt[] getemrQuanLyFileDinhKemHatts(tbl_emrHinhAnhTonThuongVM item, string currentPathServer)
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
        emrDmYhctCheDoChamSoc.ma = p;// "DM87");
        return emrDmYhctCheDoChamSoc;
    }

    private emrYhctBenhanVongChan getemrYhctBenhanVongChan(tbl_emrYhctBenhanVongChanVM item)
    {
        emrYhctBenhanVongChan emrYhctBenhanVongChan = new emrYhctBenhanVongChan();

        if (item != null)
        {
            emrYhctBenhanVongChan.lstthan = SapXepDESC(item.lstthan);//, "DM57");
            emrYhctBenhanVongChan.lstchatluoi = SapXepDESC(item.lstchatluoi);//, "DM60");
            emrYhctBenhanVongChan.lsthinhthai = SapXepDESC(item.lsthinhthai); //, "DM56");
            emrYhctBenhanVongChan.lstsac = SapXepDESC(item.lstsac);//, "DM58");
            emrYhctBenhanVongChan.lstsacluoi = SapXepDESC(item.lstsacluoi);//, "DM61");
            emrYhctBenhanVongChan.lstreuluoi = SapXepDESC(item.lstreuluoi);//, "DM62");
            emrYhctBenhanVongChan.lsttrach = SapXepDESC(item.lsttrach);//, "DM59");
            emrYhctBenhanVongChan.motavongchan = item.motavongchan;
        }
        return emrYhctBenhanVongChan;
    }

    private emrYhctBenhanVawnChan getemrYhctBenhanVawnChan(tbl_emrYhctBenhanVawnChanVM item)
    {
        emrYhctBenhanVawnChan emrYhctBenhanVawnChan = new emrYhctBenhanVawnChan();
        if (item != null)
        {
            emrYhctBenhanVawnChan.lstchatthaibenhly = SapXepDESC(item.lstchatthaibenhly);//, "DM67");
            emrYhctBenhanVawnChan.lsthoitho = SapXepDESC(item.lsthoitho);//, "DM64");
            emrYhctBenhanVawnChan.lstmuicothe = SapXepDESC(item.lstmuicothe);//, "DM66");
            emrYhctBenhanVawnChan.lsttiengho = SapXepDESC(item.lsttiengho);//, "DM65");
            emrYhctBenhanVawnChan.lsttiengnoi = SapXepDESC(item.lsttiengnoi);//, "DM63");
            emrYhctBenhanVawnChan.amthanhnac = CheckNullReturnTrueFalse(item.amthanhnac);
            emrYhctBenhanVawnChan.amthanho = CheckNullReturnTrueFalse(item.amthanho);
            emrYhctBenhanVawnChan.motavawnchan = item.motavawnchan;
        }
        return emrYhctBenhanVawnChan;
    }

    private emrYhctBenhanVaanChan getemrYhctBenhanVaanChan(tbl_emrYhctBenhanVaanChanVM item)
    {
        emrYhctBenhanVaanChan emrYhctBenhanVaanChan = new emrYhctBenhanVaanChan();
        if (item != null)
        {
            emrYhctBenhanVaanChan.lstan = SapXepDESC(item.lstan);//, "DM73");
            emrYhctBenhanVaanChan.lstbungnguc = SapXepDESC(item.lstbungnguc);//, "DM72");
            emrYhctBenhanVaanChan.lstdaitien = SapXepDESC(item.lstdaitien);//, "DM75");
            emrYhctBenhanVaanChan.lstdaumatco = SapXepDESC(item.lstdaumatco);//, "DM70");
            // format theo thứ tự tăng dần
            emrYhctBenhanVaanChan.lstdoiha = SapXepDESC(item.lstdoiha);//, "DM80");
            emrYhctBenhanVaanChan.lsthannhiet = SapXepDESC(item.lsthannhiet);//, "DM68");
            // mới thêm
            // fix code Theo DM90 fix luôn trong query thì ko phải fix:)

            //        2 = Han
            //1 = Nhiet
            //0 = Khac
            //3 = Binh THuong
            string lsthannhietbieuhien = string.Empty;
            if (item.lsthannhietbieuhien.HasValue)
            {
                if (item.lsthannhietbieuhien.Value == 0) // Khác
                {
                    lsthannhietbieuhien = "04";
                }
                else if (item.lsthannhietbieuhien.Value == 1) // Nhiet
                {
                    lsthannhietbieuhien = "03";
                }
                else if (item.lsthannhietbieuhien.Value == 2) // Han
                {
                    lsthannhietbieuhien = "02";
                }
                else if (item.lsthannhietbieuhien.Value == 3) // Bình thường
                {
                    lsthannhietbieuhien = "01";
                }
            }
            emrYhctBenhanVaanChan.lsthannhietbieuhien = lsthannhietbieuhien;
            emrYhctBenhanVaanChan.lstkinhnguyet = SapXepDESC(item.lstkinhnguyet); //, "DM78");
            emrYhctBenhanVaanChan.lstlung = SapXepDESC(item.lstlung);//, "DM71");
            emrYhctBenhanVaanChan.lstmohoi = SapXepDESC(item.lstmohoi);//, "DM69");
            // Truyền 3 không truyền 4
            emrYhctBenhanVaanChan.lstngu = SapXepDESC(item.lstngu);//, "DM77");
            emrYhctBenhanVaanChan.lstsinhduc = SapXepDESC(item.lstsinhduc); //, "DM81");
            emrYhctBenhanVaanChan.lstsinhducnu = SapXepDESC(item.lstsinhducnu);//, "DM91");
            emrYhctBenhanVaanChan.lstthongkinh = SapXepDESC(item.lstthongkinh);// "DM79");
            emrYhctBenhanVaanChan.lsttieutien = SapXepDESC(item.lsttieutien);// "DM76");
            emrYhctBenhanVaanChan.lstuong = SapXepDESC(item.lstuong);// "DM74");
            emrYhctBenhanVaanChan.motavaanchan = item.motavaanchan;
            emrYhctBenhanVaanChan.lstchantay = CheckNullReturnTrueFalse(item.lstchantay);
            // Điều kiện xuất hiện bệnh
            emrYhctBenhanVaanChan.dkxuatvien = CheckNullReturnTrueFalse(item.dkxuatvien);
        }
        return emrYhctBenhanVaanChan;
    }

    private emrYhctBenhanThietChan getemrYhctBenhanThietChan(tbl_emrYhctBenhanThietChanVM item)
    {
        emrYhctBenhanThietChan emrYhctBenhanThietChan = new emrYhctBenhanThietChan();

        if (item != null)
        {
            emrYhctBenhanThietChan.lstconhuc = item.lstconhuc; ;//, "DM83");
            emrYhctBenhanThietChan.lstmachchanQuanTayphai = SapXepDESC(item.lstmachchanQuanTayphai);//"DM85");
            emrYhctBenhanThietChan.lstmachchanQuanTaytrai = SapXepDESC(item.lstmachchanQuanTaytrai);// "DM85");
            emrYhctBenhanThietChan.lstmachchanThonTayphai = SapXepDESC(item.lstmachchanThonTayphai);//, "DM85");
            emrYhctBenhanThietChan.lstmachchanThonTaytrai = SapXepDESC(item.lstmachchanThonTaytrai);//, "DM85");
            emrYhctBenhanThietChan.lstmachchantongquat = SapXepDESC(item.lstmachchantongquat);//, "DM85");
            emrYhctBenhanThietChan.lstmachchanXichTayphai = SapXepDESC(item.lstmachchanXichTayphai);//, "DM85");
            emrYhctBenhanThietChan.lstmachchanXichTaytrai = SapXepDESC(item.lstmachchanXichTaytrai);//, "DM85");
            emrYhctBenhanThietChan.lstphucchan = SapXepDESC(item.lstphucchan);//, "DM84");
            emrYhctBenhanThietChan.lstxucchan = SapXepDESC(item.lstxucchan);//, "DM82");
            emrYhctBenhanThietChan.lstxucchanmohoi = SapXepDESC(item.lstxucchanmohoi);//, "DM89");
            // emrYhctBenhanThietChan.lstxucchanmohoi = ConvertChuoiStringID(item.lstxucchanmohoi, "DM89");
            emrYhctBenhanThietChan.motamachchanTayphai = item.motamachchanTayphai;
            emrYhctBenhanThietChan.motamachchanTaytrai = item.motamachchanTaytrai;
            emrYhctBenhanThietChan.motathietchan = item.motathietchan;
            emrYhctBenhanThietChan.motaxucchan = item.motaxucchan;
        }
        return emrYhctBenhanThietChan;
    }

    private emrVaoKhoa[] getemrVaoKhoas(List<tbl_emrVaoKhoaVM> listEmrVaoKhoa,
        List<tbl_emrDieuTriVM> listEmrDieuTri,
        List<tbl_emrChamSocVM> listEmrChamSoc,
        List<tbl_emrHoiChanVM> listEmrHoiChan,
        List<tbl_emrHoiDongHoiChanVM> listEmrHoiDongHoiChan,
        List<tbl_emrChucNangSongVM> listemrChucNangSong
        )
    {
        List<emrVaoKhoa> list = new List<emrVaoKhoa>();
        if (listEmrVaoKhoa != null)
            foreach (tbl_emrVaoKhoaVM item in listEmrVaoKhoa)
            {
                if (item != null)
                {
                    emrVaoKhoa emrVaoKhoa = new emrVaoKhoa();
                    // Hiện trạng không cần truyền thông tin này nữa
                    //if (!ShareVariables.pub_spC.Equals("YHCT"))
                    emrVaoKhoa.bacsidieutri = item.bacsidieutri;
                    emrVaoKhoa.emrDmKhoaDieuTri = getemrDmKhoaDieuTri(item);
                    emrVaoKhoa.giuong = item.giuong;
                    emrVaoKhoa.ngaygiovaokhoa = toDateFormat(item.ngaygiovaokhoa);
                    emrVaoKhoa.ngayketthucdieutri = toDateFormat(item.ngayketthucdieutri);
                    emrVaoKhoa.phong = item.phong;
                    // emrVaoKhoa.songaydieutri = item.songaydieutri.ToString();
                    // if (!ShareVariables.pub_spC.Equals("YHCT"))
                    emrVaoKhoa.tentruongkhoa = item.tentruongkhoa;
                    emrVaoKhoa.emrDieuTris = getemrDieuTris(item.STTKhoa.Value, listEmrDieuTri);
                    emrVaoKhoa.emrChamSocs = getemrChamSocs(listEmrChamSoc);
                    emrVaoKhoa.emrHoiChans = getemrHoiChans(listEmrHoiChan, listEmrHoiDongHoiChan);
                    emrVaoKhoa.emrChucNangSongs = getemrChucNangSongs(listemrChucNangSong);
                    list.Add(emrVaoKhoa);
                }
            }
        return list.ToArray();
    }

    private emrChucNangSong[] getemrChucNangSongs(List<tbl_emrChucNangSongVM> listemrChucNangSong)
    {
        List<emrChucNangSong> list = new List<emrChucNangSong>();


        //List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 3, IdDanhSachHSBA);
        if (listemrChucNangSong != null)
        //if (result != null)
        //{
        //    int SoPhieu = result.Count();
        //    for (int i = 0; i < result.Count; i++)
        {
            emrChucNangSong emrChucNangSong = new emrChucNangSong();
            emrChucNangSong.sophieu = "1";// result[i].ToString();
            emrChucNangSong.emrChucNangSongChiTiets = getemrChucNangSongChiTiets(listemrChucNangSong);
            list.Add(emrChucNangSong);
        }

        //}

        return list.ToArray();
    }

    private emrChucNangSongChiTiet[] getemrChucNangSongChiTiets(List<tbl_emrChucNangSongVM> listpara)
    {
        List<emrChucNangSongChiTiet> list = new List<emrChucNangSongChiTiet>();
        emrChucNangSongChiTiet emrChucNangSongChiTiet = new emrChucNangSongChiTiet();
        if (listpara != null)
        {
            foreach (tbl_emrChucNangSongVM item in listpara)
            {
                //if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa))
                //{
                //    if (item.SoPhieu == sophieu)
                //    {
                emrChucNangSongChiTiet.cannang = CheckNull(item.cannang);
                emrChucNangSongChiTiet.huyetapcao = returnHuyetApCaoThap(item.huyetapcao, 1);// 1 là cao 2 là thấp vì cái này data mình gộp chung 2 thông tin thành 1
                emrChucNangSongChiTiet.huyetapthap = returnHuyetApCaoThap(item.huyetapcao, 2);// 1 là cao 2
                emrChucNangSongChiTiet.mach = CheckNull(item.mach);
                emrChucNangSongChiTiet.ngaytheodoi = toDateFormat(item.ngaytheodoi);
                emrChucNangSongChiTiet.nhietdo = formatNhietDo(item.nhietdo);
                emrChucNangSongChiTiet.nhiptho = CheckNull(item.nhiptho);
                emrChucNangSongChiTiet.ytatheodoi = item.ytatheodoi;
                list.Add(emrChucNangSongChiTiet);
                //    }
                //}
            }
        }
        return list.ToArray();
    }

    private emrHoiChan[] getemrHoiChans(List<tbl_emrHoiChanVM> listEmrHoiChan, List<tbl_emrHoiDongHoiChanVM> listEmrHoiDongHoiChan)
    {
        List<emrHoiChan> list = new List<emrHoiChan>();



        if (listEmrHoiChan != null)
            foreach (tbl_emrHoiChanVM item in listEmrHoiChan)
            {
                if (item != null)
                {
                    emrHoiChan emrHoiChan = new emrHoiChan();
                    emrHoiChan.huongdieutri = item.huongdieutri;
                    emrHoiChan.ketluanhoichan = item.ketluanhoichan;
                    emrHoiChan.tomtatdienbien = item.tomtatdienbien;
                    emrHoiChan.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrHoiChan.emrHoiDongHoiChans = getemrHoiDongHoiChans(item.SttKhoa.Value, listEmrHoiDongHoiChan);
                    list.Add(emrHoiChan);
                }
            }
        return list.ToArray();
    }

    private emrHoiDongHoiChan[] getemrHoiDongHoiChans(int? sttKhoa, List<tbl_emrHoiDongHoiChanVM> listEmrHoiDongHoiChan)
    {
        List<emrHoiDongHoiChan> list = new List<emrHoiDongHoiChan>();
        if (sttKhoa.HasValue)
        {

            if (listEmrHoiDongHoiChan != null)
                foreach (tbl_emrHoiDongHoiChanVM item in listEmrHoiDongHoiChan)
                {
                    if (item != null && item.STT == sttKhoa)
                    {
                        emrHoiDongHoiChan emrHoiDongHoiChan = new emrHoiDongHoiChan();
                        emrHoiDongHoiChan.bacsihoichan = item.bacsihoichan;
                        emrHoiDongHoiChan.idvaitro = CheckNull(item.idvaitro);
                        list.Add(emrHoiDongHoiChan);
                    }
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

    private emrChamSoc[] getemrChamSocs(List<tbl_emrChamSocVM> listEmrChamSoc)
    {
        List<emrChamSoc> list = new List<emrChamSoc>();

        // List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 1, IdDanhSachHSBA);
        //if (result != null)
        //{
        //    int SoPhieu = result.Count();
        //    for (int i = 0; i < result.Count; i++)
        //    {
        emrChamSoc emrChamSoc = new emrChamSoc();
        emrChamSoc.sotochamsoc = "1";// result[i].ToString();
        emrChamSoc.emrQuaTrinhChamSocs = getemrQuaTrinhChamSocs(listEmrChamSoc);
        list.Add(emrChamSoc);
        //    }
        //}
        return list.ToArray();
    }

    private emrQuaTrinhChamSoc[] getemrQuaTrinhChamSocs(List<tbl_emrChamSocVM> listchamsoc)// Mấy object dạng này do DTT sai thiết kế hoặc ... có 1 item không phải nhiều item
    {
        List<emrQuaTrinhChamSoc> list = new List<emrQuaTrinhChamSoc>();

        foreach (tbl_emrChamSocVM item in listchamsoc)
        {
            //if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa.ToString()))
            //{
            //    if (item.sotochamsoc == SoTo)
            //    {
            emrQuaTrinhChamSoc emrQuaTrinhChamSoc = new emrQuaTrinhChamSoc();
            emrQuaTrinhChamSoc.ngaychamsoc = toDateFormat(item.ngaychamsoc);
            emrQuaTrinhChamSoc.theodoidienbien = item.theodoidienbien;
            emrQuaTrinhChamSoc.thuchienylenh = item.thuchienylenh;
            emrQuaTrinhChamSoc.ytachamsoc = item.ytachamsoc;
            list.Add(emrQuaTrinhChamSoc);
            //    }
            //}
        }
        return list.ToArray();
    }

    private emrDieuTri[] getemrDieuTris(int sttKhoa, List<tbl_emrDieuTriVM> listEmrDieuTri)
    {
        List<emrDieuTri> list = new List<emrDieuTri>();

        //  List<int> result = SoPhieuChamSoc(IdemrVaoKhoa, 2, IdDanhSachHSBA);
        //if (result != null)
        //{
        //    int SoPhieu = result.Count();
        //    for (int i = 0; i < result.Count; i++)
        //    {
        emrDieuTri emrDieuTri = new emrDieuTri();

        emrDieuTri.sotodieutri = "1";// result[i].ToString();
        emrDieuTri.emrQuaTrinhDieuTris = getemrQuaTrinhDieuTris(listEmrDieuTri, sttKhoa);
        list.Add(emrDieuTri);

        //    }

        //}

        return list.ToArray();
    }

    private emrQuaTrinhDieuTri[] getemrQuaTrinhDieuTris(List<tbl_emrDieuTriVM> listDieuTri, int sttKhoa)
    {
        List<emrQuaTrinhDieuTri> list = new List<emrQuaTrinhDieuTri>();

        foreach (tbl_emrDieuTriVM item in listDieuTri)
        {
            //if (item.IdemrVaoKhoa.ToString().Equals(IdemrVaoKhoa.ToString()))
            //{
            //    if (SoTo == item.sotodieutri)
            //    {
            emrQuaTrinhDieuTri emrQuaTrinhDieuTri = new emrQuaTrinhDieuTri();
            emrQuaTrinhDieuTri.bacsiraylenh = item.bacsiraylenh;
            emrQuaTrinhDieuTri.dienbien = item.dienbien;
            emrQuaTrinhDieuTri.ylenh = item.YLENH;
            emrQuaTrinhDieuTri.chamsoc = item.CheDoChamSoc;
            emrQuaTrinhDieuTri.ngaydieutri = toDateFormat(item.ngaydieutri);
            list.Add(emrQuaTrinhDieuTri);
            //    }
            //}
        }
        return list.ToArray();
    }

    private emrDmKhoaDieuTri getemrDmKhoaDieuTri(tbl_emrVaoKhoaVM item)
    {
        emrDmKhoaDieuTri emrDmKhoaDieuTri = new emrDmKhoaDieuTri();
        if (item != null)
        {
            emrDmKhoaDieuTri.ma = item.emrDmKhoaDieuTri + _DuoiMaKhoaHue; 
            emrDmKhoaDieuTri.ten = item.tenkhoa + _DuoiTenKhoaHue;
        }
        return emrDmKhoaDieuTri;
    }

    private emrDonThuoc[] getemrDonThuocs(List<tbl_emrDonThuocVM> listemrDonThuoc, List<tbl_emrDonThuocChiTietVM> listEmrDonThuocChiTiet)
    {
        List<emrDonThuoc> list = new List<emrDonThuoc>();

        int CountSoDon = 0;
        if (listemrDonThuoc != null)

            foreach (tbl_emrDonThuocVM item in listemrDonThuoc)
            {
                if (item != null)
                {
                    CountSoDon++;
                    emrDonThuoc emrDonThuoc = new emrDonThuoc();
                    emrDonThuoc.bacsikedon = item.bacsikedon;
                    emrDonThuoc.ngaykedon = toDateFormat(item.ngaykedon);
                    //  emrDonThuoc.sodon = CheckNull(item.sodon);
                    emrDonThuoc.sodon = CountSoDon.ToString();// Cái này chính là đơn thuốc số : xxx
                    emrDonThuoc.emrDonThuocChiTiets = getemrDonThuocChiTiets(item.IdemrDonThuoc??0, listEmrDonThuocChiTiet);
                    list.Add(emrDonThuoc);
                }
            }
        return list.ToArray();
    }

    private emrDonThuocChiTiet[] getemrDonThuocChiTiets(int IdemrDonThuoc, List<tbl_emrDonThuocChiTietVM> listEmrDonThuocChiTiet)
    {
        List<emrDonThuocChiTiet> list = new List<emrDonThuocChiTiet>();

        if (listEmrDonThuocChiTiet != null)
            foreach (tbl_emrDonThuocChiTietVM item in listEmrDonThuocChiTiet)
            {
                if (item != null && item.IdemrDonThuoc == IdemrDonThuoc)
                {
                    emrDonThuocChiTiet emrDonThuocChiTiet = new emrDonThuocChiTiet();
                    emrDonThuocChiTiet.chidandungthuoc = CheckNull(item.chidandungthuoc);
                    emrDonThuocChiTiet.emrDmDuongDungThuoc = getemrDmDuongDungThuoc(item.emrDmDuongDungThuoc);
                    emrDonThuocChiTiet.emrDmTanXuatDungThuoc = getemrDmTanXuatDungThuoc(item.emrDmTanXuatDungThuoc);
                    emrDonThuocChiTiet.emrDmThuoc = getemrDmThuoc(item.emrDmThuoc);
                    emrDonThuocChiTiet.lieuluongdung = item.lieuluongdung;
                    emrDonThuocChiTiet.bietduoc = CheckNull(item.bietduoc);
                    emrDonThuocChiTiet.ngaybatdau = toDateFormat(item.ngaybatdau);
                    emrDonThuocChiTiet.ngayketthuc = toDateFormat(item.ngayketthuc);
                    list.Add(emrDonThuocChiTiet);
                }
            }
        return list.ToArray();
    }

    private emrDmThuoc getemrDmThuoc(string item)
    {
        emrDmThuoc emrDmThuoc = new emrDmThuoc();
        emrDmThuoc.ma = item;
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

    private emrGiaiPhauBenh[] getemrGiaiPhauBenhs(List<tbl_emrGiaiPhauBenhVM> listEmrGiaiPhauBenh)
    {
        List<emrGiaiPhauBenh> list = new List<emrGiaiPhauBenh>();

        if (listEmrGiaiPhauBenh != null)
            foreach (tbl_emrGiaiPhauBenhVM item in listEmrGiaiPhauBenh)
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

    private emrDmViTriLayMau getemrDmViTriLayMau(tbl_emrGiaiPhauBenhVM item)
    {
        emrDmViTriLayMau emrDmViTriLayMau = new emrDmViTriLayMau();
        emrDmViTriLayMau.ma = item.emrDmViTriLayMau;
        return emrDmViTriLayMau;
    }

    private emrDmLoaiGiaiPhauBenh getemrDmLoaiGiaiPhauBenh(tbl_emrGiaiPhauBenhVM item)
    {
        emrDmLoaiGiaiPhauBenh emrDmLoaiGiaiPhauBenh = new emrDmLoaiGiaiPhauBenh();
        emrDmLoaiGiaiPhauBenh.ma = item.emrDmLoaiGiaiPhauBenh;
        return emrDmLoaiGiaiPhauBenh;
    }

    private emrDmKetQuaGiaiPhauBenh getemrDmKetQuaGiaiPhauBenh(tbl_emrGiaiPhauBenhVM item)
    {
        emrDmKetQuaGiaiPhauBenh emrDmKetQuaGiaiPhauBenh = new emrDmKetQuaGiaiPhauBenh();
        emrDmKetQuaGiaiPhauBenh.ma = item.emrDmKetQuaGiaiPhauBenh;
        return emrDmKetQuaGiaiPhauBenh;
    }

    private emrDmGiaiPhauBenh getemrDmGiaiPhauBenh(tbl_emrGiaiPhauBenhVM item)
    {
        emrDmGiaiPhauBenh emrDmGiaiPhauBenh = new emrDmGiaiPhauBenh();
        emrDmGiaiPhauBenh.ma = item.emrDmGiaiPhauBenh;
        return emrDmGiaiPhauBenh;
    }

    private emrThamDoChucNang[] getemrThamDoChucNangs(List<tbl_emrThamDoChucNangVM> listThamDoChucNang, List<tbl_emrQuanLyFileDinhKemVM> listFileThamDoCN, List<tbl_emrQuanLyFileDinhKemTdcnVM> listSaveFileThamDoChucNang, string currentPathServer)
    {
        List<emrThamDoChucNang> list = new List<emrThamDoChucNang>();


        if (listThamDoChucNang != null)
            foreach (tbl_emrThamDoChucNangVM item in listThamDoChucNang)
            {
                if (item != null)
                {
                    emrThamDoChucNang emrThamDoChucNang = new emrThamDoChucNang();
                    emrThamDoChucNang.bacsichuyenkhoa = item.bacsichuyenkhoa;
                    emrThamDoChucNang.bacsiyeucau = item.bacsiyeucau;
                    emrThamDoChucNang.emrDmThamDoChucNang = getemrDmThamDoChucNang(item.emrDmThamDoChucNang);
                    emrThamDoChucNang.ketluan = item.ketluan;
                    if (item.LoaiKQ.HasValue && item.LoaiKQ != 5)
                        emrThamDoChucNang.ketqua = item.ketqua;
                    emrThamDoChucNang.loidan = item.loidan;
                    emrThamDoChucNang.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrThamDoChucNang.ngayyeucau = toDateFormat(item.ngayyeucau);
                    emrThamDoChucNang.emrDmLoaiThamDoChucNang = getemrDmLoaiThamDoChucNang(item.emrDmLoaiThamDoChucNang);
                    int STT = 0;
                    if (item.STT != null)
                        STT = int.Parse(item.STT.ToString());
                    // cần tối ưu lại sau
                    emrThamDoChucNang.emrQuanLyFileDinhKemTdcns = getemrQuanLyFileDinhKemTdcns(listFileThamDoCN, listSaveFileThamDoChucNang, item.STT.Value, currentPathServer);
                    emrThamDoChucNang.noidungyeucau = item.noidungyeucau;
                    list.Add(emrThamDoChucNang);
                }
            }
        return list.ToArray();
    }

    private emrDmLoaiThamDoChucNang getemrDmLoaiThamDoChucNang(string maLoaiThamDoChucNang)
    {
        emrDmLoaiThamDoChucNang emrDmLoaiThamDoChucNang = new emrDmLoaiThamDoChucNang();
        emrDmLoaiThamDoChucNang.ma = maLoaiThamDoChucNang;
        return emrDmLoaiThamDoChucNang;
    }

    private emrQuanLyFileDinhKemTdcn[] getemrQuanLyFileDinhKemTdcns(List<tbl_emrQuanLyFileDinhKemVM> listFileDinhKemThamDoChucNang, List<tbl_emrQuanLyFileDinhKemTdcnVM> listSaveFileThamDoChucNang, int sTT, string currentPathServer)// Thăm dò chức năng loại =4
    {
        List<emrQuanLyFileDinhKemTdcn> list = new List<emrQuanLyFileDinhKemTdcn>();
        emrQuanLyFileDinhKemTdcn emrQuanLyFileDinhKemTdcn = new emrQuanLyFileDinhKemTdcn();
        foreach (var item in listFileDinhKemThamDoChucNang)
        {
            if (item != null && item.STT == sTT)
            {
                emrQuanLyFileDinhKemTdcn.tenfile = ConvertVN(formatTenFile(item.TenFile));
                // emrQuanLyFileDinhKemTdcn.tenfile = (item[0].tenfile);
                emrQuanLyFileDinhKemTdcn.noiDungFile = GetData(item.DuongDan);// check lại
                list.Add(emrQuanLyFileDinhKemTdcn);
            }
        }
        foreach (var item in listSaveFileThamDoChucNang)
        {
            if (item.STT == sTT)
            {
                string tenfile = SaveFileTDCN(item, currentPathServer);
                if (!string.IsNullOrEmpty(tenfile))
                {
                    emrQuanLyFileDinhKemTdcn.tenfile = ConvertVN(tenfile);
                    emrQuanLyFileDinhKemTdcn.noiDungFile = convertBase64ByFile(currentPathServer + tenfile);
                    list.Add(emrQuanLyFileDinhKemTdcn);
                }
            }

        }


        return list.ToArray();
    }

    private emrDmThamDoChucNang getemrDmThamDoChucNang(string item)
    {
        emrDmThamDoChucNang emrDmThamDoChucNang = new emrDmThamDoChucNang();
        emrDmThamDoChucNang.ma = item;
        return emrDmThamDoChucNang;
    }

    private emrChanDoanHinhAnh[] getemrChanDoanHinhAnhs(List<tbl_emrChanDoanHinhAnhVM> list, List<tbl_emrQuanLyFileDinhKemVM> listFieChanDoanHinhAnh, List<tbl_emrQuanLyFileDinhKemCdhaVM> listSaveFileChanDoanHinhAnh, string currentPathServer)
    {
        List<emrChanDoanHinhAnh> listemrChanDoanHinhAnh = new List<emrChanDoanHinhAnh>();
        if (list != null)
            foreach (tbl_emrChanDoanHinhAnhVM item in list)
            {
                if (item != null)
                {
                    emrChanDoanHinhAnh emrChanDoanHinhAnh = new emrChanDoanHinhAnh();
                    // Bác sỹ chuyên khoa =bác sỹ thực hiện =BSKham benhan_c "Nội trú" KhamBenh_c "Ngoại Trú"
                    emrChanDoanHinhAnh.bacsichuyenkhoa = item.bacsichuyenkhoa;
                    emrChanDoanHinhAnh.bacsiyeucau = item.bacsiyeucau;
                    emrChanDoanHinhAnh.emrDmChanDoanHinhAnh = getemrDmChanDoanHinhAnh(item.emrDmChanDoanHinhAnh);
                    emrChanDoanHinhAnh.emrDmLoaiChanDoanHinhAnh = getemrDmLoaiChanDoanHinhAnh(item.emrDmLoaiChanDoanHinhAnh);
                    emrChanDoanHinhAnh.ketluan = item.ketluan;
                    if (item.LoaiKQ != null && item.LoaiKQ != 5)
                        emrChanDoanHinhAnh.ketqua = item.ketqua;
                    emrChanDoanHinhAnh.loidan = item.loidan;
                    emrChanDoanHinhAnh.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrChanDoanHinhAnh.ngayyeucau = toDateFormat(item.ngayyeucau);
                    if (!string.IsNullOrEmpty(item.STT.ToString()))
                        emrChanDoanHinhAnh.emrQuanLyFileDinhKemCdha = getemrQuanLyFileDinhKemCdha(listFieChanDoanHinhAnh, listSaveFileChanDoanHinhAnh, item.STT.Value, currentPathServer);
                    listemrChanDoanHinhAnh.Add(emrChanDoanHinhAnh);
                }
            }
        return listemrChanDoanHinhAnh.ToArray();
    }

    private emrQuanLyFileDinhKemCdha[] getemrQuanLyFileDinhKemCdha(List<tbl_emrQuanLyFileDinhKemVM> listFieChanDoanHinhAnh, List<tbl_emrQuanLyFileDinhKemCdhaVM> listSaveFileChanDoanHinhAnh, int sTT, string currentPathServer)// Chẩn đoán hình ảnh loại =5
    {
        List<emrQuanLyFileDinhKemCdha> listemrQuanLyFileDinhKemCdha = new List<emrQuanLyFileDinhKemCdha>();
        string tenfile = string.Empty;
        foreach (var item in listSaveFileChanDoanHinhAnh)
        {
            tenfile = SaveFileCDHA(item, sTT, currentPathServer);
        }

        emrQuanLyFileDinhKemCdha emrQuanLyFileDinhKemCdha = new emrQuanLyFileDinhKemCdha();
        emrQuanLyFileDinhKemCdha emrQuanLyFileDinhKemCdha2 = new emrQuanLyFileDinhKemCdha();
        foreach (var item in listFieChanDoanHinhAnh)
        {
            if (item != null)
            {
                emrQuanLyFileDinhKemCdha2.tenfile = ConvertVN(formatTenFile(item.TenFile));
                // emrQuanLyFileDinhKemCdha2.tenfile = (item[0].tenfile);
                emrQuanLyFileDinhKemCdha2.noiDungFile = GetData(item.DuongDan);
                listemrQuanLyFileDinhKemCdha.Add(emrQuanLyFileDinhKemCdha2);
            }
        }

        if (!string.IsNullOrEmpty(tenfile))
        {
            emrQuanLyFileDinhKemCdha.tenfile = ConvertVN(tenfile);
            emrQuanLyFileDinhKemCdha.noiDungFile = convertBase64ByFile(currentPathServer + tenfile);
            //  emrQuanLyFileDinhKemCdha.noiDungFile = convertBase64ByFile(Server.MapPath((tenfile)));
            listemrQuanLyFileDinhKemCdha.Add(emrQuanLyFileDinhKemCdha);
        }
        return listemrQuanLyFileDinhKemCdha.ToArray();
    }

    private emrDmLoaiChanDoanHinhAnh getemrDmLoaiChanDoanHinhAnh(string item)
    {
        emrDmLoaiChanDoanHinhAnh emrDmLoaiChanDoanHinhAnh = new emrDmLoaiChanDoanHinhAnh();
        if (item != null)
            emrDmLoaiChanDoanHinhAnh.ma = item;
        return emrDmLoaiChanDoanHinhAnh;
    }

    private emrDmChanDoanHinhAnh getemrDmChanDoanHinhAnh(string item)
    {
        emrDmChanDoanHinhAnh emrDmChanDoanHinhAnh = new emrDmChanDoanHinhAnh();
        if (item != null)
            emrDmChanDoanHinhAnh.ma = item;
        return emrDmChanDoanHinhAnh;
    }

    private emrChanDoan getemrChanDoan(tbl_emrChanDoanVM itemEmrChanDoan)
    {
        emrChanDoan emrChanDoan = new emrChanDoan();

        if (itemEmrChanDoan != null)
        {
            emrChanDoan.bibienchung = CheckNullReturnTrueFalse(itemEmrChanDoan.bibienchung);
            emrChanDoan.bitaibien = CheckNullReturnTrueFalse(itemEmrChanDoan.bitaibien);
            emrChanDoan.emrDmLyDoTaiBienBienChung = getemrDmLyDoTaiBienBienChung(itemEmrChanDoan.emrDmLyDoTaiBienBienChung);
            emrChanDoan.emrDmMaBenhByIdicdChandoandieutri = getemrDmMaBenhByIdicdChandoandieutri(itemEmrChanDoan.emrDmMaBenhByIdicdChandoandieutri);
            emrChanDoan.emrDmMaBenhByIdicdChandoankkb = getemrDmMaBenhByIdicdChandoankkb(itemEmrChanDoan.emrDmMaBenhByIdicdChandoankkb);
            emrChanDoan.emrDmMaBenhByIdicdChandoannoiden = getemrDmMaBenhByIdicdChandoannoiden(itemEmrChanDoan.emrDmMaBenhByIdicdChandoannoiden);
            emrChanDoan.emrDmMaBenhByIdicdChandoanravienchinh = getemrDmMaBenhByIdicdChandoanravienchinh(itemEmrChanDoan.emrDmMaBenhByIdicdChandoanravienchinh);
            emrChanDoan.emrDmMaBenhByIdicdChandoanravienkemtheo = getemrDmMaBenhByIdicdChandoanravienkemtheo(itemEmrChanDoan.emrDmMaBenhByIdicdChandoanravienkemtheo);
            emrChanDoan.emrDmMaBenhByIdicdChandoanraviennguyennhan = getemrDmMaBenhByIdicdChandoanraviennguyennhan(itemEmrChanDoan.emrDmMaBenhByIdicdChandoanraviennguyennhan);
            emrChanDoan.emrDmMaBenhByIdicdChandoansaupt = getemrDmMaBenhByIdicdChandoansaupt(itemEmrChanDoan.emrDmMaBenhByIdicdChandoansaupt);
            emrChanDoan.emrDmMaBenhByIdicdChandoantruocpt = getemrDmMaBenhByIdicdChandoantruocpt(itemEmrChanDoan.emrDmMaBenhByIdicdChandoantruocpt);
            emrChanDoan.motachandoandieutri = itemEmrChanDoan.motachandoandieutri;
            emrChanDoan.motachandoankkb = itemEmrChanDoan.motachandoankkb;
            emrChanDoan.motachandoannoiden = itemEmrChanDoan.motachandoannoiden;
            emrChanDoan.motachandoanravienchinh = itemEmrChanDoan.motachandoanravienchinh;
            emrChanDoan.motachandoanravienkemtheo = itemEmrChanDoan.motachandoanravienkemtheo;
            emrChanDoan.motachandoanraviennguyennhan = itemEmrChanDoan.motachandoanraviennguyennhan;
            emrChanDoan.motachandoansaupt = itemEmrChanDoan.motachandoansaupt;
            emrChanDoan.motachandoantruocpt = itemEmrChanDoan.motachandoantruocpt;
            emrChanDoan.tongsolanpt = CheckNull(itemEmrChanDoan.tongsolanpt);
            emrChanDoan.tongsongaysaupt = CheckNull(itemEmrChanDoan.tongsongaysaupt);
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
            emrDmLyDoTaiBienBienChung.ma = item;
        return emrDmLyDoTaiBienBienChung;
    }

    private emrXetNghiem[] getemrXetNghiems(List<tbl_emrXetNghiemVM> listXetNghiem,
        List<tbl_emrXetNghiemDichVuVM> listXetNghiemDichVu,
        List<tbl_emrXetNghiemKetQuaVM> listXetNghiemKetQua,
        List<tbl_emrQuanLyFileDinhKemVM> listFileDinhKemXetNghiem, List<tbl_emrQuanLyFileDinhKemXnVM> listEmrQuanLySaveFileDinhKemXN, string currentPathServer
        )
    {
        List<emrXetNghiem> listItem = new List<emrXetNghiem>();

        int i = 0;
        if (listXetNghiem != null)
            foreach (tbl_emrXetNghiemVM item in listXetNghiem)
            {
                if (item != null)
                {
                    i++;// Test
                    emrXetNghiem emrXetNghiem = new emrXetNghiem();
                    emrXetNghiem.bacsixetnghiem = item.bacsixetnghiem;
                    emrXetNghiem.bacsiyeucau = item.bacsiyeucau;
                    emrXetNghiem.emrDmLoaiXetNghiem = getemrDmLoaiXetNghiem(item.emrDmLoaiXetNghiem);
                    emrXetNghiem.ngaythuchien = toDateFormat(item.ngaythuchien);
                    emrXetNghiem.ngayyeucau = toDateFormat(item.ngayyeucau);
                    emrXetNghiem.nhanxet = item.nhanxet;
                    int STT = 0;
                    if (item.STT != null)
                        STT = int.Parse(item.STT.ToString());
                    if (listFileDinhKemXetNghiem.Count > 0 && listEmrQuanLySaveFileDinhKemXN.Count > 0)
                        emrXetNghiem.emrQuanLyFileDinhKemXn = getemrQuanLyFileDinhKemXn(item.IdemrXetNghiem??0, listFileDinhKemXetNghiem, listEmrQuanLySaveFileDinhKemXN, currentPathServer);
                    emrXetNghiem.noidungyeucau = item.noidungyeucau;
                    if (listXetNghiemDichVu.Count > 0)
                        emrXetNghiem.emrXetNghiemDichVus = getemrXetNghiemDichVus(item.IdemrXetNghiem??0, listXetNghiemDichVu, listXetNghiemKetQua);
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

    private string SaveFileXNKQ(int IdemrXetNghiem, List<tbl_emrQuanLyFileDinhKemXnVM> listEmrQuanLySaveFileDinhKemXN, string currentPathServer)
    {
        string tenfile = string.Empty;
        foreach (var itemFileXN in listEmrQuanLySaveFileDinhKemXN)
        {
            if (itemFileXN != null && itemFileXN.IdemrXetNghiem == IdemrXetNghiem)
            {
                tenfile += formatTenFile(itemFileXN.tenfile);
            }

            // tenfile += (itemFileXN[0].tenfile);
            if (!string.IsNullOrEmpty(tenfile))
            {
                if (File.Exists(currentPathServer + (tenfile)))
                {
                    File.Delete(currentPathServer + (tenfile));
                    StreamWriter file = new StreamWriter(currentPathServer + (tenfile), true, Encoding.UTF8);
                    file.Write(itemFileXN.noiDungFile);
                    file.Close();
                }
            }
        }


        return tenfile;
    }

    private string SaveFileCDHA(tbl_emrQuanLyFileDinhKemCdhaVM itemFileXN, int sTT, string currentPathServer)
    {

        string tenfile = string.Empty;
        if (itemFileXN != null)
            tenfile += formatTenFile(itemFileXN.tenfile);
        //tenfile += (itemFileXN[0].tenfile);
        foreach (string itemFile in Directory.GetFiles(currentPathServer))
        {
            if (!string.IsNullOrEmpty(tenfile))
            {
                if (tenfile.Equals(itemFile))
                    File.Delete(currentPathServer + (tenfile));
                StreamWriter file = new StreamWriter(currentPathServer + (tenfile), true, Encoding.UTF8);
                file.Write(itemFileXN.noidung);
                file.Close();
                break;
            }
        }

        return tenfile;
    }

    private string SaveFileTDCN(tbl_emrQuanLyFileDinhKemTdcnVM itemFileXN, string currentPathServer)
    {
        string tenfile = string.Empty;
        tenfile += formatTenFile(itemFileXN.tenfile);
        //tenfile += (itemFileXN[0].tenfile);
        if (!string.IsNullOrEmpty(tenfile))
        {
            if (File.Exists(currentPathServer + (tenfile)))
                File.Delete(currentPathServer + (tenfile));
            StreamWriter file = new StreamWriter(currentPathServer + (tenfile), true, Encoding.UTF8);
            file.Write(itemFileXN.noidung);
            file.Close();
        }

        return tenfile;
    }

    private emrQuanLyFileDinhKemXn[] getemrQuanLyFileDinhKemXn(int IdemrXetNghiem, List<tbl_emrQuanLyFileDinhKemVM> listFileDinhKemXetNghiem, List<tbl_emrQuanLyFileDinhKemXnVM> listEmrQuanLySaveFileDinhKemXN, string currentPathServer)// Xét nghiệm loại =1
    {
        List<emrQuanLyFileDinhKemXn> list = new List<emrQuanLyFileDinhKemXn>();
        emrQuanLyFileDinhKemXn emrQuanLyFileDinhKemXn = new emrQuanLyFileDinhKemXn();
        string tenFilePath = SaveFileXNKQ(IdemrXetNghiem, listEmrQuanLySaveFileDinhKemXN, currentPathServer);
        emrQuanLyFileDinhKemXn emrQuanLyFileDinhKemXn2 = new emrQuanLyFileDinhKemXn();
        foreach (var item in listEmrQuanLySaveFileDinhKemXN)
        {
            if (item != null && item.IdemrXetNghiem == IdemrXetNghiem)
            {
                emrQuanLyFileDinhKemXn2.tenfile = ConvertVN(item.tenfile);
                emrQuanLyFileDinhKemXn2.noiDungFile = GetData(item.duongdan);
                list.Add(emrQuanLyFileDinhKemXn2);
            }
        }


        if (!string.IsNullOrEmpty(tenFilePath))
        {
            emrQuanLyFileDinhKemXn.tenfile = ConvertVN(tenFilePath);
            emrQuanLyFileDinhKemXn.noiDungFile = convertBase64ByFile(currentPathServer + (formatTenFile(tenFilePath)));
            //emrQuanLyFileDinhKemXn.noiDungFile = convertBase64ByFile(Server.MapPath((tenFilePath)));
            list.Add(emrQuanLyFileDinhKemXn);
        }

        return list.ToArray();
    }

    private emrXetNghiemDichVu[] getemrXetNghiemDichVus(int IdemrXetNghiem, List<tbl_emrXetNghiemDichVuVM> listEmrXetNghiemDichVuVM, List<tbl_emrXetNghiemKetQuaVM> listEmrXetNghiemKetQua)
    {
        List<emrXetNghiemDichVu> listItem = new List<emrXetNghiemDichVu>();
        if (listEmrXetNghiemDichVuVM != null)
            foreach (tbl_emrXetNghiemDichVuVM item in listEmrXetNghiemDichVuVM)
            {
                if (item != null && item.IdemrXetNghiem == IdemrXetNghiem)
                {
                    emrXetNghiemDichVu emrXetNghiemDichVu = new emrXetNghiemDichVu();
                    emrDmXetNghiem emrDmXetNghiem = new emrDmXetNghiem();

                    emrXetNghiemDichVu.emrDmXetNghiem = getemrDmXetNghiem(item.emrDmXetNghiem);
                    emrXetNghiemDichVu.emrXetNghiemKetQuas = getemrXetNghiemKetQuas(item.IdemrXetNghiemDichVu.Value, listEmrXetNghiemKetQua);
                    listItem.Add(emrXetNghiemDichVu);
                }
            }
        return listItem.ToArray();
    }

    private emrXetNghiemKetQua[] getemrXetNghiemKetQuas(int IdemrXetNghiemDichVu, List<tbl_emrXetNghiemKetQuaVM> listEmrXetNghiemKetQua)
    {
        List<emrXetNghiemKetQua> listemrXetNghiemKetQua = new List<emrXetNghiemKetQua>();

        if (listEmrXetNghiemKetQua != null)
            foreach (tbl_emrXetNghiemKetQuaVM item in listEmrXetNghiemKetQua)
            {
                if (item != null && item.IdemrXetNghiemDichVu == IdemrXetNghiemDichVu)
                {
                    emrXetNghiemKetQua emrXetNghiemKetQua = new emrXetNghiemKetQua();
                    emrXetNghiemKetQua.emrDmChiSoXetNghiem = getemrDmChiSoXetNghiem(item.emrDmChiSoXetNghiem);
                    emrXetNghiemKetQua.emrDmDichKetQuaXetNghiem = getemrDmDichKetQuaXetNghiem(item.emrDmDichKetQuaXetNghiem);
                    emrXetNghiemKetQua.giatrido = item.giatrido;
                    listemrXetNghiemKetQua.Add(emrXetNghiemKetQua);
                }
            }

        return listemrXetNghiemKetQua.ToArray();
    }

    private emrDmDichKetQuaXetNghiem getemrDmDichKetQuaXetNghiem(string item)
    {
        emrDmDichKetQuaXetNghiem emrDmDichKetQuaXetNghiem = new emrDmDichKetQuaXetNghiem();
        if (item != null)
            emrDmDichKetQuaXetNghiem.ma = item;
        return emrDmDichKetQuaXetNghiem;
    }

    private emrDmChiSoXetNghiem getemrDmChiSoXetNghiem(string item)
    {
        emrDmChiSoXetNghiem emrDmChiSoXetNghiem = new emrDmChiSoXetNghiem();
        if (item != null)
            emrDmChiSoXetNghiem.ma = item;
        return emrDmChiSoXetNghiem;
    }

    private emrDmXetNghiem getemrDmXetNghiem(string item)
    {
        emrDmXetNghiem emrDmXetNghiem = new emrDmXetNghiem();
        if (item != null)
            emrDmXetNghiem.ma = item;
        return emrDmXetNghiem;
    }

    private emrDmLoaiXetNghiem getemrDmLoaiXetNghiem(string item)
    {
        emrDmLoaiXetNghiem emrDmLoaiXetNghiem = new emrDmLoaiXetNghiem();
        if (item != null)
            emrDmLoaiXetNghiem.ma = item;
        return emrDmLoaiXetNghiem;
    }

    private emrPhauThuatThuThuat[] getemrPhauThuatThuThuats(List<tbl_emrPhauThuatThuThuatVM> listPhauThuat, List<tbl_emrHoiDongPtttsVM> listHoiDong)
    {
        List<emrPhauThuatThuThuat> list = new List<emrPhauThuatThuThuat>();


        if (listPhauThuat != null)
            foreach (tbl_emrPhauThuatThuThuatVM item in listPhauThuat)
            {
                if (item != null)
                {
                    emrPhauThuatThuThuat emrPhauThuatThuThuat = new emrPhauThuatThuThuat();
                    emrPhauThuatThuThuat.bacsithuchien = item.bacsithuchien;
                    emrPhauThuatThuThuat.bacsygayme = item.bacsygayme;
                    emrPhauThuatThuThuat.chidinhptt = item.chidinhptt;
                    emrPhauThuatThuThuat.emrDmMaBenhByIdicdchandoansau = getemrDmMaBenhByIdicdchandoansau(item.emrDmMaBenhByIdicdchandoansau);
                    emrPhauThuatThuThuat.emrDmMaBenhByIdicdchandoantruoc = getemrDmMaBenhByIdicdchandoantruoc(item.emrDmMaBenhByIdicdchandoantruoc);
                    emrPhauThuatThuThuat.emrDmPhauThuThuat = getemrDmPhauThuThuat(item.emrDmPhauThuThuat);
                    emrPhauThuatThuThuat.luocdoptt = item.luocdoptt;
                    emrPhauThuatThuThuat.motachandoansaupt = item.motachandoansaupt;
                    emrPhauThuatThuThuat.motachandoantruocpt = item.motachandoantruocpt;
                    emrPhauThuatThuThuat.ngaygiopttt = toDateFormat(item.ngaygiopttt);
                    emrPhauThuatThuThuat.phuongphapvocam = item.phuongphapvocam;
                    emrPhauThuatThuThuat.trinhtuptt = item.trinhtuptt;
                    // Tạm thời rào code lại DTT chưa deploy object này cho Huế và YHCT
                    emrPhauThuatThuThuat.loaiMo = CheckNull(item.loaimo_chklist);
                    // emrPhauThuatThuThuat.loaiMo = "1";// CheckNull(item.loaimo_chklist);
                    emrPhauThuatThuThuat.emrHoiDongPttts = getemrHoiDongPttts(listHoiDong, item.IdemrPhauThuatThuThuat);
                    list.Add(emrPhauThuatThuThuat);
                }
            }
        return list.ToArray();
    }

    private emrHoiDongPttt[] getemrHoiDongPttts(List<tbl_emrHoiDongPtttsVM> listHoiDong, int? IdemrPhauThuatThuThuat)
    {
        List<emrHoiDongPttt> list = new List<emrHoiDongPttt>();


        if (listHoiDong != null)
            foreach (tbl_emrHoiDongPtttsVM item in listHoiDong)
            {
                if (item != null && item.IdemrPhauThuatThuThuat == IdemrPhauThuatThuThuat)
                {
                    emrHoiDongPttt emrHoiDongPttt = new emrHoiDongPttt();
                    emrHoiDongPttt.idvaitro = CheckNull(item.idvaitro);
                    emrHoiDongPttt.tenbacsi = item.tenbacsi;
                    list.Add(emrHoiDongPttt);
                }
            }
        return list.ToArray();
    }

    private emrDmPhauThuThuat getemrDmPhauThuThuat(string item)
    {
        emrDmPhauThuThuat emrDmPhauThuThuat = new emrDmPhauThuThuat();
        if (item != null)
            emrDmPhauThuThuat.ma = item;
        return emrDmPhauThuThuat;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdchandoantruoc(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrDmMaBenh getemrDmMaBenhByIdicdchandoansau(string item)
    {
        emrDmMaBenh emrDmMaBenh = new emrDmMaBenh();
        if (item != null)
            emrDmMaBenh.ma = item;
        return emrDmMaBenh;
    }

    private emrTongKetRaVien getemrTongKetRaVien(tbl_emrTongKetRaVienVM item, tbl_emrCkPhuongPhapDieuTriUngBuouVM dieuTriUngBuou, tbl_emrCkTinhTrangRaVienMatVM raVienMat)
    {
        emrTongKetRaVien emrTongKetRaVien = new emrTongKetRaVien();

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
            emrTongKetRaVien.emrCkPhuongPhapDieuTriUngBuou = getemrCkPhuongPhapDieuTriUngBuou(dieuTriUngBuou);
            if (ShareVariables.pub_spC.Equals("HU"))
                emrTongKetRaVien.emrCkTinhTrangRaVienMat = getemrCkTinhTrangRaVienMat(raVienMat);
        }
        return emrTongKetRaVien;
    }

    private emrCkTinhTrangRaVienMat getemrCkTinhTrangRaVienMat(tbl_emrCkTinhTrangRaVienMatVM raVienMat)
    {
        emrCkTinhTrangRaVienMat emrCkTinhTrangRaVienMat = new emrCkTinhTrangRaVienMat();

        if (raVienMat != null)
        {
            emrCkTinhTrangRaVienMat.nhanapphai = raVienMat.nhanapphai;
            emrCkTinhTrangRaVienMat.nhanaptrai = raVienMat.nhanaptrai;
            emrCkTinhTrangRaVienMat.thiluccokinhphai = raVienMat.thiluccokinhphai;
            emrCkTinhTrangRaVienMat.thiluccokinhtrai = raVienMat.thiluccokinhtrai;
            emrCkTinhTrangRaVienMat.thiluckhongkinhphai = raVienMat.thiluckhongkinhphai;
            emrCkTinhTrangRaVienMat.thiluckhongkinhtrai = raVienMat.thiluckhongkinhtrai;
        }

        return emrCkTinhTrangRaVienMat;
    }

    private emrCkPhuongPhapDieuTriUngBuou getemrCkPhuongPhapDieuTriUngBuou(tbl_emrCkPhuongPhapDieuTriUngBuouVM dieuTriUngBuou)
    {
        emrCkPhuongPhapDieuTriUngBuou emrCkPhuongPhapDieuTriUngBuou = new emrCkPhuongPhapDieuTriUngBuou();
        if (dieuTriUngBuou != null)
        {
            emrCkPhuongPhapDieuTriUngBuou.dapung = CheckNull(dieuTriUngBuou.dapung);
            emrCkPhuongPhapDieuTriUngBuou.dieutrikhac = dieuTriUngBuou.dieutrikhac;
            emrCkPhuongPhapDieuTriUngBuou.hoachat = dieuTriUngBuou.hoachat;
            emrCkPhuongPhapDieuTriUngBuou.kieudieutri = CheckNull(dieuTriUngBuou.kieudieutri);
            emrCkPhuongPhapDieuTriUngBuou.phauthuatu = dieuTriUngBuou.phauthuatu;
            emrCkPhuongPhapDieuTriUngBuou.sodot = CheckNull(dieuTriUngBuou.sodot);
            emrCkPhuongPhapDieuTriUngBuou.tiaxadonthuantaihach = dieuTriUngBuou.tiaxadonthuantaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxadonthuantaiu = dieuTriUngBuou.tiaxadonthuantaiu;
            emrCkPhuongPhapDieuTriUngBuou.tiaxahauphautaihach = dieuTriUngBuou.tiaxahauphautaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxahauphautaiu = dieuTriUngBuou.tiaxahauphautaiu;
            emrCkPhuongPhapDieuTriUngBuou.tiaxatienphautaihach = dieuTriUngBuou.tiaxatienphautaihach;
            emrCkPhuongPhapDieuTriUngBuou.tiaxatienphautaiu = dieuTriUngBuou.tiaxatienphautaiu;
        }
        return emrCkPhuongPhapDieuTriUngBuou;
    }

    private emrDmLoaiBenhAn getEmrDmLoaiBenhAn(string itememrDmLoaiBenhAn)
    {
        emrDmLoaiBenhAn emrDmLoaiBenhAn = new emrDmLoaiBenhAn();
        if (!string.IsNullOrEmpty(itememrDmLoaiBenhAn))
            emrDmLoaiBenhAn.ma = itememrDmLoaiBenhAn;
        return emrDmLoaiBenhAn;
    }

    private string toDateFormat(DateTime? date)
    {
        return date.HasValue == true ? date.Value.ToString("yyyy-MM-dd HH:mm:ss") : string.Empty;
    }

    private emrBenhNhan getemrBenhNhan(tbl_emrBenhNhanVM item)
    {
        emrBenhNhan emrBenhNhan = new emrBenhNhan();
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

        return emrBenhNhan;
    }

    private emrDmQuocGia getemrDmQuocGia(string itememrDmQuocGia)
    {
        emrDmQuocGia emrDmQuocGia = new emrDmQuocGia();
        if (!string.IsNullOrEmpty(itememrDmQuocGia))
            emrDmQuocGia.ma = itememrDmQuocGia;
        return emrDmQuocGia;
    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdnghenghiep(string itememrDmNgheNghiepByIdnghenghiep)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (!string.IsNullOrEmpty(itememrDmNgheNghiepByIdnghenghiep))
            emrDmNgheNghiep.ma = itememrDmNgheNghiepByIdnghenghiep;
        return emrDmNgheNghiep;
    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdngheme(string itememrDmNgheNghiepByIdngheme)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (!string.IsNullOrEmpty(itememrDmNgheNghiepByIdngheme))
            emrDmNgheNghiep.ma = itememrDmNgheNghiepByIdngheme;
        return emrDmNgheNghiep;
    }

    private emrDmNgheNghiep getemrDmNgheNghiepByIdnghebo(string itememrDmNgheNghiepByIdnghebo)
    {
        emrDmNgheNghiep emrDmNgheNghiep = new emrDmNgheNghiep();
        if (!string.IsNullOrEmpty(itememrDmNgheNghiepByIdnghebo))
            emrDmNgheNghiep.ma = itememrDmNgheNghiepByIdnghebo;
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
        if (!string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdtinhthanh))
            emrDmDonViHanhChinh.ma = itememrDmDonViHanhChinhByIdtinhthanh;
        return emrDmDonViHanhChinh;
    }

    private emrDmDonViHanhChinh getemrDmDonViHanhChinhByIdquanhuyen(string itememrDmDonViHanhChinhByIdquanhuyen)
    {
        emrDmDonViHanhChinh emrDmDonViHanhChinh = new emrDmDonViHanhChinh();
        if (!string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdquanhuyen))
            emrDmDonViHanhChinh.ma = itememrDmDonViHanhChinhByIdquanhuyen;
        return emrDmDonViHanhChinh;
    }

    private emrDmDonViHanhChinh getemrDmDonViHanhChinhByIdphuongxa(string itememrDmDonViHanhChinhByIdphuongxa)
    {
        emrDmDonViHanhChinh emrDmDonViHanhChinh = new emrDmDonViHanhChinh();
        if (!string.IsNullOrEmpty(itememrDmDonViHanhChinhByIdphuongxa))
            emrDmDonViHanhChinh.ma = itememrDmDonViHanhChinhByIdphuongxa;
        return emrDmDonViHanhChinh;
    }

    private emrDmDanToc getemrDmDanToc(string itememrDmDanToc)
    {
        emrDmDanToc emrDmDanToc = new emrDmDanToc();
        if (itememrDmDanToc != null)
            emrDmDanToc.ma = itememrDmDanToc; ;
        return emrDmDanToc;
    }



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

    #endregion Huyết áp

    private emrBenhAn getemrBenhAn(tbl_emrBenhAnVM itemEmrBenhAn,
        tbl_emrCkMatVM itemEmrCkMat,
        tbl_emrCkThanKinhVM itemEmrCkThanKinh,
        tbl_emrCkTamThanVM itemEmrCkTamThan,
        tbl_emrCkKhamSanKhoaVM itemEmrCkKhamSanKhoa,
        tbl_emrCkKhamPhuKhoaVM itemEmrCkKhamPhuKhoa,
        tbl_emrCkKhamSoSinhVM itemEmrCkKhamSoSinh,
        tbl_emrCkTinhTrangSoSinhVM itemEmrCkTinhTrangSoSinh,
        List<tbl_emrCkTienSuSanKhoaVM> listEmrCkTienSuSanKhoa,
        tbl_emrCkSkTinhTrangSanPhuVM itemEmrCkSkTinhTrangSanPhu,
        tbl_emrCkTinhTrangSanPhuVM itemEmrCkTinhTrangSanPhu,
        tbl_emrCkQuaTrinhSinhTruongVM itemEmrCkQuaTrinhSinhTruong,
        tbl_emrCkToanThanVM itemEmrCkToanThan,
        tbl_emrCkPhuongPhapHoiSinhVM itemEmrCkPhuongPhapHoiSinh,
        tbl_emrCkTiemChungVM itemEmrCkTiemChung,
        tbl_emrCkTienSuGiaDinhVM itemEmrCkTienSuGiaDinh,
        tbl_emrCkTienSuBanThanSanKhoaVM itemEmrCkTienSuBanThanSanKhoa,
        tbl_emrCkTienSuPhuKhoaVM itemEmrCkTienSuPhuKhoa,
        tbl_emrCkMoiSinhVM itemEmrCkMoiSinh,
        tbl_emrCkChucNangSinhHoatVM itemEmrCkChucNangSinhHoat,
        tbl_emrCkTuanHoanVM itemEmrCkTuanHoan,
        tbl_emrCkTieuHoaVM itemEmrCkTieuHoa,
        tbl_emrCkCoXuongKhopVM itemEmrCkCoXuongKhop,
        tbl_emrCkHoHapVM itemEmrCkHoHap,
        tbl_emrCkHuongDieuTriHuyetHocVM itemEmrCkHuongDieuTriHuyetHoc
        )
    {
        emrBenhAn emrBenhAn = new emrBenhAn();
        if (itemEmrBenhAn != null)
        {
            emrBenhAn.bacsylambenhan = itemEmrBenhAn.bacsylambenhan;
            emrBenhAn.cannang = itemEmrBenhAn.cannang;
            emrBenhAn.chieucao = itemEmrBenhAn.chieucao;
            emrBenhAn.chucnangsinhhoat = itemEmrBenhAn.chucnangsinhhoat;
            emrBenhAn.coquankhac = itemEmrBenhAn.coquankhac;
            emrBenhAn.coxuongkhop = itemEmrBenhAn.coxuongkhop;
            emrBenhAn.dacdiemkhac = CheckNullReturnTrueFalse(itemEmrBenhAn.dacdiemkhac);
            emrBenhAn.dalieu = itemEmrBenhAn.dalieu;
            emrBenhAn.dungTuyen = CheckNullReturnTrueFalse(itemEmrBenhAn.dungtuyen);
            emrBenhAn.tyLeBaoHiem = CheckNull(itemEmrBenhAn.tylebaohiem);
            emrBenhAn.dichte = itemEmrBenhAn.dichte;
            emrBenhAn.diung = CheckNullReturnTrueFalse(itemEmrBenhAn.diung);
            emrBenhAn.emrDmMaBenhByIdicdChandoanbenhchinh = getemrDmMaBenhByIdicdChandoanbenhchinh(itemEmrBenhAn.emrDmMaBenhByIdicdChandoanbenhchinh);
            emrBenhAn.emrDmMaBenhByIdicdChandoankemtheo = getemrDmMaBenhByIdicdChandoankemtheo(itemEmrBenhAn.emrDmMaBenhByIdicdChandoankemtheo);
            emrBenhAn.emrDmMaBenhByIdicdChandoanphanbiet = getemrDmMaBenhByIdicdChandoanphanbiet(itemEmrBenhAn.emrDmMaBenhByIdicdChandoankemtheo);
            emrBenhAn.hohap = itemEmrBenhAn.hohap;
            emrBenhAn.huongdieutri = itemEmrBenhAn.huongdieutri;
            emrBenhAn.huyetapcao = returnHuyetApCaoThap(itemEmrBenhAn.huyetapcao, 1);
            emrBenhAn.huyetapthap = returnHuyetApCaoThap(itemEmrBenhAn.huyetapthap, 2);
            emrBenhAn.khamphukhoa = itemEmrBenhAn.khamphukhoa;
            emrBenhAn.khamsankhoa = itemEmrBenhAn.khamsankhoa;
            emrBenhAn.khamsosinh = itemEmrBenhAn.khamsosinh;
            emrBenhAn.lydovaovien = itemEmrBenhAn.lydovaovien;
            emrBenhAn.mach = itemEmrBenhAn.mach;
            emrBenhAn.mat = itemEmrBenhAn.mat;
            emrBenhAn.matuy = CheckNullReturnTrueFalse(itemEmrBenhAn.matuy);
            emrBenhAn.motachandoanbenhchinh = itemEmrBenhAn.motachandoanbenhchinh;
            emrBenhAn.motachandoankemtheo = itemEmrBenhAn.motachandoankemtheo;
            emrBenhAn.motachandoanphanbiet = itemEmrBenhAn.motachandoanphanbiet;
            emrBenhAn.ngaykybenhan = toDateFormat(itemEmrBenhAn.ngaykybenhan);
            emrBenhAn.nguonlay = itemEmrBenhAn.nguonlay;
            emrBenhAn.nhietdo = formatNhietDo(itemEmrBenhAn.nhietdo);
            emrBenhAn.nhiptho = itemEmrBenhAn.nhiptho;
            emrBenhAn.noitietdinhduong = itemEmrBenhAn.noitietdinhduong;
            emrBenhAn.phuongphaphoisinh = itemEmrBenhAn.phuongphaphoisinh;
            emrBenhAn.quatrinhbenhly = itemEmrBenhAn.quatrinhbenhly;
            emrBenhAn.quatrinhsinhtruong = CheckNull(itemEmrBenhAn.quatrinhsinhtruong);
            emrBenhAn.ranghammat = CheckNull(itemEmrBenhAn.ranghammat);
            emrBenhAn.ruoubia = CheckNullReturnTrueFalse(itemEmrBenhAn.ruoubia);
            emrBenhAn.taimuihong = itemEmrBenhAn.taimuihong;
            emrBenhAn.tamthan = itemEmrBenhAn.tamthan;
            emrBenhAn.taychanmieng = itemEmrBenhAn.taychanmieng;
            emrBenhAn.thankinh = itemEmrBenhAn.thankinh;
            emrBenhAn.thuocla = CheckNullReturnTrueFalse(itemEmrBenhAn.thuocla);
            emrBenhAn.thuoclao = CheckNullReturnTrueFalse(itemEmrBenhAn.thuoclao);
            emrBenhAn.tiemchung = itemEmrBenhAn.tiemchung;
            emrBenhAn.tienluong = itemEmrBenhAn.tienluong;
            emrBenhAn.tiensubanthan = itemEmrBenhAn.tiensubanthan;
            emrBenhAn.tiensugiadinh = itemEmrBenhAn.tiensugiadinh;
            emrBenhAn.tiensuphukhoa = itemEmrBenhAn.tiensuphukhoa;
            emrBenhAn.tiensusankhoa = itemEmrBenhAn.tiensusankhoa;
            emrBenhAn.tietnieusinhduc = itemEmrBenhAn.tietnieusinhduc;
            emrBenhAn.tieuhoa = itemEmrBenhAn.tieuhoa;
            emrBenhAn.tinhtrangsanphu = itemEmrBenhAn.tinhtrangsanphu;
            emrBenhAn.tinhtrangsosinh = itemEmrBenhAn.tinhtrangsosinh;
            emrBenhAn.toanthan = itemEmrBenhAn.toanthan;
            emrBenhAn.tomtat = itemEmrBenhAn.tomtat;
            emrBenhAn.tuanhoan = itemEmrBenhAn.tuanhoan;
            emrBenhAn.vaongaythu = itemEmrBenhAn.vaongaythu.HasValue == true ? (itemEmrBenhAn.vaongaythu.Value.ToString().Equals("0") == true ? string.Empty : itemEmrBenhAn.vaongaythu.Value.ToString()) : "";
            emrBenhAn.vongdau = itemEmrBenhAn.vongdau;
            emrBenhAn.vongnguc = itemEmrBenhAn.vongnguc;
            emrBenhAn.xetnghiemcanlamsang = itemEmrBenhAn.xetnghiemcanlamsang;
            if (ShareVariables.pub_spC.Equals("HU"))
                emrBenhAn.emrCkMat = getemrCkMat(itemEmrCkMat);
            emrBenhAn.emrCkThanKinh = getemrCkThanKinh(itemEmrCkThanKinh);
            emrBenhAn.emrCkTamThan = getemrCkTamThan(itemEmrCkTamThan);
            emrBenhAn.emrCkKhamSanKhoa = getemrCkKhamSanKhoa(itemEmrCkKhamSanKhoa);
            if (!ShareVariables.pub_spC.Equals("YH"))
            {
                emrBenhAn.emrCkKhamPhuKhoa = getemrCkKhamPhuKhoa(itemEmrCkKhamPhuKhoa);
                emrBenhAn.emrCkKhamSoSinh = getemrCkKhamSoSinh(itemEmrCkKhamSoSinh);
                emrBenhAn.emrCkTinhTrangSoSinh = getemrCkTinhTrangSoSinh(itemEmrCkTinhTrangSoSinh);
                emrBenhAn.emrCkTienSuSanKhoa = getemrCkTienSuSanKhoa(listEmrCkTienSuSanKhoa);
                emrBenhAn.emrCkSkTinhTrangSanPhu = getemrCkSkTinhTrangSanPhu(itemEmrCkSkTinhTrangSanPhu);
                emrBenhAn.emrCkTinhTrangSanPhu = getemrCkTinhTrangSanPhu(itemEmrCkTinhTrangSanPhu);
                emrBenhAn.emrCkQuaTrinhSinhTruong = getemrCkQuaTrinhSinhTruong(itemEmrCkQuaTrinhSinhTruong);
            }
            emrBenhAn.emrCkToanThan = getemrCkToanThan(itemEmrCkToanThan);
            emrBenhAn.emrCkPhuongPhapHoiSinh = getemrCkPhuongPhapHoiSinh(itemEmrCkPhuongPhapHoiSinh);
            emrBenhAn.emrCkTiemChung = getemrCkTiemChung(itemEmrCkTiemChung);
            emrBenhAn.emrCkTienSuGiaDinh = getemrCkTienSuGiaDinh(itemEmrCkTienSuGiaDinh);
            emrBenhAn.emrCkTienSuBanThanSanKhoa = getemrCkTienSuBanThanSanKhoa(itemEmrCkTienSuBanThanSanKhoa);
            emrBenhAn.emrCkTienSuPhuKhoa = getemrCkTienSuPhuKhoa(itemEmrCkTienSuPhuKhoa);
            emrBenhAn.tyletonthuongloai1 = CheckNull(itemEmrBenhAn.tyletonthuongloai1);
            emrBenhAn.tyletonthuongloai2 = CheckNull(itemEmrBenhAn.tyletonthuongloai2);
            emrBenhAn.tyletonthuongloai3 = CheckNull(itemEmrBenhAn.tyletonthuongloai3);
            emrBenhAn.tyletonthuongloai4 = CheckNull(itemEmrBenhAn.tyletonthuongloai4);
            emrBenhAn.tyletonthuongloai5 = CheckNull(itemEmrBenhAn.tyletonthuongloai5);
            // Dành riêng bệnh án truyền nhiễm
            if (ShareVariables.pub_spC.Equals("HU"))
            {
                emrBenhAn.emrCkMoiSinh = getemrCkMoiSinh(itemEmrCkMoiSinh);
                // Dành riêng cho bệnh án PHCN
                emrBenhAn.emrCkChucNangSinhHoat = getemrCkChucNangSinhHoat(itemEmrCkChucNangSinhHoat);
                emrBenhAn.emrCkTuanHoan = getemrCkTuanHoan(itemEmrCkTuanHoan);
                emrBenhAn.emrCkTieuHoa = getemrCkTieuHoa(itemEmrCkTieuHoa);
                emrBenhAn.emrCkCoXuongKhop = getemrCkCoXuongKhop(itemEmrCkCoXuongKhop);
                emrBenhAn.emrCkHoHap = getemrCkHoHap(itemEmrCkHoHap);
                // Huyết học truyền máu
                emrBenhAn.emrCkHuongDieuTriHuyetHoc = getemrCkHuongDieuTriHuyetHoc(itemEmrCkHuongDieuTriHuyetHoc);
            }
        }

        return emrBenhAn;
    }

    private emrCkHuongDieuTriHuyetHoc getemrCkHuongDieuTriHuyetHoc(tbl_emrCkHuongDieuTriHuyetHocVM itemEmrCkHuongDieuTriHuyetHoc)
    {
        emrCkHuongDieuTriHuyetHoc emrCkHuongDieuTriHuyetHoc = new emrCkHuongDieuTriHuyetHoc();

        if (itemEmrCkHuongDieuTriHuyetHoc != null)
        {
            emrCkHuongDieuTriHuyetHoc.bachcauSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanBachCauHat);
            emrCkHuongDieuTriHuyetHoc.bachcauTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongBachCauHat);
            emrCkHuongDieuTriHuyetHoc.hongcauruaSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanHongCauRua);
            emrCkHuongDieuTriHuyetHoc.hongcauruaTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongHongCauRua);
            emrCkHuongDieuTriHuyetHoc.hongcauSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanHongCau);
            emrCkHuongDieuTriHuyetHoc.hongcauTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongHongCau);
            emrCkHuongDieuTriHuyetHoc.huyettuongSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanHuyetTuong);
            emrCkHuongDieuTriHuyetHoc.huyettuongTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongHuyetTuong);
            emrCkHuongDieuTriHuyetHoc.huyettuongtuoiSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanHTTuoiDongLach);
            emrCkHuongDieuTriHuyetHoc.huyettuongtuoiTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongHTTuoiDongLach);
            emrCkHuongDieuTriHuyetHoc.mautoanphanSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanMauToanPhan);
            emrCkHuongDieuTriHuyetHoc.mautoanphanTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongMauToanPhan);
            emrCkHuongDieuTriHuyetHoc.phanungtruyenmau = string.Empty;
            emrCkHuongDieuTriHuyetHoc.tieucauSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanTieuCau);
            emrCkHuongDieuTriHuyetHoc.tieucauTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongTieuCau);
            emrCkHuongDieuTriHuyetHoc.tualanhSolan = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.SoLanTuaLanh);
            emrCkHuongDieuTriHuyetHoc.tualanhTongluong = CheckNull(itemEmrCkHuongDieuTriHuyetHoc.TongSoLuongTuaLanh);
        }
        return emrCkHuongDieuTriHuyetHoc;
    }

    private emrCkHoHap getemrCkHoHap(tbl_emrCkHoHapVM itemEmrCkHoHap)
    {
        emrCkHoHap emrCkHoHap = new emrCkHoHap();

        if (itemEmrCkHoHap != null)
        {
            emrCkHoHap.conngungtho = CheckNull(itemEmrCkHoHap.conngungtho);
            emrCkHoHap.longnguc = CheckNull(itemEmrCkHoHap.longnguc);
            emrCkHoHap.roiloan = CheckNull(itemEmrCkHoHap.roiloan);
            emrCkHoHap.silverman = CheckNull(itemEmrCkHoHap.silverman);
            emrCkHoHap.thetichkhi = CheckNull(itemEmrCkHoHap.thetichkhi);
            emrCkHoHap.thobung = CheckNull(itemEmrCkHoHap.thobung);
            emrCkHoHap.thokhokhe = CheckNull(itemEmrCkHoHap.thokhokhe);
            emrCkHoHap.tholomnguc = CheckNull(itemEmrCkHoHap.tholomnguc);
            emrCkHoHap.thonong = CheckNull(itemEmrCkHoHap.thonong);
            emrCkHoHap.thoranphoi = CheckNull(itemEmrCkHoHap.thoranphoi);
            emrCkHoHap.thoranphoichitiet = CheckNull(itemEmrCkHoHap.thoranphoichitiet);
            emrCkHoHap.thoritphequan = CheckNull(itemEmrCkHoHap.thoritphequan);
            emrCkHoHap.thoritthanhquan = CheckNull(itemEmrCkHoHap.thoritthanhquan);
            emrCkHoHap.tinhtrangbenhly = CheckNull(itemEmrCkHoHap.tinhtrangbenhly);
        }
        return emrCkHoHap;
    }

    private emrCkCoXuongKhop getemrCkCoXuongKhop(tbl_emrCkCoXuongKhopVM itemEmrCkCoXuongKhop)
    {
        emrCkCoXuongKhop emrCkCoXuongKhop = new emrCkCoXuongKhop();
        if (itemEmrCkCoXuongKhop != null)
        {
            emrCkCoXuongKhop.baccothu = CheckNull(itemEmrCkCoXuongKhop.baccothu);
            emrCkCoXuongKhop.cotsongroiloancn = CheckNull(itemEmrCkCoXuongKhop.cotsongroiloancn);
            emrCkCoXuongKhop.cotsongschober = CheckNull(itemEmrCkCoXuongKhop.cotsongschober);
            emrCkCoXuongKhop.cotsongstibor = CheckNull(itemEmrCkCoXuongKhop.cotsongstibor);
            emrCkCoXuongKhop.cotsongttbly = CheckNull(itemEmrCkCoXuongKhop.cotsongttbly);
            emrCkCoXuongKhop.hinhthekhop = CheckNull(itemEmrCkCoXuongKhop.hinhthekhop);
            emrCkCoXuongKhop.roiloanco = CheckNull(itemEmrCkCoXuongKhop.roiloanco);
            emrCkCoXuongKhop.tamhoatdongvaovien = CheckNull(itemEmrCkCoXuongKhop.tamhoatdongvaovien);
            emrCkCoXuongKhop.tamhoatdonravien = CheckNull(itemEmrCkCoXuongKhop.tamhoatdonravien);
            emrCkCoXuongKhop.tencothu = CheckNull(itemEmrCkCoXuongKhop.tencothu);
            emrCkCoXuongKhop.ttbenhlyco = CheckNull(itemEmrCkCoXuongKhop.ttbenhlyco);
        }
        return emrCkCoXuongKhop;
    }

    private emrCkTieuHoa getemrCkTieuHoa(tbl_emrCkTieuHoaVM itemEmrCkTieuHoa)
    {
        emrCkTieuHoa emrCkTieuHoa = new emrCkTieuHoa();

        if (itemEmrCkTieuHoa != null)
        {
            emrCkTieuHoa.gandacdiem = CheckNull(itemEmrCkTieuHoa.gandacdiem);
            emrCkTieuHoa.gankichthuoc = CheckNull(itemEmrCkTieuHoa.gankichthuoc);
            emrCkTieuHoa.ganto = CheckNull(itemEmrCkTieuHoa.ganto);
            emrCkTieuHoa.motakhac = CheckNull(itemEmrCkTieuHoa.motakhac);
            emrCkTieuHoa.roiloanchucnang = CheckNull(itemEmrCkTieuHoa.roiloanchucnang);
            emrCkTieuHoa.tinhtrangbenhly = CheckNull(itemEmrCkTieuHoa.tinhtrangbenhly);
        }
        return emrCkTieuHoa;
    }

    private emrCkTuanHoan getemrCkTuanHoan(tbl_emrCkTuanHoanVM itemEmrCkTuanHoan)
    {
        emrCkTuanHoan emrCkTuanHoan = new emrCkTuanHoan();

        if (itemEmrCkTuanHoan != null)
        {
            emrCkTuanHoan.danoibong = CheckNull(itemEmrCkTuanHoan.danoibong);
            emrCkTuanHoan.nhiptim = CheckNull(itemEmrCkTuanHoan.nhiptim);
            emrCkTuanHoan.roiloantim = CheckNull(itemEmrCkTuanHoan.roiloantim);
            emrCkTuanHoan.thoigiandaymaomach = CheckNull(itemEmrCkTuanHoan.thoigiandaymaomach);
            emrCkTuanHoan.timamthoi = CheckNull(itemEmrCkTuanHoan.timamthoi);
            emrCkTuanHoan.timchitiet = CheckNull(itemEmrCkTuanHoan.timchitiet);
            emrCkTuanHoan.timgallop = CheckNull(itemEmrCkTuanHoan.timgallop);
            emrCkTuanHoan.timmo = CheckNull(itemEmrCkTuanHoan.timmo);
            emrCkTuanHoan.timro = CheckNull(itemEmrCkTuanHoan.timro);
            emrCkTuanHoan.tinhmachconoi = CheckNull(itemEmrCkTuanHoan.tinhmachconoi);
            emrCkTuanHoan.vamohoi = CheckNull(itemEmrCkTuanHoan.vamohoi);
        }

        return emrCkTuanHoan;
    }

    private emrCkChucNangSinhHoat getemrCkChucNangSinhHoat(tbl_emrCkChucNangSinhHoatVM itemEmrCkChucNangSinhHoat)
    {
        emrCkChucNangSinhHoat emrCkChucNangSinhHoat = new emrCkChucNangSinhHoat();

        if (itemEmrCkChucNangSinhHoat != null)
        {
            emrCkChucNangSinhHoat.anuong = CheckNull(itemEmrCkChucNangSinhHoat.anuong);
            emrCkChucNangSinhHoat.chaitoc = CheckNull(itemEmrCkChucNangSinhHoat.chaitoc);
            emrCkChucNangSinhHoat.danhrang = CheckNull(itemEmrCkChucNangSinhHoat.danhrang);
            emrCkChucNangSinhHoat.dichuyen = CheckNull(itemEmrCkChucNangSinhHoat.dichuyen);
            emrCkChucNangSinhHoat.divesinh = CheckNull(itemEmrCkChucNangSinhHoat.divesinh);
            emrCkChucNangSinhHoat.dungcu = CheckNull(itemEmrCkChucNangSinhHoat.dungcu);
            emrCkChucNangSinhHoat.dunglen = CheckNull(itemEmrCkChucNangSinhHoat.dunglen);
            emrCkChucNangSinhHoat.dungNgoi = CheckNull(itemEmrCkChucNangSinhHoat.dungNgoi);
            emrCkChucNangSinhHoat.macquanao = CheckNull(itemEmrCkChucNangSinhHoat.macquanao);
            emrCkChucNangSinhHoat.namguaSap = CheckNull(itemEmrCkChucNangSinhHoat.namguaSap);
            emrCkChucNangSinhHoat.namnguaNgoi = CheckNull(itemEmrCkChucNangSinhHoat.namnguaNgoi);
            emrCkChucNangSinhHoat.sinhhoatkhac = CheckNull(itemEmrCkChucNangSinhHoat.sinhhoatkhac);
            emrCkChucNangSinhHoat.tam = CheckNull(itemEmrCkChucNangSinhHoat.tam);
        }
        return emrCkChucNangSinhHoat;
    }

    private emrCkMoiSinh getemrCkMoiSinh(tbl_emrCkMoiSinhVM itemEmrCkMoiSinh)
    {
        emrCkMoiSinh emrCkMoiSinh = new emrCkMoiSinh();

        if (itemEmrCkMoiSinh != null)
        {
            emrCkMoiSinh.benhdichTruonghoc = CheckNull(itemEmrCkMoiSinh.benhdichTruonghoc);
            emrCkMoiSinh.khuvucbenhcaptinh = CheckNull(itemEmrCkMoiSinh.khuvucbenhcaptinh);
            emrCkMoiSinh.khuvucsong = CheckNull(itemEmrCkMoiSinh.khuvucsong);
            emrCkMoiSinh.moisinh = CheckNull(itemEmrCkMoiSinh.moisinh);
            emrCkMoiSinh.thoigiansong = toDateFormat(itemEmrCkMoiSinh.thoigiansong);
            emrCkMoiSinh.treCungnha = CheckNull(itemEmrCkMoiSinh.treCungnha);
            emrCkMoiSinh.treCungtruong = CheckNull(itemEmrCkMoiSinh.treCungtruong);
            emrCkMoiSinh.treGannha = CheckNull(itemEmrCkMoiSinh.treGannha);
        }
        return emrCkMoiSinh;
    }

    private emrCkTienSuPhuKhoa getemrCkTienSuPhuKhoa(tbl_emrCkTienSuPhuKhoaVM itemEmrCkTienSuPhuKhoa)
    {
        emrCkTienSuPhuKhoa emrCkTienSuPhuKhoa = new emrCkTienSuPhuKhoa();

        if (itemEmrCkTienSuPhuKhoa != null)
        {
            emrCkTienSuPhuKhoa.tuoicokinh = CheckNull(itemEmrCkTienSuPhuKhoa.tuoicokinh);
            emrCkTienSuPhuKhoa.chukikinh = CheckNull(itemEmrCkTienSuPhuKhoa.chukikinh); // kiểu int
            emrCkTienSuPhuKhoa.ngaythaykinh = CheckNull(itemEmrCkTienSuPhuKhoa.ngaythaykinh);// Số ngày thấy kinh
            emrCkTienSuPhuKhoa.tuoilaychong = CheckNull(itemEmrCkTienSuPhuKhoa.tuoilaychong);
            emrCkTienSuPhuKhoa.ngaykinhcuoi = toDateFormat(itemEmrCkTienSuPhuKhoa.ngaykinhcuoi);
            emrCkTienSuPhuKhoa.tuoihetkinh = CheckNull(itemEmrCkTienSuPhuKhoa.tuoihetkinh);

            emrCkTienSuPhuKhoa.benhphukhoa = CheckNull(itemEmrCkTienSuPhuKhoa.benhphukhoa);
            emrCkTienSuPhuKhoa.khoiubt = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.khoiubt);
            emrCkTienSuPhuKhoa.uxotc = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.uxotc);
            emrCkTienSuPhuKhoa.didangsd = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.didangsd);
            emrCkTienSuPhuKhoa.ssd = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.ssd);
            emrCkTienSuPhuKhoa.luongkinh = CheckNull(itemEmrCkTienSuPhuKhoa.luongkinh);
            emrCkTienSuPhuKhoa.ngaycokinh = CheckNull(itemEmrCkTienSuPhuKhoa.ngaycokinh);
            emrCkTienSuPhuKhoa.tinhchatkinhnguyet = CheckNull(itemEmrCkTienSuPhuKhoa.tinhchatkinhnguyet);
            emrCkTienSuPhuKhoa.phauthuatphukhoakhac = CheckNull(itemEmrCkTienSuPhuKhoa.phauthuatphukhoakhac);
            emrCkTienSuPhuKhoa.daubung = CheckNull(itemEmrCkTienSuPhuKhoa.daubung);

            emrCkTienSuPhuKhoa.thoidiemdaubung = CheckNull(itemEmrCkTienSuPhuKhoa.thoidiemdaubung);// 1 =Trước kỳ, 2 =Trong, 3= Sau
            emrCkTienSuPhuKhoa.tsm = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.tsm);
            emrCkTienSuPhuKhoa.dieutrictc = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.dieutrictc);
            emrCkTienSuPhuKhoa.catcutctc = CheckNullReturnTrueFalse(itemEmrCkTienSuPhuKhoa.catcutctc);
        }
        return emrCkTienSuPhuKhoa;
    }

    private emrCkTienSuBanThanSanKhoa getemrCkTienSuBanThanSanKhoa(tbl_emrCkTienSuBanThanSanKhoaVM itemEmrCkTienSuBanThanSanKhoa)
    {
        emrCkTienSuBanThanSanKhoa emrCkTienSuBanThanSanKhoa = new emrCkTienSuBanThanSanKhoa();

        if (itemEmrCkTienSuBanThanSanKhoa != null)
        {
            emrCkTienSuBanThanSanKhoa.basedow = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.basedow);
            emrCkTienSuBanThanSanKhoa.benhthan = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.benhthan);
            emrCkTienSuBanThanSanKhoa.benhtim = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.benhtim);
            emrCkTienSuBanThanSanKhoa.caohuyetap = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.caohuyetap);
            emrCkTienSuBanThanSanKhoa.diungthuoc = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.diungthuoc);
            emrCkTienSuBanThanSanKhoa.dongkinh = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.dongkinh);
            emrCkTienSuBanThanSanKhoa.henphequan = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.henphequan);
            emrCkTienSuBanThanSanKhoa.laophoi = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.laophoi);
            emrCkTienSuBanThanSanKhoa.moruotthua = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.moruotthua);
            emrCkTienSuBanThanSanKhoa.phauthuatobung = CheckNull(itemEmrCkTienSuBanThanSanKhoa.phauthuatobung);
            emrCkTienSuBanThanSanKhoa.thongtincuthe = CheckNull(itemEmrCkTienSuBanThanSanKhoa.thongtincuthe);
            emrCkTienSuBanThanSanKhoa.viemtactinhmach = CheckNullReturnTrueFalse(itemEmrCkTienSuBanThanSanKhoa.viemtactinhmach);
        }
        return emrCkTienSuBanThanSanKhoa;
    }

    private emrCkTienSuGiaDinh getemrCkTienSuGiaDinh(tbl_emrCkTienSuGiaDinhVM itemEmrCkTienSuGiaDinh)
    {
        emrCkTienSuGiaDinh emrCkTienSuGiaDinh = new emrCkTienSuGiaDinh();

        if (itemEmrCkTienSuGiaDinh != null)
        {
            emrCkTienSuGiaDinh.benhditruyen = CheckNullReturnTrueFalse(itemEmrCkTienSuGiaDinh.benhditruyen);
            emrCkTienSuGiaDinh.benhkhac = CheckNull(itemEmrCkTienSuGiaDinh.benhkhac);
            emrCkTienSuGiaDinh.caohuyetap = CheckNullReturnTrueFalse(itemEmrCkTienSuGiaDinh.benhditruyen);
            emrCkTienSuGiaDinh.daiduong = CheckNullReturnTrueFalse(itemEmrCkTienSuGiaDinh.daiduong);
            emrCkTienSuGiaDinh.didang = CheckNullReturnTrueFalse(itemEmrCkTienSuGiaDinh.didang);
            emrCkTienSuGiaDinh.sinhdoi = CheckNullReturnTrueFalse(itemEmrCkTienSuGiaDinh.sinhdoi);
        }
        return emrCkTienSuGiaDinh;
    }

    private emrCkSkTinhTrangSanPhu getemrCkSkTinhTrangSanPhu(tbl_emrCkSkTinhTrangSanPhuVM itemEmrCkSkTinhTrangSanPhu)
    {
        emrCkSkTinhTrangSanPhu emrCkSkTinhTrangSanPhu = new emrCkSkTinhTrangSanPhu();

        if (itemEmrCkSkTinhTrangSanPhu != null)
        {
            emrCkSkTinhTrangSanPhu.chieucaotucung = CheckNull(itemEmrCkSkTinhTrangSanPhu.chieucaotucung);
            emrCkSkTinhTrangSanPhu.chisobishop = CheckNull(itemEmrCkSkTinhTrangSanPhu.chisobishop);
            emrCkSkTinhTrangSanPhu.concotucung = CheckNull(itemEmrCkSkTinhTrangSanPhu.concotucung);
            emrCkSkTinhTrangSanPhu.cotucung = CheckNull(itemEmrCkSkTinhTrangSanPhu.cotucung);
            emrCkSkTinhTrangSanPhu.dauoi = CheckNull(itemEmrCkSkTinhTrangSanPhu.dauoi);
            emrCkSkTinhTrangSanPhu.maunuocoi = CheckNull(itemEmrCkSkTinhTrangSanPhu.maunuocoi);
            emrCkSkTinhTrangSanPhu.ngoithai = CheckNull(itemEmrCkSkTinhTrangSanPhu.ngoithai);
            emrCkSkTinhTrangSanPhu.nhietdo = formatNhietDo(itemEmrCkSkTinhTrangSanPhu.nhietdo);
            emrCkSkTinhTrangSanPhu.nhiptho = CheckNull(itemEmrCkSkTinhTrangSanPhu.nhiptho);
            emrCkSkTinhTrangSanPhu.phu = CheckNullReturnTrueFalse(itemEmrCkSkTinhTrangSanPhu.phu);
            emrCkSkTinhTrangSanPhu.proteinnieu = CheckNull(itemEmrCkSkTinhTrangSanPhu.proteinnieu);
            emrCkSkTinhTrangSanPhu.seomocu = CheckNullReturnTrueFalse(itemEmrCkSkTinhTrangSanPhu.seomocu);
            emrCkSkTinhTrangSanPhu.dauvetmo = CheckNullReturnTrueFalse(itemEmrCkSkTinhTrangSanPhu.dauvetmo);
            emrCkSkTinhTrangSanPhu.timthai = CheckNull(itemEmrCkSkTinhTrangSanPhu.timthai);
            emrCkSkTinhTrangSanPhu.tinhthan = CheckNull(itemEmrCkSkTinhTrangSanPhu.tinhthan);
            emrCkSkTinhTrangSanPhu.thoidiemvooi = toDateFormat(itemEmrCkSkTinhTrangSanPhu.thoidiemvooi);
            emrCkSkTinhTrangSanPhu.tinhtrangtimthai = CheckNull(itemEmrCkSkTinhTrangSanPhu.tinhtrangtimthai);
            emrCkSkTinhTrangSanPhu.vongbung = CheckNull(itemEmrCkSkTinhTrangSanPhu.vongbung);
            emrCkSkTinhTrangSanPhu.huyetap = CheckNull(itemEmrCkSkTinhTrangSanPhu.huyetap);
            emrCkSkTinhTrangSanPhu.mach = CheckNull(itemEmrCkSkTinhTrangSanPhu.mach);
            emrCkSkTinhTrangSanPhu.domo = CheckNull(itemEmrCkSkTinhTrangSanPhu.domo);
        }
        return emrCkSkTinhTrangSanPhu;
    }

    private emrCkPhuongPhapHoiSinh getemrCkPhuongPhapHoiSinh(tbl_emrCkPhuongPhapHoiSinhVM itemEmrCkPhuongPhapHoiSinh)
    {
        emrCkPhuongPhapHoiSinh emrCkPhuongPhapHoiSinh = new emrCkPhuongPhapHoiSinh();

        if (itemEmrCkPhuongPhapHoiSinh != null)
        {
            emrCkPhuongPhapHoiSinh.bopbongoxy = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.bopbongoxy);
            emrCkPhuongPhapHoiSinh.hutdich = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.hutdich);
            emrCkPhuongPhapHoiSinh.khac = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.khac);
            emrCkPhuongPhapHoiSinh.noikhiquan = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.noikhiquan);
            emrCkPhuongPhapHoiSinh.thooxy = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.thooxy);
            emrCkPhuongPhapHoiSinh.xoaboptim = CheckNullReturnTrueFalse(itemEmrCkPhuongPhapHoiSinh.xoaboptim);
            emrCkPhuongPhapHoiSinh.mota = CheckNull(itemEmrCkPhuongPhapHoiSinh.mota);
        }
        return emrCkPhuongPhapHoiSinh;
    }

    private emrCkTinhTrangSoSinh getemrCkTinhTrangSoSinh(tbl_emrCkTinhTrangSoSinhVM itemEmrCkTinhTrangSoSinh)
    {
        emrCkTinhTrangSoSinh emrCkTinhTrangSoSinh = new emrCkTinhTrangSoSinh();

        if (itemEmrCkTinhTrangSoSinh != null)
        {
            emrCkTinhTrangSoSinh.apgar01 = CheckNull(itemEmrCkTinhTrangSoSinh.apgar01);
            emrCkTinhTrangSoSinh.apgar05 = CheckNull(itemEmrCkTinhTrangSoSinh.apgar05);
            emrCkTinhTrangSoSinh.apgar10 = CheckNull(itemEmrCkTinhTrangSoSinh.apgar10);
            emrCkTinhTrangSoSinh.cannang = CheckNull(itemEmrCkTinhTrangSoSinh.cannang);
            emrCkTinhTrangSoSinh.nguoidode = CheckNull(itemEmrCkTinhTrangSoSinh.nguoidode);
            emrCkTinhTrangSoSinh.sskhac = CheckNull(itemEmrCkTinhTrangSoSinh.sskhac);
            emrCkTinhTrangSoSinh.sskhocngay = CheckNullReturnTrueFalse(itemEmrCkTinhTrangSoSinh.sskhocngay);
            emrCkTinhTrangSoSinh.ssngat = CheckNull(itemEmrCkTinhTrangSoSinh.ssngat);
            emrCkTinhTrangSoSinh.tennguoichuyensosinh = CheckNull(itemEmrCkTinhTrangSoSinh.tennguoichuyensosinh);
            emrCkTinhTrangSoSinh.tinhtrangdinhduong = CheckNull(itemEmrCkTinhTrangSoSinh.tinhtrangdinhduong);
            emrCkTinhTrangSoSinh.tuoi = CheckNull(itemEmrCkTinhTrangSoSinh.tuoi);
        }
        return emrCkTinhTrangSoSinh;
    }

    private emrCkTiemChung getemrCkTiemChung(tbl_emrCkTiemChungVM itemEmrCkTiemChung)
    {
        emrCkTiemChung emrCkTiemChung = new emrCkTiemChung();

        if (itemEmrCkTiemChung != null)
        {
            emrCkTiemChung.tcbachhau = GetLoaiTiemChung(itemEmrCkTiemChung.tcbachhau, "tcbachhau");
            emrCkTiemChung.tcbailiet = GetLoaiTiemChung(itemEmrCkTiemChung.tcbailiet, "tcbailiet");
            emrCkTiemChung.tchoga = GetLoaiTiemChung(itemEmrCkTiemChung.tchoga, "tchoga");
            emrCkTiemChung.tckhac = GetLoaiTiemChung(itemEmrCkTiemChung.tckhac, "tckhac");
            emrCkTiemChung.tclao = GetLoaiTiemChung(itemEmrCkTiemChung.tclao, "tclao");
            emrCkTiemChung.tcmotakhac = itemEmrCkTiemChung.tcmotakhac;
            emrCkTiemChung.tcsoi = GetLoaiTiemChung(itemEmrCkTiemChung.tcsoi, "tcsoi");
            emrCkTiemChung.tcuonvan = GetLoaiTiemChung(itemEmrCkTiemChung.tcuonvan, "tcuonvan");
        }
        return emrCkTiemChung;
    }

    // Fix theo value ở form nhập vì là dạng + chuỗi
    private string GetLoaiTiemChung(string input, string loaiTiemChung)
    {
        string outPut = "0";
        if (!string.IsNullOrEmpty(input))
            switch (loaiTiemChung)
            {
                case "tclao":         // Chuỗi string input có chứa value 1=Ho Lao return true
                    if (input.Contains("1"))
                        outPut = "1";
                    break;

                case "tcbailiet":     // Chuỗi string input có chứa value 2 = Bại liệt return true
                    if (input.Contains("2"))
                        outPut = "1";
                    break;

                case "tcsoi":         // Chuỗi string input có chứa value 3 = Sởi return true
                    if (input.Contains("3"))
                        outPut = "1";
                    break;

                case "tchoga":        // Chuỗi string input có chứa value 4 = Ho Gà return true
                    if (input.Contains("4"))
                        outPut = "1";
                    break;

                case "cuonvan":       // Chuỗi string input có chứa value 5 = Uốn ván return true
                    if (input.Contains("5"))
                        outPut = "1";
                    break;

                case "tcbachhau":     // Chuỗi string input có chứa value 6 = Bạch hầu return true
                    if (input.Split('6').Count() > 0)
                        outPut = "1";
                    break;

                case "tckhac":        // Chuỗi string input có chứa value 7 =Tiêm chủng khác return true
                    if (input.Contains("7"))
                        outPut = "1";
                    break;

                default:
                    outPut = "0";
                    break;
            }
        return outPut;
    }

    private string GetLoaiNuoiDuong(string input, string loaiNuoiDuong)
    {
        string outPut = "0";
        if (!string.IsNullOrEmpty(input))
            switch (loaiNuoiDuong)
            {
                case "suame":         // Chuỗi string input có chứa value 1= sữa mẹ return true
                    if (input.Contains("1"))
                        outPut = "1";
                    break;

                case "suagoai": // Viết sai chính tả theo DTT :D    // Chuỗi string input có chứa value 2 = Nuôi nhân tạo return true
                    if (input.Contains("2"))
                        outPut = "1";
                    break;

                case "honhop":         // Chuỗi string input có chứa value 3 = Hỗn hợp true
                    if (input.Contains("3"))
                        outPut = "1";
                    break;

                default:
                    outPut = "0";
                    break;
            }
        return outPut;
    }

    private string GetLoaiChamSoc(string input, string LoaiChamSoc)
    {
        string outPut = "0";
        if (!string.IsNullOrEmpty(input))
            switch (LoaiChamSoc)
            {
                case "vuontre":         // Chuỗi string input có chứa value 1= Vườn trẻ return true
                    if (input.Contains("1"))
                        outPut = "1";
                    break;

                case "tainha":     // Chuỗi string input có chứa value 2 = Tại nhà return true
                    if (input.Contains("2"))
                        outPut = "1";
                    break;

                default:
                    outPut = "0";
                    break;
            }
        return outPut;
    }

    private emrCkToanThan getemrCkToanThan(tbl_emrCkToanThanVM itemEmrCkToanThan)
    {
        emrCkToanThan emrCkToanThan = new emrCkToanThan();

        if (itemEmrCkToanThan != null)
        {
            emrCkToanThan.biphu = CheckNullReturnTrueFalse(itemEmrCkToanThan.biphu);
            emrCkToanThan.da = CheckNull(itemEmrCkToanThan.da);
            emrCkToanThan.ganBogan = CheckNull(itemEmrCkToanThan.ganBogan);
            emrCkToanThan.ganDau = CheckNull(itemEmrCkToanThan.ganDau);
            emrCkToanThan.ganKichthuoc = CheckNull(itemEmrCkToanThan.ganKichthuoc);
            emrCkToanThan.ganMatdo = CheckNull(itemEmrCkToanThan.ganMatdo);
            emrCkToanThan.ganThongtinbosung = CheckNull(itemEmrCkToanThan.ganThongTinBoSung);
            emrCkToanThan.hachDodauhach = CheckNull(itemEmrCkToanThan.hachDodauhach);
            emrCkToanThan.hachDodidong = CheckNull(itemEmrCkToanThan.hachDodidong);
            emrCkToanThan.hachKichthuoc = CheckNull(itemEmrCkToanThan.hachKichthuoc);
            emrCkToanThan.hachSoluong = CheckNull(itemEmrCkToanThan.hachSoluong);
            emrCkToanThan.hachThongtinbosung = CheckNull(itemEmrCkToanThan.hachThongtinbosung);
            emrCkToanThan.hinhdang = CheckNull(itemEmrCkToanThan.hinhdang);
            emrCkToanThan.lachBolach = CheckNull(itemEmrCkToanThan.lachBolach);
            emrCkToanThan.lachDaulach = CheckNull(itemEmrCkToanThan.lachDaulach);
            emrCkToanThan.lachKichthuoc = CheckNull(itemEmrCkToanThan.lachKichthuoc);
            emrCkToanThan.lachMatdo = CheckNull(itemEmrCkToanThan.lachMatdo);
            emrCkToanThan.lachMatlach = CheckNull(itemEmrCkToanThan.lachMatlach);
            emrCkToanThan.lachThongtinbosung = CheckNull(itemEmrCkToanThan.lachThongtinbosung);
            emrCkToanThan.longtocmong = CheckNull(itemEmrCkToanThan.longtocmong);
            emrCkToanThan.niemmac = CheckNull(itemEmrCkToanThan.NiemMac);
            emrCkToanThan.phoiMota = CheckNull(itemEmrCkToanThan.phoiMoTa);
            emrCkToanThan.phutoanthan = CheckNullReturnTrueFalse(itemEmrCkToanThan.phutoanthan);
            emrCkToanThan.thanMota = CheckNull(itemEmrCkToanThan.thanMoTa);
            emrCkToanThan.thetrang = CheckNull(itemEmrCkToanThan.TheTrang);
            emrCkToanThan.thieumau = CheckNull(itemEmrCkToanThan.thieuMau);
            emrCkToanThan.timMota = CheckNull(itemEmrCkToanThan.timMoTa);
            emrCkToanThan.tinhthan = CheckNull(itemEmrCkToanThan.TinhThan);
            emrCkToanThan.vuMota = CheckNull(itemEmrCkToanThan.vuMota);
            // Phần bệnh án phụ

            emrCkToanThan.hachViTri = CheckNull(itemEmrCkToanThan.hachViTri);
            emrCkToanThan.khuyetTatDacBiet = CheckNull(itemEmrCkToanThan.khuyetTatDacBiet);
            emrCkToanThan.matGan = CheckNull(itemEmrCkToanThan.matGan);
            emrCkToanThan.trieuchungphu = CheckNull(itemEmrCkToanThan.trieuchungphu);
            emrCkToanThan.trieuchungxuathuyet = CheckNull(itemEmrCkToanThan.trieuchungxuathuyet);
            emrCkToanThan.tuyengiap = CheckNull(itemEmrCkToanThan.tuyengiap);
        }
        return emrCkToanThan;
    }

    private emrCkQuaTrinhSinhTruong getemrCkQuaTrinhSinhTruong(tbl_emrCkQuaTrinhSinhTruongVM itemEmrCkQuaTrinhSinhTruong)
    {
        emrCkQuaTrinhSinhTruong emrCkQuaTrinhSinhTruong = new emrCkQuaTrinhSinhTruong();

        if (itemEmrCkQuaTrinhSinhTruong != null)
        {
            emrCkQuaTrinhSinhTruong.benhlykhac = CheckNull(itemEmrCkQuaTrinhSinhTruong.benhlykhac);// Hiện tại object này chỉ đang truyền có vậy
            emrCkQuaTrinhSinhTruong.cannangsinh = CheckNull(itemEmrCkQuaTrinhSinhTruong.cannangsinh);
            emrCkQuaTrinhSinhTruong.coditat = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.coditat);
            emrCkQuaTrinhSinhTruong.conthu = CheckNull(itemEmrCkQuaTrinhSinhTruong.conthu);
            emrCkQuaTrinhSinhTruong.dechihuy = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.dechihuy);
            emrCkQuaTrinhSinhTruong.dekhac = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.dekhac);
            emrCkQuaTrinhSinhTruong.denon = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.denon);
            emrCkQuaTrinhSinhTruong.dephauthuat = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.dephauthuat);
            emrCkQuaTrinhSinhTruong.dethuong = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.dethuong);
            emrCkQuaTrinhSinhTruong.duthang = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.duthang);
            emrCkQuaTrinhSinhTruong.forceps = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.forceps);
            emrCkQuaTrinhSinhTruong.giachut = CheckNullReturnTrueFalse(itemEmrCkQuaTrinhSinhTruong.giachut);
            emrCkQuaTrinhSinhTruong.honhop = GetLoaiNuoiDuong(itemEmrCkQuaTrinhSinhTruong.honhop, "honhop");
            emrCkQuaTrinhSinhTruong.motaditat = CheckNull(itemEmrCkQuaTrinhSinhTruong.motaditat);
            emrCkQuaTrinhSinhTruong.paraDenon = CheckNull(itemEmrCkQuaTrinhSinhTruong.paraDenon);
            emrCkQuaTrinhSinhTruong.paraDuthang = CheckNull(itemEmrCkQuaTrinhSinhTruong.paraDuthang);
            emrCkQuaTrinhSinhTruong.paraSay = CheckNull(itemEmrCkQuaTrinhSinhTruong.paraSay);
            emrCkQuaTrinhSinhTruong.paraSong = CheckNull(itemEmrCkQuaTrinhSinhTruong.paraSong);
            emrCkQuaTrinhSinhTruong.phattrientinhthan = CheckNull(itemEmrCkQuaTrinhSinhTruong.phattrientinhthan);
            emrCkQuaTrinhSinhTruong.phattrienvandong = CheckNull(itemEmrCkQuaTrinhSinhTruong.phattrienvandong);
            emrCkQuaTrinhSinhTruong.say = CheckNull(itemEmrCkQuaTrinhSinhTruong.say);
            emrCkQuaTrinhSinhTruong.song = CheckNull(itemEmrCkQuaTrinhSinhTruong.song);
            emrCkQuaTrinhSinhTruong.suagoai = GetLoaiNuoiDuong(itemEmrCkQuaTrinhSinhTruong.suagoai, "suagoai");
            emrCkQuaTrinhSinhTruong.suame = GetLoaiNuoiDuong(itemEmrCkQuaTrinhSinhTruong.suame, "suame");
            emrCkQuaTrinhSinhTruong.tainha = GetLoaiChamSoc(itemEmrCkQuaTrinhSinhTruong.tainha, "tainha");
            emrCkQuaTrinhSinhTruong.thangcaisua = CheckNull(itemEmrCkQuaTrinhSinhTruong.thangcaisua);
            emrCkQuaTrinhSinhTruong.vuontre = GetLoaiChamSoc(itemEmrCkQuaTrinhSinhTruong.vuontre, "vuontre");
        }
        return emrCkQuaTrinhSinhTruong;
    }

    private emrCkTinhTrangSanPhu getemrCkTinhTrangSanPhu(tbl_emrCkTinhTrangSanPhuVM itemEmrCkTinhTrangSanPhu)
    {
        emrCkTinhTrangSanPhu emrCkTinhTrangSanPhu = new emrCkTinhTrangSanPhu();


        if (itemEmrCkTinhTrangSanPhu != null)
        {
            emrCkTinhTrangSanPhu.benhcuame = CheckNull(itemEmrCkTinhTrangSanPhu.benhcuame);
            emrCkTinhTrangSanPhu.canthiep = CheckNullReturnTrueFalse(itemEmrCkTinhTrangSanPhu.canthiep);
            emrCkTinhTrangSanPhu.dethuong = CheckNullReturnTrueFalse(itemEmrCkTinhTrangSanPhu.dethuong);
            emrCkTinhTrangSanPhu.dieutribenhcuame = itemEmrCkTinhTrangSanPhu.dieutribenhcuame;
            emrCkTinhTrangSanPhu.huyetap = CheckNull(itemEmrCkTinhTrangSanPhu.huyetap);
            emrCkTinhTrangSanPhu.kiemsoattucung = CheckNull(itemEmrCkTinhTrangSanPhu.kiemsoattucung);
            emrCkTinhTrangSanPhu.lydo = CheckNull(itemEmrCkTinhTrangSanPhu.lydo);
            emrCkTinhTrangSanPhu.mach = CheckNull(itemEmrCkTinhTrangSanPhu.mach);
            emrCkTinhTrangSanPhu.mauoi = CheckNull(itemEmrCkTinhTrangSanPhu.mauoi);
            emrCkTinhTrangSanPhu.meNoinam = CheckNull(itemEmrCkTinhTrangSanPhu.meNoinam);
            emrCkTinhTrangSanPhu.meSogiuong = CheckNull(itemEmrCkTinhTrangSanPhu.meSogiuong);
            emrCkTinhTrangSanPhu.motacachde = CheckNull(itemEmrCkTinhTrangSanPhu.motacachde);
            emrCkTinhTrangSanPhu.motakiemsoattucung = CheckNull(itemEmrCkTinhTrangSanPhu.motakiemsoattucung);
            emrCkTinhTrangSanPhu.ngaycanthiep = toDateFormat(itemEmrCkTinhTrangSanPhu.ngaycanthiep);
            emrCkTinhTrangSanPhu.ngayvooi = toDateFormat(itemEmrCkTinhTrangSanPhu.ngayvooi);
            emrCkTinhTrangSanPhu.ngoithai = CheckNull(itemEmrCkTinhTrangSanPhu.ngoithai);
            emrCkTinhTrangSanPhu.nhietdo = formatNhietDo(itemEmrCkTinhTrangSanPhu.nhietdo);
            emrCkTinhTrangSanPhu.nhommau = CheckNull(itemEmrCkTinhTrangSanPhu.nhommau);
            emrCkTinhTrangSanPhu.paraDenon = CheckNull(itemEmrCkTinhTrangSanPhu.paraDenon);
            emrCkTinhTrangSanPhu.paraDuthang = CheckNull(itemEmrCkTinhTrangSanPhu.paraDuthang);
            emrCkTinhTrangSanPhu.paraSay = CheckNull(itemEmrCkTinhTrangSanPhu.paraSay);
            emrCkTinhTrangSanPhu.paraSong = CheckNull(itemEmrCkTinhTrangSanPhu.paraSong);
            emrCkTinhTrangSanPhu.sobenhanme = CheckNull(itemEmrCkTinhTrangSanPhu.sobenhanme);
            emrCkTinhTrangSanPhu.socon = CheckNull(itemEmrCkTinhTrangSanPhu.socon);
            emrCkTinhTrangSanPhu.thoidiemmode = toDateFormat(itemEmrCkTinhTrangSanPhu.thoidiemmode);
            emrCkTinhTrangSanPhu.thoidiemvaode = toDateFormat(itemEmrCkTinhTrangSanPhu.thoidiemvaode);
            emrCkTinhTrangSanPhu.toantrang = CheckNull(itemEmrCkTinhTrangSanPhu.toantrang);
        }
        return emrCkTinhTrangSanPhu;
    }

    private emrCkTienSuSanKhoa getemrCkTienSuSanKhoa(List<tbl_emrCkTienSuSanKhoaVM> listEmrCkTienSuSanKhoa)
    {
        emrCkTienSuSanKhoa emrCkTienSuSanKhoa = new emrCkTienSuSanKhoa();

        if (listEmrCkTienSuSanKhoa.Count > 0)
        {
            var item = listEmrCkTienSuSanKhoa[0];
            if (item != null)
            {
                emrCkTienSuSanKhoa.cachde = item.Cachde;
                emrCkTienSuSanKhoa.dienbienthai = item.DienbienThai;
                emrCkTienSuSanKhoa.hausan = item.HauSan;
                emrCkTienSuSanKhoa.paraDenon = CheckNull(item.paraDenon); // sớm
                emrCkTienSuSanKhoa.paraDuthang = CheckNull(item.paraDuthang); // Sinh
                emrCkTienSuSanKhoa.paraSay = CheckNull(item.paraSay); // Sảy
                emrCkTienSuSanKhoa.paraSong = CheckNull(item.paraSong); // Sống
                emrCkTienSuSanKhoa.thoigiandiadiem = toDateFormat(item.ThoigianDiaDiem);
                // emrCkTienSuSanKhoa.solancothai = CheckNull(item.solancothai);
                emrCkTienSuSanKhoa.tresosinh = item.Tresosinh;
                emrCkTienSuSanKhoa.tuoithai = CheckNull(item.Tuoithai);
                emrCkTienSuSanKhoa.emrCkTienSuSanKhoaChiTiets = getemrCkTienSuSanKhoaChiTiets(listEmrCkTienSuSanKhoa);
            }
        }

        return emrCkTienSuSanKhoa;
    }

    private emrCkTienSuSanKhoaChiTiet[] getemrCkTienSuSanKhoaChiTiets(List<tbl_emrCkTienSuSanKhoaVM> listArray)
    {
        emrCkTienSuSanKhoa emrCkTienSuSanKhoa = new emrCkTienSuSanKhoa();
        List<emrCkTienSuSanKhoaChiTiet> list = new List<emrCkTienSuSanKhoaChiTiet>();
        foreach (var item in listArray)
        {
            emrCkTienSuSanKhoaChiTiet emrCkTienSuSanKhoaChiTiet = new emrCkTienSuSanKhoaChiTiet();
            emrCkTienSuSanKhoaChiTiet.ngayketthucthainghen = toDateFormat(item.ThoigianDiaDiem);
            emrCkTienSuSanKhoaChiTiet.tuoithai = CheckNull(item.Tuoithai);
            emrCkTienSuSanKhoaChiTiet.phuongphapde = item.Cachde;
            emrCkTienSuSanKhoaChiTiet.dienbien = item.DienbienThai;
            emrCkTienSuSanKhoaChiTiet.cannang = CheckNull(item.cannang);//
            emrCkTienSuSanKhoaChiTiet.hausan = item.HauSan;
            list.Add(emrCkTienSuSanKhoaChiTiet);
        }

        return list.ToArray();
    }

    private emrCkKhamSoSinh getemrCkKhamSoSinh(tbl_emrCkKhamSoSinhVM itemEmrCkKhamSoSinh)
    {
        emrCkKhamSoSinh emrCkKhamSoSinh = new emrCkKhamSoSinh();
        if (itemEmrCkKhamSoSinh != null)
        {
            emrCkKhamSoSinh.ditatbamsinh = CheckNullReturnTrueFalse(itemEmrCkKhamSoSinh.ditatbamsinh);
            emrCkKhamSoSinh.ditathaumon = CheckNullReturnTrueFalse(itemEmrCkKhamSoSinh.ditathaumon);
            emrCkKhamSoSinh.mausacda = CheckNull(itemEmrCkKhamSoSinh.mausacda);
            emrCkKhamSoSinh.motaditat = CheckNull(itemEmrCkKhamSoSinh.motaditat);
            emrCkKhamSoSinh.nhiptho = CheckNull(itemEmrCkKhamSoSinh.nhiptho);
            emrCkKhamSoSinh.nhiptim = CheckNull(itemEmrCkKhamSoSinh.nhiptim);
            emrCkKhamSoSinh.silverman = itemEmrCkKhamSoSinh.silverman;
            emrCkKhamSoSinh.tinhhinhsosinhvaokhoa = itemEmrCkKhamSoSinh.tinhhinhsosinhvaokhoa;
            emrCkKhamSoSinh.tinhtranghohap = itemEmrCkKhamSoSinh.tinhtranghohap;
            emrCkKhamSoSinh.tinhtrangtoanthan = itemEmrCkKhamSoSinh.tinhtrangtoanthan;
        }
        return emrCkKhamSoSinh;
    }

    private emrCkKhamPhuKhoa getemrCkKhamPhuKhoa(tbl_emrCkKhamPhuKhoaVM itemEmrCkKhamPhuKhoa)
    {
        emrCkKhamPhuKhoa emrCkKhamPhuKhoa = new emrCkKhamPhuKhoa();

        if (itemEmrCkKhamPhuKhoa != null)
        {
            emrCkKhamPhuKhoa.amdao = itemEmrCkKhamPhuKhoa.amdao;
            emrCkKhamPhuKhoa.amho = itemEmrCkKhamPhuKhoa.amho;
            emrCkKhamPhuKhoa.amvat = itemEmrCkKhamPhuKhoa.amvat;
            emrCkKhamPhuKhoa.cactuicung = itemEmrCkKhamPhuKhoa.cactuicung;
            emrCkKhamPhuKhoa.cotucung = itemEmrCkKhamPhuKhoa.cotucung;
            emrCkKhamPhuKhoa.dauhieusinhducthuphat = itemEmrCkKhamPhuKhoa.dauhieusinhducthuphat;
            emrCkKhamPhuKhoa.mangtrinh = itemEmrCkKhamPhuKhoa.mangtrinh;
            emrCkKhamPhuKhoa.moibe = itemEmrCkKhamPhuKhoa.moibe;
            emrCkKhamPhuKhoa.moilon = itemEmrCkKhamPhuKhoa.moilon;
            emrCkKhamPhuKhoa.phanphu = itemEmrCkKhamPhuKhoa.phanphu;
            emrCkKhamPhuKhoa.tangsinhmon = itemEmrCkKhamPhuKhoa.tangsinhmon;
            emrCkKhamPhuKhoa.thantucung = itemEmrCkKhamPhuKhoa.thantucung;

            emrCkKhamPhuKhoa.thongtinkhac = itemEmrCkKhamPhuKhoa.thongtinkhac;
        }
        return emrCkKhamPhuKhoa;
    }

    private emrCkKhamSanKhoa getemrCkKhamSanKhoa(tbl_emrCkKhamSanKhoaVM itemEmrCkKhamSanKhoa)
    {
        emrCkKhamSanKhoa emrCkKhamSanKhoa = new emrCkKhamSanKhoa();
        if (itemEmrCkKhamSanKhoa != null)
        {
            emrCkKhamSanKhoa.amdao = itemEmrCkKhamSanKhoa.AmDao;
            emrCkKhamSanKhoa.amho = itemEmrCkKhamSanKhoa.AmHo;
            emrCkKhamSanKhoa.bamoi = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.bamoi);
            emrCkKhamSanKhoa.bamoiluc = toDateFormat(itemEmrCkKhamSanKhoa.bamoiluc);
            emrCkKhamSanKhoa.bishop = itemEmrCkKhamSanKhoa.Bishop;
            emrCkKhamSanKhoa.chieucaotc = CheckNull(itemEmrCkKhamSanKhoa.chieucaotc);
            emrCkKhamSanKhoa.chuyendaluc = toDateFormat(itemEmrCkKhamSanKhoa.chuyendaluc);
            emrCkKhamSanKhoa.concotc = itemEmrCkKhamSanKhoa.concotc;
            emrCkKhamSanKhoa.ctcdangxoa = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.ctcdangxoa);
            emrCkKhamSanKhoa.ctcdongkin = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.ctcdongkin);
            emrCkKhamSanKhoa.ctcmo = CheckNull(itemEmrCkKhamSanKhoa.ctcmo);
            emrCkKhamSanKhoa.dauhieusaudo = itemEmrCkKhamSanKhoa.dauhieusaudo;
            emrCkKhamSanKhoa.dauoi = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.DauOi);
            emrCkKhamSanKhoa.dauvetmo = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.DauVetMo);
            emrCkKhamSanKhoa.dbodeloque = CheckNull(itemEmrCkKhamSanKhoa.dbodeloque);
            emrCkKhamSanKhoa.dluonggai = CheckNull(itemEmrCkKhamSanKhoa.dluonggai);
            emrCkKhamSanKhoa.dluongmao = CheckNull(itemEmrCkKhamSanKhoa.dluongmao);
            emrCkKhamSanKhoa.dluongmau = CheckNull(itemEmrCkKhamSanKhoa.dluongmau);
            emrCkKhamSanKhoa.dluongungoi = CheckNull(itemEmrCkKhamSanKhoa.dluongungoi);
            emrCkKhamSanKhoa.dnhohauve = CheckNull(itemEmrCkKhamSanKhoa.dnhohauve);
            emrCkKhamSanKhoa.dolot = CheckNull(itemEmrCkKhamSanKhoa.DoLot);
            emrCkKhamSanKhoa.hinhdangtc = CheckNull(itemEmrCkKhamSanKhoa.hinhdangtc);
            emrCkKhamSanKhoa.khamthaitai = CheckNull(itemEmrCkKhamSanKhoa.khamthaitai);
            emrCkKhamSanKhoa.khungchau = CheckNull(itemEmrCkKhamSanKhoa.khungchau);
            emrCkKhamSanKhoa.kieuthe = CheckNull(itemEmrCkKhamSanKhoa.kieuthe);
            emrCkKhamSanKhoa.kykinhcuoidenngay = toDateFormat(itemEmrCkKhamSanKhoa.kykinhcuoidenngay);
            emrCkKhamSanKhoa.kykinhcuoitungay = toDateFormat(itemEmrCkKhamSanKhoa.kykinhcuoitungay);
            emrCkKhamSanKhoa.mauoi = CheckNull(itemEmrCkKhamSanKhoa.mauoi);
            emrCkKhamSanKhoa.motau = itemEmrCkKhamSanKhoa.motau;
            emrCkKhamSanKhoa.muiuonvanthu = CheckNull(itemEmrCkKhamSanKhoa.muiuonvanthu); // Kiểu int
            emrCkKhamSanKhoa.ngoi = itemEmrCkKhamSanKhoa.ngoi;
            emrCkKhamSanKhoa.ngoithai = itemEmrCkKhamSanKhoa.NgoiThai;
            emrCkKhamSanKhoa.nuocoi = itemEmrCkKhamSanKhoa.nuocoi;
            emrCkKhamSanKhoa.phanphu = itemEmrCkKhamSanKhoa.phanphu;
            emrCkKhamSanKhoa.phonguonvan = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.phonguonvan);
            emrCkKhamSanKhoa.seomocu = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.seomocu);
            emrCkKhamSanKhoa.tangsinhmon = itemEmrCkKhamSanKhoa.TangSinhMon;
            emrCkKhamSanKhoa.tenbo = itemEmrCkKhamSanKhoa.tenbo;
            emrCkKhamSanKhoa.tencondukien = itemEmrCkKhamSanKhoa.tencondukien;
            emrCkKhamSanKhoa.tengai = itemEmrCkKhamSanKhoa.TenConTrai;
            emrCkKhamSanKhoa.tentrai = itemEmrCkKhamSanKhoa.TenConGai;
            emrCkKhamSanKhoa.the = itemEmrCkKhamSanKhoa.The;
            emrCkKhamSanKhoa.timthai = CheckNull(itemEmrCkKhamSanKhoa.TimThai);
            emrCkKhamSanKhoa.trieuchungbandau = itemEmrCkKhamSanKhoa.trieuchungbandau;
            emrCkKhamSanKhoa.tuoithai = CheckNull(itemEmrCkKhamSanKhoa.TuoiThai);
            emrCkKhamSanKhoa.tuthetc = itemEmrCkKhamSanKhoa.tuthetc;
            emrCkKhamSanKhoa.utiendao = CheckNullReturnTrueFalse(itemEmrCkKhamSanKhoa.utiendao);
            emrCkKhamSanKhoa.vongbung = itemEmrCkKhamSanKhoa.VongBung;
            emrCkKhamSanKhoa.vu = itemEmrCkKhamSanKhoa.Vu;
        }
        return emrCkKhamSanKhoa;
    }

    private emrCkTamThan getemrCkTamThan(tbl_emrCkTamThanVM itemEmrCkTamThan)
    {
        emrCkTamThan emrCkTamThan = new emrCkTamThan();

        if (itemEmrCkTamThan != null)
        {
            emrCkTamThan.bieuhienchung = itemEmrCkTamThan.bieuhienchung;
            emrCkTamThan.camxuc = itemEmrCkTamThan.camxuc;
            emrCkTamThan.dinhhuongbanthan = itemEmrCkTamThan.dinhhuongbanthan;
            emrCkTamThan.dinhhuongkhonggian = itemEmrCkTamThan.dinhhuongkhonggian;
            emrCkTamThan.dinhhuongthoigian = itemEmrCkTamThan.dinhhuongthoigian;
            emrCkTamThan.hoatdongbannang = itemEmrCkTamThan.hoatdongbannang;
            emrCkTamThan.hoatdongcoychi = itemEmrCkTamThan.hoatdongcoychi;
            emrCkTamThan.khanangchuy = itemEmrCkTamThan.khanangchuy;
            emrCkTamThan.trigiac = itemEmrCkTamThan.trigiac;
            emrCkTamThan.trinangphantich = itemEmrCkTamThan.trinangphantich;
            emrCkTamThan.trinangtonghop = itemEmrCkTamThan.trinangtonghop;
            emrCkTamThan.trinhomaymoc = itemEmrCkTamThan.trinhomaymoc;
            emrCkTamThan.trinhothonghieu = itemEmrCkTamThan.trinhothonghieu;
            emrCkTamThan.tuduyhinhthuc = itemEmrCkTamThan.tuduyhinhthuc;
            emrCkTamThan.tuduynoidung = itemEmrCkTamThan.tuduynoidung;
        }
        return emrCkTamThan;
    }

    private emrCkThanKinh getemrCkThanKinh(tbl_emrCkThanKinhVM itemEmrCkThanKinh)
    {
        emrCkThanKinh emrCkThanKinh = new emrCkThanKinh();
        if (itemEmrCkThanKinh != null)
        {
            emrCkThanKinh.camgiac = itemEmrCkThanKinh.camgiac;
            emrCkThanKinh.coguong = itemEmrCkThanKinh.coguong;
            emrCkThanKinh.daymat = itemEmrCkThanKinh.daymat;
            emrCkThanKinh.daythankinhsonao = itemEmrCkThanKinh.daythankinhsonao;
            emrCkThanKinh.giatminhluckham = itemEmrCkThanKinh.giatminhluckham;
            emrCkThanKinh.kichthuocDongtu = itemEmrCkThanKinh.kichthuocDongtu;
            emrCkThanKinh.le = itemEmrCkThanKinh.le;
            emrCkThanKinh.lietthankinhso = itemEmrCkThanKinh.lietthankinhso;
            emrCkThanKinh.nguga = itemEmrCkThanKinh.nguga;
            emrCkThanKinh.phanxa = itemEmrCkThanKinh.phanxa;
            emrCkThanKinh.phanxaAnhsang = itemEmrCkThanKinh.phanxaAnhsang;
            emrCkThanKinh.roiloanchucnang = itemEmrCkThanKinh.roiloanchucnang;
            emrCkThanKinh.thatdieu = itemEmrCkThanKinh.thatdieu;
            emrCkThanKinh.truonglucco = itemEmrCkThanKinh.truonglucco;

            emrCkThanKinh.vandong = itemEmrCkThanKinh.vandong;
            emrCkThanKinh.yeuchi = itemEmrCkThanKinh.yeuchi;
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

    private emrCkMat getemrCkMat(tbl_emrCkMatVM itemEmrCkMat)
    {
        emrCkMat emrCkMat = new emrCkMat();
        if (itemEmrCkMat != null)
        {
            emrCkMat.chaynuocmatphai = itemEmrCkMat.chaynuocmatphai;
            emrCkMat.chaynuocmattrai = itemEmrCkMat.chaynuocmattrai;
            emrCkMat.choimatphai = itemEmrCkMat.choimatphai;
            emrCkMat.choimattrai = itemEmrCkMat.choimattrai;
            emrCkMat.cungmacmatphai = itemEmrCkMat.cungmacmatphai;
            emrCkMat.cungmacmattrai = itemEmrCkMat.cungmacmattrai;
            emrCkMat.daymatphai = itemEmrCkMat.daymatphai;
            emrCkMat.dichkinhmatphai = itemEmrCkMat.dichkinhmatphai;
            emrCkMat.dichkinhmattrai = itemEmrCkMat.dichkinhmattrai;
            emrCkMat.dongtumatphai = itemEmrCkMat.dongtumatphai;
            emrCkMat.dongtumattrai = itemEmrCkMat.dongtumattrai;
            emrCkMat.giaccungmacmatphai = itemEmrCkMat.giaccungmacmatphai;
            emrCkMat.giaccungmacmattrai = itemEmrCkMat.giaccungmacmattrai;
            emrCkMat.goctienphongmatphai = itemEmrCkMat.goctienphongmatphai;
            emrCkMat.goctienphongmattrai = itemEmrCkMat.goctienphongmattrai;
            emrCkMat.homatphai = itemEmrCkMat.homatphai;
            emrCkMat.homattrai = itemEmrCkMat.homattrai;
            emrCkMat.ketmacmatphai = itemEmrCkMat.ketmacmatphai;
            emrCkMat.ketmacmattrai = itemEmrCkMat.ketmacmattrai;
            emrCkMat.ledaophai = itemEmrCkMat.ledaophai;
            emrCkMat.ledaotrai = itemEmrCkMat.ledaotrai;
            emrCkMat.mathoiphai = itemEmrCkMat.mathoiphai;
            emrCkMat.mathoitrai = itemEmrCkMat.mathoitrai;
            emrCkMat.mimatphai = itemEmrCkMat.mimatphai;
            emrCkMat.mimattrai = itemEmrCkMat.mimattrai;
            emrCkMat.momatphai = itemEmrCkMat.momatphai;
            emrCkMat.momattrai = itemEmrCkMat.momattrai;
            emrCkMat.mongmatphai = itemEmrCkMat.mongmatphai;
            emrCkMat.mongmattrai = itemEmrCkMat.mongmattrai;
            emrCkMat.nhanapphai = itemEmrCkMat.nhanapphai;
            emrCkMat.nhanaptrai = itemEmrCkMat.nhanaptrai;
            emrCkMat.nhancaumatphai = itemEmrCkMat.nhancaumatphai;
            emrCkMat.nhancaumattrai = itemEmrCkMat.nhancaumattrai;
            emrCkMat.rucmatphai = itemEmrCkMat.rucmatphai;
            emrCkMat.rucmattrai = itemEmrCkMat.rucmattrai;
            emrCkMat.soisangdongtumatphai = itemEmrCkMat.soisangdongtumatphai;
            emrCkMat.soisangdongtumattrai = itemEmrCkMat.sosangmattrai;
            emrCkMat.sosangmatphai = itemEmrCkMat.sosangmatphai;
            emrCkMat.sosangmattrai = itemEmrCkMat.sosangmattrai;
            emrCkMat.thethuytinhmatphai = itemEmrCkMat.thethuytinhmatphai;
            emrCkMat.thethuytinhmattrai = itemEmrCkMat.thethuytinhmattrai;
            emrCkMat.thiluccokinhphai = itemEmrCkMat.thiluccokinhphai;
            emrCkMat.thiluccokinhtrai = itemEmrCkMat.thiluccokinhtrai;
            emrCkMat.thiluckhongkinhphai = itemEmrCkMat.thiluckhongkinhphai;
            emrCkMat.thiluckhongkinhtrai = itemEmrCkMat.thiluckhongkinhtrai;
            emrCkMat.thitruongphai = itemEmrCkMat.thitruongphai;
            emrCkMat.thitruongtrai = itemEmrCkMat.thitruongtrai;
            emrCkMat.tienphongmatphai = itemEmrCkMat.tienphongmatphai;
            emrCkMat.tienphongmattrai = itemEmrCkMat.tienphongmattrai;
            emrCkMat.trieuchungmatphai = itemEmrCkMat.trieuchungmatphai;
            emrCkMat.trieuchungmattrai = itemEmrCkMat.trieuchungmattrai;
            emrCkMat.vannhanmatphai = itemEmrCkMat.vannhanmatphai;
            emrCkMat.vannhanmattrai = itemEmrCkMat.vannhanmattrai;
        }
        return emrCkMat;
    }

    #endregion Lấy thông tin chuyên khoa mắt cho bệnh án mắt

    #endregion Trả về object DanhSachHSBA

    #region Bệnh án Nha Bạ

    private emrYhctNhaBa getemrYhctNhaBa(tbl_emrYhctNhaBaVM item)
    {
        emrYhctNhaBa yhctNhaBa = new emrYhctNhaBa();
        if (item != null)
        {
            yhctNhaBa.chandoan_nhaba = item.chandoan_nhaba;
            yhctNhaBa.ngaybatdauchua_nhaba = toDateFormat(item.ngaybatdauchua_nhaba);
            yhctNhaBa.tenbacsichua_nhaba = item.tenbacsichua_nhaba;
        }
        return yhctNhaBa;
    }

    private emrYhctNhaBaGhiChu[] getemrYhctNhaBaGhiChus(List<tbl_emrYhctNhaBaGhiChuVM> listGhiChu)
    {
        List<emrYhctNhaBaGhiChu> list = new List<emrYhctNhaBaGhiChu>();
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

    #endregion Bệnh án Nha Bạ

    #region Bệnh án YHCT

    private emrYhctBenhAn getemrYhctBenhAn(tbl_emrYhctBenhAnVM item, tbl_emrYhctBenhanThietChanVM emrThietChan, tbl_emrYhctBenhanVaanChanVM emrVaanChan, tbl_emrYhctBenhanVawnChanVM emrVawnChan, tbl_emrYhctBenhanVongChanVM emrVongCHan)
    {
        emrYhctBenhAn emrYhctBenhAn = new emrYhctBenhAn();


        if (item != null)
        {
            emrYhctBenhAn.dieutriKethopyhhd = CheckNull(item.dieutriKethopyhhd);
            emrYhctBenhAn.dieutriXoabopbamhuyet = item.dieutriXoabopbamhuyet;
            emrYhctBenhAn.lstchedodinhduong = item.lstchedodinhduong;//, "DM86");
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
            emrYhctBenhAn.emrYhctBenhanThietChan = getemrYhctBenhanThietChan(emrThietChan);
            emrYhctBenhAn.emrYhctBenhanVaanChan = getemrYhctBenhanVaanChan(emrVaanChan);
            emrYhctBenhAn.emrYhctBenhanVawnChan = getemrYhctBenhanVawnChan(emrVawnChan);
            emrYhctBenhAn.emrYhctBenhanVongChan = getemrYhctBenhanVongChan(emrVongCHan);
        }
        return emrYhctBenhAn;
    }

    #endregion Bệnh án YHCT

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

    #endregion Lấy byte file

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

    #endregion get Tên file
}