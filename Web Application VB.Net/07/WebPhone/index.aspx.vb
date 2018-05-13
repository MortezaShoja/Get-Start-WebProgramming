Imports System.Data.SqlClient

Public Class index
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaVA = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsVA1 = New WebPhone.dsVA
        Me.sdaD = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsD1 = New WebPhone.dsD
        Me.sdaI = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DsI1 = New WebPhone.dsI
        Me.sdaU = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DsU1 = New WebPhone.dsU
        CType(Me.DsVA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsU1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sdaVA
        '
        Me.sdaVA.SelectCommand = Me.SqlSelectCommand1
        Me.sdaVA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID, Family, Name, Phone FROM phones ORDER BY Family, Name"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-YORFJLQ6KS6"";packet size=4096;user id=sa;data source=""."";pers" & _
        "ist security info=True;initial catalog=db;password="
        '
        'DsVA1
        '
        Me.DsVA1.DataSetName = "dsVA"
        Me.DsVA1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'sdaD
        '
        Me.sdaD.SelectCommand = Me.SqlSelectCommand2
        Me.sdaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID, Family, Name, Phone FROM phones ORDER BY Family, Name"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'DsD1
        '
        Me.DsD1.DataSetName = "dsD"
        Me.DsD1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'sdaI
        '
        Me.sdaI.SelectCommand = Me.SqlSelectCommand3
        Me.sdaI.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Family, Name, Phone FROM phones ORDER BY Family, Name"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'DsI1
        '
        Me.DsI1.DataSetName = "dsI"
        Me.DsI1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'sdaU
        '
        Me.sdaU.SelectCommand = Me.SqlSelectCommand4
        Me.sdaU.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT ID, Family, Name, Phone FROM phones ORDER BY Family, Name"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'DsU1
        '
        Me.DsU1.DataSetName = "dsU"
        Me.DsU1.Locale = New System.Globalization.CultureInfo("fa-IR")
        CType(Me.DsVA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsU1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents lnkVA As System.Web.UI.WebControls.LinkButton
    Protected WithEvents pnlVA As System.Web.UI.WebControls.Panel
    Protected WithEvents dbgVA As System.Web.UI.WebControls.DataGrid
    Protected WithEvents sdaVA As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DsVA1 As WebPhone.dsVA
    Protected WithEvents lnkD As System.Web.UI.WebControls.LinkButton
    Protected WithEvents dbgD As System.Web.UI.WebControls.DataGrid
    Protected WithEvents pnlD As System.Web.UI.WebControls.Panel
    Protected WithEvents sdaD As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DsD1 As WebPhone.dsD
    Protected WithEvents pnlI As System.Web.UI.WebControls.Panel
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents sdaI As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DsI1 As WebPhone.dsI
    Protected WithEvents dbgI As System.Web.UI.WebControls.DataGrid
    Protected WithEvents txtF As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtN As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtP As System.Web.UI.WebControls.TextBox
    Protected WithEvents lnkA As System.Web.UI.WebControls.LinkButton
    Protected WithEvents pnlU As System.Web.UI.WebControls.Panel
    Protected WithEvents sdaU As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DsU1 As WebPhone.dsU
    Protected WithEvents dbgU As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lnkU As System.Web.UI.WebControls.LinkButton
    Protected WithEvents txtSF As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSN As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnF As System.Web.UI.WebControls.Button
    Protected WithEvents dbgF As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lnkS As System.Web.UI.WebControls.LinkButton
    Protected WithEvents pnlS As System.Web.UI.WebControls.Panel

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
        Try
            If Request.QueryString.Item("action") = "VA" Then
                'reset
                pnlVA.Visible = True
                sdaVA.Fill(DsVA1)
                dbgVA.Visible = True
                dbgVA.DataBind()
            ElseIf Request.QueryString.Item("action") = "D" Then
                'reset
                If Not IsPostBack Then
                    pnlD.Visible = True
                    dbgD.Visible = True
                    sdaD.Fill(DsD1)
                    dbgD.DataBind()
                End If
            ElseIf Request.QueryString.Item("action") = "I" Then
                sdaI.Fill(DsI1)
                dbgI.DataBind()
                pnlI.Visible = True
                dbgI.Visible = True
            ElseIf Request.QueryString.Item("action") = "U" Then
                If Not IsPostBack Then
                    pnlU.Visible = True
                    dbgU.Visible = True
                    sdaU.Fill(DsU1)
                End If
            ElseIf Request.QueryString.Item("action") = "S" Then
                pnlS.Visible = True
                dbgF.Visible = True
                dbgF.DataBind()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lnkVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkVA.Click
        Response.Redirect("index.aspx?action=VA")
    End Sub

    Private Sub lnkD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkD.Click
        Response.Redirect("index.aspx?action=D")
    End Sub

    Private Sub dbgD_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgD.DeleteCommand
        'Response.Write(e.Item.Cells(0).Text)
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC DEL_Phone " & e.Item.Cells(0).Text
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sdaD.Fill(DsD1)
            dbgD.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript> alert ('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC INS_Phone '" & txtF.Text & "','" & txtN.Text & "','" & txtP.Text & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            DsI1.Clear()
            sdaI.Fill(DsI1)
            dbgI.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript> alert ('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub lnkA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkA.Click
        Response.Redirect("index.aspx?action=I")
    End Sub

    Private Sub dbgU_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.CancelCommand
        dbgU.EditItemIndex = -1
        dbgU.SelectedIndex = -1
        sdaU.Fill(DsU1)
        dbgU.DataBind()
    End Sub

    Private Sub dbgU_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.EditCommand
        dbgU.EditItemIndex = e.Item.ItemIndex
        dbgU.SelectedIndex = e.Item.ItemIndex
        sdaU.Fill(DsU1)
        dbgU.DataBind()
        dbgU.DataBind()
    End Sub

    Private Sub lnkU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkU.Click
        Response.Redirect("index.aspx?action=U")
    End Sub

    Private Sub dbgU_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.UpdateCommand
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC UPD_Phone " & e.Item.Cells(0).Text & ",'" & CType(e.Item.FindControl("txtFa"), TextBox).Text & "','" & CType(e.Item.FindControl("txtNa"), TextBox).Text & "','" & CType(e.Item.FindControl("txtPh"), TextBox).Text & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            dbgU.EditItemIndex = -1
            dbgU.SelectedIndex = -1
            sdaU.Fill(DsU1)
            dbgU.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript> alert ('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "SELECT * FROM dbo.getphone('" & txtSF.Text & "','" & txtSN.Text & "')"
        Try
            sqlcon.Open()
            dbgF.DataSource = cmd.ExecuteReader()
            dbgF.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript> alert ('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub lnkS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkS.Click
        Response.Redirect("index.aspx?action=S")
    End Sub
End Class
