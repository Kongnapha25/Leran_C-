// using System;
// using System.Data;

// class Program
// {
//     static void Main()
//     {
//         string expression = "3 + (2 * 4) - (1 / 5)";
//         double result = EvaluateExpression(expression);
//         Console.WriteLine($"Result: {result}");
//     }

//     public static double EvaluateExpression(string expression)
//     {
//         DataTable table = new DataTable();

//         object result = table.Compute(expression, null);

//         return Convert.ToDouble(result);
//     }
// }
