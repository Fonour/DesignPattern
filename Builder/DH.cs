using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 恶魔猎手创建类
    /// </summary>
    public class DH
    {
        /// <summary>
        /// 创建英雄
        /// </summary>
        /// <returns></returns>
        public string BuilderHero()
        {
            string body = "黑夜给了我黑色眼睛，我却用它去寻找光明。"; // 创建身体
            string weapon = "艾辛诺斯双刃。"; // 创建武器
            string mount = "我有这双脚有这双腿。"; // 创建坐骑
            return body + weapon + mount;
        }
    }
}
