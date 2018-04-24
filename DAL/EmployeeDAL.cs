using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class EmployeeDAL
    {
        /// <summary>
        /// 查询员工信息方法
        /// </summary>
        /// <returns>员工信息数据集</returns>
        public static List<Model.Employee> GetEmployeeList()
        {
            List<Model.Employee> list = new List<Model.Employee>();
            string sql = "select E.*,D.DeName from Employee E inner join Department D on E.DID = D.Id";
            SqlDataReader dataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if(dataReader != null)
            {
                while (dataReader.Read())
                {
                    list.Add(new Model.Employee() { ID = (int)dataReader["ID"], Age = (int)dataReader["Age"], Name = dataReader["Name"] as string, Sex = dataReader["Sex"] as string, DepartmentName = dataReader["DeName"] as string, DID = (int)dataReader["DID"] });
                }
            }
            SQLHelper.Close();
            return list;
        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="employee">员工实体类</param>
        /// <returns>是否添加成功数据信息</returns>
        public static int AddEmployee(Model.Employee employee)
        {
            string sql = "insert into Employee values(@Name,@Age,@Sex,@Did)";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@Name",employee.Name),
                new SqlParameter("@Age",employee.Age),
                new SqlParameter("@Sex",employee.Sex),
                new SqlParameter("@Did",employee.DID),
            };
            return SQLHelper.ExecuteNonQurery(sql,CommandType.Text,sqlParameter);
        }
    }
}
