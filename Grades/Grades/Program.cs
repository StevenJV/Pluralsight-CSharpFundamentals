﻿using System;
using System.Collections.Generic;
using System.IO;
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
      IGradeTracker stevensGradebook = CreateGradeBook("Steven");
      AddGrades(stevensGradebook);

      IGradeTracker bobsGradebook = CreateGradeBook("Bob");
      AddGrades(bobsGradebook);

      WriteResults(stevensGradebook);
      WriteResults(bobsGradebook);
    }

    private static IGradeTracker CreateGradeBook(string name)
    {
      if (name.ToUpper() == "BOB")
        return new ThrowAwayGradeBook(name);
      else
        return new GradeBook(name);
    }



    private static void AddGrades(IGradeTracker book)
    {
      book.AddGrade(75);
      book.AddGrade(76);
      book.AddGrade(55);
      book.AddGrade(60);
      book.AddGrade(78);
    }


    private static void OnNameChanged(object sender, NameChangedEventArgs args)
    {
      Console.WriteLine($"grade book changing name from {args.ExsitingName} to {args.NewName}");
    }

    private static void WriteResults(IGradeTracker book)
    {
      Console.WriteLine($"\n{book.Name}'s grade stats:");
      book.WriteGrades(Console.Out);
      GradeStatistics stats = book.ComputeStatistics();
      WriteResult("minimum", (int)stats.Min());
      WriteResult("maximum", (int)stats.Max());
      WriteResult("average", stats.Avg());
      WriteResult("grade", stats.Description);
    }

    private static void SaveGrades(IGradeTracker book)
    {
      using (StreamWriter outputFile = File.CreateText("grades.txt"))
      {
        book.WriteGrades(outputFile);
      }
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