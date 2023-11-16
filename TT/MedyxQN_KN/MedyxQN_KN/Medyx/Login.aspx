<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        
               <%-- 
                body {
	                margin-left: 0px;
	                margin-top: 0px;
	                margin-right: 0px;
	                margin-bottom: 0px;
                }
                body,td,th {
	                font-family: tahoma;
	                color: #FFFFFF;
                }
                .style1 {font-weight: bold}
                .style3 {
	                font-size: 18px;
	                background-position: top;
	                font-weight: bold;
                }
                .btn
                {
                 background-color:#FFFFCC;
                 font-size:16px;
                 border-color:#333333
                 }
                .style5 {font-size: 18px}
                --%>
</style>
</head>
<body style="background-color:#C0C0C0" >
   <form id="form1" runat="server">
    <div style="background-color: #C0C0C0; " >
        <BR />
        <BR />
        <BR />
        <BR />
        <BR />
        <table align="center" width="400px" cellpadding="4" cellspacing="0" style="background-image:url(img/Login/login.jpg);">
            <tr>
                <td width="400px" height="50px" colspan="3" style="background-repeat:no-repeat" 
                    align="center">
                </td>
            </tr>
                       
            <tr>
                <td colspan="3" width="300" align="center" style="color: #FF6633">
                    <asp:Label ID="lblMessage" runat="server"  ></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 97px" >
                    <span class="style5" style="color: #000000">Tên</span>
                </td>
                <td colspan="2" style="width: 245px">
                    <asp:TextBox ID="txtLoginName" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td  style="width: 87px">
                    <span class="style5" style="color: #000000">Mật khẩu </span>
                </td>
                <td colspan="2"style="width: 215px">                    
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td style="width: 77px;height:50px" >
                    &nbsp;
                </td>
                <td style="width: 27px;height:50px" >
                    &nbsp;
                </td>
                <td style="width: 215px">
                    <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập"  CssClass="btn" OnClick="btnLogin_Click" />
                </td>
            </tr>
             <tr >  <td height ="35px"> </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
