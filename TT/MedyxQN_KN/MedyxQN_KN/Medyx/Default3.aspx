<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" src="<%: ResolveUrl("~/js/compressed_min/medyx_js_all_min.js") %>"></script>    

     <script language="VBScript">
        sub Print()
            OLECMDID_PRINT = 6
            OLECMDEXECOPT_DONTPROMPTUSER = 2
            OLECMDEXECOPT_PROMPTUSER = 1
            call WB.ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER,1)
        End Sub
        document.write "<object id='WB' width='0' height='0' classid='CLSID:8856F961-340A-11D0-A96B-00C04FD705A2'></object>"
    </script>

    <script type="text/javascript">                    
        $(document).ready(function () {
            
            //window.print(true);            
            print(false);
            window.print(false);
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        NGÀy TẬN THẾ ĐẾN RỒI

    </div>
    </form>
</body>
</html>
