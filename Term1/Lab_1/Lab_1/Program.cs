using System;

class Program
{
    static void Main()
    {
        int sizeOfInt = sizeof(int);
        int sizeOfShort = sizeof(short);
        int sizeOfLong = sizeof(long);
        int sizeOfChar = sizeof(char);
        int sizeOfFloat = sizeof(float);
        int sizeOfDouble = sizeof(double);

        Console.WriteLine($"int: {sizeOfInt} bytes, short: {sizeOfShort} bytes, long: {sizeOfLong} bytes, char: {sizeOfChar} bytes, float: {sizeOfFloat} bytes, double: {sizeOfDouble} bytes");
    }
}
