using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工实体类
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 员工年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Employee() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="sex">性别</param>
        /// <param name="did">部门编号</param>
        public Employee(int id,string name,int age,string sex, int did,string departmentName)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.DID = did;
            this.DepartmentName = departmentName;
        }
    }
}
