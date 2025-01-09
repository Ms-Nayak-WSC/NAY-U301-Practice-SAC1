<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookMyShow
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox2 = New GroupBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(188, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 38)
        Label1.TabIndex = 0
        Label1.Text = "Book My Show"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button1.ForeColor = Color.Navy
        Button1.Location = New Point(39, 421)
        Button1.Name = "Button1"
        Button1.Size = New Size(267, 61)
        Button1.TabIndex = 4
        Button1.Text = "CALCULATE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button2.ForeColor = Color.Navy
        Button2.Location = New Point(39, 526)
        Button2.Name = "Button2"
        Button2.Size = New Size(248, 53)
        Button2.TabIndex = 5
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button3.ForeColor = Color.Navy
        Button3.Location = New Point(361, 542)
        Button3.Name = "Button3"
        Button3.Size = New Size(236, 48)
        Button3.TabIndex = 6
        Button3.Text = "SAVE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Arial Narrow", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(361, 215)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(236, 173)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking Category"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Arial", 9.792F)
        RadioButton1.Location = New Point(11, 36)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(140, 23)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Super Tuesday"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Arial", 9.792F)
        RadioButton2.Location = New Point(12, 69)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(156, 23)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Matinee Discount"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Arial", 9.792F)
        RadioButton3.Location = New Point(14, 99)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(157, 23)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Concession Card"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Arial", 9.792F)
        RadioButton4.Location = New Point(14, 129)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(68, 23)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "None"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 23)
        Label2.TabIndex = 9
        Label2.Text = "Movie"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(159, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 29)
        TextBox1.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.9439993F)
        Label4.Location = New Point(33, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 22)
        Label4.TabIndex = 0
        Label4.Text = "Adults"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.9439993F)
        Label5.Location = New Point(36, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 22)
        Label5.TabIndex = 1
        Label5.Text = "Child"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial", 10.9439993F)
        TextBox3.Location = New Point(113, 52)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(56, 29)
        TextBox3.TabIndex = 5
        TextBox3.Text = "0"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial", 10.9439993F)
        TextBox4.Location = New Point(115, 115)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(54, 29)
        TextBox4.TabIndex = 6
        TextBox4.Text = "0"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Font = New Font("Arial Narrow", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(39, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 184)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Tickets"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOliveGreen
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(363, 413)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(234, 80)
        Panel1.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkKhaki
        Label3.Font = New Font("Arial Narrow", 9.792F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 22)
        Label3.TabIndex = 0
        Label3.Text = "Invoice Amount"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Font = New Font("Arial", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(185, 27)
        Label6.TabIndex = 1
        ' 
        ' frmBookMyShow
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        ClientSize = New Size(657, 602)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "frmBookMyShow"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
End Class
