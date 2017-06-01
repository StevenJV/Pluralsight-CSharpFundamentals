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
      var stevensGradeBook = CreateStevensGradeBook();
      var bobsGradebook = CreateBobsGradebook();

      GradeStatistics stevensStats = stevensGradeBook.ComputeStatistics();
      GradeStatistics bobsStats = bobsGradebook.ComputeStatistics();

      Console.WriteLine($"\n{stevensGradeBook.Name}'s grades:");
      stevensGradeBook.WriteGrades(Console.Out);
      WriteResult("minimum", (int)stevensStats.Min());
      WriteResult("maximum", (int)stevensStats.Max());
      WriteResult("average", stevensStats.Avg());
      WriteResult("grade", stevensStats.Description);

      Console.WriteLine($"\n{bobsGradebook.Name}'s grades:");
      bobsGradebook.WriteGrades(Console.Out);
      WriteResult("minimum", (int)bobsStats.Min());
      WriteResult("maximum", (int)bobsStats.Max());
      WriteResult("average", bobsStats.Avg());
      WriteResult("grade", bobsStats.Description);
    }

    private static GradeBook CreateBobsGradebook()
    {
      GradeBook bobsGradebook = new GradeBook();
      bobsGradebook.NameChanged += OnNameChanged;
      bobsGradebook.Name = "Bob";
      bobsGradebook.AddGrade(75);
      bobsGradebook.AddGrade(76);
      bobsGradebook.AddGrade(60);
      bobsGradebook.AddGrade(78);
      bobsGradebook.AddGrade(55);
      return bobsGradebook;
    }

    private static GradeBook CreateStevensGradeBook()
    {
      GradeBook stevensGradeBook = new GradeBook("Steven");
      stevensGradeBook.AddGrade(91);
      stevensGradeBook.AddGrade(95.9f);
      return stevensGradeBook;
    }

    private static void OnNameChanged(object sender, NameChangedEventArgs args)
    {
      Console.WriteLine($"grade book changing name from {args.ExsitingName} to {args.NewName}");
    }

    static void WriteResult(string description, float result)
    {
      Console.WriteLine($"{description}: {result:F2}");
    }
    static void WriteResult(string description, int result)
    {
      Console.WriteLine($"{description}: {result}");
    }
    static void WriteResult(string description, string result)
    {
      Console.WriteLine($"{description}: {result}");
    }

  }
}