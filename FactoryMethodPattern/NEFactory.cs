using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 暗夜精灵种族英雄工厂类
    /// </summary>
    public class NEFactory : IFactory
    {

        /// <summary>
        /// 创建英雄的静态方法
        /// </summary>
        /// <param name="heroName">英雄名称</param>
        /// <returns></returns>
        public IHero CreateHero(string heroName)
        {
            switch (heroName)
            {
                //暗夜精灵
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
