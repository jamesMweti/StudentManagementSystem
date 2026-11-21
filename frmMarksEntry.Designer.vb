<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarksEntry
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
        lblTitle = New Label()
        lblStudent = New Label()
        lblUnit7 = New Label()
        lblUnit6 = New Label()
        lblUnit5 = New Label()
        lblUnit4 = New Label()
        lblUnit3 = New Label()
        lblUnit2 = New Label()
        lblUnit1 = New Label()
        lblUnit8 = New Label()
        txtUnit1 = New TextBox()
        txtUnit6 = New TextBox()
        txtUnit5 = New TextBox()
        txtUnit4 = New TextBox()
        txtUnit3 = New TextBox()
        txtUnit2 = New TextBox()
        txtUnit8 = New TextBox()
        txtUnit7 = New TextBox()
        lblAverage = New Label()
        lblGrade = New Label()
        lblRemarks = New Label()
        btnCalculate = New Button()
        btnViewReport = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(66, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(127, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ENTER MARKS"
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Location = New Point(12, 73)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(0, 25)
        lblStudent.TabIndex = 1
        ' 
        ' lblUnit7
        ' 
        lblUnit7.AutoSize = True
        lblUnit7.Location = New Point(12, 330)
        lblUnit7.Name = "lblUnit7"
        lblUnit7.Size = New Size(63, 25)
        lblUnit7.TabIndex = 2
        lblUnit7.Text = "Unit 7:"
        ' 
        ' lblUnit6
        ' 
        lblUnit6.AutoSize = True
        lblUnit6.Location = New Point(12, 295)
        lblUnit6.Name = "lblUnit6"
        lblUnit6.Size = New Size(63, 25)
        lblUnit6.TabIndex = 3
        lblUnit6.Text = "Unit 6:"
        ' 
        ' lblUnit5
        ' 
        lblUnit5.AutoSize = True
        lblUnit5.Location = New Point(12, 259)
        lblUnit5.Name = "lblUnit5"
        lblUnit5.Size = New Size(63, 25)
        lblUnit5.TabIndex = 4
        lblUnit5.Text = "Unit 5:"
        ' 
        ' lblUnit4
        ' 
        lblUnit4.AutoSize = True
        lblUnit4.Location = New Point(12, 224)
        lblUnit4.Name = "lblUnit4"
        lblUnit4.Size = New Size(63, 25)
        lblUnit4.TabIndex = 5
        lblUnit4.Text = "Unit 4:"
        ' 
        ' lblUnit3
        ' 
        lblUnit3.AutoSize = True
        lblUnit3.Location = New Point(12, 187)
        lblUnit3.Name = "lblUnit3"
        lblUnit3.Size = New Size(63, 25)
        lblUnit3.TabIndex = 6
        lblUnit3.Text = "Unit 3:"
        ' 
        ' lblUnit2
        ' 
        lblUnit2.AutoSize = True
        lblUnit2.Location = New Point(12, 146)
        lblUnit2.Name = "lblUnit2"
        lblUnit2.Size = New Size(63, 25)
        lblUnit2.TabIndex = 7
        lblUnit2.Text = "Unit 2:"
        ' 
        ' lblUnit1
        ' 
        lblUnit1.AutoSize = True
        lblUnit1.Location = New Point(12, 105)
        lblUnit1.Name = "lblUnit1"
        lblUnit1.Size = New Size(63, 25)
        lblUnit1.TabIndex = 8
        lblUnit1.Text = "Unit 1:"
        ' 
        ' lblUnit8
        ' 
        lblUnit8.AutoSize = True
        lblUnit8.Location = New Point(12, 378)
        lblUnit8.Name = "lblUnit8"
        lblUnit8.Size = New Size(63, 25)
        lblUnit8.TabIndex = 9
        lblUnit8.Text = "Unit 8:"
        ' 
        ' txtUnit1
        ' 
        txtUnit1.Location = New Point(81, 99)
        txtUnit1.Name = "txtUnit1"
        txtUnit1.Size = New Size(150, 31)
        txtUnit1.TabIndex = 10
        ' 
        ' txtUnit6
        ' 
        txtUnit6.Location = New Point(81, 298)
        txtUnit6.Name = "txtUnit6"
        txtUnit6.Size = New Size(150, 31)
        txtUnit6.TabIndex = 11
        ' 
        ' txtUnit5
        ' 
        txtUnit5.Location = New Point(81, 261)
        txtUnit5.Name = "txtUnit5"
        txtUnit5.Size = New Size(150, 31)
        txtUnit5.TabIndex = 12
        ' 
        ' txtUnit4
        ' 
        txtUnit4.Location = New Point(81, 224)
        txtUnit4.Name = "txtUnit4"
        txtUnit4.Size = New Size(150, 31)
        txtUnit4.TabIndex = 13
        ' 
        ' txtUnit3
        ' 
        txtUnit3.Location = New Point(81, 187)
        txtUnit3.Name = "txtUnit3"
        txtUnit3.Size = New Size(150, 31)
        txtUnit3.TabIndex = 14
        ' 
        ' txtUnit2
        ' 
        txtUnit2.Location = New Point(81, 146)
        txtUnit2.Name = "txtUnit2"
        txtUnit2.Size = New Size(150, 31)
        txtUnit2.TabIndex = 15
        ' 
        ' txtUnit8
        ' 
        txtUnit8.Location = New Point(81, 372)
        txtUnit8.Name = "txtUnit8"
        txtUnit8.Size = New Size(150, 31)
        txtUnit8.TabIndex = 16
        ' 
        ' txtUnit7
        ' 
        txtUnit7.Location = New Point(81, 335)
        txtUnit7.Name = "txtUnit7"
        txtUnit7.Size = New Size(150, 31)
        txtUnit7.TabIndex = 17
        ' 
        ' lblAverage
        ' 
        lblAverage.AutoSize = True
        lblAverage.Location = New Point(38, 431)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(93, 25)
        lblAverage.TabIndex = 18
        lblAverage.Text = "Average: -"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(38, 470)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(75, 25)
        lblGrade.TabIndex = 19
        lblGrade.Text = "Grade: -"
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Location = New Point(38, 508)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(95, 25)
        lblRemarks.TabIndex = 22
        lblRemarks.Text = "Remarks: -"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(418, 178)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(112, 40)
        btnCalculate.TabIndex = 23
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnViewReport
        ' 
        btnViewReport.Location = New Point(418, 259)
        btnViewReport.Name = "btnViewReport"
        btnViewReport.Size = New Size(112, 70)
        btnViewReport.TabIndex = 24
        btnViewReport.Text = "View Report"
        btnViewReport.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(418, 353)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 25
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmMarksEntry
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 551)
        Controls.Add(btnBack)
        Controls.Add(btnViewReport)
        Controls.Add(btnCalculate)
        Controls.Add(lblRemarks)
        Controls.Add(lblGrade)
        Controls.Add(lblAverage)
        Controls.Add(txtUnit7)
        Controls.Add(txtUnit8)
        Controls.Add(txtUnit2)
        Controls.Add(txtUnit3)
        Controls.Add(txtUnit4)
        Controls.Add(txtUnit5)
        Controls.Add(txtUnit6)
        Controls.Add(txtUnit1)
        Controls.Add(lblUnit8)
        Controls.Add(lblUnit1)
        Controls.Add(lblUnit2)
        Controls.Add(lblUnit3)
        Controls.Add(lblUnit4)
        Controls.Add(lblUnit5)
        Controls.Add(lblUnit6)
        Controls.Add(lblUnit7)
        Controls.Add(lblStudent)
        Controls.Add(lblTitle)
        Name = "frmMarksEntry"
        Text = "Marks Entry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents lblUnit7 As Label
    Friend WithEvents lblUnit6 As Label
    Friend WithEvents lblUnit5 As Label
    Friend WithEvents lblUnit4 As Label
    Friend WithEvents lblUnit3 As Label
    Friend WithEvents lblUnit2 As Label
    Friend WithEvents lblUnit1 As Label
    Friend WithEvents lblUnit8 As Label
    Friend WithEvents txtUnit1 As TextBox
    Friend WithEvents txtUnit6 As TextBox
    Friend WithEvents txtUnit5 As TextBox
    Friend WithEvents txtUnit4 As TextBox
    Friend WithEvents txtUnit3 As TextBox
    Friend WithEvents txtUnit2 As TextBox
    Friend WithEvents txtUnit8 As TextBox
    Friend WithEvents txtUnit7 As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnViewReport As Button
    Friend WithEvents btnBack As Button
End Class
