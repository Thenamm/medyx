<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmGiayNghiThai.aspx.cs" Inherits="UI_QLHSBA_frmGiayNghiThai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">    
    <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
                    <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.js")%>' type="text/javascript"></script>
        <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.datetimepicker.js")%>' type="text/javascript"></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
        <link href='<%: ResolveUrl("~/css/datetimepicker/jquery.datetimepicker.css")%>' rel="stylesheet" />
    <style type="text/css">
    .ButtonCSS
       {
           margin-left:400px;
       }
            .mainContent {
              width:100%!important;
          }
   </style>
      <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
   <script type="text/javascript">
       $(document).ready(function () {
           $("#<%= dtNgayVao.ClientID %>,#<%= dtNgayRa.ClientID %>,#<%= dtNGAYCAP_CMND.ClientID %>,#<%= dtNgayCap.ClientID %>").mask("99/99/9999 99:99");
       });
       $(function () {
           $("#<%= dtNgayVao.ClientID %>,#<%= dtNgayRa.ClientID %>,#<%= dtNGAYCAP_CMND.ClientID %>,#<%= dtNgayCap.ClientID %>").datetimepicker({
               dateFormat: 'dd/mm/yy',
               altFormat: "dd/mm/yy",
               timeFormat: 'HH:mm',
               format: 'd/m/Y H:i'
           }).keyup(function (e) {
               if (e.keyCode == 8 || e.keyCode == 46) {
                   $(this).mask('');
                   $(this).val('');

               }
           });
       });
       document.onkeydown = keyHandler;
       function keyHandler(e) {

           var pressedKey;
           if (document.all) {
               e = window.event;
               pressedKey = e.keyCode;
           }

           if (e.which) {
               pressedKey = e.which;
           }
      
           if (pressedKey == 117) { //f6-
               var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdView");
               templateButton.click();
           }
           else if (pressedKey == 123) { //f12-
               var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdAdd");
                templateButton.click();
               
           }
          
           else if (pressedKey == 118) { //f7-Filter
               var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdFilter");
               templateButton.click();
           }
           else if (pressedKey == 120) { //f9-In
               var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdPrint");
               templateButton.click();
           }
           else if (pressedKey == 121) { //f10-thoat
               var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdExit");
               templateButton.click();

           }
       }
   </script> 
     </telerik:RadCodeBlock>
    <telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
        <AjaxSettings>
        </AjaxSettings>
    </telerik:RadAjaxManagerProxy>
    <div >
         <telerik:RadToolBar ID="baraction" runat="server"
           EnableRoundedCorners="true"
        EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width ="100%" >
             <Items >  
                 <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="F2-Ghi " Group="Align" CheckOnClick="false" Value="cmdSave" CommandName="cmdSave">
                </telerik:RadToolBarButton>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                    Text="In Giấy nghỉ dưỡng thai" CheckOnClick="false" Value="cmdPrint">
                </telerik:RadToolBarButton>
               <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                Text="F10-Thoát"  CheckOnClick="false" Value ="cmdExit" >
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="F6-Xem"   CssClass="ButtonCSS" Value ="cmdView">
            </telerik:RadToolBarButton>
            </Items>
         </telerik:RadToolBar>
        </div>
      <fieldset align="center">
            <legend>
               <asp:Label ID="Label3" runat="server" Text="Thông tin bệnh nhân" Font-Bold="true"></asp:Label>
            </legend> 
    <div style="align-content:center!important">
        <table  align="left" >
                            <tr>
                                <td Width="5%">
                                    <asp:Label ID="Label1" runat="server" Text="Họ tên:" Width="70px"></asp:Label>
                                </td>
                                <td width="20%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtHoTen" Enabled="false" style="width:96% !important"></asp:TextBox>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label2" runat="server" Text="Giới tính" Width="70px"></asp:Label>
                                </td>
                                <td colspan ="2"  Width="10%" > 
                                   <asp:RadioButtonList TabIndex="1" ID="lblGioitinh" runat="server" RepeatDirection="Horizontal" Enabled="false">
                                        <asp:ListItem Value="1">Nam</asp:ListItem>
                                        <asp:ListItem Value="0" Selected ="True">Nữ</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label37" runat="server" Text="Ngày sinh" ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNgaySinh" Enabled="false" style="width:96% !important"></asp:TextBox>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label39" runat="server" Text="Tuổi(*)"></asp:Label>
                                </td>
                                <td width="5%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtTuoi" Width="50px" Enabled="false" onchange="subtinhtuoi1(this)"></asp:TextBox>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label41" runat="server" Text="Mã BN" Width="40px"></asp:Label>
                                </td>
                                <td width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtMaQL" Width="100%" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
            <tr>
                <td>
                                    <asp:Label ID="Label36" runat="server" Text="Người đại diện ký(*):" Width="70px"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNguoiThan" style="width:96% !important"></asp:TextBox>
                                </td>
                <td>
                       <asp:Label ID="Label40" runat="server" Text="Số CMND(*): "></asp:Label>
                      </td>
                    <td colspan="2">
                    <asp:TextBox runat="server" ID="txtSoCMND"></asp:TextBox>
                    </td>
                <td>
                       <asp:Label ID="Label42" runat="server" Text="Ngày cấp CMND(*): "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtNGAYCAP_CMND"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label38" runat="server" Text="Nơi cấp(*): "></asp:Label>
                      </td>
                    <td colspan="3">
                    <asp:TextBox runat="server" ID="txtNoiCapCMND"></asp:TextBox>
                    </td>
            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label43" runat="server" Text="Nghề nghiệp"></asp:Label>
                                </td>
                               <td>
                                    <asp:TextBox ID ="txtNgheNghiep"  runat="server"  CssClass="span-all" style="width:96% !important" Enabled="false"></asp:TextBox>
                                </td>
                               <td>
                                    <asp:Label ID="Label5" runat="server" Text="Đơn vị:"></asp:Label>
                                </td>
                                    <td colspan ="2">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtDonVi" Width="100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label50" runat="server" Text="Địa chỉ:"></asp:Label>
                                </td>
                                    <td colspan ="3">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtDiaChi" Width="100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="Điện thoại:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtDienThoai" style="width:100% !important"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label55" runat="server" Text="Số thẻ " ></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtSoThe" 
                                         Enabled="false" AutoPostBack="false"  MaxLength="16"
                                       style="width:96% !important"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label33" runat="server" Text="Số giấy:" ></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtSoGiayNT" 
                                         AutoPostBack="false" Enabled="false"
                                       style="width:96% !important"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label35" runat="server" Text="Ngày bắt đầu nghỉ:" ></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNgayVao" 
                                         AutoPostBack="false" 
                                       style="width:96% !important"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Ngày kết thúc nghỉ:" ></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNgayRa" 
                                         AutoPostBack="false" 
                                       style="width:96% !important"></asp:TextBox>
                                </td>
                                
                                
                                <td>
                                    <asp:Label ID="Label34" runat="server" Text="Ngày cấp giấy:" ></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNgayCap" 
                                         AutoPostBack="false" 
                                       style="width:96% !important"></asp:TextBox>
                                </td>
                                
                            </tr>
            <tr>
                <td><asp:Label ID="Label31" runat="server" Text="Chẩn đoán:"></asp:Label></td>
                        <td><telerik:RadComboBox                  runat="server" ID="cbocdravien" DataSourceID="ObjectDanhMucBenh"
                                                     EnableLoadOnDemand="true" DropDownWidth ="470px"
                                                    ItemsPerRequest="20" 
                                                    ShowMoreResultsBox="true"
                                                     ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                                    EnableAutomaticLoadOnDemand="true" Width ="100%"
                                                  HighlightTemplatedItems="true" 
                                                  MarkFirstMatch="true" 
                                                DataValueField="MaBenhID" 
                                                 DataTextField="MaICDTen"  Filter="Contains"
                                                 OnItemDataBound="cboBenh_ItemDataBound">
                                                  <HeaderTemplate>
                                                        <table class="NHTC_table_layout">
                                                            <tr>
                                                                    <td width="70px">Mã ICD</td>
                                                                    <td width="400px">Tên bệnh</td>
                                                            </tr>
                                                        </table>
                                                    </HeaderTemplate>
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                                    </Items>
                                                    <ItemTemplate>
                                                        <table>
                                                            <tr>
                                                                <td width="70px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "MaICD")%>
                                                                </td>
                                                                <td width="400px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "TenBenh") %>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                            </telerik:RadComboBox></td>
                <td>
                                        <asp:Label ID="Label58" runat="server" Text="Bác sĩ: "></asp:Label>
                                    </td>
                                    <td colspan="3" style="padding-right:0px"> 
                                        <telerik:RadComboBox                    runat="server" ID="cboBS"
                                             AppendDataBoundItems="True"
                                             AutoPostBack="false" DataSourceID="ObjectDanhMucNV"
                                            DataTextField="MaNVHoTen" DataValueField="MaNV"  DropDownWidth ="470px" CssClass="span-all"
                                             EnableVirtualScrolling="true" Width ="100%"
                                            EnableLoadOnDemand="true" TabIndex="1"
                                            ItemsPerRequest="50"
                                            ShowMoreResultsBox="true"
                                            
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true"                
                                            MarkFirstMatch="true" 
                                             ExpandDirection="Down" Filter="Contains"
                                            HighlightTemplatedItems="true"  >
                                            <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                       <td width="200px">Họ tên</td>
                                                        <td width="200px">Khoa</td>
                                                        <td width="70px">Mã NV</td>
                                                    </tr>
                                                </table>
                                            </HeaderTemplate>
                                            <Items>
                                                <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                            </Items>
                                            <ItemTemplate>
                                                <table class="NHTC_table_layout">

                                                    <tr>

                                                        <td width="200px">
                                                            <%# DataBinder.Eval(Container.DataItem, "HoTen") %>
                                                        </td>
                                                        <td width="200px">
                                                            <%# DataBinder.Eval(Container.DataItem, "TenKhoa") %>
                                                        </td>
                                                        <td width="70px">
                                                            <%# DataBinder.Eval(Container.DataItem, "MaNV") %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </telerik:RadComboBox>
                                    </td>
                <td>
                    <asp:CheckBox ID="chkHuy" runat="server" Text="Hủy"/>
                    </td>
            </tr>
                        </table> 
             </div>
          </fieldset>
        
    <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="ObjectDanhMucBenh" runat="server" SelectMethod="FindDMBenhTatByMa"
        TypeName="HTC.Business.CategoryList.DMBenhTatList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
                <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" 
        CacheDuration="60" ID="ObjectDanhMucNV" runat="server" 
        SelectMethod="FindDMNhanVienByFilter"
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="dk" Type="String" DefaultValue=" and len(isnull(a.MaChungChiHanhNghe,''))>0" />
            <asp:Parameter Name="dkfilter" Type="String" DefaultValue="" />
        </SelectParameters>
                </asp:ObjectDataSource>
</asp:Content>

