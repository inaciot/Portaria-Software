Public Class splash

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then

            ProgressBar1.Value = ProgressBar1.Value + 2

        Else
           
            login.Show()

            Me.Visible = False

        End If

    End Sub

    
End Class
