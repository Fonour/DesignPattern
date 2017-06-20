using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 恶魔猎手
    /// </summary>
    public class DH : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是恶魔猎手，我会法力燃烧、献祭、闪避和变身。");
        }
    }
}
