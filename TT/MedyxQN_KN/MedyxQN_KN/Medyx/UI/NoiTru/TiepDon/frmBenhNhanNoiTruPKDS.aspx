<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmBenhNhanNoiTruPKDS.aspx.cs" Inherits="UI_NoiTru_TiepDon_frmDangKyDS" %>

<%@ Import Namespace="HTC.Business.NoiTru" %>
<%@ Import Namespace="HTC.Business.CategoryList" %>
<%-- <%@ Register Src="~/UserControls/HTCReportViewer.ascx" TagName="HTCReportViewer" TagPrefix="uc1" %> --%>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

       <%-- <script type="text/javascript" src='<%: ResolveUrl("~/js/jquery.min.js") %>'></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>        --%>

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
            $(document).ready(function () {
                $("#<%= dtTuNgay.ClientID %>").mask('99/99/9999');
                $("#<%= dtDenNgay.ClientID %>").mask('99/99/9999');
                $("#<%= dtDenNgay.ClientID %>, #<%= dtTuNgay.ClientID %>").blur(function () {
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
                        if ((month != checkdate.getMonth() + 1)) {
                            $(this).val('').focus().css('background', '#fdd');
                            alert("Ngày không hợp lệ");
                        }

                    }
                });
            });

            
            function RowDblClick(sender, eventArgs) {
                            editedRow = eventArgs.get_itemIndexHierarchical();
                            var grid = $find("<%= grdDanhSach.ClientID %>");
                grid.get_masterTableView().editItem(editedRow);
                grid.get_masterTableView().get_dataItems()[editedRow].set_selected(true);

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

                if (pressedKey == 117) { //f6 - Xem                    
                    var toolbar1 = $find("<%= baraction.ClientID %>");
                    var templateButton = toolbar1.findItemByValue("cmdView");
                    templateButton.click();
                }
                else if (pressedKey == 118) { //f7 - Tìm Kiếm
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
                 else if (pressedKey == 123) { //f12-Thêm                 
                     var toolbar1 = $find("<%= baraction.ClientID %>");               
                     var templateButton = toolbar1.findItemByValue("cmdAdd");
                     templateButton.click();
                 }                     
            }

        </script>

        <style type="text/css">            

            /* .contentWrapper
                {
                    border: 1px solid black;
                }*/

         /*   .RadForm.rfdTextbox input.rfdDecorated[type="text"], .RadForm.rfdTextbox input.rfdDecorated[type="password"], .RadForm.rfdTextbox input.rfdDecorated[type="search"], .RadForm.rfdTextbox input.rfdDecorated[type="url"], .RadForm.rfdTextbox input.rfdDecorated[type="tel"], .RadForm.rfdTextbox input.rfdDecorated[type="email"]
            {
                width:100% !important;
            }*/
            
        </style>

    </telerik:RadCodeBlock>
        
    <telerik:RadToolBar ID="baraction" runat="server"
        EnableRoundedCorners="true"
        EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%" OnClientButtonClicked="processClick">
        <Items>       
            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                Text="F12 - Thêm" Group="Align" CheckOnClick="false" Value="cmdAdd" CommandName="cmdAdd">
            </telerik:RadToolBarButton>                 
            <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                Text="F10 - Thoát" Group="Align" CheckOnClick="false" Value="cmdExit" CommandName="cmdExit" >
            </telerik:RadToolBarButton>

            <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png" Text="F6 - Xem" style="padding-left:300px" Value="cmdView" CommandName="cmdView" >
            </telerik:RadToolBarButton>

            <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif" Text="F7 - Tìm kiếm" Value="cmdFilter" CommandName="cmdFilter" >
            </telerik:RadToolBarButton>

        </Items>
    </telerik:RadToolBar>

    <div class="form-container">
        <fieldset align="center">
            <legend>
                <label>
                    Tìm kiếm
                </label>
            </legend>
                                          <div align="center" >
   
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Trạng thái" Width="120px"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="cboTrangThai" DataSourceID="odsTrangThai"
                             AutoPostBack="false" DataTextField="Value" DataValueField="Key">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Từ ngày" Width="120px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="dtTuNgay"></asp:TextBox>
                        &nbsp;
                    <asp:Label runat="server" Text="Đến ngày"></asp:Label>
                        &nbsp;
                    <asp:TextBox runat="server" ID="dtDenNgay"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Đối tượng"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="cboDoiTuong" DataSourceID="odsDoiTuong"
                            DataTextField="Value" DataValueField="Key" AutoPostBack="false">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Tên khoa"></asp:Label>
                    </td>
                    <td>
                        <telerik:RadComboBox runat="server" ID="cboKhoa" Style="width:275px  !important"
                            DataTextField="Value" DataValueField="Key" AutoPostBack="true" Filter ="Contains"
                            OnSelectedIndexChanged ="cboKhoa_SelectedIndexChanged">
                        </telerik:RadComboBox>
                    </td>
                </tr>
            </table>
</div> 
        </fieldset>
    </div>

    <div style="clear: both; line-height: 5px">
        &nbsp;
    </div>

    <div id="gridContainer">

            <telerik:RadGrid ClientSettings-Resizing-AllowColumnResize="true"     
                     ID="grdDanhSach" GroupingSettings-CaseSensitive ="false" runat="server"
            AutoGenerateColumns="false"
            GridLines="None"

            OnItemCommand="grdDanhSach_ItemCommand"

            OnNeedDataSource="grdDanhSach_NeedDataSource"

            HeaderStyle-Font-Bold="true"

            Selecting-AllowRowSelect="true" EnablePostBackOnRowClick="true"
            OnSelectedIndexChanged="grdDanhSach_SelectedIndexChanged"

            Height="450px"
            Skin="Default" Culture="vi-VN"
            ClientSettings-Scrolling-AllowScroll="true"
            ShowFooter="false" AllowSorting="true" 

            AllowPaging="true" PageSize="50" PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100"  
            PagerStyle-AlwaysVisible="true"
            >
            <GroupingSettings CaseSensitive="false" />

            <ClientSettings AllowKeyboardNavigation="true" ReorderColumnsOnClient="True" >
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" SaveScrollPosition="true"  />              
                <ClientEvents OnRowDblClick="RowDblClick" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" />
            </ClientSettings>
            <HeaderStyle Width="100px"></HeaderStyle>
            <MasterTableView AllowMultiColumnSorting ="true" NoMasterRecordsText ="" NoDetailRecordsText="" ShowHeadersWhenNoRecords="true" AutoGenerateColumns="False"
                 CommandItemDisplay="None" EditMode="InPlace"
                 HorizontalAlign="Center" DataKeyNames="MaBA,MaBN,MaSoKham,STT">
                <CommandItemSettings ShowCancelChangesButton="true" ShowRefreshButton="false" ShowAddNewRecordButton="true" 
                     AddNewRecordText="F12 - Thêm"   />
                 <SortExpressions>
                        <telerik:GridSortExpression FieldName="OrderNumber" />
                                <telerik:GridSortExpression FieldName="MaBN" />
                                <telerik:GridSortExpression FieldName="HoTen" />
                  
                            </SortExpressions>
                <Columns>

                    <telerik:GridButtonColumn UniqueName="Edit" ItemStyle-Width="30px" HeaderStyle-Width="30px" ButtonType="ImageButton" CommandName="Edit" />

                    <telerik:GridBoundColumn DataField="OrderNumber"
                        FooterAggregateFormatString="Tổng số: {0} "
                        FilterControlAltText="Filter OrderNumber column"
                        HeaderText="STT" ReadOnly="true" SortExpression="OrderNumber"
                        UniqueName="OrderNumber" ItemStyle-Width="30px" HeaderStyle-Width="30px"
                        AllowFiltering="false"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        >
                    </telerik:GridBoundColumn>

                

                    <telerik:GridBoundColumn DataField="MaBAQL" HeaderText="Mã QL" ReadOnly="true" SortExpression="MaBAQL" UniqueName="MaBAQL"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        >
                    </telerik:GridBoundColumn>                    
                       <telerik:GridBoundColumn DataField="MaBN" HeaderText="Mã BN" ReadOnly="true" SortExpression="MaBN" UniqueName="MaBN"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        >
                    </telerik:GridBoundColumn>  
                    <telerik:GridBoundColumn ItemStyle-Width="200px" HeaderStyle-Width="200px" DataField="Hoten" HeaderText="Họ Tên" ReadOnly="true" SortExpression="Hoten" UniqueName="Hoten"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        >
                    </telerik:GridBoundColumn>     
                                   
                   
                    <telerik:GridBoundColumn DataField="Tuoi" HeaderText="Tuổi" Display ="false"  ReadOnly="true" SortExpression="Tuoi" UniqueName="Tuoi"
                        AllowFiltering="false"
                        >
                    </telerik:GridBoundColumn>                    

                      <telerik:GridBoundColumn DataField="GTD" HeaderText="Giới tính" ReadOnly="true" SortExpression="GTD" UniqueName="GTD"
                          AllowFiltering="false"
                          >
                    </telerik:GridBoundColumn>  
                     <telerik:GridBoundColumn  DataField="TenDT" HeaderText="ĐT" ReadOnly="true" 
                           SortExpression="TenDT" UniqueName="TenDT" AllowFiltering="false"
                        ItemStyle-Width="170px" HeaderStyle-Width="170px">
                    </telerik:GridBoundColumn>    
                       <telerik:GridBoundColumn ItemStyle-Width="250px" HeaderStyle-Width="250px" DataField="DiaChi" HeaderText="Địa chỉ" ReadOnly="true" SortExpression="DiaChi" UniqueName="DiaChi"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        >
                    </telerik:GridBoundColumn> 
                      <telerik:GridBoundColumn DataField="ngaySinh" HeaderText="Ngày sinh" Display ="false" ReadOnly="true" SortExpression="ngaySinh" UniqueName="ngaySinh"                          
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                          >
                    </telerik:GridBoundColumn>      

                        
                      <telerik:GridBoundColumn ItemStyle-Width="200px" HeaderStyle-Width="200px" DataField="TenKhoaVV" HeaderText="Khoa VV" ReadOnly="true" SortExpression="TenKhoaVV" UniqueName="TenKhoaVV"                           
                           CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                           >
                    </telerik:GridBoundColumn>  
                    <telerik:GridBoundColumn DataField="NGAYVV" ItemStyle-Width="150px" HeaderStyle-Width="150px" HeaderText="Ngày VV" ReadOnly="true" SortExpression="NGAYVV" UniqueName="NGAYVV"
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        >
                    </telerik:GridBoundColumn>      

                    <telerik:GridBoundColumn DataField="NgayLap" HeaderText="Ngày Lập" ReadOnly="true" SortExpression="NgayLap" UniqueName="NgayLap"
                        AllowFiltering="false"
                        >
                    </telerik:GridBoundColumn>      

                    <telerik:GridBoundColumn DataField="NguoiLap" HeaderText="Người Lập" ReadOnly="true" SortExpression="NguoiLap" UniqueName="NguoiLap"
                        AllowFiltering="false"
                        >
                    </telerik:GridBoundColumn>      

                    <telerik:GridBoundColumn DataField="NgaySD" HeaderText="Ngày SD" ReadOnly="true" SortExpression="NgaySD" UniqueName="NgaySD"
                        AllowFiltering="false"
                        >
                    </telerik:GridBoundColumn>      

                    <telerik:GridBoundColumn DataField="NguoiSD" HeaderText="Người SD" ReadOnly="true" SortExpression="NguoiSD" UniqueName="NguoiSD"
                        AllowFiltering="false"
                        >
                    </telerik:GridBoundColumn>      

                   

                </Columns>
            </MasterTableView>
        </telerik:RadGrid>


    </div>        

   
    <asp:ObjectDataSource  ID="odsTrangThai" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.TrangThaiBAListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsDoiTuong" runat="server" SelectMethod="GetListAdd" TypeName="HTC.Business.CategoryList.DMDoituongListcb" EnableViewState="true"></asp:ObjectDataSource>

</asp:Content>

