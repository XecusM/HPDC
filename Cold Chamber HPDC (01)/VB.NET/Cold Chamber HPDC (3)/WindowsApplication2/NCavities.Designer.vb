<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCavities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PDT1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PDT3 = New System.Windows.Forms.TextBox()
        Me.PDT2 = New System.Windows.Forms.TextBox()
        Me.PD3 = New System.Windows.Forms.RadioButton()
        Me.PD2 = New System.Windows.Forms.RadioButton()
        Me.PD1 = New System.Windows.Forms.RadioButton()
        Me.NNext = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nst = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nmax."
        '
        'PDT1
        '
        Me.PDT1.Enabled = False
        Me.PDT1.Location = New System.Drawing.Point(123, 60)
        Me.PDT1.Name = "PDT1"
        Me.PDT1.Size = New System.Drawing.Size(48, 20)
        Me.PDT1.TabIndex = 1
        Me.PDT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PDT3)
        Me.GroupBox1.Controls.Add(Me.PDT2)
        Me.GroupBox1.Controls.Add(Me.PD3)
        Me.GroupBox1.Controls.Add(Me.PD2)
        Me.GroupBox1.Controls.Add(Me.PD1)
        Me.GroupBox1.Controls.Add(Me.PDT1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 189)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Plunger Diameter"
        '
        'PDT3
        '
        Me.PDT3.Enabled = False
        Me.PDT3.Location = New System.Drawing.Point(123, 146)
        Me.PDT3.Name = "PDT3"
        Me.PDT3.Size = New System.Drawing.Size(48, 20)
        Me.PDT3.TabIndex = 7
        Me.PDT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PDT2
        '
        Me.PDT2.Enabled = False
        Me.PDT2.Location = New System.Drawing.Point(123, 103)
        Me.PDT2.Name = "PDT2"
        Me.PDT2.Size = New System.Drawing.Size(48, 20)
        Me.PDT2.TabIndex = 6
        Me.PDT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PD3
        '
        Me.PD3.AutoSize = True
        Me.PD3.Location = New System.Drawing.Point(18, 149)
        Me.PD3.Name = "PD3"
        Me.PD3.Size = New System.Drawing.Size(14, 13)
        Me.PD3.TabIndex = 4
        Me.PD3.TabStop = True
        Me.PD3.UseVisualStyleBackColor = True
        '
        'PD2
        '
        Me.PD2.AutoSize = True
        Me.PD2.Location = New System.Drawing.Point(18, 106)
        Me.PD2.Name = "PD2"
        Me.PD2.Size = New System.Drawing.Size(14, 13)
        Me.PD2.TabIndex = 3
        Me.PD2.TabStop = True
        Me.PD2.UseVisualStyleBackColor = True
        '
        'PD1
        '
        Me.PD1.AutoSize = True
        Me.PD1.Location = New System.Drawing.Point(18, 63)
        Me.PD1.Name = "PD1"
        Me.PD1.Size = New System.Drawing.Size(14, 13)
        Me.PD1.TabIndex = 2
        Me.PD1.TabStop = True
        Me.PD1.UseVisualStyleBackColor = True
        '
        'NNext
        '
        Me.NNext.Location = New System.Drawing.Point(246, 134)
        Me.NNext.Name = "NNext"
        Me.NNext.Size = New System.Drawing.Size(75, 23)
        Me.NNext.TabIndex = 3
        Me.NNext.Text = "&Next"
        Me.NNext.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(246, 177)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 4
        Me.Back.Text = "&Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number of Cavities"
        '
        'Nst
        '
        Me.Nst.FormattingEnabled = True
        Me.Nst.Location = New System.Drawing.Point(251, 83)
        Me.Nst.Name = "Nst"
        Me.Nst.Size = New System.Drawing.Size(58, 21)
        Me.Nst.TabIndex = 7
        '
        'NCavities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(355, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.Nst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.NNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "NCavities"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number Of Cavities"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PDT1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PDT3 As System.Windows.Forms.TextBox
    Friend WithEvents PDT2 As System.Windows.Forms.TextBox
    Friend WithEvents PD3 As System.Windows.Forms.RadioButton
    Friend WithEvents PD2 As System.Windows.Forms.RadioButton
    Friend WithEvents PD1 As System.Windows.Forms.RadioButton
    Friend WithEvents NNext As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nst As System.Windows.Forms.ComboBox
End Class
