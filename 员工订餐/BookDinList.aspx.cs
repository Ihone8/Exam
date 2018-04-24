using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 员工订餐
{
    public partial class BookDinList1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        protected void Bind()
        {
            string No = Session["User"].ToString();
            Dinner.DataSource = BLL.Book_DinnerBLL.GetDinnerList().Where(E=>E.work_no == No).ToList();
            Dinner.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Parse(txtDate.Text).ToString("yyyy-MM");
            Dinner.DataSource = BLL.Book_DinnerBLL.GetDinnerList().Where(E => E.book_time.ToString("yyyy-MM").ToString() == datetime).ToList();
            Dinner.DataBind();
        }
    }
}