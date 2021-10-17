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
            Assert.AreEqual("����������� �������: -900\n������ ����������� �������: -9\n������������ �������: 3\n������ ������������ �������: 800", maxmin);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string str = "-1 -2 -3 -900 -9";
            var maxmin = Logic.Maxmin(str);
            Assert.AreEqual("����������� �������: -900\n������ ����������� �������: -9\n������������ �������: -2\n������ ������������ �������: -1", maxmin);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string str = "5 9 34 5 777 90";
            var maxmin = Logic.Maxmin(str);
            Assert.AreEqual("����������� �������: 5\n������ ����������� �������: 5\n������������ �������: 90\n������ ������������ �������: 777", maxmin);
        }
    }
}
