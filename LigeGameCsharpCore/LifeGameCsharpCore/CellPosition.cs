using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LifeGameCsharpCore
{
    public class CellPosition
    {
        public int X { get; private set; }
        public  int Y { get; private set; }

        public Cell Cell { get; private set; }


        public CellPosition(int x, int y,Cell cell=null)
        {
            X = x;
            Y = y;
            Cell = cell;
        }


        public void SetCell(Cell cell)
        {
            Cell = cell;
        }







    }
}
