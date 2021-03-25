Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbkode.Items.Add("PAKET1")
        cbkode.Items.Add("PAKET2")
        cbkode.Items.Add("PAKET3")
        cbkode.Text = "Pilih Paket"

    End Sub

    Private Sub cbkode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkode.SelectedIndexChanged
        If cbkode.Text = "PAKET1" Then
            np.Text = "BLOCk 500 K BOT + 1 JT Click"
            hp.Text = "100000"
        End If
        If cbkode.Text = "PAKET2" Then
            np.Text = "BLOCk 2500 JT BOT + 2,5 JT Click"
            hp.Text = "200000"
        End If
        If cbkode.Text = "PAKET3" Then
            np.Text = "BLOCk 5500 JT BOT + UNLI Click"
            hp.Text = "400000"
        End If
        jm.Focus()
    End Sub

    Private Sub jm_TextChanged(sender As Object, e As EventArgs) Handles jm.TextChanged

    End Sub

    Private Sub jm_KeyDown(sender As Object, e As KeyEventArgs) Handles jm.KeyDown
        If e.KeyCode = Keys.Enter Then
            jmh.Text = Val(jm.Text) * Val(hp.Text)

            If Val(jm.Text) <= 5 Then

                ds.Text = "0"
                RadioButton1.Checked = True
            End If
            If Val(jm.Text) >= 6 And Val(jm.Text) <= 10 Then
                ds.Text = Val(jm.Text) * Val(hp.Text) * 0.05
                RadioButton2.Checked = True
            End If
            If Val(jm.Text) >= 11 Then
                ds.Text = Val(jm.Text) * Val(hp.Text) * 0.1
                RadioButton3.Checked = True
            End If
        End If
        tot.Text = Val(jmh.Text) - Val(ds.Text)
    End Sub
End Class
