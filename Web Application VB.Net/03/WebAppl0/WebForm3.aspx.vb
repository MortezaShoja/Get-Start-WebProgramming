Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Response.Write("<h1>test</h1><br><h2>new</h2>")
        Response.Write("<input type=button value='click'/>")
        'Response.Write("<script language=javascript>alert('test')</script>")
        'Page.RegisterClientScriptBlock("sample", "<script language=javascript>alert('test')</script>")
        ' Page.RegisterStartupScript("test", "<script language=javascript>alert('test1')</script>")

        Dim c As New Web.UI.HtmlControls.HtmlInputText
        c.Value = ""

        Me.Controls.Add(c)
    End Sub

End Class
