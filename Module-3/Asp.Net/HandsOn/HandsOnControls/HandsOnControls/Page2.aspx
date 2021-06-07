<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="HandsOnControls.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Welcome
			<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    	<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Page1.aspx">Back</asp:HyperLink>
    </form>
</body>
</html>
