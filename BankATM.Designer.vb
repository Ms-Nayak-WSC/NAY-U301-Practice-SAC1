<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankATM
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
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(258, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 44)
        Label2.TabIndex = 3
        Label2.Text = "My Bank"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(601, 148)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 58)
        Button1.TabIndex = 4
        Button1.Text = "Balance"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(177, 309)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 58)
        Button2.TabIndex = 5
        Button2.Text = "Deposit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateGray
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(448, 300)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 58)
        Button3.TabIndex = 6
        Button3.Text = "Withdrawal"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSlateGray
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(325, 416)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 58)
        Button4.TabIndex = 7
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(114, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 30)
        Label1.TabIndex = 8
        Label1.Text = "Balance"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(258, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(296, 38)
        Label3.TabIndex = 9
        ' 
        ' BankATM
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(801, 558)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Name = "BankATM"
        Text = "BankATM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
