using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            DH dh = new DH();
            var dh1 = WandOfIllusion.Use(dh); // 对dh使用幻象权杖
            Console.ReadLine();
        }
    }
}
