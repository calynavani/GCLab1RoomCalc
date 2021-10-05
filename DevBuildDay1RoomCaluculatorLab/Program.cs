using System;

namespace DevBuildDay1RoomCaluculatorLab
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!\n");

            double paint, carpet, length, width, height, area, perimeter, volume;
            string again = "y";

            do
            {

                Console.Write("Enter the length: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                width = double.Parse(Console.ReadLine());

                Console.Write("Enter the height: ");
                height = double.Parse(Console.ReadLine());

                area = width * length;

                Console.WriteLine($"Area: {area}");


                perimeter = 2 * (length + width);

                Console.WriteLine($"Perimeter: {perimeter}");

                volume = length * height * width;
                Console.WriteLine($"Volume: { volume}");

                double paintWalls = (area + 2 * length * height + 2 * width * height) / 25;
                Console.WriteLine($"Number of paint cans needed for walls: {paintWalls}");

                carpet = area / 5;
                Console.WriteLine($"Carpet Tiles: {carpet}");

                paint = perimeter / 5;

                Console.WriteLine($"Paint: {paint}\n");



                Console.Write("Continue? (y/n)\n");
                again = Console.ReadLine().ToLower();
            } while (again == "y");










          } 
    }
}
