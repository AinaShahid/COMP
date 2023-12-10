Imports System

Module Program
    Sub Main()
        Dim Dounts As Integer
        Dounts = 0
        Console.WriteLine("enter the num of donuts: ")
        Dounts = Console.ReadLine()
        If Dounts >= 10 Then
            Console.WriteLine("number of dounts: many ")
        Else
            Console.WriteLine("number of dounts: " & Dounts)
        End If



    End Sub
End Module
