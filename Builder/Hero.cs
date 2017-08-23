using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 英雄类
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// 身体特征
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 武器
        /// </summary>
        public string Weapon { get; set; }

        /// <summary>
        /// 坐骑
        /// </summary>
        public string Mount { get; set; }
    }
}
