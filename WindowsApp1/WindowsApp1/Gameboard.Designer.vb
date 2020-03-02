<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gameboard
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.LblPlayerTurn = New System.Windows.Forms.Label()
        Me.LblTurn = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(12, 12)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 100)
        Me.Btn1.TabIndex = 0
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(118, 12)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 100)
        Me.Btn2.TabIndex = 1
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(224, 12)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(100, 100)
        Me.Btn3.TabIndex = 2
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(224, 118)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(100, 100)
        Me.Btn6.TabIndex = 5
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(118, 118)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(100, 100)
        Me.Btn5.TabIndex = 4
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(12, 118)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(100, 100)
        Me.Btn4.TabIndex = 3
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(224, 225)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(100, 100)
        Me.Btn9.TabIndex = 8
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(118, 225)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(100, 100)
        Me.Btn8.TabIndex = 7
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(12, 225)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(100, 100)
        Me.Btn7.TabIndex = 6
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'LblPlayerTurn
        '
        Me.LblPlayerTurn.AutoSize = True
        Me.LblPlayerTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerTurn.Location = New System.Drawing.Point(374, 28)
        Me.LblPlayerTurn.Name = "LblPlayerTurn"
        Me.LblPlayerTurn.Size = New System.Drawing.Size(121, 120)
        Me.LblPlayerTurn.TabIndex = 9
        Me.LblPlayerTurn.Text = "X"
        '
        'LblTurn
        '
        Me.LblTurn.AutoSize = True
        Me.LblTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTurn.Location = New System.Drawing.Point(349, 148)
        Me.LblTurn.Name = "LblTurn"
        Me.LblTurn.Size = New System.Drawing.Size(158, 55)
        Me.LblTurn.TabIndex = 10
        Me.LblTurn.Text = "TURN"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(383, 215)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 100)
        Me.BtnReset.TabIndex = 11
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Gameboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(530, 337)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.LblTurn)
        Me.Controls.Add(Me.LblPlayerTurn)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Gameboard"
        Me.Text = "Gameboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents LblPlayerTurn As Label
    Friend WithEvents LblTurn As Label
    Friend WithEvents BtnReset As Button
End Class
