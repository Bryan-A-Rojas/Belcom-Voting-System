Public Class LoginForm
    'On Load
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimer.Start()

        Label1.Parent = PictureBox1
    End Sub
    'Simulate real time clock
    Private Sub DateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimer.Tick
        lblDateAndTime.Text = getClock()
    End Sub

    'Login Button
    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Removes Extra white space
        StripSpaces(Me)

        If txtPassword.Text = Nothing Then
            MsgBox("Access Denied, Invalid Credentials", MsgBoxStyle.Exclamation, "Please input valid Credentials")
            txtPassword.Focus()
        ElseIf Voting_System.Login(txtPassword.Text) Then
            If Voting_System.Voter.getRole = "Admin" Then
                'Admin.ShowDialog()
            ElseIf Voting_System.Voter.getRole = "User" Then
                If Voting_System.Voter.getVoted = "No" Then
                    MsgBox("Welcome!")
                    Me.Close()
                Else
                    MsgBox("Alredy Voted!")
                End If
            End If
        Else
            MsgBox("Username and Password does not match. Try Again.", MsgBoxStyle.Exclamation, "Invalid Credentials")
        End If
        'Erase text afterwards
        txtPassword.Text = Nothing
    End Sub

    'Exit Button
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MsgBox("Goodbye!", MsgBoxStyle.Information)
        Me.Close()
    End Sub
    'Cancel Button
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Goodbye!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox("Vote added")

        Voting_System.ChangeInfo()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim list As String = ""
        For Each thing As Candidates In Voting_System.list_of_voted_candidates
            list = list & Environment.NewLine & thing.getFullName
        Next

        MsgBox(list)
    End Sub
End Class
