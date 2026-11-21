<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        lblName = New Label()
        lblRemarks = New Label()
        lblGrade = New Label()
        lblAverage = New Label()
        lblUnitsDone = New Label()
        lblCourse = New Label()
        lblRegNo = New Label()
        lstStudents = New ListBox()
        btnNewStudent = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(97, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(155, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "STUDENT REPORT"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(29, 87)
        lblName.Name = "lblName"
        lblName.Size = New Size(134, 25)
        lblName.TabIndex = 1
        lblName.Text = "Student Name: "
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Location = New Point(20, 426)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(88, 25)
        lblRemarks.TabIndex = 2
        lblRemarks.Text = "Remarks: "
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(20, 375)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(68, 25)
        lblGrade.TabIndex = 3
        lblGrade.Text = "Grade: "
        ' 
        ' lblAverage
        ' 
        lblAverage.AutoSize = True
        lblAverage.Location = New Point(29, 320)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(86, 25)
        lblAverage.TabIndex = 4
        lblAverage.Text = "Average: "
        ' 
        ' lblUnitsDone
        ' 
        lblUnitsDone.AutoSize = True
        lblUnitsDone.Location = New Point(29, 266)
        lblUnitsDone.Name = "lblUnitsDone"
        lblUnitsDone.Size = New Size(110, 25)
        lblUnitsDone.TabIndex = 5
        lblUnitsDone.Text = "Units Taken: "
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(29, 210)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(76, 25)
        lblCourse.TabIndex = 6
        lblCourse.Text = "Course: "
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(29, 145)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(125, 25)
        lblRegNo.TabIndex = 7
        lblRegNo.Text = "Reg. Number: "
        ' 
        ' lstStudents
        ' 
        lstStudents.FormattingEnabled = True
        lstStudents.Location = New Point(346, 59)
        lstStudents.Name = "lstStudents"
        lstStudents.Size = New Size(346, 29)
        lstStudents.TabIndex = 8
        ' 
        ' btnNewStudent
        ' 
        btnNewStudent.Location = New Point(263, 502)
        btnNewStudent.Name = "btnNewStudent"
        btnNewStudent.Size = New Size(181, 42)
        btnNewStudent.TabIndex = 9
        btnNewStudent.Text = "New Student"
        btnNewStudent.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(477, 502)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(181, 42)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmReport
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 556)
        Controls.Add(btnExit)
        Controls.Add(btnNewStudent)
        Controls.Add(lstStudents)
        Controls.Add(lblRegNo)
        Controls.Add(lblCourse)
        Controls.Add(lblUnitsDone)
        Controls.Add(lblAverage)
        Controls.Add(lblGrade)
        Controls.Add(lblRemarks)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Name = "frmReport"
        Text = "Report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblUnitsDone As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents btnNewStudent As Button
    Friend WithEvents btnExit As Button
End Class
