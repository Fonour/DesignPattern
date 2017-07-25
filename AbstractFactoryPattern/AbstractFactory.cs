using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 创建瓶子
        /// </summary>
        /// <returns></returns>
        public abstract IBottle CreateBottle();

        /// <summary>
        /// 创建瓶盖
        /// </summary>
        /// <returns></returns>
        public abstract ICap CreateCap();
    }
}
