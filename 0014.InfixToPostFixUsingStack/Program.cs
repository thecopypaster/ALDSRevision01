// See https://aka.ms/new-console-template for more information
using _0014.InfixToPostFixUsingStack;

PostFix fix = new PostFix();
string inFix;

Console.Write("Enter infix expression: ");
inFix = Console.ReadLine();

string postFix = fix.InfixToPostFix(inFix);

Console.WriteLine("PostFix expression is: " + postFix);
Console.WriteLine("Value of expression is: " + fix.EvaluatePostFix(postFix));

