Module InstanceModule

    'Global Variables

    'Database Instance
    Public Database As DatabaseHelper = New DatabaseHelper _
    ("Data Source=DESKTOP-LJA6FPI;Initial Catalog=Voting_System;Integrated Security=True")

    'Voting Systen Instance
    Public Voting_System As VotingSystem = New VotingSystem()

    'Voter Instance
    Public Voter As Students
End Module
