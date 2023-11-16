<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMLoaiHinhKCB.cs" Inherits="UI_Category_DMHanhChinh_frmDMLoaiHinhKCB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

   

        <style type="text/css">
            /*
             table
             {
                border-collapse:inherit;
                border-spacing:3px;
             }

             
             .RadGrid_Default
             {
                 border-width:1px;
             }
             */
        </style>
    </telerik:RadCodeBlock>

    <telerik:RadToolBar ID="baraction" runat="server" EnableRoundedCorners="true" EnableShadows="true" Width="100%"  Style="display: none">
        <Items>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif" Text="Thêm nghề nghiệp" Group="Align" CheckOnClick="false" Value="cmdAdd" CommandName="cmdAdd">
            </telerik:RadToolBarButton>
        </Items>
    </telerik:RadToolBar>

    <div>
        <telerik:RadGrid AllowFilteringByColumn="True" Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true"         ID="grdChiTiet" runat="server"
            AutoGenerateColumns="false"
            GridLines="None"
            OnItemCommand="grdChiTiet_ItemCommand"
            OnDeleteCommand="grdChiTiet_DeletedCommand"
            OnInsertCommand="grdChiTiet_InsertCommand"
            OnUpdateCommand="grdChiTiet_UpdateCommand"
            OnNeedDataSource="grdChiTiet_NeedDataSource"
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

            <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="False" CommandItemDisplay="Top" EditMode="InPlace" HorizontalAlign="Center" DataKeyNames="MA_LOAI_KCB">
                <CommandItemSettings
                    AddNewRecordText="F12-Thêm"  AddNewRecordImageUrl="~/img/icon/add.gif"        
                    CancelChangesText="F10 - Thoát"
                    SaveChangesText="F9-Ghi"
                    RefreshText="F10-Thoát"
                    ShowCancelChangesButton="true"
                    ShowRefreshButton="false" ShowAddNewRecordButton="true" />
                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                    <telerik:GridSortExpression FieldName="MA_LOAI_KCB" />
                    <telerik:GridSortExpression FieldName="TEN_LOAI_KCB" />
                </SortExpressions>
                <Columns>
                    <telerik:GridEditCommandColumn ButtonType="ImageButton" UpdateText="Enter-Ghi" CancelText="ESC-Không ghi"
                        EditText="Sửa" InsertText="Enter-Ghi"
                        ItemStyle-Width="50px" HeaderStyle-Width="50px">
                    </telerik:GridEditCommandColumn>
                    <telerik:GridButtonColumn ItemStyle-Width="20px" HeaderStyle-Width="20px" ConfirmText="Bạn có chắc muốn xóa bản ghi này?" ConfirmDialogType="RadWindow" ConfirmTitle="Xóa bản ghi" ButtonType="ImageButton" CommandName="Delete" UniqueName ="Delete" />

                    <telerik:GridBoundColumn DataField="OrderNumber"
                        FooterAggregateFormatString="Tổng số: {0} "
                        FilterControlAltText="Filter OrderNumber column"
                        HeaderText="STT" ReadOnly="true" SortExpression="OrderNumber"
                        UniqueName="OrderNumber" ItemStyle-Width="50px" HeaderStyle-Width="50px">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="MA_LOAI_KCB" ItemStyle-Width="80px" HeaderStyle-Width="80px" FilterControlAltText="Filter MA_LOAI_KCB column" HeaderText="Mã loại KCB" ReadOnly="true" SortExpression="MA_LOAI_KCB" UniqueName="MA_LOAI_KCB">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="TEN_LOAI_KCB" FilterControlAltText="Filter TEN_LOAI_KCB column" HeaderText="Tên loại KCB" SortExpression="TEN_LOAI_KCB" UniqueName="TEN_LOAI_KCB">
                        <ColumnValidationSettings EnableRequiredFieldValidation="true">
                            <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                            </RequiredFieldValidator>
                        </ColumnValidationSettings>

                    </telerik:GridBoundColumn>

                  <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="LoaiBN" FilterControlAltText="Filter LoaiBN column" HeaderText="Loại BN" SortExpression="LoaiBN" UniqueName="LoaiBN">
                    </telerik:GridBoundColumn>
<%--                     <telerik:GridBoundColumn   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="GhiChu" FilterControlAltText="Filter GhiChu column" 
                         HeaderText="Ghi Chú" SortExpression="GhiChu"> 
                                
                     </telerik:GridBoundColumn>--%>

                   
                     <telerik:GridBoundColumn    DataField="MaMay"
                        FilterControlAltText="Filter MaMay column" HeaderText="Mã máy" ReadOnly="true"
                        SortExpression="MaMay" UniqueName="MaMay"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        HeaderStyle-Width="100px"
                        >
                        <HeaderStyle />
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="Huy" DataType="System.Boolean"
                        FilterControlAltText="Filter Huy column" HeaderText="Hủy" ReadOnly="false"
                        AllowFiltering="false"
                        HeaderStyle-Width="50px"
                        SortExpression="Huy" UniqueName="Huy">
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridBoundColumn DataField="NguoiSD"
                        FilterControlAltText="Filter NguoiSD column" HeaderText="Người SD"
                        HeaderStyle-Width="100px" 
                        ReadOnly="true" SortExpression="NguoiSD" UniqueName="NguoiSD" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false">
                        <HeaderStyle />
                    </telerik:GridBoundColumn>

                                              
                    
                  

                </Columns>
            </MasterTableView>
        </telerik:RadGrid>

        <br />
        <br />
    </div>

</asp:Content>

