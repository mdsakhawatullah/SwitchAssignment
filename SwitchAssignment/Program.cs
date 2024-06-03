namespace SwitchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            switch(name)
            {
                case "nine":
                    Console.WriteLine("This is class nine");
                    break;

                case "ten":
                    Console.WriteLine("This is class ten");
                    break;

                case "six":
                    Console.WriteLine("This is class six");
                    break;
                default: 
                    Console.WriteLine("This is not in our range");
                    break;
            }
        }
    }
}
