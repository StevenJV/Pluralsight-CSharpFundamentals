using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class ThrowAwayGradeBook : GradeBook
  {
    public override GradeStatistics ComputeStatistics()
    {
      float lowest = MinimumGrade();
      _grades.Remove(lowest);
      Console.WriteLine($"(lowest grade of {lowest} thrown away.)");
      return base.ComputeStatistics();
    }
    public ThrowAwayGradeBook(string name)
    {
      base.Name = name;
    }
  }
}
