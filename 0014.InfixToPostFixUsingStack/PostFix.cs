using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014.InfixToPostFixUsingStack
{
    internal class PostFix
    {
        public string InfixToPostFix(string inFix)
        {
            string postFix = "";
            StackChar stackArray = new StackChar(20);

            char next, symbol;

            for (int i = 0; i < inFix.Length; i++)
            {
                symbol = inFix[i];

                if (symbol == ' ' || symbol == '\t') //ignore blanks and tabs
                    continue;

                switch (symbol)
                {
                    case '(':
                        stackArray.Push(symbol);
                        break;
                    case ')':
                        while ((next = stackArray.Pop()) != '(')
                            postFix = postFix + next;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                        while(!stackArray.IsEmpty() && Precedence(stackArray.Peek()) >= Precedence(symbol))
                            postFix = postFix + stackArray.Pop();
                        stackArray.Push(symbol);
                        break;
                    default: //operand
                        postFix = postFix + symbol;
                        break;
                }
            }

            while(!stackArray.IsEmpty())
                postFix = postFix + stackArray.Pop();
            return postFix;
        }

        public int Precedence(char symbol)
        {
            switch (symbol)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public long EvaluatePostFix(string postFix)
        {
            StackInt stackInt = new StackInt();

            int x, y;
            for (int i = 0; i < postFix.Length; i++)
            {
                if (Char.IsDigit(postFix[i]))
                    stackInt.Push(Convert.ToInt32(Char.GetNumericValue(postFix[i])));
                else
                {
                    x = stackInt.Pop();
                    y = stackInt.Pop();
                    switch (postFix[i])
                    {
                        case '+':
                            stackInt.Push(y + x);
                            break;
                        case '-':
                            stackInt.Push(y - x);
                            break;
                        case '*':
                            stackInt.Push(y * x);
                            break;
                        case '/':
                            stackInt.Push(y / x);
                            break;
                        case '%':
                            stackInt.Push(y % x);
                            break;
                        case '^':
                            stackInt.Push(Power(y, x));
                            break;                        
                    }
                }
            }
            return stackInt.Pop();
        }

        public int Power(int b, int a)
        {
            int i, x = 1;
            for (i = 1; i <= a; i++)
                x = x * b;
            return x;
        }
    }
}
