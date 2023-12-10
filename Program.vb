Imports System

Module Program
    Sub Main()
        Dim str1, Nstr As String
        Dim chr, chr2, chr3 As String
        Nstr = " "
        str1 = " "
        chr = InStr(str1, "not")
        chr2 = InStr(str1, "bad ")
        chr3 = "good"
        Console.WriteLine("enter string: ")
        str1 = Console.ReadLine()
        If chr & chr2 = "not bad" Then
            Nstr = str1 & chr3
        End If
        Console.WriteLine(Nstr)
        Console.ReadKey()



    End Sub
End Module
