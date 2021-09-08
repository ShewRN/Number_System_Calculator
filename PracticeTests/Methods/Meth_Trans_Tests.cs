using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tests
{
    [TestClass()]
    public class Meth_Trans_Tests
    {
        Meth_Trans meth_trans = new Meth_Trans();

        //Проверка систем счислений
        [TestMethod]
        public void Translate_Success()
        {
            bool actual = true,
                 expected = true;

            string number = "1532",
                   from = "8",
                   to = "10";
            try
            {
                actual = meth_trans.Button(number, from, to);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Systema_Fail()
        {
            bool actual = false,
                 expected = false;

            string number = "1532",
                   from = "1",
                   to = "10";
            try
            {
                actual = meth_trans.Button(number, from, to);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Digit_Systema_Fail()
        {
            bool actual = false,
                 expected = false;

            string number = "1532",
                   from = "3",
                   to = "6";
            try
            {
                actual = meth_trans.Button(number, from, to);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Empty_Fail()
        {
            bool actual = false,
                 expected = false;

            string number = "",
                   from = "3",
                   to = "10";
            try
            {
                actual = meth_trans.Button(number, from, to);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        //проверка сортировки полей на числа
        [TestMethod]
        public void Number_Write_Success()
        {
            bool actual = true,
                 expected = true;

            string  text = "321";
            try
            {
                actual = meth_trans.Digit_Check1(text);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Words_Write_Fail()
        {
            bool actual = false,
                 expected = false;

            string text = "Numb";
            try
            {
                actual = meth_trans.Digit_Check1(text);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        public void Spec_Symobls_Write_Fail()
        {
            bool actual = false,
                 expected = false;

            string text = "/*%";
            try
            {
                actual = meth_trans.Digit_Check1(text);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}

    
