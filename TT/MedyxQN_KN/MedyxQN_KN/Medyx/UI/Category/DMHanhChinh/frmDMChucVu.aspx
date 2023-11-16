<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMChucVu.aspx.cs" Inherits="UI_Category_DMHanhChinh_frmDMChucVu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
 
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
  
    <telerik:RadToolBar ID="baraction" runat="server" EnableRoundedCorners="true" EnableShadows="true" Width="100%"  style="display:none">
        <Items >  
            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"  Text="Thêm quốc gia" group ="Align" CheckOnClick="false" Value ="cmdAdd" CommandName="cmdAdd" >
            </telerik:RadToolBarButton>            
        </Items>
    </telerik:RadToolBar>                   

    <div>            
        <telerik:RadGrid AllowFilteringByColumn="True" Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true"         ID="grdChiTiet" runat="server"                                         
                    AutoGenerateColumns="false" 
                    GridLines="None"                     
                    
                    onitemcommand="grdChiTiet_ItemCommand" 
                    ondeletecommand="grdChiTiet_DeletedCommand" 
                    oninsertcommand="grdChiTiet_InsertCommand" 
                    onupdatecommand="grdChiTiet_UpdateCommand" 

                    onneeddatasource="grdChiTiet_NeedDataSource"                     
                    Skin="Default"                                                       
                    ClientSettings-Scrolling-AllowScroll="true"
                    ShowFooter="false" AllowSorting="true" AllowPaging="true" PageSize="50" PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100"  PagerStyle-AlwaysVisible="true"
                                
            >
             <GroupingSettings CaseSensitive="false" ShowUnGroupButton="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">                      
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <ClientEvents OnRowClick="RowClickForDMForms" OnRowDblClick="RowDblClickForDMForms" OnCommand="GridCommandForDMForms" />
                        <KeyboardNavigationSettings AllowActiveRowCycle ="true" AllowSubmitOnEnter ="true" FocusKey ="Y"   EnableKeyboardShortcuts="true"  ValidationGroup="CustomValidatioGroup" /> 
            </ClientSettings>
             
            <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="False" CommandItemDisplay="Top" EditMode="InPlace"  HorizontalAlign="Center" DataKeyNames="MaCV" >
                <CommandItemSettings 
                    
                    AddNewRecordText="F12-Thêm"  AddNewRecordImageUrl="~/img/icon/add.gif"         
                    CancelChangesText="F10 - Thoát"                     
                    SaveChangesText="F9-Ghi"

                    
                    RefreshText="F10-Thoát" 
                    ShowCancelChangesButton="true"

                    ShowRefreshButton="false" ShowAddNewRecordButton="true"    />                       
                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                    <telerik:GridSortExpression FieldName="MaCV" />
                    <telerik:GridSortExpression FieldName="TenCV" />
                </SortExpressions>
                <columns>
                        <telerik:GridEditCommandColumn ButtonType="ImageButton" UpdateText="Enter-Ghi" CancelText="ESC-Không ghi"
                                    EditText="Sửa" InsertText ="Enter-Ghi"
                                    ItemStyle-Width="60px" HeaderStyle-width="60px"
                        >
                    </telerik:GridEditCommandColumn>     
                       <telerik:GridButtonColumn ItemStyle-Width="20px" HeaderStyle-Width="20px" ConfirmText="Bạn có chắc muốn xóa bản ghi này?" ConfirmDialogType="RadWindow" ConfirmTitle="Xóa bản ghi" ButtonType="ImageButton" CommandName="Delete" UniqueName ="Delete" />

                   <telerik:GridBoundColumn DataField="OrderNumber"  AllowFiltering="false"
                        FooterAggregateFormatString="Tổng số: {0} "
                        FilterControlAltText="Filter OrderNumber column" 
                        HeaderText="STT" readonly="true" SortExpression="OrderNumber" 
                        UniqueName="OrderNumber" ItemStyle-Width="50px" HeaderStyle-Width="50px">                              
                    </telerik:GridBoundColumn>

<%--                    <telerik:GridBoundColumn   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="MaCV" ItemStyle-Width="80px" HeaderStyle-Width="80px"  FilterControlAltText="Filter MaCV column" HeaderText="Mã CV" readonly="true" SortExpression="MaCV" UniqueName="MaCV"                        >                              

                    </telerik:GridBoundColumn>--%>

                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="MaCV" FilterControlAltText="Filter MaCV column" HeaderText="Mã CV" SortExpression="MaCV" UniqueName="MaCV"  FilterCheckListWebServiceMethod="LoadChucVuList"  >
                                <ColumnValidationSettings EnableRequiredFieldValidation="true">
                                <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                        </RequiredFieldValidator>
                    </ColumnValidationSettings>                             
                    </telerik:GridBoundColumn>


                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="TenCV" FilterControlAltText="Filter TenCV column" HeaderText="Tên CV" SortExpression="TenCV" UniqueName="TenCV"  FilterCheckListWebServiceMethod="LoadChucVuList"  >
                                <ColumnValidationSettings EnableRequiredFieldValidation="true">
                                <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                        </RequiredFieldValidator>
                    </ColumnValidationSettings>                             
                    </telerik:GridBoundColumn>



                     <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="Vi_Tri" FilterControlAltText="Filter Vi_Tri column" HeaderText="Vị Trí" SortExpression="Vi_Tri" UniqueName="Vi_Tri"  FilterCheckListWebServiceMethod="LoadChucVuList"  >
                                <ColumnValidationSettings EnableRequiredFieldValidation="true">
                                <RequiredFieldValidator Display="Dynamic" ForeColor="Red" Text="Yêu cầu phải nhập">
                        </RequiredFieldValidator>
                    </ColumnValidationSettings>                             
                    </telerik:GridBoundColumn>



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
                      
                                                                

                 

                </columns>
            </MasterTableView>
        </telerik:RadGrid>
              
            <br />
            <br />                          
    </div>            

</asp:Content>

