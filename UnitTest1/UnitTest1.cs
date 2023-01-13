using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTest1
{
    [TestClass]
    public class BrakTest
    {
        ClassLibrary1.Class1 class11 = new ClassLibrary1.Class1();

        [TestMethod] //Тест на сравнение результатов
        public void BrakTest1()
        {
            //arrange
            int productType = 1;
            int materialType = 1;
            int count = 40;
            int width = 100;
            int length = 50;
            int percent_br = 10;
            int expected = 4;

            //act
            Class1 class1 = new Class1();
            int actual = class1.GetQuantityForProduct(productType,materialType,count,width,length,percent_br);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //Тест на проверку 0
        public void TestNull()
        {
            Assert.IsNull(class11.GetQuantityForProduct(1,1,40,100,50,10));
        }

        [TestMethod] //Тест на True
        public void IsTrue()
        {
            Assert.IsTrue(Convert.ToBoolean(class11.GetQuantityForProduct(1, 1, 40, 100, 50, 10)));
        }

        [TestMethod] //Тест на False
        public void IsFalse()
        {
            Assert.IsFalse(Convert.ToBoolean(class11.GetQuantityForProduct(1, 1, 40, 100, 50, 10)));
        }
    }
}
