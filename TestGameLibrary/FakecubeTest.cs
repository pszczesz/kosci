using System;
using GameLibrary.GameTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary
{
    [TestClass]
    public class FakecubeTest
    {
        [TestMethod]
        public void CanSetResult()
        {
            ICube  cube = new FakeCube(4);
            int result = cube.GetResult(4);
            int expected = 4;
            Assert.AreEqual(expected,result);
        }
    }
}
