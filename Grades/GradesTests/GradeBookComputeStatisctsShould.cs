namespace Grades
{
  using FluentAssertions;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;
  using Xunit;
  using Xunit.Extensions;


  public class GradeBookComputeStatisctsShould
  {
    [Fact]
    public void Return_average_of_multiple_grades()
    {
      GradeBook gradebook = new GradeBook();
      gradebook.AddGrade(75f);
      gradebook.AddGrade(77f);
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(76f, gradebookStats.Avg());
    }

    [Fact]
    public void Return_average_zero_if_no_grades()
    {
      GradeBook gradebook = new GradeBook();
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(0f, gradebookStats.Avg());
    }

    [Fact]
    public void Return_average_of_single_grade_if_only_one_grade()
    {
      GradeBook gradebook = new GradeBook();
      gradebook.AddGrade(75f);
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(75f, gradebookStats.Avg());
    }
    [Fact]
    public void Return_max_zero_if_no_grades()
    {
      GradeBook gradebook = new GradeBook();
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(0f, gradebookStats.Max());
    }
    [Fact]
    public void Return_min_zero_if_no_grades()
    {
      GradeBook gradebook = new GradeBook();
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(0f, gradebookStats.Min());
    }
    [Fact]
    public void Return_min_of_multiple_grades()
    {
      GradeBook gradebook = new GradeBook();
      gradebook.AddGrade(75f);
      gradebook.AddGrade(77f);
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(75f, gradebookStats.Min());
    }
    [Fact]
    public void Return_max_of_multiple_grades()
    {
      GradeBook gradebook = new GradeBook();
      gradebook.AddGrade(75f);
      gradebook.AddGrade(77f);
      GradeStatistics gradebookStats = gradebook.ComputeStatistics();
      Assert.Equal(77f, gradebookStats.Max());
    }

  }
}
