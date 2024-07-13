using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:"); // ใส่ข้อความเข้าไป
        string input = Console.ReadLine(); // รับ inputและเก็บในตัวแปร input

        if (IsPalindrome(input)) // เรียกใช้ฟังก์ชัน IsPalindrome และตรวจสอบว่าข้อความที่รับเข้ามาเป็น palindrome ป่าว
        {
            Console.WriteLine("The input string is a palindrome."); // ถ้าเป็น palindrome ให้พิมพ์ข้อความนี้
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome."); // ถ้าไม่ใช่ palindrome ให้พิมพ์ข้อความนี้
        }
    }

    static bool IsPalindrome(string str)
    {
        int left = 0; // กำหนดตำแหน่งเริ่มต้นของตัวอักษรทางด้านซ้าย
        int right = str.Length - 1; // กำหนดตำแหน่งเริ่มต้นของตัวอักษรทางด้านขวา

        while (left < right)
        {
            // ข้ามตัวอักษรที่ไม่ใช่ตัวอักษรหรือตัวเลขจากทางด้านซ้าย
            while (left < right && !char.IsLetterOrDigit(str[left])) 
            {
                left++;
            }
            // ข้ามตัวอักษรที่ไม่ใช่ตัวอักษรหรือตัวเลขจากทางด้านขวา
            while (left < right && !char.IsLetterOrDigit(str[right]))
            {
                right--;
            }

            // เปรียบเทียบตัวอักษรหลังจากแปลงเป็นตัวพิมพ์เล็กแล้ว
            if (char.ToLower(str[left]) != char.ToLower(str[right]))
            {
                return false; // ถ้าตัวอักษรไม่ตรงกัน ให้คืนค่า false
            }

            left++; // ขยับตำแหน่งทางด้านซ้ายไปข้างหน้า
            right--; // ขยับตำแหน่งทางด้านขวาไปข้างหลัง
        }

        return true; // ถ้าตัวอักษรทั้งหมดตรงกัน ให้คืนค่า true
    }
}
