using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  public class GradeBook
  {
    protected readonly List<float> _grades;

    private string _name;
    public string Name
    {
      get { return _name; }
      set
      {
        if (string.IsNullOrEmpty(value))
        {
          throw new ArgumentNullException($"Name cannot be null or empty");
        }

        if (_name != value)
        {
          NameChangedEventArgs args = new NameChangedEventArgs
          {
            ExsitingName = _name,
            NewName = value
          };
          NameChanged?.Invoke(this, args); // same as `if (NameChanged != null) NamedChanged(this, args)` 
        }
        _name = value;

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

    public virtual GradeStatistics ComputeStatistics()
    {
      return new GradeStatistics(AverageGrade(), MinimumGrade(), MaximumGrade());
    }

    private float MaximumGrade()
    {
      if (_grades.Count > 0)
        return _grades.Max();
      return 0;
    }

    protected float MinimumGrade()
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

    public void WriteGrades(TextWriter desination)
    {
      for (int i = 0; i < _grades.Count; i++)
      {
        desination.WriteLine(_grades[i]);
      }
    }
  }
}