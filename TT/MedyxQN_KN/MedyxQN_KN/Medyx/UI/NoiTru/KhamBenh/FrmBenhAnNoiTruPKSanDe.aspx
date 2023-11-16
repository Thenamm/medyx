<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="FrmBenhAnNoiTruPKSanDe.aspx.cs" Inherits="UI_NoiTru_KhamBenh_FrmBenhAnNoiTruPKSanDe" %>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <%--<script type="text/javascript" src='<%: ResolveUrl("~/js/jquery.min.js") %>'></script>
        <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>--%>

		<style type="text/css">
			table td
			{
				/*border:1px solid black;*/
			}


		</style>
            <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.js")%>' type="text/javascript"></script>
    <script src='<%: ResolveUrl("~/js/datetimepicker/jquery.datetimepicker.js")%>' type="text/javascript"></script>
    <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
    <link href='<%: ResolveUrl("~/css/datetimepicker/jquery.datetimepicker.css")%>' rel="stylesheet" />

        <script type="text/javascript">
            $(function () {
                $("#<%= dtNgayVV.ClientID %>").datetimepicker({
                   
                     dateFormat: 'dd/mm/yy',
                     altFormat: "dd/mm/yy",
                     timeFormat: 'HH:mm',
                     format: 'd.m.Y H:i'
                })
            });




            $(function () {
                $("#<%= dtNgaySinh.ClientID %>").datetimepicker({

                      dateFormat: 'dd/mm/yy',
                      altFormat: "dd/mm/yy",
                      timeFormat: 'HH:mm',
                      format: 'd.m.Y',
                    //timepicker: true

                   


                  })
            });

            $(document).ready(function () {
                $("#<%= dtNgaySinh.ClientID %>").mask("99/99/9999");
                $("#<%= dtNgayVV.ClientID %>").mask("99/99/9999 99:99");
                
                
                $("#<%= dtNgaySinh.ClientID %>").blur(function () {
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

                         var currentdate = new Date();
                         if ((month != checkdate.getMonth() + 1)) {
                             $(this).val('').focus().css('background', '#fdd');
                             alert("Ngày tháng không hợp lệ ");
                         }

                         if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) < 0) {
                             $(this).val('').focus().css('background', '#fdd');
                             alert("Ngày phải trước ngày hiện tại");
                         }

                         else
                             $(this).css('background', 'transparent');
                     }
                 });
                $("#<%= dtNgaySinh.ClientID %>").blur(function () {
                    var dateRegEx = /^(0?[1-9]|[12][0-9]|3[01])[\/\-\.](0?[1-9]|1[012])[\/\-\.](\d{4})$/;
                    var validTime = $(this).val().match(dateRegEx);
                    if (this.value == "__/__/____") this.value = "";
                    if (this.value != "")
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
                                alert("Ngày sinh không hợp lệ");
                            }
                            var currentdate = new Date();
                            if ((currentdate - checkdate) / (1000 * 60 * 60 * 24) < 0) {
                                $(this).val('').focus().css('background', '#fdd');
                                alert("Ngày sinh phải trước ngày hiện tại");
                            }
                            else
                                $(this).css('background', 'transparent');
                        };
                });
            });

        function GridCreated(sender, args) {
            var scrollArea = sender.GridDataDiv;
            var parent = $get("gridContainer");
            var gridHeader = sender.GridHeaderDiv;
            scrollArea.style.height = parent.clientHeight -
              gridHeader.clientHeight + "px";
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

            if (pressedKey == 113) { //f2 - GHI
                var toolbar1 = $find("<%= baraction.ClientID %>");
                var templateButton = toolbar1.findItemByValue("cmdSave");
                templateButton.click();
            }
            else if (pressedKey == 121) { //f10-thoat
                var toolbar1 = $find("<%= baraction.ClientID %>");
               var templateButton = toolbar1.findItemByValue("cmdExit");
               templateButton.click();
           }
           else if (pressedKey == 120) { //f9-In
               var toolbar1 = $find("<%= baraction.ClientID %>");
                   var templateButton = toolbar1.findItemByValue("cmdPrint");
                   templateButton.click();
               }
   }
            function subtinhtuoi(sender, eventArgs) {
                var dtns = document.getElementById("<%= dtNgaySinh.ClientID %>");


       var d = new Date();
       txttuoi.value = d.getFullYear() - parseInt(dtns.value.substr(dtns.value.length - 4), 10);

   }

            function processClick(sender, args) {
                var commandName = args.get_item().get_commandName();

                if (commandName == 'cmdExit') {

                    window.opener = null;
                    window.close();

                }

                if (commandName == 'cmdSave') {
                    var ok = confirm("Thực sự muốn ghi bệnh nhân này?");
                    if (ok)
                        return true;
                    else
                        return args.set_cancel(true);
                }
            }
        </script>

    </telerik:RadCodeBlock>

    <telerik:RadToolBar ID="baraction" runat="server" OnClientButtonClicked="processClick"
        EnableRoundedCorners="true"
        EnableShadows="true" OnButtonClick="baraction_ButtonClick" Width="100%">
        <Items>
            <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.png"
                Text="F2 - Ghi" CheckOnClick="false" Value="cmdSave" CommandName="cmdSave" >
            </telerik:RadToolBarButton>
         
            
            <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg" CheckOnClick="false"
                Text="F10 - Thoát" CssClass="ButtonCSS" Value="cmdExit" CommandName="cmdExit">
            </telerik:RadToolBarButton>
        </Items>
    </telerik:RadToolBar>

   

    <div style="clear: both">
        &nbsp;
    </div>

    <div class="form-container"  style="width:100%">
        <fieldset align="center">
            <legend>
                
            </legend>

           <div align="center" class="form-container" >
      
        <table cellpadding="0" cellspacing="0" class="data-form-in-grid"  width="100%" id ="thongtibn" runat ="server" >

                <tr>
                    <td width ="70px">
                        <asp:Label runat="server" Text="Họ Tên"></asp:Label>
                        <asp:HiddenField runat ="server" ID ="txtnoitt" />                      

                    </td>
                        
                    <td width ="180px">
                        <asp:TextBox runat="server" ID="txthoten" Enabled="true"></asp:TextBox>
                    </td>
                   
                        <td width ="70px">
                        <asp:Label ID="lblGioiTinh" runat="server" Text="Giới tính"></asp:Label>
                    </td>

                    <td width ="110px">
                        <asp:RadioButtonList ID="optGT" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">Nam</asp:ListItem>
                            <asp:ListItem Value="0" Selected ="True">Nữ</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                

                    <td width ="50px">
                        <asp:Label  runat="server" Text="Ngày sinh"></asp:Label>
                    </td>

                    <td width ="80px">
                        <asp:TextBox runat="server" ID="dtNgaySinh" Enabled="true" onchange="subtinhtuoi(this)"></asp:TextBox>
                                      
                    </td>

                    <td width ="70px">
                        <asp:Label ID="Label3"  runat="server" Text="N.máu mẹ"></asp:Label>
                    </td>
                    <td width ="70px">
                        <asp:TextBox runat="server" ID="txtNhomMauMe" Enabled="true"></asp:TextBox>
                                      
                    </td>
                     
					 <td width ="50px" align="right">
                        <asp:Label ID="Label4" runat="server" Text="BA mẹ"></asp:Label>
                    </td>

                    <td width ="140px">
                        <asp:TextBox runat="server" width ="100%" ID="txtmabame" Enabled ="false"  AutoPostBack="false"></asp:TextBox>
                                      
                    </td>
                </tr>
            


                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Dân tộc"></asp:Label>
                    </td>
                    
                   <td style="padding-right:0px">
                        <telerik:RadComboBox                   runat="server" ID="cbodantoc" 
                            
                                            EnableVirtualScrolling="true"                                            
                                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true"                
                                            ItemsPerRequest="20"
											Width="100%"
                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"                                                                                        
                                            MarkFirstMatch="true"                                                                                                                                                                                
                                             Enabled ="false"
                                            Filter="Contains"
                                            HighlightTemplatedItems="true"
                                              OpenDropDownOnLoad="false"
                            DataSourceID="odsdantoc" AutoPostBack="false" 
                            DataTextField="Value" DataValueField="Key">
                        </telerik:RadComboBox>
                    </td>
                     <td >
                        <asp:Label ID="Label5" runat="server" Text="Quốc tịch"></asp:Label>
                    </td>
                    
                   <td colspan="2" style="padding-right:0px" >
                        <telerik:RadComboBox                  runat="server" IsCaseSensitive="false" ID="cboquocgia" 
                            
                                            EnableVirtualScrolling="true"                                            
                                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true"                
                                            ItemsPerRequest="20"
											Width="100%"
                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"                                                                                        
                                            MarkFirstMatch="true"                                                                                                                                                                                
                                            Enabled ="false"
                                            Filter="Contains"
                                            HighlightTemplatedItems="true"
                                              OpenDropDownOnLoad="false"
                            DataSourceID="odsquocgia" AutoPostBack="false" DataTextField="Value" DataValueField="Key">
                        </telerik:RadComboBox>
                    </td>
                     <td>
                        <asp:Label ID="Label16" runat="server" Text="Khoa NV"></asp:Label>
                    </td>
                    
                   <td colspan="4" style="padding-right:0px">
                        <telerik:RadComboBox                   runat="server" ID="cboKhoaNV" DataSourceID="odskhoaNV"
                             AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                              HighlightTemplatedItems="true"
                            CssClass="span-all" Width ="100%">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Tỉnh"></asp:Label>
                    </td>
                    
                   <td style="padding-right:0px">
                        <telerik:RadComboBox                  runat="server" IsCaseSensitive="false" ID="cbotinh" DataSourceID="odstinh" 
                           
                                            EnableVirtualScrolling="true"                                            
                                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true"                
                                            ItemsPerRequest="20"
											Width="100%"
                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"                                                                                        
                                            MarkFirstMatch="true"                                                                                                                                                                                
                                             Enabled ="false"
                                            Filter="Contains"
                                            HighlightTemplatedItems="true"
                                              OpenDropDownOnLoad="false"
                             AutoPostBack="true"  OnSelectedIndexChanged="cbotinh_SelectedIndexChanged" 
                            DataTextField="Value" DataValueField="Key">
                        </telerik:RadComboBox>
                    </td>
                     <td >
                        <asp:Label ID="Label8" runat="server" Text="Huyện"></asp:Label>
                    </td>
                    
                   <td  colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox          
                                    runat="server" IsCaseSensitive="false" ID="cbohuyen" DataSourceID="odshuyen" 
                            Enabled ="false"
                                            EnableVirtualScrolling="true"                                            
                                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true"                
                                            ItemsPerRequest="20"
											Width="100%"
                                            ShowMoreResultsBox="true"
                                            ShowDropDownOnTextboxClick="true"                                                                                        
                                            MarkFirstMatch="true"                                                                                                                                                                                
                                            
                                            Filter="Contains"
                                            HighlightTemplatedItems="true"
                                              OpenDropDownOnLoad="false"
                            AutoPostBack="false" 
                            DataTextField="Value" DataValueField="Key">
                        </telerik:RadComboBox>
                    </td>
                    <td >
                        <asp:Label ID="Label1" runat="server" Text="Phường Xã"></asp:Label>
                    </td >
                        <td  runat ="server" id ="xa">  <telerik:RadComboBox  IsCaseSensitive ="false"               CaseSensitive="false" TabIndex="1"
                                runat="server" ID="cboPXa" DataSourceID="odspxa"
                                EnableVirtualScrolling="true"
                                EnableLoadOnDemand="true"
                                DropDownAutoWidth="Enabled" 
                                Width="100%"
                                EnableAutomaticLoadOnDemand="true"
                               Enabled ="false"
                                ShowMoreResultsBox="true"
                                ShowDropDownOnTextboxClick="true"
                                MarkFirstMatch="true"
                                Filter="Contains"
                                HighlightTemplatedItems="true"
                                OpenDropDownOnLoad="false"
                                AutoPostBack="true"
                               
                                DataTextField="Value" DataValueField="Key">
                                
                            </telerik:RadComboBox>
                        </td>
                     <td  runat ="server" id ="lblxa">
                            <asp:Label ID="Label27" runat="server" Text="Địa chỉ"></asp:Label>
                        </td>
                    <td colspan="4"  runat="server" id ="diachi" >
                        <asp:TextBox runat="server" ID="txtThonXa" Enabled="false" CssClass="span-all" ></asp:TextBox>   
                    </td>
                </tr>
              
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Liên hệ"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox runat="server" ID="txtDiaChi" Enabled="false" CssClass="span-all"></asp:TextBox>
                    </td>
                     <td>
                        <asp:Label ID="Label9" runat="server" Text="Đ.thoại"></asp:Label>
                    </td>
                    <td colspan ="4" >
                        <asp:TextBox runat="server" ID="txtdienthoai" Enabled="false" CssClass="span-all"></asp:TextBox>
                    </td>
                
                </tr>
                 <tr>
                   
                     <td >
                        <asp:Label ID="Label12" runat="server" Text="B.Sĩ ĐT" ></asp:Label>
                    </td>
                     <td style="padding-right:0px">
                      
                    <telerik:RadComboBox                  ID="cboBacSi" runat="server" AppendDataBoundItems="True"
                                             AutoPostBack="false" DataSourceID="ObjectDanhMucNV"
                                            DataTextField="HoTen" DataValueField="MaNV"  DropDownWidth ="470px" CssClass="span-all"
                                             EnableVirtualScrolling="true" Width ="100%"
                                            EnableLoadOnDemand="true"
                                            ItemsPerRequest="20"
                                            ShowMoreResultsBox="true"
                                             ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                            EnableAutomaticLoadOnDemand="true"                
                                            MarkFirstMatch="true" 
                                             ExpandDirection="Down" Filter="StartsWith"
                                            HighlightTemplatedItems="true"
                                             >
                                              <HeaderTemplate>
                                                <table class="NHTC_table_layout">
                                                    <tr>
                                                       
                                                      
                                                        <td width="200px">Họ tên</td>
                                                        <td width="200px">Khoa</td>
                                                       <td width="70px">Mã NV</td>
                                                    </tr>
                                                </table>
                                            </HeaderTemplate>
                                            <Items>
                                                <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                            </Items>
                                            <ItemTemplate>
                                                <table>
                                                   
                                                    <tr>
                                                         
                                                        <td width="200px">
                                                            <%# DataBinder.Eval(Container.DataItem, "HoTen") %>
                                                        </td>
                                                        <td width="200px">
                                                            <%# DataBinder.Eval(Container.DataItem, "TenKhoa") %>
                                                        </td>
                                                     <td width="70px">
                                                            <%# DataBinder.Eval(Container.DataItem, "MaNV") %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                    </telerik:RadComboBox>
               
                    </td>
                      <td>
                        <asp:Label ID="Label11" runat="server" Text="Ngày vào viện "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="dtNgayVV" Enabled="true"></asp:TextBox>
                                      
                    </td>
					<td></td>
                      <td align="right">
                        <asp:Label ID="Label14" runat="server" Text="Đối tượng"></asp:Label>
                    </td>
                    
                   <td colspan="4" style="padding-right:0px">
                        <telerik:RadComboBox                  runat="server" ID="cboDoiTuong" 
                            DataSourceID="odsDoiTuong" Enabled="false"
                             AutoPostBack="false" DataTextField="Value" DataValueField="Key"
                              HighlightTemplatedItems="true"
                            CssClass="span-all" Width ="100%">
                        </telerik:RadComboBox>
                    </td>
                    </tr>


