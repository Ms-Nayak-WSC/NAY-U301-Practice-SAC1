<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallCalculator
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
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        CheckBox1 = New CheckBox()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label9 = New Label()
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(108, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(537, 44)
        Label2.TabIndex = 2
        Label2.Text = "International Call Calculator"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(48, 133)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(417, 337)
        Panel1.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(13, 174)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(383, 94)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Membership Type"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Checked = True
        RadioButton4.Font = New Font("Segoe UI", 9F)
        RadioButton4.Location = New Point(269, 48)
        RadioButton4.Margin = New Padding(3, 4, 3, 4)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(80, 29)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "None"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 9F)
        RadioButton3.Location = New Point(172, 45)
        RadioButton3.Margin = New Padding(3, 4, 3, 4)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(91, 29)
        RadioButton3.TabIndex = 2
        RadioButton3.Text = "Bronze"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 9F)
        RadioButton2.Location = New Point(88, 42)
        RadioButton2.Margin = New Padding(3, 4, 3, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(79, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "Silver"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 9F)
        RadioButton1.Location = New Point(11, 39)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.Text = "Gold"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(185, 294)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(22, 21)
        CheckBox1.TabIndex = 15
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(13, 288)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 28)
        Label11.TabIndex = 12
        Label11.Text = "Evening Calls"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(181, 103)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 108)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 28)
        Label10.TabIndex = 13
        Label10.Text = "Country"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(183, 35)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(213, 31)
        TextBox1.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(144, 28)
        Label9.TabIndex = 11
        Label9.Text = "Length of Call"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(513, 305)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(180, 294)
        Panel2.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Bahnschrift", 10.9439993F, FontStyle.Bold)
        Button3.Location = New Point(22, 204)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 36)
        Button3.TabIndex = 2
        Button3.Text = "END"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bahnschrift", 10.9439993F, FontStyle.Bold)
        Button2.Location = New Point(22, 114)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 36)
        Button2.TabIndex = 1
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bahnschrift", 10.9439993F, FontStyle.Bold)
        Button1.Location = New Point(22, 26)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 36)
        Button1.TabIndex = 0
        Button1.Text = "CALCULATE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(48, 477)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(417, 206)
        Panel3.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 28)
        Label5.TabIndex = 14
        Label5.Text = "SubTotal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 28)
        Label4.TabIndex = 13
        Label4.Text = "GST (10%)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 28)
        Label3.TabIndex = 12
        Label3.Text = "Total"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Location = New Point(134, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 35)
        Label6.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.White
        Label7.Location = New Point(132, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 35)
        Label7.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.White
        Label8.Location = New Point(131, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(180, 35)
        Label8.TabIndex = 6
        ' 
        ' frmCallCalculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        ClientSize = New Size(730, 717)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCallCalculator"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
