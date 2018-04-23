Imports DevExpress.Office.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports System.Drawing

Namespace LayoutApiSimpleExample
    '#Region "#MyLayoutPainter"
    Public Class MyLayoutPainter
        Inherits PagePainter

        '#End Region ' #MyLayoutPainter
        '#Region "#PlainTextBoxPainter"
        Public Overrides Sub DrawPlainTextBox(ByVal plainTextBox As PlainTextBox)
            If Form1.customDrawText = True Then
                Canvas.DrawRectangle(New RichEditPen(Color.FromArgb(141, 179, 226)), plainTextBox.Bounds)
            Else
                MyBase.DrawPlainTextBox(plainTextBox)
            End If
        End Sub
        '#End Region ' #PlainTextBoxPainter

        '#Region "#FloatingPicturePainter"
        Public Overrides Sub DrawFloatingPicture(ByVal floatingPicture As LayoutFloatingPicture)
            If Form1.customDrawImage = True Then
                Dim bounds As Rectangle = floatingPicture.Bounds
                Dim startPoint As New Point(bounds.X + 10, bounds.Y + bounds.Height - 40)
                Dim pEn As New RichEditPen(Color.Coral)
                pEn.Thickness = 3
                pEn.DashStyle = RichEditDashStyle.Dash
                Canvas.DrawEllipse(pEn, bounds)
                Canvas.DrawString("Approved", New Font("Courier New", 26), New RichEditBrush(Color.DarkMagenta), startPoint)
            Else
                MyBase.DrawFloatingPicture(floatingPicture)
            End If
        End Sub
        '#End Region ' #FloatingPicturePainter

        '#Region "#TableCellPainter"
        Public Overrides Sub DrawTableCell(ByVal tableCell As LayoutTableCell)
            If Form1.customDrawTable = True Then
                Dim Tbounds As Rectangle = tableCell.Bounds
                Dim tableRectangle As New Rectangle(New Point(Tbounds.X + Tbounds.Width \ 2 - 10, Tbounds.Y + Tbounds.Height \ 2 - 10), New Size(20, 20))
                Canvas.FillEllipse(New RichEditBrush(Color.MediumAquamarine), Canvas.ConvertToDrawingLayoutUnits(tableRectangle, DocumentLayoutUnit.Pixel))
                Canvas.DrawImage(OfficeImage.CreateImage(DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/employeeaward_16x16.png")), tableCell.Bounds, ImageSizeMode.Squeeze)
                MyBase.DrawTableCell(tableCell)
            Else
                MyBase.DrawTableCell(tableCell)
            End If
        End Sub
        '#End Region ' #TableCellPainter

        '#Region "#InlinePainter"
        Public Overrides Sub DrawInlinePictureBox(ByVal inlinePictureBox As InlinePictureBox)
            If Form1.customDrawPicture = True Then
                Dim Ebounds As Rectangle = inlinePictureBox.Bounds
                Dim pen As New RichEditPen(Color.Maroon, 2)
                pen.DashStyle = RichEditDashStyle.Dot
                Canvas.DrawLine(pen, New Point(Ebounds.X, Ebounds.Y + Ebounds.Height), New Point(Ebounds.X + Ebounds.Width, Ebounds.Y))
                Canvas.DrawLine(pen, New Point(Ebounds.X, Ebounds.Y), New Point(Ebounds.X + Ebounds.Width, Ebounds.Y + Ebounds.Height))
                Dim inlineRect As New Rectangle(Ebounds.X, Ebounds.Y, Ebounds.Width, Ebounds.Height)
                Canvas.DrawRectangle(New RichEditPen(Color.Aquamarine, 4), inlineRect)
            Else
                MyBase.DrawInlinePictureBox(inlinePictureBox)
            End If
        End Sub
        '#End Region ' #InlinePainter

        '#Region "#TextBoxPainter"
        Public Overrides Sub DrawTextBox(ByVal textBox As LayoutTextBox)
            If Form1.customDrawTextBox = True Then
                Dim StarPoints() As Point = { _
                    New Point(textBox.Bounds.X+textBox.Bounds.Width\2,textBox.Bounds.Y), _
                    New Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height), _
                    New Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height\2), _
                    New Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height\2), _
                    New Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height), _
                    New Point(textBox.Bounds.X+textBox.Bounds.Width\2,textBox.Bounds.Y) _
                }
                Canvas.DrawLines(New RichEditPen(Color.HotPink, 3), StarPoints)
            Else
                MyBase.DrawTextBox(textBox)
            End If
        End Sub
        '#End Region ' #TextBoxPainter        

        '#Region "#NumberingListWithSeparatorPainter"
        Public Overrides Sub DrawNumberingListWithSeparatorBox(ByVal numberingListWithSeparatorBox As NumberingListWithSeparatorBox)
            If Form1.customDrawSeparator = True Then
                Canvas.FillRectangle(New RichEditBrush(Color.DarkRed), numberingListWithSeparatorBox.Bounds)
            Else
                MyBase.DrawNumberingListWithSeparatorBox(numberingListWithSeparatorBox)
            End If
        End Sub
        '#End Region ' #NumberingListWithSeparatorPainter

        '#Region "#HeaderPainter"
        Public Overrides Sub DrawHeader(ByVal header As LayoutHeader)
            If Form1.customDrawHeader = True Then

                Dim p1 As New Point(0, 0)
                Dim p2 As New Point(100, 100)
                Canvas.DrawLine(New RichEditPen(Color.Red, 5), p1, p2)
                Canvas.DrawString("Default Layout Unit", New Font("Comic Sans", 12), New RichEditBrush(Color.Red), New Point(0, 0))
                Dim p3 As New Point(0, 100)
                Dim p4 As New Point(100, 200)
                Canvas.DrawLine(New RichEditPen(Color.Blue, 5), p3, p4, DocumentLayoutUnit.Pixel)
                Canvas.DrawString("Layout Unit Specified", New Font("Comic Sans", 12), New RichEditBrush(Color.Blue), New Point(0, 100), DocumentLayoutUnit.Pixel)
            Else
                MyBase.DrawHeader(header)
            End If
        End Sub
        '#End Region ' #HeaderPainter 

        '#Region "#PagePainter"
        Public Overrides Sub DrawPage(ByVal page As LayoutPage)
            If Form1.customDrawPage = True Then
                Dim inlineRect As New Rectangle(100, 100, 150, 200)
                Canvas.DrawRectangle(New RichEditPen(Color.Aquamarine, Canvas.ConvertToDrawingLayoutUnits(4, DocumentLayoutUnit.Pixel)), Canvas.ConvertToDrawingLayoutUnits(inlineRect, DocumentLayoutUnit.Pixel))

            End If
            MyBase.DrawPage(page)
        End Sub
        '#End Region ' #PagePainter
        '#Region "#_MyLayoutPainter"
    End Class
    '#End Region ' #_MyLayoutPainter
End Namespace
