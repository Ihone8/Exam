using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DepartmentDAL
    {
        /// <summary>
        /// 查询部门信息
        /// </summary>
        /// <returns>部门信息数据集</returns>
        public static List<Model.Department> GetDepartmentList()
        {
            string sql = "select * from Department";
            List<Model.Department> list = new List<Model.Department>();
            SqlDataReader dataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if(dataReader != null)
            {
                while (dataReader.Read())
                {
                    list.Add(new Model.Department() { ID = (int)dataReader["ID"], Name = dataReader["DeName"] as string });
                }
            }
            SQLHelper.Close();
            return list;

        }
    }
}
