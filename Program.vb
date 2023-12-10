Module Program
    Sub Main()
        Dim Str1, alphabets As String
        Dim i As Integer
        Dim chr As Char
        Dim alpha As Boolean
        alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Str1 = " "
        chr = " "
        i = 0
        alpha = True
        Console.WriteLine("enter string: ")
        Str1 = UCase(Console.ReadLine())
        For i = 1 To Len(Str1)
            chr = Mid(alphabets, i, 1)
            If chr >= "A" And chr <= "Z" Then
                alpha = True
            Else
                alpha = False
            End If
        Next
        If alpha = False Then
            Console.WriteLine("the string does not have all the alphabets")
        Else
            Console.WriteLine("the string has all the alphabets")
        End If
        Console.ReadKey()

    End Sub
End Module
