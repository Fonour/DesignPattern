using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// 幻象权杖
    /// </summary>
    public class WandOfIllusion
    {
        public static IHero Use(IHero hero)
        {
            IHero result = null;
            //if (hero is DH)
            //{
            //    result = new DH();
            //}
            //else if (hero is POM)
            //{
            //    result = new POM();
            //}
            result = hero.Clone();
            return result;
        }
    }
}
