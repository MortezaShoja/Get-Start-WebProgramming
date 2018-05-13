<%@ Page Language="vb" AutoEventWireup="false" Codebehind="search.aspx.vb" Inherits="PhotoGallary.search"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>search</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server" style="FONT-FAMILY: Tahoma">
			<asp:TextBox id="txtT" style="Z-INDEX: 101; LEFT: 184px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Label id="Label5" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 224px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Name</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 192px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Description</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 110; LEFT: 128px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Date</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">From</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 108; LEFT: 128px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">To</asp:Label>
			<asp:Button id="btnSN" style="Z-INDEX: 107; LEFT: 336px; POSITION: absolute; TOP: 224px" runat="server"
				Text="Search" Font-Names="Tahoma" Font-Size="9pt"></asp:Button>
			<asp:TextBox id="txtN" style="Z-INDEX: 106; LEFT: 184px; POSITION: absolute; TOP: 224px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:TextBox id="txtD" style="Z-INDEX: 105; LEFT: 184px; POSITION: absolute; TOP: 192px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Button id="btnSD" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 192px" runat="server"
				Text="Search" Font-Names="Tahoma" Font-Size="9pt"></asp:Button>
			<asp:TextBox id="txtF" style="Z-INDEX: 103; LEFT: 184px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Button id="btnSDa" style="Z-INDEX: 102; LEFT: 336px; POSITION: absolute; TOP: 152px" runat="server"
				Text="Search" Font-Names="Tahoma" Font-Size="9pt"></asp:Button>
		</form>
	</body>
</HTML>
