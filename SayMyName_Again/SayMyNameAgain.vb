'Payden Hoskins
'RCET2265
'Spring 2025
'Say My Name... Again
'https://github.com/PaydenHoskins/SayMyName_Again.git

Option Explicit On
Option Strict On
Option Compare Text

Module SayMyNameAgain

    Sub Main()
        Dim YourName As String

        Do
            Console.Write("Please insert your name HERE: ")
            YourName = Console.ReadLine()
            If YourName = "Emily" Or YourName = "Joe" Then
                Console.WriteLine()
                Console.WriteLine($"Hello, You must be {YourName}!")
                Console.WriteLine()
            ElseIf YourName = "Payden" Then
                Console.WriteLine()
                Console.WriteLine($"OH MY, You are the one they speak of" &
                                  $" the great and mighty {YourName}!")
                Console.WriteLine()
            ElseIf YourName IsNot "Emily" Or YourName IsNot "Joe" Then
                Console.WriteLine()
            ElseIf YourName IsNot "Payden" Then
                Console.WriteLine()
            End If

            Console.WriteLine("If you would like to end" &
            " type 'Leave' in the name box.")
            Console.WriteLine()
        Loop Until YourName = "Leave"
    End Sub

End Module
