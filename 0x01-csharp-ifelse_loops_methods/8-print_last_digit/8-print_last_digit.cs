using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number = number * -1;
        while (number > 9)
        {
            number = number % 10;
        }
        Console.Write(number);
        return number;
    }
}
