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
      GradeBook bobsGradebok= new GradeBook();
      bobsGradebok.AddGrade(75);
      
      Console.WriteLine("Steven's average grade: " + stevensGradeBook.AverageGrade());
      Console.WriteLine("Bob's average grade: " + bobsGradebok.AverageGrade());
      Console.ReadKey();

    }
  }
}
