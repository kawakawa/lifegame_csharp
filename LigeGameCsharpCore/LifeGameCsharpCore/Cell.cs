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


        public void SetLifeCellCount(int lifeCellCount)
        {
            SetLifeCellCountWith(lifeCellCount);
        }


        public Cell SetLifeCellCountWith(int lifeCellCount)
        {
            _lifeCellCount = lifeCellCount;
            return this;
        }

        public Cell GetNextGenerationCell()
        {

            if (_lifeCellCount == 3
                ||
                (IsLife() && _lifeCellCount==2))
                return new Cell(LifeStatus.Life);

            return new Cell(LifeStatus.Dead);
        }

        public bool IsLife()
        {
            return _lifeStatus == LifeStatus.Life;
        }
    }
}
