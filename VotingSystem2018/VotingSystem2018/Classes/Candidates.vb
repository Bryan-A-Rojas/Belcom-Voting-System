Public MustInherit Class Candidates
    Inherits Person

    Private ID As String
    Private fullName As String
    Private Party As String
    Private Position As String
    Private Votes As Integer
    Private Image As String

    Private TableName As String

    'Update database add 1 vote for this candidate
    Sub voteFor()
        Database.SetSql("UPDATE " & Me.getTableName & " SET Votes = Votes + 1 WHERE ID = @value")
        Database.ExecuteNonQuery(Me.getID)
    End Sub

    'Retrieves data about candidate from database
    Overrides Sub getDetails(ByVal condition As String)
        Database.SetSql("SELECT ID, Name, Party, Position, Votes FROM " & Me.getTableName & " WHERE ID = @value")
        Dim tablename As String = Me.getTableName

        Me.setID(Database.GetDataSetRow(condition, tablename, 0))
        Me.setFullName(Database.GetDataSetRow(condition, tablename, 1))
        Me.setParty(Database.GetDataSetRow(condition, tablename, 2))
        Me.setPosition(Database.GetDataSetRow(condition, tablename, 3))
        Me.setVotes(Database.GetDataSetRow(condition, tablename, 4))
    End Sub


    'ID Getter and Setter 
    Public Sub setID(ByVal idnum As String)
        ID = idnum
    End Sub
    Public Function getID()
        getID = ID
    End Function

    'Full Name Getter and Setter 
    Public Sub setFullName(ByVal name As String)
        fullName = name
    End Sub
    Public Function getFullName()
        getFullName = fullName
    End Function

    'Party Getter and Setter 
    Public Sub setParty(ByVal partyvar As String)
        Party = partyvar
    End Sub
    Public Function getParty()
        getParty = Party
    End Function

    'Position Getter and Setter 
    Public Sub setPosition(ByVal positionvar As String)
        Position = positionvar
    End Sub
    Public Function getPosition()
        getPosition = Position
    End Function

    'Votes Getter and Setter 
    Public Sub setVotes(ByVal votecount As Integer)
        Votes = votecount
    End Sub
    Public Function getVotes()
        getVotes = Votes
    End Function

    'Image Getter and Setter 
    Public Sub setImage(ByRef Img As String)
        Image = Img
    End Sub
    Public Function getImage()
        getImage = Image
    End Function

    'TableName Getter and Setter
    Public Sub setTableName(ByVal str As String)
        TableName = str
    End Sub
    Public Function getTableName()
        getTableName = TableName
    End Function

End Class
