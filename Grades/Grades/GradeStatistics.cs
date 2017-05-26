using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class GradeStatistics
  {
    float _average;
    float _maxgrade;
    float _mingrade;

    public GradeStatistics(float average, float mingrade, float maxgrade) {
      this._average = average;
      this._maxgrade = maxgrade;
      this._mingrade = mingrade;
    }
  }
}
