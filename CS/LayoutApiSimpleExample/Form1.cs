using DevExpress.XtraRichEdit.API.Layout;
using System;
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
    }
}
