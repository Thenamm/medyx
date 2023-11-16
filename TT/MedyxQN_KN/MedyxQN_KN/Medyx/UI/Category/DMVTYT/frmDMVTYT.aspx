<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMVTYT.aspx.cs" Inherits="UI_Category_DMVTYT_frmDMVTYT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">
            function KeyPress(sender, eventArgs) {
                if (eventArgs.get_keyCode() == 127)
                    eventArgs.get_keyCode() = 0;

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
        else if (pressedKey == 119) { //f8-
            pressedKey = 0;

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
        </script>
        <style type="text/css">
            .RadForm.rfdTextbox input.rfdDecorated[type="text"], .RadForm.rfdTextbox input.rfdDecorated[type="password"], .RadForm.rfdTextbox input.rfdDecorated[type="search"], .RadForm.rfdTextbox input.rfdDecorated[type="url"], .RadForm.rfdTextbox input.rfdDecorated[type="tel"], .RadForm.rfdTextbox input.rfdDecorated[type="email"]
            {
                width: 100% !important;
            }

            .ButtonCSS
            {
                margin-left: 400px;
            }

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
            EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%">
            <Items>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                    Text="F12-Thêm " Group="Align" CheckOnClick="false" Value="cmdAdd">
                 </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="F2-Ghi " Group="Align" CheckOnClick="false" Value="cmdSave">
              
                </telerik:RadToolBarButton>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="Export " Group="Align" CheckOnClick="true" Value="cmdExport">
              
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                    Text="F10-Thoát" CheckOnClick="false" Value="cmdExit">
                </telerik:RadToolBarButton>
<%--                 <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                    Text="ký" CssClass="ButtonCSS"  Value="cmdky"  >--%>
                <%--</telerik:RadToolBarButton>--%>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                    Text="F6-Xem" CssClass="ButtonCSS" Value="cmdView">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                    Text="F7-Tìm kiếm" CheckOnClick="false" Value="cmdFilter" CommandName="cmdFilter">
                </telerik:RadToolBarButton>
            </Items>
        </telerik:RadToolBar>


    </div>
	<div align="center" style="text-align:right">
		<table width="100%"><tr><td> <asp:Label ID="Label15" runat="server" Text="Nhóm VT"></asp:Label></td>
        <td width="850px"> <telerik:RadComboBox ID="cboDsnhom" DataTextField="value"  AutoPostBack="true" TabIndex="1" Filter="Contains"
                            DataValueField="key" runat="server" OnSelectedIndexChanged="cboDsNhom_OnSelectedIndexChanged" 
                   
                    Width="100%">
                </telerik:RadComboBox></td></tr>
    </table>
	</div>
     
    <div style="margin-bottom: 5px">
        <telerik:RadGrid Culture="vi-VN" ID="grdChiTiet" runat="server" AllowAutomaticDeletes="True"
            AllowAutomaticInserts="True" AllowAutomaticUpdates="false"
            AutoGenerateColumns="false" GridLines="None"
            OnItemCommand="grdChiTiet_ItemCommand"
            OnNeedDataSource="grdChiTiet_NeedDataSource"
            Skin="Default" Width="100%" Height="240px" OnDeleteCommand="grdChiTiet_DeletedCommand"
         
             OnPageIndexChanged="grdChiTiet_PageIndexChanged"
                  OnPageSizeChanged="grdChiTiet_PageSizeChanged"
                AllowCustomPaging="True"
            ClientSettings-Scrolling-AllowScroll="true"
            ShowFooter="false" AllowSorting="true" AllowPaging="true" PageSize="100" PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100" PagerStyle-AlwaysVisible="true" MasterTableView-EditFormSettings-EditColumn-AutoPostBackOnFilter="true">
             <GroupingSettings CaseSensitive="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" 
                    EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>


            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true">
                <%--<ClientEvents OnKeyPress="funfordefautenterkey1" />  OnBatchEditCommand="grdChiTiet_BatchEditCommand" --%>
                <%--<ClientEvents OnKeyPress="OnKeyPress"  />--%>
                <%-- <ClientEvents OnBatchEditCellValueChanging="BatchEditCellValueChanging"/>
                --%>
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />

                <Scrolling AllowScroll="True" />
                <%--<ClientEvents OnRowClick="RowClickForDMForms" OnRowDblClick="RowDblClickForDMForms" OnCommand="GridCommandForDMForms" />--%>
                <ClientEvents OnRowClick="RowDblClickForDMForms" OnRowDblClick="RowDblClickForDMForms" 
                    OnCommand="GridCommandForDMForms"  OnKeyPress="KeyPress" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y"
                    EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>

         
                   <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="False" DataKeyNames="OrderNumber,MaVT"
                             HorizontalAlign="NotSet" CommandItemDisplay="Top" EditMode="InPlace" Width="100%" >
                                 <CommandItemTemplate/>

                <SortExpressions>
                    <telerik:GridSortExpression FieldName="OrderNumber" />
                    <telerik:GridSortExpression FieldName="MaVT" />
                    <telerik:GridSortExpression FieldName="TenTM" />
                </SortExpressions>
                <Columns>
                    <%-- bat dau--onclick="btnAdd_Click"--%>
                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete"
                        ConfirmDialogType="RadWindow" ConfirmText="Bạn có muốn xóa vật tư này?" ConfirmTitle="Delete"
                        HeaderStyle-Width="20px" HeaderText="Xóa" Text="Delete" 
                        UniqueName="Delete">
                        <HeaderStyle Width="50px" />
                    </telerik:GridButtonColumn>
                    <telerik:GridBoundColumn DataField="OrderNumber"
                        FilterControlAltText="Filter OrderNumber column" HeaderStyle-Width="50px" AllowFiltering ="false"  
                        HeaderText="STT" ReadOnly="true" SortExpression="OrderNumber"
                        UniqueName="OrderNumber">
                        <HeaderStyle Width="50px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn    DataField="MaVT"
                         CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter MaVT column" HeaderText="Mã VT" ReadOnly="true"
                        SortExpression="MaVT" UniqueName="MaVT">
                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn    DataField="MaQL"
                         CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" 

ShowFilterIcon="false"
                        FilterControlAltText="Filter MaQL column" HeaderText="Mã QL" ReadOnly="true"
                        SortExpression="MaQL" UniqueName="MaQL">
                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn   DataField="TenTM" 
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        FilterControlAltText="Filter TenTM column" HeaderText="Tên VT(*)"

                        SortExpression="TenTM" UniqueName="TenTM">

                        <HeaderStyle Width="350px" />
                    </telerik:GridBoundColumn>
                    
                    <telerik:GridBoundColumn   DataField="TenDVT" 
                        CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        FilterControlAltText="Filter TenDVT column" HeaderText="Tên ĐVT(*)"
                         
                        SortExpression="TenDVT" UniqueName="TenDVT">

                        <HeaderStyle Width="80px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn    DataField="MaMay" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        FilterControlAltText="Filter MaMay column" HeaderText="Mã máy" ReadOnly="true"
                        SortExpression="MaMay" UniqueName="MaMay">
                        <HeaderStyle Width="100px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="Huy" DataType="System.Boolean"
                        FilterControlAltText="Filter Huy column" HeaderText="Hủy" ReadOnly="false"
                        SortExpression="Huy" UniqueName="Huy">
                        <HeaderStyle Width="50px" />
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridBoundColumn   DataField="TenNguoiLap"
                        FilterControlAltText="Filter TenNguoiLap column" HeaderText="Người lập" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        ReadOnly="true" SortExpression="TenNguoiLap" UniqueName="TenNguoiLap">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="NgayLap" DataFormatString="{0:dd/MM/yyyy}" CurrentFilterFunction="EqualTo" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter NgayLap column" HeaderText="Ngày lập"
                        SortExpression="NgayLap" UniqueName="NgayLap">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn   DataField="TenNguoiSD"
                        FilterControlAltText="Filter TenNguoiSD column" HeaderText="Người SD" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" 
                        ReadOnly="true" SortExpression="TenNguoiSD" UniqueName="TenNguoiSD">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="NgaySD" DataFormatString="{0:dd/MM/yyyy}" CurrentFilterFunction="EqualTo" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                        FilterControlAltText="Filter NgaySD column" HeaderText="Ngày SD"
                        SortExpression="NgaySD" UniqueName="NgaySD">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn  CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false" DataField="TenNguoiHuy"
                        FilterControlAltText="Filter TenNguoiHuy column" HeaderText="Người hủy"
                        ReadOnly="true" SortExpression="TenNguoiHuy" UniqueName="TenNguoiHuy">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="NgayHuy" DataFormatString="{0:dd/MM/yyyy}"
                        FilterControlAltText="Filter NgayHuy column" HeaderText="Ngày SD"
                        SortExpression="NgayHuy" UniqueName="NgayHuy">
                        <HeaderStyle Width="180px" />
                    </telerik:GridBoundColumn>
                    <%--het cot ghi chu --%><%--cot xoa --%>
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
        <div style="border-style: groove; width: 100%">
			<div align="center" style="">
				<table style="width: 95%;text-align:right">
					<tr>

						<td width="80px">

							<asp:Label ID="Label30" runat="server" Text="Nhóm VT"></asp:Label></td>

						</td>
						<td width="250px">
							<telerik:RadComboBox ID="cboNhomVattu" DataTextField="value" Filter="Contains"
								DataValueField="key" runat="server" TabIndex="1"
								Width="100%">
							</telerik:RadComboBox>

						</td>
						<td width="70px">
							<asp:Label ID="Label2" runat="server" Text="Mã VT"></asp:Label></td>

						<td width="60px">
							<asp:TextBox ID="txtMaVT" Text="" runat="server" TabIndex="1" 
                                ReadOnly="true"
								Width="60px"></asp:TextBox></td>
						<td width="80px">
							<asp:CheckBox ID="chkHuy" TabIndex="1" runat="server" Text="Hủy" /></td>
							<td >
							<asp:Label ID="Label11" runat="server" Text="Mã QL"></asp:Label></td>

						<td colspan="2">
							<asp:TextBox ID="txtMaQL" Text="" runat="server" TabIndex="1"
								style = "width:100% !important"></asp:TextBox></td>
					</tr>              
					<tr>
						<td>
							<asp:Label ID="Label6" runat="server" Text="Tên VT"></asp:Label></td>

						<td colspan="7">
							<asp:TextBox ID="txtTenVT" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>
                    
					</tr>
					<tr>
						<td>
							<asp:Label ID="Label8" runat="server" Text="Tên tiếng anh"></asp:Label></td>
						<td colspan="1.5">
							<asp:TextBox ID="txtTenTA" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>
						<td width="80px">
							<asp:Label ID="Label9" runat="server" Text="ĐVT"></asp:Label></td>
						<td width="110px" style="padding-right:2px">

							<asp:DropDownList ID="cboDonVi" DataTextField="value" TabIndex="1"
								DataValueField="key" runat="server"
								Width="100%">
							</asp:DropDownList></td>
						<td width="80px">
							<asp:Label ID="Label10" runat="server" Text="Quy đổi"></asp:Label>

						</td>

						<td>
							<asp:TextBox ID="txtQuydoi" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>
						<td width="80px">
							<asp:Label ID="Label12" runat="server" Text="ĐVT 2"></asp:Label></td>

						<td style="padding-right:2px">

							<asp:DropDownList ID="cboDonVi2" DataTextField="value" TabIndex="1"
								DataValueField="key" runat="server"
								Width="100%">
							</asp:DropDownList></td>
					</tr>



                                            <tr>

                           <td >
						<asp:Label  ID="Label40" runat="server" Text="Nước sản xuất "></asp:Label></td>
						  <td colspan = "1">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboQuocGia" 
                                  DataTextField="TenQG" 
							DataValueField="MaQG" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>


                                                         <%--<td>
							<asp:Label ID="Label21" runat="server" Text="Mã Hiệu SP"></asp:Label>

						</td>

						<td colspan="1">
							<asp:TextBox ID="txtMaHieuSP" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>--%>

                            <td>
							<asp:Label ID="Label14" runat="server" Text="Định Mức SD"></asp:Label>

						</td>

						<td colspan="1">
							<asp:TextBox ID="txtDinhMuc" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>

                             <td>
							<asp:Label ID="Label18" runat="server" Text="Tỉ lệ TTBH"></asp:Label>

						</td>

						<td colspan="1">
							<asp:TextBox ID="txtbh50" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>



                        </tr>


					<tr>
						 <td>
							<asp:Label ID="Label19" runat="server" Text="Nhà sản xuất"></asp:Label></td>
						<td colspan="3" style="padding-right:2px">
							<telerik:RadComboBox  Filter ="Contains"  ID="cboNSX" DataTextField="value" TabIndex="1"
								DataValueField="key" runat="server" Width="100%">
							</telerik:RadComboBox></td>
						 <td>
							<asp:Label ID="Label3" runat="server" Text="Loại VT"></asp:Label>
						 </td>

						<td colspan="3" style="padding-right:2px">
							<telerik:RadDropDownList ID="cboChungLoai" DataTextField="value" TabIndex="1"
								DataValueField="key" runat="server"
								Width="100%" AutoPostBack="true"
								OnSelectedIndexChanged="cboChungLoai_OnSelectedIndexChanged" >
							</telerik:RadDropDownList>
						</td>
					</tr>

                    <tr>
                         <td >
						<asp:Label  ID="Label20" runat="server" Text="Nguồn kinh phí "></asp:Label></td>
						  <td colspan = "3">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboDMNguon" DataTextField="TenNguon" 
							DataValueField="MaNguon" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>
                    </tr>


					<tr>
						<td>
							<asp:Label ID="Label7" runat="server" Text="Ngưỡng VT"></asp:Label>

						</td>

						<td colspan="3">
							<asp:TextBox ID="TxtNguong" Text="" runat="server" TabIndex="1"
								Width="100%"></asp:TextBox></td>
                    
						<td >
							<asp:Label ID="Label1" runat="server" Text="Loại hình VT"></asp:Label></td>
						<td colspan="3" style="padding-right:2px">
                        
							<asp:DropDownList ID="cboLoaihinh" DataTextField="value"
								DataValueField="key" runat="server" TabIndex="1"
								Width="100%">
							</asp:DropDownList>

						</td>
                  
					</tr>
                
					<tr>
						  <td>
								<asp:Label ID="Label25" runat="server" Text="Quy cách"></asp:Label></td>
							<td colspan="3">
								<asp:TextBox ID="txtQuyCach" Text="" runat="server" TabIndex="1"
									 Width="100%"></asp:TextBox></td>
                    
						  <td  >
					<asp:Label  ID="Label16" runat="server" Text="Giá nhập"></asp:Label></td>
            
				<td >
					<asp:TextBox  ID="txtGiaNhap" text ="" runat="server"   TabIndex="1"
						Width="100%"  ></asp:TextBox></td>
						<td  >
					<asp:Label  ID="Label17" runat="server" Text="Giá TT"></asp:Label></td>
            
				<td >
					<asp:TextBox  ID="txtDonGiaTT" text ="" runat="server"  Enabled ="false" TabIndex="1"
						style = "width:100% !important"></asp:TextBox></td>
                  
					</tr>
					<tr>
						<td>
							<asp:Label ID="Label24" runat="server" Text="Ghi chú"></asp:Label></td>

						<td colspan="7">
							<asp:TextBox ID="txtGhiChu"  TabIndex="1" Text="" runat="server"
								Width="100%"></asp:TextBox></td>
                 

					</tr>
                       <tr> 
                       <td>
                        <asp:Label ID="Label33" runat="server" Text="Tên BH" ForeColor="#FF3300"> </asp:Label></td>
                   <td colspan="3">
                        <asp:TextBox ID="txtTenBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label31" runat="server" Text="Quyết định" ForeColor="#FF3300"></asp:Label></td>

                    <td >
                        <asp:TextBox ID="txtQuyetDinhBH" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label32" runat="server" Text="Mã BH" ForeColor="#FF3300"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                 
             </tr>    
                <tr> 
                       <td>
                        <asp:Label ID="Label4" runat="server" Text="Tên BY tế" ForeColor="#FF3300"></asp:Label></td>
                   <td colspan="3">
                        <asp:TextBox ID="txtTenBYte" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Quyết định" ForeColor="#FF3300"></asp:Label></td>

                    <td >
                        <asp:TextBox ID="txtQuyetDinh" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text="Mã BY Tế" ForeColor="#FF3300"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaBYTe" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                 
             </tr>  
				</table>
			</div>
			<div align="center" style="text-align:right">
				<table style="width: 100%; height: auto;">
					<tr>
						<td width="200px">
							<asp:CheckBox ID="chkVTYTDuoc" runat="server" Text="VTYT Dược"  TabIndex="1"/></td>
						<td width="200px">
							<asp:CheckBox ID="chkVTYTPhauthuat" runat="server" Text="VTYT Phẫu thuật"  TabIndex="1"/></td>
						 <td  width="120px">
							<asp:CheckBox ID="chkApdunggoi" runat="server" Text="Áp dụng gói"  TabIndex="1"/></td>
						<td width="120px">
							<asp:CheckBox ID="chkDuyetNoiT" runat="server" Text="Duyệt nội trú"  TabIndex="1"/></td>
						<td width="200px">
							<asp:CheckBox ID="chkVTYTCoHD" runat="server" Text="VTYT Có hạn dùng"  TabIndex="1"/></td>  
                         <td>
                        <asp:Label ID="Label37" runat="server" Text="Mã T.Đương "></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaTDuong" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>                   
					</tr>
					<tr>
						<td width="200px">
							<asp:CheckBox ID="chkVTYTBan" runat="server" Text="VTYT Bán" TabIndex="1" /></td>
						<td width="200px">
							<asp:CheckBox ID="chkVTYTThuthuat" runat="server" Text="VTYT Thủ thuật"  TabIndex="1"/></td>
						 <td>
							<asp:CheckBox ID="chkCLS" runat="server" Text="Thuốc CLS"  TabIndex="1"/></td>
						<td width="120px">
							<asp:CheckBox ID="chkDuyetNgoaiT" runat="server" Text="Duyệt ngoại trú"  TabIndex="1"/></td>
                    
						<td width="200px">
							<asp:CheckBox ID="chkKhongSD" runat="server" Text="Không SD"  TabIndex="1"/></td>
					</tr>

				</table>
			</div>
        </div>
    </fieldset>
</asp:Content>
