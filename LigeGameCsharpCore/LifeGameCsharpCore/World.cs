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

        public List<CellPosition> Cells { get; private set; }

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
            Cells = new List<CellPosition>();

            for (int x = 0; x < _row; x++)
            {
                for (int y = 0; y < _column; y++)
                {
                    var cellPosition = new CellPosition(x, y);
                    cellPosition.SetCell(Utl.Utl.GeneratorCellByRandom());
                    Cells.Add(cellPosition);
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
                   Cells.FirstOrDefault(n => n.X == x && n.Y == y)?.Cell.SetLifeCellCount(lifeCellCount);

                    //新Cellを登録
                    var newCell = Cells.FirstOrDefault(n => n.X == x && n.Y == y)?.Cell.GetNextGenerationCell();
                    newCells.Add(new CellPosition(x,y,newCell));
                }
           }




            //cellを世代交代
            Cells = newCells;

        }

        private int GetLifeCellCount(int x, int y)
        {
            var lifeCellCount = 0;

            //左上
            if (Cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y - 1)?.Cell?.IsLife()==true)
                    lifeCellCount++;

            //上
            if (Cells.FirstOrDefault(n => n.X == x  && n.Y == y - 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右上
            if (Cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y - 1)?.Cell?.IsLife() == true)
                lifeCellCount++;


            //左
            if (Cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右
            if (Cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y)?.Cell?.IsLife() == true)
                lifeCellCount++;




            //左下
            if (Cells.FirstOrDefault(n => n.X == x - 1 && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //下
            if (Cells.FirstOrDefault(n => n.X == x && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            //右下
            if (Cells.FirstOrDefault(n => n.X == x + 1 && n.Y == y + 1)?.Cell?.IsLife() == true)
                lifeCellCount++;

            

            return lifeCellCount;

        }
    }
}
