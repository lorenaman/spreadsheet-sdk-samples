//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("sample.xls");

            // get the very first worksheet
            Worksheet sheet = document.Worksheet(0);

            Console.WriteLine("reading total price formula from cell B5");
            // we use .Formula value to read from the B5 cell
            Console.WriteLine("Formula in B5 cell is: " + sheet.Cell("B5").Formula);
            Console.WriteLine("\npress any key to continue");
            Console.ReadKey();
}
    }
}
