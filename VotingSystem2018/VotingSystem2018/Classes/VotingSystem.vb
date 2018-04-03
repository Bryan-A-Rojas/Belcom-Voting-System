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
        'Concatenates the initials and last name
        'Example: James Jeremy Random = JJRandom
        'This is case and diacritic insensitive
        'last names with spaces should be type together
        Database.SetSql("SELECT Name FROM Students WHERE REPLACE([Voting_System].[dbo].[fnFirsties](SUBSTRING([Name], CHARINDEX(', ', [Name]) + 1, LEN([Name]))) + LEFT([Name], LEN([Name]) - CHARINDEX(',', REVERSE([Name]))), ' ' , '') COLLATE Latin1_general_CI_AI = @value0 COLLATE Latin1_general_CI_AI AND StudentID = @value1")
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
    'This is where you hardcode the order of candidates to vote for
    Public Sub Change_Stage()
        'SEC Voting
        Select Case Stage_Number
            Case 0
                'SEC President - Cole Moscardon, John Tenorio, Bea Nicolas
                Display_Candidates(New Candidates("1388"), New Candidates("610"), New Candidates("384"), New Candidates("1720"))
            Case 1
                'SEC Internal VP - Limma Savet
                Display_Candidates(New Candidates("924"), New Candidates("1721"))
            Case 2
                'SEC External VP - Ella Salvatierra
                Display_Candidates(New Candidates("601"), New Candidates("1722"))
            Case 3
                'SEC Secretary - Tricia Co
                Display_Candidates(New Candidates("537"), New Candidates("1723"))
            Case 4
                'SEC Auditor - Chaina Guitierrez 
                Display_Candidates(New Candidates("1252"), New Candidates("1724"))
            Case 5
                'SEC PRO - Jesper Corpuz
                Display_Candidates(New Candidates("696"), New Candidates("1725"))
            Case 6
                If Voter.getYearLevel = "3rd Year" Then
                    'SEC 4th Year Level Rep - Eiji Katsumata
                    Display_Candidates(New Candidates("1374"), New Candidates("1726"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case Is >= 7
                'Co-curricular voting part
                If Voter.getCourse = "BSIT" Then
                    Display_BITS()
                ElseIf Voter.getCourse = "BSE" Then
                    Display_BES()
                ElseIf Voter.getCourse = "BSLM" Then
                    Display_JBLC()
                ElseIf Voter.getCourse = "BSBAMM" Then
                    Display_JBMA()
                ElseIf Voter.getCourse = "BSBAFM" Then
                    Display_JFINEX()
                Else
                    endVoting()
                End If
            Case Else
        End Select
    End Sub

    Public Sub Display_BITS()
        Select Case Stage_Number
            Case 7
                'BITS President - Joshua Amon
                Display_Candidates(New Candidates("669"), New Candidates("1727"))
            Case 8
                'BITS Internal VP - Joven Vite
                Display_Candidates(New Candidates("808"), New Candidates("1728"))
            Case 9
                'BITS External VP - Ian Dizon
                Display_Candidates(New Candidates("708"), New Candidates("1729"))
            Case 10
                'BITS Secretary - Niome Raymundo
                Display_Candidates(New Candidates("84"), New Candidates("1730"))
            Case 11
                'BITS Treasurer - Lyndon Cuananan 
                Display_Candidates(New Candidates("79"), New Candidates("1731"))
            Case 12
                'BITS Auditor - Airam Santos
                Display_Candidates(New Candidates("784"), New Candidates("1732"))
            Case 13
                'PRO - Grace Sorita
                Display_Candidates(New Candidates("789"), New Candidates("1733"))
            Case 14
                If Voter.getYearLevel = "2nd Year" Then
                    '3rd Year Level Rep - John Pinque
                    Display_Candidates(New Candidates("765"), New Candidates("1735"))
                ElseIf Voter.getYearLevel = "3rd Year" Then
                    '4th Year Level Rep - Jocel Magat
                    Display_Candidates(New Candidates("743"), New Candidates("1734"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case 15
                endVoting()
        End Select
    End Sub
    Public Sub Display_BES()
        Select Case Stage_Number
            Case 7
                'President - Carlo Locsin, Pierce Katipunin
                Display_Candidates(New Candidates("640"), New Candidates("639"), New Candidates("1736"))
            Case 8
                'Internal VP - Renz Tajeda
                Display_Candidates(New Candidates("658"), New Candidates("1737"))
            Case 9
                'External VP - Daena Paruginog
                Display_Candidates(New Candidates("647"), New Candidates("1738"))
            Case 10
                'Secretary - Luane Sablan, Nicole Domingo
                Display_Candidates(New Candidates("74"), New Candidates("629"), New Candidates("1739"))
            Case 11
                'Assistant Secretary - Gwenaleen Jamandre, Raul Matamorosa
                Display_Candidates(New Candidates("638"), New Candidates("643"), New Candidates("1740"))
            Case 12
                'Treasurer - Jesryl Vera
                Display_Candidates(New Candidates("627"), New Candidates("1741"))
            Case 13
                'Auditor - Ellaiza Gelacio, Kiara Navales
                Display_Candidates(New Candidates("635"), New Candidates("646"), New Candidates("1742"))
            Case 14
                'PRO - Selene Tan
                Display_Candidates(New Candidates("657"), New Candidates("1743"))
            Case 15
                If Voter.getYearLevel = "2nd Year" Then
                    '3rd Year Level Rep - Rafael Aninon
                    Display_Candidates(New Candidates("67"), New Candidates("1745"))
                ElseIf Voter.getYearLevel = "3rd Year" Then
                    '4th Year Level Rep - Cristine Garcia
                    Display_Candidates(New Candidates("633"), New Candidates("1744"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case 16
                endVoting()
        End Select
    End Sub
    Public Sub Display_JBLC()
        Select Case Stage_Number
            Case 7
                'President - Harvey Ruiz
                Display_Candidates(New Candidates("867"), New Candidates("1746"))
            Case 8
                'Internal VP - Miguel Pangilinan
                Display_Candidates(New Candidates("862"), New Candidates("1747"))
            Case 9
                'External VP - Pete Gancita
                Display_Candidates(New Candidates("837"), New Candidates("1748"))
            Case 10
                'Secretary - Olive Daluyo
                Display_Candidates(New Candidates("90"), New Candidates("1749"))
            Case 11
                'Treasurer - Angie Carandang
                Display_Candidates(New Candidates("826"), New Candidates("1750"))
            Case 12
                'Auditor - Jones Melendes
                Display_Candidates(New Candidates("848"), New Candidates("1751"))
            Case 13
                'PRO - Nikka Cabanting
                Display_Candidates(New Candidates("823"), New Candidates("1752"))
            Case 14
                If Voter.getYearLevel = "2nd Year" Then
                    '3rd Year Level Rep - James Alcantara
                    Display_Candidates(New Candidates("89"), New Candidates("1753"))
                ElseIf Voter.getYearLevel = "3rd Year" Then
                    '4th Year Level Rep - Karla Leonado
                    Display_Candidates(New Candidates("842"), New Candidates("1754"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case 15
                endVoting()
        End Select
    End Sub
    Public Sub Display_JBMA()
        Select Case Stage_Number
            Case 7
                'President - Vianca Apostol
                Display_Candidates(New Candidates("511"), New Candidates("1755"))
            Case 8
                'External VP - Allyraine Caña
                Display_Candidates(New Candidates("531"), New Candidates("1756"))
            Case 9
                'VP for Finance - Skelly Gonzales
                Display_Candidates(New Candidates("562"), New Candidates("1757"))
            Case 10
                'VP for Creatives - Simon Suson 
                Display_Candidates(New Candidates("62"), New Candidates("1758"))
            Case 11
                'VP for Membership and Student Services - David Bato
                Display_Candidates(New Candidates("519"), New Candidates("1759"))
            Case 12
                'VP for Logistics - Clarisse Raquedan
                Display_Candidates(New Candidates("595"), New Candidates("1760"))
            Case 13
                'VP for Marketing and Sponsorship - Bea De Belen
                Display_Candidates(New Candidates("543"), New Candidates("1761"))
            Case 14
                'VP for External Activities - Andrea Domingo
                Display_Candidates(New Candidates("550"), New Candidates("1762"))
            Case 15
                If Voter.getYearLevel = "2nd Year" Then
                    '3rd Year Level Rep - Roi Toriano
                    Display_Candidates(New Candidates("63"), New Candidates("1763"))
                ElseIf Voter.getYearLevel = "3rd Year" Then
                    '4th Year Level Rep - Rachel Torres
                    Display_Candidates(New Candidates("611"), New Candidates("1764"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case 16
                endVoting()
        End Select
    End Sub
    Public Sub Display_JFINEX()
        Select Case Stage_Number
            Case 7
                'President - Micha Milambilang
                Display_Candidates(New Candidates("464"), New Candidates("1765"))
            Case 8
                'Internal VP - Ira May De Roxas
                Display_Candidates(New Candidates("443"), New Candidates("1766"))
            Case 9
                'External VP - Ella Lemoncito
                Display_Candidates(New Candidates("457"), New Candidates("1767"))
            Case 10
                'VP for Com and Promotions - Paula Revilala
                Display_Candidates(New Candidates("474"), New Candidates("1768"))
            Case 11
                'Secretary - Janine Andres
                Display_Candidates(New Candidates("432"), New Candidates("1769"))
            Case 12
                'Treasurer - Lucy Gomez
                Display_Candidates(New Candidates("450"), New Candidates("1770"))
            Case 13
                'Auditor - Neala Boo, Treasure Caranto
                Display_Candidates(New Candidates("436"), New Candidates("437"), New Candidates("1771"))
            Case 14
                If Voter.getYearLevel = "2nd Year" Then
                    '3rd Year Level Rep - Miguel Martinez
                    Display_Candidates(New Candidates("461"), New Candidates("1772"))
                ElseIf Voter.getYearLevel = "3rd Year" Then
                    '4th Year Level Rep - Camille Arnigo
                    Display_Candidates(New Candidates("434"), New Candidates("1773"))
                Else
                    Stage_Number += 1
                    Change_Stage()
                End If
            Case 15
                endVoting()
        End Select
    End Sub

    'Display the appropriate window depending on the number of candidates against each other
    Public Sub Display_Candidates(ByVal ParamArray Candidate() As Candidates)
        If Candidate.Length = 2 Then
            VotingWindowFor1.Show()
            VotingWindowFor1.lblOrganization.Text = Candidate(0).getOrganization
            VotingWindowFor1.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingWindowFor1.lblName1.Text = Candidate(0).getName
            VotingWindowFor1.lblParty1.Text = Candidate(0).getParty
            VotingWindowFor1.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getName)

            VotingWindowFor1.lblPosition.Text = "Running For " & Candidate(0).getPosition

            If Not Current_Window_Number = 1 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 1
            End If
        ElseIf Candidate.Length = 3 Then
            VotingWindowFor2.Show()
            VotingWindowFor2.lblOrganization.Text = Candidate(0).getOrganization
            VotingWindowFor2.pictureBoxCandidate1.Image = Image.FromFile(CandidateImagesDirectory & Candidate(0).getImage)
            VotingWindowFor2.lblName1.Text = Candidate(0).getName
            VotingWindowFor2.lblParty1.Text = Candidate(0).getParty
            VotingWindowFor2.radioCandidate1.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(0).getName)

            VotingWindowFor2.pictureBoxCandidate2.Image = Image.FromFile(UtilityModule.CandidateImagesDirectory & Candidate(1).getImage)
            VotingWindowFor2.lblName2.Text = Candidate(1).getName
            VotingWindowFor2.lblParty2.Text = Candidate(1).getParty
            VotingWindowFor2.radioCandidate2.Text = "Vote for" & Environment.NewLine & getFirstName(Candidate(1).getName)

            VotingWindowFor2.lblPosition.Text = "Running For " & Candidate(0).getPosition

            If Not Current_Window_Number = 2 Then
                closeWindow(Current_Window_Number)
                Current_Window_Number = 2
            End If
        ElseIf Candidate.Length = 4 Then
            VotingWindowFor3.Show()
            VotingWindowFor3.lblOrganization.Text = Candidate(0).getOrganization
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

            VotingWindowFor3.lblPosition.Text = "Running For " & Candidate(0).getPosition

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

        'Add a log into the log_history table
        Database.SetSql("INSERT INTO log_history (StudentID, CandidateID) VALUES (@value0,@value1);")
        'Using the current time, date, and the students ID number
        Database.ExecuteNonQuery(Voter.getStudentID, Current_Candidates_In_Window(vote_number).getStudentID)

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
