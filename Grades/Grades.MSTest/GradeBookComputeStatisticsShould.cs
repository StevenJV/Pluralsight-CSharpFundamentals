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

    [TestMethod]
    public void AssignCorrectLetterGradeA()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(91);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual("A", stats.LetterGrade);
    }
    [TestMethod]
    public void AssignCorrectLetterGradeB()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(85);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual("B", stats.LetterGrade);
    }
    [TestMethod]
    public void AssignCorrectLetterGradeC()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(76);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual("C", stats.LetterGrade);
    }
    [TestMethod]
    public void AssignCorrectLetterGradeD()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(60);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual("D", stats.LetterGrade);
    }
    [TestMethod]
    public void AssignCorrectLetterGradeF()
    {
      GradeBook gradeBook = new GradeBook();
      gradeBook.AddGrade(59);
      GradeStatistics stats = gradeBook.ComputeStatistics();
      Assert.AreEqual("F", stats.LetterGrade);
    }
  }
}
