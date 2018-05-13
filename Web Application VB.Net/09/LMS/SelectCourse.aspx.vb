Public Class SelectCourse
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaC = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsC1 = New LMS.dsC
        Me.sdaL = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsL1 = New LMS.dsL
        CType(Me.DsC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsL1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sdaC
        '
        Me.sdaC.SelectCommand = Me.SqlSelectCommand1
        Me.sdaC.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Courses", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("CID", "CID")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Courses.Title, Courses.CID FROM Courses INNER JOIN U_C ON Courses.CID = U_" & _
        "C.CID WHERE (U_C.UN = @UN)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UN", System.Data.SqlDbType.VarChar, 50, "UN"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-403470410F3"";packet size=4096;user id=sa;data source=""."";pers" & _
        "ist security info=True;initial catalog=LMS;password="
        '
        'DsC1
        '
        Me.DsC1.DataSetName = "dsC"
        Me.DsC1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'sdaL
        '
        Me.sdaL.SelectCommand = Me.SqlSelectCommand2
        Me.sdaL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lessons", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("LID", "LID")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Title, Duration, LID FROM Lessons WHERE (CID = @CID)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CID", System.Data.SqlDbType.Int, 4, "CID"))
        '
        'DsL1
        '
        Me.DsL1.DataSetName = "dsL"
        Me.DsL1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.DsC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsL1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents ddlC As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnV As System.Web.UI.WebControls.Button
    Protected WithEvents dbgL As System.Web.UI.WebControls.DataGrid
    Protected WithEvents sdaC As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DsC1 As LMS.dsC
    Protected WithEvents sdaL As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DsL1 As LMS.dsL

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
            sdaC.SelectCommand.Parameters(0).Value = Session("UN")
            sdaC.Fill(DsC1)
            ddlC.DataBind()
        End If
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        sdaL.SelectCommand.Parameters(0).Value = ddlC.SelectedItem.Value
        sdaL.Fill(DsL1)
        dbgL.DataBind()
    End Sub

    Private Sub dbgL_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgL.ItemCommand
        If e.CommandName = "Select" Then
            Session("ID") = ddlC.SelectedValue & e.Item.Cells(0).Text & ".avi"
            Response.Redirect("view.aspx")
        End If
    End Sub
End Class
