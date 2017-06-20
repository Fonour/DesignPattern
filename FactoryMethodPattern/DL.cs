using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 恐惧魔王
    /// </summary>
    public class CL : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是恐惧魔王，我会腐臭群蜂、睡眠、吸血光环、地狱火。");
        }
    }
}
