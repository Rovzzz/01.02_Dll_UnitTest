using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTest1
{
    [TestClass]
    public class BrakTest
    {
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
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int result = 0;
            Class1 class1 = new Class1();
            int actual = class1.GetQuantityForProduct(a, b, c,d,e,f);
            Assert.IsNull(actual);
        }
    }
}
