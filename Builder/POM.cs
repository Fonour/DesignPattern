using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 月之女祭司创建类
    /// </summary>
    public class POM
    {
        /// <summary>
        /// 创建英雄
        /// </summary>
        /// <returns></returns>
        public string BuilderHero()
        {
            string body = "夜幕只为朱颜改，群星陨落无穷。"; // 创建身体
            string weapon = "索利达尔·群星之怒。"; // 创建武器
            string mount = "艾斯卡达尔。"; // 创建坐骑
            return body + weapon + mount;
        }
    }
}
