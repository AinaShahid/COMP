Imports System

Module Program
    Sub Main()
        Dim Str1 As String
        Dim NumCount, i, k, ANum As Integer
        Dim Chr, chr2, Chr3 As Char
        ANum = 0
        Chr3 = " "
        NumCount = 0
        Console.WriteLine("Enter the strin: ")
        Str1 = Console.ReadLine()
        For k = 1 To Len(Str1)
            Chr = Mid(Str1, k, 1)
            NumCount = 0
            For i = 1 To Len(Str1)
                chr2 = Mid(Str1, i, 1)
                If Chr = chr2 Then NumCount = NumCount + 1
            Next
            If NumCount > ANum Then
                ANum = NumCount
                Chr3 = chr2
            End If
        Next
        Console.WriteLine(Chr3 & " : appeared" & ANum & "  : times")
        Console.ReadKey()








    End Sub
End Module
