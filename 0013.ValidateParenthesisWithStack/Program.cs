// See https://aka.ms/new-console-template for more information
using _0013.ValidateParenthesisWithStack;

ParenthesisStack stack = new ParenthesisStack();

string expression;

Console.Write("Enter an expression with Parenthesis: ");
expression =  Console.ReadLine();

if (stack.IsValid(expression))
    Console.WriteLine("Valid Expression");
else
    Console.WriteLine("Invalid Expression");

