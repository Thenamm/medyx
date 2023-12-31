 //using System.Windows.Forms;
using System.Transactions;

namespace HTC
{
    public class ShareVariables
    {

        //#region "Keys"

        //public static readonly Keys SaveKey = Keys.F2;
        //public static readonly Keys FindKey = Keys.F3;
        //public static readonly Keys EditKey = Keys.F4;
        //public static readonly Keys FilterKey = Keys.F6;
        //public static readonly Keys DeleteKey = Keys.F8;
        //public static readonly Keys PrintKey = Keys.F9;
        //public static readonly Keys ExitKey = Keys.F10;
        //public static readonly Keys AddKey = Keys.F12;
        //public static readonly Keys CancelKey = Keys.Escape;
        //public static readonly Keys ConfirmKey = Keys.Enter;
        //#endregion

        //#region "Dialog Result"
        //public static readonly System.Windows.Forms.DialogResult ResultOK = System.Windows.Forms.DialogResult.OK;
        //public static readonly System.Windows.Forms.DialogResult ResultCancel = System.Windows.Forms.DialogResult.Cancel;
        //public static readonly System.Windows.Forms.DialogResult ResultInsert = System.Windows.Forms.DialogResult.Yes;
        
        //#endregion


        public enum WorkflowParameter
        {
            InitWorkflowName = 0,
            CheckPermission = 1,
            AssignPermission = 2,
            Run = 3
        };

        // Khai bao kieu ha`m Update
        public delegate object UpdateFunction(string param);
        // khai bao them cac bien dung chung
        public enum KieuFormChiTiet: int
        {
            fXem = 0,
            fThem = 1,
            fSua = 2,
            fDelete = 3,
            fNotDelete = 8,

            fNotAccess = -1
        }
         


        public static KieuFormChiTiet Pub_bQuyenForm;

        public static string pub_sMaMay = System.Environment.MachineName;
        public static string pub_sNguoiSD = "";
        public static string pub_sQuay = "";
        public static string pub_sMakhoa = "20";

        public static bool pub_bQadmin = false ;
        //public static bool pub_bSgia = false;
        //public static string pub_sAccount = "";
        public static string pub_sDaiDien = "";
        ///*      Phụ sản */
        //public static string pub_spC = "PS";
        //public static string pub_sTenBV = "BỆNH VIỆN PHỤ SẢN TRUNG ƯƠNG";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "BỘ Y TẾ";
        //public static string pub_sDiaChiBV = "43 Tràng Thi-Hà Nội";
        //public static string pub_sDiaChiBV087 = "56 Hai Bà Trưng- Hà Nội";
        //public static string pub_sTenPK091 = "NHÀ THUỐC 43 TRÀNG THI";
        //public static string pub_sTenPK092 = "NHÀ THUỐC 56 HAI BÀ TRƯNG";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "003";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "";
        //public static string pub_sMaBHXH = "01905";
        //public static string pub_sTenBVBHXH = "";
        //public static string pub_sTenPK = "KHOA KHÁM BỆNH THEO YÊU CẦU";
        //public static string pub_sDienThoai = "04.39394556";
        //public static string pub_sDienThoai087 = "04.39364656";
        //public static string pub_sMaTinh = "00001";
        //public static string pub_sTenTinh = "Hà Nội";
        //public static string pub_sMaKhoa087 = "018";

        /////* huyết học truyền máu*/ 
        //public static string pub_spC = "HH";
        //public static string pub_sTenBV = "VIỆN HUYẾT HỌC - TRUYỀN MÁU TW";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "BỘ Y TẾ";
        //public static string pub_sDiaChiBV = "14 Trần Thái Tông-Cầu Giấy-Hà Nội";
        //public static string pub_sDiaChiBV087 = "14 Trần Thái Tông-Cầu Giấy-Hà Nội";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "003";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "00376";
        //public static string pub_sMaBHXH = "";
        //public static string pub_sTenBVBHXH = "Viện huyết học - truyền máu TW";
        //public static string pub_sTenPK = "KHOA KHÁM BẸNH THEO YÊU CẦU";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sDienThoai = "043.8685582";
        //public static string pub_sDienThoai087 = "043.8685582";
        //public static string pub_sMaTinh = "00001";
        //public static string pub_sTenTinh = "Hà Nội";
        //public static string pub_sMaKhoa087 = "018";

        /////* QUANG NINH*/
        //public static string pub_spC = "QN";
        //public static string pub_sTenBV = "BỆNH VIỆN Y DƯỢC CỔ TRUYỀN";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "SỞ Y TẾ QUẢNG NINH";
        //public static string pub_sDiaChiBV = "Cột 8, Phường Hồng Hà, Thành Phố Hạ Long, Tỉnh Quảng Ninh";
        //public static string pub_sDiaChiBV087 = "Cột 8, Phường Hồng Hà, Thành Phố Hạ Long, Tỉnh Quảng Ninh";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "206";
        //public static string pub_sMaKX092 = "206";
        //public static string pub_sMaBV = "02772";
        //public static string pub_sMaBHXH = "22046";
        //public static string pub_sTenBVBHXH = "BỆNH VIỆN Y HỌC CỔ TRUYỀN";
        //public static string pub_sTenPK = "";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sDienThoai = "0203 3 838112";
        //public static string pub_sDienThoai087 = "0203 3 838112";
        //public static string pub_sMaTinh = "00022";
        //public static string pub_sTenTinh = "Quảng Ninh";
        //public static string pub_sMaKhoa087 = "018";

