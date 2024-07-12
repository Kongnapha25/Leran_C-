// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("ใส่ค่า n: ");
//         int n = int.Parse(Console.ReadLine());

//         List<int> primes = GetPrimes(n);
//         List<Tuple<int, int>> twinPrimes = GetTwinPrimes(primes);

//         Console.WriteLine("จำนวนเฉพาะคู่แฝดทั้งหมด:");
//         foreach (var twinPrime in twinPrimes)
//         {
//             Console.WriteLine($"({twinPrime.Item1}, {twinPrime.Item2})");
//         }
//         Console.WriteLine($"จำนวนคู่ทั้งหมด: {twinPrimes.Count}");
//     }

//     static List<int> GetPrimes(int n)
//     {
//         List<int> primes = new List<int>();
//         for (int i = 2; i <= n; i++)
//         {
//             if (IsPrime(i))
//             {
//                 primes.Add(i);
//             }
//         }
//         return primes;
//     }

//     static bool IsPrime(int number)
//     {
//         if (number <= 1) return false;
//         if (number == 2) return true;
//         if (number % 2 == 0) return false;

//         for (int i = 3; i <= Math.Sqrt(number); i += 2)
//         {
//             if (number % i == 0) return false;
//         }
//         return true;
//     }

//     static List<Tuple<int, int>> GetTwinPrimes(List<int> primes)
//     {
//         List<Tuple<int, int>> twinPrimes = new List<Tuple<int, int>>();
//         for (int i = 0; i < primes.Count - 1; i++)
//         {
//             if (primes[i + 1] - primes[i] == 2)
//             {
//                 twinPrimes.Add(Tuple.Create(primes[i], primes[i + 1]));
//             }
//         }
//         return twinPrimes;
//     }
// }
