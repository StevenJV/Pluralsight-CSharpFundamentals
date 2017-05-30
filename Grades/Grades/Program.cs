using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class Program
  {
    static void Main(string[] args)
    {
      SpeechSynthesizer synth = new SpeechSynthesizer();
      synth.Speak("Hello! This is the grade book program.");

      GradeBook stevensGradeBook = new GradeBook();
      stevensGradeBook.AddGrade(91);
      stevensGradeBook.AddGrade(95.9f);
      GradeBook bobsGradebok = new GradeBook();
      bobsGradebok.AddGrade(75);
      bobsGradebok.AddGrade(55);

      GradeStatistics stevensStats = stevensGradeBook.ComputeStatistics();
      GradeStatistics bobsStats = bobsGradebok.ComputeStatistics();

      Console.WriteLine("Steven's grade stats:");
      Console.WriteLine($" min: {stevensStats.Min()}, max: {stevensStats.Max()}, avg: {stevensStats.Avg()}");
      Console.WriteLine("Bob's grade stats:");
      Console.WriteLine($" min: {bobsStats.Min()}, max: {bobsStats.Max()}, avg: {bobsStats.Avg()}");
      Console.ReadKey();
    }
  }
}