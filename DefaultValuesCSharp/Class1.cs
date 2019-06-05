using System;

    public class Class1
    {
        static String location;  
        static DateTime time;
        static int integer;
        static sbyte sbyteVariable;
        static byte byteVariable;
        static long longVariable;
        static short shortVariable;
        static char charVariable;
        static bool boolVariable;


    public static void Main()
        {    
        Console.WriteLine(location == null ? "location is null" : location);
        Console.WriteLine(time == null ? "time is null" : time.ToString());


        Console.WriteLine("sbyteVariable :: " + sbyteVariable);

        Console.WriteLine("byteVariable :: " + byteVariable);
        Console.WriteLine("integer :: " + integer);
        Console.WriteLine("shortVariable :: " + shortVariable);
        Console.WriteLine("longVariable :: " + longVariable);

        Console.WriteLine("charVariable :: '" + charVariable + "'");
        Console.WriteLine("boolVariable :: " + boolVariable);

        }

      

    }

