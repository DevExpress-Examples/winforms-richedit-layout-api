Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace LayoutApiSimpleExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			richEditControl1.LoadDocument("Grimm.docx")
			AddHandler richEditControl1.DocumentLayout.DocumentFormatted, AddressOf DocumentLayout_DocumentFormatted
		End Sub
		#Region "#DocumentFormatted"
		Private Sub DocumentLayout_DocumentFormatted(ByVal sender As Object, ByVal e As EventArgs)

			richEditControl1.BeginInvoke(New Action(Sub()
				Dim pageCount As Integer = richEditControl1.DocumentLayout.GetFormattedPageCount()
				For i As Integer = 0 To pageCount - 1
					Dim visitor As New MyDocumentLayoutVisitor()
					visitor.Visit(richEditControl1.DocumentLayout.GetPage(i))
				Next i
			End Sub))
		End Sub
		#End Region ' #DocumentFormatted

		Private Sub btnPageInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPageInfo.Click
'			#Region "#GetVisiblePages"
			Dim pages As List(Of PageLayoutInfo) = richEditControl1.ActiveView.GetVisiblePageLayoutInfos()
			Dim visibleRange As DocumentRange = richEditControl1.ActiveView.GetVisiblePagesRange()

			Dim redPen As New Pen(Color.Red, 1)
			Dim gr As Graphics = richEditControl1.CreateGraphics()
			gr.DrawRectangle(redPen,pages(0).Bounds)

			Dim s As String = String.Format("{0} page(s) displayed." & ControlChars.CrLf & "From page {1} which starts at document position {2}." & ControlChars.CrLf & "To page {3} which ends at document position {4}." & ControlChars.CrLf & "First visible page is outlined with red.", pages.Count, pages(0).PageIndex, visibleRange.Start, pages(pages.Count - 1).PageIndex, visibleRange.End)
'			#End Region '  #GetVisiblePages
			lblPageInfo.Text = s
		End Sub

		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			richEditControl1.ActiveView.ZoomFactor = trackBarControl1.Value / 100F
		End Sub

		Private Sub btnCheckLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheckLayout.Click
'			#Region "#CheckLayout"
			Dim table As DevExpress.XtraRichEdit.API.Native.Table = richEditControl1.Document.Tables.First
			If table IsNot Nothing Then
				' Obtain the layout element related to the table.
				Dim ltable As LayoutTable = richEditControl1.DocumentLayout.GetElement(Of LayoutTable)(table.Range.Start)
				' Obtain zero-based page index of the page containing the layout element.
				Dim pageIndex As Integer = Me.richEditControl1.DocumentLayout.GetPageIndex(ltable)
				' Check whether the layout element is located at the second page.
				Dim s As String = "Layout verified."
				If pageIndex <> 1 Then
					s = "The first table is not on the page 2. Review pagination."
				End If
				MessageBox.Show(s, "Check Layout", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
'			#End Region ' #CheckLayout
		End Sub

		Private Sub btnPositionInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPositionInfo.Click
'			#Region "#GetPageForPosition"
			Dim subDoc As SubDocument = richEditControl1.Document.CaretPosition.BeginUpdateDocument()
			Dim pos As DocumentPosition = subDoc.CreatePosition(If(richEditControl1.Document.CaretPosition.ToInt() = 0, 0, richEditControl1.Document.CaretPosition.ToInt() - 1))
			Dim pageArea As LayoutPageArea = TryCast(richEditControl1.DocumentLayout.GetElement(pos, LayoutType.PageArea), LayoutPageArea)
			Dim page As LayoutPage = pageArea.GetParentByType(Of LayoutPage)()
			If page IsNot Nothing Then
				Dim s As String = String.Format("The caret is on the page with index={0}" & ControlChars.CrLf & "The page starts at document position {1}," & ControlChars.CrLf & "the range length of the page content is {2}." & ControlChars.CrLf, page.Index, page.MainContentRange.Start, page.MainContentRange.Length)
			lblPageInfo.Text = s
			End If
			richEditControl1.Document.CaretPosition.EndUpdateDocument(subDoc)
'			#End Region ' #GetPageForPosition
		End Sub

		Private Sub btnPageCountSelectedRange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPageCountSelectedRange.Click
'			#Region "#GetPageCountForSelection"
			Dim srv As New RichEditDocumentServer()
			srv.CreateNewDocument()
			srv.Document.AppendDocumentContent(richEditControl1.Document.Selection)
			Dim pageCount As Integer = srv.DocumentLayout.GetPageCount()
			MessageBox.Show(String.Format("The selected document range will occupy {0} page(s)", pageCount))
'			#End Region ' #GetPageCountForSelection
		End Sub
	End Class
End Namespace

