<%@ Page Language="vb" AutoEventWireup="false" Codebehind="index.aspx.vb" Inherits="WebPhone.index"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>index</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:LinkButton id="lnkVA" style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 48px" runat="server">View All</asp:LinkButton>
			<asp:LinkButton id="lnkS" style="Z-INDEX: 110; LEFT: 24px; POSITION: absolute; TOP: 192px" runat="server">Search</asp:LinkButton>
			<asp:Panel id="pnlS" style="Z-INDEX: 109; LEFT: 200px; POSITION: absolute; TOP: 48px" runat="server"
				Width="248px" Height="152px" Visible="False" BackColor="LightGray" Font-Names="Tahoma"
				Font-Size="9pt">
				<P>&nbsp;Find</P>
				<P>Family
					<asp:TextBox id="txtSF" runat="server" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox></P>
				<P>Name
					<asp:TextBox id="txtSN" runat="server" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox></P>
				<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button id="btnF" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
						Font-Names="Tahoma" Font-Size="9pt" Text="Find" BorderStyle="Solid"></asp:Button></P>
				<P>
					<asp:DataGrid id="dbgF" runat="server" Width="256px" Height="152px" Visible="False" BorderColor="Tan"
						BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black"
						Font-Names="Tahoma" Font-Size="9pt">
						<FooterStyle BackColor="Tan"></FooterStyle>
						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
						<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" BackColor="Tan"></HeaderStyle>
						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
					</asp:DataGrid></P>
			</asp:Panel>
			<asp:Panel id="pnlU" style="Z-INDEX: 108; LEFT: 200px; POSITION: absolute; TOP: 48px" runat="server"
				Width="248px" Height="152px" Visible="False" BackColor="LightGray" Font-Names="Tahoma"
				Font-Size="9pt">&nbsp;Update 
<P>
					<asp:DataGrid id=dbgU runat="server" Width="256px" Height="152px" Visible="False" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" DataSource="<%# DsU1 %>" DataMember="phones" AutoGenerateColumns="False" Font-Names="Tahoma" Font-Size="9pt">
						<FooterStyle BackColor="Tan"></FooterStyle>
						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
						<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" BackColor="Tan"></HeaderStyle>
						<Columns>
							<asp:BoundColumn Visible="False" DataField="ID" SortExpression="ID" ReadOnly="True" HeaderText="ID"></asp:BoundColumn>
							<asp:TemplateColumn HeaderText="Family">
								<ItemTemplate>
									<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Family") %>'>
									</asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:TextBox id=txtFa runat="server" Width="72px" Font-Names="Tahoma" Font-Size="9pt" Text='<%# DataBinder.Eval(Container, "DataItem.Family") %>'>
									</asp:TextBox>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Name">
								<ItemTemplate>
									<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>'>
									</asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:TextBox id=txtNa runat="server" Width="56px" Font-Names="Tahoma" Font-Size="9pt" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>'>
									</asp:TextBox>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Phone">
								<ItemTemplate>
									<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Phone") %>'>
									</asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:TextBox id=txtPh runat="server" Width="56px" Font-Names="Tahoma" Font-Size="9pt" Text='<%# DataBinder.Eval(Container, "DataItem.Phone") %>'>
									</asp:TextBox>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:Button id="Button2" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
										Font-Names="Tahoma" Font-Size="9pt" CausesValidation="false" CommandName="Edit" Text="Edit"
										BorderStyle="Solid"></asp:Button>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:Button id="Button4" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
										Font-Names="Tahoma" Font-Size="9pt" CommandName="Update" Text="Update" BorderStyle="Solid"></asp:Button>&nbsp;
									<asp:Button id="Button3" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
										Font-Names="Tahoma" Font-Size="9pt" CausesValidation="false" CommandName="Cancel" Text="Cancel"
										BorderStyle="Solid"></asp:Button>
								</EditItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
					</asp:DataGrid></P></asp:Panel>
			<asp:Panel id="pnlI" style="Z-INDEX: 107; LEFT: 200px; POSITION: absolute; TOP: 48px" runat="server"
				Width="248px" Height="152px" Visible="False" BackColor="LightGray" Font-Names="Tahoma"
				Font-Size="9pt">&nbsp;Add Phone 
