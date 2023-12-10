Imports System
Imports System.Threading

Module Program
    Sub Main()
        'inputtwo strings and swap two chars of both string
        Dim str1, str2, Newstr1, Newstr2, MX As String
        Dim i, k As Integer
        Dim chr1, chr2, X, Y As String
        i = 0
        k = 0
        str1 = " "
        str2 = " "
        Newstr1 = " "
        Newstr2 = " "
        MX = " "
        chr1 = " "
        chr2 = " "
        X = " "
        Y = " "
        Console.WriteLine("enter the word: ")
        str1 = Console.ReadLine()
        Console.WriteLine("enter the second word: ")
        str2 = Console.ReadLine()
        i = Len(str1)
        k = Len(str2)
        If i >= 2 Then
            chr1 = Left(str1, 2)
            If k >= 2 Then
                chr2 = Left(str2, 2)
            End If
        End If
        If i > 2 Then
            X = Right(str1, i - 2)
            If k > 2 Then
                Y = Right(str2, k - 2)
            End If
        End If

        Newstr1 = chr1 & Y
        Newstr2 = chr2 & X

        MX = Newstr1 & " " & Newstr2
        Console.WriteLine("the new string is " & MX)
        Console.ReadKey()

    End Sub
End Module
