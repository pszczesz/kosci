using System;
using System.Text;
using System.Collections.Generic;
using GameLibrary.GameTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary
{
    /// <summary>
    /// Summary description for CubeTest
    /// </summary>
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void CanISetCubeHowMany() {
            ICube cube = new Cube(-10);
            int expected = 10;
            Assert.AreEqual(expected,cube.HowMany);
        }

        [TestMethod]
        public void CanISetZero() {
            ICube cube = new Cube(0);
            int expected = 1;
            Assert.AreEqual(expected, cube.HowMany);
        }

        [TestMethod]
        public void CanIGetRightResult() {
            bool isOk = true;
            const int howMany = 6;
            ICube cube = new Cube(howMany);
            int result;
            for (int i = 0; i < 30; i++) {
                result = cube.GetResult();
                if (result < 1 || result > howMany) {
                    isOk = false;
                    break;
                }
            }
            Assert.IsTrue(isOk);
        }

        [TestMethod]
        public void CanIReachMaxValue() {
            bool isOk = false;
            const int howMany = 6;
            ICube cube = new Cube(howMany);
            for (int i = 0; i < 10000; i++) {
                int result = cube.GetResult();
                if ( result == howMany)
                {
                    isOk = true;
                    break;
                }
            }
            Assert.IsTrue(isOk);
        }
    }
}
