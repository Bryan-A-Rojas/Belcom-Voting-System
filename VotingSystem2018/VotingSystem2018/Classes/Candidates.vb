Public Class Candidates
    Inherits Students

    'Candidates Properties/Fields
    Private Image As String
    Private Party As String
    Private Position As String
    Private Organization As String

    'Constructor
    Public Sub New(ByVal StudentID As Integer)
        'Instantiate Students class
        MyBase.New(StudentID)
        'Retrieve database details of candidate
        getDetails(StudentID)
    End Sub

    'Retrieves data about candidate from database
    Public Sub getDetails(ByVal condition As String)
        'SQL Query
        Database.SetSql("SELECT Image, Party, Position, Organization FROM Candidates WHERE StudentID = @value")
        Dim tablename As String = "Candidates"

        Me.setImage(Database.GetDataSetRow(condition, tablename, 0))
        Me.setParty(Database.GetDataSetRow(condition, tablename, 1))
        Me.setPosition(Database.GetDataSetRow(condition, tablename, 2))
        Me.setOrganization(Database.GetDataSetRow(condition, tablename, 3))
    End Sub

    'Add 1 vote to this candidate in the database
    Sub voteFor()
        Database.SetSql("UPDATE Candidates SET NumberOfVotes = NumberOfVotes + 1 WHERE StudentID = @value")
        Database.ExecuteNonQuery(Me.getStudentID)
    End Sub



    'Image Getter and Setter 
    Public Sub setImage(ByRef Img As String)
        Me.Image = Img
    End Sub
    Public Function getImage()
        getImage = Me.Image
    End Function

    'Party Getter and Setter 
    Public Sub setParty(ByVal partyvar As String)
        Me.Party = partyvar
    End Sub
    Public Function getParty()
        getParty = Me.Party
    End Function

    'Position Getter and Setter 
    Public Sub setPosition(ByVal positionvar As String)
        Me.Position = positionvar
    End Sub
    Public Function getPosition()
        getPosition = Me.Position
    End Function

    'Organization Getter and Setter 
    Public Sub setOrganization(ByVal org As String)
        Me.Organization = org
    End Sub
    Public Function getOrganization()
        getOrganization = Me.Organization
    End Function

End Class
