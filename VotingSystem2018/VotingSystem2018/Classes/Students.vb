Public Class Students
    Inherits Person

    Private fullName As String
    Private yearLevel As String
    Private course As String
    Private major As String
    Private password As String
    Private role As String
    Private voted As String

    'Place this in the student class instead
    'Retrieves student details based on password
    Public Overrides Sub getDetails(ByVal condition As String)
        Database.SetSql("SELECT FullName, YearLevel, Course, Major, Password, Role, Voted FROM tbl_students WHERE Password = @value")
        Dim tablename As String = "tbl_students"

        Me.setFullName(Database.GetDataSetRow(condition, tablename, 0))
        Me.setYearLevel(Database.GetDataSetRow(condition, tablename, 1))
        Me.setCourse(Database.GetDataSetRow(condition, tablename, 2))
        Me.setMajor(Database.GetDataSetRow(condition, tablename, 3))
        Me.setPassword(Database.GetDataSetRow(condition, tablename, 4))
        Me.setRole(Database.GetDataSetRow(condition, tablename, 5))
        Me.setVoted(Database.GetDataSetRow(condition, tablename, 6))
    End Sub

    'Full Name Getter and Setter 
    Public Sub setFullName(ByVal name As String)
        fullName = name
    End Sub
    Public Function getFullName()
        getFullName = fullName
    End Function

    'Year Level Getter and Setter 
    Public Sub setYearLevel(ByVal yearlvl As String)
        yearLevel = yearlvl
    End Sub
    Public Function getYearLevel()
        getYearLevel = yearLevel
    End Function

    'Course Getter and Setter 
    Public Sub setCourse(ByVal coursestring As String)
        course = coursestring
    End Sub
    Public Function getCourse()
        getCourse = course
    End Function

    'Major Getter and Setter 
    Public Sub setMajor(ByVal maj As String)
        major = maj
    End Sub
    Public Function getMajor()
        getMajor = major
    End Function

    'Password Getter and Setter 
    Public Sub setPassword(ByVal pass As String)
        password = pass
    End Sub
    Public Function getPassword()
        getPassword = password
    End Function

    'Role Getter and Setter 
    Public Sub setRole(ByVal rol As String)
        role = rol
    End Sub
    Public Function getRole()
        getRole = role
    End Function

    'Voted Getter and Setter 
    Public Sub setVoted(ByVal vote As String)
        voted = vote
    End Sub
    Public Function getVoted()
        getVoted = voted
    End Function

End Class
