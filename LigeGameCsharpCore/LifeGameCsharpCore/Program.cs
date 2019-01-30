using System;

namespace LifeGameCsharpCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World(3,3);
            world.SetCells();


            while (true)
            {
                world.NextGeneration();
                //View(world);
            }

        }
    }
}
