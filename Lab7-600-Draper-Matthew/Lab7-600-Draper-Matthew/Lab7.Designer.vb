<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picRunning = New System.Windows.Forms.PictureBox()
        Me.btnCalcLongTermPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblHourly = New System.Windows.Forms.Label()
        Me.lblFuture = New System.Windows.Forms.Label()
        Me.txtNumYears = New System.Windows.Forms.TextBox()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lstJobs = New System.Windows.Forms.ListBox()
        Me.lblJobsAvailable = New System.Windows.Forms.Label()
        CType(Me.picRunning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRunning
        '
        Me.picRunning.ErrorImage = Nothing
        Me.picRunning.Image = Global.Lab7_600_Draper_Matthew.My.Resources.Resources.runninggraphic
        Me.picRunning.Location = New System.Drawing.Point(12, 12)
        Me.picRunning.Name = "picRunning"
        Me.picRunning.Size = New System.Drawing.Size(364, 321)
        Me.picRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunning.TabIndex = 0
        Me.picRunning.TabStop = False
        '
        'btnCalcLongTermPay
        '
        Me.btnCalcLongTermPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcLongTermPay.Location = New System.Drawing.Point(46, 351)
        Me.btnCalcLongTermPay.Name = "btnCalcLongTermPay"
        Me.btnCalcLongTermPay.Size = New System.Drawing.Size(98, 46)
        Me.btnCalcLongTermPay.TabIndex = 1
        Me.btnCalcLongTermPay.Text = "Calculate long term pay"
        Me.btnCalcLongTermPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(162, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 46)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(278, 351)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 46)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(396, 237)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(101, 28)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "lblSalary"
        '
        'lblHourly
        '
        Me.lblHourly.AutoSize = True
        Me.lblHourly.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourly.Location = New System.Drawing.Point(396, 265)
        Me.lblHourly.Name = "lblHourly"
        Me.lblHourly.Size = New System.Drawing.Size(110, 28)
        Me.lblHourly.TabIndex = 5
        Me.lblHourly.Text = "lblHourly"
        '
        'lblFuture
        '
        Me.lblFuture.AutoSize = True
        Me.lblFuture.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuture.Location = New System.Drawing.Point(399, 368)
        Me.lblFuture.Name = "lblFuture"
        Me.lblFuture.Size = New System.Drawing.Size(96, 26)
        Me.lblFuture.TabIndex = 6
        Me.lblFuture.Text = "lblFuture"
        '
        'txtNumYears
        '
        Me.txtNumYears.Location = New System.Drawing.Point(553, 319)
        Me.txtNumYears.Name = "txtNumYears"
        Me.txtNumYears.Size = New System.Drawing.Size(64, 20)
        Me.txtNumYears.TabIndex = 7
        Me.txtNumYears.Visible = False
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.Location = New System.Drawing.Point(398, 320)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(149, 16)
        Me.lblYears.TabIndex = 8
        Me.lblYears.Text = "After so many years:"
        '
        'lstJobs
        '
        Me.lstJobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstJobs.FormattingEnabled = True
        Me.lstJobs.ItemHeight = 25
        Me.lstJobs.Items.AddRange(New Object() {"Desk Clerk", "Assistant Office Manager", "Running Specialist", "Inventory Clerk"})
        Me.lstJobs.Location = New System.Drawing.Point(401, 114)
        Me.lstJobs.Name = "lstJobs"
        Me.lstJobs.Size = New System.Drawing.Size(298, 104)
        Me.lstJobs.TabIndex = 9
        '
        'lblJobsAvailable
        '
        Me.lblJobsAvailable.Font = New System.Drawing.Font("Sitka Small", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsAvailable.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblJobsAvailable.Location = New System.Drawing.Point(393, 13)
        Me.lblJobsAvailable.Name = "lblJobsAvailable"
        Me.lblJobsAvailable.Size = New System.Drawing.Size(324, 98)
        Me.lblJobsAvailable.TabIndex = 10
        Me.lblJobsAvailable.Text = "Jobs Available at our Running Store"
        Me.lblJobsAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 414)
        Me.Controls.Add(Me.lblJobsAvailable)
        Me.Controls.Add(Me.lstJobs)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.txtNumYears)
        Me.Controls.Add(Me.lblFuture)
        Me.Controls.Add(Me.lblHourly)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcLongTermPay)
        Me.Controls.Add(Me.picRunning)
        Me.Name = "Lab7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Jobs"
        CType(Me.picRunning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRunning As PictureBox
    Friend WithEvents btnCalcLongTermPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblHourly As Label
    Friend WithEvents lblFuture As Label
    Friend WithEvents txtNumYears As TextBox
    Friend WithEvents lblYears As Label
    Friend WithEvents lstJobs As ListBox
    Friend WithEvents lblJobsAvailable As Label
End Class
