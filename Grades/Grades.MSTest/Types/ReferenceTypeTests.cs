using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.MSTest.Types
{
  [TestClass]
  public class ReferenceTypeTests
  {
    [TestMethod]
    public void VariablesHoldAReference()
    {
      GradeBook g1 = new GradeBook();
      GradeBook g2 = g1;
      g1.Name = "Scott's grade book";
      Assert.AreEqual(g1.Name, g2.Name);
    }
  }
}
