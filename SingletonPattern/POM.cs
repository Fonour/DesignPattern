using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 月亮女祭司
    /// </summary>
    public class POM : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是月亮女祭司，我会召唤猫头鹰，灼热之箭，强击光环和流星雨。");
        }
    }
}
