using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeesBLL
    {
        /// <summary>
        /// 员工订餐登入
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工是否登入成功信息</returns>
        public static int UserLogin(string name, string pwd)
        {
            return DAL.EmployeesDAL.UserLogin(name, pwd);
        }
        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <returns>员工信息集合</returns>
        public static List<Model.Employees> GetEmployeesList()
        {
            return DAL.EmployeesDAL.GetEmployeesList();
        }
    }
}
