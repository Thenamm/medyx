<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="frmGiayChungSinh.aspx.cs" Inherits="UI_QLHSBA_frmGiayChungSinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">    
    <script type="text/javascript" src='<%: ResolveUrl("~/js/maskinput/jquery.maskedinput-1.3.1.min_.js") %>'></script>
    <style type="text/css">
    .ButtonCSS
       {
           margin-left:400px;
       }
            .mainContent {
              width:100%!important;
          }
   </style>
      <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
   <script type="text/javascript">
       $(function () {
           $("#<%= dtNGAYSINH_NND.ClientID %>").datetimepicker({

                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y H:i'
                })
            });

       $(function () {
           $("#<%= dtNGAYCAP_CCCD_NND.ClientID %>").datetimepicker({

                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y H:i'
                })
            })


       $(function () {
           $("#<%= dtNGAY_SINH_CON.ClientID %>").datetimepicker({

                    dateFormat: 'dd/mm/yy',
                    altFormat: "dd/mm/yy",
                    timeFormat: 'HH:mm',
                    format: 'd.m.Y',
                    //timepicker: false
                })
            });

       $(document).ready(function () {
           $("#<%= dtNGAYSINH_NND.ClientID %>").mask("99/99/9999");
                $("#<%= dtNGAYCAP_CCCD_NND.ClientID %>").mask("99/99/9999 99:99");
                $("#<%= dtNGAY_SINH_CON.ClientID %>").mask("99/99/9999 99:99");
                
                $("#<%= dtNGAYSINH_NND.ClientID %>").blur(function () {
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
                $("#<%= dtNGAYSINH_NND.ClientID %>").blur(function () {
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
<%--       function hidePhauThuat() {
           var pt = $("#<%= rblPhauThuat.ClientID%> input:checked").val();
           //alert(list);
           //var lst = document.getElementsByClassName(cls);
           //for (var i = 0; i < lst.length; ++i) {
           //    lst[i].style.display = on ? '' : 'none';
           //}
           if (pt == "Có") {
               $("#PhauThuat").show();
           }
           else {
               $("#PhauThuat").hide();
           }
       }
       function hideNoiTV() {
           var pt = $("#<%= rblNoiTuVong.ClientID%> input:checked").val();
           //alert(list);
           //var lst = document.getElementsByClassName(cls);
           //for (var i = 0; i < lst.length; ++i) {
           //    lst[i].style.display = on ? '' : 'none';
           //}
           if (pt == "Địa điểm khác") {
               $("#NoiTV").show();
           }
           else {
               $("#NoiTV").hide();
           }
       }--%>
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
                 <telerik:RadToolBarButton ImageUrl="~/img/icon/Save.gif"
                    Text="F2-Ghi " Group="Align" CheckOnClick="false" Value="cmdSave" CommandName="cmdSave">
                </telerik:RadToolBarButton>
<%--                 <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                    Text="In phiếu chẩn đoán NNTV" CheckOnClick="false" Value="cmdPrintCD">
                </telerik:RadToolBarButton>--%>
                  <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                    Text="In Giấy Chứng Sinh" CheckOnClick="false" Value="cmdPrint">
                </telerik:RadToolBarButton>
<%--                 <telerik:RadToolBarButton ImageUrl="~/img/icon/print.gif"
                    Text="In Giấy đề nghị cấp lại GBT" CheckOnClick="false" Value="cmdPrintLai">
                </telerik:RadToolBarButton>--%>
               <telerik:RadToolBarButton ImageUrl="~/img/icon/cancel.jpg"
                Text="F10-Thoát"  CheckOnClick="false" Value ="cmdExit" >
            </telerik:RadToolBarButton>
             <telerik:RadToolBarButton ImageUrl="~/img/icon/View.png"
                Text="F6-Xem"   CssClass="ButtonCSS" Value ="cmdView">
            </telerik:RadToolBarButton>

             <telerik:RadToolBarButton ImageUrl="~/img/icon/edit.jpg"
                Text="Ký"   CssClass="ButtonCSS" Value ="cmdKy">
            </telerik:RadToolBarButton>



            </Items>
         </telerik:RadToolBar>
        </div>
      <fieldset align="center">
            <legend>
               <asp:Label ID="Label3" runat="server" Text="Thông tin bệnh nhân" Font-Bold="true"></asp:Label>
            </legend> 
    <div style="align-content:center!important">
        <table  align="left" >
                            <tr>
                                <td Width="5%">
                                    <asp:Label ID="Label1" runat="server" Text="Họ tên NND:" Width="70px"></asp:Label>
                                </td>
                                <td width="20%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtHOTEN_NND" Enabled="false" style="width:96% !important"></asp:TextBox>
                                </td>

                                <td Width="5%">
                                    <asp:Label ID="Label2" runat="server" Text="Giới tính" Width="70px"></asp:Label>
                                </td>
                                <td colspan ="2"  > 
                                   <asp:RadioButtonList TabIndex="1" ID="lblGioitinh" runat="server" RepeatDirection="Horizontal" Enabled="false">
                                        <asp:ListItem Value="1">Nam</asp:ListItem>
                                        <asp:ListItem Value="0" Selected ="True">Nữ</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                               
                            </tr>



            <tr>

                               <td colspan ="1">
                                    <asp:Label ID="Label37" runat="server" Text="Ngày sinh" ></asp:Label>
                                </td>
                                <td Width="5%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNGAYSINH_NND" Enabled="false" style="width:96% !important"></asp:TextBox>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label39" runat="server" Text="Tuổi(*)"></asp:Label>
                                </td>
                                <td width="5%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtTuoi" Width="50px" Enabled="false" onchange="subtinhtuoi1(this)"></asp:TextBox>
                                </td>
                                <td Width="5%">
                                    <asp:Label ID="Label41" runat="server" Text="Mã BN" Width="40px"></asp:Label>
                                </td>
                                <td width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtMaQL" Width="100%" Enabled="false"></asp:TextBox>
                                </td>
            </tr>

            <tr>
                <td>
                       <asp:Label ID="Label4" runat="server" Text="Mã BHXH NND "></asp:Label>
                      </td>
                    <td Width="5%">
                    <asp:TextBox runat="server" ID="txtMA_BHXH_NND" Width="168px"></asp:TextBox>
                    </td>
                             <td >
						<asp:Label  ID="Label5" runat="server" Text="Dân tộc "></asp:Label></td>
						  <td colspan = "2">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cbodantoc" DataTextField="TenDanToc" 
							DataValueField="MaDanToc" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>

            </tr>
            <tr>
<%--                <td>
                                    <asp:Label ID="Label36" runat="server" Text="Người thân thích:" Width="70px"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNguoiThan" Enabled="false" style="width:96% !important"></asp:TextBox>
                                </td>--%>
                <td>
                       <asp:Label ID="Label40" runat="server" Text="Số CMND: "></asp:Label>
                      </td>
                    <td Width="5%">
                    <asp:TextBox runat="server" ID="txtSO_CMND_NND" Width="168px"></asp:TextBox>
                    </td>
                <td Width="5%">
                       <asp:Label ID="Label42" runat="server" Text="Ngày cấp CMND: "></asp:Label>
                      </td>
                    <td Width="5%">
                    <asp:TextBox runat="server" ID="dtNGAYCAP_CCCD_NND"></asp:TextBox>
                    </td>
                    <td>
                       <asp:Label ID="Label38" runat="server" Text="Nơi cấp: "></asp:Label>
                      </td>
                    <td colspan="1">
                    <asp:TextBox runat="server" ID="txtNOICAP_CCCD_NND"></asp:TextBox>
                    </td>
            </tr>

            <tr>
                             <td Width="5%">
                                    <asp:Label ID="Label6" runat="server" Text="Nơi Đki thường trú NND" ></asp:Label>
                                </td>
                                <td colspan ="5">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNOI_DK_THUONGTRU_NND"  ></asp:TextBox>
                                </td>
            </tr>



                        <tr>
                             <td Width="5%">
                                    <asp:Label ID="Label7" runat="server" Text="Họ tên cha" ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtHO_TEN_CHA" ></asp:TextBox>
                                </td>

                                                            <td>
                                    <asp:Label ID="Label11" runat="server" Text="Điện thoại:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtDienThoai" ></asp:TextBox>
                                </td>




            </tr>
                            <tr>
<%--                                <td>
                                    <asp:Label ID="Label43" runat="server" Text="Nghề nghiệp"></asp:Label>
                                </td>
                               <td>
                                    <asp:TextBox ID ="txtNgheNghiep"  runat="server"  CssClass="span-all" style="width:96% !important" Enabled ="false" ></asp:TextBox>
                                </td>--%>
                               
                                <td>
                                    <asp:Label ID="Label50" runat="server" Text="Địa chỉ:"></asp:Label>
                                </td>
                                    <td colspan ="5">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtDiaChi" ></asp:TextBox>
                                </td>

                            </tr>

                            


            <tr>
                                                <td Width="5%">
                                    <asp:Label ID="Label12" runat="server" Text="Ngày sinh con " ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNGAY_SINH_CON" ></asp:TextBox>
                                </td>








                 <td >
                        <asp:Label ID="GIOI_TINH_CON" runat="server" Text="Giới tính con" ></asp:Label>
                    </td>
                 <td >
                         <asp:RadioButton ID="checknam" GroupName="A" runat="server" Text=" Nam" />
                     </td>     
                <td  >
                         <asp:RadioButton ID="checknu" GroupName="A" runat="server" Text=" Nữ " />
                     </td>  
                <td  >
                         <asp:RadioButton ID="checkkxd" GroupName="A" runat="server" Text=" Không xác định " />
                     </td>  






            </tr>

            <tr> 

                                                            <td >
                                    <asp:Label ID="Label8" runat="server" Text="Số con " ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtSO_CON" ></asp:TextBox>
                                </td>

                  <td >
                                    <asp:Label ID="Label9" runat="server" Text="Cân nặng con " ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtCAN_NANG_CON" ></asp:TextBox>
                                </td>
                                               </tr>
            <tr>
                                                                <td >
                                    <asp:Label ID="Label13" runat="server" Text="Nơi sinh " ></asp:Label>
                                </td>
                                <td >
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNOI_SINH_CON" ></asp:TextBox>
                                </td>


                 <td Width="5%">
                                    <asp:Label ID="Label14" runat="server" Text="Lần sinh" ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtLAN_SINH" ></asp:TextBox>
                                </td>





            </tr>

            <tr>

                                                 <td Width="5%">
                                    <asp:Label ID="Label15" runat="server" Text="Tình trạng con" ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtTINH_TRANG_CON" ></asp:TextBox>
                                </td>

                
                                 <td Width="5%">
                                    <asp:Label ID="Label10" runat="server" Text="Số con sống" ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtSO_CON_SONG" ></asp:TextBox>
                                </td>

            </tr>
            <tr>
                                        <td><asp:Label ID="Label32" runat="server" Text="Sinh con phẫu tuật"></asp:Label></td>
                        <td colspan="1"><asp:RadioButtonList ID="rblSINHCON_PHAUTHUAT" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                            </asp:RadioButtonList>  </td>

                
                                        <td><asp:Label ID="Label16" runat="server" Text="Sinh con dưới 32 tuần"></asp:Label></td>
                        <td colspan="1"><asp:RadioButtonList ID="rblSINHCON_DUOI32TUAN" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                            </asp:RadioButtonList>  </td>

                <td>
                    <asp:CheckBox ID="chkHuy" runat="server" Text="Hủy" />
                    </td>

            </tr>


                             <td >
						<asp:Label  ID="Label17" runat="server" Text="Người đỡ đẻ "></asp:Label></td>
						  <td colspan = "1">
						
                              <telerik:RadComboBox   OnClientKeyPressing="HandlekeyPressEnter"           
                                 TabIndex="1" ID="cbonhanvien" DataTextField="HoTen" 
							DataValueField="MaNV" runat="server"
							Width="100%">
						</telerik:RadComboBox>
						  </td>


                                             <td Width="5%">
                                    <asp:Label ID="Label18" runat="server" Text="Người ghi phiếu" ></asp:Label>
                                </td>
                                <td colspan ="3">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNGUOI_GHI_PHIEU" ></asp:TextBox>
                                </td>
            <tr>
                                                                                 <td Width="5%">
                                    <asp:Label ID="Label21" runat="server" Text="Số giấy chứng sinh" ></asp:Label>
                                </td>
                                <td >
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtSoGiayChungSinh" 
                                         AutoPostBack="false" Enabled="false"
                                       style="width:96% !important"></asp:TextBox>
                                </td>    
            </tr>

            <tr>

                                                                <td Width="5%">
                                    <asp:Label ID="Label19" runat="server" Text="Ngày cấp giấy " ></asp:Label>
                                </td>
                                <td Width="10%">
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNGAY_CT" ></asp:TextBox>
                                </td>

                                                                                <td Width="5%">
                                    <asp:Label ID="Label20" runat="server" Text="Ghi chú " ></asp:Label>
                                </td>
                                <td colspan ="4">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtGHI_CHU" ></asp:TextBox>
                                </td>                                             


            </tr>
                        </table> 
             </div>
          </fieldset>
<%--        <fieldset>
            <legend>
               <asp:Label ID="Label4" runat="server" Text="PHIẾU CHẨN ĐOÁN NGUYÊN NHÂN TỬ VONG" Font-Bold="true"></asp:Label>
            </legend> 
            <div style="align-content:center!important">
                <table>
                    <tr>
                        <td colspan="7" style="text-align:center!important">
                    <asp:Label ID="Label5" runat="server" Text="Phần A: Thông tin về y tế: Mục 1 và 2" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                    <tr>
                        <td style="width:25%!important"><asp:Label ID="Label51" runat="server" Text="Mục 1." Font-Bold="true"></asp:Label></td>
                        <td style="width:5%!important"><asp:Label ID="Label52" runat="server" Text="Chuỗi sự kiện"></asp:Label></td>
                        <td style="width:5%!important"></td>
                        <td colspan="3" style="width:40%!important"><asp:Label ID="Label53" runat="server" Text="Chẩn đoán nguyên nhân tử vong"></asp:Label></td>
                        <td style="width:25%!important"><asp:Label ID="Label54" runat="server" Text="Khoảng thời gian ước tính từ khi khởi phát sự kiện đến khi tử vong"></asp:Label></td>
                        </tr>
                    <tr>
                        <td><asp:Label ID="Label6" runat="server" Text="Nguyên nhân tử vong trực tiếp *"></asp:Label></td>
                        <td><img src="../../../img/icon/turn-right.png" /></td>
                        <td>a</td>
                        <td colspan="3"><asp:TextBox ID="txtNguyenNhanA" runat="server" TabIndex="1" Width="98%" TextMode="MultiLine"></asp:TextBox></td>
                        <td><asp:TextBox ID="txtThoiGianA" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td rowspan="2"><asp:Label ID="Label7" runat="server" Text="Chuỗi sự kiện (bệnh dòng dưới dẫn đến nguyên nhân của bệnh dòng trên)"></asp:Label></td>
                        <td><img src="../../../img/icon/turn-right.png" /></td>
                        <td>b</td>
                        <td colspan="3"><asp:TextBox ID="txtNguyenNhanB" runat="server" TabIndex="1" Width="98%" TextMode="MultiLine"></asp:TextBox></td>
                        <td><asp:TextBox ID="txtThoiGianB" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><img src="../../../img/icon/turn-right.png" /></td>
                        <td>c</td>
                        <td colspan="3"><asp:TextBox ID="txtNguyenNhanC" runat="server" TabIndex="1" Width="98%" TextMode="MultiLine"></asp:TextBox></td>
                        <td><asp:TextBox ID="txtThoiGianC" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label9" runat="server" Text="Dòng cuối cùng của chuỗi là nguyên nhân chính gây tử vong"></asp:Label></td>
                        <td></td>
                        <td>d</td>
                        <td colspan="3"><asp:TextBox ID="txtNguyenNhanD" runat="server" TabIndex="1" Width="98%" TextMode="MultiLine"></asp:TextBox></td>
                        <td><asp:TextBox ID="txtThoiGianD" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="3"><b>Mục 2. </b>Bệnh/ tình trạng quan trọng khác góp phần vào tử vong </td>
                        <td colspan="3"><asp:TextBox ID="txtNguyenNhan2" runat="server" TabIndex="1" Width="98%" TextMode="MultiLine"></asp:TextBox></td>
                        <td><asp:TextBox ID="txtThoiGian2" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="7" style="text-align:center!important">
                    <asp:Label ID="Label8" runat="server" Text="Phần B: Các thông tin y tế khác:" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                    <tr>
                        <td><asp:Label ID="Label10" runat="server" Text="1. Phẫu thuật có được thực hiện 4 tuần qua?"></asp:Label></td>
                        <td colspan="5"><asp:RadioButtonList ID="rblPhauThuat" runat="server" RepeatDirection="Horizontal" onchange="hidePhauThuat();">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        </tr>
                    <tr id="PhauThuat">
                        <td><asp:Label ID="Label12" runat="server" Text="1.1 Ngày phẫu thuật:"></asp:Label></td>
                        <td colspan="2"><asp:TextBox runat="server" TabIndex="1" ID="dtNgayPhauThuat"></asp:TextBox></td>
                        <td colspan="3" style="text-align:right!important"><asp:Label ID="Label13" runat="server" Text="1.2 Lý do phẫu thuật:"></asp:Label></td>
                        <td><asp:TextBox runat="server" TabIndex="1" ID="txtLyDoPT" TextMode="MultiLine" style="width:100% !important"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label14" runat="server" Text="2. Đã khám nghiệm tử thi?"></asp:Label></td>
                        <td colspan="4"><asp:RadioButtonList ID="rblKNTT" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                            <td><asp:Label ID="Label15" runat="server" Text="Nếu có khám nghiệm tử thi, kết quả khám nghiệm tử thi có được sử dụng để ghi trong phiếu chẩn đoán NNTV?"></asp:Label></td>
                        <td><asp:RadioButtonList ID="rblSDKQ" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        </tr>
                    <tr>
                        <td><asp:Label ID="Label16" runat="server" Text="3. Hình thức tử vong" Font-Bold="true"></asp:Label></td>
                        <td colspan="6"><asp:RadioButtonList RepeatColumns="3" ID="rblHinhThucTV" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Bệnh</asp:ListItem>  
                                <asp:ListItem>Bị tấn công</asp:ListItem>  
                                <asp:ListItem>Không thể xác định</asp:ListItem>  
                            <asp:ListItem>Tai nạn</asp:ListItem> 
                            <asp:ListItem>Liên quan đến pháp luật (Chấp hành bản án tử hình hoặc bị lực lượng chức năng bắn chết khi phạm tội hoặc do bị trúng đạn...)</asp:ListItem> 
                            <asp:ListItem>Chờ điều tra</asp:ListItem> 
                            <asp:ListItem>Cố ý làm hại bản thân</asp:ListItem> 
                            <asp:ListItem>Chiến tranh</asp:ListItem> 
                            <asp:ListItem>Không biết</asp:ListItem> 
                            </asp:RadioButtonList>  </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label17" runat="server" Text="Thông tin về nguyên nhân bên ngoài của chấn thương hay ngộ độc"></asp:Label></td>
                        <td colspan="2">Ngày bị chấn thương</td>
                        <td>
                                    <asp:TextBox runat="server" TabIndex="1" ID="dtNgayChanThuong"></asp:TextBox>
                                </td>
                        <td colspan="2"><asp:Label ID="Label18" runat="server" Text="Mô tả nguyên nhân bên ngoài dẫn đến chấn thương (Nếu ngộ độc, vui lòng ghi rõ chất gây ngộ độc)"></asp:Label></td>
                        <td><asp:TextBox ID="txtNguyenNhanChanThuong" runat="server" TabIndex="1" Width="100%" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                       <td><asp:Label ID="Label19" runat="server" Text="4. Nơi xảy ra tử vong do nguyên nhân bên ngoài" Font-Bold="true"></asp:Label></td>
                        <td colspan="6"><asp:RadioButtonList RepeatColumns="5" ID="rblNoiTuVong" runat="server" RepeatDirection="Horizontal"  onchange="hideNoiTV();">  
                                <asp:ListItem>Tại nhà</asp:ListItem>  
                                <asp:ListItem>Khu dân cư</asp:ListItem>  
                                <asp:ListItem>Trường học, khu hành chính khác</asp:ListItem>  
                            <asp:ListItem>Khu thể thao</asp:ListItem> 
                            <asp:ListItem>Trên đường đi</asp:ListItem> 
                            <asp:ListItem>Khu thương mại và dịch vụ</asp:ListItem> 
                            <asp:ListItem>Khu công nghiệp</asp:ListItem> 
                            <asp:ListItem>Nông trại</asp:ListItem> 
                            <asp:ListItem>Địa điểm khác</asp:ListItem> 
                            <asp:ListItem>Không biết</asp:ListItem> 
                            </asp:RadioButtonList>  </td>
                    </tr>
                    <tr id="NoiTV">
                        <td><asp:Label ID="Label20" runat="server" Text="Nơi tử vong khác:" Font-Bold="true"></asp:Label></td>
                        <td colspan="6">
                                    <asp:TextBox runat="server" TabIndex="1" ID="txtNoiTV"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label21" runat="server" Text="Tử vong thai nhi hoặc trẻ sơ sinh"></asp:Label></td>
                        <td><asp:Label ID="Label22" runat="server" Text="Đa thai"></asp:Label></td>
                        <td colspan="2"><asp:RadioButtonList ID="rblDaThai" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        <td colspan="2" style="text-align:right!important"><asp:Label ID="Label23" runat="server" Text="Sinh non"></asp:Label></td>
                        <td ><asp:RadioButtonList ID="rblSinhNon" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        </tr>
                    <tr>
                        <td><asp:Label ID="Label24" runat="server" Text="Nếu chết trong vòng 24h, ghi rõ số giờ sống sót sau sinh"></asp:Label></td>
                        <td><asp:TextBox runat="server" TabIndex="1" ID="txtGioSongSauSinh"></asp:TextBox></td>
                        <td colspan="2"><asp:Label ID="Label25" runat="server" Text="Cân nặng khi sinh (gram)"></asp:Label></td>
                        <td><asp:TextBox runat="server" TabIndex="1" ID="txtCanNang"></asp:TextBox></td>
                        <td style="text-align:right!important"><asp:Label ID="Label26" runat="server" Text="Số tuần mang thai"></asp:Label></td>
                        <td><asp:TextBox runat="server" TabIndex="1" ID="txtSoTuanMangThai"></asp:TextBox></td>
                        </tr>
                    <tr>
                        <td><asp:Label ID="Label27" runat="server" Text="Tuổi của mẹ (năm)"></asp:Label></td>
                        <td><asp:TextBox runat="server" TabIndex="1" ID="txtTuoiMe"></asp:TextBox></td>
                        <td colspan="3"><asp:Label ID="Label28" runat="server" Text="Nếu là chết chu sinh, xin vui lòng cho biết tình hình của người mẹ có ảnh hưởng đến thai nhi và trẻ sơ sinh"></asp:Label></td>
                        <td colspan="2"><asp:TextBox runat="server" TabIndex="1" ID="txtChuSinh"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label29" runat="server" Text="Người chết có đang mang thai không?"></asp:Label></td>
                        <td colspan="3"><asp:RadioButtonList ID="rblMangThai" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        <td colspan="3"><asp:RadioButtonList ID="rblThoiDiemMangThai" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Tại thời điểm tử vong</asp:ListItem>  
                                <asp:ListItem>Trong vòng 42 ngày trước khi tử vong</asp:ListItem>  
                                <asp:ListItem>Từ 43 ngày đến 1 năm trước khi chết</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label30" runat="server" Text="Việc mang thai có góp phần gây ra tử vong không?"></asp:Label></td>
                        <td colspan="3"><asp:RadioButtonList ID="rblMangThaiGayTV" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                                <asp:ListItem>Không biết</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label32" runat="server" Text="Tử vong trên đường đi cấp cứu"></asp:Label></td>
                        <td colspan="2"><asp:RadioButtonList ID="rblTVCC" runat="server" RepeatDirection="Horizontal">  
                                <asp:ListItem>Có</asp:ListItem>  
                                <asp:ListItem>Không</asp:ListItem>  
                            </asp:RadioButtonList>  </td>
                        <td><asp:Label ID="Label31" runat="server" Text="Chẩn đoán nguyên nhân chính gây tử vong"></asp:Label></td>
                        <td colspan="4"><telerik:RadComboBox                  runat="server" ID="cbocdravien" DataSourceID="ObjectDanhMucBenh"
                                                     EnableLoadOnDemand="true" DropDownWidth ="470px"
                                                    ItemsPerRequest="20" 
                                                    ShowMoreResultsBox="true"
                                                     ShowDropDownOnTextboxClick="true" CaseSensitive="false"
                                                    EnableAutomaticLoadOnDemand="true" Width ="100%"
                                                  HighlightTemplatedItems="true" 
                                                  MarkFirstMatch="true" 
                                                DataValueField="MaBenhID" 
                                                 DataTextField="MaICDTen"  Filter="Contains"
                                                 OnItemDataBound="cboBenh_ItemDataBound">
                                                  <HeaderTemplate>
                                                        <table class="NHTC_table_layout">
                                                            <tr>
                                                                    <td width="70px">Mã ICD</td>
                                                                    <td width="400px">Tên bệnh</td>
                                                            </tr>
                                                        </table>
                                                    </HeaderTemplate>
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="" Value="" />
                                                    </Items>
                                                    <ItemTemplate>
                                                        <table>
                                                            <tr>
                                                                <td width="70px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "MaICD")%>
                                                                </td>
                                                                <td width="400px">
                                                                    <%# DataBinder.Eval(Container.DataItem, "TenBenh") %>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                            </telerik:RadComboBox></td>
                        
                    </tr>
                </table>
                </div>
        </fieldset>
    <asp:ObjectDataSource EnableCaching="true" CacheExpirationPolicy="Absolute" CacheDuration="600" ID="ObjectDanhMucBenh" runat="server" SelectMethod="FindDMBenhTatByMa"
        TypeName="HTC.Business.CategoryList.DMBenhTatList" EnableViewState="true">
        <SelectParameters>
            <asp:Parameter Name="MaDV" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>--%>
</asp:Content>

