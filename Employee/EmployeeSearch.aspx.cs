using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class EmployeeSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Bind()
        {
            Employees.DataSource = BLL.EmployeeBLL.GetEmployeeList();
            Employees.DataBind();
        }
        protected void Employees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Employees.PageIndex = e.NewPageIndex;
            Bind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeAdd.aspx");
        }
    }
}