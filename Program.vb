Imports System

Module Program
    Sub Main()
        Dim S As String
        Dim chr As Char
        Dim chr2 As Char
        Dim j As Integer
        Console.WriteLine("enter the word")
        S = Console.ReadLine()
        chr = Left(S, 1)
        Console.WriteLine(chr)
        For j = 1 To Len(S) - 1
            chr2 = Mid(S, (j + 1), 1)
            If chr2 = chr Then
                chr2 = "*"
            End If
            Console.WriteLine(chr2)
        Next
        Console.ReadKey()
    End Sub
End Module
