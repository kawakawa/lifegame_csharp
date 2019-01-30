using System;
using System.Collections.Generic;
using System.Text;

namespace LifeGameCsharpCore
{
    public class Cell
    {

        private readonly LifeStatus _lifeStatus;
        private int _lifeCellCount;

        public Cell(LifeStatus lifeStatus)
        {
            _lifeStatus = lifeStatus;
        }


        public Cell SetLifeCellCountWith(int lifeCellCount)
        {
            _lifeCellCount = lifeCellCount;
            return this;
        }

        public Cell GetNextGenerationCell()
        {
            if(IsLife() && _lifeCellCount<=1)
                return new Cell(LifeStatus.Dead);

            if(IsLife()&& _lifeCellCount>=4)
                return new Cell(LifeStatus.Dead);


            return new Cell(LifeStatus.Life);
        }

        public bool IsLife()
        {
            return _lifeStatus == LifeStatus.Life;
        }
    }
}
