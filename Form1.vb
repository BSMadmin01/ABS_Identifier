Public Class Form1
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        MsgBox("change User")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        Label1.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aTimer.Start()
    End Sub

    Dim objIniFile As New IniFile("C:\ABS_Reader\Resourses\repo.dll")
    '//Remote Connection Setup
    Dim FTPBox As String = objIniFile.GetString("FTP", "URL", "(none)")
    Dim UsrBox As String = objIniFile.GetString("FTP", "User", "(none)")
    Dim PassBox As String = objIniFile.GetString("FTP", "Password", "(none)")

    '//Port Configuration
    Dim ComboPorts As String = objIniFile.GetString("Port", "COM", "(none)")
    Dim BPSBox As String = objIniFile.GetString("Port", "Bits", "(none)")
    Dim DBitBox As String = objIniFile.GetString("Port", "DATA", "(none)")
    Dim ParBox As String = objIniFile.GetString("Port", "Parity", "(none)")
    Dim SBitBox As String = objIniFile.GetString("Port", "StopB", "(none)")
    Dim FlowBox As String = objIniFile.GetString("Port", "FlowC", "(none)")

    '//Printer Configuration
    Dim PRNTRBox As String = objIniFile.GetString("Printer", "Printer", "(none)")

    Sub Setup_Puerto_Serie()

        Try

            With SerialPort1

                If .IsOpen Then

                    .Close()

                End If

                .PortName = ComboPorts '//Port Name
                .BaudRate = BPSBox '// Bits per second (Baud Rate)
                .DataBits = DBitBox '// Data Bits

                If ParBox = "Even" Then '// Parity
                    .Parity = IO.Ports.Parity.Even
                ElseIf ParBox = "Odd" Then
                    .Parity = IO.Ports.Parity.Odd
                ElseIf ParBox = "None" Then
                    .Parity = IO.Ports.Parity.None
                ElseIf ParBox = "Mark" Then
                    .Parity = IO.Ports.Parity.Mark
                ElseIf ParBox = "Space" Then
                    .Parity = IO.Ports.Parity.Space
                End If

                If SBitBox = "None" Then '//Stop Bits
                    .StopBits = IO.Ports.StopBits.None
                ElseIf SBitBox = "1" Then
                    .StopBits = IO.Ports.StopBits.One '// 1 Stop bit
                ElseIf SBitBox = "1.5" Then
                    .StopBits = IO.Ports.StopBits.OnePointFive
                ElseIf SBitBox = "1.5" Then
                    .StopBits = IO.Ports.StopBits.Two
                End If

                If FlowBox = "none" Then '//Flow Control
                    .Handshake = IO.Ports.Handshake.XOnXOff
                ElseIf FlowBox = "RTS" Then
                    .Handshake = IO.Ports.Handshake.RequestToSend
                ElseIf FlowBox = "RTS-Xon/Xoff" Then
                    .Handshake = IO.Ports.Handshake.None
                ElseIf FlowBox = "Xon/Xoff" Then
                    .Handshake = IO.Ports.Handshake.None
                End If

                '.ReadBufferSize = 2048

                '.WriteBufferSize = 1024

                '.ReceivedBytesThreshold = 1

                .WriteTimeout = 500


                .Open() ' ABRE EL PUERTO SERIE

            End With

        Catch ex As Exception

            MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub ' //Configuracion del Puerto Seria para la comunicacion


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
