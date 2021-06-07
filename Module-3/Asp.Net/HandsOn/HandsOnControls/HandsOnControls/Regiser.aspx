<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regiser.aspx.cs" Inherits="HandsOnControls.Regiser" %>

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
					<td>Name *</td>
					<td>
						<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Pls Enter Name"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Gendar</td>
					<td>
						<asp:RadioButton ID="rbtMale" runat="server" GroupName="G" Text="Male" />
						<br />
						<asp:RadioButton ID="rbtFemale" runat="server" GroupName="G" Text="Female" />
					</td>
				</tr>
				<tr>
					<td>Age</td>
					<td>
						<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
						<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age between 18 to 60" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
					</td>
				</tr>
				<tr>
					<td>EmailID</td>
					<td>
						<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid EmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td>ContactNo</td>
					<td>
						<asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtContact" ErrorMessage="Invalid MobileNo" ValidationExpression="[6789]\d{9}"></asp:RegularExpressionValidator>
						<br />
						<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtContact" ErrorMessage="Pls Enter Mobile No"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Country</td>
					<td>
						<asp:DropDownList ID="ddlCountry" runat="server">
							<asp:ListItem></asp:ListItem>
							<asp:ListItem>India</asp:ListItem>
							<asp:ListItem>US</asp:ListItem>
							<asp:ListItem>Uk</asp:ListItem>
							<asp:ListItem>China</asp:ListItem>
							<asp:ListItem>Japan</asp:ListItem>
						</asp:DropDownList>
					</td>
				</tr>
				<tr>
					<td>Username*</td>
					<td>
						<asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUname" ErrorMessage="Pls Enter Username"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Password*</td>
					<td>
						<asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="Pls Enter Password"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Confirm Password</td>
					<td>
						<asp:TextBox ID="txtCpwd" runat="server"></asp:TextBox>
						<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtCpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:CheckBox ID="CheckBox1" runat="server" Text="Accept all terms and conditions" />
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Register" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="lblMsg" runat="server"></asp:Label>
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
