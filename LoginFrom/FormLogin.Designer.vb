<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Tusername = New System.Windows.Forms.TextBox()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BLoginFormKeluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Tusername
        '
        Me.Tusername.Location = New System.Drawing.Point(201, 75)
        Me.Tusername.Name = "Tusername"
        Me.Tusername.Size = New System.Drawing.Size(152, 20)
        Me.Tusername.TabIndex = 0
        '
        'Tpassword
        '
        Me.Tpassword.Location = New System.Drawing.Point(201, 111)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.Size = New System.Drawing.Size(152, 20)
        Me.Tpassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "username      :"
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPassword.Location = New System.Drawing.Point(42, 105)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(153, 26)
        Me.LPassword.TabIndex = 3
        Me.LPassword.Text = "password       :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "masuk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BLoginFormKeluar
        '
        Me.BLoginFormKeluar.Location = New System.Drawing.Point(214, 187)
        Me.BLoginFormKeluar.Name = "BLoginFormKeluar"
        Me.BLoginFormKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BLoginFormKeluar.TabIndex = 5
        Me.BLoginFormKeluar.Text = "Cancel"
        Me.BLoginFormKeluar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "LOGIN USER ADMIN"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(48, 149)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(154, 21)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "SHOW PASSWORD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 270)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BLoginFormKeluar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tpassword)
        Me.Controls.Add(Me.Tusername)
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tusername As TextBox
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LPassword As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BLoginFormKeluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
