using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        /// <summary>
        /// 验证用户登入方法
        /// </summary>
        /// <param name="user">用户输入信息</param>
        /// <returns>用户是否登入成功信息 1 = 成功 0 = 失败</returns>
        public static int UserLogin(Model.Login user)
        {
            return DAL.LoginDAL.UserLogin(user);
        }
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="user">用户输入信息</param>
        /// <returns>是否注册成功 1 = 成功 0 = 失败</returns>
        public static int UserResgist(Model.Login user)
        {
            return DAL.LoginDAL.UserResgist(user);
        }
        /// <summary>
        /// 查询用户是否存在方法
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns>用户名是否存在 1=存在 0 = 不存在</returns>
        public static int SelectUserName(string name)
        {
            return DAL.LoginDAL.SelectUserName(name);
        }
    }
}
