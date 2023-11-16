<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMDichVu.aspx.cs" Inherits="UI_Category_DMDichVu_frmDMDichVu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">
            function KeyPress(sender, eventArgs) {
                if (eventArgs.get_keyCode() == 127)
                    eventArgs.get_keyCode() =0;
               
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
               
                else if (pressedKey == 113) { //f2-
                    var toolbar1 = $find("<%= baraction.ClientID %>");
                    var templateButton = toolbar1.findItemByValue("cmdSave");
                    templateButton.click();

                }
                else if (pressedKey == 118) { //f7-Filter
                    var toolbar1 = $find("<%= baraction.ClientID %>");
            var templateButton = toolbar1.findItemByValue("cmdFilter");
            templateButton.click();
        }

        else if (pressedKey == 121) { //f10-thoat
            var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdExit");
               templateButton.click();

           }
           else if (pressedKey == 120) { //f9-NhapKQ
               var toolbar1 = $find("<%= baraction.ClientID %>");
                   var templateButton = toolbar1.findItemByValue("cmdNhapKQ");
                   templateButton.click();

               }

}
var hasChanges, inputs, dropdowns, editedRow;

function ComBoKeyress(sender, eventArgs) {
    var key = eventArgs.get_domEvent().keyCode;

    if (key == 27) //Check for the Esc key being press
    {
        //                  ret_bHandlePress = false;
        var grid = $find("<%= grdChiTiet.ClientID %>");

        grid.get_masterTableView().fireCommand("CancelAll", ""); //Cancel any editing activities in the grid
        grid.get_masterTableView().clearSelectedItems(); //De-select any rows
    }

}
function GridCommand(sender, args) {
    if (args.get_commandName() != "Edit") {
        editedRow = null;
    }

}
function RowClick(sender, eventArgs) {

    if (editedRow && hasChanges) {
        hasChanges = false;
        if (confirm("Có lưu dữ liệu?")) {
            $find("<%= grdChiTiet.ClientID %>").get_masterTableView().updateItem(editedRow);
            grid.get_masterTableView().fireCommand("ViewDetail", editedRow); //add master editing activities in the grid}

        }
    }
}

function RowDblClick(sender, eventArgs) {
    editedRow = eventArgs.get_itemIndexHierarchical();
    var grid = $find("<%= grdChiTiet.ClientID %>");
    grid.get_masterTableView().editItem(editedRow);
    grid.get_masterTableView().get_dataItems()[editedRow].set_selected(true);

}



function GridCreated(sender, eventArgs) {
    var gridElement = sender.get_element();
    var elementsToUse = [];
    inputs = gridElement.getElementsByTagName("input");
    for (var i = 0; i < inputs.length; i++) {
        var lowerType = inputs[i].type.toLowerCase();
        if (lowerType == "hidden" || lowerType == "button") {
            continue;
        }
        if (inputs[i].id.indexOf("PageSizeComboBox") == -1 && inputs[i].type.toLowerCase() != "checkbox") {
            Array.add(elementsToUse, inputs[i]);
        }
        inputs[i].onchange = TrackChanges;
    }

    dropdowns = gridElement.getElementsByTagName("select");
    for (var i = 0; i < dropdowns.length; i++) {
        dropdowns[i].onchange = TrackChanges;
    }

    setTimeout(function () { if (elementsToUse[0]) elementsToUse[0].focus(); }, 100);
}

