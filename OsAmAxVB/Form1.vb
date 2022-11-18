Public Class Form1
    Dim BinA, Trash As Decimal
    Dim Op As Char

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + Button10.Text
        BinA = TextBox1.Text

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + Button7.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + Button8.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + Button9.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + Button4.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + Button5.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + Button6.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + Button1.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + Button2.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + Button3.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + Button12.Text
        BinA = TextBox1.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Op = "+"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Op = "-"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Op = "/"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Op = "*"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Op = "%"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        BinA = TextBox1.Text
        TextBox1.Text = Math.Sqrt(BinA)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        BinA = TextBox1.Text
        TextBox1.Text = BinA * BinA
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Op = "^"
        Trash = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        BinA = TextBox1.Text
        TextBox1.Text = Math.Log(BinA)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Op = "+" Then
            TextBox1.Text = Trash + BinA
        ElseIf Op = "-" Then
            TextBox1.Text = Trash - BinA
        ElseIf Op = "/" Then
            TextBox1.Text = Trash / BinA
        ElseIf Op = "*" Then
            TextBox1.Text = Trash * BinA
        ElseIf Op = "%" Then
            TextBox1.Text = Trash / BinA * 100
        ElseIf Op = "^" Then
            TextBox1.Text = Trash ^ BinA
        Else
            TextBox1.Text = TextBox1.Text

        End If
    End Sub
End Class

'Please Follow My Github Repository @nawabusamabhatti'
