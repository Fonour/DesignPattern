using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 地穴领主
    /// </summary>
    public class DL : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是地穴领主，我会穿刺、刺盾、腐蚀甲虫和蝗群。");
        }
    }
}
