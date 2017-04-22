using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 恶魔猎手
    /// </summary>
    public class DH : IHero
    {
        //定义一个静态的DH类变量
        private static DH dh;
        //定义一个静态只读的用于加锁的辅助对象
        private static readonly object lockObject = new object (); 
        /// <summary>
        /// 私有的构造函数，能够保证该类不会在外部被随意实例化，是保证该类只用一个实例的基本前提
        /// </summary>
        private DH()
        {

        }

        /// <summary>
        /// 定义一个静态的公开的GetInstance方法供外部得到DH类唯一实例是调用
        /// </summary>
        /// <returns></returns>
        public static DH GetInstance()
        {
            //先判断dh是否已经被实例化，若未被实例化，先加锁保证线程安全
            if (dh == null)
            {
                lock (lockObject)
                {
                    //先判断dh是否已经被实例化，若未被实例化，先实例化得到DH类的实例
                    //保证DH类只被实例化一次
                    if (dh == null)
                    {
                        dh = new DH();
                    }
                }
            }
            return dh;
        }

        /// <summary>
        /// 秀出自己的技能
        /// </summary>
        public void ShowSkills()
        {
            Console.WriteLine("我是恶魔猎手，我会法力燃烧、献祭、闪避和变身。");
        }
    }

    ///// <summary>
    ///// 饿汉式单例
    ///// </summary>
    //public class DH : IHero
    //{
    //    //系统初始化时已经将DH类进行实例化
    //    private static readonly DH dh = new DH();

    //    /// <summary>
    //    /// 私有的构造函数，能够保证该类不会在外部被随意实例化，是保证该类只用一个实例的基本前提
    //    /// </summary>
    //    private DH()
    //    {

    //    }

    //    /// <summary>
    //    /// 调用时直接返回已经实例化完成的对象
    //    /// </summary>
    //    /// <returns></returns>
    //    public static DH GetInstance()
    //    {
    //        return dh;
    //    }

    //    /// <summary>
    //    /// 秀出自己的技能
    //    /// </summary>
    //    public void ShowSkills()
    //    {
    //        Console.WriteLine("我是恶魔猎手，我会法力燃烧、献祭、闪避和变身。");
    //    }
    //}
}
