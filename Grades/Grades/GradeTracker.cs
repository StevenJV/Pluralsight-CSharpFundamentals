using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  public abstract class GradeTracker
  {
    public abstract void AddGrade(float grade);
    public abstract GradeStatistics ComputeStatistics();
    public abstract void WriteGrades(TextWriter desination);

    protected string _name;
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

  }
}
