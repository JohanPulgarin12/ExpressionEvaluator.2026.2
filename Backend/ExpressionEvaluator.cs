using System.Globalization;
using System.Text;

namespace Backend;

public static class ExpressionEvaluator
{
    private static readonly char[] _operators = { '+', '-', '*', '/', '^', '(', ')' };

    public static double Evaluate(string infix)
    {
        if (string.IsNullOrWhiteSpace(infix))
            throw new Exception("Expression is empty.");

        return EvaluatePostfix(ToPostfix(Tokenize(infix)));
    }

    private static List<string> Tokenize(string infix)
    {
        var tokens = new List<string>();
        var number = new StringBuilder();

        void FlushNumber()
        {
            if (number.Length > 0)
            {
                tokens.Add(number.ToString());
                number.Clear();
            }
        }

        for (int i = 0; i < infix.Length; i++)
        {
            var c = infix[i];

            if (char.IsWhiteSpace(c)) { FlushNumber(); continue; }

            if (char.IsDigit(c) || c == '.')
            {
                number.Append(c);
            }
            else if (IsOperator(c))
            {
                FlushNumber();

                bool unary = c == '-' &&
                             (tokens.Count == 0 || tokens[^1] == "(" ||
                              (IsOperatorToken(tokens[^1]) && tokens[^1] != ")"));

                if (unary)
                {
                    if (i + 1 < infix.Length && infix[i + 1] == '(')
                    {
                        tokens.Add("-1");
                        tokens.Add("*");
                    }
                    else
                    {
                        number.Append('-');
                    }
                }
                else
                {
                    tokens.Add(c.ToString());
                }
            }
            else
            {
                throw new Exception($"Invalid character: '{c}'.");
            }
        }
        FlushNumber();
        return tokens;
    }

    private static List<string> ToPostfix(List<string> tokens)
    {
        var postfix = new List<string>();
        var stack = new Stack<char>();

        foreach (var token in tokens)
        {
            if (!IsOperatorToken(token))
            {
                postfix.Add(token);
                continue;
            }

            var item = token[0];

            if (item == '(')
            {
                stack.Push(item);
            }
            else if (item == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                    postfix.Add(stack.Pop().ToString());

                if (stack.Count == 0)
                    throw new Exception("Parenthesis closing without opening.");

                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && PriorityInfix(item) <= PriorityStack(stack.Peek()))
                    postfix.Add(stack.Pop().ToString());

                stack.Push(item);
            }
        }

        while (stack.Count > 0)
        {
            var op = stack.Pop();
            if (op == '(')
                throw new Exception("Parenthesis opening without closing.");
            postfix.Add(op.ToString());
        }
        return postfix;
    }

    private static double EvaluatePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();

        foreach (var token in postfix)
        {
            if (IsOperatorToken(token))
            {
                if (stack.Count < 2)
                    throw new Exception("Missing operands in the expression.");

                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, token[0]));
            }
            else
            {
                if (!double.TryParse(token, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
                    throw new Exception($"Invalid number: \"{token}\".");
                stack.Push(value);
            }
        }

        if (stack.Count != 1)
            throw new Exception("Invalid expression.");

        return stack.Pop();
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

    private static bool IsOperator(char item) => _operators.Contains(item);

    private static bool IsOperatorToken(string token) => token.Length == 1 && IsOperator(token[0]);

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope2 == 0 ? throw new Exception("Cannot divide by zero.") : ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}