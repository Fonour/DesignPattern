using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 瓶盖创建工厂方法
    /// </summary>
    public class CapFactory
    {
        /// <summary>
        /// 创建瓶子对象
        /// </summary>
        /// <param name="shape">瓶盖形状</param>
        /// <returns></returns>
        public static ICap CreateCap(string shape)
        {
            if (shape == "round")
                return new RoundCap();
            if (shape == "square")
                return new SquareCap();
            return null;
        }
    }
}
