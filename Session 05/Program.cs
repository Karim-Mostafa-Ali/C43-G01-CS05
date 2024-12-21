using System.Reflection;

namespace Session_05
{
    class MyClass
    {
        public int Value { get; set; }
    }

    internal class Program
    {
        static void PassByValue(int x)
        {
            x = 20;
        }
        static void PassByReference(ref int x)
        {
            x = 20;
        }
        static void PassByValue(MyClass obj)
        {
            obj.Value = 20; // Modifies the object's property
            obj = new MyClass { Value = 30 }; // Does not affect the original reference
        }
        static void PassByReference(ref MyClass obj)
        {
            obj.Value = 20;
            obj = new MyClass { Value = 30 }; // Changes the original reference
        }

        static void Calculate(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            Array.Sort(arr); // Sort the array in ascending order
            min = arr[0];    // The first element is the minimum
            max = arr[^1];   // The last element is the maximum
        }

        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
                throw new ArgumentOutOfRangeException("Position is out of range.");

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //Passing by Value: A copy of the variable is passed.Modifications inside the method do not affect the original variable. 
            //Passing by Reference: The actual variable is passed.Modifications inside the method affect the original variable.
            //int a = 10;
            //Console.WriteLine($"Before PassByValue: {a}");
            //PassByValue(a);
            //Console.WriteLine($"After PassByValue: {a}");

            //int b = 10;
            //Console.WriteLine($"Before PassByReference: {b}");
            //PassByReference(ref b);
            //Console.WriteLine($"After PassByReference: {b}");
            #endregion


            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //MyClass obj1 = new MyClass { Value = 10 };
            //Console.WriteLine($"Before PassByValue: {obj1.Value}");
            //PassByValue(obj1);
            //Console.WriteLine($"After PassByValue: {obj1.Value}");

            //MyClass obj2 = new MyClass { Value = 10 };
            //Console.WriteLine($"Before PassByReference: {obj2.Value}");
            //PassByReference(ref obj2);
            //Console.WriteLine($"After PassByReference: {obj2.Value}");
            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.WriteLine("Enter Two numbers:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int sub = 0;

            //Calculate(num1, num2,out sum,out sub);
            //Console.WriteLine($"Sum: {sum}, subtracting: {sub}");
            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");

            #endregion
            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Is {num} prime? {IsPrime(num)}");

            #endregion

            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = { 5, 1, 9, 3, 7, 15, 50 };
            //MinMaxArray(numbers, out int min, out int max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            #endregion
            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");

            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter position to change (0-based): ");
            //int pos = int.Parse(Console.ReadLine());
            //Console.Write("Enter new character: ");
            //char newChar = Console.ReadLine()[0];

            //string result = ChangeChar(str, pos, newChar);
            //Console.WriteLine($"Modified string: {result}");
            #endregion
        }
    }
}
