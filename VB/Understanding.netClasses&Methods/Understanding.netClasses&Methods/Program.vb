Imports System

Module Program
    Sub Main(args As String())

        'Dim myNewCar As Car = New Car()

        Dim myNewCar As New Car()
        myNewCar.Make = "Toyota"
        myNewCar.Model = "Avansis"
        myNewCar.Year = 2014
        myNewCar.Color = "Silver"

        '       Console.WriteLine("{0} - {1} - {2} - {3}",
        'myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color
        ')

        'Console.WriteLine(determineMarketValue(myNewCar))

        Console.WriteLine("Car's Value: {0:C}", myNewCar.determineMarketValue())

        Console.ReadLine()

    End Sub

    Function determineMarketValue(ByVal myCar As Car) As Decimal
        'Super secret formula
        Return 100.0
    End Function

End Module
