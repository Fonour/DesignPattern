using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 月之女祭司建造者类
    /// </summary>
    public class POMBuilder : IBuilder
    {
        private Hero _hero = new Hero();

        /// <summary>
        /// 创建身体特征
        /// </summary>
        /// <returns></returns>
        public void BuildBody()
        {
            _hero.Body = "夜幕只为朱颜改，群星陨落无穷。";
        }

        /// <summary>
        /// 创建武器
        /// </summary>
        /// <returns></returns>
        public void BuildWeapon()
        {
            _hero.Weapon = "索利达尔·群星之怒。";
        }

        /// <summary>
        /// 创建坐骑
        /// </summary>
        /// <returns></returns>
        public void BuildMount()
        {
            _hero.Mount = "艾斯卡达尔。";
        }

        /// <summary>
        /// 创建最终产品
        /// </summary>
        /// <returns></returns>
        public Hero GetResult()
        {
            return _hero;
        }

    }
}
