<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCode.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="FrmBenhAnNoiTruPK.aspx.cs" Inherits="UI_NoiTru_TiepDon_FrmBenhAnNoiTruPK" %>


<%-- <%@ Register Src="~/UserControls/HTCReportViewer.ascx" TagName="HTCReportViewer" TagPrefix="uc1" %> --%>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <style type="text/css">
            /*table td
			{
				border: 1px solid black;
			}*/
        </style>
        <%-- <script type="text/javascript" src='<%: ResolveUrl("~/js/jquery.min.js") %>'></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>--%>
        <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.js")%>' type="text/javascript"></script>
        <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.datetimepicker.js")%>' type="text/javascript"></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
        <link href='<%: ResolveUrl("~/css/datetimepicker/jquery.datetimepicker.css")%>' rel="stylesheet" />

        <script type="text/javascript">
            <%if (txtview.Value != "PS") %>
             <%{ %>
            $(function () {
                $("#<%= dtNgayVV.ClientID %>").datetimepicker({
                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y H:i'
                }).focus(function () {
                    var val = $(this).val();
                    //if (val == "")
                    //    $(this).datepicker({
                    //        dateFormat: "dd/mm/yy",
                    //        timeFormat: 'HH:mm'
                    //    }).datepicker("setDate", new Date());
                });
            });
            $(function () {
                $("#<%= dtNgayChuyen.ClientID %>,#<%= dtNgaySinh.ClientID %>,#<%= dtBHYTTN.ClientID %>,#<%= dtBHYTDN.ClientID %>").datetimepicker({
                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timepicker: false,
                    format: 'd.m.Y'
                }).keyup(function (e) {
                    if (e.keyCode == 8 || e.keyCode == 46) {
                        $(this).mask('');
                        $(this).val('');

                    }
                });
            });
            <%}%>
            $(document).ready(function () {
                $("#<%= dtNgayChuyen.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgayVV.ClientID %>").mask("99/99/9999 99:99");
                $("#<%= dtNgaySinh.ClientID %>").mask("99/99/9999");
                $("#<%= dtBHYTTN.ClientID %>").mask("99/99/9999");
                $("#<%= dtBHYTDN.ClientID %>").mask("99/99/9999");

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
                            alert("Ngày tháng không hợp lệ ");
                        }

                        if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) < 0) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày phải trước dtngaydukiende");
                        }

                        else
                            $(this).css('background', 'transparent');
                    }
                });
                $("#<%= dtBHYTDN.ClientID %>").blur(function () {
                    var dateRegEx = /^(0?[1-9]|[12][0-9]|3[01])[\/\-\.](0?[1-9]|1[012])[\/\-\.](\d{4})$/;
                    var validTime = $(this).val().match(dateRegEx);
                    if (this.value == "__/__/____") this.value = "";
                    if (this.value != "")
                        if (!validTime) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày không hợp lệ");
                        } else {
                            var year = validTime[3];
                            var month = validTime[2] * 1;
                            var day = validTime[1] * 1;
                            var checkdate = new Date(month + "/" + day + "/" + year);
                            if ((month != checkdate.getMonth() + 1)) {
                                $(this).val('').focus().css('background', '#fdd');
                                alert("Ngày không hợp lệ");
                            }
                            var currentdate = new Date();
                            if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) > 0) {
                                $(this).val('').focus().css('background', '#fdd');
                                alert("Hạn dùng phải sau ngày hiện tại");
                            }
                            else
                                $(this).css('background', 'transparent');
                        };
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
                else if (pressedKey == 120) { //f9-In
                    var toolbar1 = $find("<%= baraction.ClientID %>");
                    var templateButton = toolbar1.findItemByValue("cmdPrint");
                    templateButton.click();
                }
    }
    function subtinhtuoi1(sender, eventArgs) {
        var dtns = document.getElementById("<%= dtNgaySinh.ClientID %>");
       var txttuoi = document.getElementById("<%= txttuoi.ClientID %>");

       var d = new Date();
       if (txttuoi.value != "")
           dtns.value = "01/01/" + (d.getFullYear() - txttuoi.value).toString();


   }
   function subtinhtuoi2(sender, eventArgs) {
       var dtns = document.getElementById("<%= dtNgaySinh.ClientID %>");
       var txttuoi = document.getElementById("<%= txttuoi.ClientID %>");

       var d = new Date();
       if (dtns.value.length > 9)
           txttuoi.value = d.getFullYear() - parseInt(dtns.value.substr(dtns.value.length - 4), 10);
       if (d.getFullYear() - parseInt(dtns.value.substr(dtns.value.length - 4), 10) == 0) {
           if (txttuoi.value = "0")
               txttuoi.value = d.getMonth() - parseInt(dtns.value.substr(3, 2)) + 1;

           if (txttuoi.value < "0")
               txttuoi.value = d.getMonth() - parseInt(dtns.value.substr(3, 2)) + 13;
       }
   }
   function subenableNgayThe(sender, eventArgs) {
       var txtsothe = document.getElementById("<%= txtSoThe.ClientID %>");

                if (txtsothe.value != "") {

                    var dttn = document.getElementById("<%= dtBHYTTN.ClientID %>");
                    if (dttn.disabled = true) {
                        var dtdn = document.getElementById("<%= dtBHYTDN.ClientID %>");

                        dttn.disabled = false;
                        dtdn.disabled = false;
                    }

                }
                else {
                    var dttn = document.getElementById("<%= dtBHYTTN.ClientID %>");
                    var dtdn = document.getElementById("<%= dtBHYTDN.ClientID %>");

                    dttn.disabled = false;
                    dtdn.disabled = false;
                }

            }
            function comboSelectedIndexChangedKBT(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");
                var obbenh = document.getElementById("<%= txtBenhKCC.ClientID %>"); //item.set_text(item.get_text().substr(0, 7)); 
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }
            function comboSelectedIndexChangedYHCT(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");
                var obbenh = document.getElementById("<%= txtChanDoanTheoYHCT.ClientID %>"); //item.set_text(item.get_text().substr(0, 7)); 
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }

            function comboSelectedIndexChangedNBT(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh
                var tenbenh = item.get_attributes().getAttribute("TenBenh");

                var obbenh = document.getElementById("<%= txtBenhNGT.ClientID %>"); //item.set_text(item.get_text().substr(0, 7)); 
                obbenh.value = tenbenh; var input = combo.get_inputDomElement();
            }
            function comboSelectedIndexChangedKBD(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh vien
                var tenbv = item.get_attributes().getAttribute("TenBV");
                var obbenhvien = document.getElementById("<%= txtTenBVBD.ClientID %>"); //item.set_text(item.get_text().substr(0, 7)); //item.set_text(item.get_text().substr(0, 7));

                obbenhvien.value = tenbv;
            }
            function comboSelectedIndexChangedNGT(sender, eventArgs) {
                var item = eventArgs.get_item();

                // get the text and value elements
                var val = item.get_value();
                // benh vien
                var tenbv = item.get_attributes().getAttribute("TenBV");
                var obbenhvien = document.getElementById("<%= txtTenBVGT.ClientID %>");

                obbenhvien.value = tenbv; var input = combo.get_inputDomElement();
            }
            function MsgBox(msg) {
                if (confirm(msg)) {
                    var txthide = $find("<%= txtkieu.ClientID %>");
                    txthide.value = "1";
                }
                else
                    txthide.value = "0";
                var txtmaql = $find("<%= txtmaql.ClientID %>");
                txtmaql.TextChanged();
            }
            function processClick(sender, args) {
                var commandName = args.get_item().get_commandName();

                if (commandName == 'cmdExit') {

                    window.opener = null;
                    window.close();

                }
            }
        </script>

    </telerik:RadCodeBlock>

    <telerik:RadToolBar ID="baraction" runat="server" OnClientButtonClicked="processClick"
        EnableRoundedCorners="true"
        EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%">
        <Items>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="F2 - Ghi" CheckOnClick="false" Value="cmdSave" CommandName="cmdSave">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                Text="F9-In" CheckOnClick="false" Value="cmdPrint" CommandName="cmdPrint">
            </telerik:RadToolBarButton>

            <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg" CheckOnClick="false"
                Text="F10 - Thoát" CssClass="ButtonCSS" Value="cmdExit" CommandName="cmdExit">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                Text="Up load" CheckOnClick="false" Value="cmdUpLoad" CommandName="cmdUpLoad">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="Xem file" CheckOnClick="false" Value="cmdXemFile" CommandName="cmdXemFile">
            </telerik:RadToolBarButton>

            <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif" Visible="false"
                Text="Nhập và chuyển đối tượng" CheckOnClick="false" Value="cmdChuyenDT" CommandName="cmdChuyenDT">
            </telerik:RadToolBarButton>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg" CheckOnClick="false"
                Text="Hủy BA" Value="cmdHuyBA" CommandName="cmdHuyBA">
            </telerik:RadToolBarButton>
        </Items>
    </telerik:RadToolBar>
    <div>
        <asp:FileUpload ID="fuFileUploader" runat="server" text="Upfile" Visible="false" />
        <asp:HiddenField ID="txtview" Value="" runat="server" />
    </div>


    <%--<uc1:HTCReportViewer ID="HTCReportViewer1" runat="server"/>--%>
    <%--<uc1:HTCReportViewer ID="HTCReportViewer2" runat="server" />--%>
    <div class="form-container">
        <div class="form-container" id="ttqrcode" runat="server">
            <fieldset id="Fieldset1" align="center" style="width: 98%" runat="server">
                <legend>
                    <label>
                        Thông tin QR Code
                    </label>
                </legend>
                <div align="center" class="form-container">
                    <table width="100%">
                        <tr>
                            <td>
                                <asp:Label ID="Label32" runat="server" Text="QR code"></asp:Label>
                            </td>
                            <td width="90%">
                                <asp:TextBox runat="server" TabIndex="1" ID="txtQRCode" AutoPostBack="true" OnTextChanged="txtQRCode_TextChanged"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
            </fieldset>
        </div>
        <fieldset align="center">
            <legend>
                <label>
                    Thông tin bệnh nhân 
                </label>
            </legend>

            <div align="center" class="form-container">

                <table cellpadding="0" cellspacing="0" width="98%">

                    <tr>
                        <td width="50px">
                            <asp:Label ID="Label1" runat="server" Text="Họ Tên(*)"></asp:Label>
                        </td>
                        <td width="200px" colspan="2">
                            <asp:TextBox runat="server" ID="txthoten" Enabled="true"></asp:TextBox>
                        </td>
                        <td width="70px">
                            <asp:Label ID="lblGioiTinh" runat="server" Text="Giới tính(*)"></asp:Label>
                        </td>
                        <td width="150px" colspan="2" align="left">
                            <asp:RadioButtonList ID="optGT" runat="server" Visible="false" RepeatDirection="Horizontal" Width="150px" RepeatLayout="Flow">
                                <asp:ListItem Value="1">Nam</asp:ListItem>
                                <asp:ListItem Value="0" Selected="True">Nữ</asp:ListItem>
                            </asp:RadioButtonList>
                            <telerik:RadComboBox ID="cboGioiTinh" runat="server" AppendDataBoundItems="True"
                                Text='<%# Bind("TheTich") %>'
                                Width="100%">
                                <Items>
                                    <telerik:RadComboBoxItem Text="Nam" Value="1" />
                                    <telerik:RadComboBoxItem Text="Nữ" Value="0" />

                                </Items>
                            </telerik:RadComboBox>
                        </td>                       


                        <td width="70px">
                            <asp:Label ID="Label3" runat="server" Text="Ngày sinh(*)"></asp:Label>
                        </td>
                        <td width="120px">

                            <asp:TextBox runat="server" ID="dtNgaySinh" Enabled="true" Style="width: 100% !important;" onchange="subtinhtuoi2(this)"></asp:TextBox>

                        </td>
                        <td width="70px">
                            <asp:Label ID="Label4" Width="60px" runat="server" Text="Tuổi(*)"></asp:Label>
                        </td>
                        <td colspan="1">
                            <asp:TextBox runat="server" ID="txttuoi" Enabled="true" onkeypress=" return onlyNumbers(event)"
                                onchange="subtinhtuoi1(this)" Style="width: 100% !important;"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                    <td >
						<asp:Label  ID="Label40" runat="server" Text="Lý do vào viện "></asp:Label></td>
						  <td colspan = "5">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cbolydovaovien" DataTextField="LydoVV" 
							DataValueField="MaVV" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>
                    <td >
						<asp:Label  ID="Label44" runat="server" Text="Đối tượng khám bệnh "></asp:Label></td>
						  <td colspan = "5">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cbodoituongkhambenh" DataTextField="TenBN" 
							DataValueField="MaKB" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>
                </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Dân tộc"></asp:Label>
                        </td>
                        <td colspan="2" style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" ID="cbodantoc"
                                AppendDataBoundItems="true"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Width="100%"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                DataSourceID="odsdantoc" AutoPostBack="false"
                                DataTextField="Value" DataValueField="Key">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Quốc tịch"></asp:Label>
                        </td>
                        <td colspan="2" style="padding-top: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cboquocgia"
                                EnableVirtualScrolling="true" AppendDataBoundItems="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                Width="100%"
                                DataSourceID="odsquocgia" AutoPostBack="false" DataTextField="Value" DataValueField="Key">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="MãQL"></asp:Label>
                        </td>
                        <td width="60px">
                            <asp:TextBox runat="server" Width="60px" ID="txtmaql" AutoPostBack="true" OnTextChanged="txtmaql_TextChanged" TabIndex="200"></asp:TextBox>

                        </td>

                        <td>
                            <asp:Label ID="Label25" runat="server" Text="Số VV trước "></asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox runat="server" ID="txtSoVVcu" Enabled="False" Style="width: 100% !important;"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Tỉnh(*)"></asp:Label>
                        </td>

                        <td colspan="2" style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cbotinh" DataSourceID="odstinh"
                                AppendDataBoundItems="true"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20" Width="100%"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                AutoPostBack="true" OnSelectedIndexChanged="cbotinh_SelectedIndexChanged"
                                DataTextField="Value" DataValueField="Key">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Huyện(*)"></asp:Label>
                        </td>

                        <td colspan="2" style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cbohuyen" DataSourceID="odshuyen"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                AppendDataBoundItems="true"
                                Width="100%"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                AutoPostBack="false"
                                OnSelectedIndexChanged="cbohuyen_SelectedIndexChanged"
                                DataTextField="Value" DataValueField="Key">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="Phường Xã(*)"></asp:Label>
                        </td>

                        <td runat="server" id="xa">
                            <telerik:RadComboBox IsCaseSensitive="false" CaseSensitive="false" TabIndex="1"
                                runat="server" ID="cboPXa" DataSourceID="odspxa"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                DropDownAutoWidth="Enabled"
                                Width="100%"
                                EnableAutomaticLoadOnDemand="true"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                AutoPostBack="false"
                                DataTextField="Value" DataValueField="Key">
                            </telerik:RadComboBox>
                        </td>
                        <td runat="server" id="lblxa">
                            <asp:Label ID="Label27" runat="server" Text="Địa chỉ"></asp:Label>
                        </td>
                        <td colspan="5" runat="server" id="diachi">
                            <asp:TextBox runat="server" ID="txtDiaChi" Enabled="true" CssClass="span-all" Style="width: 100% !important;"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text="Liên hệ(*)"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox runat="server" ID="txtBaoTin" Enabled="true" CssClass="span-all" Style="width: 100% !important;"></asp:TextBox>
                        </td>
                        <td width="100px">
                            <asp:Label ID="Label12" runat="server" Text="Đ.thoại"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox runat="server" ID="txtdienthoai" Enabled="true" onkeypress=" return onlyFaxs(event)"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="Label13" runat="server" Text="N.nghiệp"></asp:Label>
                        </td>

                        <td colspan="5" style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cboNgheNghiep" DataSourceID="odsNgheNghiep"
                                AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                                AppendDataBoundItems="True" CssClass="span-all"
                                Style="width: 100% !important;"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Filter="StartsWith"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false" Width="100%">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text="Số CMT"></asp:Label></td>
                        <td colspan="2">
                            <asp:TextBox runat="server" ID="txtSoCMT" Enabled="true"></asp:TextBox></td>

                        <td>N.làm việc</td>
                        <td colspan="3">
                            <asp:TextBox ID="txtNoiLamViec" Style="width: 99.4%!important" runat="server"></asp:TextBox></td>
                        
                        <td colspan="1">
                                <asp:Label ID="Label39" runat="server" Text="Mã số thuế" Visible="false"></asp:Label>
                                <telerik:RadComboBox ID="cboLoaiGiay" runat="server"
                                    AppendDataBoundItems="True"
                                    Text='<%# Bind("MaDonVi") %>' Width="100%">
                                    <Items>
                                        <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                        <telerik:RadComboBoxItem Text="Giấy chứng sinh" Value="GCS" />
                                        <telerik:RadComboBoxItem Text="Giấy khai sinh" Value="GKS" />

                                    </Items>
                                </telerik:RadComboBox>
                            </td>
                            <td>
                                <asp:TextBox runat="server" TabIndex="1" ID="txtMaSoThue" Enabled="true" Visible="false"
                                    CssClass="span-all"></asp:TextBox>
                                <asp:TextBox runat="server" TabIndex="1" ID="txtLoaiGiay" Enabled="true"
                                    CssClass="span-all"></asp:TextBox>
                            </td>
                        <td style="text-align: right">
                            <asp:Label ID="Label38" runat="server" Text="Khu vực"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboKhuVuc" runat="server"
                                AppendDataBoundItems="True"
                                Text='<%# Bind("MaDonVi") %>' Width="100%">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                    <telerik:RadComboBoxItem Text="K1" Value="K1" />
                                    <telerik:RadComboBoxItem Text="K2" Value="K2" />
                                    <telerik:RadComboBoxItem Text="K3" Value="K3" />
                                </Items>
                            </telerik:RadComboBox>
                         </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label15" runat="server" Text="Số thẻ "></asp:Label>
                        </td>
                        <td colspan="2">
                            <telerik:RadMaskedTextBox runat="server" ID="txtSoThe" MaxLength="16"
                                Enabled="true" AutoPostBack="true" onkeypress="subenableNgayThe(this)"
                                OnTextChanged="txtSoThe_TextChanged"
                                Mask="ll.#.##.aa.###.#####"
                                Style="width: 100% !important;">
                            </telerik:RadMaskedTextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label16" runat="server" Text="BHYT TN"></asp:Label>
                        </td>
                        <td width="100px">
                            <asp:TextBox runat="server" ID="dtBHYTTN" Enabled="true"></asp:TextBox>

                        </td>
                        <td></td>
                        <td style="position: relative; left: 55px;">
                            <asp:Label ID="Label34" runat="server" Text="ĐN"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox runat="server" ID="dtBHYTDN" Enabled="true"></asp:TextBox>
                        </td>
                        <td style="position: relative; left: 20px;">
                            <asp:Label ID="Label35" runat="server" Text="Đối tượng"></asp:Label>
                        </td>

                        <td colspan="3" style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cboDoiTuong" DataSourceID="odsDoiTuong"
                                AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                                HighlightTemplatedItems="true"
                                CssClass="span-all" Style="width: 142px !important">
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label36" runat="server" Text="Nơi ĐKBD"></asp:Label>
                        </td> 
                        <td width="80px">
                            <telerik:RadComboBox ID="cboDKBD" runat="server"
                                AppendDataBoundItems="True" CssClass="span-all"
                                DataSourceID="odsNoiDK"
                                AutoPostBack="false"
                                DataTextField="MaBHXH" DataValueField="MaBV"
                                DropDownWidth="470px"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                OnItemDataBound="cboBenhVien_ItemDataBound"
                                OnClientSelectedIndexChanged="comboSelectedIndexChangedKBD">
                                <HeaderTemplate>
                                    <table class="NHTC_table_layout">
                                        <tr>

                                            <td>Mã BHXH</td>
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

                                            <td width="70px">
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

                            <asp:TextBox runat="server" ID="txtTenBVBD" Enabled="true"
                                CssClass="span-all"></asp:TextBox>

                        </td>
                        <td style="position: relative; left: 25px;">
                            <asp:Label ID="Label37" runat="server" Text="Nơi ĐKGT"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboDKGT" runat="server"
                                AppendDataBoundItems="True" CssClass="span-all"
                                DataSourceID="odsNoiDK" CaseSensitive="false"
                                AutoPostBack="false"
                                DataTextField="MaBHXHTenBV" Filter="Contains" DataValueField="MaBV"
                                DropDownWidth="470px"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                OnItemDataBound="cboBenhVien_ItemDataBound"
                                OnClientSelectedIndexChanged="comboSelectedIndexChangedNGT"
                                Width="100%">
                                <HeaderTemplate>
                                    <table class="NHTC_table_layout">
                                        <tr>
                                            <tr>

                                                <td>Mã BHXH</td>
                                                <td>Tên BV</td>
                                            </tr>
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

                            <asp:TextBox runat="server" ID="txtTenBVGT" Enabled="false" Style="width: 100% !important;"
                                CssClass="span-all"></asp:TextBox>

                        </td>
                    </tr>

                </table>
            </div>
        </fieldset>
    </div>
    <div class="form-container">
        <fieldset align="center">
            <legend>
                <label>
                    Thông tin bệnh án
                </label>
            </legend>
            <div align="center" class="contentWrapper">

                <table id="Table1" cellpadding="0" cellspacing="0" class="data-form-in-grid" width="100%" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Ngày VV(*)"></asp:Label>
                        </td>

                        <td width="140px">
                            <asp:TextBox runat="server" ID="dtNgayVV" Enabled="true"></asp:TextBox>
                        </td>


                        <td width="90px">
                            <asp:Label ID="Label17" runat="server" Text="Số VV"></asp:Label>
                        </td>

                        <td width="170px">
                            <asp:TextBox runat="server" ID="txtSoVVmoi" Enabled="true"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label Width="80px" ID="Label18" runat="server" Text="Loại BA(*)"></asp:Label>
                        </td>

                        <td>
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false"
                                ID="cboLoaiBA" DataSourceID="odsLoaiBA" DropDownWidth="250px"
                                AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                                CssClass="span-all" Width="100%">
                            </telerik:RadComboBox>
                        </td>

                        <td>
                            <asp:Label ID="Label19" runat="server" Text="Lần VV"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox runat="server" ID="txtLanVV" Enabled="true" Style="width: 102px !important;"></asp:TextBox>
                        </td>


                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label20" runat="server" Text="Mã BA LQ"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox runat="server" ID="txtMaBAGD" Enabled="true"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="Label21" runat="server" Text="Khoa nhập viện(*)"></asp:Label>
                        </td>

                        <td style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cboKhoaNV"
                                CssClass="span-all" DataSourceID="odskhoaNV" AutoPostBack="false"
                                AppendDataBoundItems="True"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                ItemsPerRequest="20"
                                Width="100%"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                DataTextField="Value" DataValueField="Key"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false">
                            </telerik:RadComboBox>
                        </td>

                        <td>
                            <asp:Label ID="Label24" runat="server" Text="Nơi giới thiệu"></asp:Label>
                        </td>

                        <td style="padding-right: 0px">
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false"
                                ID="cboNoiGT" DataSourceID="odsNoiGT" CssClass="span-all" DropDownWidth="250px"
                                AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                                Style="width: 100% !important;">
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:Label ID="Label22" runat="server" Text="Trực tiếp vào"></asp:Label>
                        </td>

                        <td>
                            <telerik:RadComboBox runat="server" IsCaseSensitive="false" ID="cboTrucTiepVao" CssClass="span-all" Style="width: 107px !important"
                                DataSourceID="odsTrucTiepVao" AutoPostBack="false" DataTextField="Value" DataValueField="Key">
                            </telerik:RadComboBox>
                        </td>
                    </tr>

                    <tr>
                        <td style="padding-left: 0px;">Bác sỹ CĐ</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtbschuyen" Enabled="true" CssClass="span-all" Width="100%"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="Label26" runat="server" Text="Ngày chuyển"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox runat="server" ID="dtNgayChuyen" Enabled="true"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="Label23" runat="server" Text="BS vào viện"></asp:Label>
                        </td>


                        <td style="padding-right: 0px">
                            <telerik:RadComboBox ID="cboBacSi" runat="server" AppendDataBoundItems="True"
                                AutoPostBack="false" DataSourceID="ObjectDanhMucNV"
                                DataTextField="HoTen" DataValueField="MaNV" DropDownWidth="470px" CssClass="span-all"
                                EnableVirtualScrolling="true" Width="100%"
                                EnableLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                EnableAutomaticLoadOnDemand="true"
                                MarkFirstMatch="true"
                                ExpandDirection="Down" Filter="Contains"
                                HighlightTemplatedItems="true">
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
                        <td width="35px">
                            <asp:Label ID="Label31" Width="50px" runat="server" Text="PLBN" Visible="true"></asp:Label>
                        </td>
                        <td width="105px">
                            <asp:DropDownList IsCaseSensitive="false"
                                TabIndex="1" runat="server" ID="cboLoaiBN" CssClass="DropDownListCss"
                                Style="width: 100% !important" DropDownWidth="200px"
                                DataSourceID="odsLoaiBN" Visible="true"
                                AutoPostBack="true" DataTextField="Value" DataValueField="Key"
                                HighlightTemplatedItems="true">
                            </asp:DropDownList>
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label30" runat="server" Text="Ghi chú"></asp:Label>
                        </td>

                        <td colspan="7">
                            <asp:TextBox runat="server" ID="txtGhiChu" Enabled="true" Style="width: 842px !important;"></asp:TextBox>
                        </td>

                    </tr>

                </table>
            </div>
        </fieldset>

    </div>
    <div class="form-container">
        <fieldset align="center">
            <legend>
                <label>
                    Chẩn đoán
                </label>
            </legend>
            <div align="center" class="contentWrapper">

                <table id="Table2" cellpadding="2" cellspacing="1" class="data-form-in-grid" width="98%" runat="server" style="padding-right: 3px">
                    <tr>
                        <td>
                            <asp:Label ID="Label28" runat="server" Text="Nơi giới thiệu"></asp:Label>
                        </td>
                        <td width="80px">

                            <telerik:RadComboBox ID="cboCDnoiGT" runat="server"
                                AppendDataBoundItems="True" Width="100%"
                                DataSourceID="odsDMBenhTat"
                                AutoPostBack="false"
                                DataTextField="MaICDTen" Filter="Contains" DataValueField="MaBenhID"
                                DropDownWidth="470px"
                                CaseSensitive="false"
                                HighlightTemplatedItems="true"
                                OnItemDataBound="cboBenh_ItemDataBound"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                EnableAutomaticLoadOnDemand="true"
                                MarkFirstMatch="true"
                                OnClientSelectedIndexChanged="comboSelectedIndexChangedNBT">
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
                        <td style="text-align: right">
                            <asp:TextBox runat="server" ID="txtBenhNGT" Style="width: 100% !important;"></asp:TextBox>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label29" runat="server" Text="KKB, Cấp cứu(*)"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboCDKKBCC" runat="server"
                                AppendDataBoundItems="True" CssClass="span-all"
                                DataSourceID="odsDMBenhTat"
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
                                CaseSensitive="false"
                                HighlightTemplatedItems="true"
                                OnItemDataBound="cboBenh_ItemDataBound"
                                OnClientSelectedIndexChanged="comboSelectedIndexChangedKBT"
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
                        <td style="text-align: right">
                            <asp:TextBox runat="server" ID="txtBenhKCC" Style="width: 100% !important;"></asp:TextBox>
                            <asp:HiddenField runat="server" ID="txtkieu" Value="2" />
                        </td>
                    </tr>
                    <tr id="chanDoanYHCT" runat="server">
                        <td>
                            <asp:Label ID="Label33" runat="server" Text="Chẩn đoán YHCT"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboChanDoanTheoYHCT" runat="server"
                                AppendDataBoundItems="True" CssClass="span-all"
                                DataSourceID="ObjectDanhMucBenh"
                                AutoPostBack="false"
                                DataTextField="MaICDTen" Filter="Contains" DataValueField="MaICD"
                                DropDownWidth="470px"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                EnableAutomaticLoadOnDemand="true"
                                MarkFirstMatch="true"
                                CaseSensitive="false"
                                HighlightTemplatedItems="true"
                                OnItemDataBound="cboBenhDanh_ItemDataBound"
                                OnClientSelectedIndexChanged="comboSelectedIndexChangedYHCT"
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
                        <td style="text-align: right">
                            <asp:TextBox runat="server" ID="txtChanDoanTheoYHCT" Style="width: 100% !important;"></asp:TextBox>
                            <asp:HiddenField runat="server" ID="HiddenField1" Value="2" />
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>

    </div>



    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="odsDMBenhTat"
        runat="server"
        SelectMethod="FindDMBenhTatByMa" TypeName="HTC.Business.CategoryList.DMBenhTatList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>


    <asp:ObjectDataSource ID="odsdantoc" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMDantocListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odsquocgia" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMQuocGiaListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odstinh" runat="server" SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMTinhListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odshuyen" runat="server" SelectMethod="GetListbyTinh" OnSelecting="odshuyen_Selecting"
        TypeName="HTC.Business.CategoryList.DMQuanHuyenListcb" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="matinh" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odspxa" runat="server" SelectMethod="GetListbyQH" OnSelecting="odspxa_Selecting"
        TypeName="HTC.Business.CategoryList.DMPhuongXaListcb" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="maQH" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsNgheNghiep" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMNgheNghiepListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsLoaiBA" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLoaiBAListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsDoiTuong" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMDoituongListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odskhoaNV" runat="server" SelectMethod="GetListNoiTru"
        OnSelecting="odsKhoa_Selecting" TypeName="HTC.Business.CategoryList.DMKhoaListcb"
        EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="account" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsNoiGT" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMNoiGTListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsTrucTiepVao" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMNoiKhamListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="ObjectDanhMucBenh" runat="server" SelectMethod="FindDMBenhDanhByMa"
        TypeName="HTC.Business.CategoryList.DMBenhDanhList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDanhMucNV" runat="server" SelectMethod="FindDMNhanVienByMa"
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="ma" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="odsNoiDK" runat="server" SelectMethod="FindDMBenhVienByMa" TypeName="HTC.Business.CategoryList.DMBenhVienList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaBV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsLoaiBN" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLoaiBNListcb" EnableViewState="true"></asp:ObjectDataSource>


</asp:Content>
