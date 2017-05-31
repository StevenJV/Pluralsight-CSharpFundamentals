using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class Program
  {
    static void Main(string[] args)
    {
      GradeBook stevensGradeBook = new GradeBook();
      stevensGradeBook.AddGrade(91);
      stevensGradeBook.AddGrade(95.9f);
      GradeBook bobsGradebok = new GradeBook();
      bobsGradebok.AddGrade(75);
      bobsGradebok.AddGrade(55);

      GradeStatistics stevensStats = stevensGradeBook.ComputeStatistics();
      GradeStatistics bobsStats = bobsGradebok.ComputeStatistics();

      Console.WriteLine("\nSteven's grade stats:");
      WriteResult("minimum", (int)stevensStats.Min());
      WriteResult("maximum", (int)stevensStats.Max());
      WriteResult("average", stevensStats.Avg());

      Console.WriteLine("\nBob's grade stats:");
      WriteResult("minimum", (int)bobsStats.Min());
      WriteResult("maximum", (int)bobsStats.Max());
      WriteResult("average", bobsStats.Avg());
    }

    static void WriteResult(string description, float result)
    {
      Console.WriteLine($"{description}: {result:F2}");
    }
    static void WriteResult(string description, int result)
    {
      Console.WriteLine($"{description}: {result}");
    }
  }
}