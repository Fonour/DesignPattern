using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class Factory
    {

        /// <summary>
        /// 创建英雄的静态方法
        /// </summary>
        /// <param name="heroName">英雄名称</param>
        /// <returns></returns>
        public static IHero CreateHero(string heroName)
        {
            switch (heroName)
            {
                case "DH":
                    return new DH();
                case "WD":
                    return new WD();
                case "KOG":
                    return new KOG();
                case "POM":
                    return new POM();
                default:
                    return null;
            }
        }
    }
}
