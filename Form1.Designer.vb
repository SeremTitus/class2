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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F)
        Label1.Location = New Point(175, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(469, 74)
        Label1.TabIndex = 0
        Label1.Text = "Registration Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(136, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(604, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 1
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(411, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 25)
        Label4.TabIndex = 1
        Label4.Text = "Phone"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(494, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 31)
        TextBox3.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 1
        Label5.Text = "Reg no."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 241)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 31)
        TextBox4.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(411, 247)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 25)
        Label6.TabIndex = 1
        Label6.Text = "Address"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(494, 244)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(246, 31)
        TextBox5.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(45, 328)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 1
        Label7.Text = "Email"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(127, 328)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(249, 31)
        TextBox6.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(411, 334)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 25)
        Label8.TabIndex = 1
        Label8.Text = "Year of birth"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(241, 419)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 25)
        Label9.TabIndex = 1
        Label9.Text = "County"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(136, 174)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 29)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(217, 174)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 29)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(525, 334)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(215, 31)
        DateTimePicker1.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Eldoret", "Nakuru", "Nairobi", "Mombasa", "Kisumu", "Kisii", "Meru"})
        ComboBox1.Location = New Point(337, 411)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(236, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(464, 502)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 7
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 578)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
