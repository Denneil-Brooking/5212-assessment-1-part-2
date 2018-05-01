using System;

namespace part_2
{
    //first section(class) start
    class Car
    //first section end
    {
        //second section(attri) start
        public string colour { get; set; }
        public string make { get; set; }
        public string gearbox { get; set; }
        //second section(attri) end
        //thrid section(opera) start
        public string DescribeCar()
        {
            return "This car is a " + colour + " " + make + " with a " + gearbox;

        }
        //thrid section(opera) end
    }
    //first section(class) end
    //main section
    class Program
    {
        static void Main(string[] args)
        {
            //ClearConsole
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This Program takes user input on the asked fields and returns it");
            Console.WriteLine("------------------------------------------");

            //Input function
            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            Car car = new Car();

            Console.Write("Colour: ");
            car.colour = Console.ReadLine();

            Console.Write("Make: ");
            car.make = Console.ReadLine();

            Console.Write("Gearbox: ");
            car.gearbox = Console.ReadLine();

            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            //Return function

            Console.WriteLine(car.DescribeCar());

            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            //program end
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <any key> to quit the program");
            Console.ReadKey();
        }
    }
}
