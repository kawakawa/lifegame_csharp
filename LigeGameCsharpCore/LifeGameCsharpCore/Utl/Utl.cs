using System;
using System.Collections.Generic;
using System.Text;

namespace LifeGameCsharpCore.Utl
{
    public static class Utl
    {

        public static LifeStatus GetRandomLifeStatus()
        {
            var bs = new byte[4];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(bs);
            }
            
            //Int32に変換する
            int i = System.BitConverter.ToInt32(bs, 0);


            if (i % 2 == 0)
                return LifeStatus.Dead;

            return LifeStatus.Life;
        }


        public static Cell GeneratorCellByRandom()
        {
            return new Cell(GetRandomLifeStatus());
        }




    }
}
