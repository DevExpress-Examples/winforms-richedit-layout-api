Imports DevExpress.Office.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports System.Drawing

Namespace LayoutApiSimpleExample
	#Region "#MyLayoutPainter"
	Public Class MyLayoutPainter
		Inherits PagePainter

		#Region "#PlainTextBoxPainter"
		Public Overrides Sub DrawPlainTextBox(ByVal plainTextBox As PlainTextBox)
			If Form1.customDrawText = True Then
				Canvas.DrawRectangle(New RichEditPen(Color.FromArgb(141, 179, 226)), plainTextBox.Bounds)
			Else
				MyBase.DrawPlainTextBox(plainTextBox)
			End If
		End Sub
		#End Region ' #PlainTextBoxPainter

		#Region "#FloatingPicturePainter"
		Public Overrides Sub DrawFloatingPicture(ByVal floatingPicture As LayoutFloatingPicture)
			If Form1.customDrawImage = True Then
				Dim bounds As Rectangle = floatingPicture.Bounds
				Dim startPoint As New Point(bounds.X + Canvas.ConvertToDrawingLayoutUnits(10, DocumentLayoutUnit.Pixel), bounds.Y + bounds.Height - Canvas.ConvertToDrawingLayoutUnits(40, DocumentLayoutUnit.Pixel))
				Dim pEn As New RichEditPen(Color.Coral)
				pEn.Thickness = 30
				pEn.DashStyle = RichEditDashStyle.Dash
				Canvas.DrawEllipse(pEn, bounds)
				Canvas.DrawString("Approved", New Font("Courier New", 26), New RichEditBrush(Color.DarkMagenta), startPoint)
			Else
				MyBase.DrawFloatingPicture(floatingPicture)
			End If
		End Sub
		#End Region ' #FloatingPicturePainter

		#Region "#TableCellPainter"
		Public Overrides Sub DrawTableCell(ByVal tableCell As LayoutTableCell)
			If Form1.customDrawTable = True Then
				Dim Tbounds As Rectangle = tableCell.Bounds

				Dim x As Integer = Tbounds.X + Tbounds.Width\2 - Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel)
				Dim y As Integer = Tbounds.Y + Tbounds.Height\2 - Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel)
				Dim tableRectangle As New Rectangle(x,y, Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel), Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel))

				Canvas.FillEllipse(New RichEditBrush(Color.MediumAquamarine), tableRectangle)
				MyBase.DrawTableCell(tableCell)
			Else
				MyBase.DrawTableCell(tableCell)
			End If
		End Sub
		#End Region ' #TableCellPainter

		#Region "#InlinePicturesPainter"
		Public Overrides Sub DrawInlineDrawingObject(ByVal inlinePictureBox As InlineDrawingObjectBox)
			If Form1.customDrawPicture = True Then
				Dim Ebounds As Rectangle = inlinePictureBox.Bounds
				Dim pen As New RichEditPen(Color.Maroon, 50)
				pen.DashStyle = RichEditDashStyle.Dot
				Canvas.DrawLine(pen, New Point(Ebounds.X, Ebounds.Y + Ebounds.Height), New Point(Ebounds.X + Ebounds.Width, Ebounds.Y))
				Canvas.DrawLine(pen, New Point(Ebounds.X, Ebounds.Y), New Point(Ebounds.X + Ebounds.Width, Ebounds.Y + Ebounds.Height))
				Dim inlineRect As New Rectangle(Ebounds.X, Ebounds.Y, Ebounds.Width, Ebounds.Height)
				Canvas.DrawRectangle(New RichEditPen(Color.Aquamarine, 40), inlineRect)
			Else
				MyBase.DrawInlineDrawingObject(inlinePictureBox)
			End If
		End Sub
		#End Region ' #InlinePicturesPainter

		#Region "#TextBoxPainter"
		Public Overrides Sub DrawTextBox(ByVal textBox As LayoutTextBox)
			If Form1.customDrawTextBox = True Then
				Dim StarPoints() As Point = {
					New Point(textBox.Bounds.X+textBox.Bounds.Width\2,textBox.Bounds.Y),
					New Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height),
					New Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height\2),
					New Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height\2),
					New Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height),
					New Point(textBox.Bounds.X+textBox.Bounds.Width\2,textBox.Bounds.Y)
				}
				Canvas.DrawLines(New RichEditPen(Color.HotPink, 30), StarPoints)
			Else
				MyBase.DrawTextBox(textBox)
			End If
		End Sub
		#End Region ' #TextBoxPainter        

		#Region "#NumberingListWithSeparatorPainter"
		Public Overrides Sub DrawNumberingListWithSeparatorBox(ByVal numberingListWithSeparatorBox As NumberingListWithSeparatorBox)
			If Form1.customDrawSeparator = True Then
				Canvas.FillRectangle(New RichEditBrush(Color.DarkRed), numberingListWithSeparatorBox.Bounds)
			Else
				MyBase.DrawNumberingListWithSeparatorBox(numberingListWithSeparatorBox)
			End If
		End Sub
		#End Region ' #NumberingListWithSeparatorPainter

		#Region "#PagePainter"
		Public Overrides Sub DrawPage(ByVal page As LayoutPage)
			If Form1.customDrawPage = True Then
				Dim inlineRect As New Rectangle(100, 100, 150, 200)
				Canvas.DrawRectangle(New RichEditPen(Color.Aquamarine, Canvas.ConvertToDrawingLayoutUnits(4, DocumentLayoutUnit.Pixel)), Canvas.ConvertToDrawingLayoutUnits(inlineRect, DocumentLayoutUnit.Pixel))

			End If
			MyBase.DrawPage(page)
		End Sub
		#End Region ' #PagePainter
	End Class
	#End Region ' #MyLayoutPainter    
End Namespace