<tr>
                                    <td width ="70px">                                               
                        <asp:Label runat="server" Text="Họ Tên Cha"></asp:Label>
                        <asp:HiddenField runat ="server" ID ="HiddenField1" />

                    </td>
                    <td width ="180px">
                        <asp:TextBox runat="server" ID="txthotencha" Enabled="true"></asp:TextBox>
                    </td>

               <td width="50px">
                            <asp:Label ID="Label17" runat="server" Text="Mã BHXH Cha"></asp:Label>
                        </td>
                        <td width="200px" colspan="3">
                            <asp:TextBox runat="server" ID="txtMaBHXHCha" Enabled="true"></asp:TextBox>
                        </td>


               

            </tr>


               <tr>
                   <td >
                        <asp:Label ID="Label2" runat="server" Text="Họ tên bố mẹ" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txthotenBM" Enabled="false"></asp:TextBox>
                                      
                    </td>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text="NN Bố mẹ"></asp:Label>
                    </td>
                    
                   <td colspan="2" style="padding-right:0px">
                        <telerik:RadComboBox         
                                     runat="server" ID="cboNgheNghiep" DataSourceID="odsNgheNghiep"
                             AutoPostBack="false" DataTextField="Value" DataValueField="Key" Enabled="false"
                            EnableLoadOnDemand="true"
                                            EnableAutomaticLoadOnDemand="true" 
                              HighlightTemplatedItems="true" 
                            CssClass="span-all" Width ="100%">
                        </telerik:RadComboBox>
                    </td>
                    <td >
                        <asp:Label ID="Label15" runat="server" Text="Số con" ></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="txtSocon" Enabled="true"></asp:TextBox>
                                      
                    </td>
                    <td >
                        <asp:Label ID="Label19" runat="server" Text="Lần Sinh" ></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="txtLansinh" Enabled="true"></asp:TextBox>
                                      
                    </td>                 
               </tr>


            <tr>

                <td width ="70px">                                               
                        <asp:Label runat="server" Text="Nơi Sinh "></asp:Label>
                        <asp:HiddenField runat ="server" ID ="HiddenField2" />

                    </td>
                     <td colspan="1">
                        <asp:TextBox runat="server" ID="txtNoisinh" Enabled="true"></asp:TextBox>
                                      
                    </td> 

                 <td >
                        <asp:Label ID="Label23" runat="server" Text="Số con sống" ></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="txtSoconsong" Enabled="true"></asp:TextBox>
                                      
                    </td>  


                <td >
                        <asp:Label ID="Label20" runat="server" Text="Tình trạng con" ></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="txtTinhtrangcon" Enabled="true"></asp:TextBox>
                                      
                    </td>   

                <td >
                        <asp:Label ID="Label21" runat="server" Text="Cân nặng" ></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="txtcannang" Enabled="true"></asp:TextBox>
                                      
                    </td>   

                 
            </tr>
            
            <tr>

                <td >
                        <asp:Label ID="Label22" runat="server" Text=" Tuổi thai " ></asp:Label>
                    </td>
                    <td colspan="1">
                        <asp:TextBox runat="server" ID="txttuoithai" Enabled="true"></asp:TextBox>
                                      
                    </td> 



                 <td >
						<asp:Label  ID="txtNguoidode" runat="server" Text="Người đỡ đẻ / Phẫu thuật "></asp:Label></td>
						  <td colspan = "5">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cbonhanvien" DataTextField="HoTen" 
							DataValueField="MaNV" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>

            </tr>

     

                       <tr>
                <td >

                        <asp:Label ID="txtCachDe" runat="server" Text="Cách đẻ" ></asp:Label>
                   
                    </td>
                            
                 <td colspan="1">
                         <asp:RadioButton ID="chkdethuong" GroupName="A" runat="server" Text=" Đẻ Thường" />
                     </td>     
                <td  colspan="1">
                         <asp:RadioButton ID="chkFoocxep" GroupName="A" runat="server" Text=" FoocXep " />
                     </td>  
                <td  colspan="1">
                         <asp:RadioButton ID="chkGiacHut" GroupName="A" runat="server" Text=" Giác Hút " />
                     </td>  
                <td  colspan="2">
                         <asp:RadioButton ID="chkmolaythai" GroupName="A" runat="server" Text=" Mổ Lấy Thai " />
                     </td>  
                <td  colspan="2">
                         <asp:RadioButton ID="chkdechihuy" GroupName="A" runat="server" Text=" Đẻ Chỉ Huy " />
            
                     </td>
            </tr>



            



            </table>
               </div> 
             </fieldset>
    </div>
        
   
    <br />

     
    
   

    <asp:ObjectDataSource  ID="odsdantoc" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMDantocListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odsquocgia" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMQuocGiaListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource  ID="odstinh" runat="server" SelectMethod="GetList" 
        TypeName="HTC.Business.CategoryList.DMTinhListcb" EnableViewState="true"></asp:ObjectDataSource>

    <asp:ObjectDataSource  ID="odshuyen" runat="server" SelectMethod="GetListbyTinh"  OnSelecting ="odshuyen_Selecting"
        TypeName="HTC.Business.CategoryList.DMQuanHuyenListcb" EnableViewState="true">
         <SelectParameters>
            <asp:Parameter Name="matinh" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsNgheNghiep" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMNgheNghiepListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsLoaiBA" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMLoaiBAListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odsDoiTuong" runat="server" SelectMethod="GetList" 
        TypeName="HTC.Business.CategoryList.DMDoituongListcb" EnableViewState="true"></asp:ObjectDataSource>
    <asp:ObjectDataSource  ID="odskhoaNV" runat="server" SelectMethod="GetList" TypeName="HTC.Business.CategoryList.DMKhoaListcb" EnableViewState="true"></asp:ObjectDataSource>
    
    
   <asp:ObjectDataSource  ID="ObjectDanhMucNV" runat="server" SelectMethod="FindDMNhanVienByMa" 
        TypeName="HTC.Business.CategoryList.DMNhanVienList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="ma" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>

     <asp:ObjectDataSource ID="odspxa" runat="server" SelectMethod="GetListbyQH" OnSelecting="odspxa_Selecting"
        TypeName="HTC.Business.CategoryList.DMPhuongXaListcb" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="maQH" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>








    














    






</asp:Content>

