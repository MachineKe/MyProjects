Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Please type something and press enter")
        'Dim userValue As String
        'userValue = Console.ReadLine()
        'Console.WriteLine("You typed:" & userValue)
        'Console.ReadLine()

        Console.WriteLine("Would you prefer what is behind door number 1,2 or 3?")
        Dim userValue As String = Console.ReadLine()

        'Dim message As String = ""

        'If userValue = "1" Then
        '    message = "You won a new car!"

        'ElseIf userValue = "2" Then
        '    message = "You won a new boat!"

        'ElseIf userValue = "3" Then
        '    message = "You won a new cat"

        'Else
        '    message = "Sorry, we did not understand your response"

        'End If
        'Console.WriteLine(message)

        Dim message As String = IIf(userValue = "1", "car", "cat")
        Console.WriteLine("You picked: {1} ... so you won a {0}!", message, userValue)

        Console.ReadLine()
    End Sub
End Module
