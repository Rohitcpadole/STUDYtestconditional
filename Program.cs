using System;


namespace testconditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.C Program to Check Whether a Number is Even or Odd");
            Console.WriteLine("2.C Program to Check Whether a Character is Vowel or Consonant");
            Console.WriteLine("3.C Program to Find the Largest Number Among Three Numbers");
            Console.WriteLine("4.C Program to Check Leap Year");
            Console.WriteLine("5.C Program to Check Whether a Number is Positive or Negative");
            Console.WriteLine("6.C Program to Check Whether a Character is an Alphabet or not");
            Console.WriteLine("7.C Program to Calculate the Sum of Natural Numbers");
            Console.WriteLine("8.C Program to Find Factorial of a Number");
            Console.WriteLine("9.C Program to Generate Multiplication Table");
            Console.WriteLine("10.C Program to Display Fibonacci Sequence");
            Console.WriteLine("11.C Program to Find GCD of two Numbers");
            Console.WriteLine("12.C Program to Find LCM of two Numbers");
            Console.WriteLine("13.C Program to Check Prime Number");
            Console.WriteLine("14.C Program to Print all Prime Numbers between 1 to N");
            Console.WriteLine("15.C Program to Check Armstrong Number");
            Console.WriteLine("16.C Program to Check Whether a Number is Palindrome or Not");
            Console.WriteLine("17.C Program to Check Whether a Number is Perfect Number");
            Console.WriteLine("18.C Program to Check Whether a Number is Strong Number");
            Console.WriteLine("19.C Program to Check Whether a Number is a Happy Number");


            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter a number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("The number is even");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter a character");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        Console.WriteLine("The character is a vowel");
                    }
                    else
                    {
                        Console.WriteLine("The character is a consonant");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter three numbers");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine("The largest number is " + num1);
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine("The largest number is " + num2);
                    }
                    else
                    {
                        Console.WriteLine("The largest number is " + num3);
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter a year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("The year is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("The year is not a leap year");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter a number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        Console.WriteLine("The number is positive");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("The number is negative");
                    }
                    else
                    {
                        Console.WriteLine("The number is zero");
                    }
                    break;
                case 6:
                    Console.WriteLine("Enter a character");
                    char character = Convert.ToChar(Console.ReadLine());
                    if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
                    {
                        Console.WriteLine("The character is an alphabet");
                    }
                    else
                    {
                        Console.WriteLine("The character is not an alphabet");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
