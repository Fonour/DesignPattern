using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 瓶子创建工厂方法
    /// </summary>
    public class BottleFactory
    {
        /// <summary>
        /// 创建瓶子对象
        /// </summary>
        /// <param name="color">瓶子颜色</param>
        /// <returns></returns>
        public static IBottle CreateBottle(string color)
        {
            if (color == "red")
                return new RedBottle();
            if (color == "blue")
                return new BlueBottle();
            return null;
        }
    }
}
