<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label11 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 32)
        Label1.TabIndex = 0
        Label1.Text = "Καλωσορίσατε "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(401, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(535, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 32)
        Label3.TabIndex = 2
        Label3.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(69, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(394, 25)
        Label4.TabIndex = 3
        Label4.Text = "Ο αριθμός λογαριασμού σου (IBAN) είναι:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(469, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 25)
        Label5.TabIndex = 4
        Label5.Text = "IBAN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(73, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(390, 25)
        Label6.TabIndex = 5
        Label6.Text = "Το υπόλοιπο του λογαριασμού σου είναι:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label7.Location = New Point(477, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 40)
        Label7.TabIndex = 6
        Label7.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label9.Location = New Point(162, 209)
        Label9.Name = "Label9"
        Label9.Size = New Size(266, 25)
        Label9.TabIndex = 8
        Label9.Text = "Τι θέλετε να κάνετε σήμερα;"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(123, 253)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 67)
        Button1.TabIndex = 9
        Button1.Text = "Κατάθεση"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(296, 253)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 67)
        Button2.TabIndex = 9
        Button2.Text = "Ανάληψη"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(469, 253)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 67)
        Button3.TabIndex = 9
        Button3.Text = "Κινήσεις Λογαριασμού"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(216, 338)
        Label10.Name = "Label10"
        Label10.Size = New Size(331, 21)
        Label10.TabIndex = 10
        Label10.Text = "Πληκτρολογήστε το ποσό που επιθυμείτε"
        Label10.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(296, 364)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 29)
        TextBox1.TabIndex = 11
        TextBox1.Text = "0"
        TextBox1.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label11.Location = New Point(486, 362)
        Label11.Name = "Label11"
        Label11.Size = New Size(23, 25)
        Label11.TabIndex = 12
        Label11.Text = "€"
        Label11.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonFace
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(314, 399)
        Button4.Name = "Button4"
        Button4.Size = New Size(159, 56)
        Button4.TabIndex = 13
        Button4.Text = "Έλεγχος και ολοκλήρωση"
        Button4.UseVisualStyleBackColor = False
        Button4.Visible = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonFace
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(1, 393)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 56)
        Button5.TabIndex = 13
        Button5.Text = "Αρχική"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonFace
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(660, 393)
        Button6.Name = "Button6"
        Button6.Size = New Size(128, 56)
        Button6.TabIndex = 13
        Button6.Text = "Αποσύνδεση"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label11)
        Controls.Add(TextBox1)
        Controls.Add(Label10)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
