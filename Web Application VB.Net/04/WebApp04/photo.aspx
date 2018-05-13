<%@ Page Language="vb" AutoEventWireup="false" Codebehind="photo.aspx.vb" Inherits="WebApp04.photo"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>photo</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<INPUT id="fld" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" type="file"
				runat="server">
			<asp:button id="btn" style="Z-INDEX: 105; LEFT: 72px; POSITION: absolute; TOP: 40px" runat="server"
				Text="View" Width="67px"></asp:button><asp:image id="img" style="Z-INDEX: 104; LEFT: 40px; POSITION: absolute; TOP: 192px" runat="server"></asp:image><asp:dropdownlist id="ddlI" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server"
				Width="224px" AutoPostBack="True"></asp:dropdownlist><asp:button id="btnU" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
				Text="Upload" Width="77px"></asp:button></form>
	</body>
</HTML>
