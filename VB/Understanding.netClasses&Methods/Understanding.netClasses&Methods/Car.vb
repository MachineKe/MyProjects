Public Class Car

    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer

    Public Property Color As String


    Function determineMarketValue() As Decimal
        'Super secret formula
        'Return 100.0

        Dim carValue As Decimal

        If Me.Year > 1990 Then
            carValue = 1000000.0
        Else
            carValue = 2400000.0
        End If

        Return carValue


    End Function

    'Private _BlueBookValue As Decimal
    'Public Property BlueBookValue() As Decimal
    '    Get
    '        Return _BlueBookValue
    '    End Get
    '    Set(ByVal value As Decimal)
    '        If value > 0 Then
    '            _BlueBookValue = value
    '        End If
    '    End Set
    'End Property



End Class
