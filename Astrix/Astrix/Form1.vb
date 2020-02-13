Public Class Form1
    Dim Number As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub CreateDisplay(ByRef V1)
        Dim counter As Integer = 0
        Dim sidecouner As Integer = 0
        While counter < V1
            counter += 1
            While sidecouner < V1
                sidecouner += 1

            End While
            ListBox1.Items.Add(StrDup(sidecouner, "*"))
        End While

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number = TextBox1.Text
        CreateDisplay(Number)
    End Sub
End Class
