using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;
using System.Globalization;
using DonThuocDT;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string portcndt = "http://beta.donthuocquocgia.vn/";
        string portdn = "http://api-beta.donthuocquocgia.vn";
        string userdn = "0140618";
        string passdn = "Z7DgeuqQ8O";
        DTDTAPI dt = new DTDTAPI();
        string logintoken = dt.dangnhapCoSoKCB(portdn,userdn,passdn);
     
        string userbs = "011622BP-CCHN";
        string passbs = "Fuv1R0LWlk";
        string tokenthembs = logintoken;
        string ThemBS = dt.themBS(portdn, userbs,tokenthembs );

        
        //string xoaBS = dt.xoaBS(portdn,userbs,tokenbs);
        string signbacsi = dt.dangnhapBS(portdn, userbs, passbs, userdn);
        string tokenbacsi = signbacsi;

        String madonthuoc = "40618R001935-c";
        


        // gui don thuoc
        donthuoc DT = new donthuoc();
        DT.loai_don_thuoc = "c";
        DT.ma_don_thuoc = madonthuoc;
        DT.ho_ten_benh_nhan = "Nguyen Van A";
        DT.ma_dinh_danh_y_te = "1234567899";
        DT.ma_dinh_danh_cong_dan = "111112345111";
        DT.ngay_sinh_benh_nhan = "01/01/1999";
        DT.can_nang = 55;
        DT.gioi_tinh = "2";
        DT.ma_so_the_bao_hiem_y_te = "wew323131e";
        DT.thong_tin_nguoi_giam_ho = "Nguyen Van B";
        DT.dia_chi = "Ha Noi";

        List<chandoan> lo = new List<chandoan>();
        chandoan lol = new chandoan();
        lol.ma_chan_doan = " 1232";
        lol.ten_chan_doan = " om nhe ";
        lol.ket_luan = " khong sao";
        lo.Add(lol);
        
        DT.chan_doan = lo;

        DT.luu_y = "an uong day du";
        DT.hinh_thuc_dieu_tri = "1";

        List<dot_dung_thuoc> la = new List<dot_dung_thuoc>();
        dot_dung_thuoc lal= new dot_dung_thuoc();
        lal.dot = 5;
        lal.tu_ngay = "2021-05-4";
        lal.den_ngay = "2021-06-3";
        lal.so_thang_thuoc = 0;
        
        la.Add(lal);
        DT.dot_dung_thuoc = la;

        List<thongtindonthuoc> li = new List<thongtindonthuoc>();
        thongtindonthuoc lil = new thongtindonthuoc();
        lil.ma_thuoc = "taotau";
        lil.biet_duoc = "tao tau";
        lil.ten_thuoc = " thuoc bo";
        lil.don_vi_tinh = "can";
        lil.so_luong = 3;
        lil.cach_dung = "an , uong";
        
        li.Add(lil);
        DT.thong_tin_don_thuoc = li;

        DT.loi_dan = "an uong day du , tap the duc ";
        DT.so_dien_thoai_nguoi_kham_benh = "231231312";
        DT.ngay_tai_kham = 14;
        DT.ngay_gio_ke_don = "2018-01-03 06:02:00";
        DT.signature = "23131dsad";

         //string donthuoc = dt.Gui_don_thuoc(portdn, tokenbacsi, DT ); // gui don thuoc

        


        string appname = "HTTest";
        string appkey = "zegWYYek3L4oVuWXJ3LJAiSVJ5e4rlbvTxqRWfRWlmz3sPX9m0MHoKjPzaJv";

        donthuocget laydonthuoc = dt.laydonthuoc(portcndt, madonthuoc, appname , appkey); // lay don thuoc

        donthuocUpdate DTUP = new donthuocUpdate();

        DTUP.ma_don_thuoc = madonthuoc;
        List<thongtinthuoc> aa = new List<thongtinthuoc>();
        thongtinthuoc aaa = new thongtinthuoc();
        aaa.ma_thuoc_da_ke_don = "123213123";
        aaa.ma_thuoc = "324434";
        aaa.biet_duoc = "taotau";
        aaa.ten_thuoc = "thuoc ho";
        aaa.so_luong = 2;
        aaa.don_vi_tinh = "can";
        aaa.cach_dung = "uong";
        aaa.so_luong_ban = 2;

        aa.Add(aaa);

        DTUP.thong_tin_thuoc = aa;

        DTUP.ma_dinh_danh_co_so_cung_ung_thuoc = "547547";
        DTUP.ten_co_so_cung_ung_thuoc = "sdadadasd";
        DTUP.so_dien_thoai_co_so_cung_ung_thuoc = "123456789987";
        DTUP.dia_chi_co_so_cung_ung_thuoc = "ha noi";
        DTUP.ma_hoa_don = "sdaa1231";


        string capnhatdonthuoc = dt.capnhatdonthuoc(portcndt, appname, appkey, DTUP);// cap nhat don thuoc





    }


    
}