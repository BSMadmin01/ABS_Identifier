Imports System.Drawing.Printing
Imports DYMO.Label.Framework
Public Class Settings
    Private Sub Get_Serial()
        Dim l As Integer
        Dim ncom As String

        Try

            ComboPorts.Items.Clear()

            For Each sp As String In My.Computer.Ports.SerialPortNames
                l = sp.Length

                If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
                    ComboPorts.Items.Add(sp)
                Else
                    'hay una letra al final del COM
                    ncom = sp.Substring(0, l - 1)
                    ComboPorts.Items.Add(ncom)
                End If
            Next

            If ComboPorts.Items.Count >= 1 Then

                ComboPorts.Text = ComboPorts.Items(0)
            Else
                ComboPorts.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Get_Printers()
        Dim pkInstalledPrinters As String

        ' Find all printers installed
        For Each pkInstalledPrinters In
            PrinterSettings.InstalledPrinters
            PRNTRBox.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        PRNTRBox.SelectedIndex = 0
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Get_Serial()
        Get_Printers()

        Dim objIniFile As New IniFile("C:\ABS_Reader\Resourses\repo.dll")
        '//Remote Connection Setup
        FTPBox.Text = objIniFile.GetString("FTP", "URL", "(none)")
        UsrBox.Text = objIniFile.GetString("FTP", "User", "(none)")
        PassBox.Text = objIniFile.GetString("FTP", "Password", "(none)")

        '//Port Configuration
        ComboPorts.Text = objIniFile.GetString("Port", "COM", "(none)")
        BPSBox.Text = objIniFile.GetString("Port", "Bits", "(none)")
        DBitBox.Text = objIniFile.GetString("Port", "DATA", "(none)")
        ParBox.Text = objIniFile.GetString("Port", "Parity", "(none)")
        SBitBox.Text = objIniFile.GetString("Port", "StopB", "(none)")
        FlowBox.Text = objIniFile.GetString("Port", "FlowC", "(none)")

        '//Printer Configuration
        PRNTRBox.Text = objIniFile.GetString("Printer", "Printer", "(none)")
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click

        Dim objIniFile As New IniFile("C:\ABS_Reader\Resourses\repo.dll")
        '//Remote Connection Setup
        objIniFile.WriteString("FTP", "URL", FTPBox.Text)
        objIniFile.WriteString("FTP", "User", UsrBox.Text)
        objIniFile.WriteString("FTP", "Password", PassBox.Text)

        '//Port Configuration
        objIniFile.WriteString("Port", "COM", ComboPorts.Text)
        objIniFile.WriteString("Port", "Bits", BPSBox.Text)
        objIniFile.WriteString("Port", "DATA", DBitBox.Text)
        objIniFile.WriteString("Port", "Parity", ParBox.Text)
        objIniFile.WriteString("Port", "StopB", SBitBox.Text)
        objIniFile.WriteString("Port", "FlowC", FlowBox.Text)

        '//Printer Configuration
        objIniFile.WriteString("Printer", "Printer", PRNTRBox.Text)
        Me.Close()
    End Sub

    Private Sub TestPRT_Click(sender As Object, e As EventArgs) Handles TestPRT.Click

        Try

            With SerialPort1
                If .IsOpen Then
                    .Close()

                End If

                .PortName = ComboPorts.Text '//Port Name
                .BaudRate = BPSBox.Text '// Bits per second (Baud Rate)
                .DataBits = DBitBox.Text '// Data Bits

                If ParBox.Text = "Even" Then '// Parity
                    .Parity = IO.Ports.Parity.Even
                ElseIf ParBox.Text = "Odd" Then
                    .Parity = IO.Ports.Parity.Odd
                ElseIf ParBox.Text = "None" Then
                    .Parity = IO.Ports.Parity.None
                ElseIf ParBox.Text = "Mark" Then
                    .Parity = IO.Ports.Parity.Mark
                ElseIf ParBox.Text = "Space" Then
                    .Parity = IO.Ports.Parity.Space
                End If

                If SBitBox.Text = "None" Then '//Stop Bits
                    .StopBits = IO.Ports.StopBits.None
                ElseIf SBitBox.Text = "1" Then
                    .StopBits = IO.Ports.StopBits.One '// 1 Stop bit
                ElseIf SBitBox.Text = "1.5" Then
                    .StopBits = IO.Ports.StopBits.OnePointFive
                ElseIf SBitBox.Text = "1.5" Then
                    .StopBits = IO.Ports.StopBits.Two
                End If

                If FlowBox.Text = "none" Then '//Flow Control
                    .Handshake = IO.Ports.Handshake.XOnXOff
                ElseIf FlowBox.Text = "RTS" Then
                    .Handshake = IO.Ports.Handshake.RequestToSend
                ElseIf FlowBox.Text = "RTS-Xon/Xoff" Then
                    .Handshake = IO.Ports.Handshake.None
                ElseIf FlowBox.Text = "Xon/Xoff" Then
                    .Handshake = IO.Ports.Handshake.None
                End If

                '.ReadBufferSize = 2048
                '.WriteBufferSize = 1024
                '.ReceivedBytesThreshold = 1
                .WriteTimeout = 500
                .ReadTimeout = 500
                .Open() ' ABRE EL PUERTO SERIE
            End With

        Catch ex As Exception
            MsgBox("Error Opening Selected Port: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        ' //Configuracion del Puerto Seria para la comunicacion

        Try
            Dim AVT_Model() As Byte = {240} '//F0
            SerialPort1.Write(AVT_Model, 0, AVT_Model.Length)

            Dim Model() As Byte = New Byte(3) {}
            SerialPort1.Read(Model, 0, Model.Length)

            Dim AVT As String = Hexconvert.ToHexString(Model)

            If AVT = "93280852" Then
                MsgBox("ABS Identifier Connected",, "Test Succesfull")
            Else
                MsgBox("ABS Identifier Not Connected or Wrong Model",, "Test Failed")
            End If
        Catch ex As Exception
            MsgBox("ABS Identifier Not Connected",, "Test Failed")
            Get_Serial()
        End Try
    End Sub

    Private Sub TestPRNT_Click(sender As Object, e As EventArgs) Handles TestPRNT.Click
        Dim Label As DYMO.Label.Framework.ILabel = DYMO.Label.Framework.Framework.Open("C:\ABS_Reader\Resourses\Small30336.label")
        Label.SetObjectText("CoreSCN", "Test Print")
        Label.Print(PRNTRBox.Text)
        MsgBox("Test Print Was Sent to Printer",, "Test Page")
    End Sub
End Class