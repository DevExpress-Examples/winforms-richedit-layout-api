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
        #endregion #MyLayoutPainter
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
                Point startPoint = new Point(bounds.X + 10, bounds.Y + bounds.Height - 40);
                RichEditPen pEn = new RichEditPen(Color.Coral);
                pEn.Thickness = 3;
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
                Rectangle tableRectangle = new Rectangle(new Point(Tbounds.X + Tbounds.Width / 2 - 10, Tbounds.Y + Tbounds.Height / 2 - 10), new Size(20, 20));
                Canvas.FillEllipse(new RichEditBrush(Color.MediumAquamarine), Canvas.ConvertToDrawingLayoutUnits(tableRectangle, DocumentLayoutUnit.Pixel));
                Canvas.DrawImage(OfficeImage.CreateImage(DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/employeeaward_16x16.png")), tableCell.Bounds, ImageSizeMode.Squeeze);
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
                RichEditPen pen = new RichEditPen(Color.Maroon, 2);
                pen.DashStyle = RichEditDashStyle.Dot;
                Canvas.DrawLine(pen, new Point(Ebounds.X, Ebounds.Y + Ebounds.Height), new Point(Ebounds.X + Ebounds.Width, Ebounds.Y));
                Canvas.DrawLine(pen, new Point(Ebounds.X, Ebounds.Y), new Point(Ebounds.X + Ebounds.Width, Ebounds.Y + Ebounds.Height));
                Rectangle inlineRect = new Rectangle(Ebounds.X, Ebounds.Y, Ebounds.Width, Ebounds.Height);
                Canvas.DrawRectangle(new RichEditPen(Color.Aquamarine, 4), inlineRect);
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
                Canvas.DrawLines(new RichEditPen(Color.HotPink, 3), StarPoints);
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

        #region #HeaderPainter
        public override void DrawHeader(LayoutHeader header)
        {
            if (Form1.customDrawHeader == true)
            {

                Point p1 = new Point(0, 0);
                Point p2 = new Point(100, 100);
                Canvas.DrawLine(new RichEditPen(Color.Red, 5), p1, p2);
                Canvas.DrawString("Default Layout Unit", new Font("Comic Sans", 12), new RichEditBrush(Color.Red), new Point(0, 0));
                Point p3 = new Point(0, 100);
                Point p4 = new Point(100, 200);
                Canvas.DrawLine(new RichEditPen(Color.Blue, 5), p3, p4, DocumentLayoutUnit.Pixel);
                Canvas.DrawString("Layout Unit Specified", new Font("Comic Sans", 12), new RichEditBrush(Color.Blue), new Point(0, 100), DocumentLayoutUnit.Pixel);
            }
            else
                base.DrawHeader(header);
        }
        #endregion #HeaderPainter 

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
        #region #_MyLayoutPainter
    }
    #endregion #_MyLayoutPainter
}
