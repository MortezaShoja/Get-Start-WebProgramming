Imports System.Data.SqlClient

Public Class upload
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaC = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsUC1 = New LMS.dsUC
        CType(Me.DsUC1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sdaC
        '
        Me.sdaC.SelectCommand = Me.SqlSelectCommand1
        Me.sdaC.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Courses", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CID", "CID"), New System.Data.Common.DataColumnMapping("Title", "Title")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CID, Title FROM Courses"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-403470410F3"";packet size=4096;user id=sa;data source=""."";pers" & _
        "ist security info=True;initial catalog=LMS;password="
        '
        'DsUC1
        '
        Me.DsUC1.DataSetName = "dsUC"
        Me.DsUC1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.DsUC1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents ddlC As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtL As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents btnU As System.Web.UI.WebControls.Button
    Protected WithEvents fld As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents sdaC As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DsUC1 As LMS.dsUC
    Protected WithEvents txtD As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label

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
        If Not IsPostBack Then
            sdaC.Fill(DsUC1)
            ddlC.DataBind()
        End If
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = "server=local;user id=sa;pwd=;data source=.;database=lms"
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = sqlcon
            cmd.CommandText = "EXEC INS_Lesson " & ddlC.SelectedValue & ",'" & txtL.Text & "'," & txtD.Text
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT DBO.GetKey(" & ddlC.SelectedValue & ")"
            fld.PostedFile.SaveAs(Server.MapPath(Request.ApplicationPath & "\" & ddlC.SelectedValue & CType(cmd.ExecuteScalar, String) & ".avi"))
            sqlcon.Close()
        Catch ex As Exception

        Finally

            sqlcon.Close()
        End Try
    End Sub
End Class
