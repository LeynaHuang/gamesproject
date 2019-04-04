<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToeChoice
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
        Me.btnPVP = New System.Windows.Forms.Button()
        Me.btnAI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPVP
        '
        Me.btnPVP.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPVP.Location = New System.Drawing.Point(12, 12)
        Me.btnPVP.Name = "btnPVP"
        Me.btnPVP.Size = New System.Drawing.Size(187, 48)
        Me.btnPVP.TabIndex = 0
        Me.btnPVP.Text = "Player vs Player"
        Me.btnPVP.UseVisualStyleBackColor = True
        '
        'btnAI
        '
        Me.btnAI.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAI.Location = New System.Drawing.Point(12, 75)
        Me.btnAI.Name = "btnAI"
        Me.btnAI.Size = New System.Drawing.Size(187, 48)
        Me.btnAI.TabIndex = 1
        Me.btnAI.Text = "Player vs AI"
        Me.btnAI.UseVisualStyleBackColor = True
        '
        'TicTacToeChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 136)
        Me.Controls.Add(Me.btnAI)
        Me.Controls.Add(Me.btnPVP)
        Me.Name = "TicTacToeChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPVP As Button
    Friend WithEvents btnAI As Button
End Class
