<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMMayCLS.cs" Inherits="UI_Category_DMDichVu_frmDMMayCLS" %>

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

            <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="False" CommandItemDisplay="Top" EditMode="InPlace" HorizontalAlign="Center" DataKeyNames="MA_MAY">
                <CommandItemSettings
                    AddNewRecordText="F12-Thêm"  AddNewRecordImageUrl="~/img/icon/add.gif"        
                    CancelChangesText="F10 - Thoát"
                    SaveChangesText="F9-Ghi"
                    RefreshText="F10-Thoát"
                    ShowCancelChangesButton="true"
                    ShowRefreshButton="false" ShowAddNewRecordButton="true" />
                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                   
                    <telerik:GridSortExpression FieldName="MA_MAY" />
                     <telerik:GridSortExpression FieldName="TEN_TB" />
                    

                    



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



<%--                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="MA_MAY" FilterControlAltText="Filter MA_MAY column" HeaderText="Mã Máy CLS" SortExpression="MA_MAY" UniqueName="MA_MAY">
                        <ColumnValidationSettings EnableRequiredFieldValidation="true">
                            <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                            </RequiredFieldValidator>
                        </ColumnValidationSettings>

                    </telerik:GridBoundColumn>--%>


                    
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="MA_MAY" FilterControlAltText="Filter MA_MAY column" HeaderText="Mã Máy CLS" SortExpression="MA_MAY" UniqueName="MA_MAY" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                        <ColumnValidationSettings EnableRequiredFieldValidation="true">
                            <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                            </RequiredFieldValidator>
                        </ColumnValidationSettings>

                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="TEN_TB" FilterControlAltText="Filter TEN_TB column" HeaderText="Tên TB" SortExpression="TEN_TB" UniqueName="TEN_TB" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                        <ColumnValidationSettings EnableRequiredFieldValidation="true">
                            <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                            </RequiredFieldValidator>
                        </ColumnValidationSettings>

                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="KY_HIEU" FilterControlAltText="Filter KY_HIEU column" HeaderText=" Ký Hiệu " SortExpression="KY_HIEU" UniqueName="KY_HIEU" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                  <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="CONGTY_SX" FilterControlAltText="Filter CONGTY_SX column" HeaderText=" Công ty sản xuất " SortExpression="CONGTY_SX" UniqueName="CONGTY_SX" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="NUOC_SX" FilterControlAltText="Filter NUOC_SX column" HeaderText=" Nước sản xuất " SortExpression="NUOC_SX" UniqueName="NUOC_SX" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                     <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="NAM_SX" FilterControlAltText="Filter NAM_SX column" HeaderText=" Năm sản xuất " SortExpression="NAM_SX" UniqueName="NAM_SX" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="NAM_SD" FilterControlAltText="Filter NAM_SD column" HeaderText=" Năm sử dụng " SortExpression="NAM_SD" UniqueName="NAM_SD" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="SO_LUU_HANH" FilterControlAltText="Filter SO_LUU_HANH column" HeaderText=" Số lưu hành" SortExpression="SO_LUU_HANH" UniqueName="SO_LUU_HANH" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="HD_TU" FilterControlAltText="Filter HD_TU column" HeaderText=" HD Từ " SortExpression="HD_TU" UniqueName="HD_TU" ItemStyle-Width="100px" HeaderStyle-Width="150px">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="HD_DEN" FilterControlAltText="Filter HD_DEN column" HeaderText=" HD Đến" SortExpression="HD_DEN" UniqueName="HD_DEN" ItemStyle-Width="100px" HeaderStyle-Width="150px">
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
                          <telerik:GridBoundColumn    DataField="NgaySD"
                        FilterControlAltText="Filter NgaySD column" HeaderText="Ngày SD" ReadOnly="true"
                        SortExpression="NgaySD" UniqueName="NgaySD"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        HeaderStyle-Width="100px"
                        >
                        <HeaderStyle />
                    </telerik:GridBoundColumn>
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

