Imports System
Imports System.Text

Module Program
    Sub Main(args As String())

        'Dim myString = "My ""so called"" life"

        'Dim myString = "What if I need" & vbNewLine & " a new line?"

        'Dim myString = "What if I need a" & vbTab & " new tab in my line?"

        'Dim myString = String.Format("{0}!", "Hello")

        'Dim myString = String.Format("Make: {0} Model: {1} {2}", "BMW", "745li", 1995)

        'Dim myString = String.Format("{0:C}", 23.25)

        'Dim myString = String.Format("{0:N}", 1234567890)

        'Dim myString = String.Format("{0:P}", 0.123)

        'Dim myString = String.Format("{0:(###) ###-####}", 1234567890)

        'Dim myString = ""

        'Dim myString As StringBuilder = New StringBuilder


        'For i = 1 To 100
        'myString = myString & "--" & CStr(i)
        'myString += "--" & CStr(i)
        'myString.Append("--")
        'myString.Append(i)
        'Next

        Dim myString = "  The king of rap is in the house coding.    "

        'myString = myString.Substring(13, 15)

        'myString = myString.ToUpper()
        'myString = myString.ToLower()

        'If "upper" = "UPPER" Then
        '    Console.WriteLine("Yes")
        'Else
        '    Console.WriteLine("No")
        'End If

        'myString = myString.Replace(" ", "--")

        myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length)


        Console.WriteLine(myString)
        Console.ReadLine()
    End Sub
End Module
