using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_GetsDichVuList : BusinessListBase<KhamBenh_GetsDichVuList, KhamBenh_GetsDichVu>
    {

        #region Business Methods



        public KhamBenh_GetsDichVu Contains(Int32 SoTT)
        {
            foreach (KhamBenh_GetsDichVu obj in this)
                if (obj.OrderNumber  == SoTT)
                    return obj;
            return null;
        }
        public void NewTo(KhamBenh_C _KhamBenh_C) //moi sua
        {
            KhamBenh_GetsDichVu obj = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();
            obj.ADGIAUSD =_KhamBenh_C.ADGiaUSD ;
            obj.BHTinhtien = _KhamBenh_C.BHTinhtien;
            obj.BSKHAM = _KhamBenh_C.MaBS;
            obj.CK = _KhamBenh_C.CK;
            obj.DATT = _KhamBenh_C.DaTT;
            obj.DONGIABH = _KhamBenh_C.DonGiaBH;
            obj.DONGIATT = _KhamBenh_C.DongiaTT;
            obj.GiaChenhLech = _KhamBenh_C.GiaChenhLech;
            obj.LOAIDV = 1;
            obj.MaDV = _KhamBenh_C.MaDV;
            obj.TENDV = _KhamBenh_C.TenTM ;
            obj.TENKHOA = _KhamBenh_C.tenkhoa;
            obj.TENBS =_KhamBenh_C.tenbs;
            obj.tentat = _KhamBenh_C.tentat;
            obj.MAKHOA = _KhamBenh_C.Makhoa;
            if (this.Items.Count == 0)
                obj.OrderNumber = 1;
            else
                obj.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
              obj.SLMua = _KhamBenh_C.slmua;
            obj.SLTra = _KhamBenh_C.SLTra;
            obj.SoTT = _KhamBenh_C.STT;
            this.Add (obj); 
 
        }
      
        public bool ContainsDeleted(string sohd, string sosohd)
        {
            foreach (KhamBenh_GetsDichVu  obj in this)
                if ((obj.SoSoHD == sosohd) && (obj.SoHD == sohd))
                {
                    obj.SLTra =obj.SLMua;
                    obj.thanhtien = "0";
                   

                }
            return false;
        }
       
        public void UpdatedTo(KhamBenh_C _KhamBenh_C, KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

            //_KhamBenh_GetsDichVu.OrderNumber = this.Items[this.IndexOf(_KhamBenh_GetsDichVu)].OrderNumber;
            _KhamBenh_GetsDichVu.ADGIAUSD = _KhamBenh_C.ADGiaUSD;
            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_C.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_C.MaBS;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_C.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_C.DaTT;
            _KhamBenh_GetsDichVu.TENDV = _KhamBenh_C.TenTM;  
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_C.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_C.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_C.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 1;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_C.MaDV;
            _KhamBenh_GetsDichVu.TENBS = _KhamBenh_C.tenbs;
          
            _KhamBenh_GetsDichVu.MAKHOA = _KhamBenh_C.Makhoa;
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_C.slmua;
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_C.SLTra;
           // _KhamBenh_GetsDichVu.SoTT = _KhamBenh_C.STT;
            //this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;

        }
        public void NewTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();

            
            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
         
            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_ThuocSD.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_ThuocSD.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_ThuocSD.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_ThuocSD.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_ThuocSD.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_ThuocSD.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_ThuocSD.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 2;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_ThuocSD.Mathuoc;
            _KhamBenh_GetsDichVu.TENDV = _KhamBenh_ThuocSD.TenTM;
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_ThuocSD.SLMua;
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_ThuocSD.SLTra;
            _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD.STT;
            this.Add(_KhamBenh_GetsDichVu); 
           

        }
        public void UpdatedTo(KhamBenh_ThuocSD _KhamBenh_ThuocSD, KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

           // _KhamBenh_GetsDichVu.OrderNumber = this.Items[_KhamBenh_GetsDichVu.OrderNumber-1].OrderNumber;

            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_ThuocSD.BHTinhtien ;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_ThuocSD.BSChiDinh ;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_ThuocSD.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_ThuocSD.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_ThuocSD.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_ThuocSD.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_ThuocSD.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 2;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_ThuocSD.Mathuoc  ;

           _KhamBenh_GetsDichVu.SLMua = _KhamBenh_ThuocSD.SLMua;
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_ThuocSD.SLTra;
           // _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD.STT;
          

            //this.Items[_KhamBenh_GetsDichVu.OrderNumber-1] = _KhamBenh_GetsDichVu;

        }
        public void NewTo(KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DYC,int slthang,int stt)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();

         
            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber + 1;
          
                _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();
              
                _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_ThuocSD_DYC.BHTinhtien;
                
                _KhamBenh_GetsDichVu.DATT = 0;
                _KhamBenh_GetsDichVu.DONGIABH = (decimal .Parse ( _KhamBenh_ThuocSD_DYC.DongiaBH) * _KhamBenh_ThuocSD_DYC.QuyDoi).ToString ();
                _KhamBenh_GetsDichVu.DONGIATT = (decimal.Parse(_KhamBenh_ThuocSD_DYC.DongiaTT) * _KhamBenh_ThuocSD_DYC.QuyDoi).ToString();
                _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_ThuocSD_DYC.GiaChenhLech;
                _KhamBenh_GetsDichVu.LOAIDV = 6;
                _KhamBenh_GetsDichVu.MaDV = _KhamBenh_ThuocSD_DYC.Mathuoc;
                _KhamBenh_GetsDichVu.TENDV = _KhamBenh_ThuocSD_DYC.TenTM;
                decimal a = slthang * decimal.Parse(_KhamBenh_ThuocSD_DYC.SLMua) * _KhamBenh_ThuocSD_DYC.QuyDoi;
                _KhamBenh_GetsDichVu.SLMua = a.ToString();

                _KhamBenh_GetsDichVu.SoTT = stt;
                this.Add(_KhamBenh_GetsDichVu);

          
           
        }
        public void NewTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu ();

            KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DYC;
            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber + 1;
            for (int i = 0; i <= _KhamBenh_ThuocSD_DY.KhamBenh_ThuocSD_DY_Cs.Count - 1; i++)
            {
                _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();
                _KhamBenh_ThuocSD_DYC = _KhamBenh_ThuocSD_DY.KhamBenh_ThuocSD_DY_Cs[i];
                _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_ThuocSD_DYC.BHTinhtien;
                _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_ThuocSD_DY.BSChiDinh;
                _KhamBenh_GetsDichVu.CK = _KhamBenh_ThuocSD_DY.CK.ToString ();
                _KhamBenh_GetsDichVu.DATT = _KhamBenh_ThuocSD_DY.DATT;
                _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_ThuocSD_DYC.DongiaBH;
                _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_ThuocSD_DYC.DongiaTT;
                _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_ThuocSD_DYC.GiaChenhLech;
                _KhamBenh_GetsDichVu.LOAIDV = 6;
                _KhamBenh_GetsDichVu.MaDV = _KhamBenh_ThuocSD_DYC.Mathuoc;
                _KhamBenh_GetsDichVu.TENDV = _KhamBenh_ThuocSD_DYC.TenTM;
                decimal a = (decimal.Parse(_KhamBenh_ThuocSD_DY.SLMua) ) * decimal.Parse(_KhamBenh_ThuocSD_DYC.SLMua) ;
                 _KhamBenh_GetsDichVu.SLMua = a.ToString();
                decimal aa = (_KhamBenh_ThuocSD_DY.SLTra * decimal.Parse(_KhamBenh_ThuocSD_DYC.SLMua));
             
                _KhamBenh_GetsDichVu.SLTra = aa.ToString ();
         
            
                _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD_DY.STT;
                this.Add(_KhamBenh_GetsDichVu);

            }
            if (_KhamBenh_ThuocSD_DY.Sac == true)
            {
                _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();
                  _KhamBenh_GetsDichVu.BHTinhtien = true;
                _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_ThuocSD_DY.BSChiDinh;
                _KhamBenh_GetsDichVu.CK = _KhamBenh_ThuocSD_DY.CK.ToString();
                _KhamBenh_GetsDichVu.DATT = _KhamBenh_ThuocSD_DY.DATT;
                _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_ThuocSD_DY.GiaSac.ToString ();
                _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_ThuocSD_DY.GiaSac.ToString ();
               
                _KhamBenh_GetsDichVu.LOAIDV = 6;
                _KhamBenh_GetsDichVu.MaDV = "ST";
                _KhamBenh_GetsDichVu.TENDV = "ST";
                 _KhamBenh_GetsDichVu.SLMua = _KhamBenh_ThuocSD_DY.SLMua.ToString();
                _KhamBenh_GetsDichVu.SLTra = _KhamBenh_ThuocSD_DY.SLTra.ToString();

                _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD_DY.STT;
                this.Add(_KhamBenh_GetsDichVu);
            }
        }
        public void UpdatedTo(KhamBenh_ThuocSD_DY _KhamBenh_ThuocSD_DY)
        {
            KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DYC;
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu ;

            for (int j = 0; j <= this.Count - 1; j++)
            {
                if ((this[j].SoTT == _KhamBenh_ThuocSD_DY.STT))
                    if ((_KhamBenh_ThuocSD_DY.Sac == true) && (this[j].MaDV == "ST"))
                    {
                        _KhamBenh_GetsDichVu = this[j];
                        decimal a = (decimal.Parse(_KhamBenh_ThuocSD_DY.SLMua) - _KhamBenh_ThuocSD_DY.SLTra);
                        //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
                        _KhamBenh_GetsDichVu.SLMua = _KhamBenh_ThuocSD_DY.SLMua.ToString();
                        _KhamBenh_GetsDichVu.SLTra = _KhamBenh_ThuocSD_DY.SLTra.ToString();


                        // _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD_DY.STT;
                        this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;
                        if (a == 0)
                        {
                            if (_KhamBenh_GetsDichVu.IsNew == true)
                                this.Items.Remove(_KhamBenh_GetsDichVu);

                            else
                                Remove(_KhamBenh_GetsDichVu);
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= _KhamBenh_ThuocSD_DY.KhamBenh_ThuocSD_DY_Cs.Count - 1; i++)
                        {
                            if (this[i].MaDV == _KhamBenh_ThuocSD_DY.KhamBenh_ThuocSD_DY_Cs[i].Mathuoc)
                            {
                                _KhamBenh_GetsDichVu = this[i];
                                _KhamBenh_ThuocSD_DYC = _KhamBenh_ThuocSD_DY.KhamBenh_ThuocSD_DY_Cs[i];
                                _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_ThuocSD_DYC.BHTinhtien;
                                _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_ThuocSD_DY.BSChiDinh;
                                _KhamBenh_GetsDichVu.CK = _KhamBenh_ThuocSD_DY.CK.ToString();
                                _KhamBenh_GetsDichVu.DATT = _KhamBenh_ThuocSD_DY.DATT;
                                _KhamBenh_GetsDichVu.DONGIABH = (decimal .Parse (_KhamBenh_ThuocSD_DYC.DongiaBH) / _KhamBenh_ThuocSD_DYC.QuyDoi).ToString ();
                                _KhamBenh_GetsDichVu.DONGIATT = (decimal .Parse (_KhamBenh_ThuocSD_DYC.DongiaTT) / _KhamBenh_ThuocSD_DYC.QuyDoi).ToString ();
                                _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_ThuocSD_DYC.GiaChenhLech;
                                _KhamBenh_GetsDichVu.LOAIDV = 6;
                                _KhamBenh_GetsDichVu.MaDV = _KhamBenh_ThuocSD_DYC.Mathuoc;
                                _KhamBenh_GetsDichVu.TENDV = _KhamBenh_ThuocSD_DYC.TenTM;

                                //decimal a = (decimal.Parse(_KhamBenh_ThuocSD_DY.SLMua) - _KhamBenh_ThuocSD_DY.SLTra) * decimal.Parse(_KhamBenh_ThuocSD_DYC.SLMua) * _KhamBenh_ThuocSD_DYC.QuyDoi;
                                //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
                                _KhamBenh_GetsDichVu.SLMua = _KhamBenh_ThuocSD_DY.SLMua.ToString();
                                _KhamBenh_GetsDichVu.SLTra = _KhamBenh_ThuocSD_DY.SLTra.ToString();


                                // _KhamBenh_GetsDichVu.SoTT = _KhamBenh_ThuocSD_DY.STT;
                                this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;
                               
                            }

                        }
                    }
               
            }
        
        }
        public void NewTo(KhamBenh_Mau _KhamBenh_Mau)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();


            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_Mau.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_Mau.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_Mau.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_Mau.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_Mau.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_Mau.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_Mau.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 4;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_Mau.MaCPMau ;
            _KhamBenh_GetsDichVu.TENDV = _KhamBenh_Mau.TenTM;
            //decimal a = decimal.Parse(_KhamBenh_Mau.SLMua) - decimal.Parse(_KhamBenh_Mau.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_Mau.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_Mau.SLTra.ToString();

            _KhamBenh_GetsDichVu.SoTT = _KhamBenh_Mau.STT;
            this.Add(_KhamBenh_GetsDichVu);


        }
        public void UpdatedTo(KhamBenh_Mau _KhamBenh_Mau, KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

            _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.IndexOf(_KhamBenh_GetsDichVu)].OrderNumber;

            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_Mau.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_Mau.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_Mau.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_Mau.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_Mau.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_Mau.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_Mau.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 4;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_Mau.MaCPMau ;

            //decimal a = decimal.Parse(_KhamBenh_Mau.SLMua) - decimal.Parse(_KhamBenh_Mau.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_Mau.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_Mau.SLTra.ToString();

          //  _KhamBenh_GetsDichVu.SoTT = _KhamBenh_Mau.STT;
          //  _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;

            this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;

        }
        public void NewTo(KhamBenh_VTTH _KhamBenh_VTTH)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();


            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;
            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_VTTH.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_VTTH.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_VTTH.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_VTTH.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_VTTH.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_VTTH.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_VTTH.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 3;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_VTTH.MaVT ;
            _KhamBenh_GetsDichVu.TENDV = _KhamBenh_VTTH.TenTM;
            //decimal a = decimal.Parse(_KhamBenh_VTTH.SLMua) - decimal.Parse(_KhamBenh_VTTH.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_VTTH.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_VTTH.SLTra.ToString();

            _KhamBenh_GetsDichVu.SoTT = _KhamBenh_VTTH.STT;
            this.Add(_KhamBenh_GetsDichVu);


        }
        public void UpdatedTo(KhamBenh_VTTH _KhamBenh_VTTH, KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

            _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.IndexOf(_KhamBenh_GetsDichVu)].OrderNumber;

            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_VTTH.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_VTTH.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_VTTH.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_VTTH.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_VTTH.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_VTTH.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_VTTH.GiaChenhLech;  
            _KhamBenh_GetsDichVu.LOAIDV = 2;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_VTTH.MaVT ;

            //decimal a = decimal.Parse(_KhamBenh_VTTH.SLMua) - decimal.Parse(_KhamBenh_VTTH.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_VTTH.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_VTTH.SLTra.ToString();

          //  _KhamBenh_GetsDichVu.SoTT = _KhamBenh_VTTH.STT;
          //  _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;

            this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;

        }
        public void NewTo(KhamBenh_HoaChat _KhamBenh_HoaChat)
        {
            KhamBenh_GetsDichVu _KhamBenh_GetsDichVu = KhamBenh_GetsDichVu.NewKhamBenh_GetsDichVu();


            if (this.Items.Count == 0)
                _KhamBenh_GetsDichVu.OrderNumber = 1;
            else
                _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber + 1;
            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_HoaChat.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_HoaChat.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_HoaChat.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_HoaChat.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_HoaChat.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_HoaChat.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_HoaChat.GiaChenhLech;
            _KhamBenh_GetsDichVu.LOAIDV = 5;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_HoaChat.MaHC;
            _KhamBenh_GetsDichVu.TENDV = _KhamBenh_HoaChat.TenTM;
            //decimal a = decimal.Parse(_KhamBenh_HoaChat.SLMua) - decimal.Parse(_KhamBenh_HoaChat.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_HoaChat.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_HoaChat.SLTra.ToString();

            _KhamBenh_GetsDichVu.SoTT = _KhamBenh_HoaChat.STT;
            this.Add(_KhamBenh_GetsDichVu);


        }
        public void UpdatedTo(KhamBenh_HoaChat _KhamBenh_HoaChat, KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

            _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.IndexOf(_KhamBenh_GetsDichVu)].OrderNumber;

            _KhamBenh_GetsDichVu.BHTinhtien = _KhamBenh_HoaChat.BHTinhtien;
            _KhamBenh_GetsDichVu.BSKHAM = _KhamBenh_HoaChat.BSChiDinh;
            _KhamBenh_GetsDichVu.CK = _KhamBenh_HoaChat.CK;
            _KhamBenh_GetsDichVu.DATT = _KhamBenh_HoaChat.DATT;
            _KhamBenh_GetsDichVu.DONGIABH = _KhamBenh_HoaChat.DonGiaBH;
            _KhamBenh_GetsDichVu.DONGIATT = _KhamBenh_HoaChat.DongiaTT;
            _KhamBenh_GetsDichVu.GiaChenhLech = _KhamBenh_HoaChat.GiaChenhLech;
            _KhamBenh_GetsDichVu.LOAIDV = 5;
            _KhamBenh_GetsDichVu.MaDV = _KhamBenh_HoaChat.MaHC;

            //decimal a = decimal.Parse(_KhamBenh_HoaChat.SLMua) - decimal.Parse(_KhamBenh_HoaChat.SLTra);
            //_KhamBenh_GetsDichVu.SoLuong = a.ToString();
            _KhamBenh_GetsDichVu.SLMua = _KhamBenh_HoaChat.SLMua.ToString();
            _KhamBenh_GetsDichVu.SLTra = _KhamBenh_HoaChat.SLTra.ToString();

            //  _KhamBenh_GetsDichVu.SoTT = _KhamBenh_HoaChat.STT;
            //  _KhamBenh_GetsDichVu.OrderNumber = this.Items[this.Items.Count - 1].OrderNumber+1;

            this.Items[this.IndexOf(_KhamBenh_GetsDichVu)] = _KhamBenh_GetsDichVu;

        }
        public void RemoveTo(   Int32 sott)
        {
            KhamBenh_GetsDichVu  _kb = Contains(sott);
            if (_kb !=null)
            if (_kb.IsNew == true)
                this.Items.Remove(_kb);

            else
                Remove(_kb);
           
        }
        public void RemoveTo(KhamBenh_GetsDichVu _KhamBenh_GetsDichVu)
        {

            if (_KhamBenh_GetsDichVu != null)
                if (_KhamBenh_GetsDichVu.IsNew == true)
                    this.Items.Remove(_KhamBenh_GetsDichVu);

                else
                    Remove(_KhamBenh_GetsDichVu);

        }
        #endregion
        #region Factory Methods

        public static KhamBenh_GetsDichVuList GetAllGetsDichVu(string _masokham, Byte _datt,  Byte _loaiphieu, String _dk)
        {
            return DataPortal.Fetch<KhamBenh_GetsDichVuList>(new Criteria(_masokham, _datt,_loaiphieu, _dk ));

        }

        private KhamBenh_GetsDichVuList()
        {  /* Require use of factory methods */ }
       
        public static KhamBenh_GetsDichVuList NewKhamBenh_GetsDichVuList()
        {
            return new KhamBenh_GetsDichVuList();
        }
        
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private DateTime _ngayYC;
            public DateTime ngayYC
            {
                get
                {
                    return _ngayYC;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Byte _DaTT;
            public Byte DaTT
            {
                get
                {
                    return _DaTT;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public Criteria(string MaSoKham, Byte DaTT,  Byte loai, string dk)
            {
                //_ngayYC = ngayYC;
                _Loai = loai;
                _MaSoKham = MaSoKham;
                _DK = dk;
                _DaTT = DaTT;
              


            }
        }



        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_GETsMABNInfo(criteria.MaBN, criteria.NgayYC, criteria.Loai, criteria.DK, criteria.qadmin)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            KhamBenh_GETsMABNInfo item = new KhamBenh_GETsMABNInfo(
        // i,
        // dr.GetString("MaSoKham"),
        // dr.GetString("MaBN"),
        // dr.GetString("MaDT"),
        // dr.GetString("Sothe"),
        // dr.GetSmartDate("GiatriDN", true),
        // dr.GetString("MaBV"),
        // dr.GetString("MaTinh"),
        // dr.GetSmartDate("NgayKT", true),
        // dr.GetString("Gio"),
        // dr.GetSmartDate("Ngayduyet", true),
        // dr.GetString("Nguoiduyet"),
        // dr.GetSmartDate("NgayQT", true),
        // dr.GetSmartDate("NgayQTTT", true),
        // dr.GetString("NguoiQT"),
        // dr.GetString("MaBenhNoiGT"),
        // dr.GetString("MaNoiGT"),
        // dr.GetString("CDNoiGT"),
        // dr.GetString("Ghichu"),
        // dr.GetByte("Loaikham"),
        // dr.GetBoolean("Cungtra"),
        // dr.GetDecimal("CK"),
        // dr.GetSmartDate("NgayLap", true),
        // dr.GetString("NguoiLap"),
        // dr.GetSmartDate("NgaySD", true),
        // dr.GetString("NguoiSD"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetByte("NguoiHuy"),
        // dr.GetSmartDate("NgayHuy", true),
        // dr.GetSmartDate("NgaySD1", true),
        // dr.GetString("NguoiSD1"),
        // dr.GetString("DienThoai"),
        // dr.GetString("DiaChi"),
        // dr.GetDecimal("TongTien"),
        // dr.GetDecimal("TongBHTra"),
        // dr.GetDecimal("TongTienBH")
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }

            //IsReadOnly = true;

        //    RaiseListChangedEvents = true; 
        //}

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_GetsDichVu( criteria.qadmin, criteria.MaSoKham,criteria.DaTT ,criteria.Loai, criteria.DK )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                     
                    KhamBenh_GetsDichVu  item = new KhamBenh_GetsDichVu(

          dr.GetString("Masokham"),
          dr.GetInt32("LOAIDV"),
          dr.GetString("MaDV")  ,
          dr.GetString("TENDV") ,
          dr.GetInt32("STT"),
          dr.GetDecimal("DONGIATT") ,
          dr.GetDecimal("DONGIABH") ,
          dr.GetBoolean("ADGIAUSD") ,
          dr.GetDecimal("SoLuong") ,
           0,
          dr.GetString("MAKHOA") ,
          dr.GetString("BSKHAM") ,
          dr.GetBoolean("Tinhtien") ,
          dr.GetBoolean("BHTinhtien") ,
          dr.GetByte("DATT")  ,
          dr.GetDecimal("CK")  ,
          dr.GetString("TENKHOA")  ,
          dr.GetString("TENBS") ,
          dr.GetSmartDate("NGAYYC", true) ,
          dr.GetSmartDate("NGAYLAP", true) ,
          dr.GetString("NGUOILAP") ,
          dr.GetString("NGUOISD") ,
          dr.GetSmartDate("NGAYSD", true) ,
          dr.GetSmartDate("NGAYHUY", true) ,
          dr.GetString("NGUOIHUY")  ,
          dr.GetString("TENNGUOILAP") ,
          dr.GetString("TENNGUOISD")  ,
          dr.GetString("TENNGUOIHUY"),
         i,
         dr.GetString("sosohd"),
         dr.GetString("sohd"),
         dr.GetDecimal("giachenhlech"),
          dr.GetSmartDate("ngaygiokham", true),
            dr.GetString("tentat"),
               dr.GetBoolean("inthu"),
               dr.GetBoolean("duyetbh")
         );
                    item.OrderNumber = i;
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
           dr.Close();
          // dr = null;
            }
           
            RaiseListChangedEvents = true;          
        }
     
        #endregion
    }
}
