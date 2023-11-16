using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.NoiTru
{
    [Serializable()]

    public class BenhAnPhauThuat_DungCuMoList : BusinessListBase<BenhAnPhauThuat_DungCuMoList, BenhAnPhauThuat_DungCuMo>
    {
        #region Factory Methods
        public static BenhAnPhauThuat_DungCuMoList GetAllBenhAnPhauThuat_DungCuMo(String MaBA, int STT, int STTKhoa)
        {
            return DataPortal.Fetch<BenhAnPhauThuat_DungCuMoList>(new Criteria(MaBA,STT,STTKhoa ));
        }
        //public static BenhAnPhauThuat_DungCuMoList GetAllBenhAnPhauThuat_DungCuMoBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        //{
        //    return DataPortal.Fetch<BenhAnPhauThuat_DungCuMoList>(new OtherCriteria(MaBA,sttKhoa,"",1,qadmin ));
        //}
        //public static BenhAnPhauThuat_DungCuMoList GetAllBenhAnPhauThuat_DungCuMoByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        //{
        //    return DataPortal.Fetch<BenhAnPhauThuat_DungCuMoList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2, qadmin));
        //}
        public BenhAnPhauThuat_DungCuMo NewTo() 
        {
            BenhAnPhauThuat_DungCuMo obj = BenhAnPhauThuat_DungCuMo.NewBenhAnPhauThuat_DungCuMo();
            return obj;
        }
        public void NewTo(BenhAnPhauThuat_DungCuMo _BenhAnPhauThuat_DungCuMo)
        {
            try
            {
                if (!Contains(_BenhAnPhauThuat_DungCuMo.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAnPhauThuat_DungCuMo.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAnPhauThuat_DungCuMo);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_BenhAnPhauThuat_DungCuMo.STT = ++_count;
                        this.Add(_BenhAnPhauThuat_DungCuMo);
                    }
                    else
                    {
                        //_BenhAnPhauThuat_DungCuMo.STT = 1;
                        this.Add(_BenhAnPhauThuat_DungCuMo);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(BenhAnPhauThuat_DungCuMo _BenhAnPhauThuat_DungCuMo)
        {

            _BenhAnPhauThuat_DungCuMo.MaBA = this.Items[this.IndexOf(_BenhAnPhauThuat_DungCuMo)].MaBA;
            this.Items[this.IndexOf(_BenhAnPhauThuat_DungCuMo)] = _BenhAnPhauThuat_DungCuMo;
        }
        //public void RemoveTo(BenhAnPhauThuat_DungCuMo _BenhAnPhauThuat_DungCuMo)
        //{
        //    this.Items.Remove(_BenhAnPhauThuat_DungCuMo);

        //}
        public void RemoveTo(BenhAnPhauThuat_DungCuMo obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAnPhauThuat_DungCuMo  AssignTo(BenhAnPhauThuat_DungCuMo  _BenhAnPhauThuat_DungCuMo)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAnPhauThuat_DungCuMo.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAnPhauThuat_DungCuMo.STT = ++_count;
                    this.Add(_BenhAnPhauThuat_DungCuMo);
                }
                else
                {
                    //_BenhAnPhauThuat_DungCuMo.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAnPhauThuat_DungCuMo);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAnPhauThuat_DungCuMo;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAnPhauThuat_DungCuMo  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAnPhauThuat_DungCuMo  item in this)
            {
                if (item.MaBA == MaBA && item.STT == stt && item.STTKhoa == sttkhoa)
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAnPhauThuat_DungCuMo GetTo(string MaBA, int stt, int sttkhoa, string madc) //
        {
            foreach (BenhAnPhauThuat_DungCuMo obj in this)
                if (obj.MaBA == MaBA && obj.STT == stt && obj.STTKhoa == sttkhoa &&obj.MaDC==madc)
                return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAnPhauThuat_DungCuMo  item = BenhAnPhauThuat_DungCuMo.NewBenhAnPhauThuat_DungCuMo();
            Add(item);
            return item;
        }

      
        private BenhAnPhauThuat_DungCuMoList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private String  _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
                }
            }
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(String mMaBA, int stt, int sttkhoa)
            {
                _MaBA = mMaBA;
                _STT = stt;
                _STTKhoa = sttkhoa;
            }
        }
        
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PhauThuat_DungCuMo(criteria.MaBA, criteria.STT, criteria.STTKhoa)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAnPhauThuat_DungCuMo.GetBenhAnPhauThuat_DungCuMo(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAnPhauThuat_DungCuMo  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAnPhauThuat_DungCuMo  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAnPhauThuat_DungCuMoList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAnPhauThuat_DungCuMoList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
