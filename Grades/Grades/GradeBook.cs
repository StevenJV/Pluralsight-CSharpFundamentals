using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  public class GradeBook
  {
    readonly List<float> _grades;

    //fields are private
    private string _name;
    //properties have accessors
    public string Name
    {
      get { return _name; }
      set
      {
        if (!string.IsNullOrEmpty(value))
        {
          _name = value;
        }
      }
    }

    public GradeBook()
    {
      _grades = new List<float>();
    }

    public GradeBook(string name)
    {
      _grades = new List<float>();
      Name = name;
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
      if (_grades.Count > 0)
        return _grades.Max();
      return 0;
    }

    private float MinimumGrade()
    {
      if (_grades.Count > 0)
        return _grades.Min();
      return 0;
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