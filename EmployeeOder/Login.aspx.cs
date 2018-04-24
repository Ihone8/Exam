using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 员工订餐
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text;
            string Password = txtPassword.Text;
            Model.Employees employees = new Model.Employees();
            employees.Emp_No = UserName;
            employees.Password = Password;
            if(BLL.EmployeesBLL.UserLogin(UserName,Password) > 0)
            {
                Session["User"] = UserName; //登入成功 保存到Session
                Response.Redirect("BookDinOrder.aspx");
              
            }
            else
            {
                lblMes.Text = "账号或密码错误！";
            }
            
        }
    }
}