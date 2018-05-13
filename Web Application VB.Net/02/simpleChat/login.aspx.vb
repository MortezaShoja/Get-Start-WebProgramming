Public Class login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtUN As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btnL As System.Web.UI.WebControls.Button

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

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        If Not Application("Users") Is Nothing Then
            Dim users() As String = CType(Application("users"), String).Split(",")
            For i As Integer = 0 To users.Length - 2
                If users(i) = txtUN.Text Then
                    Response.Write("Exists !")
                    Exit Sub
                End If
            Next
        End If

        Session("UN") = txtUN.Text
        If Application("Users") Is Nothing Then
            Application("Users") = txtUN.Text & ","
        Else
            Application("Users") &= txtUN.Text & ","
        End If
        Response.Redirect("chat.aspx")
    End Sub
End Class
