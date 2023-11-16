class Program
{
    static void Main()
    {
        Console.Write("Input number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        inputNumber.FooBarConverter();
    }
}

public static class IniExtension
{
    public static void FooBarConverter(this object x)
    {
        for (int i = 0; i <= (int)x; i++)
        {
            if (i == 0)
            {
                Console.Write(i);
            }
            else if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    Console.Write("foobar");
                }
                else
                {
                    Console.Write("foo");
                }
            }
            else if (i % 5 == 0)
            {
                Console.Write("bar");
            }
            else
            {
                Console.Write(i);
            }
            if (i != (int)x)
            {
                Console.Write(", ");
            } 
        }
    }
}