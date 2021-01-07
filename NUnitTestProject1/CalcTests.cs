using NUnit.Framework;
using CMProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMProject.Tests
{
    [TestFixture()]
    public class CalcTests
    {
        private Calc c = new Calc();

        [TestCase(7, 4, 6,"7")]
        [TestCase(12, 3, 4,"fizz buzz")]
        [TestCase(12, 2, 5, "fizz")]
        [TestCase(12, 5, 3,"buzz")]
        [TestCase(909, 3, 6, "fizz")]
        [TestCase(112, 3, 4, "buzz")]
        [TestCase(12, 9, 14, "12")]
        [TestCase(120, 15, 40, "fizz buzz")]
        [TestCase(43, -1, 0, "error")]
        public void resultTest(int i, int n1, int n2,string r)
        {
                Assert.AreEqual(c.result(i,n1,n2,"fizz","buzz"),r);
        }

    }
}