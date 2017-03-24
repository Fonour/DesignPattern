using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 英雄类
    /// </summary>
    public class Hero
    {
        private readonly string _name; // 英雄名称

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">英雄名称</param>
        public Hero(string name)
        {
            _name = name;
        }

        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            switch (_name)
            {
                case "DH":
                    Console.WriteLine("我是恶魔猎手，我会法力燃烧、献祭、闪避和变身。");
                    break;
                case "WD":
                    Console.WriteLine("我是守望者，我会暗影突袭、刀阵、闪烁和复仇天神。");
                    break;
                case "KOG":
                    Console.WriteLine("我是丛林守护者，我会缠绕根须、荆棘光环、自然之力和宁静。");
                    break;
                case "POM":
                    Console.WriteLine("我是月亮女祭司，我会召唤猫头鹰，灼热之箭，强击光环和流星雨。");
                    break;
                default:
                    break;
            }
        }
    }
}
