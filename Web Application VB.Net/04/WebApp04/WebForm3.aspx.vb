Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents fld As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents btnU As System.Web.UI.WebControls.Button

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
        Response.Write(Server.MapPath(Request.ApplicationPath))
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        Dim tmp() As String = fld.PostedFile.FileName.Split("\")
        Dim fname As String = tmp(tmp.Length - 1)
        Response.Write(fld.PostedFile.FileName)
        fld.PostedFile.SaveAs(Server.MapPath(Request.ApplicationPath) & "\" & fname)
    End Sub
End Class
