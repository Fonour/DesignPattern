using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 蓝瓶子方盖子工厂类
    /// </summary>
    public class BlueBottleAndSquareCapFactory : AbstractFactory
    {
        /// <summary>
        /// 创建瓶子
        /// </summary>
        /// <returns></returns>
        public override IBottle CreateBottle()
        {
            return BottleFactory.CreateBottle("blue");
        }

        /// <summary>
        /// 创建瓶盖
        /// </summary>
        /// <returns></returns>
        public override ICap CreateCap()
        {
            return CapFactory.CreateCap("square");
        }
    }
}
