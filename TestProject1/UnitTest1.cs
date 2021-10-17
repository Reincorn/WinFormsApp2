using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "1 2 3 -900 -9 800";
            var maxmin = Logic.Maxmin(str);
            Assert.AreEqual("Минимальный элемент: -900\nВторой минимальный элемент: -9\nМаксимальный элемент: 3\nВторой максимальный элемент: 800", maxmin);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string str = "-1 -2 -3 -900 -9";
            var maxmin = Logic.Maxmin(str);
            Assert.AreEqual("Минимальный элемент: -900\nВторой минимальный элемент: -9\nМаксимальный элемент: -2\nВторой максимальный элемент: -1", maxmin);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string str = "5 9 34 5 777 90";
            var maxmin = Logic.Maxmin(str);
            Assert.AreEqual("Минимальный элемент: 5\nВторой минимальный элемент: 5\nМаксимальный элемент: 90\nВторой максимальный элемент: 777", maxmin);
        }
    }
}
