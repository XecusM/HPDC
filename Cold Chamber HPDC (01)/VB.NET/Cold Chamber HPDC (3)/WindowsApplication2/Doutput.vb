Public Class Doutput

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        Me.Hide()
        OverA.Text = ""
        OverB.Text = ""
        OverC.Text = ""
        OverV.Text = ""
        Vent.Text = ""
        WrT.Text = ""
        ArT.Text = ""
        HrT.Text = ""
        DsT.Text = ""

        Me.Close()
    End Sub

    Private Sub Doutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub ExExp_Click(sender As Object, e As EventArgs) Handles ExExp.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        saveFileDialog1.Title = "Save Parameters File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            FileOpen(1, saveFileDialog1.FileName, OpenMode.Output)
            PrintLine(1, Chr(34), SPC(0), "wp", SPC(0), Chr(34), SPC(0), "=", SPC(0), W)
            PrintLine(1, Chr(34), SPC(0), "Lp", SPC(0), Chr(34), SPC(0), "=", SPC(0), L)
            PrintLine(1, Chr(34), SPC(0), "Hp", SPC(0), Chr(34), SPC(0), "=", SPC(0), H)
            PrintLine(1, Chr(34), SPC(0), "Tp", SPC(0), Chr(34), SPC(0), "=", SPC(0), T)
            PrintLine(1, Chr(34), SPC(0), "Ap", SPC(0), Chr(34), SPC(0), "=", SPC(0), A)
            PrintLine(1, Chr(34), SPC(0), "Pp", SPC(0), Chr(34), SPC(0), "=", SPC(0), P)
            PrintLine(1, Chr(34), SPC(0), "Wg", SPC(0), Chr(34), SPC(0), "=", SPC(0), WgT.Text)
            PrintLine(1, Chr(34), SPC(0), "Hg", SPC(0), Chr(34), SPC(0), "=", SPC(0), Hg)
            PrintLine(1, Chr(34), SPC(0), "GLand", SPC(0), Chr(34), SPC(0), "=", SPC(0), Bg)
            PrintLine(1, Chr(34), SPC(0), "Gl1", SPC(0), Chr(34), SPC(0), "=", SPC(0), L1T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw1", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL1T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh1", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL1T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl2", SPC(0), Chr(34), SPC(0), "=", SPC(0), L2T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw2", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL2T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh2", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL2T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl3", SPC(0), Chr(34), SPC(0), "=", SPC(0), L3T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw3", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL3T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh3", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL3T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl4", SPC(0), Chr(34), SPC(0), "=", SPC(0), L4T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw4", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL4T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh4", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL4T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl5", SPC(0), Chr(34), SPC(0), "=", SPC(0), L5T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw5", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL5T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh5", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL5T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl6", SPC(0), Chr(34), SPC(0), "=", SPC(0), L6T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw6", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL6T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh6", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL6T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl7", SPC(0), Chr(34), SPC(0), "=", SPC(0), L7T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw7", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL7T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh7", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL7T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gl8", SPC(0), Chr(34), SPC(0), "=", SPC(0), L8T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gw8", SPC(0), Chr(34), SPC(0), "=", SPC(0), WL8T.Text)
            PrintLine(1, Chr(34), SPC(0), "Gh8", SPC(0), Chr(34), SPC(0), "=", SPC(0), HL8T.Text)
            PrintLine(1, Chr(34), SPC(0), "OA", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverA.Text)
            PrintLine(1, Chr(34), SPC(0), "OB", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverB.Text)
            PrintLine(1, Chr(34), SPC(0), "OC", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverC.Text)
            PrintLine(1, Chr(34), SPC(0), "Ow", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverW.Text)
            PrintLine(1, Chr(34), SPC(0), "Ol", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverL.Text)
            PrintLine(1, Chr(34), SPC(0), "Oh", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverH.Text)
            PrintLine(1, Chr(34), SPC(0), "Ogw", SPC(0), Chr(34), SPC(0), "=", SPC(0), OverGh.Text)
            PrintLine(1, Chr(34), SPC(0), "GSS", SPC(0), Chr(34), SPC(0), "=", SPC(0), GSST.Text)
            PrintLine(1, Chr(34), SPC(0), "OSS", SPC(0), Chr(34), SPC(0), "=", SPC(0), OSST.Text)
            PrintLine(1, Chr(34), SPC(0), "PD", SPC(0), Chr(34), SPC(0), "=", SPC(0), PDT.Text)
            PrintLine(1, Chr(34), SPC(0), "Vh", SPC(0), Chr(34), SPC(0), "=", SPC(0), Vent.Text)
            PrintLine(1, Chr(34), SPC(0), "Vw", SPC(0), Chr(34), SPC(0), "=", SPC(0), VentW.Text)
            FileClose(1)
        End If
    End Sub
End Class