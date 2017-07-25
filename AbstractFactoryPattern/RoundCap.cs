using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 圆形瓶盖
    /// </summary>
    public class RoundCap : ICap
    {
        /// <summary>
        /// 展示自己的信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("我是一个圆形瓶盖，我的直径是2cm。");
        }
    }
}
