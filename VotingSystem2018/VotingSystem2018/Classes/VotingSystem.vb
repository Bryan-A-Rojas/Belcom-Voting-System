Public Class VotingSystem
    'Number to tell which part of the voting they are in
    Private Stage_Number As Int16 = 0

    'Current window being used
    Private Current_Window_Number As Int16 = 0

    'Current set of candidates being voted against
    Private Current_Candidates_In_Window() As Candidates

    'Stores the candidates they voted for
    Public list_of_voted_candidates As ArrayList = New ArrayList()

    'Returns true if an account exists
    Public Function Login(ByVal StudentName As String, ByVal StudentID As String) As Boolean
        'SQL Query
        Database.SetSql("SELECT Name FROM Students WHERE Name = @value0 AND StudentID = @value1")
        Dim tablename As String = "Students"
        Dim conditions() As String = {StudentName, StudentID}

        'If the query returned nothing then return false, else instantiate a student as the new voter and return true
        If Database.GetDataSetRow(conditions, tablename, 0) = Nothing Then
            Login = False
        Else
            Voter = New Students(StudentID)
            Login = True
        End If
    End Function

    'Change the window and information to be displayed
    Public Sub Change_Stage()
        'This is where you hardcode the order of candidates to vote for
        Select Case Stage_Number
            Case 0
                Display_Candidates(New Candidates("9"), New Candidates("10"))
            Case 1
                Display_Candidates(New Candidates("9"), New Candidates("9"), New Candidates("10"))
            Case 2
                Display_Candidates(New Candidates("9"), New Candidates("9"), New Candidates("9"), New Candidates("10"))
            Case 3
                endVoting()
            Case Else
        End Select
    End Sub

    'Display the appropriate window depending on the number of candidates against each other
    Public Sub Display_Candidates(ByVal ParamArray Candidate() As Candidates)
        If Candidate.Length = 2 Then
            VotingWindowFor1.Show()
            VotingWindowFor1.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingWindowFor1.lblName1.Text = Candidate(0).getName
            VotingWindowFor1.lblParty1.Text = Candidate(0).getParty
            VotingWindowFor1.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getName)

            VotingWindowFor1.lblPosition.Text = "For " & Candidate(0).getPosition

            If Not Current_Window_Number = 1 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 1
            End If
        ElseIf Candidate.Length = 3 Then
            VotingWindowFor2.Show()
            VotingWindowFor2.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingWindowFor2.lblName1.Text = Candidate(0).getName
            VotingWindowFor2.lblParty1.Text = Candidate(0).getParty
            VotingWindowFor2.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getName)

            VotingWindowFor2.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(1).getImage)
            VotingWindowFor2.lblName2.Text = Candidate(1).getName
            VotingWindowFor2.lblParty2.Text = Candidate(1).getParty
            VotingWindowFor2.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(1).getName)

            VotingWindowFor2.lblPosition.Text = "For " & Candidate(0).getPosition

            If Not Current_Window_Number = 2 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 2
            End If
        ElseIf Candidate.Length = 4 Then
            VotingWindowFor3.Show()
            VotingWindowFor3.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingWindowFor3.lblName1.Text = Candidate(0).getName
            VotingWindowFor3.lblParty1.Text = Candidate(0).getParty
            VotingWindowFor3.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getName)

            VotingWindowFor3.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(1).getImage)
            VotingWindowFor3.lblName2.Text = Candidate(1).getName
            VotingWindowFor3.lblParty2.Text = Candidate(1).getParty
            VotingWindowFor3.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(1).getName)

            VotingWindowFor3.pictureBoxCandidate3.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(2).getImage)
            VotingWindowFor3.lblName3.Text = Candidate(2).getName
            VotingWindowFor3.lblParty3.Text = Candidate(2).getParty
            VotingWindowFor3.radioCandidate3.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(2).getName)

            VotingWindowFor3.lblPosition.Text = "For " & Candidate(0).getPosition

            If Not Current_Window_Number = 3 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 3
            End If
        End If

        Current_Candidates_In_Window = Candidate
    End Sub

    'Execute the last part of the voting
    Public Sub endVoting()
        'Send the votes to the database
        sendVotesToDatabase()

        'Update DateVoted of student voter
        Database.SetSql("UPDATE students SET DateVoted = @value0 WHERE StudentID = @value1")
        'Using the current time, date, and the students ID number
        Database.ExecuteNonQuery(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Voter.getStudentID)

        'Go back to the login menu
        LoginForm.Show()

        'Close the last window manually
        closeWindow(Current_Window_Number)

        'Reset variables and fields
        reset()

        'Show thank you message
        MsgBox("Thank you for voting!")
    End Sub

    'Resets everything
    Public Sub reset()
        Stage_Number = 0
        Current_Window_Number = 0
        Current_Candidates_In_Window = Nothing
        list_of_voted_candidates.Clear()
        Voter = Nothing
    End Sub

    'Closes the window
    Public Sub closeWindow(ByVal Window_Number As Int16)
        If Window_Number = 1 Then
            VotingWindowFor1.Close()
        ElseIf Window_Number = 2 Then
            VotingWindowFor2.Close()
        ElseIf Window_Number = 3 Then
            VotingWindowFor3.Close()
        End If
    End Sub

    Public Sub Vote(ByVal vote_number As Integer)
        'Add the voted candidate to the array list
        list_of_voted_candidates.Add(Current_Candidates_In_Window(vote_number))

        'Increment the stage number
        Stage_Number += 1

        'Show the next stage
        Change_Stage()
    End Sub

    Public Sub sendVotesToDatabase()
        'Loop through all the voted candidates
        For Each candidate As Candidates In list_of_voted_candidates
            candidate.voteFor()
        Next
    End Sub

End Class