        ///////* MUONG KHUONG*/
        public static string pub_spC = "QN";
        public static string pub_sTenBV = "BỆNH VIỆN ĐA KHOA MƯỜNG KHƯƠNG";
        public static string pub_loaiDT = "";
        public static string pub_sTenDVChuQuan = "SỞ Y TẾ LÀO CAI";
        public static string pub_sDiaChiBV = "Số nhà 429 đường Giải Phóng – TT Mường Khương – H.Mường Khương – Lào Cai";
        public static string pub_sDiaChiBV087 = "Số nhà 429 đường Giải Phóng – TT Mường Khương – H.Mường Khương – Lào Cai";
        public static string pub_sMaSoThue = "5300376806";
        public static string pub_sMaKX091 = "206";
        public static string pub_sMaKX092 = "206";
        public static string pub_sMaBV = "10006";
        public static string pub_sMaBHXH = "10006";
        public static string pub_sTenBVBHXH = "";
        public static string pub_sTenPK = "";
        public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        public static string pub_sDienThoai = "0214 3891 333";
        public static string pub_sDienThoai087 = "02143 891 333";
        public static string pub_sMaTinh = "10";
        public static string pub_sTenTinh = "Lào Cai";
        public static string pub_sMaKhoa087 = "018";
      
        ///* hue*/
        //public static string pub_spC = "HU";
        //public static string pub_sTenBV = "BỆNH VIỆN TRUNG ƯƠNG HUẾ";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "BỘ Y TẾ";
        //public static string pub_sDiaChiBV = "16 Lê lợi-TP.Huế";
        //public static string pub_sDiaChiBV087 = "3 Ngô Quyền-TP.Huế";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "203";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "07941";
        //public static string pub_sMaBHXH = "46001";
        //public static string pub_sTenBVBHXH = "Bệnh viện Trung ương Huế";
        //public static string pub_sTenPK = "TT ĐIỀU TRỊ THEO YÊU CẦU VÀ QUỐC TẾ";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sDienThoai = "054.3822325";
        //public static string pub_sDienThoai087 = "054.38908888";
        //public static string pub_sMaTinh = "00031";
        //public static string pub_sTenTinh = "Thừa Thiên Huế";
        //public static string pub_sMaKhoa087 = "018";

        ///* hue 2*/ 
        //public static string pub_spC = "HU";
        //public static string pub_sTenBV = "BỆNH VIỆN TRUNG ƯƠNG HUẾ - CƠ SỞ 2";
        ////  public static string pub_sTenBV = "CÔNG TY TNHH HÀ THẮNG";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "";
        ////public static string pub_sTenDVChuQuan = "BỆNH VIỆN TRUNG ƯƠNG HUẾ";
        //// public static string pub_sTenBV = "CƠ SỞ 2";
        //public static string pub_sDiaChiBV = "Xã Phong An- Huyện Phong Điền-TP.Huế";
        //public static string pub_sDiaChiBV087 = "3 Ngô Quyền-TP.Huế";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "203";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "08135";
        //public static string pub_sMaBHXH = "46204";
        //public static string pub_sTenBVBHXH = "BỆNH VIỆN ĐA KHOA TỈNH TT HUẾ";
        //public static string pub_sTenPK = "TT ĐIỀU TRỊ THEO YÊU CẦU VÀ QUỐC TẾ";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sDienThoai = "054.3761761";
        //public static string pub_sDienThoai087 = "054.38908888";
        //public static string pub_sMaTinh = "00031";
        //public static string pub_sTenTinh = "Thừa Thiên Huế";
        //public static string pub_sMaKhoa087 = "018";

        ///* hue 1*/
        //public static string pub_spC = "HU";
        //public static string pub_sTenBV = "BỆNH VIỆN TRUNG ƯƠNG HUẾ ";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "BỘ Y TẾ";
        //public static string pub_sDiaChiBV = "16 Lê lợi-TP.Huế";
        //public static string pub_sDiaChiBV087 = "3 Ngô Quyền-TP.Huế";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "203";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "";
        //public static string pub_sMaBHXH = "46001";
        //public static string pub_sTenBVBHXH = "";
        //public static string pub_sTenPK = "";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sDienThoai = "054.3822325";
        //public static string pub_sDienThoai087 = "054.38908888";
        //public static string pub_sMaTinh = "00031";
        //public static string pub_sTenTinh = "Thừa Thiên Huế";
        //public static string pub_sMaKhoa087 = "018";

