using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 隐形药水组装者
    /// </summary>
    public class ProductMaker
    {
        private IBottle _bottle; // 瓶子对象
        private ICap _cap; // 瓶盖对象

        /// <summary>
        /// 创建最终药水对象
        /// </summary>
        /// <param name="bottleColor"></param>
        /// <param name="capShape"></param>
        public void MakeProduct(string bottleColor, string capShape)
        {
            _bottle = BottleFactory.CreateBottle(bottleColor);
            _cap = CapFactory.CreateCap(capShape);
            Console.WriteLine("准备英雄需要的瓶子和瓶盖。");
            _bottle.ShowInfo();
            _cap.ShowInfo();
            Console.WriteLine("开始往瓶子了灌入隐形药水，然后封上瓶盖。");
        }

        /// <summary>
        /// 创建最终药水对象
        /// </summary>
        /// <param name="factory">抽象工厂具体对象</param>
        public void MakeProduct(AbstractFactory factory)
        {
            _bottle = factory.CreateBottle();
            _cap = factory.CreateCap();
            Console.WriteLine("准备英雄需要的瓶子和瓶盖。");
            _bottle.ShowInfo();
            _cap.ShowInfo();
            Console.WriteLine("开始往瓶子了灌入隐形药水，然后封上瓶盖。");
        }
    }
}
