Imports System.Data.SqlClient

Public Class result
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
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = Session("condition")
        Try
            sqlcon.Open()
            Dim sdr As SqlDataReader = cmd.ExecuteReader
            Dim tbl As New Table
            While sdr.Read
                Dim r As New TableRow
                Dim c1 As New TableCell
                c1.BorderStyle = BorderStyle.Solid
                c1.Text = sdr.Item("Name")
                Dim c2 As New TableCell
                c2.BorderStyle = BorderStyle.Solid
                c2.Text = sdr.Item("Description")
                Dim c3 As New TableCell
                c3.BorderStyle = BorderStyle.Solid
                Dim img As New Web.UI.WebControls.Image
                img.Attributes.Add("OnClick", "window.showModalDialog('" & sdr.Item("pid") & ".jpg');")
                img.ImageUrl = "/photogallary/" & sdr.Item("pid") & ".jpg"
                Dim u As New Web.UI.WebControls.Unit(40)
                img.Width = u
                img.Height = u
                c3.Controls.Add(img)
                r.Cells.Add(c1)
                r.Cells.Add(c2)
                r.Cells.Add(c3)
                tbl.Rows.Add(r)
            End While
            Me.Controls.Add(tbl)
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

End Class
