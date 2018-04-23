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
            gr.DrawRectangle(redPen,pages[0].Bounds);

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
    }
}
