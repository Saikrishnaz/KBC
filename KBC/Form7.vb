Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Apke account mai apki jeeti hui keemat bheji ja chuki hai ...!!!\n (HAA / Naa) mai jawab dein ?")
        Dim ans As String
        ans = InputBox("Kya ap yeh game Phir se khelna chate hain..")
        If ans = "HAA" Or ans = "Haa" Or ans = "haa" Then
            Form1.Show()
        Else
            End
        End If

    End Sub


End Class