<P>&nbsp;Family
					<asp:TextBox id="txtF" runat="server" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox></P>
<P>&nbsp;Name
					<asp:TextBox id="txtN" runat="server" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox></P>
<P>&nbsp;Phone
					<asp:TextBox id="txtP" runat="server" Font-Names="Tahoma" Font-Size="9pt"></asp:TextBox></P>
<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button id="btnAdd" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
						Font-Names="Tahoma" Font-Size="9pt" Text="Add" BorderStyle="Solid"></asp:Button></P>
<P>
					<asp:DataGrid id=dbgI runat="server" Width="256px" Height="152px" Visible="False" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" DataSource="<%# DsI1 %>" DataMember="phones" Font-Names="Tahoma" Font-Size="9pt">
						<FooterStyle BackColor="Tan"></FooterStyle>
						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
						<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" BackColor="Tan"></HeaderStyle>
						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
					</asp:DataGrid></P></asp:Panel>
			<asp:Panel id="pnlD" style="Z-INDEX: 106; LEFT: 200px; POSITION: absolute; TOP: 48px" runat="server"
				Width="248px" Height="152px" Visible="False" BackColor="Gainsboro" Font-Names="Tahoma"
				Font-Size="8pt">&nbsp;Delete Phone 
<P>
					<asp:DataGrid id=dbgD runat="server" Width="256px" Height="152px" Visible="False" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" DataSource="<%# DsD1 %>" DataMember="phones" AutoGenerateColumns="False" Font-Names="Tahoma" Font-Size="9pt">
						<FooterStyle BackColor="Tan"></FooterStyle>
						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
						<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" BackColor="Tan"></HeaderStyle>
						<Columns>
							<asp:BoundColumn Visible="False" DataField="ID" SortExpression="ID" ReadOnly="True" HeaderText="ID"></asp:BoundColumn>
							<asp:BoundColumn DataField="Family" SortExpression="Family" HeaderText="Family"></asp:BoundColumn>
							<asp:BoundColumn DataField="Name" SortExpression="Name" HeaderText="Name"></asp:BoundColumn>
							<asp:BoundColumn DataField="Phone" SortExpression="Phone" HeaderText="Phone"></asp:BoundColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:Button id="Button1" runat="server" BorderColor="Black" BorderWidth="1px" BackColor="DarkGray"
										Font-Names="Tahoma" Font-Size="9pt" CausesValidation="false" CommandName="Delete" Text="Delete"
										BorderStyle="Solid"></asp:Button>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
					</asp:DataGrid></P></asp:Panel>
			<asp:LinkButton id="lnkU" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 152px" runat="server">Update</asp:LinkButton>
			<asp:LinkButton id="lnkA" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 112px" runat="server">Add Phone</asp:LinkButton>
			<asp:LinkButton id="lnkD" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 80px" runat="server">Delete Phone</asp:LinkButton>
			<asp:Panel id="pnlVA" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 48px" runat="server"
				Width="248px" Height="152px" Visible="False" BackColor="LightGray" Font-Names="Tahoma"
				Font-Size="9pt">
				<P>View All</P>
				<P>
					<asp:DataGrid id=dbgVA runat="server" Width="256px" Height="152px" Visible="False" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" DataSource="<%# DsVA1 %>" DataMember="phones" Font-Names="Tahoma" Font-Size="9pt">
						<FooterStyle BackColor="Tan"></FooterStyle>
						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
						<HeaderStyle Font-Size="9pt" Font-Names="Tahoma" Font-Bold="True" BackColor="Tan"></HeaderStyle>
						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
					</asp:DataGrid></P>
			</asp:Panel>
		</form>
	</body>
</HTML>
