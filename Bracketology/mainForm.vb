Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initMain()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SetRounds()
        'ControlExists("testBox1")
        'Me.Controls.Remove(Me.Controls("testbox1"))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearPictureBoxes()
    End Sub
End Class
