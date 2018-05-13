Public Class WebForm2
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image

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
        Dim c As Control
        For Each c In Me.FindControl("form1").Controls
            If TypeOf c Is Panel Then
                c.Visible = False
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Control
        For Each c In Me.FindControl("form1").Controls
            If TypeOf c Is Panel Then
                If CType(c, Panel).ID = "Panel1" Then
                    c.Visible = True
                Else
                    c.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Control
        For Each c In Me.FindControl("form1").Controls
            If TypeOf c Is Panel Then
                If CType(c, Panel).ID = "Panel2" Then
                    c.Visible = True
                Else
                    c.Visible = False
                End If
            End If
        Next
    End Sub
End Class
