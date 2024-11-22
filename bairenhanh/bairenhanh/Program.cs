using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap mot so nguyen khong am co toi da 3 chu so:");

        string input = Console.ReadLine();

        if (IsValidNumber(input))
        {
            int number = int.Parse(input);
            string result = ConvertNumberToWords(number);
            Console.WriteLine($"So ban da nhap la: {result}");
        }
        else
        {
            Console.WriteLine("So ban nhap khong hop le. Vui long nhap mot so nguyen khong am co toi da 3 chu so.");
        }
    }

    static bool IsValidNumber(string input)
    {
        
        if (int.TryParse(input, out int number))
        {
            return number >= 0 && number <= 999; 
        }
        return false;
    }

    static string ConvertNumberToWords(int number)
    {
        if (number == 0) return "zero";

        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string words = "";

        if (number >= 100)
        {
            int hundreds = number / 100;
            words += units[hundreds] + " hundred";
            number %= 100;
            if (number > 0)
            {
                words += " and ";
            }
        }

        if (number >= 20)
        {
            int t = number / 10;
            words += tens[t];
            number %= 10;
            if (number > 0)
            {
                words += " ";
            }
        }
        else if (number >= 10)
        {
            words += teens[number - 10];
            number = 0;
        }

        if (number > 0)
        {
            words += units[number];
        }

        return words;
    }
}
