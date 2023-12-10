Imports System
Imports System.Transactions

Module Program
    Sub Main()
        Dim Str1, Str2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer
        Str1 = ""
        Str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        i = 0
        Console.WriteLine("Enter the string: ")
        Str1 = Console.ReadLine()
        Console.WriteLine("Enter the character to be replaced: ")
        char1 = Console.ReadLine()
        Console.WriteLine("Enter character to be replaced with: ")
        char2 = Console.ReadLine()
        For i = 1 To Len(Str1)
            char3 = Mid(Str1, i, 1)
            If char1 <> char3 Then
                Str2 = Str2 & char3
            Else
                Str2 = Str2 & char2
            End If
        Next
        Console.WriteLine("The new string is: " & Str2)
        Console.ReadKey()
    End Sub
End Module
