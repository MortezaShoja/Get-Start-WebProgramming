Public Class WebForm6
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents chk As System.Web.UI.WebControls.CheckBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

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
        If Request.Browser.Cookies Then
            If Not Request.Cookies("u") Is Nothing Then
                TextBox1.Text = Request.Cookies("u").Value.ToString
                TextBox1.ReadOnly = True
                TextBox1.BorderStyle = BorderStyle.None
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Request.Browser.Cookies Then
            If chk.Checked = True Then
                Dim c As New HttpCookie("u", TextBox1.Text)
                c.Expires = Now.AddMonths(1)
                Response.Cookies.Add(c)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Request.Browser.Cookies Then
            If Not Request.Cookies("u") Is Nothing Then
                Dim c As New HttpCookie("u", 1)
                c.Expires = Now.AddMonths(-2)
                Response.Cookies.Add(c)
            End If
        End If
    End Sub
End Class
