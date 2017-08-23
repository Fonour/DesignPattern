using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 建造者接口
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// 创建身体特征
        /// </summary>
        /// <returns></returns>
        void BuildBody();

        /// <summary>
        /// 创建武器
        /// </summary>
        /// <returns></returns>
        void BuildWeapon();

        /// <summary>
        /// 创建坐骑
        /// </summary>
        /// <returns></returns>
        void BuildMount();

        /// <summary>
        /// 获取最终产品
        /// </summary>
        /// <returns></returns>
        Hero GetResult();
    }
}
