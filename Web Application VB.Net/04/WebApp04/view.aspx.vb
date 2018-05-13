Public Class view
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
        Dim tmp() As String = Application("pix").ToString.Split(",")
        ReDim Preserve tmp(tmp.Length - 2)
        For i As Integer = 0 To tmp.Length - 1
            'Dim img As New Web.UI.HtmlControls.HtmlImage
            'img.Src = "/webapp04/" & tmp(i)
            'img.Width = 30
            'img.Height = 30
            'img.Attributes.Add("OnClick", "window.open('" & tmp(i) & "')")
            'Me.FindControl("form1").Controls.Add(img)

            Response.Write("<br><img src=" & tmp(i) & " width=30 height=30 OnClick=window.open('" & tmp(i) & "') /img><br>")

        Next
    End Sub

End Class
