<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="HandsOnControls.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	welcome
			<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
			<br />
			<asp:Button ID="Button1" runat="server" Text="LogOut" />
        </div>
    </form>
</body>
</html>
