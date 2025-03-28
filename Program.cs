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
            Console.WriteLine("Thanks For Help ");


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
                case 7:
                    Console.WriteLine("Enter a number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("The sum of natural numbers is " + sum);
                    break;
                case 8:
                    Console.WriteLine("Enter a number");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int fact = 1;
                    for (int i = 1; i <= n1; i++)
                    {
                        fact *= i;
                    }
                    Console.WriteLine("The factorial of the number is " + fact);
                    break;
                case 9:
                    Console.WriteLine("Enter a number");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(n2 + " * " + i + " = " + n2 * i);
                    }
                    break;
                case 10:
                    Console.WriteLine("Enter the number of terms");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    int a = 0, b = 1, c;
                    Console.WriteLine("Fibonacci series:");
                    for (int i = 0; i < n3; i++)
                    {
                        Console.WriteLine(a);
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    break;
                case 11:
                    Console.WriteLine("Enter two numbers");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    while (num4 != num5)
                    {
                        if (num4 > num5)
                        {
                            num4 -= num5;
                        }
                        else
                        {
                            num5 -= num4;
                        }
                    }
                    Console.WriteLine("The GCD of the numbers is " + num4);
                    break;
                case 12:
                    Console.WriteLine("Enter two numbers");
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    int max = Math.Max(num6, num7);
                    int lcm = max;
                    while (true)
                    {
                        if (lcm % num6 == 0 && lcm % num7 == 0)
                        {
                            Console.WriteLine("The LCM of the numbers is " + lcm);
                            break;
                        }
                        lcm += max;
                    }
                    break;
                case 13:
                    Console.WriteLine("Enter a number");
                    int num8 = Convert.ToInt32(Console.ReadLine());
                    int count = 0;
                    for (int i = 1; i <= num8; i++)
                    {
                        if (num8 % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine("The number is a prime number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a prime number");
                    }
                    break;
                case 14:
                    Console.WriteLine("Enter a number");
                    int num9 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i <= num9; i++)
                    {
                        int count1 = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                count1++;
                            }
                        }
                        if (count1 == 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 15:
                    Console.WriteLine("Enter a number");
                    int num10 = Convert.ToInt32(Console.ReadLine());
                    int sum1 = 0;
                    int temp = num10;
                    while (num10 > 0)
                    {
                        int rem = num10 % 10;
                        sum1 += rem * rem * rem;
                        num10 /= 10;
                    }
                    if (sum1 == temp)
                    {
                        Console.WriteLine("The number is an Armstrong number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not an Armstrong number");
                    }
                    break;
                case 16:
                    Console.WriteLine("Enter a number");
                    int num11 = Convert.ToInt32(Console.ReadLine());
                    int sum2 = 0;
                    int temp1 = num11;
                    while (num11 > 0)
                    {
                        int rem = num11 % 10;
                        sum2 = sum2 * 10 + rem;
                        num11 /= 10;
                    }
                    if (sum2 == temp1)
                    {
                        Console.WriteLine("The number is a palindrome number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a palindrome number");
                    }
                    break;
                case 17:
                    Console.WriteLine("Enter a number");
                    int num12 = Convert.ToInt32(Console.ReadLine());
                    int sum3 = 0;
                    for (int i = 1; i < num12; i++)
                    {
                        if (num12 % i == 0)
                        {
                            sum3 += i;
                        }
                    }
                    if (sum3 == num12)
                    {
                        Console.WriteLine("The number is a perfect number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a perfect number");
                    }
                    break;
                case 18:
                    Console.WriteLine("Enter a number");
                    int num13 = Convert.ToInt32(Console.ReadLine());
                    int sum4 = 0;
                    int temp2 = num13;
                    while (num13 > 0)
                    {
                        int rem = num13 % 10;
                        int fact1 = 1;
                        for (int i = 1; i <= rem; i++)
                        {
                            fact1 *= i;
                        }
                        sum4 += fact1;
                        num13 /= 10;
                    }
                    if (sum4 == temp2)
                    {
                        Console.WriteLine("The number is a strong number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a strong number");
                    }
                    break;
                case 19:
                    Console.WriteLine("Enter a number");
                    int num14 = Convert.ToInt32(Console.ReadLine());
                    int sum5 = 0;
                    int temp3 = num14;
                    while (num14 > 0)
                    {
                        int rem = num14 % 10;
                        sum5 += rem * rem;
                        num14 /= 10;
                    }
                    if (sum5 == 1)
                    {
                        Console.WriteLine("The number is a happy number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a happy number");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
