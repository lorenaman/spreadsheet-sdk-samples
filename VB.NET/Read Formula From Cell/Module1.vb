'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
        document.LoadFromFile("sample.xls")

        ' get the very first worksheet
        Dim sheet As Worksheet = document.Worksheet(0)

        Console.WriteLine("reading total price formula from cell B5")
        ' we use .Formula value to read from the B5 cell
        Console.WriteLine("Formula in B5 cell is: " + sheet.Cell("B5").Formula)
        Console.WriteLine("\npress any key to continue")
        Console.ReadKey()
    End Sub

End Module
