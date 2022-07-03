﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksApi;

namespace BookSearchConsoleApp
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("\n------------------------------------------------------------------------");

         string isbn = "0071807993";
         var output = BookSearch.SearchISBN(isbn);
         var result = output.Result;

         foreach (var item in result.VolumeInfo.Authors)
         {
            Console.WriteLine("Author: \t" + item);
         }
         Console.WriteLine("------------------------------------------------------------------------");
         Console.WriteLine("Book Name: \t" + result.VolumeInfo.Title);
         Console.WriteLine("Author: \t" + result.VolumeInfo.Authors.FirstOrDefault());
         Console.WriteLine("Publisher: \t" + result.VolumeInfo.Publisher);
         Console.WriteLine("------------------------------------------------------------------------");
      }
   }
}
