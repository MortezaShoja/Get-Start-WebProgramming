<%@ Page Language="vb" AutoEventWireup="false" Codebehind="login.aspx.vb" Inherits="PhotoGallary.login"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>login</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server" style="FONT-SIZE: 9pt; FONT-FAMILY: Tahoma">
			<asp:TextBox id="txtPWD" style="Z-INDEX: 101; LEFT: 144px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt" BorderStyle="Solid" BorderWidth="1px" TextMode="Password"></asp:TextBox>
			<asp:Button id="btnL" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 160px" runat="server"
				Text="LogIn" Font-Names="Tahoma" Font-Size="9pt" BorderStyle="Solid" BorderWidth="1px"></asp:Button>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 56px; POSITION: absolute; TOP: 128px" runat="server">Password</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 56px; POSITION: absolute; TOP: 88px" runat="server">Username</asp:Label>
			<asp:TextBox id="txtUID" style="Z-INDEX: 102; LEFT: 144px; POSITION: absolute; TOP: 88px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
		</form>
	</body>
</HTML>
