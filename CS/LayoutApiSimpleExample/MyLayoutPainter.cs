using DevExpress.Office.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Layout;
using System.Drawing;

namespace LayoutApiSimpleExample
{
    #region #MyLayoutPainter
    public class MyLayoutPainter : PagePainter
    {

        #region #PlainTextBoxPainter
        public override void DrawPlainTextBox(PlainTextBox plainTextBox)
        {
            if (Form1.customDrawText == true)
            {
                Canvas.DrawRectangle(new RichEditPen(Color.FromArgb(141, 179, 226)), plainTextBox.Bounds);
            }
            else base.DrawPlainTextBox(plainTextBox);
        }
        #endregion #PlainTextBoxPainter

        #region #FloatingPicturePainter
        public override void DrawFloatingPicture(LayoutFloatingPicture floatingPicture)
        {
            if (Form1.customDrawImage == true)
            {
                Rectangle bounds = floatingPicture.Bounds;
                Point startPoint = new Point(bounds.X + Canvas.ConvertToDrawingLayoutUnits(10, DocumentLayoutUnit.Pixel), bounds.Y + bounds.Height - Canvas.ConvertToDrawingLayoutUnits(40, DocumentLayoutUnit.Pixel));
                RichEditPen pEn = new RichEditPen(Color.Coral);
                pEn.Thickness = 30;
                pEn.DashStyle = RichEditDashStyle.Dash;
                Canvas.DrawEllipse(pEn, bounds);
                Canvas.DrawString("Approved", new Font("Courier New", 26), new RichEditBrush(Color.DarkMagenta), startPoint);
            }
            else
                base.DrawFloatingPicture(floatingPicture);
        }
        #endregion #FloatingPicturePainter

        #region #TableCellPainter
        public override void DrawTableCell(LayoutTableCell tableCell)
        {
            if (Form1.customDrawTable == true)
            {
                Rectangle Tbounds = tableCell.Bounds;

                int x = Tbounds.X + Tbounds.Width/2 - Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel);
                int y = Tbounds.Y + Tbounds.Height/2 - Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel);
                Rectangle tableRectangle = new Rectangle(x,y, Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel), 
                    Canvas.ConvertToDrawingLayoutUnits(20, DocumentLayoutUnit.Pixel));

                Canvas.FillEllipse(new RichEditBrush(Color.MediumAquamarine), tableRectangle);
                base.DrawTableCell(tableCell);
            }
            else
                base.DrawTableCell(tableCell);
        }
        #endregion #TableCellPainter

        #region #InlinePainter
        public override void DrawInlinePictureBox(InlinePictureBox inlinePictureBox)
        {
            if (Form1.customDrawPicture == true)
            {
                Rectangle Ebounds = inlinePictureBox.Bounds;
                RichEditPen pen = new RichEditPen(Color.Maroon, 50);
                pen.DashStyle = RichEditDashStyle.Dot;
                Canvas.DrawLine(pen, new Point(Ebounds.X, Ebounds.Y + Ebounds.Height), new Point(Ebounds.X + Ebounds.Width, Ebounds.Y));
                Canvas.DrawLine(pen, new Point(Ebounds.X, Ebounds.Y), new Point(Ebounds.X + Ebounds.Width, Ebounds.Y + Ebounds.Height));
                Rectangle inlineRect = new Rectangle(Ebounds.X, Ebounds.Y, Ebounds.Width, Ebounds.Height);
                Canvas.DrawRectangle(new RichEditPen(Color.Aquamarine, 40), inlineRect);
            }
            else
                base.DrawInlinePictureBox(inlinePictureBox);
        }
        #endregion #InlinePainter

        #region #TextBoxPainter
        public override void DrawTextBox(LayoutTextBox textBox)
        {
            if (Form1.customDrawTextBox == true)
            {
                Point[] StarPoints =
                    {
                new Point(textBox.Bounds.X+textBox.Bounds.Width/2,textBox.Bounds.Y),
                new Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height),
                new Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height/2),
                new Point(textBox.Bounds.X+textBox.Bounds.Width,textBox.Bounds.Y+textBox.Bounds.Height/2),
                new Point(textBox.Bounds.X,textBox.Bounds.Y+textBox.Bounds.Height),
                new Point(textBox.Bounds.X+textBox.Bounds.Width/2,textBox.Bounds.Y)
                    };
                Canvas.DrawLines(new RichEditPen(Color.HotPink, 30), StarPoints);
            }
            else
                base.DrawTextBox(textBox);
        }
        #endregion #TextBoxPainter        

        #region #NumberingListWithSeparatorPainter
        public override void DrawNumberingListWithSeparatorBox(NumberingListWithSeparatorBox numberingListWithSeparatorBox)
        {
            if (Form1.customDrawSeparator == true) Canvas.FillRectangle(new RichEditBrush(Color.DarkRed), numberingListWithSeparatorBox.Bounds);
            else base.DrawNumberingListWithSeparatorBox(numberingListWithSeparatorBox);
        }
        #endregion #NumberingListWithSeparatorPainter

        #region #PagePainter
        public override void DrawPage(LayoutPage page)
        {
            if (Form1.customDrawPage == true)
            {
                Rectangle inlineRect = new Rectangle(100, 100, 150, 200);
                Canvas.DrawRectangle(new RichEditPen(Color.Aquamarine, Canvas.ConvertToDrawingLayoutUnits(4, DocumentLayoutUnit.Pixel)), Canvas.ConvertToDrawingLayoutUnits(inlineRect, DocumentLayoutUnit.Pixel));

            }
            base.DrawPage(page);
        }
        #endregion #PagePainter
    }
    #endregion #MyLayoutPainter    
}
