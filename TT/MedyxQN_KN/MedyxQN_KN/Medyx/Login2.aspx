<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="Login2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <link rel="shortcut icon" href="../favicon.ico" >
   <link rel="icon" type="image/gif" href="../animated_favicon1.gif" >
    <title>Đăng nhập</title>
    <style type="text/css">
        body {
            font-family:Tahoma;
            color:antiquewhite;
            font-size:12px;
            font-weight:bold;
        }
    </style>
</head>
<body background="img/Admin_Login/LoginBG.jpg"  style="margin-top:70px">
    <form id="form1" runat="server">
    <div>
            <table background="img/Admin_Login/LoginBG_CENTER.jpg" align="center"  width="901px" height="520px">                             
                <tr>
                    <td width="450px" style="vertical-align:middle" align="center" >
                        
                        <img src="img/LOGO/loginLogo.png"  />

                    </td>                    

                    <td width="450px" style="vertical-align:middle" align="left" >
                            
                                <table width="106px" border="0" cellspacing="3" cellpadding="3">                                                                    
                                    <tr>
                                        <td background="img/Admin_Login/loginHead.png" style="background-repeat:no-repeat" height="36px">                                                                                    
                                            &nbsp;
                                            <asp:Label ID="lblInformation" runat="server" Style="font-weight: bold; font-size: 14px;
                                                color: #ffffff; font-family: tahoma" Width="245px"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Tên đăng nhập <asp:TextBox ID="txtUserName" runat="server" style="border-right: #ffffff thin solid; border-top: #ffffff thin solid; border-left: #ffffff thin solid; border-bottom: #ffffff thin solid; padding-right: 4px; padding-left: 4px; font-size: 12px; padding-bottom: 5px; width: 170px; padding-top: 5px; font-family: tahoma; height: 20px;"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Mật khẩu <Br /> <asp:TextBox ID="txtPassword" runat="server" style="border-right: #ffffff thin solid; border-top: #ffffff thin solid; border-left: #ffffff thin solid; border-bottom: #ffffff thin solid; padding-right: 4px; padding-left: 4px; font-size: 12px; padding-bottom: 5px; width: 170px; padding-top: 5px; font-family: tahoma; height: 20px;" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>                                    
                                    <tr>
                                        <td>
                                            <!--
                                            <asp:CheckBox ID="cbRemember" runat="server" Style="font-size: 12px; color: #ffffff;
                                                font-family: tahoma" Text="Remember me" /></td>-->
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" Text="Đăng nhập" style="border-right: #ffffff thin solid; border-top: #ffffff thin solid; font-weight: bold; font-size: 11px; border-left: #ffffff thin solid; border-bottom: #ffffff thin solid; font-family: tahoma; background-color: #66ffcc" Height="30px" Width="80px" OnClick="Button1_Click" />
                                        </td>
                                    </tr>
                                </table>                    
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="forgotpassword.aspx" Style="font-size: 12px;
                            color: #ffffff; font-family: verdana; font-style: italic;" Visible="False">Forgot password?</asp:HyperLink>
                        &nbsp;&nbsp;
                    </td>                    
                </tr>                                
            </table>    
    </div>
    </form>    
</body>
</html>
