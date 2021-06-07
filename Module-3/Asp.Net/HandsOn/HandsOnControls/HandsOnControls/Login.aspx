<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HandsOnControls.Login" %>

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
					<td>Username</td>
					<td>
						<asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUname" ErrorMessage="Pls Ener Name"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Password</td>
					<td>
						<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="Pls Enter Password"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Button ID="Button1" runat="server" Text="SingIn" OnClick="Validate" />
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Regiser.aspx">SignUp</asp:HyperLink>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
					</td>
				</tr>
			</table>
        </div>
    	
    </form>
</body>

</html>
