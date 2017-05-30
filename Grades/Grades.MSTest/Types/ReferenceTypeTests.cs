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
