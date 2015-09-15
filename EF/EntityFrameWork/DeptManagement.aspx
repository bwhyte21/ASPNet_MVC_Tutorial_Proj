<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptManagement.aspx.cs" Inherits="EntityFrameWork.DeptManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<table>
				<tr id="trDName">
					<td style="text-align: right">
						<asp:Label ID="lblDName" Text="DeptName" runat="server" />
					</td>
					<td>
						<asp:TextBox ID="txtDName" runat="server" />
					</td>
				</tr>
				<tr id="trHOD">
					<td style="text-align: right">
						<asp:Label ID="lblHOD" Text="HOD" runat="server"/>
					</td>
					<td>
						<asp:TextBox ID="txtHOD" runat="server" />
					</td>
				</tr>
				<tr id="trGender">
					<td style="text-align: right">
						<asp:Label ID="lblGender" Text="Gender" runat="server" />
					</td>
					<td>
						<asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
							<asp:ListItem Value="M" Text="Male" />
							<asp:ListItem Value="F" Text="Female" />
						</asp:RadioButtonList>
					</td>
				</tr>
				<tr id="trIsActive">
					<td style="text-align: right">
						<asp:Label ID="lblIsActive" Text="IsActive" runat="server" />
					</td>
					<td>
						<asp:CheckBox ID="ckbIsActive" runat="server" />
					</td>
				</tr>
				<tr id="trBtns">
					<td style="text-align: right">
						<asp:Button ID="btnCancel" Text="Cancel" runat="server" />
					</td>
					<td>
						<asp:Button ID="btnSave" Text="Save" runat="server" />
						<asp:Button ID="btnUpdate" Text="Update" runat="server" />
						<asp:Button ID="btnDelete" Text="Delete" runat="server" />
					</td>
				</tr>
			</table>
		</div>
	</form>
</body>
</html>