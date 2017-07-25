using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductMaker pm = new ProductMaker();
            //pm.MakeProduct("red", "round"); // 提供给英雄红瓶子圆盖子的隐形药水
            //Console.WriteLine();
            //pm.MakeProduct("blue", "square"); // 提供给英雄蓝瓶子方盖子的隐形药水
            //Console.ReadLine();

            ProductMaker pm = new ProductMaker();
            AbstractFactory factory = new RedBottleAndRoundCapFactory(); // 提供给英雄红瓶子圆盖子的隐形药水
            pm.MakeProduct(factory);
            Console.WriteLine();
            factory = new BlueBottleAndSquareCapFactory(); // 提供给英雄蓝瓶子方盖子的隐形药水
            pm.MakeProduct(factory);
            Console.ReadLine();
        }
    }
}
