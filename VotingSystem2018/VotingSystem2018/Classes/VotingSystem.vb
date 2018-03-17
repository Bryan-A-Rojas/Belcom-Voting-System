Public Class VotingSystem
    'Number to tell which part of the voting they are in
    Private Stage_Number As Int16 = 0

    'Current Window being used
    Private Current_Window_Number As Int16 = 0

    'Student Voter Instance
    Public Voter As Students = New Students

    'Candidates Instance
    'List all the candidates and their names

    'BITS
    Public Joven As Candidates = New BITS("19")
    Public Patricia As Candidates = New BITS("22")
    Public Grace As Candidates = New BITS("23")
    Public Abstain As Candidates = New BITS("24")

    Public Adriel As Candidates = New BITS("1")
    Public Martino As Candidates = New BITS("2")
    Public Abstain1 As Candidates = New BITS("3")

    Public Aljohn As Candidates = New BITS("4")
    Public Abstain2 As Candidates = New BITS("5")

    Public Abstain3 As Candidates = New BITS("6")

    'Note: for some reason arrays are 0 indexed but still
    'continue to their actual length
    Public ordered_candidates(10, 4) As Candidates

    'Stores the candidates you voted for
    Public list_of_voted_candidates As ArrayList = New ArrayList()

    Public Sub New()
        'Load all the candidates at the start
        InstantiateCandidates()
    End Sub

    Public Function Instantiate_ordered_candidates()
        ordered_candidates(0, 0) = Joven
        ' ordered_candidates(0, 0) = New BITS("19")
        'ordered_candidates(0, 0).setImage("secretary.png")
        ordered_candidates(1, 0) = Patricia
        ordered_candidates(2, 0) = Grace
        ordered_candidates(3, 0) = Abstain

        ordered_candidates(0, 1) = Adriel
        ordered_candidates(1, 1) = Martino
        ordered_candidates(2, 1) = Abstain1

        ordered_candidates(0, 2) = Aljohn
        ordered_candidates(1, 2) = Abstain2

        ordered_candidates(0, 3) = Aljohn
        ordered_candidates(1, 3) = Abstain3

    End Function

    Public Sub InstantiateCandidates()
        'BITS

        'Joven
        Joven.setImage("secretary.png")
        'Patricia Maranan
        Patricia.setImage("secretary.png")
        'Grace
        Grace.setImage("secretary.png")
        'Abstain
        Abstain.setImage("")

        Adriel.setImage("secretary.png")
        Martino.setImage("secretary.png")
        Abstain1.setImage("secretary.png")

        Aljohn.setImage("secretary.png")
        Abstain2.setImage("secretary.png")

        Instantiate_ordered_candidates()

        'Erase SQL entry
        'Database.SetSql(Nothing)
    End Sub

    'Returns true if an account exists
    Public Function Login(ByVal password As String) As Boolean
        Voter.getDetails(password)
        'If the database did not retrieve anything return false
        If Not Voter.getPassword = Nothing Then
            Login = True
        Else
            Login = False
        End If
    End Function

    Public Function ChangeInfo()
        'This is where you hardcode the order of candidates to vote for
        If Stage_Number = 0 Then
            ChangeWindow(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number), ordered_candidates(2, Stage_Number))
        ElseIf Stage_Number = 1 Then
            ChangeWindow(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number))
        ElseIf Stage_Number = 2 Then
            ChangeWindow(ordered_candidates(0, Stage_Number))
        ElseIf Stage_Number = 3 Then
            ChangeWindow(ordered_candidates(0, Stage_Number))
        ElseIf Stage_Number = 4 Then
            
            'Send the votes to the database
            Voting_System.sendVotesToDatabase()

            'Close the last window manually
            closeWindow(Current_Window_Number)

            'Go back to the login menu
            VotingSystem2018.LoginForm.Show()

        End If
    End Function

    Public Function ChangeWindow(ByVal ParamArray Candidate() As Candidates)
        If Candidate.Length = 1 Then
            VotingSystem2018.VotingWindowFor1.Show()
            VotingSystem2018.VotingWindowFor1.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingSystem2018.VotingWindowFor1.lblName1.Text = Candidate(0).getFullName
            VotingSystem2018.VotingWindowFor1.lblParty1.Text = Candidate(0).getParty
            VotingSystem2018.VotingWindowFor1.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getFullName)

            If Not Current_Window_Number = 1 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 1
            End If
        ElseIf Candidate.Length = 2 Then
            VotingSystem2018.VotingWindowFor2.Show()
            VotingSystem2018.VotingWindowFor2.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingSystem2018.VotingWindowFor2.lblName1.Text = Candidate(0).getFullName
            VotingSystem2018.VotingWindowFor2.lblParty1.Text = Candidate(0).getParty
            VotingSystem2018.VotingWindowFor2.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getFullName)

            VotingSystem2018.VotingWindowFor2.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(1).getImage)
            VotingSystem2018.VotingWindowFor2.lblName2.Text = Candidate(1).getFullName
            VotingSystem2018.VotingWindowFor2.lblParty2.Text = Candidate(1).getParty
            VotingSystem2018.VotingWindowFor2.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(1).getFullName)

            If Not Current_Window_Number = 2 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 2
            End If
        ElseIf Candidate.Length = 3 Then
            VotingSystem2018.VotingWindowFor3.Show()
            VotingSystem2018.VotingWindowFor3.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingSystem2018.VotingWindowFor3.lblName1.Text = Candidate(0).getFullName
            VotingSystem2018.VotingWindowFor3.lblParty1.Text = Candidate(0).getParty
            VotingSystem2018.VotingWindowFor3.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getFullName)

            VotingSystem2018.VotingWindowFor3.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(1).getImage)
            VotingSystem2018.VotingWindowFor3.lblName2.Text = Candidate(1).getFullName
            VotingSystem2018.VotingWindowFor3.lblParty2.Text = Candidate(1).getParty
            VotingSystem2018.VotingWindowFor3.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(1).getFullName)

            VotingSystem2018.VotingWindowFor3.pictureBoxCandidate3.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(2).getImage)
            VotingSystem2018.VotingWindowFor3.lblName3.Text = Candidate(2).getFullName
            VotingSystem2018.VotingWindowFor3.lblParty3.Text = Candidate(2).getParty
            VotingSystem2018.VotingWindowFor3.radioCandidate3.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(2).getFullName)

            If Not Current_Window_Number = 3 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 3
            End If
        End If

    End Function

    Public Function closeWindow(ByVal Window_Number As Int16)
        If Window_Number = 1 Then
            VotingSystem2018.VotingWindowFor1.Close()
        ElseIf Window_Number = 2 Then
            VotingSystem2018.VotingWindowFor2.Close()
        ElseIf Window_Number = 3 Then
            VotingSystem2018.VotingWindowFor3.Close()
        End If
    End Function

    Public Function Vote(ByVal vote_number As Int16) As Candidates
        If vote_number = 0 Then
            list_of_voted_candidates.Add(ordered_candidates(0, Stage_Number))
        ElseIf vote_number = 1 Then
            list_of_voted_candidates.Add(ordered_candidates(1, Stage_Number))
        ElseIf vote_number = 2 Then
            list_of_voted_candidates.Add(ordered_candidates(2, Stage_Number))
        ElseIf vote_number = 3 Then
            list_of_voted_candidates.Add(ordered_candidates(3, Stage_Number))
        End If

        Stage_Number += 1
        ChangeInfo()
    End Function

    Public Function sendVotesToDatabase()
        'Loop through all the voted candidates at the end
        For Each candidate As Candidates In list_of_voted_candidates
            candidate.voteFor()
        Next
    End Function

End Class
