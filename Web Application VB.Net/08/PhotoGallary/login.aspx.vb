Imports System.Data.SqlClient

Public Class login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtPWD As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtUID As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
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

    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "SELECT DBO.ValidateUser('" & txtUID.Text & "','" & txtPWD.Text.GetHashCode & "')"
        Try
            sqlcon.Open()
            Session("UID") = txtUID.Text
            Session("PWD") = txtPWD.Text.GetHashCode
            Response.Redirect(cmd.ExecuteScalar.ToString)
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub
End Class
