using System;

namespace Prototype
{
    /// <summary>
    /// 英雄接口定义
    /// </summary>
    public interface IHero
    {
        /// <summary>
        /// 身体特征
        /// </summary>
        string Body { get; set; }

        /// <summary>
        /// 武器
        /// </summary>
        string Weapon { get; set; }

        /// <summary>
        /// 坐骑
        /// </summary>
        string Mount { get; set; }

        /// <summary>
        /// Clone本身接口定义
        /// </summary>
        /// <returns></returns>
        IHero Clone();
    }
}
