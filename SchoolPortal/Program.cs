using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Commercial commercial = new Commercial(123,"abayomi",90,89,90);
            Science science = new Science(1,"dami",89,78,45);

            commercial.GetSubjects();
            
            commercial.ToString();
            science.GetSubjects();
            science.ToString();
        }
    }
}