        ///* yhct*/
        //public static string pub_spC = "YH";
        //public static string pub_sTenBV = "BỆNH VIỆN Y HỌC CỔ TRUYỀN TW";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "BỘ Y TẾ";
        //public static string pub_sDiaChiBV = "29 NGUYỄN BỈNH KHIÊM";
        //public static string pub_sDiaChiBV087 = "27 NGUYỄN BỈNH KHIÊM";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "206";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "00035";
        //public static string pub_sMaBHXH = "01047";
        //public static string pub_sTenBVBHXH = "Bệnh viện YHCT Trung Ương";
        //public static string pub_sTenPK = "KHOA KHÁM BỆNH CHẤT LƯỢNG CAO";
        //public static string pub_sMaTinh = "00001";
        //public static string pub_sTenTinh = "Hà Nội";
        //public static string pub_sDienThoai = "054.3822325";
        //public static string pub_sDienThoai087 = "054.38908888";
        //public static string pub_sMaKhoa087 = "034";

        ///* phoi ha noi*/
        //public static string pub_spC = "PH";
        //public static string pub_sTenBV = "BỆNH VIỆN PHỔI HÀ NỘI";
        //public static string pub_loaiDT = "";
        //public static string pub_sTenDVChuQuan = "SỞ Y TẾ";
        //public static string pub_sDiaChiBV = "44 THANH NHÀN";
        //public static string pub_sDiaChiBV087 = "44 THANH NHÀN";
        //public static string pub_sTenPK091 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sTenPK092 = "NHÀ THUỐC BỆNH VIỆN";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaKX091 = "206";
        //public static string pub_sMaKX092 = "008";
        //public static string pub_sMaBV = "00285";
        //public static string pub_sMaBHXH = "01903";
        //public static string pub_sTenBVBHXH = "";
        //public static string pub_sTenPK = "KHOA KHÁM BỆNH";
        //public static string pub_sMaTinh = "00001";
        //public static string pub_sTenTinh = "Hà Nội";
        //public static string pub_sDienThoai = "38219062";
        //public static string pub_sDienThoai087 = "38219062";
        //public static string pub_sMaKhoa087 = "034";
        //////////////
        //public static string pub_sTenBV = "BỆNH VIỆN TIM HN";
        //public static string pub_sTenDVChuQuan = "SỞ Y TẾ";
        //          public static string pub_sDiaChiBV = "92 Trần Hưng Đạo";
        //public static string pub_sTenBV = "VIỆN YHCT QUÂN ĐỘI";
        //public static string pub_sTenDVChuQuan = "BỘ QUỐC PHÒNG";
        //public static string pub_loaiDT = "QD";
        //public static string pub_sDiaChiBV = "442 Kim giang-HM-HN";
        //public static string pub_sMaSoThue = "0101425792";
        //public static string pub_sMaBV = "";
        public static string pub_sTenNguoiSD = "";
        public static int  pub_igiasac = 0;
        public static string pub_SoHDBH = "";
        public static string pub_SoHDTT = "";
        public static string pub_SoHDSacBH = "";
        public static string pub_SoHDSacTT = "";
        public static System.DateTime NgayLV= System .DateTime .Now   ;
        public static string pub_sthongbao = "Thong bao";
        public static string pub_sTenMN = "";
        //public static string pub_sPrint = Localization.GetString("MAYIN");
        //public static string pub_sPrintBarCode = Localization.GetString("MAYINBARCODE");
        private static long pub_lMaxTime = 99999999999999999;
        public static System.TimeSpan ts = new System.TimeSpan(HTC.ShareVariables.pub_lMaxTime);
        public static string VAR_ITEMEXIST = "Không tồn tại thông tin";
        public static string VAR_DATA = "Dữ liệu sai";
        public static string VAR_STRINGREQUIRED = "Không đúng định dạng thông tin";
        public static string VAR_NUMBERREQUIRED = "Không đúng định dạng số ";
        public static string VAR_VALIDATION_NOW = "Ngày yêu cầu sai ";
        public static string VAR_NO_EXIST_RACE_CATALOG = "Không tồn tại thông tin";
        public static string VAR_ALL = "Tất cả";
       // public static HTC.Common.MessageBox mb;
        //private static extern uint GetUserDefaultLCID();
      
        //static extern bool SetLocaleInfo(uint Locale, uint LCType,
        //string lpLCData);
        //public const int LOCALE_SSHORTDATE = 0x1F;
        //public const int LOCALE_SDATE = 0x1D;

        ///// <summary>
        ///// Sets the short date.
        ///// </summary>
        ///// <param name="strShortDate">The STR short date.</param>
        //public static void SetShortDate(string strShortDate)
        //{
        //    uint lngLCID;
        //    lngLCID = GetUserDefaultLCID();
        //    SetLocaleInfo(lngLCID, LOCALE_SSHORTDATE, strShortDate);
        //    SetLocaleInfo(lngLCID, LOCALE_SDATE, "/");
        //}

    }
}