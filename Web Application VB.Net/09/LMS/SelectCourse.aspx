<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SelectCourse.aspx.vb" Inherits="LMS.SelectCourse"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SelectCourse</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id=ddlC style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 24px" runat="server" Width="176px" DataSource="<%# DsC1 %>" DataMember="Courses" DataTextField="Title" DataValueField="CID">
			</asp:DropDownList>
			<asp:DataGrid id=dbgL style="Z-INDEX: 103; LEFT: 56px; POSITION: absolute; TOP: 64px" runat="server" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" DataSource="<%# DsL1 %>" DataMember="Lessons" AutoGenerateColumns="False">
				<FooterStyle BackColor="Tan"></FooterStyle>
				<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="LID" SortExpression="LID" ReadOnly="True" HeaderText="LID"></asp:BoundColumn>
					<asp:BoundColumn DataField="Title" SortExpression="Title" HeaderText="Title"></asp:BoundColumn>
					<asp:BoundColumn DataField="Duration" SortExpression="Duration" HeaderText="Duration"></asp:BoundColumn>
					<asp:TemplateColumn>
						<ItemTemplate>
							<asp:Button id="Button1" runat="server" Text="Select" BorderColor="Crimson" BorderWidth="1px"
								BackColor="MistyRose" CausesValidation="false" CommandName="Select" BorderStyle="Solid"></asp:Button>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
			</asp:DataGrid>
			<asp:Button id="btnV" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 24px" runat="server"
				Text="View"></asp:Button>
		</form>
	</body>
</HTML>
