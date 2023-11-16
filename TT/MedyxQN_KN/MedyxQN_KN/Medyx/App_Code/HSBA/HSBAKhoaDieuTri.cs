using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HSBAKhoaDieuTri
/// </summary>
/// 
[Serializable]
public class HSBAKhoaDieuTri
{
    public HSBAKhoaDieuTri()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int STT { set; get; }
    public int STTKhoa { set; get; }
    public string MaBa { set; get; }
    public string TenKhoa { set; get; }
    public string MaKhoa { set; get; }
    public string NgayGioVaoKhoa { set; get; }
    public string NgayGioRaKhoa { set; get; }
    public string BacSyDieuTri { set; get; }
    public string MaBacSyDieuTri { set; get; }
}