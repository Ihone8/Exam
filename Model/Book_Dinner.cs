using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订餐实体类
    /// </summary>
    public class Book_Dinner
    {
        /// <summary>
        /// 属性：编号
        /// </summary>
        public int Bd_id { get; set; }
        /// <summary>
        /// 属性：外键 工号
        /// </summary>
        public string work_no { get; set; }
        /// <summary>
        /// 属性：订餐时间
        /// </summary>
        public DateTime book_time { get; set; }
        /// <summary>
        /// 属性：姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Book_Dinner() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="no">工号</param>
        /// <param name="time">订餐时间</param>
        /// <param name="name">姓名</param>
        public Book_Dinner(int id,string no ,DateTime time,string name)
        {
            this.Bd_id = id;
            this.work_no = no;
            this.book_time = time;
            this.Emp_Name = name;
        }
    }
}
