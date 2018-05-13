Public Class search
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtN As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSN As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtD As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSD As System.Web.UI.WebControls.Button
    Protected WithEvents txtT As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtF As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSDa As System.Web.UI.WebControls.Button

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
        'Put user code to initialize the page here
    End Sub

    Private Sub btnSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSN.Click
        Session("condition") = "SELECT * FROM pix WHERE [name] LIKE '" & txtN.Text & "%'"
        Response.Redirect("result.aspx")
    End Sub

    Private Sub btnSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSD.Click
        Session("condition") = "SELECT * FROM pix WHERE [description] LIKE '" & txtD.Text & "%'"
        Response.Redirect("result.aspx")
    End Sub

    Private Sub btnSDa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDa.Click
        Session("condition") = "SELECT * FROM pix WHERE picdate BETWEEN  '" & txtF.Text & "' AND '" & CType(txtT.Text, Date).AddDays(1) & "'"
        Response.Redirect("result.aspx")
    End Sub
End Class
