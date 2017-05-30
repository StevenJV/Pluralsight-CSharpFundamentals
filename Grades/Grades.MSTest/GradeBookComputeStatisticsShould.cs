using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.MSTest
{
  [TestClass]
  public class GradeBookComputeStatisticsShould
  {
    [TestMethod]
    public void ComputeHighestGrade()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(10);
      gradeBook.AddGrade(90);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual(90, stats.Max());
    }
    [TestMethod]
    public void ComputeLowestGrade()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(10);
      gradeBook.AddGrade(90);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual(10, stats.Min());
    }
    [TestMethod]
    public void ComputeAverageGrade()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(91);
      gradeBook.AddGrade(89.5f);
      gradeBook.AddGrade(75);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual(85.16, stats.Avg(), 0.01);
    }
  }
}
