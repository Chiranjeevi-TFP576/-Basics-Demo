namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    // Console.WriteLine("Hello, World!");
        //    int a = 20;
        //    int b = 10;
        //    int sum = a + b;
        //    Console.WriteLine(""+sum);
        //}
        {
            Student s = new Student("Chiranjeevi",2,111);
            s.Display();
            Student s2 = new Student(s);
            s2.Display();

        }
    }
}