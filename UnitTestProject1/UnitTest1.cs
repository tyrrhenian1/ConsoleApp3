using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] readyMas = new int[] { 44, 52, 119, 122, 248, 252, 252, 259, 271, 297, 310, 372, 409, 426, 469, 517, 520, 543, 565, 584, 607, 655, 662, 675, 743, 749, 810, 869, 902, 986, 997 };
            int[] mas = new int[] {119,372,252,252,743,749,122,543,584,297,565,517,655,469,426,986,869,662,810,997,52,248,44,259,520,409,607,310,271,675,902};
            ConsoleApp3.Program.sort(mas);
            
            CollectionAssert.AreEqual(readyMas,mas);
        }
    }
}
