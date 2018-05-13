<%@ Register TagPrefix="uc1" TagName="UC" Src="UC.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="WebAppUC.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:UC id="UC1" runat="server" style="Z-INDEX:103;LEFT:344px;POSITION:absolute;TOP:176px"></uc1:UC>
			<asp:TextBox id="txtN" style="Z-INDEX: 101; LEFT: 464px; POSITION: absolute; TOP: 176px" runat="server"></asp:TextBox>
		</form>
	</body>
</HTML>
