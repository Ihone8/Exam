using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Login
    {
        /// <summary>
        /// 属性：姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 属性：密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 属性：性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 属性：生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Login() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pwd">密码</param>
        /// <param name="sex">性别</param>
        /// <param name="time">生日</param>
        public Login(string name,string pwd,string sex, DateTime time)
        {
            this.UserName = name;
            this.PassWord = pwd;
            this.Sex = sex;
            this.Birthday = time;
        }
    }
}
