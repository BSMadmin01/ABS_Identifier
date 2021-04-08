<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsrBox = New System.Windows.Forms.TextBox()
        Me.UserBox = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FTPBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TestPRT = New System.Windows.Forms.Button()
        Me.FlowBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SBitBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ParBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DBitBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BPSBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboPorts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PRNTRBox = New System.Windows.Forms.ComboBox()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TestPRNT = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(332, 271)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.PassBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.UsrBox)
        Me.TabPage1.Controls.Add(Me.UserBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.FTPBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(324, 245)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(6, 108)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(148, 20)
        Me.PassBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password"
        '
        'UsrBox
        '
        Me.UsrBox.Location = New System.Drawing.Point(6, 69)
        Me.UsrBox.Name = "UsrBox"
        Me.UsrBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UsrBox.Size = New System.Drawing.Size(150, 20)
        Me.UsrBox.TabIndex = 15
        '
        'UserBox
        '
        Me.UserBox.AutoSize = True
        Me.UserBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserBox.Location = New System.Drawing.Point(3, 53)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(63, 13)
        Me.UserBox.TabIndex = 14
        Me.UserBox.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FTP Address"
        '
        'FTPBox
        '
        Me.FTPBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FTPBox.Location = New System.Drawing.Point(6, 30)
        Me.FTPBox.Name = "FTPBox"
        Me.FTPBox.Size = New System.Drawing.Size(313, 20)
        Me.FTPBox.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TestPRT)
        Me.TabPage2.Controls.Add(Me.FlowBox)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.SBitBox)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ParBox)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.DBitBox)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BPSBox)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.ComboPorts)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(324, 245)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Port Settings"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Press Test button to test connection with the Identifier"
        '
        'TestPRT
        '
        Me.TestPRT.Location = New System.Drawing.Point(243, 176)
        Me.TestPRT.Name = "TestPRT"
        Me.TestPRT.Size = New System.Drawing.Size(75, 23)
        Me.TestPRT.TabIndex = 26
        Me.TestPRT.Text = "Test "
        Me.TestPRT.UseVisualStyleBackColor = True
        '
        'FlowBox
        '
        Me.FlowBox.FormattingEnabled = True
        Me.FlowBox.Items.AddRange(New Object() {"none", "RTS", "RTS-Xon/Xoff", "Xon/Xoff", "", ""})
        Me.FlowBox.Location = New System.Drawing.Point(197, 149)
        Me.FlowBox.Name = "FlowBox"
        Me.FlowBox.Size = New System.Drawing.Size(121, 21)
        Me.FlowBox.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Flow Control:"
        '
        'SBitBox
        '
        Me.SBitBox.FormattingEnabled = True
        Me.SBitBox.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.SBitBox.Location = New System.Drawing.Point(197, 122)
        Me.SBitBox.Name = "SBitBox"
        Me.SBitBox.Size = New System.Drawing.Size(121, 21)
        Me.SBitBox.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Stop Bits:"
        '
        'ParBox
        '
        Me.ParBox.FormattingEnabled = True
        Me.ParBox.Items.AddRange(New Object() {"Even", "Odd", "None", "Mark", "Space"})
        Me.ParBox.Location = New System.Drawing.Point(197, 94)
        Me.ParBox.Name = "ParBox"
        Me.ParBox.Size = New System.Drawing.Size(121, 21)
        Me.ParBox.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(148, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Parity:"
        '
        'DBitBox
        '
        Me.DBitBox.FormattingEnabled = True
        Me.DBitBox.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.DBitBox.Location = New System.Drawing.Point(197, 67)
        Me.DBitBox.Name = "DBitBox"
        Me.DBitBox.Size = New System.Drawing.Size(121, 21)
        Me.DBitBox.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Data Bits:"
        '
        'BPSBox
        '
        Me.BPSBox.FormattingEnabled = True
        Me.BPSBox.Items.AddRange(New Object() {"75", "110", "134", "150", "300", "600", "1200", "1800", "2400", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me.BPSBox.Location = New System.Drawing.Point(197, 40)
        Me.BPSBox.Name = "BPSBox"
        Me.BPSBox.Size = New System.Drawing.Size(121, 21)
        Me.BPSBox.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Bits per second:"
        '
        'ComboPorts
        '
        Me.ComboPorts.FormattingEnabled = True
        Me.ComboPorts.Location = New System.Drawing.Point(197, 13)
        Me.ComboPorts.Name = "ComboPorts"
        Me.ComboPorts.Size = New System.Drawing.Size(121, 21)
        Me.ComboPorts.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Com Port Number:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TestPRNT)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.PRNTRBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(324, 245)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Printer Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Printer"
        '
        'PRNTRBox
        '
        Me.PRNTRBox.FormattingEnabled = True
        Me.PRNTRBox.Location = New System.Drawing.Point(53, 14)
        Me.PRNTRBox.Name = "PRNTRBox"
        Me.PRNTRBox.Size = New System.Drawing.Size(265, 21)
        Me.PRNTRBox.TabIndex = 0
        '
        'SaveBTN
        '
        Me.SaveBTN.Location = New System.Drawing.Point(259, 299)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(75, 23)
        Me.SaveBTN.TabIndex = 3
        Me.SaveBTN.Text = "save"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'TestPRNT
        '
        Me.TestPRNT.Location = New System.Drawing.Point(243, 41)
        Me.TestPRNT.Name = "TestPRNT"
        Me.TestPRNT.Size = New System.Drawing.Size(75, 23)
        Me.TestPRNT.TabIndex = 2
        Me.TestPRNT.Text = "Test"
        Me.TestPRNT.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 334)
        Me.Controls.Add(Me.SaveBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UsrBox As TextBox
    Friend WithEvents UserBox As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FTPBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents TestPRT As Button
    Friend WithEvents FlowBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SBitBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ParBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DBitBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BPSBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboPorts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBTN As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents PRNTRBox As ComboBox
    Friend WithEvents TestPRNT As Button
End Class
