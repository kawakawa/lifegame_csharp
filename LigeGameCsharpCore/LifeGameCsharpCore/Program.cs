using System;

namespace LifeGameCsharpCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World(30,30);
            world.SetCells();


            while (true)
            {
                world.NextGeneration();
                ViewCell.Print(world.Cells);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();

            }

        }
    }
}
