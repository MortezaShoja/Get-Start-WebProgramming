<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm3.aspx.vb" Inherits="WebApplication1.WebForm3"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
    <title>WebForm3</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
            <script language=javascript>
            window.status='welcome';
            var i=0;
            var j=0;
		setTimeout("msg()",500);
		function msg(){
			if(i<20){
			window.status=' '+window.status;
			i++;
			}
			else{
				if(j<8){
					if(j=0){
						window.status=' '+window.status;
					}
				}
			}
			setTimeout("msg()",500);
		}
    </script>
  </head>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">

    </form>

  </body>
</html>
