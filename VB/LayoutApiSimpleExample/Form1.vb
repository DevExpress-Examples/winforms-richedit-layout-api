Imports DevExpress.XtraRichEdit.API.Layout
Imports System
Imports System.Windows.Forms

Namespace LayoutApiSimpleExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("Grimm.docx")
            AddHandler richEditControl1.DocumentLayout.DocumentFormatted, AddressOf Me.DocumentLayout_DocumentFormatted
        End Sub

'#Region "#DocumentFormatted"
        Private Sub DocumentLayout_DocumentFormatted(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginInvoke(New Action(Sub()
                Dim pageCount As Integer = richEditControl1.DocumentLayout.GetFormattedPageCount()
                For i As Integer = 0 To pageCount - 1
                    Dim visitor As MyDocumentLayoutVisitor = New MyDocumentLayoutVisitor()
                    visitor.Visit(richEditControl1.DocumentLayout.GetPage(i))
                Next
            End Sub))
        End Sub
'#End Region  ' #DocumentFormatted
    End Class
End Namespace
