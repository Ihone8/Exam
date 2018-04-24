using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class EmployeesDAL
    {
        /// <summary>
        /// 员工订餐登入
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工是否登入成功信息</returns>
        public static int UserLogin(string name,string pwd)
        {
            string sql = "select count(*) from Employee where Emp_No = @No and Password =@Pwd ";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@No",name),
                new SqlParameter("@Pwd", pwd),
            };
            return SQLHelper.ExecuteScalar(sql, CommandType.Text, sqlParameter);
        }
        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <returns>员工信息集合</returns>
        public static List<Model.Employees> GetEmployeesList()
        {
            string sql = "select * from Employee";
            List<Model.Employees> list = new List<Model.Employees>();
            SqlDataReader dataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    list.Add(new Model.Employees() { EmpId = (int)dataReader["EmpId"], Emp_Name = dataReader["Emp_Name"] as string, Emp_No = dataReader["Emp_No"] as string, Password = dataReader["Password"] as string });
                }
            }
            SQLHelper.Close();
            return list;
        }
    }
}
