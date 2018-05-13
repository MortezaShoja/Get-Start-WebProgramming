Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

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
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "SELECT * FROM employees"
        Try
            sqlcon.Open()
            DataGrid1.DataSource = cmd.ExecuteReader
            DataGrid1.DataBind()
        Catch ex As Exception
        Finally
            sqlcon.Close()
        End Try
    End Sub

End Class
