using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 死亡骑士
    /// </summary>
    public class DK : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是死亡骑士，我会死亡缠绕、死亡契约、邪恶光环和操纵死尸。");
        }
    }
}