function TrackChanges(e) {
    hasChanges = true;
}
function processClick(sender, args) {
    var commandName = args.get_item().get_commandName();

    if (commandName == 'cmdExit') {
        window.Location.href = "/Default.aspx";

        return false;
    }
}
        </script>
        <style type="text/css">
            /*  .RadForm.rfdTextbox input.rfdDecorated[type="text"], .RadForm.rfdTextbox input.rfdDecorated[type="password"], .RadForm.rfdTextbox input.rfdDecorated[type="search"], .RadForm.rfdTextbox input.rfdDecorated[type="url"], .RadForm.rfdTextbox input.rfdDecorated[type="tel"], .RadForm.rfdTextbox input.rfdDecorated[type="email"]
            {
                width: 100% !important;
            }*/

            .ButtonCSS {
                margin-left: 10px;
            }

        	/*table td
        	{
				border:1px solid black;
        	}*/
            
        </style>
    </telerik:RadCodeBlock>
    <div>
        <!--  <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="Sửa phiếu" CheckOnClick="false" Value ="cmdEdit">
            </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/Delete.png"
                Text="F8-Xóa phiếu" CheckOnClick="false" Value ="cmdDelete" >
            </telerik:RadToolBarButton> -->
        <telerik:RadToolBar ID="baraction" runat="server"
            EnableRoundedCorners="true"
            EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%" OnClientButtonClicked="processClick">
            <Items>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                    Text="F12-Thêm" Group="Align" CheckOnClick="false" Value="cmdAdd">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="F2-Ghi" Group="Align" CheckOnClick="false" Value="cmdSave">
                </telerik:RadToolBarButton>
                 <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="Export" Group="Align" CheckOnClick="true" Value="cmdExport">
              
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                    Text="F10-Thoát" CheckOnClick="false" Value="cmdExit">
                </telerik:RadToolBarButton>

                 <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif" Text="Phiếu hẹn"
                    CheckOnClick="false" Value="cmdPhieuHen" CssClass="ButtonCSS">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif" Text="Nhập KQ"
                    CheckOnClick="false" Value="cmdNhapKQ" >
                </telerik:RadToolBarButton>

                <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif"
                    Text="Gói DV" Value="cmdGoi">
                </telerik:RadToolBarButton>
                   <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif"
                    Text="ĐMức Thuốc" Value="cmdDMThuoc">
                </telerik:RadToolBarButton>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif"
                    Text="ĐMức VT" Value="cmdDMVT">
                </telerik:RadToolBarButton>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/addCT.gif"
                    Text="ĐMức HC" Value="cmdDMHC">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                    Text="F6-Xem" Value="cmdView">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                    Text="F7-Tìm kiếm" CheckOnClick="false" Value="cmdFilter" CommandName="cmdFilter">
                </telerik:RadToolBarButton>
            </Items>
        </telerik:RadToolBar>


    </div>
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Nhóm Dịch Vụ"></asp:Label></td>
            <td width="850px">
                <asp:DropDownList ID="cboDsnhom" DataTextField="value" AutoPostBack="true"
                    DataValueField="key" runat="server" OnSelectedIndexChanged="cboDsNhom_OnSelectedIndexChanged"
                    Width="100%">
                </asp:DropDownList></td>
        </tr>
    </table>


    <div style="margin-bottom: 5px">

        <telerik:RadGrid Culture="vi-VN" ID="grdChiTiet" runat="server" AllowAutomaticDeletes="True"
            AllowAutomaticInserts="True" AllowAutomaticUpdates="false"
            AutoGenerateColumns="false" GridLines="None"
            OnItemCommand="grdChiTiet_ItemCommand"
            OnNeedDataSource="grdChiTiet_NeedDataSource"
            Skin="Default" Width="100%" Height="220px" OnDeleteCommand="grdChiTiet_DeletedCommand"
            OnInsertCommand="grdChiTiet_InsertCommand"
            OnUpdateCommand="grdChiTiet_UpdateCommand"
              OnPageIndexChanged="grdChiTiet_PageIndexChanged"
                  OnPageSizeChanged="grdChiTiet_PageSizeChanged"
                AllowCustomPaging="True"
               
			GroupingSettings-CaseSensitive="false"
            ClientSettings-Scrolling-AllowScroll="true"
            ShowFooter="false" AllowSorting="true" AllowPaging="true" PageSize="100" PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100" PagerStyle-AlwaysVisible="true"
            MasterTableView-EditFormSettings-EditColumn-AutoPostBackOnFilter="true">
             <GroupingSettings CaseSensitive="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true"    KeyboardNavigationSettings-AllowActiveRowCycle="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <ClientEvents OnRowClick="RowDblClickForDMForms" OnRowDblClick="RowDblClickForDMForms"
                     OnCommand="GridCommandForDMForms"  OnKeyPress="KeyPress"/>

                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>

            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true"    KeyboardNavigationSettings-AllowActiveRowCycle="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y"
                    EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>

            <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="false" DataKeyNames="OrderNumber,MaDV"
                HorizontalAlign="NotSet" CommandItemDisplay="None" EditMode="InPlace" Width="100%">
                <CommandItemTemplate />
                <CommandItemSettings AddNewRecordText="F12-Thêm"
                    ShowAddNewRecordButton="true"
                    ShowRefreshButton="false"
                    ShowCancelChangesButton="false"
                    AddNewRecordImageUrl="~/img/icon/addCT.gif" />
                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                    <telerik:GridSortExpression FieldName="MaDV" />
                    <telerik:GridSortExpression FieldName="TenDV" />
                </SortExpressions>
                <Columns>
                    <%-- bat dau--onclick="btnAdd_Click"--%>
                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete"
                        ConfirmDialogType="RadWindow" ConfirmText="Bạn có muốn xóa dịch vụ này?" ConfirmTitle="Delete"
                        HeaderStyle-Width="20px" HeaderText="Xóa" Text="Delete"
                        UniqueName="Delete">
                        <HeaderStyle Width="50px" />
                    </telerik:GridButtonColumn>
                     <telerik:GridBoundColumn DataField="OrderNumber" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter OrderNumber column" HeaderText="STT" ReadOnly="true"
                        SortExpression="OrderNumber" UniqueName="OrderNumber">
                        <HeaderStyle Width="60px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="MaDV" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter MaDV column" HeaderText="Mã dịch vụ" ReadOnly="true"
                        SortExpression="MaDV" UniqueName="MaDV">
                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="TenDV" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter TenDV column" HeaderText="Tên dịch vụ"
                        SortExpression="TenDV" UniqueName="TenDV">

                        <HeaderStyle Width="200px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="TenTat" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter TenTat column" HeaderText="Tên tắt"
                        SortExpression="TenTat" UniqueName="TenTat">

                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>


                    

                       

                    <telerik:GridBoundColumn DataField="ĐVT" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter DonVi column" HeaderText="Tên ĐVT"
                        SortExpression="DonVi" UniqueName="DonVi">

                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="NhapSL" DataType="System.Boolean" AllowFiltering="false"
                        FilterControlAltText="Filter NhapSL column" HeaderText="Nhập SL" ReadOnly="false"
                        SortExpression="NhapSL" UniqueName="NhapSL">
                        <HeaderStyle Width="60px" />
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridBoundColumn DataField="MaMay" CurrentFilterFunction="Contains" 
                        AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter MaMay column" HeaderText="Mã máy" ReadOnly="true"
                        SortExpression="MaMay" UniqueName="MaMay">
                        <HeaderStyle Width="120px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="Huy" DataType="System.Boolean"
                        FilterControlAltText="Filter Huy column" HeaderText="Hủy" ReadOnly="false" AllowFiltering="false"
                        SortExpression="Huy" UniqueName="Huy">
                        <HeaderStyle Width="50px" />
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridBoundColumn DataField="TenNguoiLap" CurrentFilterFunction="Contains" 
                        AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        AllowFiltering="false"
                        FilterControlAltText="Filter TenNguoiLap column" HeaderText="Người lập"
                        ReadOnly="true" SortExpression="TenNguoiLap" UniqueName="TenNguoiLap">
                        <HeaderStyle Width="100px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="NgayLap" DataFormatString="{0:dd/MM/yyyy}" CurrentFilterFunction="EqualTo"
                        AllowFiltering="false"
                         AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter NgayLap column" HeaderText="Ngày lập"
                        SortExpression="NgayLap" UniqueName="NgayLap">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="TenNguoiSD" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        AllowFiltering="false"
                        FilterControlAltText="Filter TenNguoiSD column" HeaderText="Người SD"
                        ReadOnly="true" SortExpression="TenNguoiSD" UniqueName="TenNguoiSD">
                        <HeaderStyle Width="100px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="NgaySD" DataFormatString="{0:dd/MM/yyyy}" CurrentFilterFunction="EqualTo"
                       
                         AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter NgaySD column" HeaderText="Ngày SD"
                        SortExpression="NgaySD" UniqueName="NgaySD">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="TenNguoiHuy" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        AllowFiltering="false"
                        FilterControlAltText="Filter TenNguoiHuy column" HeaderText="Người hủy"
                        ReadOnly="true" SortExpression="TenNguoiHuy" UniqueName="TenNguoiHuy">
                        <HeaderStyle Width="100px" />
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>

    </div>
    <fieldset align="left">


        <legend>
            <label>
                Thông tin chi tiết
            </label>
        </legend>
        <div align="center" style="border-style: groove; width: 100%">

            <table style="width: 100%; text-align:right" cellspacing="6" >
                <tr>

                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Mã dịch vụ"></asp:Label></td>

                    <td>
                        <asp:TextBox ID="txtMaDV" Text="" runat="server" TabIndex="1"
                            Width="100%"></asp:TextBox></td>
                  
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Tên tắt"></asp:Label></td>

                    <td>
                        <asp:TextBox ID="txtTentat" Text="" runat="server" TabIndex="1"
                            Width="120px"></asp:TextBox></td>

                  
                    


                     <td>
                        <asp:Label ID="Label16" runat="server" Text="Loại hình "></asp:Label></td>
                    <td >

                        <asp:DropDownList ID="cboLoaiTT" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                     <td>
                        <asp:Label ID="Label23" runat="server" Text="Ký tự đầu(*)"></asp:Label></td>

                    <td width ="50px">
                        <asp:TextBox ID="txtKyTu" Text="" runat="server" TabIndex="1"
                            Width="100%"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Bệnh phẩm"></asp:Label></td>
                    <td colspan="2">

                        <asp:DropDownList ID="cboBenhpham" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label30" runat="server" Text="Nhóm DV"></asp:Label></td>
                    <td colspan="3">
                        <asp:DropDownList ID="cboNhomDV" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="ĐVT"></asp:Label></td>
                    <td>

                        <asp:DropDownList ID="cboDonVi" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                    <td>
                        <asp:Label ID="Label22" runat="server" Text="Số tiêu bản"></asp:Label></td>

                    <td >
                        <asp:TextBox ID="txtSotieuban" Text="" runat="server" TabIndex="1"
                            Width="100%"></asp:TextBox></td>
                     <td>
                        <asp:Label ID="Label1" runat="server" Text="Chuyên khoa"></asp:Label></td>
                   
                    <td colspan="2" >

                        <asp:DropDownList ID="cboChuyenkhoa" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Tên DV(*)"></asp:Label></td>

                    <td colspan="5">
                        <asp:TextBox ID="txtTenDV" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    
                     <td>
                        <asp:Label ID="Label4" runat="server" Text="Tên TA"></asp:Label></td>

                    <td colspan="4">
                        <asp:TextBox ID="txtTenTA" Text="" runat="server" TabIndex="1"
                            style = "width:100% !important"></asp:TextBox></td>


                </tr>


                <tr>

                    <td >
						<asp:Label  ID="Label45" runat="server" Text="Nhóm BHXH"></asp:Label></td>
						  <td colspan = "5">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboNhomBHXH" DataTextField="TenDV" 
							DataValueField="MaDV" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>




                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label20" runat="server" Text="Loại Kết quả"></asp:Label></td>
                    <td colspan="5">

                        <asp:DropDownList ID="cboLoaiKQ" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Nơi thực hiện"></asp:Label></td>
                    <td colspan="4">
                        <asp:DropDownList ID="cboNoiTH" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList>
                        </td> 
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Phân loại(*)"></asp:Label></td>
                    <td colspan="2">

                        <asp:DropDownList ID="cboChungLoai" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%" AutoPostBack="true"
                            OnSelectedIndexChanged="cboChungLoai_OnSelectedIndexChanged">
                        </asp:DropDownList></td>

                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Loại hình "></asp:Label></td>
                    <td colspan="2">

                        <asp:DropDownList ID="cboLoaihinh" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>
                    <td>
                        <asp:Label ID="Label17" runat="server" Text="Kiểu dịch vụ"></asp:Label></td>
                    <td colspan="4">

                        <asp:DropDownList ID="cboKieuDV" DataTextField="value" TabIndex="1"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </asp:DropDownList></td>

                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label26" runat="server" Text="Khoa LM"></asp:Label></td>
                    <td colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaLM1" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>


                    <td>
                        <asp:Label ID="Label27" runat="server" Text="Khoa LM NV"></asp:Label></td>
                    <td colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaLM2" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>
                    <td>
                        <asp:Label ID="Label28" runat="server" Text="Khoa LM NG"></asp:Label></td>
                    <td colspan="4" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaLM3" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Khoa TH"></asp:Label></td>
                    <td colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaTH1" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>


                    <td>
                        <asp:Label ID="Label18" runat="server" Text="Khoa TH NV"></asp:Label></td>
                    <td colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaTH2" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>
                    <td>
                        <asp:Label ID="Label19" runat="server" Text="Khoa TH NG"></asp:Label></td>
                    <td colspan="4" style="padding-right:0px">
                        <telerik:RadComboBox                  TabIndex="1" ID="cboKhoaTH3" DataTextField="value"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="Label21" runat="server" Text="Phiếu YC"></asp:Label></td>

                    <td colspan="5">
                        <asp:TextBox ID="txtPhieuYC" Text="" runat="server" TabIndex="1"
                            style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label29" runat="server" Text="Ghi chú"></asp:Label></td>
                     <td colspan="4">
                        <asp:TextBox ID="txtGhiChu" Text="" runat="server" TabIndex="1"
                            style = "width:100% !important"></asp:TextBox></td>
                 
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label12" runat="server" Text="Phiếu YC 2"></asp:Label></td>

                    <td colspan="5">
                        <asp:TextBox ID="txtPhieuYC2" Text="" runat="server" TabIndex="1"
                            style = "width:100% !important"></asp:TextBox></td>
                    <td colspan="2">
                        <asp:CheckBox TabIndex="1" ID="chkNhapSL" runat="server" Text="Nhập số lượng" Width="200px" /></td>
                    <td >
                        <asp:CheckBox TabIndex="1" ID="chkBCThu" runat="server" Text="Báo cáo thu" Width="200px" /></td>
                    <td >
                        <asp:CheckBox TabIndex="1" ID="chkSuagia" runat="server" Text="Sửa giá" Width="200px" /></td>
                     <td >
                        <asp:CheckBox TabIndex="1" ID="chkApdunggoi" runat="server" Text="Áp dụng gói" Width="200px" /></td>
                   
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label24" runat="server" Text="CS thấp nữ"></asp:Label></td>

                    <td colspan="2">
                        <asp:TextBox ID="txtThapNu" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label25" runat="server" Text="CS thấp nam"></asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtThapNam" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td colspan="2">
                        <asp:CheckBox TabIndex="1" ID="chkLaymauTT" runat="server" Text="Lấy máu TT" Width="200px"  /></td>
                     <td >
                        <asp:CheckBox TabIndex="1" ID="chkKythuatcao" runat="server" Text="Kỹ Thuật cao" Width="200px" Checked ="true" /></td>
                         <td >
                        <asp:CheckBox TabIndex="1" ID="chkDichvugui" runat="server" Text="Dịch vụ gửi" Width="200px" Checked ="true" /></td>
                  <td >
                        <asp:CheckBox TabIndex="1" ID="chkApdungNT" runat="server" Text="Áp dụng NT" Width="200px" Checked ="true" /></td>
                   
                      </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text="CS cao nữ"></asp:Label></td>

                    <td colspan="2">
                        <asp:TextBox ID="txtCaoNu" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label14" runat="server" Text="CS cao nam"></asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtCaoNam" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td colspan="2">
                        <asp:CheckBox TabIndex="1" ID="chkInthu" runat="server" Text="In thu" Width="200px" /></td>
                    <td >
                        <asp:CheckBox TabIndex="1" ID="chkHuy" runat="server" Text="Không SD" Width="200px" /></td>
                    <td >
                        <asp:CheckBox TabIndex="1" ID="chkApdungNK" runat="server" Text="Áp dụng NK" Width="200px" /></td>
                     <td >
                        <asp:CheckBox TabIndex="1" ID="chkApdungPK" runat="server" Text="Áp dụng PK" Width="200px" /></td>
             </tr>
                   <tr> 
                       <td>
                        <asp:Label ID="Label33" runat="server" Text="Tên BH"></asp:Label></td>
                   <td colspan="5">
                        <asp:TextBox ID="txtTenBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label31" runat="server" Text="Quyết định"></asp:Label></td>

                    <td colspan="2">
                        <asp:TextBox ID="txtQuyetDinhBH" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label32" runat="server" Text="Mã BH"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                 
             </tr>    
                <tr> 
                       <td>
                        <asp:Label ID="Label34" runat="server" Text="Tên BY tế"></asp:Label></td>
                   <td colspan="5">
                        <asp:TextBox ID="txtTenBYte" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label35" runat="server" Text="Quyết định"></asp:Label></td>

                    <td colspan="2">
                        <asp:TextBox ID="txtQuyetDinh" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label36" runat="server" Text="Mã BY Tế"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaBYTe" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                 
             </tr>  
                <tr>
                    <td>
                        <asp:Label ID="Label42" runat="server" Text="Đơn giá BD"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtDonGiaBD" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                     <td>
                        <asp:Label ID="Label40" runat="server" Text="Mã máy XN "></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaMayXNBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                     <td>
                        <asp:Label ID="Label39" runat="server" Text="Mã CS BH "></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaCSBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                     <td>
                        <asp:Label ID="Label41" runat="server" Text="Tên CS BH "></asp:Label></td>
                    <td colspan ="4" >
                        <asp:TextBox ID="txtTenCSBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                </tr>
                <tr>
                   <td colspan="3"></td>
                     <td>
                        <asp:Label ID="Label38" runat="server" Text="Mã KHTH "></asp:Label></td>
                    <td colspan="3">
                          <telerik:RadComboBox                
                                TabIndex="1" ID="cboMaKHTH" DataTextField="value"  Filter="Contains"
                            DataValueField="key" runat="server"
                            Width="100%">
                        </telerik:RadComboBox></td>
                     <td>    <asp:Label ID="Label43" runat="server" Text="Tỷ lệ BH trả"></asp:Label></td>
                                <td>   <asp:TextBox ID="txtTyLeBH" Text="" runat="server" TabIndex="1" /> </td>
                      <td>
                        <asp:Label ID="Label37" runat="server" Text="Mã T.Đương "></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaTDuong" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                </tr>
            </table>

        </div>
    </fieldset>
</asp:Content>
