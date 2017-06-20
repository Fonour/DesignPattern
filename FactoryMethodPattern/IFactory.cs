using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂方法接口
    /// </summary>
    public interface IFactory
    {

        /// <summary>
        /// 创建英雄的方法
        /// </summary>
        /// <param name="heroName">英雄名称</param>
        /// <returns></returns>
        IHero CreateHero(string heroName);
    }
}
