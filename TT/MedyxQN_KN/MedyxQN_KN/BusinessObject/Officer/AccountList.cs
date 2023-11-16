using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class AccountList : BusinessListBase<AccountList, Account >
    {
        
         #region Factory Methods
        public static AccountList FindAccountMaNV(string manv)
        {
            return DataPortal.Fetch<AccountList>(new Criteria(manv));
        }
        public void NewTo(Account _Account)
        {
            _Account.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_Account);
        }
        public void UpdatedTo(Account _Account)
        {

            _Account.OrderNumber = this.Items[this.IndexOf(_Account)].OrderNumber;
            this.Items[this.IndexOf(_Account)] = _Account;
        }
        public void RemoveTo(Account _Account)
        {
            this.Items.Remove(_Account);

        }
        private AccountList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

            private String _maNV;
            public String maNV
            {
                get
                {
                    return _maNV;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
        
        
            public Criteria(String manv)
            {
                _maNV = manv;
                _dk = "";// and a.manv = '" + _maNV + "'";
              
            }
        }
        #endregion
     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindAccountList(criteria.maNV, criteria.dk   )))
            {
               
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben Account vao phuong thuc (internal Account)
                {
                    try 
                    {
                        Account item = new Account(
     i,
     dr.GetString("MaNV") ,
			                                dr.GetString("Account") ,
			                                dr.GetString("Password") ,
			                                dr.GetString("MaKhoaLS") ,
			                                dr.GetString("MaKhoaCLS") ,
			                                dr.GetString("MaKho") ,
			                                dr.GetBoolean("AllMaKho") ,
			                                dr.GetBoolean("AllMaKhoaCLS") ,
			                                dr.GetBoolean("AllMaKhoaLS") ,
			                                dr.GetString("QuyenDTuong") ,
			                                dr.GetBoolean("AllQuyenDTuong") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Qadmin") ,
     dr.GetString("Hoten"),
     dr.GetString("TenNguoiSD"),
     dr.GetBoolean("qsgia")
  );
                   
                    this.Add(item);
                    i += 1;
                    }
                    catch ( Exception ex )
                    {
                       
                        //MessageBox.Show(ex.ToString());
                    }
                    
                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
        #endregion
    }
}
