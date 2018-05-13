<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="WebApp04.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	<script id=clientEventHandlersJS language=javascript>
<!--

function btnMsg_onclick() {
alert(txt.value);
}

//-->
</script>
</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="TextBox1" style="Z-INDEX: 101; LEFT: 96px; POSITION: absolute; TOP: 240px" runat="server">1</asp:TextBox><INPUT id="btnMsg" style="Z-INDEX: 108; LEFT: 312px; POSITION: absolute; TOP: 136px" type="button"
				value="Msg" language=javascript onclick="return btnMsg_onclick()"><INPUT id="txt" style="Z-INDEX: 107; LEFT: 304px; POSITION: absolute; TOP: 88px" type="text">
			<asp:Button id="btnReset" style="Z-INDEX: 106; LEFT: 192px; POSITION: absolute; TOP: 280px"
				runat="server" Text="Reset"></asp:Button>
			<asp:TextBox id="TextBox5" style="Z-INDEX: 105; LEFT: 96px; POSITION: absolute; TOP: 168px" runat="server">1</asp:TextBox>
			<asp:TextBox id="TextBox4" style="Z-INDEX: 104; LEFT: 96px; POSITION: absolute; TOP: 128px" runat="server">1</asp:TextBox>
			<asp:TextBox id="TextBox3" style="Z-INDEX: 103; LEFT: 96px; POSITION: absolute; TOP: 88px" runat="server">1</asp:TextBox>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 102; LEFT: 96px; POSITION: absolute; TOP: 200px" runat="server">1</asp:TextBox>
		</form>
	</body>
</HTML>
