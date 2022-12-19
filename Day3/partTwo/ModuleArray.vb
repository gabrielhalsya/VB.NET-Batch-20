Namespace PartTwo
    Module ModuleArray
        Function GetArray() As Integer()
            Dim arr() As Integer = New Integer(2) {1, 2, 3}
            'array known with '()', in java/c using '[]'
            Return arr
        End Function
        Sub DisplayArray()
            Dim arr() As Integer

            arr = GetArray()
            For i = 0 To arr.Length - 1
                Console.Write($"{arr(i)}")
            Next
            Console.WriteLine()
        End Sub

        Sub InitListGeneric()
            Dim list1 As New List(Of String) From {
            "CodeId", "CodeMay", "CodeTha"
            }

            For Each list In list1
                Console.WriteLine(list)
            Next
        End Sub
    End Module
End Namespace