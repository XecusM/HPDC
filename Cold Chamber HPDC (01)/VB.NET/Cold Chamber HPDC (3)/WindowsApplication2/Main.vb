Public Class Main



    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shapelist.Enabled = False
        shapelist.SelectedIndex = 0
        Lab1.Text = "W: Width (mm)"
        Doutput.Lab1.Text = "W: Width (mm)"
        Lab2.Text = "L: Length (mm)"
        Doutput.Lab2.Text = "L: Length (mm)"
        Lab3.Text = "H: Height (mm)"
        Doutput.Lab3.Text = "H: Height (mm)"
        Lab4.Text = "T: Thickness (mm)"
        Doutput.Lab4.Text = "T: Thickness (mm)"
        Lab5.Text = "A: Angle (degree)"
        Doutput.Lab5.Text = "A: Angle (degree)"
        Lab6.Text = "P: Parting Line Height (mm)"
        Doutput.Lab6.Text = "P: Parting Line Height (mm)"
        Txt1.Text = ""
        Doutput.Txt1.Text = ""
        Txt2.Text = ""
        Doutput.Txt2.Text = ""
        Txt3.Text = ""
        Doutput.Txt3.Text = ""
        Txt4.Text = ""
        Doutput.Txt4.Text = ""
        Txt5.Text = ""
        Doutput.Txt5.Text = ""
        Txt6.Text = ""
        Doutput.Txt6.Text = ""
        Txt1.Enabled = True
        Txt2.Enabled = True
        Txt3.Enabled = True
        Txt4.Enabled = True
        Txt5.Enabled = True
        Txt6.Enabled = True
        Lab1.Visible = True
        Doutput.Lab1.Visible = True
        Lab2.Visible = True
        Doutput.Lab2.Visible = True
        Lab3.Visible = True
        Doutput.Lab3.Visible = True
        Lab4.Visible = True
        Doutput.Lab4.Visible = True
        Lab5.Visible = True
        Doutput.Lab5.Visible = True
        Lab6.Visible = True
        Doutput.Lab6.Visible = True
        Txt1.Visible = True
        Doutput.Txt1.Visible = True
        Txt2.Visible = True
        Doutput.Txt2.Visible = True
        Txt3.Visible = True
        Doutput.Txt3.Visible = True
        Txt4.Visible = True
        Doutput.Txt4.Visible = True
        Txt5.Visible = True
        Doutput.Txt5.Visible = True
        Txt6.Visible = True
        Doutput.Txt6.Visible = True
        ShapePic.Image = My.Resources.Parallelogram
        Doutput.ShapePic.Image = My.Resources.Parallelogram
        Doutput.Shape.Text = "Parallelogram"
    End Sub

    Private Sub ExButton_Click(sender As Object, e As EventArgs) Handles ExButton.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Machlist.SelectedIndexChanged
        Select Case Machlist.Text
            Case "150 TON"
                LFText.Text = "1500 KN"
                IFText.Text = "182 KN"
                PDText.Text = "45-50-60 mm"
                ISText.Text = "0.1~7 m/sec"
                IStText.Text = "340 mm"
                MC = Machlist.Text
                lforce = 1500
                iforce = 182
                pDia(1) = 45
                pDia(2) = 50
                pDia(3) = 60
                iSpeed(1) = 0.1
                iSpeed(2) = 7
                iStroke = 340
                MCvol(1) = 362 * 1000
                MCvol(2) = 447 * 1000
                MCvol(3) = 644 * 1000
                Pm(1, 1) = 522 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(1, 2) = 1056 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 1) = 422 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 2) = 856 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 1) = 293 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 2) = 594 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Ca(1, 1) = 239 * 100
                Ca(1, 2) = 118 * 100
                Ca(2, 1) = 296 * 100
                Ca(2, 2) = 146 * 100
                Ca(3, 1) = 426 * 100
                Ca(3, 2) = 210 * 100
            Case "250 TON"
                LFText.Text = "2500 KN"
                IFText.Text = "270 KN"
                PDText.Text = "50-60-70 mm"
                ISText.Text = "0.1~7 m/sec"
                IStText.Text = "420 mm"
                MC = Machlist.Text
                lforce = 2500
                iforce = 270
                pDia(1) = 50
                pDia(2) = 60
                pDia(3) = 70
                iSpeed(1) = 0.1
                iSpeed(2) = 7
                iStroke = 420
                MCvol(1) = 540 * 1000
                MCvol(2) = 777 * 1000
                MCvol(3) = 1058 * 1000
                Pm(1, 1) = 687 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(1, 2) = 1374 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 1) = 477 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 2) = 954 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 1) = 350 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 2) = 700 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Ca(1, 1) = 363 * 100
                Ca(1, 2) = 181 * 100
                Ca(2, 1) = 524 * 100
                Ca(2, 2) = 262 * 100
                Ca(3, 1) = 714 * 100
                Ca(3, 2) = 357 * 100
            Case "420 TON"
                LFText.Text = "4200 KN"
                IFText.Text = "350 KN"
                PDText.Text = "60-70-80 mm"
                ISText.Text = "0.1~7 m/sec"
                IStText.Text = "500 mm"
                MC = Machlist.Text
                lforce = 4200
                iforce = 350
                pDia(1) = 60
                pDia(2) = 70
                pDia(3) = 80
                iSpeed(1) = 0.1
                iSpeed(2) = 7
                iStroke = 500
                MCvol(1) = 904 * 1000
                MCvol(2) = 1230 * 1000
                MCvol(3) = 1607 * 1000
                Pm(1, 1) = 600 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(1, 2) = 1200 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 1) = 441 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 2) = 882 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 1) = 337 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 2) = 674 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Ca(1, 1) = 584 * 100
                Ca(1, 2) = 292 * 100
                Ca(2, 1) = 794 * 100
                Ca(2, 2) = 397 * 100
                Ca(3, 1) = 1036 * 100
                Ca(3, 2) = 518 * 100
            Case "500 TON"
                LFText.Text = "5000 KN"
                IFText.Text = "500 KN"
                PDText.Text = "70-80-90 mm"
                ISText.Text = "0.1~7 m/sec"
                IStText.Text = "630 mm"
                MC = Machlist.Text
                lforce = 5000
                iforce = 500
                pDia(1) = 70
                pDia(2) = 80
                pDia(3) = 90
                iSpeed(1) = 0.1
                iSpeed(2) = 7
                iStroke = 630
                MCvol(1) = 1788 * 1000
                MCvol(2) = 2336 * 1000
                MCvol(3) = 2956 * 1000
                Pm(1, 1) = 707 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(1, 2) = 1416 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 1) = 541 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 2) = 1084 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 1) = 427 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 2) = 857 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Ca(1, 1) = 919 * 100
                Ca(1, 2) = 459 * 100
                Ca(2, 1) = 1201 * 100
                Ca(2, 2) = 599 * 100
                Ca(3, 1) = 1522 * 100
                Ca(3, 2) = 775 * 100
            Case "650 TON"
                LFText.Text = "6500 KN"
                IFText.Text = "545 KN"
                PDText.Text = "70-80-90 mm"
                ISText.Text = "0.1~7 m/sec"
                IStText.Text = "630 mm"
                MC = Machlist.Text
                lforce = 6500
                iforce = 545
                pDia(1) = 70
                pDia(2) = 80
                pDia(3) = 90
                iSpeed(1) = 0.1
                iSpeed(2) = 7
                iStroke = 630
                MCvol(1) = 1788 * 1000
                MCvol(2) = 2336 * 1000
                MCvol(3) = 2956 * 1000
                Pm(1, 1) = 707 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(1, 2) = 1416 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 1) = 541 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(2, 2) = 1084 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 1) = 427 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Pm(3, 2) = 857 * (10 ^ 5) / ((10 ^ 6) * 1000)
                Ca(1, 1) = 919 * 100
                Ca(1, 2) = 459 * 100
                Ca(2, 1) = 1201 * 100
                Ca(2, 2) = 599 * 100
                Ca(3, 1) = 1522 * 100
                Ca(3, 2) = 775 * 100
            Case Else
                LFText.Text = ""
                IFText.Text = ""
                PDText.Text = ""
                ISText.Text = ""
                IStText.Text = ""
                MC = ""
                lforce = 0
                iforce = 0
                pDia(1) = 0
                pDia(2) = 0
                pDia(3) = 0
                iSpeed(1) = 0
                iSpeed(2) = 0
                iStroke = 0
                MCvol(1) = 0
                MCvol(2) = 0
                MCvol(3) = 0

        End Select
    End Sub

    Private Sub shapelist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shapelist.SelectedIndexChanged
        Select Case shapelist.Text
            Case "Parallelogram"
                Lab1.Text = "W: Width (mm)"
                Doutput.Lab1.Text = "W: Width (mm)"
                Lab2.Text = "L: Length (mm)"
                Doutput.Lab2.Text = "L: Length (mm)"
                Lab3.Text = "H: Height (mm)"
                Doutput.Lab3.Text = "H: Height (mm)"
                Lab4.Text = "T: Thickness (mm)"
                Doutput.Lab4.Text = "T: Thickness (mm)"
                Lab5.Text = "A: Angle (degree)"
                Doutput.Lab5.Text = "A: Angle (degree)"
                Lab6.Text = "P: Parting Line Height (mm)"
                Doutput.Lab6.Text = "P: Parting Line Height (mm)"
                Txt1.Text = ""
                Doutput.Txt1.Text = ""
                Txt2.Text = ""
                Doutput.Txt2.Text = ""
                Txt3.Text = ""
                Doutput.Txt3.Text = ""
                Txt4.Text = ""
                Doutput.Txt4.Text = ""
                Txt5.Text = ""
                Doutput.Txt5.Text = ""
                Txt6.Text = ""
                Doutput.Txt6.Text = ""
                Txt1.Enabled = True
                Txt2.Enabled = True
                Txt3.Enabled = True
                Txt4.Enabled = True
                Txt5.Enabled = True
                Txt6.Enabled = True
                Lab1.Visible = True
                Doutput.Lab1.Visible = True
                Lab2.Visible = True
                Doutput.Lab2.Visible = True
                Lab3.Visible = True
                Doutput.Lab3.Visible = True
                Lab4.Visible = True
                Doutput.Lab4.Visible = True
                Lab5.Visible = True
                Doutput.Lab5.Visible = True
                Lab6.Visible = True
                Doutput.Lab6.Visible = True
                Txt1.Visible = True
                Doutput.Txt1.Visible = True
                Txt2.Visible = True
                Doutput.Txt2.Visible = True
                Txt3.Visible = True
                Doutput.Txt3.Visible = True
                Txt4.Visible = True
                Doutput.Txt4.Visible = True
                Txt5.Visible = True
                Doutput.Txt5.Visible = True
                Txt6.Visible = True
                Doutput.Txt6.Visible = True
                ShapePic.Image = My.Resources.Parallelogram
                Doutput.ShapePic.Image = My.Resources.Parallelogram
                Doutput.Shape.Text = "Parallelogram"
            Case "Cylinder"
                Lab1.Text = "D: Diameter (mm)"
                Doutput.Lab1.Text = "D: Diameter (mm)"
                Lab2.Text = "H: Height (mm)"
                Doutput.Lab2.Text = "H: Height (mm)"
                Lab3.Text = "T: Thickness (mm)"
                Doutput.Lab3.Text = "T: Thickness (mm)"
                Lab4.Text = "P: Parting Line Height (mm)"
                Doutput.Lab4.Text = "P: Parting Line Height (mm)"
                Txt1.Text = ""
                Doutput.Txt1.Text = ""
                Txt2.Text = ""
                Doutput.Txt2.Text = ""
                Txt3.Text = ""
                Doutput.Txt3.Text = ""
                Txt4.Text = ""
                Doutput.Txt4.Text = ""
                Txt5.Text = ""
                Doutput.Txt5.Text = ""
                Txt6.Text = ""
                Doutput.Txt6.Text = ""
                ShapePic.Image = My.Resources.Cylinder
                Doutput.ShapePic.Image = My.Resources.Cylinder
                Txt1.Enabled = True
                Txt2.Enabled = True
                Txt3.Enabled = True
                Txt4.Enabled = True
                Lab1.Visible = True
                Doutput.Lab1.Visible = True
                Lab2.Visible = True
                Doutput.Lab2.Visible = True
                Lab3.Visible = True
                Doutput.Lab3.Visible = True
                Lab4.Visible = True
                Doutput.Lab4.Visible = True
                Lab5.Visible = False
                Doutput.Lab5.Visible = False
                Lab6.Visible = False
                Doutput.Lab6.Visible = False
                Txt1.Visible = True
                Doutput.Txt1.Visible = True
                Txt2.Visible = True
                Doutput.Txt2.Visible = True
                Txt3.Visible = True
                Doutput.Txt3.Visible = True
                Txt4.Visible = True
                Doutput.Txt4.Visible = True
                Txt5.Visible = False
                Doutput.Txt5.Visible = False
                Txt6.Visible = False
                Doutput.Txt6.Visible = False
                Doutput.Shape.Text = "Cylinder"
            Case "Hexagonal"
                Lab1.Text = "W: Width (mm)"
                Doutput.Lab1.Text = "W: Width (mm)"
                Lab2.Text = "H: Height (mm)"
                Doutput.Lab2.Text = "H: Height (mm)"
                Lab3.Text = "T: Thickness (mm)"
                Doutput.Lab3.Text = "T: Thickness (mm)"
                Lab4.Text = "P: Parting Line Height (mm)"
                Doutput.Lab4.Text = "P: Parting Line Height (mm)"
                Txt1.Text = ""
                Doutput.Txt1.Text = ""
                Txt2.Text = ""
                Doutput.Txt2.Text = ""
                Txt3.Text = ""
                Doutput.Txt3.Text = ""
                Txt4.Text = ""
                Doutput.Txt4.Text = ""
                Txt5.Text = ""
                Doutput.Txt5.Text = ""
                Txt6.Text = ""
                Doutput.Txt6.Text = ""
                ShapePic.Image = My.Resources.Hexagonal
                Doutput.ShapePic.Image = My.Resources.Hexagonal
                Txt1.Enabled = True
                Txt2.Enabled = True
                Txt3.Enabled = True
                Txt4.Enabled = True
                Lab1.Visible = True
                Doutput.Lab1.Visible = True
                Lab2.Visible = True
                Doutput.Lab2.Visible = True
                Lab3.Visible = True
                Doutput.Lab3.Visible = True
                Lab4.Visible = True
                Doutput.Lab4.Visible = True
                Lab5.Visible = False
                Doutput.Lab5.Visible = False
                Lab6.Visible = False
                Doutput.Lab6.Visible = False
                Txt1.Visible = True
                Doutput.Txt1.Visible = True
                Txt2.Visible = True
                Doutput.Txt2.Visible = True
                Txt3.Visible = True
                Doutput.Txt3.Visible = True
                Txt4.Visible = True
                Doutput.Txt4.Visible = True
                Txt5.Visible = False
                Doutput.Txt5.Visible = False
                Txt6.Visible = False
                Doutput.Txt6.Visible = False
                Doutput.Shape.Text = "Hexagonal"
            Case "Arc"
                Lab1.Text = "W: Width (mm)"
                Doutput.Lab1.Text = "W: Width (mm)"
                Lab2.Text = "L: Length (mm)"
                Doutput.Lab2.Text = "L: Length (mm)"
                Lab3.Text = "H: Height (mm)"
                Doutput.Lab3.Text = "H: Height (mm)"
                Lab4.Text = "T: Thickness (mm)"
                Doutput.Lab4.Text = "T: Thickness (mm)"
                Lab5.Text = "R: Radius (mm)"
                Doutput.Lab5.Text = "R: Radius (mm)"
                Lab6.Text = "P: Parting Line Height (mm)"
                Doutput.Lab5.Text = "P: Parting Line Height (mm)"
                Txt1.Text = ""
                Doutput.Txt1.Text = ""
                Txt2.Text = ""
                Doutput.Txt2.Text = ""
                Txt3.Text = ""
                Doutput.Txt3.Text = ""
                Txt4.Text = ""
                Doutput.Txt4.Text = ""
                Txt5.Text = ""
                Doutput.Txt5.Text = ""
                Txt6.Text = ""
                Doutput.Txt6.Text = ""
                ShapePic.Image = My.Resources.Arc
                Doutput.ShapePic.Image = My.Resources.Arc
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                Txt4.Enabled = False
                Txt5.Enabled = False
                Txt6.Enabled = False
                Lab1.Visible = True
                Doutput.Lab1.Visible = True
                Lab2.Visible = True
                Doutput.Lab2.Visible = True
                Lab3.Visible = True
                Doutput.Lab3.Visible = True
                Lab4.Visible = True
                Doutput.Lab4.Visible = True
                Lab5.Visible = True
                Doutput.Lab5.Visible = True
                Lab6.Visible = True
                Doutput.Lab6.Visible = True
                Txt1.Visible = True
                Doutput.Txt1.Visible = True
                Txt2.Visible = True
                Doutput.Txt2.Visible = True
                Txt3.Visible = True
                Doutput.Txt3.Visible = True
                Txt4.Visible = True
                Doutput.Txt4.Visible = True
                Txt5.Visible = True
                Doutput.Txt5.Visible = True
                Txt6.Visible = True
                Doutput.Txt6.Visible = True
                Doutput.Shape.Text = "Arc"
            Case Else
                Lab1.Visible = False
                Lab2.Visible = False
                Lab3.Visible = False
                Lab4.Visible = False
                Lab5.Visible = False
                Lab6.Visible = False
                Txt1.Visible = False
                Txt2.Visible = False
                Txt3.Visible = False
                Txt4.Visible = False
                Txt5.Visible = False
                Txt6.Visible = False
                ShapePic.Image = Nothing
        End Select
    End Sub


    Private Sub AbButton_Click(sender As Object, e As EventArgs) Handles AbButton.Click
        About.ShowDialog()

    End Sub


    Private Sub CalButton_Click(sender As Object, e As EventArgs) Handles CalButton.Click
        NCavities.Nst.Items.Clear()
        If Mat = "" Then
            MsgBox("Part mateial must be selected")
            Exit Sub
        End If
        If iforce = 0 Then
            MsgBox("Machine type must be selected")
            Exit Sub
        End If
        If Ti = 0 Then
            MsgBox("Metal temperature must be selected")
            Exit Sub
        End If
        If Td = 0 Then
            MsgBox("Mold temperature must be selected")
            Exit Sub
        End If
        Select Case shapelist.Text
            Case "Parallelogram"
                Call Parallelogram_data()
            Case "Cylinder"
                Call Cylinder_data()
            Case "Hexagonal"
                Call Hexagonal_data()
            Case "Arc"
                Call Arc_data()
            Case Else
                Call Gate_go()
        End Select
    End Sub

    Private Sub Parallelogram_data()
        On Error GoTo Handler
        If Txt1.Text = "" Or Txt2.Text = "" Or Txt3.Text = "" Or Txt4.Text = "" Or Txt5.Text = "" Or Txt6.Text = "" Then
            MsgBox("Shape Parameters cannot leave blank !")
            Exit Sub
        End If
        If Txt5.Text < 50 Or Txt5.Text > 90 Then
            MsgBox("A angle must fall between 50~90 degree")
            Exit Sub
        End If
        If Txt4.Text > 3 Then
            MsgBox("A thickness must be under 3 mm")
            Exit Sub
        End If
        W = Txt1.Text
        Doutput.Txt1.Text = W
        L = Txt2.Text
        Doutput.Txt2.Text = L
        H = Txt3.Text
        Doutput.Txt3.Text = H
        T = Txt4.Text
        Doutput.Txt4.Text = T
        A = Txt5.Text
        Doutput.Txt5.Text = A
        P = Txt6.Text
        Doutput.Txt6.Text = P
        Shape = shapelist.Text
        Call Parallelogram_Calc()
        Exit Sub
