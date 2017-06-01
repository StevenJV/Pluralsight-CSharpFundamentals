using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  public class GradeStatistics
  {
    readonly float _average;
    readonly float _maxgrade;
    readonly float _mingrade;

    public GradeStatistics(float average, float mingrade, float maxgrade)
    {
      _average = average;
      _maxgrade = maxgrade;
      _mingrade = mingrade;
    }

    public string LetterGrade
    {
      get
      {
        string result;
        if (Avg() > 90)
        {
          result = "A";
        }
        else if (Avg() >= 80)
        {
          result = "B";
        }
        else if (Avg() >= 70)
        {
          result = "C";
        }
        else if (Avg() >= 60)
        {
          result = "D";
        }
        else result = "F";
        return result;
      }
    }

    public string Description
    {
      get {
        string result;
        switch (LetterGrade) {
          case "A":
            result = "Excellent";
            break;
          case "B":
            result = "Good";
            break;
          case "C":
            result = "Average";
            break;
          case "D":
            result = "Below Average";
            break;
          default:
            result = "Failing";
            break;
        }
        return result;
      }
    }


    public float Avg() { return _average; }

    public float Min() { return _mingrade; }

    public float Max() { return _maxgrade; }
  }
}