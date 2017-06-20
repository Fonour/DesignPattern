using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new NEFactory();  // 初始化一个暗夜精灵族的英雄工厂
            Console.WriteLine("我在开局时选择了暗夜精灵族，我的首发英雄是DH。");
            IHero dh = factory.CreateHero("DH");
            dh.ShowSkills();

            factory = new UDFactory();  // 初始化一个不死族的英雄工厂
            Console.WriteLine("我在开局时选择了不死族，我的首发英雄是DK。");
            IHero dk = factory.CreateHero("DK");
            dk.ShowSkills();

            Console.ReadLine();

            //string factoryName = ConfigurationManager.AppSettings["FactoryName"]; // 读取配置文件
            //factory = (IFactory)Assembly.Load("FactoryMethodPattern").CreateInstance("FactoryMethodPattern." + factoryName); // 实例化配置的工厂方法类

        }
    }
}
