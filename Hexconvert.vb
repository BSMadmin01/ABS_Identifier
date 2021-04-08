Public Class Hexconvert
    Private Shared hexDigits As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c,
                                              "9"c, "A"c, "B"c, "C"c, "D"c, "E"c, "F"c}

    Public Shared Function ToHexString(bytes() As Byte) As String
        Dim hexStr As String = ""
        Dim HexCHK As String = ""
        Dim i As Integer
        For i = 0 To bytes.Length - 1
            HexCHK = Hex(bytes(i))
            If HexCHK.Length = 1 Then
                hexStr = hexStr + String.Concat("0", Hex(bytes(i)))
            Else
                hexStr = hexStr + Hex(bytes(i))
            End If
        Next i
        Return hexStr
    End Function
    Shared Sub Main()
        Dim b As Byte() = {&H0, &H12, &H34, &H56, &HAA, &H55, &HFF}
        Console.WriteLine(ToHexString(b))
    End Sub
End Class
