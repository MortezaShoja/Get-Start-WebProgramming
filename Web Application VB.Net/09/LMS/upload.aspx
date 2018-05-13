<%@ Page Language="vb" AutoEventWireup="false" Codebehind="upload.aspx.vb" Inherits="LMS.upload"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>upload</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id=ddlC style="Z-INDEX: 100; LEFT: 160px; POSITION: absolute; TOP: 40px" runat="server" Width="176px" Font-Names="Tahoma" Font-Size="9pt" DataSource="<%# DsUC1 %>" DataMember="Courses" DataTextField="Title" DataValueField="CID">
			</asp:DropDownList>
			<asp:Label id="Label3" style="Z-INDEX: 108; LEFT: 104px; POSITION: absolute; TOP: 104px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Duration</asp:Label>
			<asp:TextBox id="txtD" style="Z-INDEX: 107; LEFT: 160px; POSITION: absolute; TOP: 104px" runat="server"
				Width="176px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox><INPUT id="fld" style="Z-INDEX: 106; LEFT: 160px; WIDTH: 176px; POSITION: absolute; TOP: 176px; HEIGHT: 22px"
				type="file" size="10" runat="server">
			<asp:Button id="btnU" style="Z-INDEX: 105; LEFT: 280px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt" Text="Upload"></asp:Button>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 104px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Lesson</asp:Label>
			<asp:TextBox id="txtL" style="Z-INDEX: 103; LEFT: 160px; POSITION: absolute; TOP: 72px" runat="server"
				Width="176px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 104px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Course</asp:Label>
		</form>
	</body>
</HTML>
