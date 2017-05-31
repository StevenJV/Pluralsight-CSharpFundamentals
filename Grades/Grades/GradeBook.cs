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

    private string _name;
    public string Name
    {
      get { return _name; }
      set
      {
        if (!string.IsNullOrEmpty(value))
        {
          if (_name != value) {
            // name is changing, others might need to know about it.
            NameChanged(_name, value);
          }
          _name = value;
        }
      }
    }

    public event NameChangedDeligate NameChanged;


    public GradeBook()
    {
      _grades = new List<float>();
      _name = "Empty";
    }

    public GradeBook(string name)
    {
      _grades = new List<float>();
      _name = name;
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