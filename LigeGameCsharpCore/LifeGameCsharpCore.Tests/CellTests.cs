using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifeGameCsharpCore;

namespace LifeGameCsharpCore.Tests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void 誕生_死んでいるセルに隣接する生きたセルがちょうど3つあれば次の世代が誕生する()
        {
            var target = new Cell(LifeStatus.Dead)
                                .SetLifeCellCountWith(3)
                                .GetNextGenerationCell();
            Assert.IsTrue(target.IsLife());

        }


        [TestMethod]
        public void 生存_生きているセルに隣接する生きたセルが2つならば次の世代でも生存する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(2)
                .GetNextGenerationCell();

            Assert.IsTrue(target.IsLife());
        }

        [TestMethod]
        public void 生存_生きているセルに隣接する生きたセルが3つならば次の世代でも生存する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(3)
                .GetNextGenerationCell();

            Assert.IsTrue(target.IsLife());
        }

        [TestMethod]
        public void 過疎_生きているセルに隣接する生きたセルが1ならば過疎により死滅する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(1)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


        [TestMethod]
        public void 過疎_生きているセルに隣接する生きたセルが0ならば過疎により死滅する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(0)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }



        [TestMethod]
        public void 過密_生きているセルに隣接する生きたセルが4マスなら過密により死滅する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(4)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


        [TestMethod]
        public void 過密_生きているセルに隣接する生きたセルが8マスなら過密により死滅する()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(8)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


    }
}
