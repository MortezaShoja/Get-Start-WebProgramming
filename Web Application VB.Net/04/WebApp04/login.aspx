<%@ Page Language="vb" AutoEventWireup="false" Codebehind="login.aspx.vb" Inherits="WebApp04.login"%>
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
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtUN" style="Z-INDEX: 101; LEFT: 40px; POSITION: absolute; TOP: 80px" runat="server"></asp:TextBox>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 152px" runat="server"
				Text="login" Width="65px"></asp:Button>
			<asp:TextBox id="txtPWD" style="Z-INDEX: 102; LEFT: 40px; POSITION: absolute; TOP: 112px" runat="server"></asp:TextBox>
		</form>
	</body>
</HTML>
