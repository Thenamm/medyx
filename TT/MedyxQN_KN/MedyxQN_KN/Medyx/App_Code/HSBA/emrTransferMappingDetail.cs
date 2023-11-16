using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for emrTransferMappingDetail
/// </summary>
public class emrTransferMappingDetail
{
    public emrTransferMappingDetail()
    {
    }
    String _DanhMucName = String.Empty;
    public String DanhMucName
    {
        get { return _DanhMucName; }
        set { _DanhMucName = value; }
    }
    private int _Id = 0;

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }

    String _TableHaThang = String.Empty;
    public String TableHaThang
    {
        get { return _TableHaThang; }
        set { _TableHaThang = value; }
    }
    String _MaKeyDTT = String.Empty;
    public String MaKeyDTT
    {
        get { return _MaKeyDTT; }
        set { _MaKeyDTT = value; }
    }
    String _TenDTT = String.Empty;
    public String TenDTT
    {
        get { return _TenDTT; }
        set { _TenDTT = value; }
    }
    String _KeyHT = String.Empty;
    public String KeyHT
    {
        get { return _KeyHT; }
        set { _KeyHT = value; }
    }
    String _TenHT = String.Empty;
    public String TenHT
    {
        get { return _TenHT; }
        set { _TenHT = value; }
    }

}