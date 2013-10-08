using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    //This class handles all of the dirty work for the calculator
    //Keep in mind that this is not a post-fix notation engine, so things are done fairly linearly

    internal class calcEngine
    {
        private static String m_equation; //Used for parentheses only
        private static String m_input; //This is the behind the scenes number that represents what will be on the display and what number to store as last input
        private static String m_sign; //Sign of the number (positive or negative)
        public static String m_operation; //Current operator selected (+,-,* or /)
        private static String m_lastNum; //Last result displayed
        private static String m_lastInput; //Last input made
        public static String m_memory; //Number stored in memory
        public static bool m_openParen; //If the parentheses have been opened
        public static bool m_closeParen; //If the parentheses have been closed
        public static bool m_wait; //If the calculator should should start a new input after a number is hit
        public static bool m_decimal; //If the user is entering in decimal values
        public static bool m_useRadians; //If radian mode is on, otherwise it's in degree mode
        private static bool m_lastHitEquals; //If the last key that was hit was the equals button

        //Initalizes the calc engine
        static calcEngine()
        {
            m_equation = "";
            m_input = "."; //I use this to respresent no input, which registers as 0
            m_sign = "+";
            m_operation = null;
            m_lastNum = null;
            m_lastInput = null;
            m_memory = null;
            m_openParen = false;
            m_closeParen = true;
            m_wait = false;
            m_decimal = false;
            m_useRadians = true;
            m_lastHitEquals = false;
        }

        //These are the main functions that are called by the button events above.
        public static void clear()
        {
            //Just clear the current input
            m_sign = "+";
            m_input = ".";
            m_decimal = false;
        }

        //Resets all variables
        public static void clearAll()
        {
            //Reset the calculator
            m_equation = "";
            m_input = ".";
            m_lastNum = null; ;
            m_lastInput = null;
            m_operation = null;
            m_sign = "+";
            m_wait = false;
            m_openParen = false;
            m_closeParen = true;
            m_decimal = false;
            m_lastHitEquals = false;
        }


        //Formats the input into a valid double format
        private static String formatInput(String n)
        {
            //Format the input to something convertable by Convert.toDouble
            if (n.IndexOf(".") == 0) //Prepend a Zero if the string begins with a "."
            {
                n = "0" + n;
            }
            if (n.IndexOf(".") == n.Length - 1) //Appened a Zero if the string ends with a "."
            {
                n = n + "0";
            }
            if (m_sign.Equals("-") && n != "0.0" && n.IndexOf("-") == -1) //If negative is turned on and there's no "-" in the current string, then "-" is prepended
            {
                n = "-" + n;
            }
            return n;
        }

        //Appends number to the input
        public static void appendNum(double numValue)
        {
            if (numValue == Math.Round(numValue) && numValue>=0)
            {
                if (!isEmpty()) //Append number to the input string depending upon if decimal is turned on
                {
                    if (m_decimal)
                    {
                        m_input += "" + numValue;
                    }
                    else
                    {
                        m_input = m_input.Insert(m_input.IndexOf("."), "" + numValue);
                    }
                }
                else //If nothing was entered yet, then set input equal to the number hit
                {
                    if (m_lastHitEquals) //Start over if the last key hit was the equals button and no operators were chosen
                    {
                        clearAll();
                        m_lastHitEquals = false;
                    }
                    if (m_decimal)
                    {
                        m_input = "." + numValue;
                    }
                    else
                    {
                        m_input = numValue + ".";
                    }
                    m_wait = false;
                }
                if (m_input.IndexOf("0", 0, 1) == 0 && m_input.IndexOf(".") > 1)
                {
                    m_input = m_input.Remove(0, 1); //Get rid of any extra zeroes that may have been prepended
                }
            }
            else
            { //If they're trying to append a decimal or negative, that's impossible so just replace the entire input with that value

                if (m_lastHitEquals) //Start over if the last key hit was the equals button and no operators were chosen
                {
                    clearAll();
                    m_lastHitEquals = false;
                }
                m_input = "" + numValue;
                //Reformat first
                m_input = formatInput(m_input);
                if (!m_input.Contains("."))
                {
                    m_input += ".";
                }
                if (m_input.Contains(".") && !(m_input.EndsWith("0") && m_input.IndexOf(".") == m_input.Length - 2))
                {
                    m_decimal = true;
                }
                if (m_input.Contains("-"))
                {
                    m_sign = "-";
                }
                else
                {
                    m_sign = "+";
                }
                //Get rid of any extra zeroes that may have been prepended or appended
                if (m_input.IndexOf("0", 0, 1) == 0 && m_input.IndexOf(".") > 1)
                {
                    m_input = m_input.Remove(0, 1);
                }
                if (m_input.EndsWith("0") && m_input.IndexOf(".") == m_input.Length - 2)
                {
                    m_input.Remove(m_input.Length - 1);
                }
                m_wait = false;
            }
        }

        //Handles operation functions
        public static void prepareOperation(String operationType)
        {
            switch (operationType) //All operator buttons perform in the same manner so I won't go into too much detail
            {
                case "add":
                    if (!m_openParen) //If the parenthesees is turned off, then proceed normally
                    {
                        if (m_lastNum == null || m_wait)//If this is the first number they are entering
                        {
                            if (m_lastNum != null && !m_operation.Equals("+") && !m_lastHitEquals && !m_wait)
                                solve();
                            m_operation = "+";
                            m_lastNum = "" + formatInput(m_input);
                            m_sign = "+";
                            m_decimal = false;
                            m_wait = true;
                        }
                        else //If this is the second or higher number they are entering, then update the results of the expression by solving
                        {
                            if(!m_wait)
                                solve();
                            m_operation = "+";
                            m_sign = "+";
                            m_wait = true;
                        }
                    }
                    else //In parentheses mode, the last input and operator is appeneded to the equation string
                    {
                        if ((!m_wait || (m_wait && !m_operation.Equals("+"))) && !m_input.Equals("."))
                        {
                            m_sign = "+";
                            m_operation = "+";
                            char[] c = { '+', '-', '*', '/' };
                            if (m_wait)
                            {
                                m_equation = m_equation.TrimEnd(c);
                                m_equation += "+";
                            }
                            else
                            {
                                m_equation += formatInput(m_input) + "+";
                            }
                            m_decimal = false;
                            m_wait = true;
                        }
                    }
                    m_lastHitEquals = false; break;
                case "subtract":
                    if (!m_openParen)
                    {
                        if (m_lastNum == null || m_wait)
                        {
                            if (m_lastNum != null && !m_operation.Equals("-") && !m_lastHitEquals && !m_wait)
                                solve();
                            m_operation = "-";
                            m_lastNum = "" + formatInput(m_input);
                            m_sign = "+";
                            m_decimal = false;
                            m_wait = true;
                        }
                        else
                        {
                            if (!m_wait)
                                solve();
                            m_operation = "-";
                            m_sign = "+";
                            m_wait = true;
                        }
                    }
                    else
                    {
                        if ((!m_wait || (m_wait && !m_operation.Equals("-"))) && !m_input.Equals("."))
                        {
                            m_sign = "+";
                            m_operation = "-";
                            char[] c = { '+', '-', '*', '/' };
                            if (m_wait)
                            {
                                m_equation = m_equation.TrimEnd(c);
                                m_equation += "-";
                            }
                            else
                            {
                                m_equation += formatInput(m_input) + "-";
                            }
                            m_decimal = false;
                            m_wait = true;
                        }
                    }
                    m_lastHitEquals = false; break;
                case "multiply":
                    if (!m_openParen)
                    {
                        if (m_lastNum == null || m_wait)
                        {
                            if (m_lastNum != null && !m_operation.Equals("*") && !m_lastHitEquals && !m_wait)
                                solve();
                            m_operation = "*";
                            m_lastNum = "" + formatInput(m_input);
                            m_sign = "+";
                            m_decimal = false;
                            m_wait = true;
                        }
                        else
                        {
                            if (!m_wait)
                                solve();
                            m_operation = "*";
                            m_sign = "+";
                            m_wait = true;
                        }
                    }
                    else
                    {
                        if ((!m_wait || (m_wait && !m_operation.Equals("*"))) && !m_input.Equals(".") && !m_wait)
                        {
                            m_sign = "+";
                            m_operation = "*";
                            char[] c = { '+', '-', '*', '/' };
                            if (m_wait)
                            {
                                m_equation = m_equation.TrimEnd(c);
                                m_equation += "*";
                            }
                            else
                            {
                                m_equation += formatInput(m_input) + "*";
                            }
                            m_decimal = false;
                            m_wait = true;
                        }
                    }
                    m_lastHitEquals = false; break;
                case "divide":
                    if (!m_openParen)
                    {
                        if (m_lastNum == null || m_wait)
                        {
                            if (m_lastNum != null && !m_operation.Equals("/") && !m_lastHitEquals)
                                solve();
                            m_operation = "/";
                            m_lastNum = "" + formatInput(m_input);
                            m_sign = "+";
                            m_decimal = false;
                            m_wait = true;
                        }
                        else
                        {
                            if (!m_wait)
                                solve();
                            m_operation = "/";
                            m_sign = "+";
                            m_wait = true;
                        }
                    }
                    else
                    {
                        if ((!m_wait || (m_wait && !m_operation.Equals("/"))) && !m_input.Equals("."))
                        {
                            m_sign = "+";
                            m_decimal = false;
                            m_operation = "/";
                            char[] c = { '+', '-', '*', '/' };
                            if (m_wait)
                            {
                                m_equation = m_equation.TrimEnd(c);
                                m_equation += "/";
                            }
                            else
                            {
                                m_equation += formatInput(m_input) + "/";
                            }
                            m_decimal = false;
                            m_wait = true;
                        }
                    }
                    m_lastHitEquals = false; break;
            }
        } 
        public static double getDisplay()
        {
            return Convert.ToDouble(formatInput(m_input));
        }

        //Solve the currently stored expression
        public static bool solve()
        {
            bool canSolve = true;
            if (!m_openParen)
            {
                //For normal solving
                if (m_operation != null)
                {
                    //Clean up
                    if (m_input.Equals(""))
                        m_input = "0";
                    if (m_lastNum == null || m_lastNum.Equals(""))
                    {
                        m_lastNum = "0.0";
                    }
                    if (!m_wait)
                    {
                        m_lastInput = "" + formatInput(m_input);
                    }
                    //We take the previous number value and perform an operation with the current value
                    String answer = "";
                    switch (m_operation)
                    {
                        case "+":
                            answer = "" + Convert.ToString(Convert.ToDouble(m_lastNum) + Convert.ToDouble(m_lastInput));
                            break;
                        case "-":
                            answer = "" + Convert.ToString(Convert.ToDouble(m_lastNum) - Convert.ToDouble(m_lastInput));
                            break;
                        case "*":
                            answer = "" + Convert.ToString(Convert.ToDouble(m_lastNum) * Convert.ToDouble(m_lastInput));
                            break;
                        case "/":
                            if (!formatInput(m_lastInput).Equals("0.0"))
                            {
                                answer = "" + Convert.ToString(Convert.ToDouble(m_lastNum) / Convert.ToDouble(m_lastInput));
                            } break;
                    }

                    if (answer.Equals(""))
                    {
                        //This is how we know a faulty operation has occured...
                        canSolve = false;
                    }
                    else
                    {
                        m_lastNum = answer;
                        m_input = answer;
                        m_sign = "+";
                        m_decimal = false;
                        m_lastHitEquals = true;
                        m_wait = true;
                        canSolve = true;
                    }
                }
                return canSolve;
            }
            else
            {
                //Order of operations solving
                if (!m_equation.Equals(""))
                {
                    m_openParen = false;
                    m_closeParen = true;
                    if (!m_wait)
                    {
                        m_equation += "" + formatInput(m_input);
                    }
                    else
                    {
                        m_equation = m_equation.Remove(m_equation.Length - 1, 1);
                    }
                    m_input = solveString(m_equation);
                    m_operation = null;
                    m_equation = "";
                }
                else
                {
                    //Just turn it off if no numbers are available to work with
                    m_openParen = false;
                    m_closeParen = true;
                }
                m_wait = true;
                m_lastHitEquals = true;
                return canSolve;
            }
        }

        //Perform a trig function on the current input
        public static void trig_fcns(String n)
        {
            switch (n)
            {
                case "sin":
                    if (m_useRadians)
                    {
                        m_input = "" + Math.Sin(Convert.ToDouble(m_input));
                        m_wait = false;
                    }
                    else
                    {
                        m_input = "" + Math.Sin(Convert.ToDouble(m_input) * Math.PI / 180);
                        m_wait = false;
                    } break;
                case "cos":
                    if (m_useRadians)
                    {
                        m_input = "" + Math.Cos(Convert.ToDouble(m_input));
                        m_wait = false;
                    }
                    else
                    {
                        m_input = "" + Math.Cos(Convert.ToDouble(m_input) * Math.PI / 180);
                        m_wait = false;
                    } break;
                case "tan":
                    if (m_useRadians)
                    {
                        m_input = "" + Math.Tan(Convert.ToDouble(m_input));
                        m_wait = false;
                    }
                    else
                    {
                        m_input = "" + Math.Tan(Convert.ToDouble(m_input) * Math.PI / 180);
                        m_wait = false;
                    } break;
                case "pi":
                    m_input = "" + Math.PI;
                    m_wait = false; break;
            }
        }

        //Handles decimal square roots, decimal buttons, percents, inverse, backspaces, and sign switching
        public static bool other_fcns(String n) 
        {
            bool success = false;
            switch (n)
            {
                case "sqrt":
                    if (!m_sign.Equals("-"))
                    {
                        m_input = Convert.ToString(Math.Sqrt(Convert.ToDouble(m_input)));
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    break;
                case "percent":
                    if (m_lastNum != null && !m_openParen)
                    {
                        switch (m_operation)
                        {
                            case "+":
                                m_input = Convert.ToString(Convert.ToDouble(m_lastNum) * (Convert.ToDouble(m_input) / 100));
                                break;
                            case "-":
                                m_input = Convert.ToString(Convert.ToDouble(m_lastNum) * (Convert.ToDouble(m_input) / 100));
                                break;
                            case "*":
                                m_input = Convert.ToString(Convert.ToDouble(m_lastNum) * (Convert.ToDouble(m_input) / 100));
                                break;
                            case "/":
                                m_input = Convert.ToString(Convert.ToDouble(m_lastNum) * (Convert.ToDouble(m_input) / 100));
                                break;
                        }
                        success = true;
                    }
                    else
                    {

                        success = false;
                    }
                    break;
                case "inverse":
                    if (Convert.ToDouble(m_input) != 0)
                    {
                        m_input = Convert.ToString(1 / Convert.ToDouble(m_input));
                        if (Math.Abs(Convert.ToDouble(m_input)) - (Math.Round(Convert.ToDouble(m_input))) < .000000001)
                        {
                            m_input = Convert.ToString(Math.Round(Convert.ToDouble(m_input)));
                        }
                        success = true;
                    }
                    else
                    {
                        //Can't inverse Zero.
                        success = false;
                    }
                    break;
                case "backspace":
                    if (!m_input.Equals(".") && !m_wait)
                    {
                        if (m_decimal)
                        {
                            m_input = m_input.Remove(m_input.Length - 1);
                            if (m_input.IndexOf(".") < 0)
                            {
                                m_input += ".";
                                m_decimal = false;
                            }
                        }
                        else
                        {
                            m_input = m_input.Remove(m_input.IndexOf(".") - 1, 1);
                        }
                        if (m_input.Equals(".") || m_input.Equals("-."))
                        {
                            m_input = ".";
                            m_sign = "+";
                        }
                        success = true;
                    }
                    else
                    {
                        //Nothing to to backspace
                        success = false;
                    }
                    break;
                case "open_paren":
                    if (!m_openParen)
                    {
                        clearAll();
                        m_openParen = true;
                        m_closeParen = false;
                        m_lastNum = null;
                        m_lastInput = null;
                        m_sign = "+";
                        m_decimal = false;
                        m_equation = "";
                        m_wait = true;
                        m_input = ".";
                        m_operation = null;
                        success = true;
                    }
                    else
                    {
                        //Parentheses already opened
                        success = false;
                    }
                    break;
                case "close_paren":
                    if (!m_closeParen)
                    {
                        if (!m_equation.Equals(""))
                        {
                            m_openParen = false;
                            m_closeParen = true;
                            if (!m_wait)
                            {
                                m_equation += "" + formatInput(m_input);
                            }
                            else
                            {
                                m_equation = m_equation.Remove(m_equation.Length - 1, 1);
                            }
                            m_input = solveString(m_equation);
                            m_operation = null;
                            m_equation = "";
                        }
                        else
                        {
                            //Just turn it off if no numbers are available to work with
                            m_openParen = false;
                            m_closeParen = true;
                        }
                        m_wait = true;
                        m_lastHitEquals = true;
                        success = true;
                    }
                    else
                    {
                        //You must open the parentheses first
                        success = false;
                    }
                    break;
                case "switchSign":
                    if (!m_wait && !m_input.Equals("."))
                    {
                        if (m_sign.Equals("+") && !m_input.Equals(""))
                        {
                            m_sign = "-";
                            m_input = "-" + m_input;
                        }
                        else
                        {
                            if (m_sign.Equals("-"))
                            {
                                m_input = m_input.Remove(0, 1);
                            }
                            m_sign = "+";
                        }
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    break;
                case "decimal":
                    if (!m_decimal)
                    {
                        m_decimal = true;
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    break;
            }
            return success;
        }

        //Handles memory storage functions
        public static void memory(String n)
        {
            switch (n)
            {
                case "memClear":
                    m_memory = null; break;
                case "memRecall":
                    if (m_memory != null)
                    {
                        m_input = m_memory;
                    }
                    else
                    {
                        //Nothing stored in Memory;
                    } break;
                case "memStore":
                    m_memory = m_input; break;
                case "memAdd":
                    if (m_memory != null)
                    {
                        m_memory = Convert.ToString(Convert.ToDouble(m_memory) + Convert.ToDouble(m_input));

                    }
                    else
                    {
                        //Nothing stored in Memory
                    }
                    break;
            }
        }

        //The built in version didn't work right for some reason, so I made my own
        public static int LastIndexOfAny(String s, char[] c, int start, int maxcount)
        {
            int lastPos = 0;
            int count = 0;
            foreach (char j in c)
            {
                count = 0;
                for (int i = start; i < s.Length && count < maxcount; i++)
                {
                    if (s.Substring(i, 1).Equals(Convert.ToString(j)) && i > lastPos)
                    {
                        lastPos = i;
                    }
                    count++;
                }
            }
            return lastPos;
        }

        //Get or set the current input
        public static String input
        {
            get
            {
                return m_input;
            }
            set
            {
                m_input = value;
            }

        }

        //Getter
        public static String equation
        {
            get
            {
                return m_equation;
            }
        }

        //This function parses a string of numbers and operations and treats it as a single level of order of operations (no nested parentheses)
        //-It essentially just performs the multiplication/divided operations on the first pass condensing the string as it goes, and on the second pass it does addition/subtraction
        private static String solveString(String equation)
        {
            Stack<double> total = new Stack<double>();
            char[] symbol = { '+', '-', '*', '/' };
            char[] plusOrMinus = { '+', '-' };
            char[] timesOrDivide = { '*', '/' };
            char[] charEquation = equation.ToCharArray();
            for (int i = 0; i < charEquation.Length; i++)
            {
                if (equation.IndexOfAny(symbol, i, 1) > -1 && charEquation.GetValue(i + 1).Equals('-'))
                {
                    charEquation.SetValue('!', i + 1);
                }
            }
            equation = "";
            foreach (char i in charEquation)
            {
                equation += Convert.ToString(i);
            }
            equation = "0+" + equation + "+0";
            int num1_Start = 0;
            int num1_End = 0;
            int num2_Start = 0;
            int num2_End = 0;
            String num1_str = "";
            String num2_str = "";
            String answer = "";
            double num1 = 0;
            double num2 = 0;
            int pos = 0; //Position of last + or - operator before current * or / operator
            double numBuffer = 0;

            while (equation.IndexOfAny(timesOrDivide) > -1)
            {
                pos = LastIndexOfAny(equation, plusOrMinus, 0, equation.IndexOfAny(timesOrDivide));
                num1_Start = pos + 1;
                num1_End = equation.IndexOfAny(timesOrDivide) - 1;
                num2_Start = equation.IndexOfAny(timesOrDivide) + 1;
                num2_End = equation.IndexOfAny(symbol, equation.IndexOfAny(timesOrDivide) + 1) - 1;

                num1_str = equation.Substring(num1_Start, num1_End - num1_Start + 1);
                num2_str = equation.Substring(num2_Start, num2_End - num2_Start + 1);
                if (num1_str.IndexOf("!") > -1)
                {
                    num1_str = num1_str.Replace("!", "-");
                }
                if (num2_str.IndexOf("!") > -1)
                {
                    num2_str = num2_str.Replace("!", "-");
                }
                num1 = Convert.ToDouble(num1_str);
                num2 = Convert.ToDouble(num2_str);

                if (equation.Substring(equation.IndexOfAny(timesOrDivide), 1) == "*")
                {
                    answer = Convert.ToString(num1 * num2);
                }
                else
                {
                    answer = Convert.ToString(num1 / num2);
                }
                if (answer.IndexOf("-") > -1)
                {
                    answer = answer.Replace("-", "!");
                }
                if (answer.IndexOf("-") > -1)
                {
                    answer = answer.Replace("-", "!");
                }
                equation = equation.Substring(0, num1_Start) + answer + equation.Substring(num2_End + 1, equation.Length - num2_End - 1);
            }
            equation = equation.Insert(0, "+");
            while (equation.IndexOfAny(plusOrMinus) > -1)
            {
                if (equation.Substring(1, 1).Equals("!"))
                {
                    if (equation.Substring(0, 1).Equals("+"))
                    {
                        total.Push(Convert.ToDouble("-" + equation.Substring(2, equation.IndexOfAny(plusOrMinus, 1) - 2)));
                        equation = equation.Remove(0, equation.IndexOfAny(plusOrMinus, 1));
                    }
                    else
                    {
                        total.Push(Convert.ToDouble(equation.Substring(2, equation.IndexOfAny(plusOrMinus, 2) - 2)));
                        equation = equation.Remove(0, equation.IndexOfAny(plusOrMinus, 1));
                    }
                }
                else if (equation.Length > 2)
                {
                    if (equation.Substring(0, 1).Equals("+"))
                    {
                        total.Push(Convert.ToDouble(equation.Substring(1, equation.IndexOfAny(plusOrMinus, 1) - 1)));
                        equation = equation.Remove(0, equation.IndexOfAny(plusOrMinus, 1));
                    }
                    else
                    {
                        total.Push(Convert.ToDouble("-" + equation.Substring(1, equation.IndexOfAny(plusOrMinus, 1) - 1)));
                        equation = equation.Remove(0, equation.IndexOfAny(plusOrMinus, 1));
                    }
                }
                else
                {
                    equation = "";
                }

            }
            while (total.Count > 0)
            {
                numBuffer += total.Pop();
            }
            return Convert.ToString(numBuffer);
        } 
        
        //Test to see if the engine is waiting for the user to enter a number (Test if no input)
        private static bool isEmpty()
        {
            if ((m_input.Equals(".")) || m_wait)
                return true;
            else
                return false;
        }

        //Make sure the calculator is indeed cleared (a bit hacky but it's useful for test cases)
        public static bool assureCleared()
        {
            if (m_equation == "" && m_input == "." && m_lastNum == null &&  m_lastInput == null && m_operation == null && m_sign == "+" && m_sign == "+" && !m_wait && !m_openParen && m_closeParen && !m_decimal)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
