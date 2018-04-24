using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.Login user = new Model.Login();
            user.UserName = txtName.Text;
            user.PassWord = txtPassword.Text;
            if(BLL.LoginBLL.UserLogin(user) > 0)
            {
                Response.Redirect("Login_Ok.aspx");
            }
            else
            {
                lblMes.Text = "登入失败，请重新填写用户名和密码";
            }
        }
    }
}