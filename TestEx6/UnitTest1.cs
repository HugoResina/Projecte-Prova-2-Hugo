using System;
namespace TestEx6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("adsffd")]
        [DataRow("adsffdadf")]
        public void TestLength(string s)
        {
            //arrange
            int max = 12;
            int min = 5;
            //act
            bool flag = ex6.Program.ValidLength(s);
            //assert
            Assert.IsTrue(flag);
        }
        [TestMethod]
        [DataRow("afd")]
        [DataRow("adsffdadfadfasdfadf")]
        public void TestINvalidLength(string s)
        {
            //arrange
            int max = 12;
            int min = 5;
            //act
            bool flag = ex6.Program.ValidLength(s);
            //assert
            Assert.IsFalse(flag);
        }
        [TestMethod]
        [DataRow("a4ds6d")]
        [DataRow("asdf5df")]
        public void TestFormat(string s)
        {
            //arrange
            
            //act
            bool flag = ex6.Program.ValidateFormat(s);
            //assert
            Assert.IsTrue(flag);
        }
        [TestMethod]
        [DataRow("ads]€654d")]
        [DataRow("a#sdf5435df")]
        public void TestINvalidFormat(string s)
        {
            //arrange

            //act
            bool flag = ex6.Program.ValidateFormat(s);
            //assert
            Assert.IsFalse(flag);
        }
    }
}