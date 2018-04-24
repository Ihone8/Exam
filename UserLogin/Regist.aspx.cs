using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLogin
{
    public partial class Regist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegist_Click(object sender, EventArgs e)
        {
            Model.Login user = new Model.Login();
            user.UserName = txtName.Text;
            user.PassWord = txtPassword.Text;
            user.Sex = dropSex.SelectedItem.Text;
            user.Birthday = DateTime.Parse(txtDate.Text);
            if (BLL.LoginBLL.UserResgist(user) > 0)
            {
                lblMes.Text = "注册成功！是否立即登入<a href='Login.aspx'>点击登入</a>";
            }
        }



        protected void txtName_TextChanged1(object sender, EventArgs e)
        {
            if (BLL.LoginBLL.SelectUserName(txtName.Text) > 0)
            {
                lblMes.Text = "用户名已存在，请重新输入用户名";
            }
            else
            {
                lblMes.Text = "";
            }
        }
    }
}