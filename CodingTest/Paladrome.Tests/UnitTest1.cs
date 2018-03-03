using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Paladrome.Library;
namespace Paladrome.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestisPaladrome() {
            var expected = "olleh h";
            Class1 c1  = new Class1();
            string actual = c1.isPaladrome("h hello");
            Assert.AreEqual(expected, actual);
        }


        

        [TestMethod]
        public void TestisisPaladrome2() {
            bool expected = true;
            Class1 c1  = new Class1();
            Assert.IsTrue(c1.isPaladrome2("hello H") == expected);
        }
         [TestMethod]
        public void TestisisPaladrome3() {
            bool expected = true;
            Class1 c1  = new Class1();
            Assert.IsTrue(c1.isPaladrome3(454) == expected);
        }
       
    }
}
