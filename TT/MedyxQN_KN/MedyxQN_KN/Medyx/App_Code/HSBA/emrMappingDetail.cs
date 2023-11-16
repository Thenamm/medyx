using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for emrMappingDetail
/// </summary>
/// 
[Serializable]
public class emrMappingDetail
{
	public emrMappingDetail()
	{
	
	}
    private int _ID = 0;

    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    private String _MaDTT = String.Empty;

    public String MaDTT
    {
        get { return _MaDTT; }
        set { _MaDTT = value; }
    }
    private String _TenDTT = String.Empty;

    public String TenDTT
    {
        get { return _TenDTT; }
        set { _TenDTT = value; }
    }
    private String _DanhMucName = String.Empty;

    public String DanhMucName
    {
        get { return _DanhMucName; }
        set { _DanhMucName = value; }
    }
    private String _MaDanhMuc = String.Empty;

    public String MaDanhMuc
    {
        get { return _MaDanhMuc; }
        set { _MaDanhMuc = value; }
    }
    private String _HTTableName = String.Empty;

    public String HTTableName
    {
        get { return _HTTableName; }
        set { _HTTableName = value; }
    }
    private String _HaThangCategoryItemMa = String.Empty;

    public String HaThangCategoryItemMa
    {
        get { return _HaThangCategoryItemMa; }
        set { _HaThangCategoryItemMa = value; }
    }
    private String _TenHT = String.Empty;

    public String TenHT
    {
        get { return _TenHT; }
        set { _TenHT = value; }
    }

}