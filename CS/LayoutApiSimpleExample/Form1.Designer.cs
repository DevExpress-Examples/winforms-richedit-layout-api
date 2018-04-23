namespace LayoutApiSimpleExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPageCountSelectedRange = new DevExpress.XtraEditors.SimpleButton();
            this.btnPositionInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckLayout = new DevExpress.XtraEditors.SimpleButton();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.btnPageInfo = new DevExpress.XtraEditors.SimpleButton();
            this.lblPageInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.EnableToolTips = true;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Bookmarks.AllowNameResolution = false;
            this.richEditControl1.Options.Printing.EnableCommentBackgroundOnPrint = false;
            this.richEditControl1.Options.Printing.EnableCommentFillOnPrint = false;
            this.richEditControl1.Size = new System.Drawing.Size(784, 492);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPageCountSelectedRange);
            this.panelControl1.Controls.Add(this.btnPositionInfo);
            this.panelControl1.Controls.Add(this.btnCheckLayout);
            this.panelControl1.Controls.Add(this.trackBarControl1);
            this.panelControl1.Controls.Add(this.btnPageInfo);
            this.panelControl1.Controls.Add(this.lblPageInfo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 492);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 149);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPageCountSelectedRange
            // 
            this.btnPageCountSelectedRange.Location = new System.Drawing.Point(12, 81);
            this.btnPageCountSelectedRange.Name = "btnPageCountSelectedRange";
            this.btnPageCountSelectedRange.Size = new System.Drawing.Size(153, 23);
            this.btnPageCountSelectedRange.TabIndex = 5;
            this.btnPageCountSelectedRange.Text = "Get Page Count for Selection";
            this.btnPageCountSelectedRange.Click += new System.EventHandler(this.btnPageCountSelectedRange_Click);
            // 
            // btnPositionInfo
            // 
            this.btnPositionInfo.Location = new System.Drawing.Point(12, 9);
            this.btnPositionInfo.Name = "btnPositionInfo";
            this.btnPositionInfo.Size = new System.Drawing.Size(153, 23);
            this.btnPositionInfo.TabIndex = 4;
            this.btnPositionInfo.Text = "Get Selected Position Info";
            this.btnPositionInfo.Click += new System.EventHandler(this.btnPositionInfo_Click);
            // 
            // btnCheckLayout
            // 
            this.btnCheckLayout.Location = new System.Drawing.Point(12, 117);
            this.btnCheckLayout.Name = "btnCheckLayout";
            this.btnCheckLayout.Size = new System.Drawing.Size(153, 23);
            this.btnCheckLayout.TabIndex = 3;
            this.btnCheckLayout.Text = "Check Layout";
            this.btnCheckLayout.Click += new System.EventHandler(this.btnCheckLayout_Click);
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 100;
            this.trackBarControl1.Location = new System.Drawing.Point(502, 6);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "100";
            trackBarLabel2.Value = 100;
            trackBarLabel3.Label = "200";
            trackBarLabel3.Value = 200;
            trackBarLabel4.Label = "300";
            trackBarLabel4.Value = 300;
            trackBarLabel5.Label = "400";
            trackBarLabel5.Value = 400;
            trackBarLabel6.Label = "500";
            trackBarLabel6.Value = 500;
            trackBarLabel7.Label = "600";
            trackBarLabel7.Value = 600;
            trackBarLabel8.Label = "700";
            trackBarLabel8.Value = 700;
            trackBarLabel9.Label = "800";
            trackBarLabel9.Value = 800;
            trackBarLabel10.Label = "900";
            trackBarLabel10.Value = 900;
            trackBarLabel11.Label = "1000";
            trackBarLabel11.Value = 1000;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5,
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11});
            this.trackBarControl1.Properties.Maximum = 300;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Properties.SmallChange = 10;
            this.trackBarControl1.Properties.TickFrequency = 10;
            this.trackBarControl1.Size = new System.Drawing.Size(270, 72);
            this.trackBarControl1.TabIndex = 2;
            this.trackBarControl1.Value = 100;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // btnPageInfo
            // 
            this.btnPageInfo.Location = new System.Drawing.Point(12, 45);
            this.btnPageInfo.Name = "btnPageInfo";
            this.btnPageInfo.Size = new System.Drawing.Size(153, 23);
            this.btnPageInfo.TabIndex = 1;
            this.btnPageInfo.Text = "Get Page Information";
            this.btnPageInfo.Click += new System.EventHandler(this.btnPageInfo_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.LineVisible = true;
            this.lblPageInfo.Location = new System.Drawing.Point(189, 14);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(0, 13);
            this.lblPageInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblPageInfo;
        private DevExpress.XtraEditors.SimpleButton btnPageInfo;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnCheckLayout;
        private DevExpress.XtraEditors.SimpleButton btnPositionInfo;
        private DevExpress.XtraEditors.SimpleButton btnPageCountSelectedRange;
    }
}

