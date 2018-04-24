using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 员工订餐
{
    public partial class BookDinList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Show();
        }
        protected void Show()
        {
            if(Session["User"] != null) { 

              string No = Session["User"].ToString();
              Model.Employees employees = BLL.EmployeesBLL.GetEmployeesList().Where(E => E.Emp_No == No).First();
              lblName.Text = employees.Emp_Name;
              lblNo.Text = employees.Emp_No;
            }
            txtStartTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if(DateTime.TryParse(txtEndTime.Text, out dateTime) == true)
            {
                Model.Book_Dinner book_Dinner = new Model.Book_Dinner();
                string No = Session["User"].ToString();
                Model.Employees employees = BLL.EmployeesBLL.GetEmployeesList().Where(E => E.Emp_No == No).First();
                book_Dinner.work_no = No;
                book_Dinner.Emp_Name = employees.Emp_Name;
                book_Dinner.book_time = dateTime;
                if(BLL.Book_DinnerBLL.AddOrder(book_Dinner) > 0)
                {
                    Response.Redirect("BookDinList.aspx");
                }
                else
                {
                    Response.Write("<script>alert('预定出现错误！，请重试')</script>");
                }
            }
        }
    }
}