Handler:
        Call Gate_go()

    End Sub
    Private Sub Cylinder_data()
        On Error GoTo Handler
        If Txt1.Text = "" Or Txt2.Text = "" Or Txt3.Text = "" Or Txt4.Text = "" Then
            MsgBox("Shape Parameters cannot leave blank !")
            Exit Sub
        End If
        If Txt3.Text > 3 Then
            MsgBox("A thickness must be under 3 mm")
            Exit Sub
        End If
        D = Txt1.Text
        Doutput.Txt1.Text = D
        H = Txt2.Text
        Doutput.Txt2.Text = H
        T = Txt3.Text
        Doutput.Txt3.Text = T
        P = Txt4.Text
        Doutput.Txt4.Text = P
        Shape = shapelist.Text
        Call Cylinder_Calc()
        Exit Sub
Handler:
        Call Gate_go()

    End Sub
    Private Sub Hexagonal_data()
        On Error GoTo Handler
        If Txt1.Text = "" Or Txt2.Text = "" Or Txt3.Text = "" Or Txt4.Text = "" Then
            MsgBox("Shape Parameters cannot leave blank !")
            Exit Sub
        End If
        If Txt3.Text > 3 Then
            MsgBox("A thickness must be under 3 mm")
            Exit Sub
        End If
        W = Txt1.Text
        Doutput.Txt1.Text = W
        H = Txt2.Text
        Doutput.Txt2.Text = H
        T = Txt3.Text
        Doutput.Txt3.Text = T
        P = Txt4.Text
        Doutput.Txt4.Text = P
        Shape = shapelist.Text
        Call Hexagonal_Calc()
        Exit Sub
