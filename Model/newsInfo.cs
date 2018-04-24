using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class newsInfo
    {
        /// <summary>
        /// 属性：编号
        /// </summary>
        public int newsId { get; set; }
        /// <summary>
        /// 属性：标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 属性：时间
        /// </summary>
        public DateTime addTime { get; set; }
        /// <summary>
        /// 属性：正文
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 属性：类型编号
        /// </summary>
        public int type_Id { get; set; }
        /// <summary>
        /// 属性：类型名称
        /// </summary>
        public string nType { get; set; }
    }
}
