<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(233, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 30)
        Label1.TabIndex = 0
        Label1.Text = "Εισάγετε το ποσό ανάληψης:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0)
        TextBox1.Location = New Point(276, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(192, 39)
        TextBox1.TabIndex = 1
        TextBox1.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button1.Location = New Point(309, 179)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 56)
        Button1.TabIndex = 2
        Button1.Text = "Ανάληψη"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(474, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 30)
        Label2.TabIndex = 3
        Label2.Text = "€"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button2.Location = New Point(12, 382)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 56)
        Button2.TabIndex = 4
        Button2.Text = "Αρχική"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button3.Location = New Point(309, 382)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 56)
        Button3.TabIndex = 5
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
