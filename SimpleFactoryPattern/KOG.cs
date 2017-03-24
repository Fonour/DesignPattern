using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 丛林守护者
    /// </summary>
    public class KOG : IHero
    {
        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是丛林守护者，我会缠绕根须、荆棘光环、自然之力和宁静。");
        }
    }
}
