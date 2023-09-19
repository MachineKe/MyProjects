Imports System

Module Program
    Sub Main(args As String())
        'Call displayTheMessage()
        'displayTheMessage()

        'Dim message As String
        'message = superSecretFormula()
        'Console.WriteLine(message)

        Console.WriteLine(superSecretFormula("world"))
        Console.WriteLine(superSecretFormula("sunshine!"))

        Console.ReadLine()

    End Sub
    Sub displayTheMessage()
        Console.WriteLine("From displayTheMessage")
    End Sub

    Function superSecretFormula() As String
        Return "Hello World!"
    End Function

    Function superSecretFormula(ByVal name As String) As String
        Return String.Format("Hello {0}!", name)

    End Function
End Module
