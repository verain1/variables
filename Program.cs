using System;

namespace variables
{
    class Hcl
    {
        int a;
        string b;

        readonly int c;
        readonly string d;

        const int e = 101;
        const string f = "Verain";

        static int g;
        static string h;

        static readonly int i;
        static readonly string j;

        static void Main()
        {
            System.Console.WriteLine("Various types of variables: ");
            
            System.Console.WriteLine("Instance variables");
            // Hcl obj = new Hcl(5, "Hello");
            Hcl obj = new Hcl();
            System.Console.WriteLine($"{ obj.a }, { obj.b }");

            System.Console.WriteLine("\nInstance Read only variables: ");
            Hcl obj1 = new Hcl(5, "Hello");
            System.Console.WriteLine($"{ obj1.c }, { obj1.d }");

            System.Console.WriteLine("\nConstant variable: ");
            System.Console.WriteLine($"{ Hcl.e }, { Hcl.f }");

            System.Console.WriteLine($"\nStatic Variable: ");
            System.Console.WriteLine($"{ Hcl.g }, { Hcl.h }");

            System.Console.WriteLine("\nStatic read only variables: ");
            System.Console.WriteLine($"{ Hcl.i }, { Hcl.j }");
        }

        static Hcl()
        {
            Hcl.g = 101;
            Hcl.h = "Verain";

            Hcl.i = 101;
            Hcl.j = "Verain";
        }
        public Hcl()
        {
            this.a = 123;
            this.b = "Hello";
        }

        public Hcl(int first, string second)
        {
            c = first;
            d = second;
        }
    }
}
