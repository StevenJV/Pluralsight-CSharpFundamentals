using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  internal interface IGradeTracker
  {
    void AddGrade(float grade);
    GradeStatistics ComputeStatistics();
    void WriteGrades(TextWriter desination);
    string Name { get; set; }
  }
}
