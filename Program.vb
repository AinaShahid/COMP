Imports System
Imports System.Threading

Module Program
    Sub Main()
        Dim S, StrS As String
        Dim char1, char2 As Char
        Dim k, i As Integer
        k = 0
        char1 = " "
        char2 = " "
        Console.WriteLine("Enter string: ")
        S = Console.ReadLine()
        For k = 1 To Len(S)
            If Len(S) > 2 Then
                char1 = Right(S, 2)
                For i = 1 To Len(S) - 1
                    char2 = Left(S, 2)
                Next
                StrS = char1 & char2
            Else
                StrS = S
            End If
        Next
        Console.Write("the new string is: " & StrS)
        Console.ReadKey()










    End Sub
End Module
