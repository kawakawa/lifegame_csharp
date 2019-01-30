using System;
using System.Collections.Generic;
using System.Text;

namespace LifeGameCsharpCore
{
    public class CellPosition
    {
        private readonly int _x;
        private readonly int _y;

        private Cell _cell;

        public CellPosition(int x, int y)
        {
            _x = x;
            _y = y;

        }


        public void SetCell(Cell cell)
        {
            _cell = cell;
        }







    }
}
