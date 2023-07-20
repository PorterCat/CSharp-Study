using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public static class Equation
    {
        private static string _text = String.Empty;
        private static Dictionary<char, int> _priorites = new Dictionary<char, int>()
        {
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
            {'(', 3},
            {')', 3},
        };


        private static string Text
        {
            get { return _text; }
            set
            {
                int countOpenedBracket = 0, countClosedBracket = 0;
                foreach(char c in value)
                {
                    if(c == '(')
                    {
                        countOpenedBracket++;
                    }
                    if (c == ')')
                    {
                        countClosedBracket++;
                    }
                }
                if(countOpenedBracket != countClosedBracket)
                {
                    throw new Exception("Error");
                }
                _text = value;
            }
        }

        public static decimal EnOperator(decimal a, decimal b, char enOperator)
        {
            switch (enOperator)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return 0;

            }
        }

        public static decimal Solve(string text)
        {
            Text = text;
            text = Text;


            var num = new Stack<string>();
            var operation = new Stack<char>();

            string lineNum = String.Empty;
            /*int i = 0;
            while (( num.Count != 2 || operation.Count != 1 ) && i < text.Length)
            {
                if (_priorites.ContainsKey(text[i])) // Это опреатор
                {
                    operation.Push(text[i]);
                    if (lineNum != string.Empty)
                    {
                        num.Push(lineNum);
                        lineNum = string.Empty;
                    }

                }
                else // Это цифра
                {
                    lineNum += text[i];
                }
                i++;
            }
            if(lineNum != string.Empty)
            {
                num.Push(lineNum);
                lineNum = string.Empty;
            }*/

            int previousPriority = 0, newPriority = 0;
            decimal a = 0, b = 0;

            for(int i = 0; i < text.Length; i++)
            {
                if (_priorites.ContainsKey(text[i])) //Мы встретили опреатор И у нас есть незаснесенное число
                {
                    if(lineNum != string.Empty)
                    {
                        num.Push(lineNum);
                        lineNum = string.Empty;
                    }

                    if (num.Count >= 2 && operation.Count >= 1) // уже есть оператор для сравнения и пара чисел для операций
                    {
                        //проверяем приоритет
                        _priorites.TryGetValue(operation.Peek(), out previousPriority);
                        _priorites.TryGetValue(Text[i], out newPriority);
                        if(newPriority <= previousPriority)
                        {
                            b = decimal.Parse(num.Peek());
                            num.Pop();
                            a = decimal.Parse(num.Peek());
                            num.Pop();

                            num.Push(EnOperator(a, b, operation.Peek()).ToString());
                            operation.Pop();
                            operation.Push(text[i]);
                        }
                        else
                        {
                            operation.Push(text[i]);
                        }
                    }
                    else
                    {
                        operation.Push(text[i]);
                    }
                }
                else
                {
                    if (_priorites.ContainsKey(text[i])) // Это опреатор
                    {
                        operation.Push(text[i]);
                    }
                    else // Это цифра
                    {
                        lineNum += text[i];
                    }
                }
            }

            num.Push(lineNum);

            while(operation.Count > 0) 
            {
                b = decimal.Parse(num.Peek());
                num.Pop();
                a = decimal.Parse(num.Peek());
                num.Pop();
                num.Push(EnOperator(a, b, operation.Peek()).ToString());

                operation.Pop();
            }

            return decimal.Parse(num.Peek());
        }
    }
}