Handler:
        Call Gate_go()

    End Sub
    Private Sub Arc_data()
        On Error GoTo Handler
        If Txt1.Text = "" Or Txt2.Text = "" Or Txt3.Text = "" Or Txt4.Text = "" Or Txt5.Text = "" Or Txt6.Text = "" Then
            MsgBox("Shape Parameters cannot leave blank !")
            Exit Sub
        End If
        If Txt4.Text > 3 Then
            MsgBox("A thickness must be under 3 mm")
            Exit Sub
        End If
        W = Txt1.Text
        Doutput.Txt1.Text = W
        L = Txt2.Text
        Doutput.Txt2.Text = L
        H = Txt3.Text
        Doutput.Txt3.Text = H
        T = Txt4.Text
        Doutput.Txt4.Text = T
        R = Txt5.Text
        Doutput.Txt5.Text = R
        P = Txt6.Text
        Doutput.Txt6.Text = P
        Shape = shapelist.Text
        Call Arc_Calc()
        Exit Sub
Handler:
        Call Gate_go()
    End Sub

    Private Sub MatList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MatList.SelectedIndexChanged
        Mat = MatList.Text
        Select Case Mat
            Case "AlSi12 (230)"
                DieHardness.Text = "48-50 HRC"
                Tf = 600
                DTemp.Items.Clear()
                iTemp.Items.Clear()
                DTemp.Text = "Select Temperature"
                iTemp.Text = "Select Temperature"
                DTemp.Items.Insert(0, 260)
                DTemp.Items.Insert(1, 280)
                DTemp.Items.Insert(2, 300)
                DTemp.Items.Insert(3, 320)
                DTemp.Items.Insert(4, 340)
                iTemp.Items.Insert(0, 600)
                iTemp.Items.Insert(1, 620)
                iTemp.Items.Insert(2, 650)
                iTemp.Items.Insert(3, 680)
                Ti = 0
                Td = 0
            Case "ZnAl4 (ZA3)"
                DieHardness.Text = "52-55 HRC"
                Tf = 382
                DTemp.Items.Clear()
                iTemp.Items.Clear()
                DTemp.Text = "Select Temperature"
                iTemp.Text = "Select Temperature"
                DTemp.Items.Insert(0, 205)
                DTemp.Items.Insert(1, 210)
                DTemp.Items.Insert(2, 215)
                DTemp.Items.Insert(3, 220)
                DTemp.Items.Insert(4, 225)
                DTemp.Items.Insert(4, 230)
                iTemp.Items.Insert(0, 405)
                iTemp.Items.Insert(1, 410)
                iTemp.Items.Insert(2, 415)
                iTemp.Items.Insert(3, 420)
                Ti = 0
                Td = 0
        End Select

    End Sub

    Private Sub DTemp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DTemp.SelectedIndexChanged
        Td = DTemp.SelectedItem
    End Sub

    Private Sub iTemp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iTemp.SelectedIndexChanged
        Ti = iTemp.SelectedItem
    End Sub

    Private Sub ShapePic_Click(sender As Object, e As EventArgs) Handles ShapePic.Click

    End Sub
End Class
