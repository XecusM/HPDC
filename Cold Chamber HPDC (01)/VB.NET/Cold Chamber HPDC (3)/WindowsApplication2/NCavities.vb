Public Class NCavities


    Private Sub PD3_CheckedChanged(sender As Object, e As EventArgs) Handles PD3.CheckedChanged
        N = Nmax(3)
        Pdsel = pDia(3)
        Nst.Items.Clear()
        i = Nmax(3)
        Do Until i = 0
            Nst.Items.Add(i)
            i = i - 1
        Loop
        Nst.SelectedIndex = 0
    End Sub



    Private Sub PD2_CheckedChanged(sender As Object, e As EventArgs) Handles PD2.CheckedChanged
        N = Nmax(2)
        Pdsel = pDia(2)
        Nst.Items.Clear()
        i = Nmax(2)
        Do Until i = 0
            Nst.Items.Add(i)
            i = i - 1
        Loop
        Nst.SelectedIndex = 0
    End Sub

    Private Sub PD1_CheckedChanged(sender As Object, e As EventArgs) Handles PD1.CheckedChanged
        N = Nmax(1)
        Pdsel = pDia(1)
        Nst.Items.Clear()
        i = Nmax(1)
        Do Until i = 0
            Nst.Items.Add(i)
            i = i - 1
        Loop
        Nst.SelectedIndex = 0
    End Sub



    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Nst.Text = ""
        Me.Close()
    End Sub

    Private Sub NNext_Click(sender As Object, e As EventArgs) Handles NNext.Click
        Doutput.Vwarn.Text = ""
        Nsel = Nst.Text
        Me.Hide()
        Nst.Text = ""
        Call Gate_Area()
        Select Case volfl
            Case 0
                Doutput.OverA.Text = 0
                Doutput.OverB.Text = 0
                Doutput.OverC.Text = 0
            Case Else
                Doutput.OverA.Text = OA
                Doutput.OverB.Text = OB
                Doutput.OverC.Text = Math.Round(OC, 2)
                Doutput.OverW.Text = Math.Round(Wv, 2)
                Doutput.OverL.Text = Math.Round(Lv, 2)
                Doutput.OverH.Text = Math.Round(Hv, 2)
                Doutput.OverGh.Text = Math.Round(Gv, 2)
        End Select
        Doutput.Vent.Text = OV
        Doutput.OverV.Text = Math.Round(volfl, 2)
        Doutput.DsT.Text = 10
        Doutput.WrT.Text = Math.Round(Wr, 2)
        Doutput.HrT.Text = Math.Round(Hr, 2)
        Doutput.ArT.Text = Math.Round(Ar, 2)
        Doutput.WgT.Text = Math.Round(Wgate, 2)
        Doutput.HgT.Text = Math.Round(Hg, 2)
        Doutput.DfT.Text = Math.Round(Df, 2)
        Doutput.AgT.Text = Math.Round(Agate, 2)
        Doutput.CN.Text = Nsel
        Doutput.MCT.Text = MC
        Doutput.PDT.Text = Pdsel
        Doutput.WL1T.Text = Math.Round(Wl(1), 2)
        Doutput.WL2T.Text = Math.Round(Wl(2), 2)
        Doutput.WL3T.Text = Math.Round(Wl(3), 2)
        Doutput.WL4T.Text = Math.Round(Wl(4), 2)
        Doutput.WL5T.Text = Math.Round(Wl(5), 2)
        Doutput.WL6T.Text = Math.Round(Wl(6), 2)
        Doutput.WL7T.Text = Math.Round(Wl(7), 2)
        Doutput.WL8T.Text = Math.Round(Wl(8), 2)
        Doutput.L1T.Text = Math.Round(Ll(1), 2)
        Doutput.L2T.Text = Math.Round(Ll(2), 2)
        Doutput.L3T.Text = Math.Round(Ll(3), 2)
        Doutput.L4T.Text = Math.Round(Ll(4), 2)
        Doutput.L5T.Text = Math.Round(Ll(5), 2)
        Doutput.L6T.Text = Math.Round(Ll(6), 2)
        Doutput.L7T.Text = Math.Round(Ll(7), 2)
        Doutput.L8T.Text = Math.Round(Ll(8), 2)
        Doutput.HL1T.Text = Math.Round(Hl(1), 2)
        Doutput.HL2T.Text = Math.Round(Hl(2), 2)
        Doutput.HL3T.Text = Math.Round(Hl(3), 2)
        Doutput.HL4T.Text = Math.Round(Hl(4), 2)
        Doutput.HL5T.Text = Math.Round(Hl(5), 2)
        Doutput.HL6T.Text = Math.Round(Hl(6), 2)
        Doutput.HL7T.Text = Math.Round(Hl(7), 2)
        Doutput.HL8T.Text = Math.Round(Hl(8), 2)
        Doutput.MoTT.Text = Td
        Doutput.MaTT.Text = Ti
        Doutput.BgT.Text = Bg
        Doutput.VentV.Text = Math.Round(Agate / 4, 2)
        If Wv >= Doutput.VentV.Text / OV Then
            Doutput.VentW.Text = Math.Round(Doutput.VentV.Text / OV, 2)
        Else
            Doutput.VentW.Text = Math.Round(Wv, 2)
        End If
        Doutput.TFmax.Text = tfill
        Doutput.MPS.Text = Math.Round((((vol + volfl) * 1.2 * Nsel) / ((Pdsel ^ 2) * Math.PI)) / (1000 * tfill), 2)
        f1 = Doutput.VentW.Text
        If Agate / 4 > (OV * f1) Then
            Doutput.Vwarn.Text = "Need to add a " & Math.Round(((Agate / 4) - (OV * f1)), 2) & "mm2 venting area with the same thickness"
        End If
        Doutput.GSST.Text = GSS
        Doutput.OSST.Text = OSS
        Doutput.PoroT.Text = fn
        Doutput.MatText.Text = Mat
        Doutput.DieHardness.Text = Main.DieHardness.Text
        Doutput.ShowDialog()
        Me.Close()
    End Sub
End Class