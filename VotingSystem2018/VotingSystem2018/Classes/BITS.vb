Public Class BITS
    Inherits Candidates

    'Constructor
    'On object creation, set ID and get details of the candidate from the database
    Public Sub New(ByVal ID As String)
        Me.setTableName("tbl_candidates_BITS")
        MyBase.getDetails(ID)
    End Sub

End Class
