<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMTuongTac.aspx.cs" Inherits="UI_Category_DMTBYT_frmDMTuongTac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadCodeBlock runat="server" ID="RadCodeBlock1">
                        <script type="text/javascript">
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
                        else if (pressedKey == 27) //Check for the Esc key being press
                        {
                            //                  ret_bHandlePress = false;
                            var gridCT = $find("<%= grdChiTiet.ClientID %>");

                                gridCT.get_masterTableView().fireCommand("CancelAll", ""); //Cancel any editing activities in the grid
                                gridCT.get_masterTableView().clearSelectedItems(); //De-select any rows
                            }
}

function funUpload() {
    var toolbar1 = $find("<%= baraction.ClientID %>");
                        var templateButton = toolbar1.findItemByValue("cmdUploadData");
                        templateButton.click();
                    }


        </script>

    </telerik:RadCodeBlock>

    <telerik:RadToolBar ID="baraction" runat="server"
            EnableRoundedCorners="true"
            EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%">
            <Items>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                    Text="F12-Thêm" Group="Align" CheckOnClick="false" Value="cmdAdd">
                </telerik:RadToolBarButton>

               <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                    Text="F7-Tìm kiếm" CheckOnClick="false" Value="cmdFilter">
                </telerik:RadToolBarButton>

                <telerik:RadToolBarButton Text="Export" ImageUrl="~/img/icon/download_button.png" Visible="false"
                    Value="cmdExportData"
                    ></telerik:RadToolBarButton>

                <telerik:RadToolBarButton Value="cmdUploadData"  Visible="false">
                    <ItemTemplate>
                        <asp:FileUpload runat="server" ID="FileUpload1" Width="80px" onchange="funUpload()"/>
                    </ItemTemplate>
                </telerik:RadToolBarButton>

                <telerik:RadToolBarButton ImageUrl="~/img/icon/exit.gif"
                    Text="F10-Thoát" CheckOnClick="false" Value="cmdExit">
                </telerik:RadToolBarButton>
            </Items>
        </telerik:RadToolBar>
    <div>
        <telerik:RadGrid AllowFilteringByColumn="false" Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true"  ID="grdChiTiet" runat="server"
            AutoGenerateColumns="false"
            GridLines="None"
            OnNeedDataSource="grdChiTiet_NeedDataSource"
            OnItemCommand="grdChiTiet_ItemCommand"
            OnItemCreated="grdChiTiet_ItemCreated"
            OnItemDataBound="grdChiTiet_ItemDataBound"
            OnPageIndexChanged="grdChiTiet_PageIndexChanged"
            OnPageSizeChanged="grdChiTiet_PageSizeChanged"
            Skin="Default" 
            ClientSettings-Scrolling-AllowScroll="true"
            ShowFooter="false" AllowSorting="true" AllowPaging="true" PageSize="50" PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100"  PagerStyle-AlwaysVisible="true">
            <GroupingSettings CaseSensitive="false" ShowUnGroupButton="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <ClientEvents OnRowClick="RowClickForDMForms" OnRowDblClick="RowDblClickForDMForms" OnCommand="GridCommandForDMForms" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>

            <MasterTableView EditMode="InPlace" DataKeyNames="STT">
                <Columns>
                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                              ConfirmDialogType="RadWindow" ConfirmText="Bạn có đồng ý xoá không?" ConfirmTitle="Delete" 
                              HeaderStyle-Width="20px" HeaderText="Delete" Text="Delete" 
                              UniqueName="Delete"  >
                              <HeaderStyle Width="50px" Height="30px" />
                    </telerik:GridButtonColumn>

                    <telerik:GridEditCommandColumn ButtonType="ImageButton" HeaderText="Edit" UniqueName="Edit" CancelText="Thoát" UpdateText="Lưu" InsertText="Thêm mới"
                        >
                        <HeaderStyle Width="80px" Height="30px" />
                    </telerik:GridEditCommandColumn>

                    <telerik:GridBoundColumn DataField="OrderNumber" UniqueName="OrderNumber" HeaderText="STT"  ReadOnly="true" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="50px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridTemplateColumn DataField="TenGoc1" UniqueName="TenGoc1" HeaderText="Tên Gốc 1" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <ItemTemplate><%# Eval("TenGoc1") %></ItemTemplate>
                        <EditItemTemplate><telerik:RadComboBox  ID="cboDMThuoc1" runat="server" AppendDataBoundItems="true"
                                AutoPostBack="false" DataSourceID="odsDMThuoc"
                                DataTextField="TenGoc" DataValueField="TenGoc" DropDownWidth="170px" CssClass="span-all"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                MarkFirstMatch="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                EnableVirtualScrolling ="false" 
                                ExpandDirection="Up" Filter="StartsWith"
                                HighlightTemplatedItems="true"
                               Width ="100%"></telerik:RadComboBox></EditItemTemplate>
                        <HeaderStyle Width="170px" Height="30px" />
                    </telerik:GridTemplateColumn>

                    <telerik:GridTemplateColumn DataField="TenGoc2" UniqueName="TenGoc2" HeaderText="Tên Gốc 2" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <ItemTemplate><%# Eval("TenGoc2") %></ItemTemplate>
                        <EditItemTemplate><telerik:RadComboBox  ID="cboDMThuoc2" runat="server" AppendDataBoundItems="true"
                                AutoPostBack="false" DataSourceID="odsDMThuoc"
                                DataTextField="TenGoc" DataValueField="TenGoc" DropDownWidth="170px" CssClass="span-all"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                MarkFirstMatch="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                EnableVirtualScrolling ="false" 
                                ExpandDirection="Up" Filter="StartsWith"
                                HighlightTemplatedItems="true"
                               Width ="100%"></telerik:RadComboBox></EditItemTemplate>
                        <HeaderStyle Width="170px" Height="30px" />
                    </telerik:GridTemplateColumn>

                    <telerik:GridTemplateColumn DataField="TenGoc3" UniqueName="TenGoc3" HeaderText="Tên Gốc 3" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <ItemTemplate><%# Eval("TenGoc3") %></ItemTemplate>
                        <EditItemTemplate><telerik:RadComboBox  ID="cboDMThuoc3" runat="server" AppendDataBoundItems="true"
                                AutoPostBack="false" DataSourceID="odsDMThuoc"
                                DataTextField="TenGoc" DataValueField="TenGoc" DropDownWidth="170px" CssClass="span-all"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                MarkFirstMatch="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                EnableVirtualScrolling ="false" 
                                ExpandDirection="Up" Filter="StartsWith"
                                HighlightTemplatedItems="true"
                               Width ="100%"></telerik:RadComboBox></EditItemTemplate>
                        <HeaderStyle Width="170px" Height="30px" />
                    </telerik:GridTemplateColumn>


                                        <telerik:GridBoundColumn DataField="TuongTacThuoc" UniqueName="TuongTacThuoc" HeaderText="Tương tác thuốc" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="200px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridNumericColumn DataField="MucDo" UniqueName="MucDo" HeaderText="Mức độ" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="70px" Height="30px"/>
                    </telerik:GridNumericColumn>

                    <telerik:GridBoundColumn DataField="MoTa" UniqueName="MoTa" HeaderText="Mô tả" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="250px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridCheckBoxColumn DataField="Huy" UniqueName="Huy" HeaderText="Hủy" AllowFiltering="false">
                        <HeaderStyle Width="70px" Height="30px" />
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridBoundColumn DataField="NgayLap" UniqueName="NgayLap" HeaderText="Ngày lập" ReadOnly="true" AllowFiltering="false">
                        <HeaderStyle Width="150px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="TenNguoiLap" UniqueName="TenNguoiLap" HeaderText="Người lập" ReadOnly="true" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="200px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="NgaySD" UniqueName="NgaySD" HeaderText="Ngày Sửa" ReadOnly="true" AllowFiltering="false">
                        <HeaderStyle Width="150px" Height="30px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="TenNguoiSD" UniqueName="TenNguoiSD" HeaderText="Người Sửa" ReadOnly="true" AllowFiltering="true" AutoPostBackOnFilter="true">
                        <HeaderStyle Width="200px" Height="30px" />
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </div>

    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="odsDMThuoc" runat="server"
        SelectMethod="DMThuocGetAll"
        TypeName="HTC.Business.CategoryList.DMTuongTacs" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="TenGoc" Type="String" DefaultValue="" />

        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

