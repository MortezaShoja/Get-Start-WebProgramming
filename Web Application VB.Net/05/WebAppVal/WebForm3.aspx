<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm3.aspx.vb" Inherits="WebAppVal.WebForm3"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 72px; POSITION: absolute; TOP: 48px" runat="server"
				BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" BackColor="White"
				CellPadding="3" GridLines="None">
				<FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
				<ItemStyle Wrap="False" ForeColor="Black" Width="300px" BackColor="#DEDFDE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
