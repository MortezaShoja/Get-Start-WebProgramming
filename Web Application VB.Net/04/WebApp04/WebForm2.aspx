<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm2.aspx.vb" Inherits="WebApp04.WebForm2"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm2</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Width="160px" Height="176px">
				<P>Students Info</P>
				<P>
					<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox3" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox4" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox5" runat="server"></asp:TextBox></P>
			</asp:Panel>
			<asp:Button id="Button2" style="Z-INDEX: 104; LEFT: 168px; POSITION: absolute; TOP: 32px" runat="server"
				Text="Address"></asp:Button>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 48px; POSITION: absolute; TOP: 32px" runat="server"
				Text="Info" Width="72px"></asp:Button>
			<asp:Panel id="Panel2" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Width="160px" Height="176px">
				<P>Students Address</P>
				<P>
					<asp:TextBox id="TextBox6" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox7" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox8" runat="server"></asp:TextBox>
					<asp:TextBox id="TextBox9" runat="server"></asp:TextBox></P>
			</asp:Panel>
			<asp:Image id="Image1" style="Z-INDEX: 105; LEFT: 272px; POSITION: absolute; TOP: 64px" runat="server"
				ImageUrl="/webapp04/1.jpg" Width="82px"></asp:Image>
		</form>
	</body>
</HTML>
