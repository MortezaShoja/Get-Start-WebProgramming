<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm4.aspx.vb" Inherits="WebAppVal.WebForm4"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm4</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtCMD" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 24px" runat="server"
				TextMode="MultiLine" Height="88px"></asp:TextBox>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 32px" runat="server"
				Text="!"></asp:Button>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 102; LEFT: 56px; POSITION: absolute; TOP: 144px"
				runat="server" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White"
				CellPadding="3" GridLines="Vertical" ForeColor="Black">
				<FooterStyle BackColor="#CCCCCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
				<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
