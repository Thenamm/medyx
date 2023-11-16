<%@ Page Title="" Language="C#"  MasterPageFile="~/AdminCode.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="abc_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to save data?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Raise Confirm" OnClientClick="Confirm()" />
</asp:Content>

