// See https://aka.ms/new-console-template for more information

//https://projecteuler.net/archives
//Multiples_3_5_Below_1000();
//Even_Fibonacci_Numbers();
//Largest_Prime_Factor_Of_The_Number_600851475143();
//Largest_Palindrome_Product_3_Digit_Numbers();
//Smallest_Multiple();
Sum_Square_Difference();

#region Methods

static void Multiples_3_5_Below_1000()
{
    int result = 0;

    for (int i = 0; i < 1000; i++)
    {
        result += (i % 3 == 0 || i % 5 == 0) ? i : 0;
    }

    Console.WriteLine(result);
}

static void Even_Fibonacci_Numbers()
{
    int x = 0, y = 1, z = 0, result = 0;

    while (x < 4000000)
    {
        z = y;
        y = x + y;
        x = z;

        if (x % 2 == 0)
            result += x;
    }

    Console.WriteLine(result);
}

static void Largest_Prime_Factor_Of_The_Number_600851475143()
{
    long number = 600851475143;
    int count = 2; //first primo number

    while (number > 1)
    {
        if (number % count == 0)
        {
            number /= count;
            Console.WriteLine(count);
        }

        count++;
    }
}

static void Largest_Palindrome_Product_3_Digit_Numbers()
{
    var polidromes = new List<int>();

    for (int i = 100; i < 999; i++)
    {
        for (int j = 100; j < 999; j++)
        {
            int number = i * j;

            int reverse = int.Parse(number.ToString().Reverse().Aggregate(string.Empty, (s, c) => s + c));

            if (number == reverse)
            {
                Console.WriteLine($"{i} - {j}");

                polidromes.Add(number);
            }
        }
    }

    Console.WriteLine(polidromes.OrderDescending().FirstOrDefault());
}

static void Smallest_Multiple()
{
    int count = 1;

    while (count > 0)
    {
        bool isDivisible1To20 = true;

        for (int i = 1; i <= 20; i++)
        {
            if (count % i != 0)
            {
                isDivisible1To20 = false;
                break;
            }
        }

        if (isDivisible1To20)
        {
            Console.WriteLine(count);
            break;
        }

        count++;
    }
}

static void Sum_Square_Difference()
{
    double sumSquare = 0;
    double squareSum = 0;

    for (int i = 1; i <= 100; i++)
    {
       sumSquare+= Math.Pow((double)i, 2);
       squareSum+=i;
    }

    Console.WriteLine(Math.Pow(squareSum, 2) - sumSquare);
}

#endregion