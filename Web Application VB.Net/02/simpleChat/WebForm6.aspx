<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm6.aspx.vb" Inherits="simpleChat.WebForm6"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm6</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="TextBox1" style="Z-INDEX: 101; LEFT: 280px; POSITION: absolute; TOP: 40px" runat="server"></asp:TextBox>
			<asp:Button id="Button2" style="Z-INDEX: 106; LEFT: 376px; POSITION: absolute; TOP: 176px" runat="server"
				Text="sign Out -->"></asp:Button>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 105; LEFT: 280px; POSITION: absolute; TOP: 72px" runat="server"
				TextMode="Password" Width="152px"></asp:TextBox>
			<asp:CheckBox id="chk" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 136px" runat="server"
				Text="Remember Me"></asp:CheckBox>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 288px; POSITION: absolute; TOP: 176px" runat="server"
				Text="Button"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 208px; POSITION: absolute; TOP: 40px" runat="server">Label</asp:Label>
		</form>
	</body>
</HTML>
