using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.MSTest.Types
{
  [TestClass]
  public class TypeTests
  {
    [TestMethod]
    public void UsingArrays()
    {
      var grades = new float[3];
      AddGrades(grades);
      Assert.AreEqual(89.1f, grades[1]);
    }

    private void AddGrades(float[] grades)
    {
      // arrays are reference type, so the contents of the array object to which grades points can be changed
      grades[1] = 89.1f;
    }

    [TestMethod]
    public void AddDaysToDateTime()
    {
      DateTime date = new DateTime(2017, 1, 1);
      date.AddDays(1);
      // Assert.AreEqual(2,date.Day); // fails, as DateTime is a value type and therefore immutable
      DateTime newdate = date.AddDays(1);
      Assert.AreEqual(2, newdate.Day);
    }

    [TestMethod]
    public void UppercaseString()
    {
      string name = "steven";
      name.ToUpper(); // doesn't actually do anything useful. Even though string is a reference type, it behaves like a value type
      // Assert.AreEqual("STEVEN", name); // fails as name never got changed.
      name = name.ToUpper(); // re-points name to location of returned (upper-case) string
      Assert.AreEqual("STEVEN", name);
    }

    [TestMethod]
    public void ValueTypesPassByValue()
    {
      int x = 46;
      IncrementNumber(x);
      Assert.AreEqual(46, x);
    }

    private void IncrementNumber(int i)
    {
      i++;
    }

    [TestMethod]
    public void ReferenceTypesPassByValue()
    {
      GradeBook book1 = new GradeBook();
      GradeBook book2 = book1;
      GiveBookAName(book2);
      Assert.AreEqual("A Name", book1.Name);
    }

    private void GiveBookAName(GradeBook book)
    {
      book.Name = "A Name";
    }

    [TestMethod]
    public void StringComparisons()
    {
      string name1 = "Scott";
      string name2 = "scott";
      bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
      Assert.IsTrue(result);
    }
    [TestMethod]
    public void IntVariablesHoldAValue()
    {
      int x1 = 100;
      int x2 = x1;
      x1 = 4;
      Assert.AreNotEqual(x1, x2);
    }
    [TestMethod]
    public void GradeBookVariablesHoldAReference()
    {
      GradeBook g1 = new GradeBook();
      GradeBook g2 = g1;
      g1.Name = "Scott's grade book";
      Assert.AreEqual(g1.Name, g2.Name);
    }
  }
}
