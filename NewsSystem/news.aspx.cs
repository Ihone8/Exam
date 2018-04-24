using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class news : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsDataBind();
        }
        protected void NewsDataBind()
        {
            NewsView.DataSource = BLL.NewsInfoBLL.GetNewsList();
            NewsView.DataBind();
        }
        protected void NewsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void NewsView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse( NewsView.DataKeys[e.RowIndex].Values[0].ToString());
             if(BLL.NewsInfoBLL.RemoveNews(id) > 0)
            {
                Response.Write("<script>alert('删除成功！')</script>");
                NewsDataBind();
            }
        }
    }
}