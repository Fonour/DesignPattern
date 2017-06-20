using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 巫妖
    /// </summary>
    public class Lich : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是巫妖，我会霜冻新星、寒冰甲、黑暗仪式和死亡凋零。");
        }
    }
}
