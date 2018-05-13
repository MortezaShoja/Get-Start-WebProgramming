Imports System.Data.SqlClient

Public Class load
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaU = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsU1 = New PhotoGallary.dsU
        CType(Me.DsU1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sdaU
        '
        Me.sdaU.SelectCommand = Me.SqlSelectCommand1
        Me.sdaU.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UID", "UID"), New System.Data.Common.DataColumnMapping("PWD", "PWD"), New System.Data.Common.DataColumnMapping("DP", "DP")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT UID, PWD, DP FROM users"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-YORFJLQ6KS6"";packet size=4096;user id=sa;data source=""."";pers" & _
        "ist security info=True;initial catalog=PG;password="
        '
        'DsU1
        '
        Me.DsU1.DataSetName = "dsU"
        Me.DsU1.Locale = New System.Globalization.CultureInfo("fa-IR")
        CType(Me.DsU1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents btnA As System.Web.UI.WebControls.Button
    Protected WithEvents txtDP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtUID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPWD As System.Web.UI.WebControls.TextBox
    Protected WithEvents dbgU As System.Web.UI.WebControls.DataGrid
    Protected WithEvents sdaU As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DsU1 As PhotoGallary.dsU
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents txtD As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtN As System.Web.UI.WebControls.TextBox
    Protected WithEvents cld As System.Web.UI.WebControls.Calendar
    Protected WithEvents btnU As System.Web.UI.WebControls.Button
    Protected WithEvents fld As System.Web.UI.HtmlControls.HtmlInputFile

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
        cmd.CommandText = "SELECT DBO.ValidateUser('" & Session("UID") & "','" & Session("PWD") & "')"
        Try
            sqlcon.Open()
            If cmd.ExecuteScalar.ToString <> "load.aspx" Then
                Response.Redirect("login.aspx")
            End If
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try

        If Not IsPostBack Then
            sdaU.Fill(DsU1)
            dbgU.DataBind()
        End If
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC INS_User '" & txtUID.Text & "','" & txtPWD.Text.GetHashCode & "','" & txtDP.Text & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub dbgU_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.DeleteCommand
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC DEL_User '" & CType(e.Item.FindControl("lblEUID"), Label).Text & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sdaU.Fill(DsU1)
            dbgU.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub dbgU_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.EditCommand
        dbgU.SelectedIndex = e.Item.ItemIndex
        dbgU.EditItemIndex = e.Item.ItemIndex
        sdaU.Fill(DsU1)
        dbgU.DataBind()
    End Sub

    Private Sub dbgU_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dbgU.UpdateCommand
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC UPD_User '" & CType(e.Item.FindControl("lblEUID"), Label).Text & "','" & CType(e.Item.FindControl("txtEPWD"), TextBox).Text.GetHashCode & "','" & CType(e.Item.FindControl("txtEDP"), TextBox).Text & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            dbgU.EditItemIndex = -1
            dbgU.SelectedIndex = -1
            sdaU.Fill(DsU1)
            dbgU.DataBind()
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        Dim sqlcon As New SqlConnection
        sqlcon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings.Item("CStr")
        Dim cmd As New SqlCommand
        cmd.Connection = sqlcon
        cmd.CommandText = "EXEC INS_Pic '" & txtN.Text & "','" & txtD.Text & "','" & cld.SelectedDate.ToShortDateString & "'"
        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Response.Write("<script language=javascript>alert('" & ex.Message & "');</script>")
        Finally
            sqlcon.Close()
        End Try

        cmd.CommandText = "SELECT DBO.GetKey()"
        sqlcon.Open()
        fld.PostedFile.SaveAs(Server.MapPath(Request.ApplicationPath) & "\" & cmd.ExecuteScalar.ToString & ".jpg")
        sqlcon.Close()
    End Sub
End Class
