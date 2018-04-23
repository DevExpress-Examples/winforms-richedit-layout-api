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

        '#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.checkEdit9 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit8 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit7 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit5 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkbtnCustomDraw = New DevExpress.XtraEditors.CheckButton()
            Me.btnPageCountSelectedRange = New DevExpress.XtraEditors.SimpleButton()
            Me.btnPositionInfo = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCheckLayout = New DevExpress.XtraEditors.SimpleButton()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.btnPageInfo = New DevExpress.XtraEditors.SimpleButton()
            Me.lblPageInfo = New DevExpress.XtraEditors.LabelControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.checkEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.EnableToolTips = True
            Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
            Me.richEditControl1.Options.Fields.UpdateFieldsInTextBoxes = False
            Me.richEditControl1.Options.Printing.EnableCommentBackgroundOnPrint = False
            Me.richEditControl1.Options.Printing.EnableCommentFillOnPrint = False
            Me.richEditControl1.Size = New System.Drawing.Size(876, 526)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.simpleButton2)
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Controls.Add(Me.checkbtnCustomDraw)
            Me.panelControl1.Controls.Add(Me.btnPageCountSelectedRange)
            Me.panelControl1.Controls.Add(Me.btnPositionInfo)
            Me.panelControl1.Controls.Add(Me.btnCheckLayout)
            Me.panelControl1.Controls.Add(Me.trackBarControl1)
            Me.panelControl1.Controls.Add(Me.btnPageInfo)
            Me.panelControl1.Controls.Add(Me.lblPageInfo)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 526)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(876, 149)
            Me.panelControl1.TabIndex = 1
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(463, 55)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(145, 27)
            Me.simpleButton2.TabIndex = 17
            Me.simpleButton2.Text = "Print Preview"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.checkEdit9)
            Me.panelControl2.Controls.Add(Me.checkEdit4)
            Me.panelControl2.Controls.Add(Me.checkEdit8)
            Me.panelControl2.Controls.Add(Me.checkEdit1)
            Me.panelControl2.Controls.Add(Me.checkEdit7)
            Me.panelControl2.Controls.Add(Me.checkEdit2)
            Me.panelControl2.Controls.Add(Me.checkEdit3)
            Me.panelControl2.Controls.Add(Me.checkEdit5)
            Me.panelControl2.Enabled = False
            Me.panelControl2.Location = New System.Drawing.Point(646, 24)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(200, 100)
            Me.panelControl2.TabIndex = 15
            ' 
            ' checkEdit9
            ' 
            Me.checkEdit9.Location = New System.Drawing.Point(97, 53)
            Me.checkEdit9.Name = "checkEdit9"
            Me.checkEdit9.Properties.Caption = "Page"
            Me.checkEdit9.Size = New System.Drawing.Size(77, 19)
            Me.checkEdit9.TabIndex = 15
            ' 
            ' checkEdit4
            ' 
            Me.checkEdit4.Location = New System.Drawing.Point(97, 28)
            Me.checkEdit4.Name = "checkEdit4"
            Me.checkEdit4.Properties.Caption = "Inline Picture"
            Me.checkEdit4.Size = New System.Drawing.Size(88, 19)
            Me.checkEdit4.TabIndex = 10
            ' 
            ' checkEdit8
            ' 
            Me.checkEdit8.Location = New System.Drawing.Point(14, 53)
            Me.checkEdit8.Name = "checkEdit8"
            Me.checkEdit8.Properties.Caption = "Header"
            Me.checkEdit8.Size = New System.Drawing.Size(77, 19)
            Me.checkEdit8.TabIndex = 14
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(14, 5)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Text"
            Me.checkEdit1.Size = New System.Drawing.Size(77, 19)
            Me.checkEdit1.TabIndex = 7
            ' 
            ' checkEdit7
            ' 
            Me.checkEdit7.Location = New System.Drawing.Point(97, 75)
            Me.checkEdit7.Name = "checkEdit7"
            Me.checkEdit7.Properties.Caption = "Numbering List"
            Me.checkEdit7.Size = New System.Drawing.Size(96, 19)
            Me.checkEdit7.TabIndex = 13
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.Location = New System.Drawing.Point(97, 4)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Floating Picture"
            Me.checkEdit2.Size = New System.Drawing.Size(97, 19)
            Me.checkEdit2.TabIndex = 8
            ' 
            ' checkEdit3
            ' 
            Me.checkEdit3.Location = New System.Drawing.Point(14, 28)
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = "Table"
            Me.checkEdit3.Size = New System.Drawing.Size(77, 19)
            Me.checkEdit3.TabIndex = 9
            ' 
            ' checkEdit5
            ' 
            Me.checkEdit5.Location = New System.Drawing.Point(14, 78)
            Me.checkEdit5.Name = "checkEdit5"
            Me.checkEdit5.Properties.Caption = "Text Box"
            Me.checkEdit5.Size = New System.Drawing.Size(77, 19)
            Me.checkEdit5.TabIndex = 11
            ' 
            ' checkbtnCustomDraw
            ' 
            Me.checkbtnCustomDraw.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
            Me.checkbtnCustomDraw.Location = New System.Drawing.Point(463, 24)
            Me.checkbtnCustomDraw.Name = "checkbtnCustomDraw"
            Me.checkbtnCustomDraw.Size = New System.Drawing.Size(145, 23)
            Me.checkbtnCustomDraw.TabIndex = 6
            Me.checkbtnCustomDraw.Text = "Custom Draw Layout"
            ' 
            ' btnPageCountSelectedRange
            ' 
            Me.btnPageCountSelectedRange.Location = New System.Drawing.Point(12, 81)
            Me.btnPageCountSelectedRange.Name = "btnPageCountSelectedRange"
            Me.btnPageCountSelectedRange.Size = New System.Drawing.Size(153, 23)
            Me.btnPageCountSelectedRange.TabIndex = 5
            Me.btnPageCountSelectedRange.Text = "Get Page Count for Selection"
            ' 
            ' btnPositionInfo
            ' 
            Me.btnPositionInfo.Location = New System.Drawing.Point(12, 9)
            Me.btnPositionInfo.Name = "btnPositionInfo"
            Me.btnPositionInfo.Size = New System.Drawing.Size(153, 23)
            Me.btnPositionInfo.TabIndex = 4
            Me.btnPositionInfo.Text = "Get Selected Position Info"
            ' 
            ' btnCheckLayout
            ' 
            Me.btnCheckLayout.Location = New System.Drawing.Point(12, 117)
            Me.btnCheckLayout.Name = "btnCheckLayout"
            Me.btnCheckLayout.Size = New System.Drawing.Size(153, 23)
            Me.btnCheckLayout.TabIndex = 3
            Me.btnCheckLayout.Text = "Check Layout"
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.EditValue = 100
            Me.trackBarControl1.Location = New System.Drawing.Point(284, 72)
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
            Me.trackBarControl1.Size = New System.Drawing.Size(239, 72)
            Me.trackBarControl1.TabIndex = 2
            Me.trackBarControl1.Value = 100
            ' 
            ' btnPageInfo
            ' 
            Me.btnPageInfo.Location = New System.Drawing.Point(12, 45)
            Me.btnPageInfo.Name = "btnPageInfo"
            Me.btnPageInfo.Size = New System.Drawing.Size(153, 23)
            Me.btnPageInfo.TabIndex = 1
            Me.btnPageInfo.Text = "Get Page Information"
            ' 
            ' lblPageInfo
            ' 
            Me.lblPageInfo.LineVisible = True
            Me.lblPageInfo.Location = New System.Drawing.Point(189, 14)
            Me.lblPageInfo.Name = "lblPageInfo"
            Me.lblPageInfo.Size = New System.Drawing.Size(0, 13)
            Me.lblPageInfo.TabIndex = 0
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("borole_16x16.png", "images/business%20objects/borole_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/borole_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "borole_16x16.png")
            Me.imageCollection1.InsertGalleryImage("employeeaward_16x16.png", "devav/people/employeeaward_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/employeeaward_16x16.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "employeeaward_16x16.png")
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(876, 675)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.checkEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        '#End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private lblPageInfo As DevExpress.XtraEditors.LabelControl
        Private WithEvents btnPageInfo As DevExpress.XtraEditors.SimpleButton
        Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
        Private WithEvents btnCheckLayout As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnPositionInfo As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnPageCountSelectedRange As DevExpress.XtraEditors.SimpleButton
        Private WithEvents checkbtnCustomDraw As DevExpress.XtraEditors.CheckButton
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private WithEvents checkEdit5 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit4 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit7 As DevExpress.XtraEditors.CheckEdit
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents checkEdit8 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit9 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

