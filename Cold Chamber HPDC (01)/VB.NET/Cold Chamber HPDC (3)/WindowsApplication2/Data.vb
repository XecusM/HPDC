Module data
    ''' <summary>
    ''' Runner Cross Section Area
    ''' </summary>
    ''' <remarks></remarks>
    Public Ar As Decimal
    ''' <summary>
    ''' Runner Average width
    ''' </summary>
    ''' <remarks></remarks>
    Public Wr As Decimal
    ''' <summary>
    ''' Runner Hight
    ''' </summary>
    ''' <remarks></remarks>
    Public Hr As Decimal
    ''' <summary>
    ''' Flow Angle
    ''' </summary>
    ''' <remarks></remarks>
    Public Df As Decimal
    ''' <summary>
    ''' Total Gate Cross Section Area
    ''' </summary>
    ''' <remarks></remarks>
    Public Agate As Decimal
    ''' <summary>
    ''' Gate Thickness Variation
    ''' </summary>
    ''' <remarks></remarks>
    Public Tg(2) As Decimal
    ''' <summary>
    ''' Gate Thickness
    ''' </summary>
    ''' <remarks></remarks>
    Public Hg As Decimal
    ''' <summary>
    ''' Gate Width
    ''' </summary>
    ''' <remarks></remarks>
    Public Wgate As Decimal
    ''' <summary>
    ''' Gate Land
    ''' </summary>
    ''' <remarks></remarks>
    Public Bg As Decimal
    ''' <summary>
    ''' Total Gate Length
    ''' </summary>
    ''' <remarks></remarks>
    Public Lg As Decimal
    ''' <summary>
    ''' Max. Gate Width
    ''' </summary>
    ''' <remarks></remarks>
    Public Wmax As Decimal
    ''' <summary>
    ''' Gate Velocity
    ''' </summary>
    ''' <remarks></remarks>
    Public Vgate As Decimal
    ''' <summary>
    ''' Solids units conversion factor, degree to %
    ''' </summary>
    ''' <remarks></remarks>
    Public Z As Decimal
    ''' <summary>
    ''' Empirically derived constant related to the thermal conductivity of the die steel
    ''' </summary>
    ''' <remarks></remarks>
    Public K As Decimal
    ''' <summary>
    ''' Percent Solids at the end of fill
    ''' </summary>
    ''' <remarks></remarks>
    Public S As Decimal
    ''' <summary>
    ''' Width dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public W As Decimal
    ''' <summary>
    ''' Length dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public L As Decimal
    ''' <summary>
    ''' Hight dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public H As Decimal
    ''' <summary>
    ''' Thickness dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public T As Decimal
    ''' <summary>
    ''' Redius dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public R As Decimal
    ''' <summary>
    ''' Angle dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public A As Decimal
    ''' <summary>
    ''' Diameter dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public D As Decimal
    ''' <summary>
    ''' Parting line Hight dimension
    ''' </summary>
    ''' <remarks></remarks>
    Public P As Decimal
    ''' <summary>
    ''' Metal temperature at the gate
    ''' </summary>
    ''' <remarks></remarks>
    Public Ti As Decimal
    ''' <summary>
    ''' Metal temperature
    ''' </summary>
    ''' <remarks></remarks>
    Public Tf As Decimal
    ''' <summary>
    ''' Die surface temperature just before the shot
    ''' </summary>
    ''' <remarks></remarks>
    Public Td As Decimal
    ''' <summary>
    ''' Max. fill time
    ''' </summary>
    ''' <remarks></remarks>
    Public tfill As Decimal
    ''' <summary>
    ''' Part volume
    ''' </summary>
    ''' <remarks></remarks>
    Public vol As Decimal
    ''' <summary>
    ''' Shape type
    ''' </summary>
    ''' <remarks></remarks>
    Public Shape As String
    ''' <summary>
    ''' Machine Type
    ''' </summary>
    ''' <remarks></remarks>
    Public MC As String
    ''' <summary>
    ''' Machine locking force
    ''' </summary>
    ''' <remarks></remarks>
    Public lforce As Integer
    ''' <summary>
    ''' Machine injection force
    ''' </summary>
    ''' <remarks></remarks>
    Public iforce As Integer
    ''' <summary>
    ''' Machine Plunger diameter
    ''' </summary>
    ''' <remarks></remarks>
    Public pDia(3) As Integer
    ''' <summary>
    ''' Selected Machine Plunger Diameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Pdsel As Integer
    ''' <summary>
    ''' Machine Plunger speed
    ''' </summary>
    ''' <remarks></remarks>
    Public iSpeed(2) As Decimal
    ''' <summary>
    ''' Machine plunger stroke
    ''' </summary>
    ''' <remarks></remarks>
    Public iStroke As Integer
    ''' <summary>
    ''' Projected area in the die
    ''' </summary>
    ''' <remarks></remarks>
    Public AreaProj As Decimal
    ''' <summary>
    ''' Machine material volumes
    ''' </summary>
    ''' <remarks></remarks>
    Public MCvol(3) As Decimal
    ''' <summary>
    ''' Number of cavities due to volume
    ''' </summary>
    ''' <remarks></remarks>
    Public Nvol(3) As Integer
    ''' <summary>
    ''' Number of cavities due to locking force
    ''' </summary>
    ''' <remarks></remarks>
    Public Ncf(3) As Integer
    ''' <summary>
    ''' Number of cavities due to flow
    ''' </summary>
    ''' <remarks></remarks>
    Public Nfl(3) As Integer
    ''' <summary>
    ''' Max. Number of cavities
    ''' </summary>
    ''' <remarks></remarks>
    Public Nmax(3) As Integer
    ''' <summary>
    ''' Number of Cavities Selected
    ''' </summary>
    ''' <remarks></remarks>
    Public Nsel As Integer
    ''' <summary>
    ''' Machine flows
    ''' </summary>
    ''' <remarks></remarks>
    Public Flow(3) As Decimal
    ''' <summary>
    ''' Coefficient of discharge
    ''' </summary>
    ''' <remarks></remarks>
    Public Cd(2) As Decimal
    ''' <summary>
    ''' Gravitational constant
    ''' </summary>
    ''' <remarks></remarks>
    Public g As Decimal
    ''' <summary>
    ''' Metal density
    ''' </summary>
    ''' <remarks></remarks>
    Public pd As Decimal
    ''' <summary>
    ''' Metal Pressure
    ''' </summary>
    ''' <remarks></remarks>
    Public Pm(3, 2) As Decimal
    ''' <summary>
    ''' Cast Area
    ''' </summary>
    ''' <remarks></remarks>
    Public Ca(3, 2) As Decimal
    'OverFlow Parameters
    ''' <summary>
    ''' Overflow Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public OA As Decimal
    ''' <summary>
    ''' Overflow Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public OB As Decimal
    ''' <summary>
    ''' Overflow Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public OC As Decimal
    ''' <summary>
    ''' Overflow Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public OV As Decimal
    ''' <summary>
    ''' Overflow volume
    ''' </summary>
    ''' <remarks></remarks>
    Public volfl As Decimal
    ''' <summary>
    ''' Overflow Width
    ''' </summary>
    ''' <remarks></remarks>
    Public Wv As Decimal
    ''' <summary>
    ''' Overflow Length
    ''' </summary>
    ''' <remarks></remarks>
    Public Lv As Decimal
    ''' <summary>
    ''' Overflow Hight
    ''' </summary>
    ''' <remarks></remarks>
    Public Hv As Decimal
    ''' <summary>
    ''' Overflow Gate Width
    ''' </summary>
    ''' <remarks></remarks>
    Public Gv As Decimal
    ''' <summary>
    ''' Overflow Gate Area
    ''' </summary>
    Public Av As Decimal
    ''' <summary>
    ''' Help Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Iv As Decimal
    'Gate Sections Parameters
    ''' <summary>
    ''' Gate Sections Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Al(8) As Decimal
    ''' <summary>
    ''' Gate Sections Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Ll(8) As Decimal
    ''' <summary>
    ''' Gate Sections Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Wl(8) As Decimal
    ''' <summary>
    ''' Gate Sections Parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public Hl(8) As Decimal
    'Helpful parameters
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public N As Integer
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public i As Integer
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public j As Integer
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    ''' <remarks></remarks>
    Public m As Integer
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    Public Ig As Decimal
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    Public Jg As Decimal
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    Public f1 As Decimal
    ''' <summary>
    ''' Helpful parameter
    ''' </summary>
    Public f2 As Decimal
    ''' <summary>
    ''' Gate Shift Scale
    ''' </summary>
    Public GSS As Decimal
    ''' <summary>
    ''' Overflow Shift Scale
    ''' </summary>
    Public OSS As Decimal
    ''' <summary>
    ''' Optimization Array
    ''' </summary>
    Public OPS(2, 3) As Decimal
    ''' <summary>
    ''' Objective Function
    ''' </summary>
    Public fn As Decimal
    ''' <summary>
    ''' Part Material
    ''' </summary>
    Public Mat As String
    Public Sub Parallelogram_Calc()
        vol = (W * L * H) - ((W - 2 * T) * (L - 2 * T) * (H - T))
        AreaProj = W * L
        Wmax = W
        Call Cavities_Number()
    End Sub
    Public Sub Cylinder_Calc()
        vol = ((Math.PI / 4) * (D ^ 2) * H) - ((Math.PI / 4) * ((D - 2 * T) ^ 2) * (H - T))
        AreaProj = (Math.PI / 4) * (D ^ 2)
        Wmax = 0.4 * D
        Call Cavities_Number()
    End Sub
    Public Sub Hexagonal_Calc()
        vol = ((Math.Sqrt(3) / 2) * (W ^ 2) * H) - ((Math.Sqrt(3) / 2) * ((W - 2 * T) ^ 2) * (H - T))
        AreaProj = (Math.Sqrt(3) / 2) * (W ^ 2)
        Call Cavities_Number()
    End Sub
    Public Sub Arc_Calc()
        MsgBox("Arc Shape is not ready yet !")
    End Sub
    Public Sub Cavities_Number()
        Call Intial_Cond()
        Nvol(1) = MCvol(1) / ((vol + volfl) * 1.2)
        Nvol(2) = MCvol(2) / ((vol + volfl) * 1.2)
        Nvol(3) = MCvol(3) / ((vol + volfl) * 1.2)
        Flow(1) = iSpeed(2) * 0.8 * 1000 * ((Math.PI / 4) * (pDia(1) ^ 2))
        Flow(2) = iSpeed(2) * 0.8 * 1000 * ((Math.PI / 4) * (pDia(2) ^ 2))
        Flow(3) = iSpeed(2) * 0.8 * 1000 * ((Math.PI / 4) * (pDia(3) ^ 2))
        tfill = K * ((Ti - Tf + S * Z) / (Tf - Td)) * T
        Nfl(1) = Flow(1) / ((vol + volfl) / tfill)
        Nfl(2) = Flow(2) / ((vol + volfl) / tfill)
        Nfl(3) = Flow(3) / ((vol + volfl) / tfill)
        Ncf(1) = Ca(1, 2) / (AreaProj * 1.5)
        Ncf(2) = Ca(2, 2) / (AreaProj * 1.5)
        Ncf(3) = Ca(3, 2) / (AreaProj * 1.5)
        Nmax(1) = Math.Min(Nfl(1), Nvol(1))
        Nmax(1) = Math.Min(Ncf(1), Nmax(1))
        Nmax(2) = Math.Min(Nfl(2), Nvol(2))
        Nmax(2) = Math.Min(Ncf(2), Nmax(2))
        Nmax(3) = Math.Min(Nfl(3), Nvol(3))
        Nmax(3) = Math.Min(Ncf(3), Nmax(3))
        NCavities.NNext.Enabled = True
        NCavities.Nst.Enabled = True
        NCavities.PD1.Enabled = True
        NCavities.PD2.Enabled = True
        NCavities.PD3.Enabled = True
        NCavities.PD1.Text = "φ" & pDia(1) & " mm"
        NCavities.PD2.Text = "φ" & pDia(2) & " mm"
        NCavities.PD3.Text = "φ" & pDia(3) & " mm"
        NCavities.PDT1.Text = Nmax(1)
        NCavities.PDT2.Text = Nmax(2)
        NCavities.PDT3.Text = Nmax(3)
        If Nmax(3) = 0 Then
            NCavities.PD1.Enabled = False
            NCavities.PD2.Enabled = False
            NCavities.PD3.Enabled = False
            NCavities.Nst.Enabled = False
            NCavities.NNext.Enabled = False
        ElseIf Nmax(2) = 0 Then
            NCavities.PD1.Enabled = False
            NCavities.PD2.Enabled = False
            NCavities.PD3.Checked = True
            N = Nmax(3)
            Pdsel = pDia(3)
            i = Nmax(3)
            Do Until i = 0
                NCavities.Nst.Items.Add(i)
                i = i - 1
            Loop
        ElseIf Nmax(1) = 0 Then
            NCavities.PD1.Enabled = False
            NCavities.PD2.Checked = True
            N = Nmax(2)
            Pdsel = pDia(2)
            i = Nmax(2)
            Do Until i = 0
                NCavities.Nst.Items.Add(i)
                i = i - 1
            Loop
        Else
            i = Nmax(1)
            Do Until i = 0
                NCavities.Nst.Items.Add(i)
                i = i - 1
            Loop
            NCavities.PD1.Checked = True
            N = Nmax(1)
            Pdsel = pDia(1)
        End If
        NCavities.Nst.SelectedIndex = 0
        NCavities.ShowDialog()
    End Sub
    Public Sub S_Set()
        Select Case Mat
            Case "AlSi12 (230)"
                If T < 0.75 Then
                    S = 0.05
                Else
                    If T >= 0.75 And T < 1.25 Then
                        S = 0.15
                    Else
                        If T >= 1.25 And T < 2 Then
                            S = 0.25
                        Else
                            If T >= 2 And T <= 3.15 Then
                                S = 0.35
                            Else
                                S = 0.5
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Case "ZnAl4 (ZA3)"
                If T < 0.75 Then
                    S = 0.1
                Else
                    If T >= 0.75 And T < 1.25 Then
                        S = 0.15
                    Else
                        If T >= 1.25 And T < 2 Then
                            S = 0.225
                        Else
                            If T >= 2 And T <= 3.15 Then
                                S = 0.275
                            Else
                                S = 0.35
                                Exit Sub
                            End If
                        End If
                    End If
                End If
        End Select

    End Sub
    Public Sub volfl_set()
        If T < 0.9 Then
            volfl = 1.5 * vol
        Else
            If T >= 0.9 And T < 1.3 Then
                volfl = 1.5 * vol
            Else
                If T >= 1.3 And T < 1.8 Then
                    volfl = 1 * vol
                Else
                    If T >= 1.8 And T < 2.5 Then
                        volfl = 0.5 * vol
                    Else
                        If T >= 1.5 And T < 3.2 Then
                            volfl = 0.25 * vol
                        Else
                            volfl = 0 * vol
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub Intial_Cond()
        Call S_Set()
        Select Case Mat
            Case "AlSi12 (230)"
                Vgate = 1500 * 25.4 / 1000
                K = 0.0346
                Z = 4.8
                Cd(1) = 0.45
                Cd(2) = 0.5
                'Pm = 800 * (10 ^ 5) / ((10 ^ 6) * 1000)
                OA = 2
                OB = 5
                OC = 0.6
                OV = 0.15
                Tg(1) = 0.8
                Tg(2) = 3
                pd = 2.76
                Df = 35
                Bg = 1.5
            Case "ZnAl4 (ZA3)"
                Vgate = 1850 * 25.4 / 1000
                K = 0.0346
                Z = 2.5
                Cd(1) = 0.45
                Cd(2) = 0.5
                OA = 2
                OB = 5
                OC = 0.6
                OV = 0.15
                Tg(1) = 0.2
                Tg(2) = 3
                pd = 6.7
                Df = 35
                Bg = 1.5
        End Select
        Call volfl_set()
    End Sub
    Public Sub Gate_Area()
        Select Case Mat
            Case "AlSi12 (230)"
                Agate = (vol + volfl) / ((Vgate * 1000) * tfill)
                Hg = Math.Max(0.8, 400 / ((Vgate ^ 1.71) * (pd * (1000))))
                Wgate = Agate / Hg
                Do Until (Vgate ^ 1.71) * Hg * (pd * (1000)) >= 400 And Hg >= 0.8 And Wgate < (W - (Hg * 0.2))
                    If Wgate >= (W - (Hg * 0.2)) Then
                        Hg += 0.1
                        Wgate = Agate / Hg
                    Else
                        Hg -= 0.1
                        Wgate = Agate / Hg
                    End If
                Loop
                Av = (Agate * volfl) / (vol + volfl)
                Gv = Math.Min(Av / OC, W - 4.5)
                OC = Av / Gv
                Do Until Gv < W
                    OC += 0.1
                    Gv = Av / OC
                Loop
                Wv = Gv + 4.5
                Hv = 2
                Lv = (volfl / (Wv * Hv)) + 0.5 * Hv * Iv
                Iv = Math.Tan(60 * Math.PI / 180)
                Do Until Hv / Lv > 0.25
                    Hv += 0.1
                    Lv = (volfl / (Wv * Hv)) + 0.5 * Hv * Iv
                Loop
            Case "ZnAl4 (ZA3)"
                Agate = (vol + volfl) / ((Vgate * 1000) * tfill)
                Hg = Math.Max(0.2, 475 / ((Vgate ^ 1.71) * (pd * (1000))))
                Wgate = Agate / Hg
                Do Until (Vgate ^ 1.71) * Hg * (pd * (1000)) >= 475 And Hg >= 0.2 And Wgate < (W - (Hg * 0.2))
                    If Wgate >= (W - (Hg * 0.2)) Then
                        Hg += 0.1
                        Wgate = Agate / Hg
                    Else
                        Hg -= 0.1
                        Wgate = Agate / Hg
                    End If
                Loop
                Av = (Agate * volfl) / (vol + volfl)
                Gv = Math.Min(Av / OC, W - 4.5)
                OC = Av / Gv
                Do Until Gv < W
                    OC += 0.1
                    Gv = Av / OC
                Loop
                Wv = Gv + 4.5
                Hv = 2
                Lv = (volfl / (Wv * Hv)) + 0.5 * Hv * Iv
                Iv = Math.Tan(60 * Math.PI / 180)
                Do Until Hv / Lv > 0.25
                    Hv += 0.1
                    Lv = (volfl / (Wv * Hv)) + 0.5 * Hv * Iv
                Loop
        End Select
        Call Runner_Area()
    End Sub
    Public Sub Runner_Area()
        Select Case Mat
            Case "AlSi12 (230)"
                If Df >= 10 And Df <= 35 Then
                    Ar = 1.3 * Agate
                Else
                    If Df > 35 And Df <= 45 Then
                        Ar = 1.4 * Agate
                    Else
                        MsgBox("Flow Angle out of range!")
                        Exit Sub
                    End If
                End If
                'Hr = (Ar / 2) ^ 0.5
                Hr = Hg + 1
                Wr = Ar / Hr
                Do Until Wr <= Hr * 3 And Wr >= Hr And Wr < Wgate
                    Hr += 0.1
                    Wr = Ar / Hr
                Loop
            Case "ZnAl4 (ZA3)"
                Ar = 1.1 * Agate
                'Hr = (Ar / 2) ^ 0.5
                Hr = Hg + 1
                Wr = Ar / Hr
                Do Until Hr >= Hg And Wr <= Hr * 3 And Wr < Wgate
                    Hr += 0.1
                    Wr = Ar / Hr
                Loop
        End Select
        Call Gate_Sections()
    End Sub
    Public Sub Gate_Sections()
        Al(8) = Ar
        Al(4) = (Agate + Al(8)) / 2
        Al(2) = (Agate + Al(4)) / 2
        Al(6) = (Al(8) + Al(4)) / 2
        Al(1) = (Agate + Al(2)) / 2
        Al(3) = (Al(2) + Al(4)) / 2
        Al(5) = (Al(4) + Al(6)) / 2
        Al(7) = (Al(6) + Al(8)) / 2
        Hl(8) = Hr
        Hl(4) = (Hg + Hl(8)) / 2
        Hl(2) = (Hg + Hl(4)) / 2
        Hl(6) = (Hl(8) + Hl(4)) / 2
        Hl(1) = (Hg + Hl(2)) / 2
        Hl(3) = (Hl(2) + Hl(4)) / 2
        Hl(5) = (Hl(4) + Hl(6)) / 2
        Hl(7) = (Hl(6) + Hl(8)) / 2
        Wl(1) = Al(1) / Hl(1)
        Wl(2) = Al(2) / Hl(2)
        Wl(3) = Al(3) / Hl(3)
        Wl(4) = Al(4) / Hl(4)
        Wl(5) = Al(5) / Hl(5)
        Wl(6) = Al(6) / Hl(6)
        Wl(7) = Al(7) / Hl(7)
        Wl(8) = Al(8) / Hl(8)
        Lg = (Hr - Hg) / Math.Tan(5 * (Math.PI / 180))
        Ll(8) = Lg
        Ll(1) = Math.Round(Lg / 9, 2)
        Ll(2) = Math.Round(Ll(1) + Lg / 9, 2)
        Ll(3) = Math.Round(Ll(2) + Lg / 9, 2)
        Ll(4) = Math.Round(Ll(3) + Lg / 9, 2)
        Ll(5) = Math.Round(Ll(4) + Lg / 9, 2)
        Ll(6) = Math.Round(Ll(5) + Lg / 9, 2)
        Ll(7) = Math.Round(Ll(6) + Lg / 9, 2)
        Call Optimization_Technique()
    End Sub
    Public Sub Optimization_Technique()
        Select Case Mat
            Case "AlSi12 (230)"
                GSS = 1
                OSS = 1
                OPS(1, 1) = 5.75 - 0.00009 * W - 0.00953 * L - 0.0195 * H + 0.208 * T - 0.1313 * A - 0.327 * GSS - 0.456 * OSS - 0.000012 * W * W + 0.000017 * L * L + 0.000106 * H * H + 0.2283 * T * T + 0.000946 * A * A - 0.0934 * GSS * GSS + 0.1598 * OSS * OSS + 0.000028 * W * L - 0.000068 * W * H + 0.00177 * W * T + 0.000031 * W * A - 0.00003 * W * GSS + 0.00008 * W * OSS + 0.000058 * L * H - 0.002092 * L * T - 0.000031 * L * A + 0.00077 * L * GSS + 0.00072 * L * OSS - 0.00148 * H * T + 0.000064 * H * A + 0.00179 * H * GSS + 0.00015 * H * OSS + 0.00053 * T * A + 0.002 * T * GSS + 0.0191 * T * OSS + 0.00136 * A * GSS + 0.00419 * A * OSS + 0.012 * GSS * OSS
                OPS(1, 2) = GSS
                OPS(1, 3) = OSS
                OSS = OSS - 0.01
                Do Until GSS <= -1
                    Do Until OSS <= -1
                        OPS(2, 1) = 5.75 - 0.00009 * W - 0.00953 * L - 0.0195 * H + 0.208 * T - 0.1313 * A - 0.327 * GSS - 0.456 * OSS - 0.000012 * W * W + 0.000017 * L * L + 0.000106 * H * H + 0.2283 * T * T + 0.000946 * A * A - 0.0934 * GSS * GSS + 0.1598 * OSS * OSS + 0.000028 * W * L - 0.000068 * W * H + 0.00177 * W * T + 0.000031 * W * A - 0.00003 * W * GSS + 0.00008 * W * OSS + 0.000058 * L * H - 0.002092 * L * T - 0.000031 * L * A + 0.00077 * L * GSS + 0.00072 * L * OSS - 0.00148 * H * T + 0.000064 * H * A + 0.00179 * H * GSS + 0.00015 * H * OSS + 0.00053 * T * A + 0.002 * T * GSS + 0.0191 * T * OSS + 0.00136 * A * GSS + 0.00419 * A * OSS + 0.012 * GSS * OSS
                        OPS(2, 2) = GSS
                        OPS(2, 3) = OSS
                        If OPS(2, 1) <= OPS(1, 1) Then
                            OPS(1, 1) = OPS(2, 1)
                            OPS(1, 2) = OPS(2, 2)
                            OPS(1, 3) = OPS(2, 3)
                        End If
                        OSS = OSS - 0.01
                    Loop
                    GSS = GSS - 0.01
                Loop
                GSS = OPS(1, 2)
                OSS = OPS(1, 3)
                fn = OPS(1, 1)
            Case "ZnAl4 (ZA3)"
                GSS = 1
                OSS = 1
                OPS(1, 1) = -0.061 - 0.00028 * W - 0.00306 * L - 0.0012 * H + 0.204 * T + 0.009 * A - 0.108 * GSS - 0.079 * OSS + 0.000001 * W * W + 0.000012 * L * L + 0.000015 * H * H + 0.1796 * T * T - 0.000073 * A * A + 0.0049 * GSS * GSS - 0.0178 * OSS * OSS - 0.000002 * W * L - 0.000005 * W * H + 0.000665 * W * T - 0.000001 * W * A + 0.000106 * W * GSS + 0.000053 * W * OSS + 0.000034 * L * H - 0.00252 * L * T + 0.000002 * L * A + 0.000059 * L * GSS + 0.00007 * L * OSS - 0.00536 * H * T + 0.000005 * H * A + 0.00026 * H * GSS + 0.00057 * H * OSS + 0.00024 * T * A + 0.0111 * T * GSS - 0.0032 * T * OSS + 0.00071 * A * GSS + 0.00049 * A * OSS + 0.005 * GSS * OSS
                OPS(1, 2) = GSS
                OPS(1, 3) = OSS
                OSS = OSS - 0.01
                Do Until GSS <= -1
                    Do Until OSS <= -1
                        OPS(2, 1) = -0.061 - 0.00028 * W - 0.00306 * L - 0.0012 * H + 0.204 * T + 0.009 * A - 0.108 * GSS - 0.079 * OSS + 0.000001 * W * W + 0.000012 * L * L + 0.000015 * H * H + 0.1796 * T * T - 0.000073 * A * A + 0.0049 * GSS * GSS - 0.0178 * OSS * OSS - 0.000002 * W * L - 0.000005 * W * H + 0.000665 * W * T - 0.000001 * W * A + 0.000106 * W * GSS + 0.000053 * W * OSS + 0.000034 * L * H - 0.00252 * L * T + 0.000002 * L * A + 0.000059 * L * GSS + 0.00007 * L * OSS - 0.00536 * H * T + 0.000005 * H * A + 0.00026 * H * GSS + 0.00057 * H * OSS + 0.00024 * T * A + 0.0111 * T * GSS - 0.0032 * T * OSS + 0.00071 * A * GSS + 0.00049 * A * OSS + 0.005 * GSS * OSS
                        OPS(2, 2) = GSS
                        OPS(2, 3) = OSS
                        If OPS(2, 1) <= OPS(1, 1) Then
                            OPS(1, 1) = OPS(2, 1)
                            OPS(1, 2) = OPS(2, 2)
                            OPS(1, 3) = OPS(2, 3)
                        End If
                        OSS = OSS - 0.01
                    Loop
                    GSS = GSS - 0.01
                Loop
                GSS = OPS(1, 2)
                OSS = OPS(1, 3)
                fn = OPS(1, 1)
        End Select
    End Sub
    Public Sub Gate_go()
        MsgBox("Error!")
    End Sub
End Module
