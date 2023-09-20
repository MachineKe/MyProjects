Imports System
Imports System.IO

Module Program
    Sub Main(args As String())

        Dim myReader As StreamReader = New StreamReader("values.txt")
        Dim line As String = ""

        While Not IsNothing(line)
            line = myReader.ReadLine()
            If Not IsNothing(line) Then
                Console.WriteLine(line)
            End If
        End While

        myReader.Close()
        Console.ReadLine()

    End Sub
End Module
