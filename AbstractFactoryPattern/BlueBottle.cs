using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 蓝色瓶子
    /// </summary>
    public class BlueBottle : IBottle
    {
        /// <summary>
        /// 展示自己的信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("我是一个平静自信的蓝色瓶子，我的瓶口直径是5cm。");
        }
    }
}
