using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LifeGameCsharpCore
{
    public class World
    {
        private readonly int _row;
        private readonly int _column;

        private List<CellPosition> _cells;

        public World(int row, int column)
        {
            if(row<=0)
                throw new ArgumentOutOfRangeException(nameof(row));

            if(column<=0)
                throw new ArgumentOutOfRangeException(nameof(column));

            _row = row;
            _column = column;

        }



        public void SetCells()
        {
            _cells = new List<CellPosition>();

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    var cellPosition = new CellPosition(i, j);
                    cellPosition.SetCell(Utl.Utl.GeneratorCellByRandom());
                    _cells.Add(cellPosition);
                }
            }
            
        }





    }
}
