using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class Book_DinnerDAL
    {
        /// <summary>
        /// 添加员工订餐信息
        /// </summary>
        /// <param name="_Dinner">员工订餐信息类</param>
        /// <returns>是否添加成功</returns>
        public static int AddOrder(Model.Book_Dinner _Dinner)
        {
            string sql = "insert into Book_Dinner values(@No,@Time,@Name)";
            SqlParameter[] parameter =
            {
                new SqlParameter("@No",_Dinner.work_no),
                new SqlParameter("@Time",_Dinner.book_time),
                new SqlParameter("@Name",_Dinner.Emp_Name),
            };

            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text,parameter);
        }
        /// <summary>
        /// 读取员工订餐信息
        /// </summary>
        /// <returns>员工订餐信息实体集</returns>
        public static List<Model.Book_Dinner> GetDinnerList()
        {
            string sql = "select * from Book_Dinner";
            List<Model.Book_Dinner> list = new List<Model.Book_Dinner>();
            SqlDataReader dataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if(dataReader != null)
            {
                while (dataReader.Read())
                {
                    list.Add(new Model.Book_Dinner() { Bd_id = (int)dataReader["Bd_id"], book_time = (DateTime)dataReader["book_time"], Emp_Name = dataReader["Emp_Name"] as string, work_no = dataReader["work_no"] as string });
                }
            }
            SQLHelper.Close();
            return list;
         }
    }
}
