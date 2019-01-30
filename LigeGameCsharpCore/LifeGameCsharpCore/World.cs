using System;
using System.Collections.Generic;
using System.Linq;
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

            for (int x = 0; x < _row; x++)
            {
                for (int y = 0; y < _column; y++)
                {
                    var cellPosition = new CellPosition(x, y);
                    cellPosition.SetCell(Utl.Utl.GeneratorCellByRandom());
                    _cells.Add(cellPosition);
                }
            }
            
        }


        public void NextGeneration()
        {
           var newCells = new List<CellPosition>();

            for (int x = 0; x < _row; x++)
           {
               for (int y = 0; y < _column; y++)
               {
                   //対象cellの周りの生存Cellをカウント
                   var lifeCellCount = GetLifeCellCount(x, y);

                   //対象cellに生存cell数を登録
                   _cells.FirstOrDefault(n => n.X == x && n.Y == y)?.Cell.SetLifeCellCount(lifeCellCount);

                    //新Cellを登録
                    var newCell = _cells.FirstOrDefault(n => n.X == x && n.Y == y)?.Cell.GetNextGenerationCell();
                    newCells.Add(new CellPosition(x,y,newCell));
                }
           }




            //cellを世代交代
            _cells = newCells;

        }

        private int GetLifeCellCount(int x, int y)
        {
            var lifeCellCount = 0;

            //左上
            if (_cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y - 1)?.Cell?.IsLife()==true)
                    lifeCellCount++;

            //上
            if (_cells.FirstOrDefault(n => n.X == x  && n.Y == y - 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右上
            if (_cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y - 1)?.Cell?.IsLife() == true)
                lifeCellCount++;


            //左
            if (_cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右
            if (_cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y)?.Cell?.IsLife() == true)
                lifeCellCount++;




            //左下
            if (_cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //下
            if (_cells.FirstOrDefault(n => n.X == x && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右下
            if (_cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            

            return lifeCellCount;

        }
    }
}
