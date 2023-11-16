<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NhanVienLogin.aspx.cs" Inherits="NhanVienLogin" %>

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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
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
                                            Quầy thu tiền:
                                            <asp:DropDownList  ID="cboQuay" runat="server" DataValueField="Key" DataTextField="Value"
                                                 DataSourceID="ObjectDanhMucQuay"
                                Width="100%">
                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td>
                                            <asp:Button ID="btnOK" runat="server" Text="Xác nhận" style="border-right: #ffffff thin solid; border-top: #ffffff thin solid; font-weight: bold; font-size: 11px; border-left: #ffffff thin solid; border-bottom: #ffffff thin solid; font-family: tahoma; background-color: #66ffcc" Height="30px" Width="80px" OnClick="btnOK_Click" />
                                        </td>
                                    </tr>
                                </table>                    
                        <br />
                    </td>                    
                </tr>                                
            </table>    
    </div>
    </form>
     <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucQuay" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMQuayListcb"></asp:ObjectDataSource>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function HandlekeyPressEnter(sender, args) {

            var e = args.get_domEvent();
            var id = "";
            var senderId = sender.get_inputDomElement().id;
            var isMarked = false;

            if (e.keyCode == 13) {
                sender._raiseClientBlur(e);
                var curtabIndex = sender.get_inputDomElement().tabIndex;

                for (i = 0; i < document.forms[0].elements.length; i++) {
                    if (document.forms[0].elements[i].type == "text"
                        || document.forms[0].elements[i].type == "textarea"
                        || document.forms[0].elements[i].type == "select-one"
                        || document.forms[0].elements[i].type == "checkbox"
                        || document.forms[0].elements[i].type == "select"
                        ) {
                        id = document.forms[0].elements[i].id;

                        if (isMarked) {
                            setTimeout('document.getElementById("' + id + '").focus();', 10);
                            break;
                        }

                        if (id == senderId) {
                            isMarked = true;
                        }
                    }
                }
            }
        }
    </script>
    </telerik:RadCodeBlock>
</body>
</html>
