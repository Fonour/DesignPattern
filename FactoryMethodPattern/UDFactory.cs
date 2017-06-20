using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 不死族英雄工厂类
    /// </summary>
    public class UDFactory : IFactory
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

                // 不死族
                case "DK":
                    return new DK();
                case "Lich":
                    return new Lich();
                case "CL":
                    return new CL();
                case "DL":
                    return new DL();
                default:
                    return null;
            }
        }
    }
}
