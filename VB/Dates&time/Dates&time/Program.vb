Imports System

Module Program
    Sub Main(args As String())
        Dim myValue As Date = Now()
        'Console.WriteLine(myValue.ToShortTimeString())
        'Console.WriteLine(myValue.AddDays(3).ToShortDateString())
        'Console.WriteLine(myValue.AddHours(3).ToShortTimeString())
        'Console.WriteLine(myValue.AddDays(-3))
        'Console.WriteLine(myValue.Month())
        'Console.WriteLine(myValue.DayOfWeek())

        'Dim myBirthDate As New Date(2002, 9, 7)

        'Dim myBirthDate As New Date
        'myBirthDate = Date.Parse("09/09/2002")

        'Dim myBirthDate = #09/09/2002#

        Dim myBirthDate = New Date(2002, 9, 9)
        Dim myAge As TimeSpan = Date.Now.Subtract(myBirthDate)
        Console.WriteLine(myAge)
        Console.ReadLine()
    End Sub
End Module
