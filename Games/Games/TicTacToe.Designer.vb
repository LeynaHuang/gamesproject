<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.ptCounterX = New System.Windows.Forms.Label()
        Me.ptCounterO = New System.Windows.Forms.Label()
        Me.teamX = New System.Windows.Forms.Label()
        Me.teamO = New System.Windows.Forms.Label()
        Me.roundCounter = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.teamXTurn = New System.Windows.Forms.Label()
        Me.teamOTurn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn1.Location = New System.Drawing.Point(183, 113)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 100)
        Me.btn1.TabIndex = 0
        Me.btn1.UseVisualStyleBackColor = True
        '
        'ptCounterX
        '
        Me.ptCounterX.BackColor = System.Drawing.SystemColors.Window
        Me.ptCounterX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptCounterX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptCounterX.Location = New System.Drawing.Point(15, 113)
        Me.ptCounterX.Name = "ptCounterX"
        Me.ptCounterX.Size = New System.Drawing.Size(161, 34)
        Me.ptCounterX.TabIndex = 9
        Me.ptCounterX.Text = "0"
        Me.ptCounterX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptCounterO
        '
        Me.ptCounterO.BackColor = System.Drawing.SystemColors.Window
        Me.ptCounterO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptCounterO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptCounterO.Location = New System.Drawing.Point(500, 113)
        Me.ptCounterO.Name = "ptCounterO"
        Me.ptCounterO.Size = New System.Drawing.Size(161, 34)
        Me.ptCounterO.TabIndex = 10
        Me.ptCounterO.Text = "0"
        Me.ptCounterO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teamX
        '
        Me.teamX.BackColor = System.Drawing.Color.Salmon
        Me.teamX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teamX.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.teamX.Location = New System.Drawing.Point(15, 68)
        Me.teamX.Name = "teamX"
        Me.teamX.Size = New System.Drawing.Size(161, 36)
        Me.teamX.TabIndex = 11
        Me.teamX.Text = "TEAM EX"
        Me.teamX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teamO
        '
        Me.teamO.BackColor = System.Drawing.Color.PowderBlue
        Me.teamO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teamO.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.teamO.Location = New System.Drawing.Point(500, 68)
        Me.teamO.Name = "teamO"
        Me.teamO.Size = New System.Drawing.Size(161, 36)
        Me.teamO.TabIndex = 12
        Me.teamO.Text = "TEAM OH"
        Me.teamO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'roundCounter
        '
        Me.roundCounter.BackColor = System.Drawing.Color.GhostWhite
        Me.roundCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.roundCounter.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundCounter.Location = New System.Drawing.Point(201, 30)
        Me.roundCounter.Name = "roundCounter"
        Me.roundCounter.Size = New System.Drawing.Size(275, 75)
        Me.roundCounter.TabIndex = 13
        Me.roundCounter.Text = "ROUND 1"
        Me.roundCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(527, 356)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 69)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn2.Location = New System.Drawing.Point(288, 113)
        Me.btn2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 100)
        Me.btn2.TabIndex = 15
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn3.Location = New System.Drawing.Point(393, 113)
        Me.btn3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 100)
        Me.btn3.TabIndex = 16
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn6.Location = New System.Drawing.Point(393, 219)
        Me.btn6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(100, 100)
        Me.btn6.TabIndex = 17
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn5.Location = New System.Drawing.Point(288, 219)
        Me.btn5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(100, 100)
        Me.btn5.TabIndex = 18
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn4.Location = New System.Drawing.Point(183, 219)
        Me.btn4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(100, 100)
        Me.btn4.TabIndex = 19
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn7.Location = New System.Drawing.Point(183, 325)
        Me.btn7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(100, 100)
        Me.btn7.TabIndex = 20
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn8.Location = New System.Drawing.Point(288, 325)
        Me.btn8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(100, 100)
        Me.btn8.TabIndex = 21
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn9.Location = New System.Drawing.Point(393, 325)
        Me.btn9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(100, 100)
        Me.btn9.TabIndex = 22
        Me.btn9.UseVisualStyleBackColor = True
        '
        'teamXTurn
        '
        Me.teamXTurn.BackColor = System.Drawing.Color.Cornsilk
        Me.teamXTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teamXTurn.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamXTurn.Location = New System.Drawing.Point(35, 41)
        Me.teamXTurn.Name = "teamXTurn"
        Me.teamXTurn.Size = New System.Drawing.Size(121, 24)
        Me.teamXTurn.TabIndex = 23
        Me.teamXTurn.Text = "Current Turn"
        Me.teamXTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teamOTurn
        '
        Me.teamOTurn.BackColor = System.Drawing.Color.Cornsilk
        Me.teamOTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teamOTurn.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamOTurn.Location = New System.Drawing.Point(520, 39)
        Me.teamOTurn.Name = "teamOTurn"
        Me.teamOTurn.Size = New System.Drawing.Size(121, 24)
        Me.teamOTurn.TabIndex = 24
        Me.teamOTurn.Text = "Current Turn" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.teamOTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 455)
        Me.Controls.Add(Me.teamOTurn)
        Me.Controls.Add(Me.teamXTurn)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.roundCounter)
        Me.Controls.Add(Me.teamO)
        Me.Controls.Add(Me.teamX)
        Me.Controls.Add(Me.ptCounterO)
        Me.Controls.Add(Me.ptCounterX)
        Me.Controls.Add(Me.btn1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TicTacToe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic-Tac-Toe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents ptCounterX As Label
    Friend WithEvents ptCounterO As Label
    Friend WithEvents teamX As Label
    Friend WithEvents teamO As Label
    Friend WithEvents roundCounter As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents teamXTurn As Label
    Friend WithEvents teamOTurn As Label
End Class
