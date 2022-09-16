using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013.ValidateParenthesisWithStack
{
    internal class ParenthesisStack
    {
        public bool IsValid(string expr)
        {
            StackA stackArray = new StackA();
            char ch;

            for(int i = 0; i < expr.Length; i++) 
            {
                if (expr[i] == '(' || expr[i] == '{' || expr[i] == '[') 
                    stackArray.Push(expr[i]);
                if(expr[i] == ')' || expr[i] == '}' || expr[i] == ']')
                    if (stackArray.IsEmpty())
                    {
                        Console.WriteLine("Right parenthesis are more than left paranthesis");
                        return false; ;
                    }
                    else
                    {
                        ch = stackArray.Pop();
                        if(!MatchParenthesis(ch, expr[i]))
                        {
                            Console.WriteLine("Mismatched parenthesis are: ");
                            Console.WriteLine(ch + " and " + expr[i]);
                            return false;
                        }
                    }
            }

            if (stackArray.IsEmpty())
            {
                Console.WriteLine("Balanced parenthesis");
                return true;
            }
            else
            {
                Console.WriteLine("Left parenthesis are more than right parenthesis");
                return false;
            }
        }

        private bool MatchParenthesis(char leftPar, char rightPar)
        {
            if(leftPar == '(' && rightPar == ')')
                return true;
            if (leftPar == '[' && rightPar == ']')
                return true;
            if (leftPar == '{' && rightPar == '}')
                return true;
            return false;
        }
    }
}
