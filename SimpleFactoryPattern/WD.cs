using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 守望者
    /// </summary>
    public class WD : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是守望者，我会暗影突袭、刀阵、闪烁和复仇天神。");
        }
    }
}
