Public Class photo
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents fld As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents btnU As System.Web.UI.WebControls.Button
    Protected WithEvents ddlI As System.Web.UI.WebControls.DropDownList
    Protected WithEvents img As System.Web.UI.WebControls.Image
    Protected WithEvents btn As System.Web.UI.WebControls.Button

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
            FillDdl()
        End If

    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        Dim tmp() As String = fld.PostedFile.FileName.Split("\")
        Dim ext() As String = tmp(tmp.Length - 1).Split(".")
        If ext(ext.Length - 1) = "JPG" Then
            fld.PostedFile.SaveAs(Server.MapPath(Request.ApplicationPath) & "\" & tmp(tmp.Length - 1))
            If Application("pix") Is Nothing Then
                Application("pix") = tmp(tmp.Length - 1) & ","
            Else
                Application("pix") &= tmp(tmp.Length - 1) & ","
            End If
            FillDdl()
        End If
    End Sub

    Public Sub FillDdl()
        If Not Application("pix") Is Nothing Then
            Dim str() As String = Application("pix").ToString.Split(",")
            ReDim Preserve str(str.Length - 2)
            ddlI.DataSource = str
            ddlI.DataBind()
        End If
    End Sub

    Private Sub ddlI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlI.SelectedIndexChanged
        img.ImageUrl = "/webapp04/" & ddlI.SelectedItem.Text
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Response.Redirect("view.aspx")
    End Sub
End Class
