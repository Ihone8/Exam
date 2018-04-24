using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class NewsInfoDAL
    {
        /// <summary>
        /// 获取所有新闻信息
        /// </summary>
        /// <returns>新闻信息集合</returns>
        public static List<Model.newsInfo> GetNewsList()
        {
            string sql = "select T.nType ,I.* from newsType T  inner join newsInfo I on T.nId = I.[type_Id]";
            List<Model.newsInfo> list = new List<Model.newsInfo>();
            SqlDataReader reader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if(reader != null)
            {
                while (reader.Read())
                {
                    list.Add(new Model.newsInfo() { addTime = (DateTime)reader["addTime"], content = reader["content"] as string, newsId = (int)reader["newsId"], nType = reader["nType"] as string, title = reader["title"] as string, type_Id = (int)reader["type_Id"] });
                }
            }
            SQLHelper.Close();
            return list;
        }
        /// <summary>
        /// 删除单个新闻信息
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns>新闻是否删除成功 1 = 成功 0 = 失败</returns>
        public static int RemoveNews(int id)
        {
            string sql = "delete newsInfo where newsId = @ID";
            SqlParameter[] parameter =
            {
                new SqlParameter("@ID",id)
            };
            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text, parameter);
        }
    }
}
