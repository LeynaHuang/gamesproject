<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.openTicTacToe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'openTicTacToe
        '
        Me.openTicTacToe.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openTicTacToe.Location = New System.Drawing.Point(12, 24)
        Me.openTicTacToe.Name = "openTicTacToe"
        Me.openTicTacToe.Size = New System.Drawing.Size(228, 40)
        Me.openTicTacToe.TabIndex = 0
        Me.openTicTacToe.Text = "Tic-Tac-Toe"
        Me.openTicTacToe.UseVisualStyleBackColor = True
        '
        'GameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 152)
        Me.Controls.Add(Me.openTicTacToe)
        Me.Name = "GameMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openTicTacToe As Button
End Class
