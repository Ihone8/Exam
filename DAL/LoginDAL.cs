using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class LoginDAL
    {
        /// <summary>
        /// 验证用户登入方法
        /// </summary>
        /// <param name="user">用户输入信息</param>
        /// <returns>用户是否登入成功信息 1 = 成功 0 = 失败</returns>
        public static int UserLogin(Model.Login user)
        {
            string sql = "select count(*) from Login where UserName = @name and [PassWord] =@pwd";
            SqlParameter[] parameter =
            {
                new SqlParameter("@name",user.UserName),
                new SqlParameter("@pwd",user.PassWord),
            };
            return SQLHelper.ExecuteScalar(sql, CommandType.Text,parameter);
        }
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="user">用户输入信息</param>
        /// <returns>是否注册成功 1 = 成功 0 = 失败</returns>
        public static int UserResgist(Model.Login user)
        {
            string sql = "insert into Login values(@Name,@Pwd,@sex,@date)";
            SqlParameter[] parameter =
             {
                new SqlParameter("@Name",user.UserName),
                new SqlParameter("@Pwd",user.PassWord),
                new SqlParameter("@date",user.Birthday),
                new SqlParameter("@sex",user.Sex),
            };
            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text, parameter);
        }
        /// <summary>
        /// 查询用户是否存在方法
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns>用户名是否存在 1=存在 0 = 不存在</returns>
        public static int SelectUserName(string name)
        {
            string sql = "select count(*) from login where  UserName =@name";
            SqlParameter[] parameter =
            {
                new SqlParameter("@name",name)
            };
            return SQLHelper.ExecuteScalar(sql, CommandType.Text,parameter);
        }
    }
}
