Public Class chat
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMSG As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSend As System.Web.UI.WebControls.Button
    Protected WithEvents ddlUN As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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
        Response.Write("Welcome " & Session("UN"))
        Dim users() As String = CType(Application("Users"), String).Split(",")
        ReDim Preserve users(users.Length - 2)
        'For i As Integer = 0 To users.Length - 1
        '    ddlUN.Items.Add(users(i))
        'Next

        If Not IsPostBack Then
            ddlUN.DataSource = users
            ddlUN.DataBind()
        End If

        If Not Application("MSG") Is Nothing Then
            Dim msg() As String = CType(Application("MSG"), String).Split(":")
            ReDim Preserve msg(msg.Length - 2)
            For i As Integer = 0 To msg.Length - 1
                Dim tmp() As String = msg(i).Split(",")
                If tmp(1) = Session("UN") Then
                    Response.Write("<br>" & tmp(2) & "<br>")
                End If
            Next
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Application("MSG") Is Nothing Then
            Application("MSG") = Session("UN") & "," & ddlUN.SelectedItem.Text & "," & txtMSG.Text & ":"
        Else
            Application("MSG") &= Session("UN") & "," & ddlUN.SelectedItem.Text & "," & txtMSG.Text & ":"
        End If
    End Sub
End Class
