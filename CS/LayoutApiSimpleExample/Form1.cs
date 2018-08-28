using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LayoutApiSimpleExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("Grimm.docx");
            richEditControl1.DocumentLayout.DocumentFormatted += DocumentLayout_DocumentFormatted;
        }
        #region #DocumentFormatted
        private void DocumentLayout_DocumentFormatted(object sender, EventArgs e)
        {

            richEditControl1.BeginInvoke(new Action(() =>
            {
                int pageCount = richEditControl1.DocumentLayout.GetFormattedPageCount();
                for (int i = 0; i < pageCount; i++)
                {
                    MyDocumentLayoutVisitor visitor = new MyDocumentLayoutVisitor();
                    visitor.Visit(richEditControl1.DocumentLayout.GetPage(i));
                }
            }));
        }
        #endregion #DocumentFormatted

        private void btnPageInfo_Click(object sender, EventArgs e)
        {
            #region #GetVisiblePages
            List<PageLayoutInfo> pages = richEditControl1.ActiveView.GetVisiblePageLayoutInfos();
            DocumentRange visibleRange = richEditControl1.ActiveView.GetVisiblePagesRange();

            Pen redPen = new Pen(Color.Red, 1);
            Graphics gr = richEditControl1.CreateGraphics();
            gr.DrawRectangle(redPen, pages[0].Bounds);

            string s = String.Format("{0} page(s) displayed.\r\n" +
                "From page {1} which starts at document position {2}.\r\n" +
                "To page {3} which ends at document position {4}.\r\n" +
                "First visible page is outlined with red.",
            pages.Count, pages[0].PageIndex, visibleRange.Start, pages[pages.Count - 1].PageIndex, visibleRange.End);
            #endregion  #GetVisiblePages
            lblPageInfo.Text = s;
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            richEditControl1.ActiveView.ZoomFactor = trackBarControl1.Value / 100f;
        }

        private void btnCheckLayout_Click(object sender, EventArgs e)
        {
            #region #CheckLayout
            DevExpress.XtraRichEdit.API.Native.Table table = richEditControl1.Document.Tables.First;
            if (table != null)
            {
                // Obtain the layout element related to the table.
                LayoutTable ltable = richEditControl1.DocumentLayout.GetElement<LayoutTable>(table.Range.Start);
                // Obtain zero-based page index of the page containing the layout element.
                int pageIndex = this.richEditControl1.DocumentLayout.GetPageIndex(ltable);
                // Check whether the layout element is located at the second page.
                string s = "Layout verified.";
                if (pageIndex != 1)
                    s = "The first table is not on the page 2. Review pagination.";
                MessageBox.Show(s, "Check Layout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion #CheckLayout
        }

        private void btnPositionInfo_Click(object sender, EventArgs e)
        {
            #region #GetPageForPosition
            SubDocument subDoc = richEditControl1.Document.CaretPosition.BeginUpdateDocument();
            DocumentPosition pos = subDoc.CreatePosition(richEditControl1.Document.CaretPosition.ToInt() == 0 ? 0 : richEditControl1.Document.CaretPosition.ToInt() - 1);
            LayoutPageArea pageArea = richEditControl1.DocumentLayout.GetElement(pos, LayoutType.PageArea) as LayoutPageArea;
            LayoutPage page = pageArea.GetParentByType<LayoutPage>();
            if (page != null)
            {
                string s = String.Format("The caret is on the page with index={0}\r\n" +
                "The page starts at document position {1},\r\n" +
                "the range length of the page content is {2}.\r\n",
            page.Index, page.MainContentRange.Start, page.MainContentRange.Length);
                lblPageInfo.Text = s;
            }
            richEditControl1.Document.CaretPosition.EndUpdateDocument(subDoc);
            #endregion #GetPageForPosition
        }

        private void btnPageCountSelectedRange_Click(object sender, EventArgs e)
        {
            #region #GetPageCountForSelection
            RichEditDocumentServer srv = new RichEditDocumentServer();
            srv.CreateNewDocument();
            srv.Document.AppendDocumentContent(richEditControl1.Document.Selection);
            int pageCount = srv.DocumentLayout.GetPageCount();
            MessageBox.Show(String.Format("Selected range will occupy {0} page(s)", pageCount));
            #endregion #GetPageCountForSelection
        }

        #region #checkbtnCustomDraw
        private void checkbtnCustomDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbtnCustomDraw.Checked)
            {
                richEditControl1.BeforePagePaint += richEditControl1_BeforePagePaint;
                panelControl2.Enabled = true;
            }
            else
            {
                richEditControl1.BeforePagePaint -= richEditControl1_BeforePagePaint;
                panelControl2.Enabled = false;
            }
            richEditControl1.Refresh();

        }
        void richEditControl1_BeforePagePaint(object sender, BeforePagePaintEventArgs e)
        {
            e.Painter = new MyLayoutPainter();
        }
        #endregion #checkbtnCustomDraw
        public static bool customDrawImage;
        public static bool customDrawText;
        public static bool customDrawTable;
        public static bool customDrawPicture;
        public static bool customDrawTextBox;
        public static bool customDrawSeparator;
        public static bool customDrawHeader;
        public static bool customDrawPage;

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            customDrawText = checkEdit1.Checked ? true : false;
            richEditControl1.Refresh();
        }
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            customDrawImage = checkEdit2.Checked ? true : false;
            richEditControl1.Refresh();
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            customDrawTable = checkEdit3.Checked ? true : false;
            richEditControl1.Refresh();
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            customDrawPicture = checkEdit4.Checked ? true : false;
            richEditControl1.Refresh();
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            customDrawTextBox = checkEdit5.Checked ? true : false;
            richEditControl1.Refresh();
        }
        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            customDrawSeparator = checkEdit7.Checked ? true : false;
            richEditControl1.Refresh();
        }
        private void checkEdit9_CheckedChanged(object sender, EventArgs e)
        {
            customDrawPage = checkEdit9.Checked ? true : false;
            richEditControl1.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            richEditControl1.ShowPrintPreview();
        }
    }
}

