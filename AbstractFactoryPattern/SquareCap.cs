using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 方形瓶子
    /// </summary>
    public class SquareCap : ICap
    {
        /// <summary>
        /// 展示自己的信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("我是一个方形瓶盖，我的直径是5cm。");
        }
    }
}
