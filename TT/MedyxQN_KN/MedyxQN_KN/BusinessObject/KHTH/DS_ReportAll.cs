using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.KHTH
{
    public class DS_ReportAll
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

      
       /// <summary>
        /// BÁO CÁO TÌNH HÌNH PHẪU THUẬT - THỦ THUẬT
       /// </summary>
       /// <param name="tungay"></param>
       /// <param name="denngay"></param>
       /// <param name="noitt"></param>
       /// <param name="DK"></param>
       /// <returns></returns>
        public static DataSet CrBCTHPhauThuatThuThuat(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String DK)
        {
            //return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhpttt", tungay, denngay, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhpttt");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
         
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        
        }

        /// <summary>
        /// BÁO CÁO TÌNH HÌNH PHẪU THUẬT THEO CHUYÊN KHOA
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHPhauThuatChuyenKhoa(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String DK)
        {
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhpt_theochuyenkhoa", tungay, denngay, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhpt_theochuyenkhoa");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
          
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        //BÁO CÁO THỐNG KÊ TÌNH HÌNH SỬ DỤNG GIƯỜNG
        public static DataSet CrBCTHSuDungGiuong(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhoa, String DK)
        {
            //return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_thongke_sdgiuong", tungay, denngay, noitt, makhoa, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_thongke_sdgiuong");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
          
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        /// <summary>
        /// THỐNG KÊ NGÀY ĐIỀU TRỊ NỘI TRÚ TẠI CÁC KHOA
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="makhoa"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHNgayDieuTriNoiTruTaiCacKhoa(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhoa, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_ngaydtnoitru_khoa", tungay, denngay, noitt, makhoa, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_ngaydtnoitru_khoa");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
         
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        
        /// <summary>
        /// THỐNG KÊ TÌNH HÌNH BỆNH NHÂN NGOẠI TRÚ THEO ICD 10
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="maicd"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHBenhNhanNgoaiTruTheoICD10(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String maicd, String noitt, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhkb_theoicd", tungay, denngay, maicd, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
          
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhkb_theoicd");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
           
            cmd.Parameters.AddWithValue("maicd", maicd);
           
            cmd.Parameters.AddWithValue("maicd", maicd);
           
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// TÌNH HÌNH BỆNH NHÂN RA VIỆN
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="makhoa"></param>
        /// <param name="noitt"></param>
        /// <param name="matinh"></param>
        /// <param name="tuoi"></param>
        /// <param name="dtbn"></param>
        /// <param name="maicd"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHBenhNhanRaVien(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String makhoa, String noitt, String matinh, String tuoi, Nullable<Int32> tutuoi, Nullable<Int32> dentuoi, String dtbn, String maicd, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_bnxuatvien1c", tungay, denngay, makhoa, noitt, matinh, tuoi, tutuoi, dentuoi, dtbn, maicd, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_bnxuatvien1c");
            cmd.CommandTimeout = 18000;
            if (tutuoi == null)
                cmd.Parameters.AddWithValue("tutuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("tutuoi", tutuoi);

            if (dentuoi == null)
                cmd.Parameters.AddWithValue("dentuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dentuoi", dentuoi);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("matinh", matinh);
            cmd.Parameters.AddWithValue("maicd", maicd);
            cmd.Parameters.AddWithValue("tuoi", tuoi);
            
           
            cmd.Parameters.AddWithValue("dtbn", dtbn);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        
        /// <summary>
        /// TÌNH HÌNH BỆNH NHÂN VÀO VIỆN
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="maicd"></param>
        /// <param name="matinh"></param>
        /// <param name="mahuyen"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHBenhNhanVaoVien(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String maicd, String makhoa, String matinh, String mahuyen, String noitt,byte loai, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_bnnhapvien_bc1a", tungay, denngay, maicd, makhoa, matinh, mahuyen, noitt,loai, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_bnnhapvien_bc1a");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("matinh", matinh);
            cmd.Parameters.AddWithValue("maicd", maicd);
            cmd.Parameters.AddWithValue("mahuyen", mahuyen);
            cmd.Parameters.AddWithValue("loai", loai);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);


            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// DANH SÁCH BỆNH NHÂN HIỆN CÓ
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="MAKHOA"></param>
        /// <param name="DK"></param>
        /// <param name="noitt"></param>
        /// <returns></returns>
        public static DataSet CrBCTHBenhNhanHienCo(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String MAKHOA, String DK, String noitt)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_danhsachbnhienco", tungay, denngay, MAKHOA, DK, noitt);
            // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhtinhcapcuu", tungay, denngay, tutuoi, dentuoi, dk, noitt);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_danhsachbnhienco");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);

            cmd.Parameters.AddWithValue("makhoa", MAKHOA);
            cmd.Parameters.AddWithValue("noitt", noitt);
          

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }
        public static DataSet CRTinhHinhCC_H(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String tutuoi, String dentuoi, string dk , String noitt)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhtinhcapcuu", tungay, denngay, tutuoi, dentuoi, dk, noitt);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhtinhcapcuu");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);

           // cmd.Parameters.AddWithValue("tutuoi", tutuoi);
            cmd.Parameters.AddWithValue("noitt", noitt);
            //cmd.Parameters.AddWithValue("dentuoi", dentuoi);
            if (tutuoi == null)
                cmd.Parameters.AddWithValue("tutuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("tutuoi", tutuoi);

            if (dentuoi == null)
                cmd.Parameters.AddWithValue("dentuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dentuoi", dentuoi);
            cmd.Parameters.AddWithValue("DK", dk);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }
        public static DataSet CRTinhHinhtntt_H(Nullable<DateTime> tungay, Nullable<DateTime> denngay, string dk, String noitt)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinh_tntt", tungay, denngay, dk, noitt);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinh_tntt");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
        
            cmd.Parameters.AddWithValue("noitt", noitt);
           
            cmd.Parameters.AddWithValue("DK", dk);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }
        public static DataSet CRBCtinhhinhcc_tuoi_H(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String tutuoi, String dentuoi, string dk, String noitt)
        {
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhtinhcapcuu_tuoi", tungay, denngay, tutuoi, dentuoi, dk, noitt);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
            //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhtinhcapcuu_tuoi");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            //cmd.Parameters.AddWithValue("tutuoi", tutuoi);
            //cmd.Parameters.AddWithValue("noitt", noitt);
            //cmd.Parameters.AddWithValue("dentuoi", dentuoi);

            if (tutuoi == null)
                cmd.Parameters.AddWithValue("tutuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("tutuoi", tutuoi);

            if (dentuoi == null)
                cmd.Parameters.AddWithValue("dentuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dentuoi", dentuoi);
            cmd.Parameters.AddWithValue("noitt", noitt);
            cmd.Parameters.AddWithValue("DK", dk);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }
        /// <summary>
        /// TÌNH HÌNH ĐIỀU TRỊ BÊNH NHÂN NƯỚC NGOÀI
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="makhoa"></param>
        /// <param name="noitt"></param>
        /// <param name="maicd"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHDieuTriBenhNhanNuocNgoai(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String makhoa, String noitt, String maicd, String DK)
        {
             
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

           string _databaseOwner = "dbo.";
           string _objectQualifier = "";
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhdt_bnnn", tungay, denngay, makhoa, noitt, maicd, DK);
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhdt_bnnn");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);
            cmd.Parameters.AddWithValue("maicd", maicd);
            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
         
            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;
           
            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        /// <summary>
        /// BÁO CÁO TÌNH HÌNH KHÁM BỆNH
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="maicd"></param>
        /// <param name="matinh"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHTinhHinhKhamBenh(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String makhoa, String noitt, String DK)
        {
         //   return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhkb", tungay, denngay, makhoa, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";
           
            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhkb");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("noitt", noitt);
           
            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        /// <summary>
        /// TÌNH HÌNH KHÁM BỆNH THEO ĐỊA PHƯƠNG
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="maicd"></param>
        /// <param name="matinh"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>

        public static DataSet CrBCTHKhamBenhTheoDiaPhuong(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String matinh, String noitt, String DK)
        {
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhKBtheoDP", tungay, denngay, matinh, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhKBtheoDP");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("matinh", matinh);
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;


        }


        /// <summary>
        /// Báo Cáo Tổng Hợp Hoạt Động Cận Lâm Sàng
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="loai"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTTTHDCanLamSangTongHop(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String loai, String DK)
        {
         //   return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_hoatdongcls", tungay, denngay, noitt, loai, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_hoatdongcls");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("loai", loai);
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// Báo Cáo Chi Tiết Hoạt Động Cận Lâm Sàng
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="makhth"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTTTHDCanLamSangChiTiet(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhth, String DK)
        {
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_hoatdongcls_chitiet", tungay, denngay, noitt, makhth, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_hoatdongcls_chitiet");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhth", makhth);
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        /// <summary>
        /// Tình Hình Bệnh Tật Và Tử Vong Điều Trị Nội Trú
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="mabenhrv"></param>
        /// <param name="tutuoi"></param>
        /// <param name="dentuoi"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHBenhTatVaTuVongDieuTriNoiTru(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String mabenhrv, Nullable<Int32> Tutuoi, Nullable<Int32> DenTuoi, String noitt, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_tinhhinhbt_tuvong", tungay, denngay, mabenhrv, Tutuoi, DenTuoi, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_tinhhinhbt_tuvong");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("mabenhrv", mabenhrv);
            //cmd.Parameters.AddWithValue("Tutuoi", Tutuoi);
            //cmd.Parameters.AddWithValue("DenTuoi", DenTuoi);
            //cmd.Parameters.AddWithValue("noitt", noitt);
            if (Tutuoi == null)
                cmd.Parameters.AddWithValue("tutuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("tutuoi", Tutuoi);

            if (DenTuoi == null)
                cmd.Parameters.AddWithValue("dentuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dentuoi", DenTuoi);
            cmd.Parameters.AddWithValue("noitt", noitt);
            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// Báo Cáo Tình Hình Điều Trị Nội Trú Theo Địa Phương
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="matinh"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTHDTNoiTruTheoDiaPhuong(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String matinh, String noitt, String DK)
        {
            //return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_dieutrint_theodp", tungay, denngay, matinh, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_dieutrint_theodp");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("matinh", matinh);
            
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// Thống kê bệnh nhân điều trị nội trú theo địa phương
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="makhoa"></param>
        /// <param name="matinh"></param>
        /// <param name="tutuoi"></param>
        /// <param name="dentuoi"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTKBNDTNoiTruTheoDiaPhuong(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String makhoa, String matinh, Nullable<Decimal> tutuoi, Nullable<Decimal> dentuoi, String noitt, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_bnnoitru_dp_chitiet", tungay, denngay, makhoa, matinh, tutuoi, dentuoi, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_bnnoitru_dp_chitiet");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("matinh", matinh);
            //cmd.Parameters.AddWithValue("Tutuoi", tutuoi);
            //cmd.Parameters.AddWithValue("DenTuoi", dentuoi);
            //cmd.Parameters.AddWithValue("noitt", noitt);
            if (tutuoi == null)
                cmd.Parameters.AddWithValue("tutuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("tutuoi", tutuoi);

            if (dentuoi == null)
                cmd.Parameters.AddWithValue("dentuoi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dentuoi", dentuoi);
            cmd.Parameters.AddWithValue("noitt", noitt);
            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


        /// <summary>
        /// Danh sách thủ thuật thực hiện tại các khoa cận lâm sàng
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="makhoa"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTTTHTCacKhoaCLS(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhoa, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_thuthuat_nt", tungay, denngay, noitt, makhoa, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_thuthuat_nt");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
          
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// Báo Cáo Chi Tiết Thủ Thuật Ngoại Trú
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="makhoa"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCTTTHTNgoaiTru(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhoa, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_thuthuat_ngoaitru", tungay, denngay, noitt, makhoa, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_thuthuat_ngoaitru");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);

            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }

        /// <summary>
        /// Thống Kê Hoạt Động Điều Trị
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="noitt"></param>
        /// <param name="makhoa"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBThongKeHoatDongDieuTri(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String noitt, String makhoa, String DK)
        {
          //  return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_thongkehddt", tungay, denngay, noitt, makhoa, DK);
            DataSet ds = new DataSet();
            System.Data.SqlClient.SqlConnection SQLConnectionDataNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);

            System.Data.SqlClient.SqlCommand cmd = SqlHelper.CreateCommand(SQLConnectionDataNoiT, "spBC_KHTH_thongkehddt");

            cmd.CommandTimeout = 18000;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("noitt", noitt);
            cmd.Parameters.AddWithValue("makhoa", makhoa);

            cmd.Parameters.AddWithValue("DK", DK);
            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);

            sqlad.Fill(ds);
           
            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;
            return ds;
        }       
        

        /// <summary>
        /// Thống Kê Danh Sách Bệnh Nhân Phẫu Thuật Theo Khoa
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <param name="makhoa"></param>
        /// <param name="mabs"></param>
        /// <param name="kqdt"></param>
        /// <param name="gt"></param>
        /// <param name="dtbn"></param>
        /// <param name="noitt"></param>
        /// <param name="DK"></param>
        /// <returns></returns>
        public static DataSet CrBCDSBNPhauThuatTheoKhoa(Nullable<DateTime> tungay, Nullable<DateTime> denngay, String makhoa, String mabs, String kqdt, String gt, String dtbn, String noitt, String DK)
        {
           // return SqlHelper.ExecuteDataset(ConnectString, "spBC_KHTH_dsbnphauthuat_theokhoa", tungay, denngay, makhoa, mabs, kqdt, gt, dtbn, noitt, DK);
            System.Data.SqlClient.SqlConnection _connectionserverNoiT = new System.Data.SqlClient.SqlConnection(ConnectString);
            _connectionserverNoiT.Open();

            string _databaseOwner = "dbo.";
            string _objectQualifier = "";

            System.Data.SqlClient.SqlCommand cmd;

            cmd = SqlHelper.CreateCommand(_connectionserverNoiT, _databaseOwner + _objectQualifier + "spBC_KHTH_dsbnphauthuat_theokhoa");
            cmd.CommandTimeout = 18000;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tungay", tungay);
            cmd.Parameters.AddWithValue("denngay", denngay);
            cmd.Parameters.AddWithValue("makhoa", makhoa);
            cmd.Parameters.AddWithValue("mabs", mabs);
            cmd.Parameters.AddWithValue("kqdt", kqdt);
            cmd.Parameters.AddWithValue("gt", gt);
            cmd.Parameters.AddWithValue("dtbn", dtbn);
            cmd.Parameters.AddWithValue("noitt", noitt);

            cmd.Parameters.AddWithValue("DK", DK);

            System.Data.SqlClient.SqlDataAdapter sqlad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);

            sqlad.Dispose(); cmd.Dispose(); sqlad = null;
            cmd = null;

            _connectionserverNoiT.Close();
            _connectionserverNoiT.Dispose();
            _connectionserverNoiT = null;
            return ds;
        }


       
    }
}
