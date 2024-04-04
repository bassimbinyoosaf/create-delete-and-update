Module mystud
    Class Student
        Public name As String
        Public rollno As Integer
        Public address As String
    End Class
    Sub Main()
        Dim stud As Student = New Student()

        Dim ch As Integer
        Console.WriteLine("1-Insert Values \n 2-Delete Values \n 3-Update Values \n 4-Exit")
        Console.WriteLine("ENTER A CHOICE")

        ch = Console.ReadLine()
        Select Case ch
            Case 1
                Console.WriteLine("Name:")
                stud.name = Console.ReadLine()
                Console.WriteLine("RollNo:")
                stud.rollno = Console.ReadLine()
                Console.WriteLine("Address:")
                stud.address = Console.ReadLine()
            Case 2
                Console.WriteLine("Name:")
                stud.name = Console.ReadLine()
                Console.WriteLine("RollNo:")
                stud.rollno = Console.ReadLine()
                Console.WriteLine("Address:")
                stud.address = Console.ReadLine()
        End Select


    End Sub
End Module