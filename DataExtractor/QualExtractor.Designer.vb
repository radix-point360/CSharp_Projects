<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QualExtractor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QualExtractor))
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.dgGetData = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbLoad = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.lblCmd = New System.Windows.Forms.Label()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.txtCmd = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelcType = New System.Windows.Forms.Label()
        Me.cboSrlType = New System.Windows.Forms.ComboBox()
        Me.cboColName = New System.Windows.Forms.ComboBox()
        Me.txtDefaulVal = New System.Windows.Forms.TextBox()
        Me.lblDefaultVal = New System.Windows.Forms.Label()
        Me.btnDefaultVal = New System.Windows.Forms.Button()
        Me.cboSelInstitue = New System.Windows.Forms.ComboBox()
        CType(Me.dgGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetData
        '
        Me.btnGetData.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGetData.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnGetData.Location = New System.Drawing.Point(856, 149)
        Me.btnGetData.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(123, 35)
        Me.btnGetData.TabIndex = 0
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = False
        '
        'dgGetData
        '
        Me.dgGetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGetData.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgGetData.Location = New System.Drawing.Point(13, 345)
        Me.dgGetData.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgGetData.Name = "dgGetData"
        Me.dgGetData.Size = New System.Drawing.Size(1043, 219)
        Me.dgGetData.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbLoad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblFooter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 568)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 51)
        Me.Panel1.TabIndex = 2
        '
        'pbLoad
        '
        Me.pbLoad.Location = New System.Drawing.Point(635, 20)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(167, 17)
        Me.pbLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbLoad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(481, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version 1.0v"
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Location = New System.Drawing.Point(853, 25)
        Me.lblFooter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(173, 15)
        Me.lblFooter.TabIndex = 0
        Me.lblFooter.Text = "All Right Reserved  @QualSoft"
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExcel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnExcel.Location = New System.Drawing.Point(856, 194)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(123, 35)
        Me.btnExcel.TabIndex = 3
        Me.btnExcel.Text = "Export To Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1066, 74)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(245, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(352, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(408, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "QualSoft Data Migration Utility"
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.BackColor = System.Drawing.Color.Transparent
        Me.lblCon.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCon.Location = New System.Drawing.Point(232, 149)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(126, 17)
        Me.lblCon.TabIndex = 6
        Me.lblCon.Text = "Connection String"
        '
        'lblCmd
        '
        Me.lblCmd.AutoSize = True
        Me.lblCmd.BackColor = System.Drawing.Color.Transparent
        Me.lblCmd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCmd.Location = New System.Drawing.Point(232, 226)
        Me.lblCmd.Name = "lblCmd"
        Me.lblCmd.Size = New System.Drawing.Size(49, 17)
        Me.lblCmd.TabIndex = 7
        Me.lblCmd.Text = "Query"
        '
        'txtCon
        '
        Me.txtCon.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtCon.Location = New System.Drawing.Point(364, 149)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(438, 22)
        Me.txtCon.TabIndex = 8
        Me.txtCon.Text = "Data Source=.;Initial Catalog=SSMCLibrary;Integrated Security=True"
        '
        'txtCmd
        '
        Me.txtCmd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtCmd.Location = New System.Drawing.Point(358, 194)
        Me.txtCmd.Multiline = True
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.Size = New System.Drawing.Size(444, 95)
        Me.txtCmd.TabIndex = 9
        Me.txtCmd.Text = "Please Select Type To Auto Fill This Box"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(361, 176)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(44, 15)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "Label3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1066, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripMenuItem1.Text = "Help"
        '
        'lblSelcType
        '
        Me.lblSelcType.AutoSize = True
        Me.lblSelcType.BackColor = System.Drawing.Color.Transparent
        Me.lblSelcType.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelcType.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblSelcType.Location = New System.Drawing.Point(232, 110)
        Me.lblSelcType.Name = "lblSelcType"
        Me.lblSelcType.Size = New System.Drawing.Size(84, 17)
        Me.lblSelcType.TabIndex = 13
        Me.lblSelcType.Text = "Select Type"
        '
        'cboSrlType
        '
        Me.cboSrlType.FormattingEnabled = True
        Me.cboSrlType.Location = New System.Drawing.Point(364, 104)
        Me.cboSrlType.Name = "cboSrlType"
        Me.cboSrlType.Size = New System.Drawing.Size(121, 23)
        Me.cboSrlType.TabIndex = 14
        '
        'cboColName
        '
        Me.cboColName.FormattingEnabled = True
        Me.cboColName.Location = New System.Drawing.Point(358, 310)
        Me.cboColName.Name = "cboColName"
        Me.cboColName.Size = New System.Drawing.Size(121, 23)
        Me.cboColName.TabIndex = 15
        '
        'txtDefaulVal
        '
        Me.txtDefaulVal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtDefaulVal.Location = New System.Drawing.Point(642, 311)
        Me.txtDefaulVal.Name = "txtDefaulVal"
        Me.txtDefaulVal.Size = New System.Drawing.Size(160, 22)
        Me.txtDefaulVal.TabIndex = 16
        '
        'lblDefaultVal
        '
        Me.lblDefaultVal.AutoSize = True
        Me.lblDefaultVal.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultVal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultVal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDefaultVal.Location = New System.Drawing.Point(232, 310)
        Me.lblDefaultVal.Name = "lblDefaultVal"
        Me.lblDefaultVal.Size = New System.Drawing.Size(95, 17)
        Me.lblDefaultVal.TabIndex = 17
        Me.lblDefaultVal.Text = "Default Value"
        '
        'btnDefaultVal
        '
        Me.btnDefaultVal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDefaultVal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaultVal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnDefaultVal.Location = New System.Drawing.Point(856, 296)
        Me.btnDefaultVal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDefaultVal.Name = "btnDefaultVal"
        Me.btnDefaultVal.Size = New System.Drawing.Size(123, 35)
        Me.btnDefaultVal.TabIndex = 18
        Me.btnDefaultVal.Text = "Set Value"
        Me.btnDefaultVal.UseVisualStyleBackColor = False
        '
        'cboSelInstitue
        '
        Me.cboSelInstitue.FormattingEnabled = True
        Me.cboSelInstitue.Location = New System.Drawing.Point(496, 310)
        Me.cboSelInstitue.Name = "cboSelInstitue"
        Me.cboSelInstitue.Size = New System.Drawing.Size(140, 23)
        Me.cboSelInstitue.TabIndex = 20
        '
        'QualExtractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1066, 619)
        Me.Controls.Add(Me.cboSelInstitue)
        Me.Controls.Add(Me.btnDefaultVal)
        Me.Controls.Add(Me.lblDefaultVal)
        Me.Controls.Add(Me.txtDefaulVal)
        Me.Controls.Add(Me.cboColName)
        Me.Controls.Add(Me.cboSrlType)
        Me.Controls.Add(Me.lblSelcType)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtCmd)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.lblCmd)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgGetData)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "QualExtractor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QualExtractor"
        CType(Me.dgGetData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetData As Button
    Friend WithEvents dgGetData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnExcel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbLoad As ProgressBar
    Friend WithEvents lblCon As Label
    Friend WithEvents lblCmd As Label
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtCmd As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblSelcType As Label
    Friend WithEvents cboSrlType As ComboBox
    Friend WithEvents cboColName As ComboBox
    Friend WithEvents txtDefaulVal As TextBox
    Friend WithEvents lblDefaultVal As Label
    Friend WithEvents btnDefaultVal As Button
    Friend WithEvents cboSelInstitue As ComboBox
End Class
