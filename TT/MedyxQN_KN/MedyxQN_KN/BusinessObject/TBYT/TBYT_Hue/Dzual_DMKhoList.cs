using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class Dzual_DMKhoList: List<Dzual_DMKho>
    {
        public Dzual_DMKhoList()
	    {

	    }

	    private static string ConnectString
	    {
		    get
		    {
			    return HTC.Business.DataProvider.Instance().DuanConnectString();
		    }
	    }

	    public static Dzual_DMKhoList GetByAccount(String account, Byte loai, Nullable<Boolean> KhoChinh)
	    {
		    Dzual_DMKhoList List = new Dzual_DMKhoList();
		    using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMKHO_byAccount", account, loai, KhoChinh))
		    {
			    int Ordernumber = 0;
			    while (dr.Read())
			    {
				    Ordernumber++;
				    List.Add(new Dzual_DMKho(dr, Ordernumber));
			    }
		    }
		    return List;
	    }        
    }
}
