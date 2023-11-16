<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmRaVienNoiTru.aspx.cs" Inherits="UI_NoiTru_KhamBenh_frmRaVienNoiTru" %>

<%--<%@ Import Namespace="HTC.Business.NoiTru" %>
<%@ Import Namespace="HTC.Business.CategoryList" %>--%>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%-- <%@ Register Src="~/UserControls/HTCReportViewer.ascx" TagName="HTCReportViewer" TagPrefix="uc1" %> --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
       
    <telerik:radcodeblock id="RadCodeBlock1" runat="server">
 <%-- <script type="text/javascript" src='<%: ResolveUrl("~/js/jquery.min.js") %>'></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>--%>

        <style type="text/css">

            table td {
                
            }

            div.contentWrapper table td:nth-child(1) {
                  width: 120px;
                }

        </style>
        <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.js")%>' type="text/javascript"></script>
    <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.datetimepicker.js")%>' type="text/javascript"></script>
    <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
    <link href='<%: ResolveUrl("~/css/datetimepicker/jquery.datetimepicker.css")%>' rel="stylesheet" />

        <script type="text/javascript">
            function StopPropogation(e, objTextArea) {

                if (e.keyCode == "13") {
                    objTextArea.value = objTextArea.value + '\n';

                    return false;

                }
                return true;

            }
            $(function () {
                $("#<%= dtNgayTV.ClientID %>").datetimepicker({
                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y H:i'
                }).keyup(function (e) {
                    if (e.keyCode == 8 || e.keyCode == 46) {
                        $(this).mask('');
                        $(this).val('');

                    }
                });
            });
            $(function () {
                $("#<%= dtngayravien.ClientID %>").datetimepicker({
                        dateFormat: 'dd/mm/yy',
                        altFormat: "dd/mm/yy",
                        timeFormat: 'HH:mm',
                        format: 'd.m.Y H:i'
                    }).keyup(function (e) {
                        if (e.keyCode == 8 || e.keyCode == 46) {
                            $(this).mask('');
                            $(this).val('');

                        }
                    });
            });
            $(function () {
                $("#<%= dtngayravien.ClientID %>,#<%= dttungay_bhxh.ClientID%>,#<%= dtdenngay_bhxh.ClientID%>,#<%= dtngaycap_bhxh.ClientID%>,#<%= dtNGAY_CHUNG_TU_RaVien.ClientID%>").datetimepicker({
                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y H:i'
                }).keyup(function (e) {
                    if (e.keyCode == 8 || e.keyCode == 46) {
                        $(this).mask('');
                        $(this).val('');

                    }
                });
            });
            $(function () {
                $("#<%= dtNgayLuu.ClientID %>").datetimepicker({
                        dateFormat: 'dd/mm/yy',
                        altFormat: "dd/mm/yy",
                        timepicker: false,
                        format: 'd.m.Y',
                        defaultDate: ''
                    }).keyup(function (e) {
                        if (e.keyCode == 8 || e.keyCode == 46) {
                            $(this).mask('');
                            $(this).val('');

                        }
                    });
                });
            $(function () {
                $("#<%= dtNgayTV.ClientID %>").datetimepicker({
                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timepicker: false,
                    format: 'd.m.Y',
                    defaultDate: ''
                }).keyup(function (e) {
                    if (e.keyCode == 8 || e.keyCode == 46) {
                        $(this).mask('');
                        $(this).val('');

                    }
                });
            });
            $(document).ready(function () {
                $("#<%= dtngayravien.ClientID %>,#<%= dttungay_bhxh.ClientID%>,#<%= dtdenngay_bhxh.ClientID%>,#<%= dtngaycap_bhxh.ClientID%>,#<%= dtNGAY_CHUNG_TU_RaVien.ClientID%>").mask("99/99/9999 99:99");
                
                //$("#<%= dtngayravien.ClientID %>").mask("99/99/9999 99:99");
                $("#<%= dtNgayVV.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgaySinh.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgayTV.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgayLuu.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgayTV.ClientID %>").blur(function () {
                    var dateRegEx = /^(0?[1-9]|[12][0-9]|3[01])[\/\-\.](0?[1-9]|1[012])[\/\-\.](\d{4})$/;
                    var validTime = $(this).val().match(dateRegEx);
                    if (!validTime) {

                    } else {
                        var year = validTime[3];
                        var month = validTime[2] * 1;
                        var day = validTime[1] * 1;
                        var checkdate = new Date(month + "/" + day + "/" + year);

                        var currentdate = new Date();

                        if ((month != checkdate.getMonth() + 1)) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày tháng không hợp lệ ");
                        }

                        if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) < 0) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày phải trước ngày hiện tại");
                        }

                        else
                            $(this).css('background', 'transparent');
                    }
                });
                $("#<%= dtNgaySinh.ClientID %>").blur(function () {
                    var dateRegEx = /^(0?[1-9]|[12][0-9]|3[01])[\/\-\.](0?[1-9]|1[012])[\/\-\.](\d{4})$/;
                    var validTime = $(this).val().match(dateRegEx);
                    if (!validTime) {
                        $(this).val('').focus().css('background', '#fdd');
                        alert("Ngày không hợp lệ");
                    } else {
                        var year = validTime[3];
                        var month = validTime[2] * 1;
                        var day = validTime[1] * 1;
                        var checkdate = new Date(month + "/" + day + "/" + year);

                        var currentdate = new Date();

                        if ((month != checkdate.getMonth() + 1)) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày tháng không hợp lệ");
                        }

                        if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) < 0) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày phải trước ngày hiện tại");
                        }

                        else
                            $(this).css('background', 'transparent');
                    }
                });
            });

            function GridCreated(sender, args) {
                var scrollArea = sender.GridDataDiv;
                var parent = $get("gridContainer");
                var gridHeader = sender.GridHeaderDiv;
                scrollArea.style.height = parent.clientHeight -
                  gridHeader.clientHeight + "px";
            }


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

                if (pressedKey == 113) { //f2 - GHI
                    var toolbar1 = $find("<%= baraction.ClientID %>");
                    var templateButton = toolbar1.findItemByValue("cmdSave");
                    templateButton.click();
                }
                else if (pressedKey == 121) { //f10-thoat
                    var toolbar1 = $find("<%= baraction.ClientID %>");
                        var templateButton = toolbar1.findItemByValue("cmdExit");
                        templateButton.click();
                    }
            }


            function comboSelectedIndexChangedBV(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh vien
                var tenbv = item.get_attributes().getAttribute("TenBV");
                var obbenhvien = document.getElementById("<%= txtTenBV.ClientID %>");

               obbenhvien.value = tenbv; var input = combo.get_inputDomElement();
           }
           function comboSelectedIndexChangedVV(sender, eventArgs) {
               var item = eventArgs.get_item();

               // get the text and value elements
               var val = item.get_value();
               // benh
               var tenbenh = item.get_attributes().getAttribute("TenBenh");
               var obbenh = document.getElementById("<%= txtBenhVao.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  
            obbenh.value = tenbenh; var input = combo.get_inputDomElement();
        }
        function comboSelectedIndexChangedRV(sender, eventArgs) {
            var item = eventArgs.get_item();

            // get the text and value elements
            var val = item.get_value();
            // benh
            var tenbenh = item.get_attributes().getAttribute("TenBenh");
            var obbenh = document.getElementById("<%= txtBenhRa.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }
            function comboSelectedIndexChangedKBTYHCT(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");
                var obbenh = document.getElementById("<%= txtChanDoanTheoYHCT.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }
            function comboSelectedIndexChangedKem(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_text();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");
                var obbenh = document.getElementById("<%= txtBenhKem.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  

                var maicd = val;

                if (obbenh.value == "" && maicd.length > 20)
                    obbenh.value = maicd;
                else if (obbenh.value == "")
                    obbenh.value = maicd + "-" + tenbenh;
                else if (maicd.length > 20)
                    obbenh.value = obbenh.value + ";   " + maicd;

                else
                    obbenh.value = obbenh.value + ";   " + maicd + "-" + tenbenh;

                var input = combo.get_inputDomElement();
            }
            function comboSelectedIndexChangedGP(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");
                var obbenh = document.getElementById("<%= txtBenhGP.ClientID %>");
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }
            function processClick(sender, args) {
                var commandName = args.get_item().get_commandName();

                if (commandName == 'cmdExit') {

                    window.opener = null;
                    window.close();

                }
            }
        </script>

    </telerik:radcodeblock>

    <telerik:radtoolbar ID="baraction" runat="server" OnClientButtonClicked="processClick"
           EnableRoundedCorners="true"
        EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width ="100%" >
        <Items>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="F2 - Ra viện" CheckOnClick="false" Value="cmdSave" CommandName="cmdSave" >
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                 Text="F9-In" CheckOnClick="false" Value="cmdPrint" CommandName="cmdPrint">
             </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/exitprint.png" Visible="false" 
                Text="Ðóng báo cáo"  Value ="exitcmdPrint" >
             </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif" 
                Text="Up load" CheckOnClick="false" Value="cmdUpLoad" CommandName="cmdUpLoad">
            </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="Xem file" CheckOnClick="false" Value="cmdXemFile" CommandName="cmdXemFile">
            </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif" 
                Text="Thông tin BA" CheckOnClick="false" Value="cmdThongTinBA" CommandName="cmdThongTinBA">
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif" 
                Text="Tóm tắt BA" CheckOnClick="false" Value="cmdTomTatBA" CommandName="cmdTomTatBA">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg" CheckOnClick="false"
                Text="F10-Thoát" Value="cmdExit" CommandName="cmdExit">
            </telerik:RadToolBarButton>
          

        </Items>
    </telerik:radtoolbar>



    <div style="clear: both">
        &nbsp;
    </div>
       <div align="center">
         <%--<uc1:HTCReportViewer ID="HTCReportViewer1" runat="server"/>--%>
    </div>
     <div align="center">
         <%--<uc1:HTCReportViewer ID="HTCReportViewer2" runat="server" />--%>
    </div>
     <div align="center">
         <%--<uc1:HTCReportViewer ID="HTCReportViewer3" runat="server" />--%>
    </div>
      <div align="center">
         <%--<uc1:HTCReportViewer ID="HTCReportViewer4" runat="server" />--%>
    </div>
      <div>
        <asp:FileUpload ID="fuFileUploader" runat="server" text="Upfile" Visible ="false" />
      </div>
    <div class="form-container">
       
        <fieldset align="center" class="align-right-container">                       
           <legend >
                <label>
                    Thông tin bệnh nhân
                </label>
            </legend>

            <table  width="98%">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Mã QL"></asp:Label>
                    </td>
                    <td width ="200px">
                        <asp:TextBox runat="server" ID="txtMaQL" Enabled="false"></asp:TextBox>
                    </td> 
                    
                      <td>
                        <asp:Label ID="Label2" runat="server" Text="Họ tên"></asp:Label>
                    </td>
                    <td width ="200px">
                        <asp:TextBox runat="server" ID="txtHoTen" Enabled="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Ngày sinh"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="dtNgaySinh" Enabled="false"></asp:TextBox>
                      </td>
                     <td>
                        <asp:Label ID="Label4" runat="server" Text="Giới tính"></asp:Label>
                         &nbsp;
                         <asp:Label runat="server" Text="" ID="lblGioiTinh"></asp:Label>
                    </td>                                       
                </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label5" runat="server" Text="Ngày VV"></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtNgayVaoKhoa" Enabled="false"></asp:TextBox>
                    </td>
                    <td >
                        <asp:Label ID="Label15" runat="server" Text="Tên khoa"></asp:Label>
                    </td>
                    <td width ="200px">
                        <asp:TextBox runat="server" ID="txtTenKhoa" Enabled="false" Style="width: 100% !important;"></asp:TextBox>
                    </td>
                   

                    <td>
                        <asp:Label ID="Label18" runat="server" Text="Tên đối tượng"></asp:Label>
                    </td>
                    <td colspan ="3">
                        <asp:TextBox runat="server" ID="txtTenDoiTuong" Enabled="false" Style="width: 100% !important;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                        <td>
                       <asp:Label ID="Label37" runat="server" Text="Ngày bắt đầu nghỉ việc hưởng BHXH: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dttungay_bhxh"></asp:TextBox>
                    </td>
                        <td>
                       <asp:Label ID="Label38" runat="server" Text="Ngày kết thúc nghỉ việc hưởng BHXH: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtdenngay_bhxh"></asp:TextBox>
                    </td>
                        <td>
                       <asp:Label ID="Label39" runat="server" Text="Ngày cấp giấy CN nghỉ việc hưởng BHXH: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtngaycap_bhxh"></asp:TextBox>
                    </td>
                        <td>
                       <asp:Label ID="Label40" runat="server" Text="Ngày cấp giấy ra viện: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtNGAY_CHUNG_TU_RaVien"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                     <td>
                       <asp:Label ID="Label41" runat="server" Text="Họ tên cha: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txthotencha"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label42" runat="server" Text="Họ tên mẹ: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txthotenme"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label43" runat="server" Text="Người giám hộ: "></asp:Label>
                      </td>
                    <td colspan="3">
                    <asp:TextBox runat="server" ID="txtnguoigiamho"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:Label ID="Label44" runat="server" Text="Số CMND: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txtSoCMND"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label45" runat="server" Text="Ngày cấp CMND: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="dtNGAYCAP_CMND"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label46" runat="server" Text="Nơi cấp: "></asp:Label>
                      </td>
                    <td colspan="3">
                    <asp:TextBox runat="server" ID="txtNoiCapCMND"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                                        <asp:Label ID="Label47"   runat="server" Text="Trưởng khoa:"></asp:Label>
                                    </td>
                                    <td >                                                                         
                                             <telerik:RadComboBox                  ID="cboTruongKhoa" runat="server" AppendDataBoundItems="True"
                                             AutoPostBack="false" DataSourceID="ObjectDanhMucNV"
                                            DataTextField="HoTen" DataValueField="MaNV"  DropDownWidth ="470px" CssClass="span-all"
                                             EnableVirtualScrolling="true" 
                                            EnableLoadOnDemand="true"
                                            ItemsPerRequest="20"
                                            ShowMoreResultsBox="true"
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true"                
                                            MarkFirstMatch="true" 
                                             ExpandDirection="Down" Filter="Contains"
                                            HighlightTemplatedItems="true"

                                             >
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
                                                <table>
                                                   
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
                       <asp:Label ID="Label48" runat="server" Text="Nơi LV: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txtNoiLV"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label49" runat="server" Text="Mã số BHXH: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txtMaSoBHXH"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label50" runat="server" Text="Số Seri: "></asp:Label>
                      </td>
                    <td>
                    <asp:TextBox runat="server" ID="txtSoSeri"></asp:TextBox>
                    </td>
                </tr>
            </table>

        </fieldset>
        </div>
    <div>
       

        <telerik:radtabstrip runat="server"
              ID="RadTabStrip1"
            Align="Justify"
            AutoPostBack="True"
            MultiPageID="RadMultiPage1"
            SelectedIndex="0"
            Width="100%"
            ClickSelectedTab="True"
            OnTabClick="RadTabStrip1_TabClick"
            >
           
                    <Tabs>
                       <telerik:RadTab Text="Tình trạng ra viện" Value="0"></telerik:RadTab>
                        <telerik:RadTab runat="server" Text="Huớng diều trị" Value="1"></telerik:RadTab>
                        <telerik:RadTab runat="server" Text="Nguyên nhân tử vong" Value="2" Selected="True"></telerik:RadTab>
                    </Tabs>
                    
                    
                </telerik:radtabstrip>

        <telerik:radmultipage runat="server" id="RadMultiPage1" selectedindex="0" Width="100%">
                    <telerik:RadPageView runat="server" ID="RadPageView1" Width="100%" selectedindex="0">
                     
                        <div class="contentWrapper">

                    <fieldset align="center">
                        <legend>
                            <label>
                            </label>
                        </legend>

                        <div align="center">

                            <table class="data-form-in-grid" width="98%" cellpadding="4px" cellspacing="4px">
                                <tr>
                                    <td width="20px">
                                        <asp:Label ID="Label6" runat="server" Text="Ngày ra viện(*)"></asp:Label>
                                    </td>
                                    <td width ="100px" >
                                        <asp:TextBox  runat="server" ID="dtngayravien"></asp:TextBox>
                                    </td>
                                     <td width="100px">
                                         <asp:CheckBox ID="chkchuyenBA" width ="100px" runat="server" Text="BA về KHTH" AutoPostBack="false"   />
                                     </td>            
                                     <td width="60px">
                                        <asp:Label ID="Label17" runat="server" Text="Mã lưu trữ"></asp:Label>
                                    </td>
                                    <td  width="70px" >
                                        <asp:TextBox runat="server" ID="txtmaluutru"></asp:TextBox>
                                    </td>
                                    <td width="60px">
                                        <asp:Label ID="Label32" runat="server" Text="Ngày lưu"></asp:Label>
                                    </td>
                                    <td width ="80px" >
                                        <asp:TextBox  runat="server" ID="dtNgayLuu"></asp:TextBox>
                                    </td>
                                    <td width="90px" >
                                        <asp:Label ID="Label13"   runat="server" Text="BS cho ra viện"></asp:Label>
                                    </td>
                                    <td >                                                                         
                                             <telerik:RadComboBox                  ID="cboBacSy" runat="server" AppendDataBoundItems="True"
                                             AutoPostBack="false" DataSourceID="ObjectDanhMucNV"
                                            DataTextField="HoTen" DataValueField="MaNV"  DropDownWidth ="470px" CssClass="span-all"
                                             EnableVirtualScrolling="true" 
                                            EnableLoadOnDemand="true"
                                            ItemsPerRequest="20"
                                            ShowMoreResultsBox="true"
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true"                
                                            MarkFirstMatch="true" 
                                             ExpandDirection="Down" Filter="Contains"
                                            HighlightTemplatedItems="true"

                                             >
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
                                                <table>
                                                   
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
                              
                                </tr>
                               <tr>
                                    <td>
                                        <asp:Label ID="Label12" runat="server" Text="Kết quả ÐT(*)"></asp:Label>
                                    </td>
                                    <td colspan="4">
                                        <telerik:RadComboBox                  runat="server" ID="cboKQDT" DataSourceID="odsKQDT" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>
                                    </td>
                                     <td>
                                        <asp:Label ID="Label7" runat="server" Text="Loại BA"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <telerik:RadComboBox                  runat="server" ID="cboLoaiBA" DataSourceID="odsLoaiBA" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>
                                    </td>
                                </tr>

                                 <tr>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="HT Ra viện"></asp:Label>
                                    </td>
                                    <td colspan="4">
                                        <telerik:RadComboBox                  runat="server" ID="cboHTravien" DataSourceID="odsHTravien" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>
                                    </td>
                                     <td>
                                        <asp:Label ID="Label10" runat="server" Text="Giải phẫu bệnh"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <telerik:RadComboBox                  runat="server" ID="cboGPbenh" DataSourceID="odsGPbenh" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>
                                    </td>

                                </tr>
                               
                               
                                  <tr>
                                <td >
                                    <asp:Label ID="Label28" runat="server" Text="CÐ Vào viện"></asp:Label>
                                </td>
                                <td  align="left">
                                     <telerik:RadComboBox                  runat="server" 
                                         
                                          ID="cboCDVaoVien" DataSourceID="ObjectDanhMucBenh"
                                            EnableLoadOnDemand="true"
                                            ItemsPerRequest="20"
                                            ShowMoreResultsBox="true"
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true" Width ="100%"
                                        DataValueField="MaBenhID" 
                                         HighlightTemplatedItems="true"  MarkFirstMatch="true"
                                         DataTextField="MaICDTen"  Filter="Contains" DropDownWidth ="470px"
                                            OnItemDataBound="cboBenh_ItemDataBound"
                                      
                                         OnClientSelectedIndexChanged="comboSelectedIndexChangedVV"
                                         
                                         >
                                          <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                            <td  width="70px">Mã ICD</td>
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
                                    </telerik:RadComboBox>
                                   </td>
                      <td colspan ="7">
                                      <asp:TextBox runat="server" ID="txtBenhVao"  CssClass="span-all"></asp:TextBox>
                                  
                                </td>
                                      </tr>
                                <tr>
                                <td  >
                                    <asp:Label ID="Label8" runat="server" Text="CÐ Ra viện(*)" style="padding-left:20px"></asp:Label>
                                </td>
                                <td >

                                  
                                          <telerik:RadComboBox                  runat="server" ID="cbocdravien" DataSourceID="ObjectDanhMucBenh"
                                                     EnableLoadOnDemand="true" DropDownWidth ="470px"
                                                    ItemsPerRequest="20" 
                                                    ShowMoreResultsBox="true"
                                                     ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                                    EnableAutomaticLoadOnDemand="true" Width ="100%"
                                                  HighlightTemplatedItems="true" 
                                                  MarkFirstMatch="true" 
                                                DataValueField="MaBenhID" 
                                                 DataTextField="MaICDTen"  Filter="Contains"
                                          

                                                 OnItemDataBound="cboBenh_ItemDataBound"
                                                 OnClientSelectedIndexChanged="comboSelectedIndexChangedRV">
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
                                            </telerik:RadComboBox> 
                                    </td>                                    
                                   <td colspan ="7">
                                        <asp:TextBox runat="server" ID="txtBenhRa"  CssClass="span-all" ></asp:TextBox>                                  
                                                               
                                </td>                               
                                      </tr>
                                 <tr>
                                
                               
                                <td  >
                                    <asp:Label ID="Label29" runat="server" Text="CÐ kèm" style="padding-left:50px"></asp:Label>
                                </td>
                                <td >

                                          <telerik:RadComboBox                  runat="server" ID="cboCDKem" DataSourceID="ObjectDanhMucBenh"
                                                     EnableLoadOnDemand="true" DropDownWidth ="470px"
                                                    ItemsPerRequest="20" 
                                                    ShowMoreResultsBox="true"
                                                     ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                                    EnableAutomaticLoadOnDemand="true" Width ="100%"
                                                  HighlightTemplatedItems="true" 
                                                  MarkFirstMatch="true" 
                                                DataValueField="MaBenhID" 
                                                 DataTextField="MaICDTen"  Filter="Contains"
                                          

                                                 OnItemDataBound="cboBenh_ItemDataBound"
                                                 OnClientSelectedIndexChanged="comboSelectedIndexChangedKem">
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
                                            </telerik:RadComboBox>                                     
                                   </td>  
                                    <td colspan ="7">
                                        <asp:TextBox runat="server" ID="txtBenhKem"  CssClass="span-all" ></asp:TextBox>                                  
                                    </td>                       
                                                             
                                      </tr>
                                 <tr id="ChanDoanYHCT" runat="server" >
                                    <td>
                                        <asp:Label ID="lblChanDoanYHCT" runat="server" >
                                            Chẩn doán Ra viện theo YHCT
                                        </asp:Label>
                                        
                                    </td>
                                    <td>
                                        <telerik:RadComboBox ID="cboChanDoanTheoYHCT" runat="server"
                                            AppendDataBoundItems="True" CssClass="span-all"
                                            DataSourceID="ObjectDanhMucBenhDanh"
                                            AutoPostBack="false"
                                            DataTextField="MaICDTen" Filter="Contains" DataValueField="MaBenhID"
                                            DropDownWidth="470px"
                                            EnableVirtualScrolling="true"
                                            EnableLoadOnDemand="true"
                                            ItemsPerRequest="20"
                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"
                                            EnableAutomaticLoadOnDemand="true"
                                            MarkFirstMatch="true"
                                            casesensitive="false"
                                            HighlightTemplatedItems="true"
                                            OnItemDataBound="cboBenhYHCT_ItemDataBound"
                                            OnClientSelectedIndexChanged="comboSelectedIndexChangedKBTYHCT"
                                            Width="100%">
                                            <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                        <td>Mã ICD</td>
                                                        <td>Tên bệnh</td>
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
                                        </telerik:RadComboBox>

                                    </td>
                                    <td colspan="7">
                                        <asp:TextBox runat="server" ID="txtChanDoanTheoYHCT"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="GhichuChanDoan" runat="server">
                                    <td>
                                     <asp:Label ID="Label34" runat="server" >
                                            Ghi chú
                                        </asp:Label>
                                        </td>
                                     <td colspan ="7">
                                        <asp:TextBox runat="server" ID="txtGhiChuBenh"  CssClass="span-all" ></asp:TextBox>                                  
                                    </td>          
                                </tr>
                            </table>
                         </div>
                                </fieldset>                  
                        </div>
                         <br />
                         <br />
                         <br />
                    </telerik:RadPageView>
                                       
               
                    <telerik:RadPageView runat="server" ID="RadPageView2">
                         <br />
                         <br />
                         <br />
                        <div class="contentWrapper">
                            <fieldset align="center">
                        <legend>
                            <label>
                            </label>
                        </legend>
                        <div align="center">
                            <table cellpadding="5" cellspacing="5" class="data-form-in-grid" width="90%">
                                <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label21" width="100px" runat="server" Text="Bệnh lý"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtBenhLy" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                 <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label30" width="100px" runat="server" Text="Kết quả CLS"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtKetQuaCLS" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                
                                 <tr>
                                     <td>
                                        <asp:Label ID="Label14" runat="server" Text="Phương pháp ÐT"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtPhuongPhapDT" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                 <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label31" width="100px" runat="server" Text="Tình trạng nguời bệnh"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtTinhTrang" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                 <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label11" width="100px" runat="server" Text="Huớng điều trị"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtLoiDan" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                  <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label33" width="100px" runat="server" Text="Ghi chú"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtGhiChu" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label35" width="100px" runat="server" Text="Người vận chuyển"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtNguoiVanChuyen" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                     <td width="150px">
                                        <asp:Label ID="Label36" width="100px" runat="server" Text="Phương tiện vận chuyển"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtPhuongtienVC" TextMode="multiline"  onkeypress="return StopPropogation(event,this)" Height="30px" CssClass="span-all"></asp:TextBox>
                                    </td>
                                </tr>
                                </table  >
                            </div>

               <div align="center">
                    
                    <fieldset align="center" width="90%" style="width:90%;padding-left:20px">
                        <legend>
                            <label>
                                 Hướng điều trị tiếp theo
                            </label>
                        </legend>
      
                        <div>
                            <table cellpadding="3" cellspacing="3" class="data-form-in-grid" >                        
                                 <tr>
                                    
                                                  <td width="100px">
                                              <asp:Label ID="Label16" width="100px" runat="server" Text="Hướng điều trị"></asp:Label>
                                                 </td>
                                                  <td width ="200px" colspan ="2">
                                        <telerik:RadComboBox                  runat="server" ID="cboHuongDT" DataSourceID="odsHuongDT"  Width ="100%"
                                             AutoPostBack="true" OnSelectedIndexChanged="cboHuongDT_SelectedIndexChanged"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>

                                    </td>

                                             <td>
                                              <asp:Label ID="Label19" runat="server" Text="Ngày" Visible="false" ></asp:Label>
                                                 </td>
                                                <td width ="100px">
                                            <asp:TextBox runat="server" ID="dtNgayVV"  Visible="false"></asp:TextBox>
                                             </td>
                                     <td width ="100px"></td>
                                            </tr>
                                             <tr>
                                                   <td>
                                              <asp:Label ID="Label20" runat="server" Text="Noi chuyển"></asp:Label>
                                                 </td>
                                                 <td width ="80px">
                           <telerik:RadComboBox                  ID="cboNoiDK" runat="server" 
                                            AppendDataBoundItems="True" CssClass="span-all"
                                            DataSourceID="odsNoiDK"
                                            AutoPostBack="false"
                                           DataTextField="MaBHXHTenBV" Filter="Contains" DataValueField="MaBV"                                            
                                           DropDownWidth ="470px"
                                            EnableVirtualScrolling="true"                                            
                                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true"                
                                            ItemsPerRequest="20"

                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"                                                                                        
                                            MarkFirstMatch="true"                                                                                                                                                                                
                                            
                                           
                                            HighlightTemplatedItems="true"
                                            OnItemDataBound="cboBenhVien_ItemDataBound"
                                            OnClientSelectedIndexChanged="comboSelectedIndexChangedBV"
                                            

                                            Width="100%">
                                            <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                       
                                                            <td>Mã nơi ÐK</td>
                                                            <td>Tên BV</td>
                                                    </tr>
                                                </table>
                                            </HeaderTemplate>
                                            <Items>
                                                <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                            </Items>
                                            <ItemTemplate>
                                                <table>
                                                    <tr>
                                                     
                                                        <td align="right" width="70px">
                                                            <%# DataBinder.Eval(Container.DataItem, "MaBHXH")%>
                                                        </td>
                                                        <td width="400px">
                                                            <%# DataBinder.Eval(Container.DataItem, "TenBV") %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </telerik:RadComboBox>
                       </td>
                    <td colspan="4">
                       <asp:TextBox runat="server" ID="txtTenBV"  CssClass="span-all"></asp:TextBox>
                    </td>
                                             </tr>
                                             <tr>
                                                     <td>
                                              <asp:Label ID="Label22" runat="server" Text="Lý do chuyển" Visible ="false" ></asp:Label>
                                                 </td>
                                                  <td colspan="2">
                                        <telerik:RadComboBox                  runat="server" ID="cbolydochuyen" DataSourceID="odslydochuyen" Width ="100%" Visible ="false" 
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>

                                    </td>
                                                
                                             </tr>

                                         </table>
                                  </div> 
        </fieldset>
                            </div>
                                </fieldset>     
                               
                            </div>
                         <br />
                         <br />
                         <br />
                        </telerik:RadPageView>
                  
                    <telerik:RadPageView runat="server" ID="RadPageView3">
                         <br />
                         <br />
                         <br />
                             <div class="contentWrapper">
                            <fieldset align="center">
                        <legend>
                            <label>
                            </label>
                        </legend>
                        <div align="center">
                            <table cellpadding="5" cellspacing="5" class="data-form-in-grid" width="60%">
                                   
                                <tr>
                                     <td width ="100px">
                                              <asp:Label ID="Label23" width ="100px" runat="server" Text="Ngày tử vong"></asp:Label>
                                                 </td>
                                                <td colspan ="2">
                                            <asp:TextBox runat="server" ID="dtNgayTV"></asp:TextBox>
                                             </td>
                                     
                                               <td  colspan="2">
                         <asp:CheckBox ID="chkknTuthi" runat="server" Text="KN Tử thi" AutoPostBack="false" />
                     </td>         
                                       
                                </tr>
                                <tr>
                                    <td>
                                              <asp:Label ID="Label25" runat="server" Text="Th?i gian TV"></asp:Label>
                                                 </td>
                                                  <td colspan="2">
                                        <telerik:RadComboBox                  runat="server" ID="cboThoiGianTV" DataSourceID="odsThoiGianTV" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>

                                    </td>
                                     <td>
                                              <asp:Label ID="Label24" runat="server" Text="Lý do TV"></asp:Label>
                                                 </td>
                                       <td colspan="2" >
                                        <telerik:RadComboBox                  runat="server" ID="cboLyDoTV" DataSourceID="odsLyDoTV" Width ="100%"
                                             AutoPostBack="false"
                                            DataValueField="Key"
                                            DataTextField="Value">
                                        </telerik:RadComboBox>

                                    </td> 
                                </tr>
                                <tr>
                                    <td>
                                              <asp:Label ID="Label26" runat="server" Text="CÐ GP t? thi"></asp:Label>
                                                 </td>
                                    <td width ="70px">
                                                          <telerik:RadComboBox                  runat="server"  HighlightTemplatedItems="true"  MarkFirstMatch="true" ID="cboCDGiaiPhau" DataSourceID="ObjectDanhMucBenh"
                                             EnableLoadOnDemand="true" DropDownWidth ="470px"
                                            ItemsPerRequest="20" 
                                            ShowMoreResultsBox="true"
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true" Width ="70px"
                                        DataValueField="MaBenhID" 
                                         DataTextField="MaICDTen"  Filter="Contains"
                                         OnItemDataBound="cboBenh_ItemDataBound"
                                         OnClientSelectedIndexChanged="comboSelectedIndexChangedGP">
                                          <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                            <td>Mã ICD</td>
                                                            <td>Tên bệnh</td>
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
                                    </telerik:RadComboBox>
                                   </td>
                      <td colspan ="4">
                                      <asp:TextBox runat="server" ID="txtBenhGP"  Width ="100%"></asp:TextBox>
                                  
                                </td>
                                </tr>
                                <tr>
                                    <td>
                                              <asp:Label ID="Label27" runat="server" Text="Nguyên nhân TV"></asp:Label>
                                                 </td>
                                                <td colspan ="5">
                                            <asp:TextBox runat="server" ID="txtNguyennhanTV" CssClass="span-all"></asp:TextBox>
                                             </td>
                                </tr>
                                    </table>
                            </div>
                               </fieldset>
                            </div>

                        <br />
                         <br />
                         <br />
                        </telerik:RadPageView>
                        </telerik:radmultipage>


    </div>

    <div class="form-container">
    </div>


  
  
    <asp:ObjectDataSource ID="odsThoiGianTV" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMTGTVongListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsLyDoTV" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLDTVongListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odslydochuyen" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLoaiBNListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsHuongDT" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMHuongDTListcb" EnableViewState="true" >
         <SelectParameters>
            <asp:Parameter Name="loai" Type="byte" DefaultValue=1 />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsLoaiBA" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLoaiBAListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource  ID="odsKQDT" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMKQDTriListcb" EnableViewState="true">
         
    </asp:ObjectDataSource>

    <asp:ObjectDataSource  ID="odsHTravien" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMHTRaVienListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsGPbenh" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMGPBenhListcb" EnableViewState="true"></asp:ObjectDataSource>
      <asp:ObjectDataSource  ID="ObjectDanhMucNVDu" runat="server" SelectMethod="FindDMNhanVienByMa"
      
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
          <SelectParameters>
            <asp:Parameter Name="ma" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="ObjectDanhMucNV" runat="server" SelectMethod="FindDMNhanVienByMaKhoa"
       OnSelecting="ObjectDanhMucNV_Selecting"
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
          <SelectParameters>
            <asp:Parameter Name="makhoa" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="ObjectDanhMucBenh" runat="server" SelectMethod="FindDMBenhTatByMa"
        TypeName="HTC.Business.CategoryList.DMBenhTatList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
      <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="odsNoiDK" runat="server" SelectMethod="FindDMBenhVienByMa" TypeName="HTC.Business.CategoryList.DMBenhVienList" EnableViewState="true">
          <SelectParameters>
            <asp:Parameter Name="MaBV" Type="String" DefaultValue="" />
        </SelectParameters>
         </asp:ObjectDataSource>
     <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="ObjectDanhMucBenhDanh" runat="server" SelectMethod="FindDMBenhDanhByMa"
        TypeName="HTC.Business.CategoryList.DMBenhDanhList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>


   
</asp:Content>

