using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        /// <summary>
        /// 查询员工信息方法
        /// </summary>
        /// <returns>员工信息数据集</returns>
        public static List<Model.Employee> GetEmployeeList()
        {
            return DAL.EmployeeDAL.GetEmployeeList();
        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="employee">员工实体类</param>
        /// <returns>是否添加成功数据信息</returns>
        public static int AddEmployee(Model.Employee employee)
        {
            return DAL.EmployeeDAL.AddEmployee(employee);
        }
    }
}
