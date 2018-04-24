using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentBLL
    {
        /// <summary>
        /// 查询部门信息
        /// </summary>
        /// <returns>部门信息数据集</returns>
        public static List<Model.Department> GetDepartmentList()
        {
            return DAL.DepartmentDAL.GetDepartmentList();
        }
       }
}
