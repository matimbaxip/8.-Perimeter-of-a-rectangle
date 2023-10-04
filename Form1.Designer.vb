<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(540, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(424, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter Height"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(369, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Answer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(540, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 0
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(540, 70)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(427, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Length"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
End Class
