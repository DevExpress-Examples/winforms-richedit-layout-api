Namespace LayoutApiSimpleExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim trackBarLabel1 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel2 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel3 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel4 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel5 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel6 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel7 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel8 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel9 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel10 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel11 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnPageCountSelectedRange = New DevExpress.XtraEditors.SimpleButton()
			Me.btnPositionInfo = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCheckLayout = New DevExpress.XtraEditors.SimpleButton()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.btnPageInfo = New DevExpress.XtraEditors.SimpleButton()
			Me.lblPageInfo = New DevExpress.XtraEditors.LabelControl()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			DirectCast(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.EnableToolTips = True
			Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Options.Bookmarks.AllowNameResolution = False
			Me.richEditControl1.Options.Printing.EnableCommentBackgroundOnPrint = False
			Me.richEditControl1.Options.Printing.EnableCommentFillOnPrint = False
			Me.richEditControl1.Size = New System.Drawing.Size(784, 492)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnPageCountSelectedRange)
			Me.panelControl1.Controls.Add(Me.btnPositionInfo)
			Me.panelControl1.Controls.Add(Me.btnCheckLayout)
			Me.panelControl1.Controls.Add(Me.trackBarControl1)
			Me.panelControl1.Controls.Add(Me.btnPageInfo)
			Me.panelControl1.Controls.Add(Me.lblPageInfo)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 492)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(784, 149)
			Me.panelControl1.TabIndex = 1
			' 
			' btnPageCountSelectedRange
			' 
			Me.btnPageCountSelectedRange.Location = New System.Drawing.Point(12, 81)
			Me.btnPageCountSelectedRange.Name = "btnPageCountSelectedRange"
			Me.btnPageCountSelectedRange.Size = New System.Drawing.Size(153, 23)
			Me.btnPageCountSelectedRange.TabIndex = 5
			Me.btnPageCountSelectedRange.Text = "Get Page Count for Selection"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnPageCountSelectedRange.Click += new System.EventHandler(this.btnPageCountSelectedRange_Click);
			' 
			' btnPositionInfo
			' 
			Me.btnPositionInfo.Location = New System.Drawing.Point(12, 9)
			Me.btnPositionInfo.Name = "btnPositionInfo"
			Me.btnPositionInfo.Size = New System.Drawing.Size(153, 23)
			Me.btnPositionInfo.TabIndex = 4
			Me.btnPositionInfo.Text = "Get Selected Position Info"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnPositionInfo.Click += new System.EventHandler(this.btnPositionInfo_Click);
			' 
			' btnCheckLayout
			' 
			Me.btnCheckLayout.Location = New System.Drawing.Point(12, 117)
			Me.btnCheckLayout.Name = "btnCheckLayout"
			Me.btnCheckLayout.Size = New System.Drawing.Size(153, 23)
			Me.btnCheckLayout.TabIndex = 3
			Me.btnCheckLayout.Text = "Check Layout"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnCheckLayout.Click += new System.EventHandler(this.btnCheckLayout_Click);
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = 100
			Me.trackBarControl1.Location = New System.Drawing.Point(502, 6)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			trackBarLabel1.Label = "0"
			trackBarLabel2.Label = "100"
			trackBarLabel2.Value = 100
			trackBarLabel3.Label = "200"
			trackBarLabel3.Value = 200
			trackBarLabel4.Label = "300"
			trackBarLabel4.Value = 300
			trackBarLabel5.Label = "400"
			trackBarLabel5.Value = 400
			trackBarLabel6.Label = "500"
			trackBarLabel6.Value = 500
			trackBarLabel7.Label = "600"
			trackBarLabel7.Value = 600
			trackBarLabel8.Label = "700"
			trackBarLabel8.Value = 700
			trackBarLabel9.Label = "800"
			trackBarLabel9.Value = 800
			trackBarLabel10.Label = "900"
			trackBarLabel10.Value = 900
			trackBarLabel11.Label = "1000"
			trackBarLabel11.Value = 1000
			Me.trackBarControl1.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() { trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11})
			Me.trackBarControl1.Properties.Maximum = 300
			Me.trackBarControl1.Properties.ShowLabels = True
			Me.trackBarControl1.Properties.SmallChange = 10
			Me.trackBarControl1.Properties.TickFrequency = 10
			Me.trackBarControl1.Size = New System.Drawing.Size(270, 72)
			Me.trackBarControl1.TabIndex = 2
			Me.trackBarControl1.Value = 100
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
			' 
			' btnPageInfo
			' 
			Me.btnPageInfo.Location = New System.Drawing.Point(12, 45)
			Me.btnPageInfo.Name = "btnPageInfo"
			Me.btnPageInfo.Size = New System.Drawing.Size(153, 23)
			Me.btnPageInfo.TabIndex = 1
			Me.btnPageInfo.Text = "Get Page Information"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnPageInfo.Click += new System.EventHandler(this.btnPageInfo_Click);
			' 
			' lblPageInfo
			' 
			Me.lblPageInfo.LineVisible = True
			Me.lblPageInfo.Location = New System.Drawing.Point(189, 14)
			Me.lblPageInfo.Name = "lblPageInfo"
			Me.lblPageInfo.Size = New System.Drawing.Size(0, 13)
			Me.lblPageInfo.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(784, 641)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			DirectCast(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private lblPageInfo As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnPageInfo As DevExpress.XtraEditors.SimpleButton
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private WithEvents btnCheckLayout As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnPositionInfo As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnPageCountSelectedRange As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

