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

    public float AverageGrade() {
      float total = 0;
      foreach (var grade in _grades) {
        total += grade;
      }
      return total/_grades.Count;
    }
  }
}
