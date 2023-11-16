<%@ Page Language="C#" MasterPageFile="AdminCode.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <div class="grid_12 header-repeat">
        <div id="branding1" style="background:url('img/header-repeat.png') repeat-x scroll center bottom #E1E1E1">
            <div class="floatleft"> 
                <!--                                   
                <asp:Image runat="server" ImageUrl="~/img/HTCLogo.png" width="120px" height="100px"  />
                -->
                <asp:Image runat="server" ImageUrl="~/img/BenhVienYHocCoTruyen.png" width="700px" height="100px"  />                                  
            </div>
            <div class="floatright" style="background-image:url() repeat-x;padding-top:7px">                
                <div class="floatleft">                                                    
                        <asp:Image runat="server" ImageUrl="~/img/img-profile.jpg" AlternateText="Profile Pic" />
                    </div>

                <div class="floatleft marginleft10" >
                    <ul class="inline-ul floatleft" style="padding-top:6px" >
                        <li style="color:black;font-weight:bold">Admin</li>                        
                        <li style="color:black;font-weight:bold">&nbsp; | &nbsp;</li>                        
                        <li >                            
                            <asp:LinkButton runat="server" OnClick="btnLogout_Click">Đăng xuất</asp:LinkButton>
                        </li>
                    </ul>
                    <br />
                    <span class="small grey"></span>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%= txtInput.ClientID %>").mask("99/99/9999");
        });


        /*
        var confirmOnPageExit = function (e) {

            // If we haven't been passed the event get the window.event            
            e = e || window.event;

            var message = 'Any text will block the navigation and display a prompt';

            // For IE6-8 and Firefox prior to version 4
            if (e) {
                e.returnValue = message;
            }

            // For Chrome, Safari, IE8+ and Opera 12+
            return message;
        };

        // Turn it on - assign the function that returns the string
        window.onbeforeunload = confirmOnPageExit;

        // Turn it off - remove the function entirely
        //window.onbeforeunload = null;
        */

    </script>        

    <!-- TOOL BAR --> 
    <telerik:RadToolBar ID="baraction" runat="server"
           EnableRoundedCorners="true"
        EnableShadows="true" Width ="100%" style="display:none" >
             <Items >  
            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                Text="Thêm phiếu" group ="Align" CheckOnClick="false" Value ="cmdAdd">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="Sửa phiếu" CheckOnClick="false" Value ="cmdEdit">
            </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/Delete.png"
                Text="Xóa phiếu" CheckOnClick="false" Value ="cmdDelete" >
            </telerik:RadToolBarButton>
               <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                Text="Thoát"  CheckOnClick="false" Value ="cmdExit" >
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="Xem"   CssClass="ButtonCSS" Value ="cmdView">
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                Text="Lọc"  CheckOnClick="false" Value ="cmdFilter" >
            </telerik:RadToolBarButton>
            </Items>
         </telerik:RadToolBar>

    <div style="clear:both" >
        &nbsp;
        </div>

    <div class="form-container" style="display:none">

        <fieldset align="center">
          <legend>
                <label>              
                        Nội dung form nhập liệu
                </label>
          </legend>

        <table id="tbl4cols">
            <tr>
                <td>
                    <asp:Label runat="server" Text="Ngày hoàn thành" ID="lblDate"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtInput" />
                </td>        
                <td>
                    <asp:Label runat="server" Text="Người phụ trách" ID="lblPerson"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="cboProducts"></asp:DropDownList>
                </td>        
             </tr>
              <tr>
                <td>
                    <asp:Label runat="server" Text="Ngày hoàn thành" ID="lblDate1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtInpu1t" />
                </td>        
                <td>
                    <asp:Label runat="server" Text="Người phụ trách" ID="lblPerson1"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="cboProducts1"></asp:DropDownList>
                </td>        
             </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="BZ" ID="lbl"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox runat="server" /> A <asp:CheckBox runat="server" /> B
                </td>        
                <td>
                    <asp:Label runat="server" Text="BS" ID="lbl123"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton runat="server" /> A <asp:RadioButton runat="server" /> B
                </td>        
             </tr>

             <tr>
                <td>
                    &nbsp;
                </td>
                <td colspan="3">
                    <asp:Button runat="server" Text="Cập nhật" ID="btnGetValue" OnClick="btnGetValue_Click" />                 
                    &nbsp;&nbsp;
                    <asp:Button runat="server" Text="Thêm mới" ID="btnGetValue1" OnClick="btnGetValue_Click" />
                    &nbsp;&nbsp;
                    <asp:Button runat="server" Text="In Phiếu" ID="btnGetValu2e" OnClick="btnGetValue_Click" />
                    &nbsp;&nbsp;
                    <asp:Button runat="server" Text="Xuất hóa đơn" ID="btnGetValu3e" OnClick="btnGetValue_Click" />
                </td>        
             </tr>
        </table>
    </div>    
    


</asp:Content>    


