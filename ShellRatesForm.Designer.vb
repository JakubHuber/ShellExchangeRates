<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShellRatesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBaseCurrency = New System.Windows.Forms.ComboBox()
        Me.cmbQueryCurrency = New System.Windows.Forms.ComboBox()
        Me.DTPickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTPickerTo = New System.Windows.Forms.DateTimePicker()
        Me.FramePeriods = New System.Windows.Forms.GroupBox()
        Me.OptionButtonYearly = New System.Windows.Forms.RadioButton()
        Me.OptionButtonMonthly = New System.Windows.Forms.RadioButton()
        Me.OptionButtonQuartely = New System.Windows.Forms.RadioButton()
        Me.OptionButtonDaily = New System.Windows.Forms.RadioButton()
        Me.FrameOutput = New System.Windows.Forms.GroupBox()
        Me.FrameSheetAppend = New System.Windows.Forms.GroupBox()
        Me.OptionButtonAppend = New System.Windows.Forms.RadioButton()
        Me.OptionButtonSheet = New System.Windows.Forms.RadioButton()
        Me.OptionButtonActiveWorkbook = New System.Windows.Forms.RadioButton()
        Me.OptionButtonNewWorkbook = New System.Windows.Forms.RadioButton()
        Me.ButtonTable = New System.Windows.Forms.Button()
        Me.ButtonExcel = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FramePeriods.SuspendLayout()
        Me.FrameOutput.SuspendLayout()
        Me.FrameSheetAppend.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Download site"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(123, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(333, 20)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://vt.shell.com/vtexchangerates/default.aspx"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Base Currency"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Query Currency"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "From Date"
        '
        'cmbBaseCurrency
        '
        Me.cmbBaseCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaseCurrency.FormattingEnabled = True
        Me.cmbBaseCurrency.Location = New System.Drawing.Point(127, 61)
        Me.cmbBaseCurrency.Name = "cmbBaseCurrency"
        Me.cmbBaseCurrency.Size = New System.Drawing.Size(148, 28)
        Me.cmbBaseCurrency.TabIndex = 6
        '
        'cmbQueryCurrency
        '
        Me.cmbQueryCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQueryCurrency.FormattingEnabled = True
        Me.cmbQueryCurrency.Location = New System.Drawing.Point(127, 108)
        Me.cmbQueryCurrency.Name = "cmbQueryCurrency"
        Me.cmbQueryCurrency.Size = New System.Drawing.Size(148, 28)
        Me.cmbQueryCurrency.TabIndex = 7
        '
        'DTPickerFrom
        '
        Me.DTPickerFrom.CustomFormat = "dd/MM/yyyy"
        Me.DTPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPickerFrom.Location = New System.Drawing.Point(362, 62)
        Me.DTPickerFrom.Name = "DTPickerFrom"
        Me.DTPickerFrom.Size = New System.Drawing.Size(119, 27)
        Me.DTPickerFrom.TabIndex = 8
        '
        'DTPickerTo
        '
        Me.DTPickerTo.CustomFormat = "dd/MM/yyyy"
        Me.DTPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPickerTo.Location = New System.Drawing.Point(362, 111)
        Me.DTPickerTo.Name = "DTPickerTo"
        Me.DTPickerTo.Size = New System.Drawing.Size(119, 27)
        Me.DTPickerTo.TabIndex = 9
        '
        'FramePeriods
        '
        Me.FramePeriods.Controls.Add(Me.OptionButtonYearly)
        Me.FramePeriods.Controls.Add(Me.OptionButtonMonthly)
        Me.FramePeriods.Controls.Add(Me.OptionButtonQuartely)
        Me.FramePeriods.Controls.Add(Me.OptionButtonDaily)
        Me.FramePeriods.Location = New System.Drawing.Point(505, 12)
        Me.FramePeriods.Name = "FramePeriods"
        Me.FramePeriods.Size = New System.Drawing.Size(162, 151)
        Me.FramePeriods.TabIndex = 10
        Me.FramePeriods.TabStop = False
        Me.FramePeriods.Text = "Periods"
        '
        'OptionButtonYearly
        '
        Me.OptionButtonYearly.AutoSize = True
        Me.OptionButtonYearly.Location = New System.Drawing.Point(6, 116)
        Me.OptionButtonYearly.Name = "OptionButtonYearly"
        Me.OptionButtonYearly.Size = New System.Drawing.Size(125, 24)
        Me.OptionButtonYearly.TabIndex = 3
        Me.OptionButtonYearly.TabStop = True
        Me.OptionButtonYearly.Text = "Yearly Average"
        Me.OptionButtonYearly.UseVisualStyleBackColor = True
        '
        'OptionButtonMonthly
        '
        Me.OptionButtonMonthly.AutoSize = True
        Me.OptionButtonMonthly.Location = New System.Drawing.Point(6, 56)
        Me.OptionButtonMonthly.Name = "OptionButtonMonthly"
        Me.OptionButtonMonthly.Size = New System.Drawing.Size(140, 24)
        Me.OptionButtonMonthly.TabIndex = 2
        Me.OptionButtonMonthly.TabStop = True
        Me.OptionButtonMonthly.Text = "Monthly Average"
        Me.OptionButtonMonthly.UseVisualStyleBackColor = True
        '
        'OptionButtonQuartely
        '
        Me.OptionButtonQuartely.AutoSize = True
        Me.OptionButtonQuartely.Location = New System.Drawing.Point(6, 86)
        Me.OptionButtonQuartely.Name = "OptionButtonQuartely"
        Me.OptionButtonQuartely.Size = New System.Drawing.Size(147, 24)
        Me.OptionButtonQuartely.TabIndex = 1
        Me.OptionButtonQuartely.TabStop = True
        Me.OptionButtonQuartely.Text = "Quarterly Average"
        Me.OptionButtonQuartely.UseVisualStyleBackColor = True
        '
        'OptionButtonDaily
        '
        Me.OptionButtonDaily.AutoSize = True
        Me.OptionButtonDaily.Location = New System.Drawing.Point(6, 26)
        Me.OptionButtonDaily.Name = "OptionButtonDaily"
        Me.OptionButtonDaily.Size = New System.Drawing.Size(61, 24)
        Me.OptionButtonDaily.TabIndex = 0
        Me.OptionButtonDaily.TabStop = True
        Me.OptionButtonDaily.Text = "Daily"
        Me.OptionButtonDaily.UseVisualStyleBackColor = True
        '
        'FrameOutput
        '
        Me.FrameOutput.Controls.Add(Me.FrameSheetAppend)
        Me.FrameOutput.Controls.Add(Me.OptionButtonActiveWorkbook)
        Me.FrameOutput.Controls.Add(Me.OptionButtonNewWorkbook)
        Me.FrameOutput.Controls.Add(Me.ButtonTable)
        Me.FrameOutput.Location = New System.Drawing.Point(16, 156)
        Me.FrameOutput.Name = "FrameOutput"
        Me.FrameOutput.Size = New System.Drawing.Size(483, 149)
        Me.FrameOutput.TabIndex = 11
        Me.FrameOutput.TabStop = False
        Me.FrameOutput.Text = "Output"
        '
        'FrameSheetAppend
        '
        Me.FrameSheetAppend.Controls.Add(Me.OptionButtonAppend)
        Me.FrameSheetAppend.Controls.Add(Me.OptionButtonSheet)
        Me.FrameSheetAppend.Location = New System.Drawing.Point(291, 57)
        Me.FrameSheetAppend.Name = "FrameSheetAppend"
        Me.FrameSheetAppend.Size = New System.Drawing.Size(133, 86)
        Me.FrameSheetAppend.TabIndex = 6
        Me.FrameSheetAppend.TabStop = False
        '
        'OptionButtonAppend
        '
        Me.OptionButtonAppend.AutoSize = True
        Me.OptionButtonAppend.Location = New System.Drawing.Point(10, 56)
        Me.OptionButtonAppend.Name = "OptionButtonAppend"
        Me.OptionButtonAppend.Size = New System.Drawing.Size(119, 24)
        Me.OptionButtonAppend.TabIndex = 8
        Me.OptionButtonAppend.TabStop = True
        Me.OptionButtonAppend.Text = "Append Table"
        Me.OptionButtonAppend.UseVisualStyleBackColor = True
        '
        'OptionButtonSheet
        '
        Me.OptionButtonSheet.AutoSize = True
        Me.OptionButtonSheet.Location = New System.Drawing.Point(10, 26)
        Me.OptionButtonSheet.Name = "OptionButtonSheet"
        Me.OptionButtonSheet.Size = New System.Drawing.Size(64, 24)
        Me.OptionButtonSheet.TabIndex = 7
        Me.OptionButtonSheet.TabStop = True
        Me.OptionButtonSheet.Text = "Sheet"
        Me.OptionButtonSheet.UseVisualStyleBackColor = True
        '
        'OptionButtonActiveWorkbook
        '
        Me.OptionButtonActiveWorkbook.AutoSize = True
        Me.OptionButtonActiveWorkbook.Location = New System.Drawing.Point(291, 32)
        Me.OptionButtonActiveWorkbook.Name = "OptionButtonActiveWorkbook"
        Me.OptionButtonActiveWorkbook.Size = New System.Drawing.Size(186, 24)
        Me.OptionButtonActiveWorkbook.TabIndex = 5
        Me.OptionButtonActiveWorkbook.TabStop = True
        Me.OptionButtonActiveWorkbook.Text = "Add to active workbook"
        Me.OptionButtonActiveWorkbook.UseVisualStyleBackColor = True
        '
        'OptionButtonNewWorkbook
        '
        Me.OptionButtonNewWorkbook.AutoSize = True
        Me.OptionButtonNewWorkbook.Location = New System.Drawing.Point(109, 32)
        Me.OptionButtonNewWorkbook.Name = "OptionButtonNewWorkbook"
        Me.OptionButtonNewWorkbook.Size = New System.Drawing.Size(174, 24)
        Me.OptionButtonNewWorkbook.TabIndex = 4
        Me.OptionButtonNewWorkbook.TabStop = True
        Me.OptionButtonNewWorkbook.Text = "Add to new workbook"
        Me.OptionButtonNewWorkbook.UseVisualStyleBackColor = True
        '
        'ButtonTable
        '
        Me.ButtonTable.Location = New System.Drawing.Point(6, 26)
        Me.ButtonTable.Name = "ButtonTable"
        Me.ButtonTable.Size = New System.Drawing.Size(75, 36)
        Me.ButtonTable.TabIndex = 0
        Me.ButtonTable.Text = "Button1"
        Me.ButtonTable.UseVisualStyleBackColor = True
        '
        'ButtonExcel
        '
        Me.ButtonExcel.Location = New System.Drawing.Point(16, 311)
        Me.ButtonExcel.Name = "ButtonExcel"
        Me.ButtonExcel.Size = New System.Drawing.Size(75, 36)
        Me.ButtonExcel.TabIndex = 7
        Me.ButtonExcel.Text = "Excel"
        Me.ButtonExcel.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(97, 311)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(402, 36)
        Me.ProgressBar1.TabIndex = 12
        '
        'ShellRatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 359)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonExcel)
        Me.Controls.Add(Me.FrameOutput)
        Me.Controls.Add(Me.FramePeriods)
        Me.Controls.Add(Me.DTPickerTo)
        Me.Controls.Add(Me.DTPickerFrom)
        Me.Controls.Add(Me.cmbQueryCurrency)
        Me.Controls.Add(Me.cmbBaseCurrency)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ShellRatesForm"
        Me.Text = "Form1"
        Me.FramePeriods.ResumeLayout(False)
        Me.FramePeriods.PerformLayout()
        Me.FrameOutput.ResumeLayout(False)
        Me.FrameOutput.PerformLayout()
        Me.FrameSheetAppend.ResumeLayout(False)
        Me.FrameSheetAppend.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBaseCurrency As ComboBox
    Friend WithEvents cmbQueryCurrency As ComboBox
    Friend WithEvents DTPickerFrom As DateTimePicker
    Friend WithEvents DTPickerTo As DateTimePicker
    Friend WithEvents FramePeriods As GroupBox
    Friend WithEvents OptionButtonYearly As RadioButton
    Friend WithEvents OptionButtonMonthly As RadioButton
    Friend WithEvents OptionButtonQuartely As RadioButton
    Friend WithEvents OptionButtonDaily As RadioButton
    Friend WithEvents FrameOutput As GroupBox
    Friend WithEvents FrameSheetAppend As GroupBox
    Friend WithEvents OptionButtonAppend As RadioButton
    Friend WithEvents OptionButtonSheet As RadioButton
    Friend WithEvents OptionButtonActiveWorkbook As RadioButton
    Friend WithEvents OptionButtonNewWorkbook As RadioButton
    Friend WithEvents ButtonTable As Button
    Friend WithEvents ButtonExcel As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
