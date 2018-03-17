Public MustInherit Class Person
    'Abstract class
    'Database Instance
    Protected Database As DatabaseHelper = New DatabaseHelper _
    ("Data Source=DESKTOP-LJA6FPI;Initial Catalog=VotingSystem;Integrated Security=True")

    MustOverride Sub getDetails(ByVal condition As String)
End Class
