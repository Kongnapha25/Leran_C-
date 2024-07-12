// using System;

// class TemperatureConverter
// {
//     static void Main()
//     {
//         Console.Write("ใส่อุณหภูมิ: ");
//         double temperature = Convert.ToDouble(Console.ReadLine());

//         Console.Write("ใส่หน่วย (C/F/K): ");
//         char unit = Char.ToUpper(Console.ReadLine()[0]);

//         switch (unit)
//         {
//             case 'C':
//                 ConvertFromCelsius(temperature);
//                 break;
//             case 'F':
//                 ConvertFromFahrenheit(temperature);
//                 break;
//             case 'K':
//                 ConvertFromKelvin(temperature);
//                 break;
//             default:
//                 Console.WriteLine("หน่วยที่ใส่ไม่ถูกต้อง");
//                 break;
//         }
//     }

//     static void ConvertFromCelsius(double celsius)
//     {
//         double fahrenheit = (celsius * 9 / 5) + 32;
//         double kelvin = celsius + 273.15;
//         Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");
//     }

//     static void ConvertFromFahrenheit(double fahrenheit)
//     {
//         double celsius = (fahrenheit - 32) * 5 / 9;
//         double kelvin = celsius + 273.15;
//         Console.WriteLine($"{fahrenheit}°F = {celsius}°C = {kelvin}K");
//     }

//     static void ConvertFromKelvin(double kelvin)
//     {
//         double celsius = kelvin - 273.15;
//         double fahrenheit = (celsius * 9 / 5) + 32;
//         Console.WriteLine($"{kelvin}K = {celsius}°C = {fahrenheit}°F");
//     }
// }
