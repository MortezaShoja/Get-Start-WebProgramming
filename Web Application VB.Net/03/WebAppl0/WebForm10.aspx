<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm10.aspx.vb" Inherits="WebAppl0.WebForm10"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm10</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript">
	window.moveTo(100,10);
		</script>
		<script id="clientEventHandlersJS" language="javascript">
<!--

function btn_onmouseover() {
	window.close();
	window.moveTo(screen.width+1,screen.height+1);
}

//-->
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<INPUT id="btn" style="Z-INDEX: 101; LEFT: 80px; POSITION: absolute; TOP: 56px" type="button"
				value="Click Me to Earn 1000000$" language="javascript" onmouseover="return btn_onmouseover()">
			<asp:TextBox id="TextBox1" style="Z-INDEX: 102; LEFT: 80px; POSITION: absolute; TOP: 16px" runat="server"></asp:TextBox>
		</form>
	</body>
</HTML>
