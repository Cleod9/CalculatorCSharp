using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator
{
    //This class contains all the test cases I made for NUnit
    //If you have NUnit installed you can debug easily by seeing if any test cases become broken

    [TestFixture]
    public class Test_Appending
    {
        [Test]
        public void appendDigit_0_9()
        {
            clearCalcEngine();
            for (int i = 9; i >= 0; i--)
            {
                calcEngine.appendNum(i);
                Assert.AreEqual(i, calcEngine.getDisplay());
                clearCalcEngine();
            }
        }
        [Test]
        public void appendDigit_multiple()
        {
            clearCalcEngine();
            for (int i = 9; i >= 0; i--)
            {
                calcEngine.appendNum(i);
            }
            Assert.AreEqual(9876543210, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void appendDigit_decimal()
        {
            clearCalcEngine();
            calcEngine.appendNum(8);
            calcEngine.appendNum(4);
            calcEngine.other_fcns("decimal");
            calcEngine.appendNum(2);
            calcEngine.appendNum(5);
            Assert.AreEqual(84.25, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void appendNum_multiple()
        {
            clearCalcEngine();
            calcEngine.appendNum(829);
            Assert.AreEqual(829, calcEngine.getDisplay());
            calcEngine.appendNum(204);
            Assert.AreEqual(829204, calcEngine.getDisplay());
            clearCalcEngine();
            calcEngine.appendNum(5392.634);
            Assert.AreEqual(5392.634, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void appendNum_decimal()
        {
            clearCalcEngine();
            //Try doing two decimals at once
            calcEngine.appendNum(84.523);
            Assert.AreEqual(84.523, calcEngine.getDisplay());
            calcEngine.appendNum(678.935); //Should replae the other one
            Assert.AreEqual(678.935, calcEngine.getDisplay());
            clearCalcEngine();
            //Now try agian after doing a normal append
            calcEngine.appendNum(8);
            calcEngine.appendNum(4);
            calcEngine.other_fcns("decimal");
            calcEngine.appendNum(2);
            calcEngine.appendNum(5);
            Assert.AreEqual(84.25, calcEngine.getDisplay());
            calcEngine.appendNum(678.935); //Should replae the other one
            Assert.AreEqual(678.935, calcEngine.getDisplay());
            clearCalcEngine();
            //Now try doing before a normal append (should just append to decimal)
            calcEngine.appendNum(678.935); //Should replae the other one
            Assert.AreEqual(678.935, calcEngine.getDisplay());
            calcEngine.appendNum(8);
            calcEngine.appendNum(4);
            calcEngine.other_fcns("decimal");
            calcEngine.appendNum(2);
            calcEngine.appendNum(5);
            Assert.AreEqual(678.9358425, calcEngine.getDisplay());
            clearCalcEngine();
        }
        public void clearCalcEngine()
        {
            calcEngine.clearAll();
            Assert.IsTrue(calcEngine.assureCleared());
        }
    }
    [TestFixture]
    public class Test_Memory
    {
        [Test]
        public void clearAll()
        {
            clearCalcEngine();
            calcEngine.appendNum(34.223);
            calcEngine.prepareOperation("+");
            calcEngine.other_fcns("switchSign");
            clearCalcEngine();
            calcEngine.other_fcns("open_paren");
            calcEngine.appendNum(34.223);
            calcEngine.prepareOperation("add");
            clearCalcEngine();
        }
        [Test]
        public void storeMemory()
        {
            clearCalcEngine();
            calcEngine.appendNum(526.42);
            calcEngine.memory("memStore");
            Assert.IsTrue(526.42-Math.Abs(Convert.ToDouble(calcEngine.m_memory)) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void recallMemory()
        {
            clearCalcEngine();
            calcEngine.appendNum(526.42);
            calcEngine.memory("memStore");
            clearCalcEngine();
            calcEngine.memory("memRecall");
            Assert.IsTrue(526.42 - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void sumToMemory()
        {
            clearCalcEngine();
            calcEngine.appendNum(526.42);
            calcEngine.memory("memStore");
            clearCalcEngine();
            calcEngine.memory("memRecall");
            Assert.IsTrue(526.42 - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
            calcEngine.appendNum(35.56);
            calcEngine.memory("memAdd");
            Assert.IsTrue((526.42 + 35.56) - (Convert.ToDouble(calcEngine.m_memory) + calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void clearMemory()
        {
            clearCalcEngine();
            calcEngine.appendNum(526.42);
            calcEngine.memory("memStore");
            clearCalcEngine();
            Assert.IsTrue(526.42 - Math.Abs(Convert.ToDouble(calcEngine.m_memory)) < 0.000000001);
            calcEngine.memory("memClear");
            Assert.IsNull(calcEngine.m_memory);
            clearCalcEngine();
        }
        public void clearCalcEngine()
        {
            calcEngine.clearAll();
            Assert.IsTrue(calcEngine.assureCleared());
        }
    }
    [TestFixture]
    public class Test_TrigFunctions
    {
         
        [Test]
        public void trig_SIN()
        {
            clearCalcEngine();
            calcEngine.m_useRadians = true;
            Assert.IsTrue(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("sin");
            Assert.IsTrue(Math.Sin(55) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
            clearCalcEngine();
            calcEngine.m_useRadians = false;
            Assert.IsFalse(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("sin");
            Assert.IsTrue(Math.Sin(55 * Math.PI / 180) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void trig_COS()
        {
            clearCalcEngine();
            calcEngine.m_useRadians = true;
            Assert.IsTrue(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("cos");
            Assert.IsTrue(Math.Cos(55) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
            clearCalcEngine();
            calcEngine.m_useRadians = false;
            Assert.IsFalse(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("cos");
            Assert.IsTrue(Math.Cos(55 * Math.PI / 180) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void trig_TAN()
        {
            clearCalcEngine();
            calcEngine.m_useRadians = true;
            Assert.IsTrue(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("tan");
            Assert.IsTrue(Math.Tan(55) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
            clearCalcEngine();
            calcEngine.m_useRadians = false;
            Assert.IsFalse(calcEngine.m_useRadians);
            calcEngine.appendNum(55);
            calcEngine.trig_fcns("tan");
            Assert.IsTrue(Math.Tan(55 * Math.PI / 180) - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        [Test]
        public void trig_PI()
        {
            clearCalcEngine();
            calcEngine.trig_fcns("pi");
            Assert.IsTrue(Math.PI-Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
            calcEngine.appendNum(234);
            Assert.IsTrue(Math.PI - Math.Abs(calcEngine.getDisplay()) < 0.000000001);
            clearCalcEngine();
        }
        public void clearCalcEngine()
        {
            calcEngine.clearAll();
            Assert.IsTrue(calcEngine.assureCleared());
        }
    }
    [TestFixture]
    public class Test_MathFunctions
    {
        //Tests both postive and negative numbers for math functions
        //Tests consecutive presses of the solve button
        //Tests a change of operation to anything besides current one
        [Test]
        public void math_ADD()
        {
            clearCalcEngine();
            calcEngine.appendNum(83);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(17);
            calcEngine.solve();
            Assert.AreEqual(100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(117, calcEngine.getDisplay());
            //If you don't hit the add button again after hitting '=', then it assumes you're typing a new number
            calcEngine.prepareOperation("add");
            //Now you may append a numbers
            calcEngine.appendNum(3);
            calcEngine.prepareOperation("subtract");
            //Make sure display got updated after changing operation
            Assert.AreEqual(120, calcEngine.getDisplay());
            clearCalcEngine();
            //Now try every combination of negative values
            //-+
            calcEngine.appendNum(-83);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(13);
            calcEngine.solve();
            Assert.AreEqual(-70, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-57, calcEngine.getDisplay());
            clearCalcEngine();
            //+-
            calcEngine.appendNum(83);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(-13);
            calcEngine.solve();
            Assert.AreEqual(70, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(57, calcEngine.getDisplay());
            clearCalcEngine();
            //--
            calcEngine.appendNum(-83);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(-17);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-117, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void math_SUBTRACT()
        {
            clearCalcEngine();
            calcEngine.appendNum(83);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(3);
            calcEngine.solve();
            Assert.AreEqual(80, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(77, calcEngine.getDisplay());
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(7);
            calcEngine.prepareOperation("add");
            Assert.AreEqual(70, calcEngine.getDisplay());
            clearCalcEngine();
            //-+
            calcEngine.appendNum(-83);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(17);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-117, calcEngine.getDisplay());
            clearCalcEngine();
            //+-
            calcEngine.appendNum(83);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(-17);
            calcEngine.solve();
            Assert.AreEqual(100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(117, calcEngine.getDisplay());
            clearCalcEngine();
            //--
            calcEngine.appendNum(-83);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(-13);
            calcEngine.solve();
            Assert.AreEqual(-70, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-57, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void math_MULTIPLY()
        {
            clearCalcEngine();
            calcEngine.appendNum(10);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(5);
            calcEngine.solve();
            Assert.AreEqual(50, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(250, calcEngine.getDisplay());
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(2);
            calcEngine.prepareOperation("divide");
            Assert.AreEqual(500, calcEngine.getDisplay());
            clearCalcEngine();
            //-+
            calcEngine.appendNum(-20);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(5);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-500, calcEngine.getDisplay());
            clearCalcEngine();
            //+-
            calcEngine.appendNum(20);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(-5);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(500, calcEngine.getDisplay());
            clearCalcEngine();
            //--
            calcEngine.appendNum(-20);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(-5);
            calcEngine.solve();
            Assert.AreEqual(100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-500, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void math_DIVIDE()
        {
            clearCalcEngine();
            calcEngine.appendNum(500);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(2);
            calcEngine.solve();
            Assert.AreEqual(250, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(125, calcEngine.getDisplay());
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(0.5);
            calcEngine.prepareOperation("multiply");
            Assert.AreEqual(250, calcEngine.getDisplay());
            clearCalcEngine();
            //-+
            calcEngine.appendNum(-500);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(5);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-20, calcEngine.getDisplay());
            clearCalcEngine();
            //+-
            calcEngine.appendNum(500);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(-5);
            calcEngine.solve();
            Assert.AreEqual(-100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(20, calcEngine.getDisplay());
            clearCalcEngine();
            //--
            calcEngine.appendNum(-500);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(-5);
            calcEngine.solve();
            Assert.AreEqual(100, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-20, calcEngine.getDisplay());
            clearCalcEngine();
            //Check divide by Zero
            calcEngine.appendNum(5);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(0);
            Assert.IsFalse(calcEngine.solve());
        }
        [Test]
        public void math_DIF_OPERATIONS()
        {
            clearCalcEngine();
            calcEngine.appendNum(3);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(5);
            calcEngine.prepareOperation("multiply");
            Assert.AreEqual(8, calcEngine.getDisplay());
            calcEngine.appendNum(3);
            calcEngine.solve();
            Assert.AreEqual(24, calcEngine.getDisplay());
            calcEngine.prepareOperation("divide");
            Assert.AreEqual(24, calcEngine.getDisplay());
            calcEngine.appendNum(6);
            calcEngine.prepareOperation("subtract");
            Assert.AreEqual(4, calcEngine.getDisplay());
            calcEngine.appendNum(1.5);
            calcEngine.solve();
            Assert.AreEqual(2.5, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(1, calcEngine.getDisplay());
            calcEngine.prepareOperation("add");
            Assert.AreEqual(1, calcEngine.getDisplay());
            calcEngine.appendNum(-3);
            calcEngine.solve();
            Assert.AreEqual(-2, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(-5, calcEngine.getDisplay());
            clearCalcEngine();
        }

        public void clearCalcEngine()
        {
            calcEngine.clearAll();
            Assert.IsTrue(calcEngine.assureCleared());
        }
    }
    [TestFixture]
    public class Test_MiscFunctions
    {
        [Test]
        public void misc_SQRT()
        {
            clearCalcEngine();
            calcEngine.appendNum(25);
            calcEngine.other_fcns("sqrt");
            Assert.IsTrue(5 == calcEngine.getDisplay());
            calcEngine.other_fcns("sqrt");
            Assert.IsTrue(Math.Sqrt(5) - Math.Abs(calcEngine.getDisplay()) < 0.0000001);
            clearCalcEngine();
            calcEngine.appendNum(-3);
            Assert.IsFalse(calcEngine.other_fcns("sqrt"));
            clearCalcEngine();
        }
        [Test]
        public void misc_PERCENT()
        {
            //(+)
            clearCalcEngine();
            calcEngine.appendNum(50);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(25);
            calcEngine.other_fcns("percent");
            Assert.AreEqual(12.5, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(62.5, calcEngine.getDisplay());
            //(-)
            clearCalcEngine();
            calcEngine.appendNum(50);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(25);
            calcEngine.other_fcns("percent");
            Assert.AreEqual(12.5, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(37.5, calcEngine.getDisplay());
            //(*)
            clearCalcEngine();
            calcEngine.appendNum(50);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(25);
            calcEngine.other_fcns("percent");
            Assert.AreEqual(12.5, calcEngine.getDisplay());
            calcEngine.other_fcns("percent");
            Assert.AreEqual(6.25, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(312.5, calcEngine.getDisplay());
            //(/)
            clearCalcEngine();
            calcEngine.appendNum(50);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(25);
            calcEngine.other_fcns("percent");
            Assert.AreEqual(12.5, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(4, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void misc_INVERSE()
        {
            clearCalcEngine();
            calcEngine.appendNum(5);
            calcEngine.other_fcns("inverse");
            Assert.IsTrue(1 / 5 - Math.Abs(calcEngine.getDisplay()) < 0.0000001);
            clearCalcEngine();
            calcEngine.appendNum(0);
            Assert.IsFalse(calcEngine.other_fcns("inverse"));
            clearCalcEngine();
        }
        [Test]
        public void misc_BACKSPACE()
        {
            clearCalcEngine();
            calcEngine.appendNum(45352.743);
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(45352.74, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(45352.7, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(45352, calcEngine.getDisplay());
            Assert.IsTrue(calcEngine.m_decimal);
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(45352, calcEngine.getDisplay());
            Assert.IsFalse(calcEngine.m_decimal);
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(4535, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(453, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(45, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(4, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.AreEqual(0, calcEngine.getDisplay());
            calcEngine.other_fcns("backspace");
            Assert.IsFalse(calcEngine.other_fcns("backspace"));
            clearCalcEngine();
        }
        [Test]
        public void misc_PARENTHESES()
        {
            clearCalcEngine();
            calcEngine.other_fcns("open_paren");
            Assert.IsTrue(calcEngine.m_openParen);
            Assert.IsFalse(calcEngine.m_closeParen);
            calcEngine.appendNum(1);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(-2);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(88);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(54);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(36);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(21);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(2);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(-13);
            calcEngine.other_fcns("close_paren");
            Assert.IsTrue(calcEngine.m_closeParen);
            Assert.IsFalse(calcEngine.m_openParen);
            Assert.AreEqual(-40,calcEngine.getDisplay());
            //Try Again
            calcEngine.other_fcns("open_paren");
            Assert.IsTrue(calcEngine.m_openParen);
            Assert.IsFalse(calcEngine.m_closeParen);
            calcEngine.appendNum(1);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(-2);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(88);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(54);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(36);
            calcEngine.prepareOperation("subtract");
            calcEngine.appendNum(21);
            calcEngine.prepareOperation("divide");
            calcEngine.appendNum(2);
            calcEngine.prepareOperation("multiply");
            calcEngine.appendNum(-13);
            calcEngine.other_fcns("close_paren");
            Assert.IsTrue(calcEngine.m_closeParen);
            Assert.IsFalse(calcEngine.m_openParen);
            Assert.AreEqual(-40, calcEngine.getDisplay());
            clearCalcEngine();
        }
        [Test]
        public void misc_clearEntry()
        {
            clearCalcEngine();
            calcEngine.appendNum(83);
            calcEngine.prepareOperation("add");
            calcEngine.appendNum(17);
            calcEngine.clear();
            calcEngine.appendNum(27); //Chagne 17 to 27
            calcEngine.solve();
            Assert.AreEqual(110, calcEngine.getDisplay());
            calcEngine.solve();
            Assert.AreEqual(137, calcEngine.getDisplay());
            clearCalcEngine();
        }

        public void clearCalcEngine()
        {
            calcEngine.clearAll();
            Assert.IsTrue(calcEngine.assureCleared());
        }
    }
}
