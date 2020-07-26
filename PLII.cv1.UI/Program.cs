using System;

namespace PLII.cv1.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("First name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            user.LastName = Console.ReadLine();
            Console.WriteLine(user.Greeting());
        }
    }
}
