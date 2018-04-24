using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class EmployeeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            Bind();
        }
        protected void Bind()
        {
            List<Model.Department> list = BLL.DepartmentBLL.GetDepartmentList();
            list.Insert(0, new Model.Department() { ID = -1, Name = "==请选择部门===" });
            DepartmentList.DataSource = list;
            DepartmentList.DataTextField = "Name";
            DepartmentList.DataValueField = "Id";
            DepartmentList.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            int a = 0;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblNameMes.Text = "[姓名]不能为空！";
                return;
            }
            else
            {
                lblNameMes.Text = "";
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                lblAgeMes.Text = "[年龄]不能为空！";
                return;
            }

            else if (int.TryParse(txtAge.Text, out a) == false)
            {
                lblAgeMes.Text = "[年龄]应输入1-150的数字";
                return;
            }
            else
            {
                lblAgeMes.Text = "";
            }

            if (DepartmentList.SelectedValue == "-1")
            {
                lblDepartment.Text = "请选择部门";
            }
            else
            {
                lblDepartment.Text = "";
            }
            //lblName.Text = DepartmentList.SelectedValue.ToString();
            Model.Employee employee = new Model.Employee();
            employee.Name = txtName.Text;
            employee.Age = a;
            employee.DID = int.Parse(DepartmentList.SelectedValue);
            employee.Sex = RdMan.Checked ? "男" : "女";
            if (BLL.EmployeeBLL.AddEmployee(employee) > 0)
            {
                Response.Redirect("EmployeeSearch.aspx");
            }
            else
            {
                Response.Write("<script>alert('发生错误，添加员工失败！')</script>");
            }
        }

    }
}