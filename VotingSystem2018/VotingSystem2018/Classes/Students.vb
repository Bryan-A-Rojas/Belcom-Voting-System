Public Class Students

    'Student Properties/Fields
    Private StudentID As Integer
    Private Name As String
    Private YearLevel As String
    Private Course As String
    Private Major As String
    Private Role As String
    Private DateVoted As String

    'Constructor
    Public Sub New(ByVal StudentID As Integer)
        'Retrieve database details of student
        getDetails(StudentID)
    End Sub

    'Retrieves student details based on their ID number
    Public Sub getDetails(ByVal condition As String)
        Database.SetSql("SELECT StudentID, Name, YearLevel, Course, Major, Role, DateVoted FROM Students WHERE StudentID = @value")
        Dim tablename As String = "Students"

        Me.setStudentID(Database.GetDataSetRow(condition, tablename, 0))
        Me.setName(Database.GetDataSetRow(condition, tablename, 1))
        Me.setYearLevel(Database.GetDataSetRow(condition, tablename, 2))
        Me.setCourse(Database.GetDataSetRow(condition, tablename, 3))
        Me.setMajor(Database.GetDataSetRow(condition, tablename, 4))
        Me.setRole(Database.GetDataSetRow(condition, tablename, 5))
        Me.setDateVoted(Database.GetDataSetRow(condition, tablename, 6))
    End Sub



    'StudentID Getter and Setter 
    Public Sub setStudentID(ByVal id As Integer)
        Me.StudentID = id
    End Sub
    Public Function getStudentID()
        getStudentID = Me.StudentID
    End Function

    'Full Name Getter and Setter 
    Public Sub setName(ByVal name As String)
        Me.Name = name
    End Sub
    Public Function getName()
        getName = Me.Name
    End Function

    'Year Level Getter and Setter 
    Public Sub setYearLevel(ByVal yearlvl As String)
        YearLevel = yearlvl
    End Sub
    Public Function getYearLevel()
        getYearLevel = YearLevel
    End Function

    'Course Getter and Setter 
    Public Sub setCourse(ByVal coursestring As String)
        Course = coursestring
    End Sub
    Public Function getCourse()
        getCourse = Course
    End Function

    'Major Getter and Setter 
    Public Sub setMajor(ByVal maj As String)
        Major = maj
    End Sub
    Public Function getMajor()
        getMajor = Major
    End Function

    'Role Getter and Setter 
    Public Sub setRole(ByVal rol As String)
        Role = rol
    End Sub
    Public Function getRole()
        getRole = Role
    End Function

    'Voted Getter and Setter 
    Public Sub setDateVoted(ByVal vote As String)
        Me.DateVoted = vote
    End Sub
    Public Function getDateVoted()
        getDateVoted = Me.DateVoted
    End Function

End Class
