Public Class Form1



    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.Enabled = False
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        txtFNums.Text = "Un"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        txtFNums.Text = "Deux"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = False
        btn4.Enabled = True
        btn5.Enabled = True
        txtFNums.Text = "Trois"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = False
        btn5.Enabled = True
        txtFNums.Text = "Quatre"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = False
        txtFNums.Text = "Cinq"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
