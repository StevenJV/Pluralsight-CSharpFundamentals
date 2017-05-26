using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class GradeBook
  {
    readonly List<float> _grades;
    public GradeBook()
    {
      _grades = new List<float>();
    }

    public void AddGrade(float grade)
    {
      _grades.Add(grade);
    }

    public GradeStatistics ComputeStatistics()
    {
      return new GradeStatistics(AverageGrade(), MinimumGrade(), MaximumGrade());
    }

    private float MaximumGrade()
    {
      return _grades.Max();
    }

    private float MinimumGrade()
    {
      return _grades.Min();
    }

    private float AverageGrade()
    {
      float total = 0;
      foreach (var grade in _grades)
      {
        total += grade;
      }
      if (_grades.Count > 0)
        return total / _grades.Count;
      return 0;
    }
  }


}
