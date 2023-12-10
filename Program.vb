Imports System
Imports System.ComponentModel.Design

Module Program
    Sub Main()
        Dim str, Str2 As String
        Dim chr, chr2 As String

        Str2 = " "  ' variable which stores the string after any addition or no changes 
        str = " "
        chr = "ing "
        chr2 = "ly"
        Console.WriteLine("enter string:")
        str = Console.ReadLine()
        If Len(str) >= 3 And Right(str, 3) = "ing" Then
            Str2 = str & chr2
        ElseIf Len(str) >= 3 Then
            Str2 = str & chr
        Else
            Str2 = str
        End If
        Console.WriteLine("the new string is: " & Str2)
        Console.ReadKey()

    End Sub
End Module
