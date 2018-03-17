Public Class VotingSystem
    'Number to tell which part of the voting they are in
    Public Stage_Number As Int16 = 0

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

    Public Function Instantiate_ordered_candidates()
        ordered_candidates(0, 0) = Joven
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
            ChangeWindow3(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number), ordered_candidates(2, Stage_Number), ordered_candidates(3, Stage_Number))
        ElseIf Stage_Number = 1 Then
            ChangeWindow2(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number), ordered_candidates(2, Stage_Number))
            closeWindow3()
        ElseIf Stage_Number = 2 Then
            ChangeWindow1(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number))
            closeWindow2()
        ElseIf Stage_Number = 3 Then
            ChangeWindow1(ordered_candidates(0, Stage_Number), ordered_candidates(1, Stage_Number))
        ElseIf Stage_Number = 4 Then
            VotingSystem2018.LoginForm.Show()
            Voting_System.sendVotesToDatabase()
            closeWindow1()
        End If
    End Function

    Public Function ChangeWindow1(ByVal Candidate1 As Candidates, ByVal Abstain As Candidates)
        VotingSystem2018.VotingWindowFor1.Show()
        VotingSystem2018.VotingWindowFor1.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate1.getImage)
        VotingSystem2018.VotingWindowFor1.lblName1.Text = Candidate1.getFullName
        VotingSystem2018.VotingWindowFor1.lblParty1.Text = Candidate1.getParty
        VotingSystem2018.VotingWindowFor1.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate1.getFullName)
    End Function
    Public Function ChangeWindow2(ByVal Candidate1 As Candidates, ByVal Candidate2 As Candidates, ByVal Abstain As Candidates)
        VotingSystem2018.VotingWindowFor2.Show()
        VotingSystem2018.VotingWindowFor2.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate1.getImage)
        VotingSystem2018.VotingWindowFor2.lblName1.Text = Candidate1.getFullName
        VotingSystem2018.VotingWindowFor2.lblParty1.Text = Candidate1.getParty
        VotingSystem2018.VotingWindowFor2.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate1.getFullName)

        VotingSystem2018.VotingWindowFor2.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate2.getImage)
        VotingSystem2018.VotingWindowFor2.lblName2.Text = Candidate2.getFullName
        VotingSystem2018.VotingWindowFor2.lblParty2.Text = Candidate2.getParty
        VotingSystem2018.VotingWindowFor2.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate2.getFullName)
    End Function
    Public Function ChangeWindow3(ByVal Candidate1 As Candidates, ByVal Candidate2 As Candidates, ByVal Candidate3 As Candidates, ByVal Abstain As Candidates)
        VotingSystem2018.VotingWindowFor3.Show()
        VotingSystem2018.VotingWindowFor3.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate1.getImage)
        VotingSystem2018.VotingWindowFor3.lblName1.Text = Candidate1.getFullName
        VotingSystem2018.VotingWindowFor3.lblParty1.Text = Candidate1.getParty
        VotingSystem2018.VotingWindowFor3.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate1.getFullName)

        VotingSystem2018.VotingWindowFor3.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate2.getImage)
        VotingSystem2018.VotingWindowFor3.lblName2.Text = Candidate2.getFullName
        VotingSystem2018.VotingWindowFor3.lblParty2.Text = Candidate2.getParty
        VotingSystem2018.VotingWindowFor3.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate2.getFullName)

        VotingSystem2018.VotingWindowFor3.pictureBoxCandidate3.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate3.getImage)
        VotingSystem2018.VotingWindowFor3.lblName3.Text = Candidate3.getFullName
        VotingSystem2018.VotingWindowFor3.lblParty3.Text = Candidate3.getParty
        VotingSystem2018.VotingWindowFor3.radioCandidate3.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate3.getFullName)
    End Function

    Public Function closeWindow1()
        VotingSystem2018.VotingWindowFor1.Close()
    End Function
    Public Function closeWindow2()
        VotingSystem2018.VotingWindowFor2.Close()
    End Function
    Public Function closeWindow3()
        VotingSystem2018.VotingWindowFor3.Close()
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
