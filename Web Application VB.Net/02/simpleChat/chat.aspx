<%@ Page Language="vb" AutoEventWireup="false" Codebehind="chat.aspx.vb" Inherits="simpleChat.chat"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>chat</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtMSG" style="Z-INDEX: 101; LEFT: 400px; POSITION: absolute; TOP: 96px" runat="server"
				TextMode="MultiLine" Height="120px"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 400px; POSITION: absolute; TOP: 56px" runat="server"
				Height="16px">To</asp:Label>
			<asp:DropDownList id="ddlUN" style="Z-INDEX: 103; LEFT: 472px; POSITION: absolute; TOP: 56px" runat="server"
				Width="112px"></asp:DropDownList>
			<asp:Button id="btnSend" style="Z-INDEX: 102; LEFT: 400px; POSITION: absolute; TOP: 232px" runat="server"
				Text="Send"></asp:Button>
		</form>
	</body>
</HTML>
