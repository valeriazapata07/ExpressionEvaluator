
using System.Globalization;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static List<string> Tokenize(string infix)
    {
        var tokens = new List<string>();
        var number = string.Empty;
        foreach (var item in infix)
        {
            if (item is >= '0' and <= '9' || item == '.')
            {
                number += item;
                continue;
            }
            if (number != string.Empty)
            {
                tokens.Add(number);
                number = string.Empty;
            }
            if (char.IsWhiteSpace(item))
            {
                continue;
            }
            if (!IsOperator(item))
            {
                throw new Exception("Invalid expression.");
            }
            if (item == '-' && (tokens.Count == 0 || tokens[^1] == "("))
            {
                tokens.Add("0");
            }
            tokens.Add(item.ToString());
        }
        if (number != string.Empty)
        {
            tokens.Add(number);
        }
        return tokens;
    }

    private static List<string> ToPostfix(string infix)
    {
        var postfix = new List<string>();
        var stack = new Stack<char>();
        foreach (var token in Tokenize(infix))
        {
            if (!IsOperator(token[0]))
            {
                postfix.Add(token);
                continue;
            }

            var item = token[0];
            if (item == ')')
            {
                if (stack.Count == 0)
                {
                    throw new Exception("Invalid expression.");
                }
                var ope = stack.Pop();
                while (ope != '(')
                {
                    postfix.Add(ope.ToString());
                    if (stack.Count == 0)
                    {
                        throw new Exception("Invalid expression.");
                    }
                    ope = stack.Pop();
                }
            }
            else
            {
                while (stack.Count > 0 && PriorityInfix(item) <= PriorityStack(stack.Peek()))
                {
                    postfix.Add(stack.Pop().ToString());
                }
                stack.Push(item);
            }
        }
        while (stack.Count > 0)
        {
            var ope = stack.Pop();
            if (ope == '(')
            {
                throw new Exception("Invalid expression.");
            }
            postfix.Add(ope.ToString());
        }
        return postfix;
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var item in postfix)
        {
            if (IsOperator(item[0]))
            {
                if (stack.Count < 2)
                {
                    throw new Exception("Invalid expression.");
                }
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item[0]));
            }
            else
            {
                stack.Push(double.Parse(item, CultureInfo.InvariantCulture));
            }
        }
        if (stack.Count != 1)
        {
            throw new Exception("Invalid expression.");
        }
        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}