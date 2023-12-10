Imports System

Module Program
    Sub Main()
        Dim Str1 As String
        Dim j, vowel As Integer
        Dim CHR As Char
        j = 0
        vowel = 0
        Console.WriteLine("Enter string to find vowels from it: ")
        Str1 = UCase(Console.ReadLine())
        For j = 1 To Len(Str1)
            CHR = Mid(Str1, j, 1)
            If CHR = "A" Or CHR = "E" Or CHR = "I" Or CHR = "O" Or CHR = "U" Then
                vowel = vowel + 1
            End If
        Next
        Console.WriteLine("number of vowels in the string:  " & vowel)
        Console.ReadKey()







    End Sub
End Module
