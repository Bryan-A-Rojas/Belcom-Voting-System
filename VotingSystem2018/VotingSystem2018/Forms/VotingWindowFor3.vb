Public Class VotingWindowFor3
    'On Load
    Private Sub VotingWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimer.Start()
    End Sub

    'Simulate real time clock
    Private Sub DateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimer.Tick
        lblDateAndTime.Text = getClock()
    End Sub

    Private Sub btnVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVote.Click
        Dim vote_number As Int16

        If Me.radioCandidate1.Checked Then
            vote_number = 0
        ElseIf Me.radioCandidate2.Checked Then
            vote_number = 1
        ElseIf Me.radioCandidate3.Checked Then
            vote_number = 2
        ElseIf Me.radioAbstain.Checked Then
            vote_number = 3
        End If

        Voting_System.Vote(vote_number)
    End Sub

    Private Sub pictureBoxCandidate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxCandidate1.Click
        Me.radioCandidate1.Checked = True
    End Sub

    Private Sub lblName1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName1.Click
        Me.radioCandidate1.Checked = True
    End Sub

    Private Sub lblParty1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblParty1.Click
        Me.radioCandidate1.Checked = True
    End Sub

    Private Sub pictureBoxCandidate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxCandidate2.Click
        Me.radioCandidate2.Checked = True
    End Sub

    Private Sub lblName2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName2.Click
        Me.radioCandidate2.Checked = True
    End Sub

    Private Sub lblParty2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblParty2.Click
        Me.radioCandidate2.Checked = True
    End Sub

    Private Sub pictureBoxCandidate3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxCandidate3.Click
        Me.radioCandidate3.Checked = True
    End Sub

    Private Sub lblName3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName3.Click
        Me.radioCandidate3.Checked = True
    End Sub

    Private Sub lblParty3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblParty3.Click
        Me.radioCandidate3.Checked = True
    End Sub
End Class