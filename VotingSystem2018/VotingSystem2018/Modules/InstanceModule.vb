Module InstanceModule

    'Global Variables

    'Database Instance
    Public Database As DatabaseHelper = New DatabaseHelper _
    ("Data Source=DESKTOP-JN1BU83;Initial Catalog=Voting_System;user id=sa;password=B1Admin")

    'Voting Systen Instance
    Public Voting_System As VotingSystem = New VotingSystem()

    'Voter Instance
    Public Voter As Students
End Module
