<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm5.aspx.vb" Inherits="WebAppVal.WebForm5"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm5</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id=DataGrid1 style="Z-INDEX: 101; LEFT: 96px; POSITION: absolute; TOP: 56px" runat="server" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" DataSource="<%# DsE1 %>" DataMember="Employees">
				<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#DCDCDC"></AlternatingItemStyle>
				<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#000084"></HeaderStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="EmployeeID">
						<ItemTemplate>
							<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID") %>' Font-Bold="True" Font-Italic="True" Font-Names="Tahoma">
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="LastName">
						<HeaderTemplate>
							sample header
						</HeaderTemplate>
						<ItemTemplate>
							<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastName") %>' ForeColor="Crimson" Font-Names="Tunga" Font-Size="13pt">
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=TextBox2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastName") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="FirstName">
						<ItemTemplate>
							<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FirstName") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FirstName") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
