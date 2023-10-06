Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Drawing
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
        Private Sub btnPageInfo_Click(ByVal sender As Object, ByVal e As EventArgs)
'#Region "#GetVisiblePages"
            Dim pages As List(Of PageLayoutInfo) = richEditControl1.ActiveView.GetVisiblePageLayoutInfos()
            Dim visibleRange As DocumentRange = richEditControl1.ActiveView.GetVisiblePagesRange()
            Dim redPen As Pen = New Pen(Color.Red, 1)
            Dim gr As Graphics = richEditControl1.CreateGraphics()
            gr.DrawRectangle(redPen, pages(0).Bounds)
            Dim s As String = String.Format("{0} page(s) displayed." & Microsoft.VisualBasic.Constants.vbCrLf & "From page {1} which starts at document position {2}." & Microsoft.VisualBasic.Constants.vbCrLf & "To page {3} which ends at document position {4}." & Microsoft.VisualBasic.Constants.vbCrLf & "First visible page is outlined with red.", pages.Count, pages(CInt(0)).PageIndex, visibleRange.Start, pages(CInt(pages.Count - 1)).PageIndex, visibleRange.End)
'#End Region  ' #GetVisiblePages
            lblPageInfo.Text = s
        End Sub

        Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.ActiveView.ZoomFactor = trackBarControl1.Value / 100F
        End Sub

        Private Sub btnCheckLayout_Click(ByVal sender As Object, ByVal e As EventArgs)
'#Region "#CheckLayout"
            Dim table As Table = richEditControl1.Document.Tables.First
            If table IsNot Nothing Then
                ' Obtain the layout element related to the table.
                Dim ltable As LayoutTable = richEditControl1.DocumentLayout.GetElement(Of LayoutTable)(table.Range.Start)
                ' Obtain zero-based page index of the page containing the layout element.
                Dim pageIndex As Integer = richEditControl1.DocumentLayout.GetPageIndex(ltable)
                ' Check whether the layout element is located at the second page.
                Dim s As String = "Layout verified."
                If pageIndex <> 1 Then s = "The first table is not on the page 2. Review pagination."
                MessageBox.Show(s, "Check Layout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
'#End Region  ' #CheckLayout
        End Sub

        Private Sub btnPositionInfo_Click(ByVal sender As Object, ByVal e As EventArgs)
'#Region "#GetPageForPosition"
            Dim subDoc As SubDocument = richEditControl1.Document.CaretPosition.BeginUpdateDocument()
            Dim pos As DocumentPosition = subDoc.CreatePosition(If(richEditControl1.Document.CaretPosition.ToInt() = 0, 0, richEditControl1.Document.CaretPosition.ToInt() - 1))
            Dim pageArea As LayoutPageArea = TryCast(richEditControl1.DocumentLayout.GetElement(pos, LayoutType.PageArea), LayoutPageArea)
            Dim page As LayoutPage = pageArea.GetParentByType(Of LayoutPage)()
            If page IsNot Nothing Then
                Dim s As String = String.Format("The caret is on the page with index={0}" & Microsoft.VisualBasic.Constants.vbCrLf & "The page starts at document position {1}," & Microsoft.VisualBasic.Constants.vbCrLf & "the range length of the page content is {2}." & Microsoft.VisualBasic.Constants.vbCrLf, page.Index, page.MainContentRange.Start, page.MainContentRange.Length)
                lblPageInfo.Text = s
            End If

            richEditControl1.Document.CaretPosition.EndUpdateDocument(subDoc)
'#End Region  ' #GetPageForPosition
        End Sub

        Private Sub btnPageCountSelectedRange_Click(ByVal sender As Object, ByVal e As EventArgs)
'#Region "#GetPageCountForSelection"
            Dim srv As RichEditDocumentServer = New RichEditDocumentServer()
            srv.CreateNewDocument()
            srv.Document.AppendDocumentContent(richEditControl1.Document.Selection)
            Dim pageCount As Integer = srv.DocumentLayout.GetPageCount()
            MessageBox.Show(String.Format("Selected range will occupy {0} page(s)", pageCount))
'#End Region  ' #GetPageCountForSelection
        End Sub

'#Region "#checkbtnCustomDraw"
        Private Sub checkbtnCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkbtnCustomDraw.Checked Then
                AddHandler richEditControl1.BeforePagePaint, AddressOf richEditControl1_BeforePagePaint
                panelControl2.Enabled = True
            Else
                RemoveHandler richEditControl1.BeforePagePaint, AddressOf richEditControl1_BeforePagePaint
                panelControl2.Enabled = False
            End If

            richEditControl1.Refresh()
        End Sub

        Private Sub richEditControl1_BeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            e.Painter = New MyLayoutPainter()
        End Sub

'#End Region  ' #checkbtnCustomDraw
        Public Shared customDrawImage As Boolean

        Public Shared customDrawText As Boolean

        Public Shared customDrawTable As Boolean

        Public Shared customDrawPicture As Boolean

        Public Shared customDrawTextBox As Boolean

        Public Shared customDrawSeparator As Boolean

        Public Shared customDrawHeader As Boolean

        Public Shared customDrawPage As Boolean

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawText = If(checkEdit1.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawImage = If(checkEdit2.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawTable = If(checkEdit3.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawPicture = If(checkEdit4.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawTextBox = If(checkEdit5.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawSeparator = If(checkEdit7.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub checkEdit9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            customDrawPage = If(checkEdit9.Checked, True, False)
            richEditControl1.Refresh()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.ShowPrintPreview()
        End Sub
    End Class
End Namespace
