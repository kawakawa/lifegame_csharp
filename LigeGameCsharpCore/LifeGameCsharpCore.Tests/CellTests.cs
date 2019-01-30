using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifeGameCsharpCore;

namespace LifeGameCsharpCore.Tests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void �a��_����ł���Z���ɗאڂ��鐶�����Z�������傤��3����Ύ��̐��オ�a������()
        {
            var target = new Cell(LifeStatus.Dead)
                                .SetLifeCellCountWith(3)
                                .GetNextGenerationCell();
            Assert.IsTrue(target.IsLife());

        }


        [TestMethod]
        public void ����_�����Ă���Z���ɗאڂ��鐶�����Z����2�Ȃ�Ύ��̐���ł���������()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(2)
                .GetNextGenerationCell();

            Assert.IsTrue(target.IsLife());
        }

        [TestMethod]
        public void ����_�����Ă���Z���ɗאڂ��鐶�����Z����3�Ȃ�Ύ��̐���ł���������()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(3)
                .GetNextGenerationCell();

            Assert.IsTrue(target.IsLife());
        }

        [TestMethod]
        public void �ߑa_�����Ă���Z���ɗאڂ��鐶�����Z����1�Ȃ�Ήߑa�ɂ�莀�ł���()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(1)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


        [TestMethod]
        public void �ߑa_�����Ă���Z���ɗאڂ��鐶�����Z����0�Ȃ�Ήߑa�ɂ�莀�ł���()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(0)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }



        [TestMethod]
        public void �ߖ�_�����Ă���Z���ɗאڂ��鐶�����Z����4�}�X�Ȃ�ߖ��ɂ�莀�ł���()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(4)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


        [TestMethod]
        public void �ߖ�_�����Ă���Z���ɗאڂ��鐶�����Z����8�}�X�Ȃ�ߖ��ɂ�莀�ł���()
        {
            var target = new Cell(LifeStatus.Life)
                .SetLifeCellCountWith(8)
                .GetNextGenerationCell();

            Assert.IsFalse(target.IsLife());
        }


    }
}
