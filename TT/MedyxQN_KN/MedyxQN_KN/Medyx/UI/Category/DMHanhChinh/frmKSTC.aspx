
<%@ Page Language="C#" AutoEventWireup="true" Codefile="frmKSTC.cs" Inherits="frmKSTC" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>KÝ SỐ TẬP CHUNG </title>


    <script src="../../../JS%20-%20KSTC/vgcaplugin.js"></script>
        <script type="text/javascript">

            function SignFileCallBack1(rv) {
                var received_msg = JSON.parse(rv);
                console.log(received_msg);
                if (received_msg.Status == 0) {
                    //console.log(received_msg);
                    document.getElementById("_signature").value = received_msg.FileName + ":" + received_msg.FileServer + ":" + received_msg.DocumentNumber + ":" + received_msg.DocumentDate;
                    document.getElementById("file1").value = received_msg.FileServer;
                    document.getElementById("file2").value = received_msg.FileServer;
                } else {
                    document.getElementById("_signature").value = received_msg.Message;
                }
            }

            function exc_sign_issued() {
                var prms = {};

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = "http://localhost:8084/(S(0ln03fvqxyjyyftgy1oj3mvr))/UI/QLHSBA/tem/1114/000000192.1.0.40CRgiaychungsinh.rptfrmGiayChungSinh.aspx.pdf";
                prms["DocNumber"] = "123";
                prms["IssuedDate"] = "2019-03-12T12:00:00+07:00";

                var json_prms = JSON.stringify(prms);
                vgca_sign_issued(json_prms, SignFileCallBack1);

            }
            
            function exc_sign_approved(url) {
                var prms = {};

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = "http://localhost:8084/(S(0ln03fvqxyjyyftgy1oj3mvr))/UI/QLHSBA/tem/1114/000000192.1.0.40CRgiaychungsinh.rptfrmGiayChungSinh.aspx.pdf";

                var json_prms = JSON.stringify(prms);
                vgca_sign_approved(json_prms, SignFileCallBack1);

            }

            function exc_sign_income(url) {
                var prms = {};
                var scv = [{ "Key": "abc", "Value": "abc" }];

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = "http://localhost:8084/(S(0ln03fvqxyjyyftgy1oj3mvr))/UI/QLHSBA/tem/1114/000000192.1.0.40CRgiaychungsinh.rptfrmGiayChungSinh.aspx.pdf";
                prms["MetaData"] = scv;

                var json_prms = JSON.stringify(prms);
                vgca_sign_income(json_prms, SignFileCallBack1);
            }

            function exc_comment(url) {
                var prms = {};
                var scv = [{ "Key": "abc", "Value": "abc" }];

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = url;
                prms["MetaData"] = scv;

                var json_prms = JSON.stringify(prms);
                vgca_comment(json_prms, SignFileCallBack1);
            }

            function exc_appendix(url) {
                var prms = {};
                var scv = [{ "Key": "abc", "Value": "abc" }];

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = "";
                prms["DocNumber"] = "123/BCY-CTSBMTT";
                prms["MetaData"] = scv;

                var json_prms = JSON.stringify(prms);
                vgca_sign_appendix(json_prms, SignFileCallBack1);
            }

            function exc_sign_copy(url) {
                var prms = {};
                var scv = [{ "Key": "abc", "Value": "abc" }];

                prms["FileUploadHandler"] = "http://localhost:8084/(S(ulfe2dtjcziaquws3eji4hsl))/UI/Category/DMHanhChinh/FileUploadHandler.aspx";
                prms["SessionId"] = "";//xác thực cookies
                prms["JWTToken"] = "";//xác thực jwt token
                prms["FileName"] = "";
                prms["DocNumber"] = "123/BCY-CTSBMTT";
                prms["MetaData"] = scv;

                var json_prms = JSON.stringify(prms);
                vgca_sign_copy(json_prms, SignFileCallBack1);
            }

            function exc_sign_files() {

                //format lại chuỗi JSON
                var txt = document.getElementById("_txtfiles").value;
                var prms = JSON.parse(txt);
                var json_prms = JSON.stringify(prms);

                console.log(json_prms);

                vgca_sign_files(json_prms, SignFileCallBack1);
            }
        </script>

</head>
<body>
    <form id="message_form" runat="server">

        <div id="page-wrapper">
            <h1 style =" margin-left : 650px">KÝ SỐ TẬP CHUNG</h1>

            <p style =" margin-left : 555px"><textarea id="_signature" cols="60" rows="20" readonly ></textarea></p>

            <p style =" margin-left : 555px">
                <button type="button" id="_Config" onclick="vgca_show_config();">Show config</button> <br />
            </p>
            <div>

                <p>
                    <h3 style =" margin-left : 555px">Lãnh đạo ký phê duyệt:</h3>
                    <input style =" margin-left : 555px" type="text" id="file1" size="64" />
                    <button style =" margin-left : 555px" type="button" id="_lanhdaoPheduyet" onclick="exc_sign_approved();">Ký phê duyệt</button> 
                </p>
               

               <%-- <p>
                    <h3>Văn thư ký phát hành:</h3>
                    <input type="text" id="file2" size="50" />
                    <button type="button" id="_vanthuphathanh" onclick="exc_sign_issued();">Đóng dấu Phát Hành</button>
                </p>
                <p>
                    <h3>Văn thư ký công văn đến:</h3>
                    <input type="text" id="file3" size="50" />
                    <button type="button" id="_vanthukycongvanden" onclick="exc_sign_income();">Ký số công văn đến</button>
                </p>--%>
<%--                <p>
                    <h3>Comment:</h3>
                    <input type="text" id="file3" size="50" />
                    <button type="button" id="_comment" onclick="exc_comment('');">Add Comment</button>
                </p>--%>

               <%-- <p>
                    <h3>Phụ lục/ Đính kèm:</h3>
                    <input type="text" id="file3" size="50" />
                    <button type="button" id="_comment" onclick="exc_appendix();">Ký tài liệu đính kèm</button>
                </p>
                <p>
                    <h3>Ký số Bản sao điện tử:</h3>
                    <input type="text" id="file3" size="50" />
                    <button type="button" id="_Sacomment" onclick="exc_sign_copy();">Sao văn bản điện tử</button>
                </p>
                <p>
                    <h3>Ký số nhiều tệp:</h3>
                <p><textarea id="_txtfiles" cols="80" rows="10"></textarea></p>
                <button type="button" id="_SignFiles" onclick="exc_sign_files();">Ký Danh sách tệp!</button>
                </p>--%>
            </div>


        </div>
    </form>
</body>
</html>
