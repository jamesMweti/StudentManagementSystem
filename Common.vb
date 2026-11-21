' ============================================================
' Common.vb  -  the common module that stores ALL shared variables
' Add via: Project > Add Module > name it "Common"
'' ============================================================
'Imports System.Drawing
'Imports System.Windows.Forms

Module Common

    ' ---------- Limits ----------
    Public Const MaxStudents As Integer = 100
    Public Const MaxUnits As Integer = 8

    ' ---------- Arrays that store the student data (NO database) ----------
    Public studentNames(MaxStudents - 1) As String            ' Student name array
    Public studentRegNos(MaxStudents - 1) As String
    Public studentCourses(MaxStudents - 1) As String
    Public studentUnitCount(MaxStudents - 1) As Integer
    Public studentUnits(MaxStudents - 1, MaxUnits - 1) As String   ' Student units array
    Public studentScores(MaxStudents - 1, MaxUnits - 1) As Double  ' Student scores array
    Public studentAverages(MaxStudents - 1) As Double
    Public studentGrades(MaxStudents - 1) As String
    Public studentRemarks(MaxStudents - 1) As String

    ' ---------- Counters ----------
    Public studentCount As Integer = 0        ' how many students are stored
    Public currentStudent As Integer = -1     ' index of the student shown on the report

    ' ---------- Details passed from Form 1 to Form 2 ----------
    Public pendingFirstName As String
    Public pendingLastName As String
    Public pendingRegNo As String
    Public pendingCourse As String
    Public pendingUnitCount As Integer

    ' ---------- Course list ----------
    Public Courses() As String = {
        "Software Engineering",
        "Computer Science",
        "Information Technology"
    }

    ' ---------- Colours / fonts used by every form (consistent design) ----------
    Public ReadOnly ColorBack As Color = Color.FromArgb(240, 244, 250)
    Public ReadOnly ColorPrimary As Color = Color.FromArgb(25, 55, 109)
    Public ReadOnly ColorAccent As Color = Color.FromArgb(0, 150, 136)
    Public ReadOnly ColorText As Color = Color.FromArgb(33, 37, 41)
    Public ReadOnly BaseFont As New Font("Segoe UI", 10.5F)
    Public ReadOnly TitleFont As New Font("Segoe UI", 20.0F, FontStyle.Bold)

    ' ---------- Units for each course (edit these to match your syllabus) ----------
    Public Function GetCourseUnits(course As String) As String()
        Select Case course
            Case "Software Engineering"
                Return {"Visual Programming", "Database Systems", "Software Design", "Web Development",
                        "Data Structures", "Computer Networks", "Operating Systems", "Software Testing"}
            Case "Computer Science"
                Return {"Algorithms", "Discrete Mathematics", "Artificial Intelligence", "Computer Architecture",
                        "Programming Languages", "Theory of Computation", "Compilers", "Machine Learning"}
            Case Else
                Return {"Systems Administration", "Network Security", "Web Technologies", "IT Project Management",
                        "Cloud Computing", "Mobile Applications", "Digital Forensics", "E-Commerce Systems"}
        End Select
    End Function

    ' ---------- Grading chart ----------
    Public Function GetGrade(avg As Double) As String
        If avg >= 70 Then
            Return "A"
        ElseIf avg >= 60 Then
            Return "B"
        ElseIf avg >= 50 Then
            Return "C"
        ElseIf avg >= 40 Then
            Return "D"
        Else
            Return "Fail"
        End If
    End Function

    Public Function GetRemark(avg As Double) As String
        Select Case GetGrade(avg)
            Case "A" : Return "Excellent"
            Case "B" : Return "Very good"
            Case "C" : Return "Good"
            Case "D" : Return "Fair"
            Case Else : Return "Pull up your socks"
        End Select
    End Function

    Public Function GradeColor(grade As String) As Color
        Select Case grade
            Case "A" : Return Color.FromArgb(46, 125, 50)
            Case "B" : Return Color.FromArgb(25, 118, 210)
            Case "C" : Return Color.FromArgb(0, 150, 136)
            Case "D" : Return Color.FromArgb(245, 150, 20)
            Case Else : Return Color.FromArgb(198, 40, 40)
        End Select
    End Function

    ' ---------- One theme for all forms ----------
    ' Call ApplyTheme(Me) in each form's Load event.
    ' Give the heading label on each form the Tag value "title".
    Public Sub ApplyTheme(frm As Form)
        frm.BackColor = ColorBack
        frm.Font = BaseFont
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.MaximizeBox = False
        ThemeControls(frm.Controls)
    End Sub

    Private Sub ThemeControls(ctrls As Control.ControlCollection)
        For Each c As Control In ctrls
            If TypeOf c Is Button Then
                Dim b As Button = DirectCast(c, Button)
                b.FlatStyle = FlatStyle.Flat
                b.FlatAppearance.BorderSize = 0
                b.BackColor = ColorPrimary
                b.ForeColor = Color.White
                b.Cursor = Cursors.Hand
                b.Height = 38
            ElseIf TypeOf c Is Label Then
                If Convert.ToString(c.Tag) = "title" Then
                    c.Font = TitleFont
                    c.ForeColor = ColorPrimary
                Else
                    c.ForeColor = ColorText
                End If
            ElseIf TypeOf c Is TextBox OrElse TypeOf c Is ComboBox OrElse TypeOf c Is ListBox Then
                c.ForeColor = ColorText
                c.BackColor = Color.White
            End If
            If c.HasChildren Then ThemeControls(c.Controls)
        Next
    End Sub

    ' ---------- Small helper ----------
    Public Function IsBlank(s As String) As Boolean
        Return String.IsNullOrWhiteSpace(s)
    End Function

End Module
