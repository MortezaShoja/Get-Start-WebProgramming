<%@ Page Language="vb" AutoEventWireup="false" Codebehind="load.aspx.vb" Inherits="PhotoGallary.load"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>load</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server" style="FONT-SIZE: 9pt; FONT-FAMILY: Tahoma">
			<asp:TextBox id="txtDP" style="Z-INDEX: 101; LEFT: 216px; POSITION: absolute; TOP: 120px" runat="server"
				BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox><INPUT id="fld" style="Z-INDEX: 117; LEFT: 112px; POSITION: absolute; TOP: 528px; HEIGHT: 22px"
				type="file" size="16" name="File1" runat="server">
			<asp:Button id="btnU" style="Z-INDEX: 116; LEFT: 272px; POSITION: absolute; TOP: 568px" runat="server"
				Text="Upload" BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt"></asp:Button>
			<asp:Calendar id="cld" style="Z-INDEX: 115; LEFT: 400px; POSITION: absolute; TOP: 440px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt"></asp:Calendar>
			<asp:TextBox id="txtN" style="Z-INDEX: 114; LEFT: 208px; POSITION: absolute; TOP: 448px" runat="server"
				BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:TextBox id="txtD" style="Z-INDEX: 113; LEFT: 208px; POSITION: absolute; TOP: 488px" runat="server"
				BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 488px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Description</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 110; LEFT: 112px; POSITION: absolute; TOP: 456px" runat="server"
				Font-Names="Tahoma" Font-Size="9pt">Name</asp:Label>
			<asp:Button id="Button5" style="Z-INDEX: 109; LEFT: 184px; POSITION: absolute; TOP: 760px" runat="server"
				Text="Button"></asp:Button>
			<asp:DataGrid id=dbgU style="Z-INDEX: 108; LEFT: 88px; POSITION: absolute; TOP: 200px" runat="server" BorderStyle="None" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt" BorderColor="#DEBA84" CellSpacing="2" BackColor="#DEBA84" CellPadding="3" DataSource="<%# DsU1 %>" DataMember="users" AutoGenerateColumns="False">
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="UID">
						<ItemTemplate>
							<asp:Label id=lblEUID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.UID") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="PWD">
						<ItemTemplate>
							<asp:Label id="Label5" runat="server"></asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id="txtEPWD" runat="server" TextMode="Password"></asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="DP">
						<ItemTemplate>
							<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DP") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=txtEDP runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DP") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<ItemTemplate>
							<asp:Button id="Button1" runat="server" Text="Delete" BorderStyle="Solid" BorderWidth="1px"
								Font-Names="Tahoma" Font-Size="9pt" CausesValidation="false" CommandName="Delete"></asp:Button>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<ItemTemplate>
							<asp:Button id="Button2" runat="server" Text="Edit" BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma"
								Font-Size="9pt" CausesValidation="false" CommandName="Edit"></asp:Button>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:Button id="Button4" runat="server" Text="Update" BorderStyle="Solid" BorderWidth="1px"
								Font-Names="Tahoma" Font-Size="9pt" CommandName="Update"></asp:Button>&nbsp;
							<asp:Button id="Button3" runat="server" Text="Cancel" BorderStyle="Solid" BorderWidth="1px"
								Font-Names="Tahoma" Font-Size="9pt" CausesValidation="false" CommandName="Cancel"></asp:Button>
						</EditItemTemplate>
					</asp:TemplateColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Label id="Label3" style="Z-INDEX: 107; LEFT: 88px; POSITION: absolute; TOP: 120px" runat="server">Default Page</asp:Label>
			<asp:TextBox id="txtUID" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 56px" runat="server"
				BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 105; LEFT: 88px; POSITION: absolute; TOP: 56px" runat="server">Username</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 88px; POSITION: absolute; TOP: 88px" runat="server">Password</asp:Label>
			<asp:Button id="btnA" style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 160px" runat="server"
				Text="Add" BorderStyle="Solid" BorderWidth="1px"></asp:Button>
			<asp:TextBox id="txtPWD" style="Z-INDEX: 102; LEFT: 216px; POSITION: absolute; TOP: 88px" runat="server"
				BorderStyle="Solid" BorderWidth="1px" Font-Names="Tahoma" Font-Size="9pt" TextMode="Password"></asp:TextBox>
		</form>
	</body>
</HTML>
