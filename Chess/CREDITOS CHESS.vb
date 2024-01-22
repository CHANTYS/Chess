Public Class CREDITOS_CHESS

    Private Sub CREDITOS_CHESS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        Form1.Show()

    End Sub

    Private Sub CREDITOS_CHESS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.SendToBack()
        Label1.BringToFront()
        My.Computer.Audio.Play(My.Resources.Game_of_Thrones_Cello_Cover_Break_of_Reality, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.BringToFront()
        Label1.Location = New Point(Label1.Location.X, Label1.Location.Y - 2)
        'Label2.Location = New Point(Label2.Location.X, Label2.Location.Y - 2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class