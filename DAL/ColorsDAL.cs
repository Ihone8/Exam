using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class ColorsDAL
    {
        /// <summary>
        /// 获取所有颜色信息集合
        /// </summary>
        /// <returns>颜色信息集合</returns>
        public static List<Model.Colors> GetColorsList()
        {
            string sql = " select  * from Colors";
            List<Model.Colors> list = new List<Model.Colors>();
            SqlDataReader reader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if (reader != null)
            {
                while (reader.Read())
                {
                    list.Add(new Model.Colors() { ColorId = (int)reader["ColorId"], ColorCode = reader["ColorCode"] as string, Name = reader["Name"] as string, Matching = reader["Matching"] as string });
                }
            }
            SQLHelper.Close();
            return list;
        }
        /// <summary>
        /// 修改单个颜色信息
        /// </summary>
        /// <param name="colors">修改之后的颜色信息</param>
        /// <returns>是否修改成功 1 = 成功  0 = 失败</returns>
        public static int UpdateColor(Model.Colors colors)
        {
            string sql = "update Colors set ColorCode = @code, Name = @name , Matching =@match where ColorId = @id ";
            SqlParameter[] parameter =
            {
                new SqlParameter("@code",colors.ColorCode),
                new SqlParameter("@name",colors.Name),
                new SqlParameter("@match",colors.Matching),
                new SqlParameter("@id",colors.ColorId),
            };
            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text,parameter);
        }
        /// <summary>
        /// 删除单个颜色信息
        /// </summary>
        /// <param name="id">颜色ID</param>
        /// <returns>是否删除成功 1 = 成功  0 = 失败</returns>
        public static int RemoveColor(int id)
        {
            string sql = "delete Colors where ColorId = @id";
            SqlParameter[] parameter =
            {
                new SqlParameter("@id",id)
            };
            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text, parameter);
        }
    }
}
