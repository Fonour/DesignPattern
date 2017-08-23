using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 恶魔猎手建造者实现类
    /// </summary>
    public class DHBuilder : IBuilder
    {
        private Hero _hero = new Hero();

        /// <summary>
        /// 创建身体特征
        /// </summary>
        /// <returns></returns>
        public void BuildBody()
        {
            _hero.Body = "黑夜给了我黑色眼睛，我却用它去寻找光明。";
        }

        /// <summary>
        /// 创建武器
        /// </summary>
        /// <returns></returns>
        public void BuildWeapon()
        {
            _hero.Weapon= "艾辛诺斯双刃。";
        }

        /// <summary>
        /// 创建坐骑
        /// </summary>
        /// <returns></returns>
        public void BuildMount()
        {
            _hero.Mount= "我有这双脚有这双腿。";
        }

        public Hero GetResult()
        {
            return _hero;
        }
    }
}
