Imports System.Data.Linq
Imports System.Windows.Documents
Imports Braintree
Imports DevExpress.Data.Browsing
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Module ModuleLinq

    Sub Test()
        Dim numbers() As Integer = {1, 2, 3, 4, 5, 6, 7, 8}

        Dim evensquery = From num In numbers
                         Where num Mod 2 = 0
                         Select num

        'For Each number In queryEven
        '    Console.Write(number & " ")
        'Next

        Dim numEvens = (
        From num In numbers
        Where num Mod 2 = 0
        Select num
        ).Count()

        'Console.Write(numEvens)

        Dim numEvensAgg = Aggregate num In numbers
                              Where num Mod 2 = 0
                                  Select num
                                      Into Count()

        'Console.Write(numEvensAgg)



    End Sub

End Module
