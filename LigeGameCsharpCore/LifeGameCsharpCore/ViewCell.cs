using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGameCsharpCore
{
    public class ViewCell
    {

        public static void Print(List<CellPosition> cells)
        {
            var maxRow = cells.Max(n => n.X);
            var maxColum = cells.Max(n => n.Y);

            for (int x = 0; x <= maxRow; x++)
            {
                for (int y = 0; y <= maxColum; y++)
                {
                    var cell = cells.FirstOrDefault(n => n.X == x && n.Y == y)?.Cell;

                    if(cell != null && cell.IsLife())
                        Console.Write("■");
                    else
                    {
                        Console.Write("□");
                    }
                }

                Console.WriteLine();
            }


        }


    }
}
