Public Class Form1
    Dim Number1 As Integer
    Function Even(ByRef N1)
        If N1 Mod 2 = 0 Then
            ListBox1.Items.Add("The number you enetered is even")
        Else
            ListBox1.Items.Add("The number you entered is odd")
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number1 = TextBox1.Text
        Even(Number1)
    End Sub
End Class
