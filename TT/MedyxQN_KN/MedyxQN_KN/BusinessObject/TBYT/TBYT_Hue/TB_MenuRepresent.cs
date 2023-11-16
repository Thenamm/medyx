using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class TB_MenuRepresent
    {
        public Int32 Ordernumber { get; set; }
        public Int32 Id { get; set; }
        public Int32 ParentId { get; set; }
        public String Image { get; set; }
        public String TenMN { get; set; }
        public String Path { get; set; }
        public Boolean Disnable { get; set; }
        public TB_MenuRepresent()
        {
            Id = 0;
            ParentId = 0;
            Image = "";
            TenMN = "";
            Path = "";
            Disnable = false;
            Ordernumber = 0;
        }
        public TB_MenuRepresent(Int32 Id, Int32 ParentId, String Image, String TenMN, String Path, Boolean Disnable, Int32 Ordernumber)
        {
            this.Id = Id;
            this.ParentId = ParentId;
            this.Image = Image;
            this.TenMN = TenMN;
            this.Path = Path;
            this.Disnable = Disnable;
            this.Ordernumber = Ordernumber;
        }
        public TB_MenuRepresent(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["Id"].GetType().Name != "DBNull" && dr["Id"] != null)
                this.Id = Convert.ToInt32(dr["Id"]);
            if (dr["ParentId"].GetType().Name != "DBNull" && dr["ParentId"] != null)
                this.ParentId = Convert.ToInt32(dr["ParentId"]);
            if (dr["Image"].GetType().Name != "DBNull" && dr["Image"] != null)
                this.Image = Convert.ToString(dr["Image"]);
            if (dr["TenMN"].GetType().Name != "DBNull" && dr["TenMN"] != null)
                this.TenMN = Convert.ToString(dr["TenMN"]);
            if (dr["Path"].GetType().Name != "DBNull" && dr["Path"] != null)
                this.Path = Convert.ToString(dr["Path"]);
            if (dr["Disnable"].GetType().Name != "DBNull" && dr["Disnable"] != null)
                this.Disnable = Convert.ToBoolean(dr["Disnable"]);
            this.Ordernumber = Ordernumber;
        }         
    }

    [Serializable()]
    public class TB_MenuRepresentList : List<TB_MenuRepresent>
    {
        public TB_MenuRepresentList()
        {

        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        /// <summary>
        /// GetId and Disnable and Image in MaMN
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public static TB_MenuRepresentList GetByAccount(String Account)
        {
            TB_MenuRepresentList List = new TB_MenuRepresentList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.TB_MenuRepresent_GetByAccount", Account))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TB_MenuRepresent(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
