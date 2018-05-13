<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="WebAppVal.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="vb" runat="server">
			sub SVal(sender as object,value  as servervalidateeventargs)
				dim i as int32=int32.parse(value.Value)
				if i mod 2=0
					value.IsValid=true
					exit sub
				else
					value.IsValid=false
				end if
			end sub
			
			sub btnE_OnClick(sender as object,e as eventargs)
					if page.IsValid then
						Label3.Text="Even"
					else
						Label3.Text="odd"
					end if
			end sub
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="txtUN" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 40px" runat="server"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 114; LEFT: 352px; POSITION: absolute; TOP: 168px" runat="server"
				Width="80px">Label</asp:label><asp:customvalidator id="CustomValidator1" style="Z-INDEX: 113; LEFT: 304px; POSITION: absolute; TOP: 216px"
				runat="server" ErrorMessage="Odd" ControlToValidate="txtN" ClientValidationFunction="CVal" OnServerValidate="SVal">Odd</asp:customvalidator><asp:button id="btnE" style="Z-INDEX: 112; LEFT: 176px; POSITION: absolute; TOP: 208px" onclick="btnE_OnClick"
				runat="server" Text="Even"></asp:button><asp:textbox id="txtN" style="Z-INDEX: 111; LEFT: 176px; POSITION: absolute; TOP: 160px" runat="server"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator1" style="Z-INDEX: 110; LEFT: 360px; POSITION: absolute; TOP: 120px"
				runat="server" ErrorMessage="incorrect email" ControlToValidate="txtE" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">email not valid</asp:regularexpressionvalidator><asp:textbox id="txtE" style="Z-INDEX: 109; LEFT: 176px; POSITION: absolute; TOP: 120px" runat="server"></asp:textbox><asp:rangevalidator id="RangeValidator1" style="Z-INDEX: 108; LEFT: 352px; POSITION: absolute; TOP: 80px"
				runat="server" ErrorMessage="out of range" ControlToValidate="txtAge" Type="Integer" MinimumValue="18" MaximumValue="70">incorrect age</asp:rangevalidator><asp:label id="Label2" style="Z-INDEX: 107; LEFT: 104px; POSITION: absolute; TOP: 88px" runat="server">age</asp:label><asp:textbox id="txtAge" style="Z-INDEX: 106; LEFT: 176px; POSITION: absolute; TOP: 80px" runat="server"></asp:textbox><asp:validationsummary id="ValidationSummary1" style="Z-INDEX: 105; LEFT: 504px; POSITION: absolute; TOP: 40px"
				runat="server" ShowMessageBox="True" ShowSummary="False"></asp:validationsummary><asp:requiredfieldvalidator id="RequiredFieldValidator1" style="Z-INDEX: 104; LEFT: 352px; POSITION: absolute; TOP: 40px"
				runat="server" ErrorMessage="error message" ControlToValidate="txtUN">error text</asp:requiredfieldvalidator><asp:button id="btnSubmit" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 296px"
				runat="server" Text="submit"></asp:button><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 96px; POSITION: absolute; TOP: 40px" runat="server">username</asp:label></form>
		<script language="javascript">
			function CVal(source,arguments){
				if(arguments.Value % 2==0){
					arguments.IsValid=true;
				}
				else{
					arguments.IsValid=false;
				}
			}
		</script>
	</body>
</HTML>
