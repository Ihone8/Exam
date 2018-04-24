using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工订餐 员工实体类
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// 属性:编号
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 属性：工号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 属性：密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 属性：姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Employees() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="No">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="password">密码</param>
        public Employees(int id,string No ,string name,string password)
        {
            this.EmpId = id;
            this.Emp_No = No;
            this.Emp_Name = name;
            this.Password = password;
        }
    }
}
