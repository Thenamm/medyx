<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMNhanVien.aspx.cs" Inherits="UI_Category_DMHanhChinh_frmDMNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">

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

    </script>
    <style type="text/css">
              
    </style>
    <table width="100%">
        <tr>
            <td width="150px" style="height: 26px" align="right">
                <asp:Label ID="Label14" runat="server" Text="Chọn Khoa, Phòng:">
                </asp:Label>
            </td>
            <td style="height: 26px">
                <asp:DropDownList runat="server" ID="cboDSKhoa"
                    DataTextField="Value" DataValueField="Key" AutoPostBack="true"
                    OnSelectedIndexChanged="cboDSKhoa_SelectedIndexChanged" Width="280px">
                </asp:DropDownList>
            </td>
        </tr>
    </table>


    <div>
        <telerik:RadGrid Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true" runat="server" ID="grdChiTiet" AutoGenerateColumns="false" AllowPaging="true"
            OnItemCommand="grdChiTiet_ItemCommand"
			OnItemDataBound="grdChiTiet_ItemDataBound"
            OnNeedDataSource="grdChiTiet_NeedDataSource"
            OnDeleteCommand="grdChiTiet_DeleteCommand"
            OnInsertCommand="grdChiTiet_InsertCommand"
              OnPageIndexChanged="grdChiTiet_PageIndexChanged"
                  OnPageSizeChanged="grdChiTiet_PageSizeChanged"

            Skin="Default"
            ClientSettings-Scrolling-AllowScroll="true"
            ShowFooter="false" AllowSorting="true" PageSize="50" 
            PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes=" 50, 70, 100"
                AllowCustomPaging="True"
            Width="100%"
            AllowFilteringByColumn="True">
            <GroupingSettings CaseSensitive="false" ShowUnGroupButton="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>
            <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" DataKeyNames="MaNV"
                CommandItemDisplay="Top"
                InsertItemPageIndexAction="ShowItemOnCurrentPage"
                EditMode="InPlace">
                <CommandItemSettings
                      showexporttoexcelbutton="true" 
                    ShowAddNewRecordButton="true" AddNewRecordText="F12 - Thêm"
                    AddNewRecordImageUrl="~/img/icon/add.gif"
                    ShowCancelChangesButton="true"
                    CancelChangesText="F10 - Thoát"
                    ShowRefreshButton="false"
                    RefreshImageUrl="~/img/icon/add.gif"
                    RefreshText="F10-Thoát" />
                <FilterItemStyle Width="100%" />
                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                    <telerik:GridSortExpression FieldName="MaNV" />
                    <telerik:GridSortExpression FieldName="Hoten" />

                </SortExpressions>
                <Columns>

                    <telerik:GridEditCommandColumn ButtonType="ImageButton" UpdateText="Enter-Ghi" CancelText="ESC-Không ghi"
                        EditText="Sửa" InsertText="Enter-Ghi"
                        ItemStyle-Width="60px" HeaderStyle-Width="60px">
                    </telerik:GridEditCommandColumn>

                    <telerik:GridButtonColumn ItemStyle-Width="30px" HeaderStyle-Width="30px" ConfirmText="Bạn có chắc muốn xóa bản ghi này?" ConfirmDialogType="RadWindow" ConfirmTitle="Xóa bản ghi" ButtonType="ImageButton" CommandName="Delete" UniqueName="Delete" />

                    <telerik:GridButtonColumn ItemStyle-Width="30px" HeaderStyle-Width="30px" ButtonType="ImageButton"
                        ImageUrl="~/img/icon/permission.jpg" HeaderText="Quyền" Text="Quyền"
                        HeaderStyle-Font-Bold="true"
                        CommandName="EditRoles" UniqueName="EditRoles" />

                    <telerik:GridBoundColumn DataField="MaNV" HeaderText="Mã NV" ReadOnly="true" ForceExtractValue="Always" ConvertEmptyStringToNull="true" ItemStyle-Width="100px" HeaderStyle-Width="100px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />


                    <telerik:GridBoundColumn DataField="Hoten" HeaderText="Họ tên" ItemStyle-Width="200px" HeaderStyle-Width="200px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />

                          <telerik:GridBoundColumn DataField="NgaySinh" HeaderText="Ngày Sinh" ItemStyle-Width="100px" HeaderStyle-Width="100px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />


                    <telerik:GridBoundColumn DataField="MaBHXH" HeaderText="Mã BHXH" ItemStyle-Width="100px" HeaderStyle-Width="100px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />

                   




                    <telerik:GridTemplateColumn DataField="MaChucVu"
                        HeaderText="Chức vụ" UniqueName="MaChucVu" ItemStyle-Width="150px" HeaderStyle-Width="150px"
                        HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <%#Eval("TenCV") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <telerik:RadComboBox  ID="cboChucVu" runat="server"
                                 DataValueField="Key" Width="100%" 
                                DataTextField="Value" DataSourceID="ObjectDanhMucCV" >
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>

                    <telerik:GridTemplateColumn DataField="MaKhoa"
                        HeaderText="   Khoa" UniqueName="MaKhoa" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <%#Eval("TenKhoa") %>
                        </ItemTemplate>
                        <EditItemTemplate>

                            <telerik:RadComboBox  ID="cboKhoa" runat="server" DataValueField="Key" DataTextField="Value" DataSourceID="ObjectDanhMucKhoa" 
                                Width="100%">
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>

                    <telerik:GridTemplateColumn DataField="MaChuyenMon" UniqueName="MaChuyenMon" HeaderText="Chuyên môn" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <%#Eval("TenChuyenmon") %>
                        </ItemTemplate>



                        <EditItemTemplate>

                            <telerik:RadComboBox  
                                ID="cboChuyenmon" runat="server" DataValueField="Key" 
                                 DataTextField="Value" DataSourceID="ObjectDanhMucChuyenMon"
                                Width="100%">
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>


                    
                         <telerik:GridBoundColumn DataField="PhamVi_CM" HeaderText="P.Vi HĐ Chuyên Môn" ItemStyle-Width="100px" HeaderStyle-Width="200px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />


                                             <telerik:GridBoundColumn DataField="PhamVi_CMBS" HeaderText="P.Vi  Chuyên Môn bổ sung" ItemStyle-Width="100px" HeaderStyle-Width="200px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />


                    <telerik:GridTemplateColumn DataField="MaCD"
                        HeaderText="Chức danh" UniqueName="MaCD" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <%#Eval("TenCD") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <telerik:RadComboBox  ID="cboChucDanh" runat="server" DataValueField="Key" DataTextField="Value" DataSourceID="ObjectDanhMucChucDanh"
                                Width="100%">
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>


                                             <telerik:GridBoundColumn DataField="ThoiGian_Ngay " HeaderText="Thời gian làm việc trong tuần (theo giờ)" ItemStyle-Width="100px" HeaderStyle-Width="150px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />

                                                                 <telerik:GridBoundColumn DataField="ThoiGian_Tuan" HeaderText="Ngày làm việc trong tuần (theo ngày)" ItemStyle-Width="100px" HeaderStyle-Width="150px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />

                    <telerik:GridBoundColumn MaxLength="20" DataField="DienThoai" HeaderText="Điện thoại" UniqueName="DienThoai" ItemStyle-Width="100px" HeaderStyle-Width="100px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false"></telerik:GridBoundColumn>


                     <telerik:GridBoundColumn DataField="NgayCap_CCHN" HeaderText="Ngày cấp CCHN" ItemStyle-Width="100px" HeaderStyle-Width="100px"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" />

                    <telerik:GridBoundColumn MaxLength="225" DataField="MaChungChiHanhNghe" HeaderText="Mã CCHN" UniqueName="MaChungChiHanhNghe" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                    </telerik:GridBoundColumn>     
                    
                     <telerik:GridBoundColumn MaxLength="20" DataField="DienThoaiKhoa" HeaderText="ĐT Khoa" UniqueName="DienThoaiKhoa" ItemStyle-Width="100px" HeaderStyle-Width="100px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false"></telerik:GridBoundColumn>

                     <telerik:GridTemplateColumn DataField="NguoiGiamHo" HeaderText="Người giám hộ" UniqueName="NguoiGiamHo" ItemStyle-Width="200px" HeaderStyle-Width="200px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                          <ItemTemplate>
                            <%#Eval("TenNguoiGiamHo") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <telerik:RadComboBox  ID="DMNguoiGiamHo" EnableAutomaticLoadOnDemand="true" EnableLoadOnDemand="true"
                                runat="server" DataValueField="MaNV" DataTextField="HoTen" DataSourceID="odsDMNguoiGiamHo"
                                Width="190px" Filter="Contains">
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                     </telerik:GridTemplateColumn>                                                     
                      <telerik:GridTemplateColumn DataField="MaLoaiHD" HeaderText="Loại NV" UniqueName="MaLoaiHD" ItemStyle-Width="200px" HeaderStyle-Width="200px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                          <ItemTemplate>
                            <%#Eval("TenLoaiHD") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <telerik:RadComboBox  ID="cboLoaiHD" EnableAutomaticLoadOnDemand="true" EnableLoadOnDemand="true"
                                runat="server" DataValueField="Key" DataTextField="Value" DataSourceID="odsDMLoaiHD"
                                Width="190px" Filter="Contains">
                            </telerik:RadComboBox>
                        </EditItemTemplate>
                     </telerik:GridTemplateColumn>    
                     <telerik:GridBoundColumn MaxLength="20" DataField="DienThoaiKhoa" HeaderText="Tài khoản" UniqueName="TaiKhoan" ItemStyle-Width="100px" HeaderStyle-Width="100px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false"></telerik:GridBoundColumn>
                     <telerik:GridBoundColumn MaxLength="20" DataField="GhiChu" HeaderText="Số CMT" UniqueName="SoCMT" ItemStyle-Width="100px" HeaderStyle-Width="100px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false"></telerik:GridBoundColumn>
                      
                     <telerik:GridTemplateColumn DataField="GhiChu"
                        HeaderText="Quầy" UniqueName="GhiChu" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <%#Eval("GhiChu") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList  ID="cboQuay" runat="server" DataValueField="Key" DataTextField="Value" DataSourceID="ObjectDanhMucQuay"
                                Width="100%">
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn DataField="ChuKy"
                        HeaderText="Chữ ký" UniqueName="ChuKy" ItemStyle-Width="150px" HeaderStyle-Width="150px"
                         HeaderStyle-Font-Bold="true"
                        AllowFiltering="false">
                        <ItemTemplate>
                            <asp:Image ID="anhChuKy" runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                             <telerik:RadAsyncUpload ID="ChuKy" runat="server">
                             </telerik:RadAsyncUpload>
                        </EditItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridCheckBoxColumn DataField="KhongSD" DataType="System.Boolean"
                        FilterControlAltText="Filter KhongSD column" HeaderText="Không SD" ReadOnly="false"
                        AllowFiltering="false"
                        HeaderStyle-Width="70px"
                        SortExpression="KhongSD" UniqueName="KhongSD">
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridCheckBoxColumn DataField="Huy" DataType="System.Boolean"
                        FilterControlAltText="Filter Huy column" HeaderText="Hủy" ReadOnly="false"
                        HeaderStyle-Width="50px"
                        SortExpression="Huy" UniqueName="Huy"
                        AllowFiltering="false">
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridBoundColumn DataField="MaMay"
                        FilterControlAltText="Filter MaMay column" HeaderText="Mã máy" ReadOnly="true"
                        SortExpression="MaMay" UniqueName="MaMay"
                        ItemStyle-Width="100px" HeaderStyle-Width="100px"
                        AllowFiltering="false">
                        <HeaderStyle />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="NGuoiSD"
                        FilterControlAltText="Filter NGuoiSD column" HeaderText="Người SD"
                        ReadOnly="true" SortExpression="NGuoiSD" UniqueName="NGuoiSD"
                        ItemStyle-Width="150px" HeaderStyle-Width="150px">

                        <HeaderStyle />
                    </telerik:GridBoundColumn>

                </Columns>


            </MasterTableView>
            <PagerStyle Mode="NextPrevAndNumeric" />

            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <ClientEvents OnRowClick="RowClickForDMForms" OnRowDblClick="RowDblClickForDMForms" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>


        </telerik:RadGrid>

        <telerik:RadInputManager runat="server" ID="RadInputManager1" Enabled="true">
            <telerik:TextBoxSetting BehaviorID="TextBoxSetting1">
            </telerik:TextBoxSetting>

            <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting1" Type="Number" AllowRounding="true" DecimalDigits="2">
            </telerik:NumericTextBoxSetting>

            <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting2" Type="Number"
                AllowRounding="true" DecimalDigits="0" MinValue="0">
            </telerik:NumericTextBoxSetting>
        </telerik:RadInputManager>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" />

    </div>

    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucKhoa" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMKhoaListcb"></asp:ObjectDataSource>






    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucCV" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMChucVuListcb"></asp:ObjectDataSource>



    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucChuyenMon" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMChuyenMonListcb"></asp:ObjectDataSource>

     <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" 
         CacheDuration="180" ID="odsDMLoaiHD" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMLoaiHopDongListcb">
         
     </asp:ObjectDataSource>
    

    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucChucDanh" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMChucDanhListcb"></asp:ObjectDataSource>
    
    <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMucQuay" runat="server"
        SelectMethod="GetList"
        TypeName="HTC.Business.CategoryList.DMQuayListcb"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odsDMNguoiGiamHo" runat="server" SelectMethod="FindDMNhanVienByMa"
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="ma" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>




