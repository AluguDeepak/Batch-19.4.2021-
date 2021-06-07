<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="MyFirstApp.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 50%;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<table align="center" class="auto-style1">
				<tr>
					<td>Enter Name</td>
					<td>
						<asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
						<asp:Button ID="BtnClick" runat="server" BackColor="#FF6600" ForeColor="White" Text="ClickMe" OnClick="BtnClick_Click"   />
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Label ID="LblMsg" runat="server"></asp:Label>
					</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
