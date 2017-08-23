using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指导者
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 指导方法
        /// </summary>
        public void Construct(IBuilder builder)
        {
            builder.BuildBody(); // 创建身体特征
            builder.BuildWeapon(); // 创建武器
            builder.BuildMount(); // 创建坐骑
        }
    }
}
