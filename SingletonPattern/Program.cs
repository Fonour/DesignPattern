using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHero dh1 = Factory.CreateHero("DH");
            IHero dh2 = Factory.CreateHero("DH");
            if (dh1.Equals(dh2))
                Console.WriteLine("恶魔猎手：我还是从前的我。");
            else
                Console.WriteLine("恶魔猎手：我已不是从前的我。");

            IHero wd1 = Factory.CreateHero("WD");
            IHero wd2 = Factory.CreateHero("WD");
            if (wd1.Equals(wd2))
                Console.WriteLine("守望者：我还是从前的我。");
            else
                Console.WriteLine("守望者：我已不是从前的我。");

            Console.ReadLine();
        }
    }
}
