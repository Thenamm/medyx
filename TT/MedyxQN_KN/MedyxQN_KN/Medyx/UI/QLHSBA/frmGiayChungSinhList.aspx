<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmGiayChungSinhList.aspx.cs" Inherits="UI_QLHSBA_frmGiayChungSinhList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">    
    <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
    <style type="text/css">
    .ButtonCSS
       {
           margin-left:400px;
       }

   </style>
      <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
   <script type="text/javascript">
       $(function () {
           $("#<%= dtDenNgay.ClientID %>, #<%= dtTuNgay.ClientID %>").datepicker({
                 dateFormat: 'dd/mm/yy',
                 altFormat: "dd/mm/yy",
                 minDate: '01/01/1900',
                 maxDate: '31/12/2100'
             }).focus(function () {
                 var val = $(this).val();

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

var hasChanges, inputs, dropdowns, editedRow, editedRowDS;
      
        function DoubleRowDSClick(sender, eventArgs) {
    //           var selecteditem = $find("<%= grdDanhSach.MasterTableView.ClientID %>").get_selectedItems();
           editedRowDS = eventArgs.get_itemIndexHierarchical();
           var grid = $find("<%= grdDanhSach.ClientID %>");

           grid.get_masterTableView().fireCommand("Edit", editedRowDS); //add master editing activities in the grid}


       }
       function RowSelected(sender, eventArgs) {
           //           var selecteditem = $find("<%= grdDanhSach.MasterTableView.ClientID %>").get_selectedItems();
                editedRowDS = eventArgs.get_itemIndexHierarchical();
                var grid = $find("<%= grdDanhSach.ClientID %>");

           grid.get_masterTableView().fireCommand("ViewDetail", editedRowDS); //add master editing activities in the grid}
          

       }
       $(document).ready(function () {
           $("#<%= dtDenNgay.ClientID %>").mask("99/99/9999");
           $("#<%= dtTuNgay.ClientID %>").mask("99/99/9999");
       });
    
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
               <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                Text="F10-Thoát"  CheckOnClick="false" Value ="cmdExit" >
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="F6-Xem"   CssClass="ButtonCSS" Value ="cmdView">
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                Text="F7-Tìm kiếm"  CheckOnClick="false" Value ="cmdFilter" >
            </telerik:RadToolBarButton>
            </Items>
         </telerik:RadToolBar>
        </div>
      <fieldset align="center">
            <legend>
               
            </legend> 
    <div style="align-content:center!important">
        <table>
            <tr>
                <td style="width:10%!important;text-align:right!important">
                    <asp:Label ID="Label13" runat="server" Text="Từ ngày" Font-Bold="true"></asp:Label>
                </td>
                    
                <td style="width:10%!important"><asp:TextBox runat="server" TabIndex="1" ID="dtTuNgay"></asp:TextBox></td>
 
                <td style="width:10%!important;text-align:right!important">
                    <asp:Label ID="Label17" runat="server" Text="Đến ngày" Font-Bold="true"></asp:Label>
                 </td>
                    
                <td style="width:10%!important">   <asp:TextBox ID="dtDenNgay" runat="server" MaxLength="1" Style="text-align: justify"></asp:TextBox>
                </td>
                <td style="width:10%!important;text-align:right!important">
                    <asp:Label ID="Label15" runat="server" Text="Khoa" Font-Bold="true"></asp:Label>
                 </td>
                <td>   <telerik:RadComboBox runat="server" ID="cboKhoa" DataSourceID="odsKhoa" Style="width:275px !important"
                            DataTextField="Value" DataValueField="Key" AutoPostBack="true"
                            OnSelectedIndexChanged ="cboKhoa_SelectedIndexChanged">
                        </telerik:RadComboBox>
                </td>
               
            </tr>
            
            </table> 
             </div>
          </fieldset>
                    <telerik:RadGrid Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true"          
                        ID="grdDanhSach" GroupingSettings-CaseSensitive ="false" runat="server"
                        AutoGenerateColumns="false"
                        GridLines="Both"  EnableViewState ="true" 
                        OnItemCommand="grdDanhSach_ItemCommand"
                        
                        OnNeedDataSource="grdDanhSach_NeedDataSource"
                        AllowAutomaticInserts="false" AllowAutomaticUpdates="false"
                        AllowSorting="true" Height="297px" width ="100%"
                        ClientSettings-Scrolling-AllowScroll="true"
                        ShowFooter="false" AllowPaging="true" PageSize="50" PagerStyle-Visible="true" 
                        MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100"  PagerStyle-AlwaysVisible="true"
                        AllowFilteringByColumn="false" ShowStatusBar="true" Font-Size="Small">
                            <GroupingSettings CaseSensitive="false"  /> 
                        <ClientSettings EnableRowHoverStyle="false" AllowKeyboardNavigation="true">
                            <Selecting AllowRowSelect="true" EnableDragToSelectRows="false" />
                            <Scrolling AllowScroll="True" UseStaticHeaders="true" SaveScrollPosition="true" />
                            <KeyboardNavigationSettings ValidationGroup="CustomValidatioGroup" />
                            <ClientEvents OnRowDblClick ="DoubleRowDSClick" OnRowSelected ="RowSelected" />
                        </ClientSettings>
                        <MasterTableView  AutoGenerateColumns="False" DataKeyNames="MaBN, MaBA"
                             HorizontalAlign="NotSet" CommandItemDisplay="Top" EditMode="InPlace" Width="100%" >
                                 <CommandItemTemplate/>
                            <FilterItemStyle Width="100%" />
                            <SortExpressions>
                                <telerik:GridSortExpression FieldName="MaBN, MaBA" />
                            </SortExpressions>
                            <Columns>
                                <telerik:GridEditCommandColumn ButtonType="ImageButton" UpdateText="Enter-Ghi" CancelText="ESC-Không ghi" 
                                                    EditText="Sửa" InsertText ="Enter-Ghi" UniqueName ="Edit"
                                                    ItemStyle-Width="30px" HeaderStyle-width="30px" ItemStyle-HorizontalAlign="Center" >
                                                    </telerik:GridEditCommandColumn>

                               
                                <telerik:GridBoundColumn DataField="MaBN" Display="true"
                                    FilterControlAltText="Filter MaBN column" HeaderText="Mã BN" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                                    SortExpression="MaBN" UniqueName="MaBN">
                                    <HeaderStyle Width="150px"  />
                                </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="MaBA" Display="false"
                                    FilterControlAltText="Filter MaBA column" HeaderText="Mã BA" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                                    SortExpression="MaBA" UniqueName="MaBA">
                                    <HeaderStyle Width="150px"  />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Hoten"
                                    FilterControlAltText="Filter Hoten column" HeaderText="Tên bệnh nhân"   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"   
                                    SortExpression="Hoten" UniqueName="Hoten">
                                    <HeaderStyle Width="200px" />
                                </telerik:GridBoundColumn>
<%--                                <telerik:GridBoundColumn DataField="Lansinh"
                                    FilterControlAltText="Filter Lansinh column" HeaderText="Lần sinh"   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"   
                                    SortExpression="Lansinh" UniqueName="Lansinh">
                                    <HeaderStyle Width="200px" />
                                </telerik:GridBoundColumn>--%>
<%--                                <telerik:GridBoundColumn DataField="TenBenhRaVien"
                                    FilterControlAltText="Filter TenBenhRaVien column" HeaderText="Tên bệnh"   CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"   
                                    SortExpression="TenBenhRaVien" UniqueName="TenBenhRaVien">
                                    <HeaderStyle Width="200px" />
                                </telerik:GridBoundColumn>--%>
                            </Columns>
                        </MasterTableView>                        
                    </telerik:RadGrid>
                <telerik:RadGrid Culture="vi-VN" ClientSettings-Resizing-AllowColumnResize="true" 
                    ID="grdChiTiet" runat="server" AllowAutomaticDeletes="True" OnItemCommand="grdChiTiet_ItemCommand"
                    AllowAutomaticInserts="True" AllowAutomaticUpdates="false"
                    AutoGenerateColumns="false" GridLines="None" Height="123px" Font-Size="Small">
                    <ClientSettings AllowKeyboardNavigation="true" EnableRowHoverStyle="false">
                        <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                        <Scrolling AllowScroll="True" SaveScrollPosition="true" 
                            UseStaticHeaders="true" />
                    </ClientSettings>
                    <MasterTableView  TableLayout="Fixed" AllowAutomaticDeletes="True" AllowAutomaticInserts="True"
                        AllowAutomaticUpdates="True" AutoGenerateColumns="False"
                       DataKeyNames="MaBN, MaBA,SoGiayChungSinh"
                        HorizontalAlign="NotSet" NoDetailRecordsText="Không có dữ liệu" Width ="100%"
                        NoMasterRecordsText="Không có dữ liệu" >
                         <SortExpressions>
                            <telerik:GridSortExpression FieldName="MaBN, MaBA,SoGiayChungSinh"/>
                        </SortExpressions>
                        <Columns>   
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" UpdateText="Enter-Ghi" CancelText="ESC-Không ghi" 
                                                    EditText="Sửa" InsertText ="Enter-Ghi" UniqueName ="Edit"
                                                    ItemStyle-Width="30px" HeaderStyle-width="30px" ItemStyle-HorizontalAlign="Center" >
                                                    </telerik:GridEditCommandColumn>

                                   <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" UniqueName="Delete"
                                ConfirmDialogType="RadWindow" ConfirmText="Bạn muốn xóa phiếu ?" ConfirmTitle="Delete"
                                HeaderText="" Text="Delete">
                                <HeaderStyle Width="20px" HorizontalAlign="Center" />
                            </telerik:GridButtonColumn>


                             <%--<telerik:GridButtonColumn ItemStyle-Width="40px" HeaderStyle-Width="40px" ConfirmText="Bạn có chắc muốn xóa bản ghi này?" ConfirmDialogType="RadWindow" ConfirmTitle="Xóa bản ghi" ButtonType="ImageButton" CommandName="Delete" UniqueName ="Delete" />--%>
                            <telerik:GridBoundColumn DataField="SoGiayChungSinh"
                                FilterControlAltText="Filter SoGiayChungSinh column"
                                HeaderText="Số giấy chứng sinh" ReadOnly="true" SortExpression="SoGiayChungSinh"
                                UniqueName="SoGiayChungSinh" AllowFiltering="true" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true"
                                 ShowFilterIcon="false">
                                <HeaderStyle Width="50px" />
                            </telerik:GridBoundColumn>








                            <telerik:GridBoundColumn DataField="MaBN"
                                FilterControlAltText="Filter MaBN column"
                                HeaderText="Mã BN" ReadOnly="true" SortExpression="MaBN"
                                UniqueName="MaBN" AllowFiltering="false" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false">
                                <HeaderStyle Width="100px" />
                            </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="HOTEN_NND"
                                FilterControlAltText="Filter HOTEN_NND column"
                                HeaderText="Tên bệnh nhân" ReadOnly="true" SortExpression="HOTEN_NND"
                                UniqueName="HOTEN_NND" AllowFiltering="false" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false">
                                <HeaderStyle Width="100px" />
                            </telerik:GridBoundColumn>
                            <telerik:GridCheckBoxColumn DataField="Huy"
                                    FilterControlAltText="Filter Huy column" HeaderText="Hủy" AllowFiltering="false"
                                    SortExpression="Huy" UniqueName="Huy">
                                    <HeaderStyle  />
                                </telerik:GridCheckBoxColumn>

<%--                            <telerik:GridBoundColumn DataField="NgayTV"
                                FilterControlAltText="Filter NgayTV column"
                                HeaderText="Ngày Tử vong" ReadOnly="true" SortExpression="TenBN"
                                UniqueName="NgayTV" AllowFiltering="true" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false">
                                <HeaderStyle Width="100px" />
                            </telerik:GridBoundColumn>--%>
                      </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
        <asp:ObjectDataSource ID="odsKhoa" runat="server" SelectMethod="GetListByAccountNoiTru"  OnSelecting ="odsKhoa_Selecting" 
        TypeName="HTC.Business.CategoryList.DMKhoaListcb" EnableViewState="true">
          <SelectParameters>
            <asp:Parameter Name="account" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

