Public Class LoginForm
    'On Load
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimer.Start()

        'Max length of characters allowed in the textboxes
        txtStudentID.MaxLength = 10
        txtStudentName.MaxLength = 250

        txtStudentName.Focus()
    End Sub

    'Simulate real time clock
    Private Sub DateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimer.Tick
        lblDateAndTime.Text = getClock()
    End Sub

    'Login Button
    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login()
    End Sub
    Private Sub OnEnterKeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtStudentName.KeyDown, txtStudentID.KeyDown
        'Do the same thing as clicking login when pressing enter
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    'Login Handler Function
    Private Sub login()
        'Removes Extra white space
        StripSpaces(Me)

        'Check if any of the fields are empty
        If txtStudentID.Text = Nothing Or txtStudentName.Text = Nothing Then
            MsgBox("Please fill up all fields", MsgBoxStyle.Exclamation, "Invalid Credentials")
            txtStudentName.Focus()


            ' ElseIf txtStudentID.Text.GetType Then

            'Check if the login credentials are correct, else display error message
        ElseIf Voting_System.Login(txtStudentName.Text, txtStudentID.Text) Then
            'Check if the voter has already voted beforehand, else display "already voted"
            If Voter.getDateVoted = Nothing Then
                'Show welcome message
                MsgBox("Welcome!")

                'Show note
                MsgBox("Once you click vote, it is final. Please vote wisely.", MsgBoxStyle.Exclamation, "Warning")

                'Start voting!
                Voting_System.Change_Stage()

                'Erase the text in the two textboxes
                EraseText(Me)

                'Close login form
                Me.Close()
            Else
                MsgBox("You already voted!", MsgBoxStyle.Exclamation, "Invalid Voter")
            End If
        Else
            MsgBox("Student ID and Name do not match.Please Try Again.", MsgBoxStyle.Exclamation, "Invalid Credentials")
        End If
    End Sub

    'Prevent studentID textbox from having anything besides numbers
    Private Sub ValidationNumber_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
                              Handles txtStudentID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Not Asc(e.KeyChar) = Keys.Enter Then
                e.Handled = True
                MsgBox("Only numbers are allowed", MsgBoxStyle.Exclamation, "Warning")
            End If
        End If
    End Sub

    'Exit Button
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MsgBox("Goodbye", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
