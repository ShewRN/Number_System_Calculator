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
    public class Meth_Calc_Tests
    {
        Meth_Calc meth_calc = new Meth_Calc();

        //Проверка систем счислений
        [TestMethod]
        public void Calculate_Success()
        {
            bool actual = true,
                 expected = true;

            string number1 = "231",
                   number2 = "452",
                   systema = "10";
            try
            {
                actual = meth_calc.Button(number1, number2, systema);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Number1_Fail()
        {
            bool actual = false,
                 expected = false;

            string number1 = "291",
                   number2 = "452",
                   systema = "7";
            try
            {
                actual = meth_calc.Button(number1, number2, systema);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Number2_Fail()
        {
            bool actual = false,
                 expected = false;

            string number1 = "341",
                   number2 = "832",
                   systema = "6";
            try
            {
                actual = meth_calc.Button(number1, number2, systema);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Systema_Digit_Fail()
        {
            bool actual = false,
                 expected = false;

            string number1 = "231",
                   number2 = "452",
                   systema = "13";
            try
            {
                actual = meth_calc.Button(number1, number2, systema);
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

            string number1 = "256",
                   number2 = "",
                   systema = "10";
            try
            {
                actual = meth_calc.Button(number1, number2, systema);
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

            string text = "741";
            try
            {
                actual = meth_calc.Digit_Check1(text);
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

            string text = "Digit";
            try
            {
                actual = meth_calc.Digit_Check1(text);
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

            string text = "#@!&";
            try
            {
                actual = meth_calc.Digit_Check1(text);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}