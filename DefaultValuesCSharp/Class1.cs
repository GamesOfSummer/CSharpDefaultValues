using System;

    public class Class1
    {
        static String stringVariable;  
        static DateTime time;

        static int integer;
        static sbyte sbyteVariable;
        static byte byteVariable;
        static long longVariable;
        static short shortVariable;
        static char charVariable;
        static bool boolVariable;


    public class Person
    {
        public string name { get; set; }
    }

    public static void Mutate(Person person)
    {
        person.name = "Mutated";
    }


    public static void Main()
        {    
        Console.WriteLine(stringVariable == null ? "stringVariable is null" : stringVariable);
        Console.WriteLine(time == null ? "time is null" : time.ToString());

        Console.WriteLine("sbyteVariable :: " + sbyteVariable);
        Console.WriteLine("byteVariable :: " + byteVariable);
        Console.WriteLine("integer :: " + integer);
        Console.WriteLine("shortVariable :: " + shortVariable);
        Console.WriteLine("longVariable :: " + longVariable);
        Console.WriteLine("charVariable :: '" + charVariable + "'");
        Console.WriteLine("boolVariable :: " + boolVariable);



        var person = new Person() { name = "Default"};
        Console.WriteLine(person.name);
        Mutate(person);
        Console.WriteLine(person.name);

    }



}

