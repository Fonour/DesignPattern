using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// 恶魔猎手
    /// </summary>
    public class DH : IHero
    {

        /// <summary>
        /// 身体特征
        /// </summary>
        public string Body
        {
            get { return "黑夜给了我黑色眼睛，我却用它去寻找光明。"; }
            set { }
        }

        /// <summary>
        /// 武器
        /// </summary>
        public string Weapon
        {
            get { return "艾辛诺斯双刃。"; }
            set { }
        }

        /// <summary>
        /// 坐骑
        /// </summary>
        public string Mount
        {
            get { return "我有这双脚有这双腿。"; }
            set { }
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public IHero Clone()
        {
            IHero hero = new DH();
            //TODO:进行其他Clone相关操作
            return hero;
        }
    }
}
