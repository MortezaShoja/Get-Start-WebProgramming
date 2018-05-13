Public Class UC
    Inherits System.Web.UI.UserControl

    Public Event Click(ByVal sender As Object, ByVal e As EventArgs)

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents pnl As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnI As System.Web.UI.WebControls.Button
    Protected WithEvents btnD As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public Overridable Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent Click(sender, e)
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Public Property Style() As String
        Get
            Return pnl.Attributes("style")
        End Get
        Set(ByVal Value As String)
            pnl.Attributes("style") = Value
        End Set
    End Property

    Public Property Value() As Integer
        Get
            Return viewstate("V")
        End Get
        Set(ByVal Value As Integer)
            viewstate("V") = Value
        End Set
    End Property

    Private Sub btnD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnD.Click
        Me.Value -= 1
        OnClick(sender, e)
    End Sub

    Private Sub btnI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnI.Click
        Me.Value += 1
        OnClick(sender, e)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Value
    End Function
End Class
