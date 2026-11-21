<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDetails
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
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        txtRegNo = New TextBox()
        lblRegNo = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        lblCourse = New Label()
        cboCourse = New ComboBox()
        cboUnits = New ComboBox()
        lblUnits = New Label()
        btnNext = New Button()
        btnExit = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(89, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(157, 25)
        lblTitle.TabIndex = 0
        lblTitle.Tag = "title"
        lblTitle.Text = "STUDENT DETAILS"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(35, 93)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(101, 25)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(228, 93)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(150, 31)
        txtFirstName.TabIndex = 2
        ' 
        ' txtRegNo
        ' 
        txtRegNo.Location = New Point(228, 209)
        txtRegNo.Name = "txtRegNo"
        txtRegNo.Size = New Size(150, 31)
        txtRegNo.TabIndex = 6
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(12, 209)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(180, 25)
        lblRegNo.TabIndex = 5
        lblRegNo.Text = "Registration Number:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(228, 151)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(150, 31)
        txtLastName.TabIndex = 8
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(35, 151)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(99, 25)
        lblLastName.TabIndex = 7
        lblLastName.Text = "Last Name:"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(30, 270)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(71, 25)
        lblCourse.TabIndex = 9
        lblCourse.Text = "Course:"
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(228, 262)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(182, 33)
        cboCourse.TabIndex = 10
        ' 
        ' cboUnits
        ' 
        cboUnits.FormattingEnabled = True
        cboUnits.Location = New Point(228, 316)
        cboUnits.Name = "cboUnits"
        cboUnits.Size = New Size(182, 33)
        cboUnits.TabIndex = 12
        ' 
        ' lblUnits
        ' 
        lblUnits.AutoSize = True
        lblUnits.Location = New Point(30, 319)
        lblUnits.Name = "lblUnits"
        lblUnits.Size = New Size(192, 25)
        lblUnits.TabIndex = 11
        lblUnits.Text = "Number of units done:"
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(59, 395)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 34)
        btnNext.TabIndex = 13
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(440, 395)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(246, 395)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Controls.Add(btnNext)
        Controls.Add(cboUnits)
        Controls.Add(lblUnits)
        Controls.Add(cboCourse)
        Controls.Add(lblCourse)
        Controls.Add(txtLastName)
        Controls.Add(lblLastName)
        Controls.Add(txtRegNo)
        Controls.Add(lblRegNo)
        Controls.Add(txtFirstName)
        Controls.Add(lblFirstName)
        Controls.Add(lblTitle)
        Name = "frmStudentDetails"
        Text = "Student Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboUnits As ComboBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
