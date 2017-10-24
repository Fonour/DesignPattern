using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// 月亮女祭司
    /// </summary>
    public class POM : IHero
    {
        /// <summary>
        /// 身体特征
        /// </summary>
        public string Body
        {
            get { return "夜幕只为朱颜改，群星陨落无穷。"; }
            set { }
        }

        /// <summary>
        /// 武器
        /// </summary>
        public string Weapon
        {
            get { return "索利达尔·群星之怒。"; }
            set { }
        }

        /// <summary>
        /// 坐骑
        /// </summary>
        public string Mount
        {
            get { return "艾斯卡达尔。"; }
            set { }
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public IHero Clone()
        {
            IHero hero = new POM();
            //TODO:进行其他Clone相关操作
            return hero;
        }
    }
}
