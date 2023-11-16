<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmDMThuoc.aspx.cs" Inherits="UI_Category_DMDuoc_frmDMThuoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        
<script type="text/javascript">
    function KeyPress(sender, eventArgs) {
        if (eventArgs.get_keyCode() == 127)
            eventArgs.get_keyCode() = 0;

    }
    function funUpload() {
        var toolbar1 = $find("<%= baraction.ClientID %>");
        var templateButton = toolbar1.findItemByValue("cmdUploadData");
        templateButton.click();
    };
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
               var templateButton = toolbar1.findItemByValue("cmdFiter");
               templateButton.click();
           }

           else if (pressedKey == 121) { //f10-thoat
               var toolbar1 = $find("<%= baraction.ClientID %>");
                   var templateButton = toolbar1.findItemByValue("cmdExit");
                   templateButton.click();

               }

}
    var hasChanges, inputs, dropdowns, editedRow;



    function comboSelectedIndexChangedBaoChe(sender, eventArgs) {
        var item = eventArgs.get_item();

        // get the text and value elements
        var val = item.get_text();

        // benh
        var MaDangBC = item.get_attributes().getAttribute("MaDangBC");
        var obbaoche = document.getElementById("<%= txtDangBC.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  

        //var TenDangBC = val;
      

        //if (obbaoche.value == "" && MaDangBC.length > 1)
        //    obbaoche.value = MaDangBC;
        //else if (obbaoche.value == "")
        //    obbaoche.value = MaDangBC + "-" + TenDangBC;
        //else if (MaDangBC.length > 1)
        //    obbaoche.value = obbaoche.value + ";   " + MaDangBC;

        //        else
           // obbaoche.value = obbaoche.value + " " + MaDangBC + "-" + TenDangBC;
        obbaoche.value = obbaoche.value + MaDangBC + ";";
                /*var input = combo.get_inputDomElement();*/
            }


    function comboSelectedIndexChangedPPCB(sender, eventArgs) {


        var item = eventArgs.get_item();


        var val = item.get_text();

        var MaPPCB = item.get_attributes().getAttribute("MaPPCB");
        var obchebien = document.getElementById("<%= txtDangCB.ClientID %>"); //item.set_text(item.get_text().substr(0, 7));  

        //var TenPPCB = val;


        //if (obchebien.value == "" && MaPPCB.length > 2)
        //    obchebien.value = MaPPCB;
        //else if (obchebien.value == "")
        //    obchebien.value = MaPPCB + "-" + TenPPCB;
        //else if (MaPPCB.length > 2)
        //    obchebien.value = obchebien.value + "; " + MaPPCB;

        //else
        obchebien.value = obchebien.value + MaPPCB + ";";

        /* var input = combo.get_inputDomElement();*/

    }












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
           
             .RadForm.rfdTextbox input.rfdDecorated[type="text"], .RadForm.rfdTextbox input.rfdDecorated[type="password"], .RadForm.rfdTextbox input.rfdDecorated[type="search"], .RadForm.rfdTextbox input.rfdDecorated[type="url"], .RadForm.rfdTextbox input.rfdDecorated[type="tel"], .RadForm.rfdTextbox input.rfdDecorated[type="email"]
             {
                 width:100% !important;
             }
             .ButtonCSS
       {
           margin-left:100px;
       }
      
        </style>
</telerik:RadCodeBlock>
<div >
       	  <!--  <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="Sửa phiếu" CheckOnClick="false" Value ="cmdEdit">
            </telerik:RadToolBarButton>
              <telerik:RadToolBarButton ImageUrl="~/img/icon/Delete.png"
                Text="F8-Xóa phiếu" CheckOnClick="false" Value ="cmdDelete" >
            </telerik:RadToolBarButton> -->
        <telerik:RadToolBar ID="baraction" runat="server"
            EnableRoundedCorners="true"
            EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%" OnClientButtonClicked="processClick" >
            <Items>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif"
                    Text="F12-Thêm " Group="Align" CheckOnClick="true" Value="cmdAdd">
                 </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="F2-Ghi " Group="Align" CheckOnClick="true" Value="cmdSave">
              
                </telerik:RadToolBarButton>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="Export " Group="Align" CheckOnClick="true" Value="cmdExport">
              
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                    Text="F10-Thoát" CheckOnClick="true" Value="cmdExit">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                    Text="F6-Xem" CssClass="ButtonCSS" Value="cmdView">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="~/img/icon/filter.gif"
                    Text="F7-Tìm kiếm" CheckOnClick="true" Value="cmdFilter" CommandName="cmdFilter">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton Value="cmdUploadData">
                    <ItemTemplate>
                        <asp:FileUpload runat="server" ID="FileUpload1" Width="80px" onchange="funUpload()"/>
                    </ItemTemplate>
                </telerik:RadToolBarButton>
            </Items>
        </telerik:RadToolBar>
        </div>
    <table width="100%"><tr>
        <td> <asp:Label ID="Label1" runat="server" Text="Nhóm thuốc"></asp:Label></td>
        <td width="850px"> <telerik:RadComboBox CssClass="span-all" ID="cboDsnhom" DataTextField="value"  AutoPostBack="true"
                            DataValueField="key" runat="server" OnSelectedIndexChanged="cboDsNhom_OnSelectedIndexChanged"
                   Filter ="Contains"
                    Width="100%">
                </telerik:RadComboBox></td></tr>
    </table>
   
          <div style="margin-bottom:10px">
            
              <telerik:RadGrid ClientSettings-Resizing-AllowColumnResize="true"  
                      
                  ID="grdChiTiet" runat="server" AllowAutomaticDeletes="True" 
                  AllowAutomaticInserts="True" AllowAutomaticUpdates="true" 
                  AutoGenerateColumns="false" GridLines="None" 
                   onitemcommand="grdChiTiet_ItemCommand" 
                  onneeddatasource="grdChiTiet_NeedDataSource" 
                 OnPageIndexChanged="grdChiTiet_PageIndexChanged"
                  OnPageSizeChanged="grdChiTiet_PageSizeChanged"
                AllowCustomPaging="True"
                GroupingSettings-CaseSensitive ="false"
                  Skin="Default" Width="100%" Height="210px"
                  ondeletecommand="grdChiTiet_DeletedCommand" 
                  oninsertcommand="grdChiTiet_InsertCommand" 
                  onupdatecommand="grdChiTiet_UpdateCommand"
                  ClientSettings-Scrolling-AllowScroll="true"
                  ShowFooter="false" AllowSorting="true" AllowPaging="true" PageSize="100" 
                  PagerStyle-Visible="true" MasterTableView-PagerStyle-PageSizes="20, 50, 70, 100"
                    PagerStyle-AlwaysVisible="true"
                  MasterTableView-EditFormSettings-EditColumn-AutoPostBackOnFilter="true"
                  >
             <GroupingSettings CaseSensitive="false" ShowUnGroupButton="false" />
            <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True" AllowKeyboardNavigation="true"    KeyboardNavigationSettings-AllowActiveRowCycle="true">
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />
                <Scrolling AllowScroll="True" UseStaticHeaders="true" />
                <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y" EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
            </ClientSettings>


                  <ClientSettings AllowColumnsReorder="True" ReorderColumnsOnClient="True"  AllowKeyboardNavigation="true"    KeyboardNavigationSettings-AllowActiveRowCycle="true">
                      <%--<ClientEvents OnKeyPress="funfordefautenterkey1" />  OnBatchEditCommand="grdChiTiet_BatchEditCommand" --%>
                      <%--<ClientEvents OnKeyPress="OnKeyPress"  />--%>
                      <%-- <ClientEvents OnBatchEditCellValueChanging="BatchEditCellValueChanging"/>
            --%>
                <Selecting AllowRowSelect="true" EnableDragToSelectRows="true" />

                <Scrolling AllowScroll="True" />
                <%--<ClientEvents OnRowClick="RowClickForDMForms" OnRowDblClick="RowDblClickForDMForms" OnCommand="GridCommandForDMForms" />--%>
                <ClientEvents OnRowClick="RowDblClickForDMForms" OnRowDblClick="RowDblClickForDMForms" 
                    OnCommand="GridCommandForDMForms" OnKeyPress="KeyPress" />
                    <KeyboardNavigationSettings AllowActiveRowCycle="true" AllowSubmitOnEnter="true" FocusKey="Y"
                    EnableKeyboardShortcuts="true" ValidationGroup="CustomValidatioGroup" />
                 </ClientSettings>

         
                   <MasterTableView NoMasterRecordsText ="" NoDetailRecordsText="" AutoGenerateColumns="False" DataKeyNames="OrderNumber,MaThuoc"
                             HorizontalAlign="NotSet" CommandItemDisplay="Top" EditMode="InPlace" Width="100%" >
                                 <CommandItemTemplate/>

                <SortExpressions>
                     <telerik:GridSortExpression FieldName="MaThuoc" />
                           <telerik:GridSortExpression FieldName="TenTM" />
                          <telerik:GridSortExpression FieldName="OrderNumber" />
                          
                      </SortExpressions>
                      <columns>
                          <%-- bat dau--onclick="btnAdd_Click"--%>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                              ConfirmDialogType="RadWindow" ConfirmText="Bạn có đồng ý Xóa thuốc này không?" ConfirmTitle="Delete" 
                              HeaderStyle-Width="20px" HeaderText="Xóa" Text="Delete" 
                              UniqueName="Delete"  >
                              <HeaderStyle Width="50px" />
                          </telerik:GridButtonColumn>
                          <telerik:GridBoundColumn DataField="OrderNumber" 
                              FilterControlAltText="Filter OrderNumber column" HeaderStyle-Width="50px" 
                              HeaderText="STT" readonly="true" SortExpression="OrderNumber"  AllowFiltering="false" 
                              UniqueName="OrderNumber">
                              <HeaderStyle Width="50px" />
                          </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="MaThuoc" 
                              FilterControlAltText="Filter MaThuoc column" HeaderText="Mã thuốc" readonly="true" 
                              CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="MaThuoc" UniqueName="MaThuoc">
                              <HeaderStyle Width="80px" />
                          </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="MaQL" 
                              FilterControlAltText="Filter MaQL column" HeaderText="Mã QL" readonly="true" 
                              CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="MaQL" UniqueName="MaQL">
                              <HeaderStyle Width="80px" />
                          </telerik:GridBoundColumn>
                           <telerik:GridBoundColumn DataField="TenGoc" 
                              FilterControlAltText="Filter TenGoc column" HeaderText="Tên gốc" 
                              SortExpression="TenGoc" UniqueName="TenGoc"
                                CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                             
                                >
                             
                              <HeaderStyle Width="250px" />
                          </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="TenTM" 
                              FilterControlAltText="Filter TenTM column" HeaderText="Tên TM" 
                               CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="TenTM" UniqueName="TenTM">
                             
                              <HeaderStyle Width="250px" />
                          </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="HamLuong" 
                              FilterControlAltText="Filter HamLuong column" HeaderText="Hàm lượng" 
                                 CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="HamLuong" UniqueName="HamLuong">
                             
                              <HeaderStyle Width="80px" />
                          </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="TenDVT" 
                              FilterControlAltText="Filter TenDVT column" HeaderText="Tên ĐVT" 
                                 CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="TenDVT" UniqueName="TenDVT">
                             
                              <HeaderStyle Width="80px" />
                          </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="SoVisa" 
                              FilterControlAltText="Filter SoVisa column" HeaderText="Sovisa" 
                                 CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="SoVisa" UniqueName="SoVisa">
                             
                              <HeaderStyle Width="80px" />
                          </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="TenNSX" 
                              FilterControlAltText="Filter TenNSX column" HeaderText="TenNSX" 
                                 CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" ShowFilterIcon="false"
                              SortExpression="TenNSX" UniqueName="TenNSX">
                             
                              <HeaderStyle Width="180px" />
                          </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="MaMay" 
                              FilterControlAltText="Filter MaMay column" HeaderText="Mã máy" readonly="true"  AllowFiltering="false" 
                              SortExpression="MaMay" UniqueName="MaMay">
                              <HeaderStyle Width="100px" />
                          </telerik:GridBoundColumn>
                          <telerik:GridCheckBoxColumn DataField="Huy" DataType="System.Boolean" 
                              FilterControlAltText="Filter Huy column" HeaderText="Hủy" readonly="false"  AllowFiltering="false" 
                              SortExpression="Huy" UniqueName="Huy">
                              <HeaderStyle Width="50px" />
                         </telerik:GridCheckBoxColumn>
                          <telerik:GridBoundColumn DataField="TenNguoiLap" 
                              FilterControlAltText="Filter TenNguoiLap column" HeaderText="Người lập"  AllowFiltering="false" 
                              readonly="true" SortExpression="TenNguoiLap" UniqueName="TenNguoiLap">
                              <HeaderStyle Width="180px" />
                          </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NgayLap" DataFormatString="{0:dd/MM/yyyy}"
                         FilterControlAltText="Filter NgayLap column" HeaderText="Ngày lập"  AllowFiltering="false" 
                         SortExpression="NgayLap" UniqueName="NgayLap">
                          <HeaderStyle  Width="180px" />
                     </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="TenNguoiSD" 
                              FilterControlAltText="Filter TenNguoiSD column" HeaderText="Người SD"  AllowFiltering="false" 
                              readonly="true" SortExpression="TenNguoiSD" UniqueName="TenNguoiSD">
                              <HeaderStyle Width="180px" />
                          </telerik:GridBoundColumn>
                             <telerik:GridBoundColumn DataField="NgaySD" DataFormatString="{0:dd/MM/yyyy}"
                         FilterControlAltText="Filter NgaySD column" HeaderText="Ngày SD" 
                         SortExpression="NgaySD" UniqueName="NgaySD">
                          <HeaderStyle  Width="180px" />
                     </telerik:GridBoundColumn>
                          <telerik:GridBoundColumn DataField="TenNguoiHuy" 
                              FilterControlAltText="Filter TenNguoiHuy column" HeaderText="Người hủy"  AllowFiltering="false" 
                              readonly="true" SortExpression="TenNguoiHuy" UniqueName="TenNguoiHuy">
                              <HeaderStyle Width="180px" />
                          </telerik:GridBoundColumn>
                             <telerik:GridBoundColumn DataField="NgayHuy" DataFormatString="{0:dd/MM/yyyy}" AllowFiltering="false" 
                         FilterControlAltText="Filter NgayHuy column" HeaderText="Ngày SD" 
                         SortExpression="NgayHuy" UniqueName="NgayHuy">
                          <HeaderStyle  Width="180px" />
                     </telerik:GridBoundColumn>
                          <%--het cot ghi chu --%><%--cot xoa --%>
                        
                        
                      </columns>
                  </MasterTableView>
              </telerik:RadGrid>
        </div>
        <div style="width : 100%; text-align:right">
			<table style="width: 100%; height: auto;">
				<tr>
					<td width ="85px">Nhóm thuốc(*)</td>
           
						 <td width="150px">
						<telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboNhomThuoc" DataTextField="value" 
							DataValueField="key" runat="server"
							Width="100%">
						</telerik:RadComboBox>

					</td>
					<td width ="70px">
						<asp:Label  ID="Label2" runat="server" Text="Mã thuốc"></asp:Label></td>
            
					<td width ="60px">
						<asp:TextBox  ID="txtMaThuoc" TabIndex="1" runat="server" 
							Width="60px"  ></asp:TextBox></td>
						   <td width ="80px">
											  <asp:CheckBox TabIndex="1"   ID="chkHuy" runat="server" Text="Hủy" /></td>
												 <td width ="85px">
											  <asp:CheckBox TabIndex="1"   ID="chkThuocGoc" runat="server" Text="Thuốc gốc" /></td>
							   <td width = "60px" >
						<asp:Label  ID="Label11" runat="server" Text="Mã QL"></asp:Label></td>
            
					 <td width = "60px">
						<asp:TextBox  ID="txtMaQL" text ="" runat="server"  TabIndex="1"
							Width="100%"  ></asp:TextBox></td>   <td width ="60px">
						<asp:Label  ID="Label3" runat="server" Text="Mã gốc"></asp:Label></td>
            
					<td width ="60px">
                       <telerik:RadComboBox                  ID="cboMaGoc" runat="server" AppendDataBoundItems="true"
                                AutoPostBack="false" DataSourceID="ObjectDanhMuc"
                                DataTextField="TenTMHL" DataValueField="MaThuoc" DropDownWidth="690px" CssClass="span-all"
                                ItemsPerRequest="20"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                MarkFirstMatch="true"
                                EnableLoadOnDemand="true"
                                EnableAutomaticLoadOnDemand="true"
                                EnableVirtualScrolling ="false" 
                                ExpandDirection="Up" Filter="StartsWith"
                                HighlightTemplatedItems="true"
                               Width ="100%"
                               >
                                <HeaderTemplate>
                                    <table class="NHTC_table_layout" width ="100%">
                                        <tr>
											<td width="50px">Mã thuốc</td>
                                            <td width="250px">Tên thuốc</td>
                                            <td width="70px">ĐVT</td>
                                            <td width="150px">Nhà sản xuất</td>
                                        </tr>
                                    </table>
                                </HeaderTemplate>
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                </Items>
                                <ItemTemplate><table class="NHTC_table_layout" width ="100%"><tr>
											 <td width="50px">
                                                <%# DataBinder.Eval(Container.DataItem, "MaThuoc") %>
                                            </td>
                                            <td width="250px">
                                                <%# DataBinder.Eval(Container.DataItem, "TenTMHL") %>
                                            </td>
                                            <td width="70px">
                                                <%# DataBinder.Eval(Container.DataItem, "TenDVT") %>
                                            </td>
                                            <td width="150px">
                                                <%# DataBinder.Eval(Container.DataItem, "TenNSX") %>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate></telerik:RadComboBox>

					</td>
				</tr>
				<tr>
					  <td  >
						<asp:Label  ID="Label4" runat="server" Text="Tên gốc"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtTenGoc" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td >
						<asp:Label  ID="Label5" runat="server" Text="Phân loại(*)" style="padding-right:0px"></asp:Label></td>
            
					 <td colspan ="3"><asp:DropDownList CssClass="span-all"  ID="cboPhanLoai" DataTextField="value" 
												   DataValueField="key" runat="server" TabIndex="1"
												Width="100%" > 
										   </asp:DropDownList>
					 </td>   
					<td >
						<asp:Label  ID="Label13" runat="server" Text="Ngày dùng"></asp:Label></td>
											 <td >
						<asp:TextBox  ID="txtNgayDung" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>  
				</tr>
				 <tr>
					  <td  >
						<asp:Label  ID="Label6" runat="server" Text="Tên TM(*)"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtTenTM" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td >
						<asp:Label  ID="Label7" runat="server" Text="NĐ,HL"></asp:Label></td>
					 <td colspan ="2">
						<asp:TextBox  ID="txtHamLuong" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					 <td style="padding-right:0px">
                                      
											   <asp:DropDownList CssClass="span-all"  ID="cboDonViHL" DataTextField="value" 
												   DataValueField="key" runat="server" TabIndex="1"
												Width="100%" > 
										   </asp:DropDownList></td>   
                      <td  >
						<asp:Label  ID="Label36" runat="server" Text="SL.Kê max"></asp:Label></td>
					<td >
						<asp:TextBox  ID="txtNguongNhap" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
				</tr>
				   <tr>
					  <td  >
						<asp:Label  ID="Label8" runat="server" Text="Tên TM1"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtTenTM1" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td >
						<asp:Label  ID="Label9" runat="server" Text="ĐVT(*)" ></asp:Label></td>
						  <td style="padding-right:0px"> 
                                      
											   <asp:DropDownList CssClass="span-all"  ID="cboDonVi" DataTextField="value" 
												   DataValueField="key" runat="server" TabIndex="1"
												Width="100%" > 
										   </asp:DropDownList></td> 
											   <td  >
						<asp:Label  ID="Label10" runat="server" Text="Quy đổi"></asp:Label></td>
            
					 <td >
						<asp:TextBox  ID="txtQuydoi" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
						   <td  >
						<asp:Label  ID="Label12" runat="server" Text="ĐVT(*)"></asp:Label></td>
            
					 <td style="padding-right:0px"> 
                                      
											   <asp:DropDownList CssClass="span-all"  ID="cboDonVi2" DataTextField="value" 
												   DataValueField="key" runat="server" TabIndex="1"
												Width="100%" > 
										   </asp:DropDownList></td>   
				</tr>
					 <tr>
					  <td  >
						<asp:Label  ID="Label14" runat="server" Text="Tên TM2"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtTenTM2" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td  >
						<asp:Label  ID="Label26" runat="server" Text="Ngưỡng tồn"></asp:Label></td>
					<td >
						<asp:TextBox  ID="txtNguong" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td >
						<asp:Label  ID="Label19" runat="server" Text="Loại thuốc(*)"></asp:Label></td>
						  <td colspan = "3" style="padding-right:0px"> 
                                      
											   <asp:DropDownList CssClass="span-all"  ID="cboChungLoai" DataTextField="value"
									DataValueField="key" runat="server" TabIndex="1"
									Width="100%" AutoPostBack="true"
									OnSelectedIndexChanged="cboChungLoai_OnSelectedIndexChanged" >
								</asp:DropDownList></td>
				</tr>
				 <tr>
					  <td  >
						<asp:Label  ID="Label18" runat="server" Text="Tên TA"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtTenTA" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
					  <td><asp:Label ID="Label15" runat="server" Text="Thuộc nhóm"></asp:Label></td>
							<td colspan="5" style="padding-right:0px">

								<asp:DropDownList CssClass="span-all"  ID="cboLoaihinh" DataTextField="value"
									DataValueField="key" runat="server" TabIndex="1"
									Width="100%">
								</asp:DropDownList></td>
               
             
                                 
				</tr>
					<tr>
					  <td  >
						<asp:Label  ID="Label20" runat="server" Text="NSX"></asp:Label></td>
					 <td colspan = "3" style="padding-right:0px"> 
                                      
					<telerik:RadComboBox  Filter ="Contains"  CssClass="span-all"  ID="cboNSX" DataTextField="value" 
						DataValueField="key" runat="server" TabIndex="1"
					style="width:100% !important" > 
				</telerik:RadComboBox></td> 
         
					  <td >
						<asp:Label  ID="Label21" runat="server" Text="Loại T phẩm"></asp:Label></td>
						  <td colspan = "5" style="padding-right:0px"> 
                                      
											   <asp:DropDownList CssClass="span-all"  ID="cboLoaiTP" DataTextField="value" 
												   DataValueField="key" runat="server" TabIndex="1"
												Width="100%" > 
										   </asp:DropDownList></td>
                                 
				</tr>
					   <tr>


                           <td >
						<asp:Label  ID="Label40" runat="server" Text="Nước sản xuất "></asp:Label></td>
						  <td colspan = "3">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboQuocGia" DataTextField="TenQG" 
							DataValueField="MaQG" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>



					  <td  >
						<asp:Label  ID="Label22" runat="server" Text="Số Visa" ForeColor="#FF3300"></asp:Label></td>
            
					<td colspan = "1">
						<asp:TextBox  ID="txtSoViSa" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>

					  <td >
						<asp:Label  ID="Label23" runat="server" Text="Đ.dùng,DB"></asp:Label></td>
						  <td colspan = "2">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cboDuongDung" DataTextField="value" 
							DataValueField="key" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>
                                 
				</tr>




                <tr>
                    <td >
						<asp:Label  ID="Label37" runat="server" Text="Dạng bào chế: "></asp:Label></td>
						  <td colspan = "3">					
                              <telerik:RadComboBox   
                                  
                                   OnClientSelectedIndexChanged="comboSelectedIndexChangedBaoChe"
                                  OnClientKeyPressing="HandlekeyPressEnter" OnItemDataBound="cboDangBC_ItemDataBound"           
                                 TabIndex="1" ID="cboDangBC" DataValueField="MaDangBC" DataTextField="TenDangBC" runat="server"  
							                     
							Width="100%">
                                  <HeaderTemplate>
                                                        <table class="NHTC_table_layout">
                                                            <tr>
                                                                    <td width="70px">Mã dạng bào chế</td>
                                                                    <td width="400px">Tên dạng bào chế</td>
                                                            </tr>
                                                        </table>
                                                    </HeaderTemplate>
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                                    </Items>
                                                   <%-- <ItemTemplate>
                                                        <table>
                                                            <tr>
                                                                <td width="70px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "MaDangBC")%>
                                                                </td>
                                                                <td width="400px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "TenDangBC") %>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>--%>
						</telerik:RadComboBox>
						  </td>
                    <td colspan="6">
        <asp:TextBox runat="server" ID="txtDangBC" CssClass="span-all"></asp:TextBox>
    </td>
                    </tr>
                <tr>
                    <td >
						<asp:Label  ID="Label38" runat="server" Text="Phương pháp chế biến: "></asp:Label></td>
						  <td colspan = "3">
						
                              <telerik:RadComboBox   

                                  OnClientSelectedIndexChanged="comboSelectedIndexChangedPPCB"
                                  OnClientKeyPressing="HandlekeyPressEnter"   OnItemDataBound="cboDangCB_ItemDataBound"        
                                 TabIndex="1" ID="cboDangCB" DataTextField="TenPPCB" 
							DataValueField="MaPPCB" runat="server"
							Width="100%">


                                  <HeaderTemplate>
                                                        <table class="NHTC_table_layout">
                                                            <tr>
                                                                    <td width="70px">Mã pp Chế Biến</td>
                                                                    <td width="400px">Tên pp Chế Biến</td>
                                                            </tr>
                                                        </table>
                                                    </HeaderTemplate>
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                                    </Items>
  <%--                                                  <ItemTemplate>
                                                        <table>
                                                            <tr>
                                                                <td width="70px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "MaPPCB")%>
                                                                </td>
                                                                <td width="400px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "TenPPCB") %>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>--%>



						</telerik:RadComboBox>
						  </td>
                        <td colspan="6">
        <asp:TextBox runat="server" ID="txtDangCB" CssClass="span-all"></asp:TextBox>
    </td>
                        </tr>

                <tr>

                    					  <td  >
						<asp:Label  ID="Label39" runat="server" Text="Mã DVKT"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtMaDVKT" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>


                    						   <td >
						<asp:Label  ID="Label25" runat="server" Text="Quy cách"></asp:Label></td>
						  <td >
						<asp:TextBox  ID="txtQuyCach" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>

                </tr>


















					 <tr>
					  <td  >
						<asp:Label  ID="Label24" runat="server" Text="Ghi chú"></asp:Label></td>
            
					<td colspan = "3">
						<asp:TextBox  ID="txtGhiChu" text ="" runat="server" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
						<td  >
						<asp:Label  ID="Label16" runat="server" Text="Giá nhập"></asp:Label></td>
            
					<td >
						<asp:TextBox  ID="txtGiaNhap" text ="" runat="server"  Enabled ="false" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
							<td  >
						<asp:Label  ID="Label17" runat="server" Text="Giá TT"></asp:Label></td>
            
					<td >
						<asp:TextBox  ID="txtDonGiaTT" text ="" runat="server"  Enabled ="false" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>
							<td  >
						<asp:Label  ID="Label27" runat="server" Text="Giá NT "></asp:Label></td>
            
					<td >
						<asp:TextBox  ID="txtGiaNT" text ="" runat="server"  Enabled ="false" TabIndex="1"
							Width="100%"  ></asp:TextBox></td>                
				</tr>

                    <tr> 
                       <td>
                        <asp:Label ID="Label33" runat="server" Text="Tên BH" ForeColor="#FF3300"></asp:Label></td>
                   <td colspan="3">
                        <asp:TextBox ID="txtTenBH" Text="" runat="server" TabIndex="1" 
                          style = "width:100% !important" ></asp:TextBox></td>
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
                  <td>
                        <asp:Label ID="Label34" runat="server" Text="Mã T.Đương" ForeColor="#FF3300"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaTDuong" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
             </tr>    
                <tr> 
                       <td>
                        <asp:Label ID="Label28" runat="server" Text="Tên BY tế" ForeColor="#FF3300" ></asp:Label></td>
                   <td colspan="3">
                        <asp:TextBox ID="txtTenBYte" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label29" runat="server" Text="QĐ-TT Thầu" ForeColor="#FF3300"></asp:Label></td>

                    <td >
                        <asp:TextBox ID="txtQuyetDinh" Text="" runat="server" TabIndex="1"
                           style = "width:100% !important"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label30" runat="server" Text="Mã BY Tế" ForeColor="#FF3300"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtMaBYTe" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                 
             </tr>  
			</table>
		</div>
		<div class="contentWrapper" style="width : 100%">
			<table style="width: 100%; height: auto;">
			<tr>
			   <td width ="120px" colspan ="2">
											  <asp:CheckBox TabIndex="1"   ID="chkDuyetNoiT" runat="server" Text="Duyệt nội trú" /></td>
													<td width ="120px">
											  <asp:CheckBox TabIndex="1"   ID="chkDuyetNgoaiT" runat="server" Text="Duyệt ngoại trú" /></td>
			   <td width ="120px">
											  <asp:CheckBox TabIndex="1"   ID="chkThuoc43" runat="server" Text="Thuốc bán" /></td>
		   <td width ="120px">
											  <asp:CheckBox TabIndex="1"   ID="chkThuoc56" runat="server" Text="Thuốc bán 56" /></td>
		 <td width ="120px">
											  <asp:CheckBox TabIndex="1"   ID="chkThuocHanSD" runat="server" Text="Thuốc có HSD" /></td>
		<td width ="120px">
											  <asp:CheckBox TabIndex="1"   ID="chkThuocHoiChan" runat="server" Text="Thuốc hội chẩn" /></td>

						 </tr>
						 <tr>
						   <td>    <asp:Label ID="Label35" runat="server" Text="BH trả" ForeColor="#FF3300"></asp:Label></td>
                                <td>   <asp:TextBox ID="txtThuocBH" Text="" runat="server" TabIndex="1"
                          style = "width:100% !important"></asp:TextBox></td>
                      
                              <td>  <asp:CheckBox TabIndex="1"   ID="chkNoiVien" runat="server" Text="Thuốc N.Viện" /></td>
						
							  <td>  <asp:CheckBox TabIndex="1"   ID="chkCLS" runat="server" Text="Thuốc CLS" /></td>
							   <td>  <asp:CheckBox TabIndex="1"   ID="chkDuoc" runat="server" Text="Thuốc Dược" /></td>
						   <td>  <asp:CheckBox TabIndex="1"   ID="chkTieuHao" runat="server" Text="Thuốc tiêu hao" /></td>
							  <td>  <asp:CheckBox TabIndex="1"   ID="chkKhongSD" runat="server" Text="Không SD" /></td>
						 </tr>
			</table> 
			</div>
     <asp:ObjectDataSource EnableCaching="false" CacheExpirationPolicy="Absolute" CacheDuration="180" ID="ObjectDanhMuc" runat="server" OnSelecting="ObjectDanhMuc_Selecting"
        SelectMethod="FindDMThuocMa"
        TypeName="HTC.Business.CategoryList.DMThuocList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="Ma" Type="String" DefaultValue="" />

        </SelectParameters>
    </asp:ObjectDataSource>
    </asp:Content>
