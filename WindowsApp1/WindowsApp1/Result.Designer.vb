<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Me.LblPlayerWon = New System.Windows.Forms.Label()
        Me.LblHasWon = New System.Windows.Forms.Label()
        Me.LblPlayAgain = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPlayerWon
        '
        Me.LblPlayerWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerWon.Location = New System.Drawing.Point(95, 20)
        Me.LblPlayerWon.Name = "LblPlayerWon"
        Me.LblPlayerWon.Size = New System.Drawing.Size(341, 120)
        Me.LblPlayerWon.TabIndex = 10
        Me.LblPlayerWon.Text = "X"
        Me.LblPlayerWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHasWon
        '
        Me.LblHasWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHasWon.Location = New System.Drawing.Point(95, 127)
        Me.LblHasWon.Name = "LblHasWon"
        Me.LblHasWon.Size = New System.Drawing.Size(341, 67)
        Me.LblHasWon.TabIndex = 11
        Me.LblHasWon.Text = "HAS WON"
        Me.LblHasWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPlayAgain
        '
        Me.LblPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayAgain.Location = New System.Drawing.Point(95, 194)
        Me.LblPlayAgain.Name = "LblPlayAgain"
        Me.LblPlayAgain.Size = New System.Drawing.Size(341, 67)
        Me.LblPlayAgain.TabIndex = 12
        Me.LblPlayAgain.Text = "Play again?"
        Me.LblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(210, 264)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 52)
        Me.BtnReset.TabIndex = 13
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(530, 337)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.LblPlayAgain)
        Me.Controls.Add(Me.LblHasWon)
        Me.Controls.Add(Me.LblPlayerWon)
        Me.Name = "Result"
        Me.Text = "Result"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblPlayerWon As Label
    Friend WithEvents LblHasWon As Label
    Friend WithEvents LblPlayAgain As Label
    Friend WithEvents BtnReset As Button
End Class
