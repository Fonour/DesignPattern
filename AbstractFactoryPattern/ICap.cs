using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 定义瓶盖接口
    /// </summary>
    public interface ICap
    {
        /// <summary>
        /// 展示自己的信息
        /// </summary>
        void ShowInfo();
    }
}
