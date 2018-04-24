using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColorSystem
{
    public partial class ColorManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ColorDataBind();
            }
        }
        //绑定数据方法
        protected void ColorDataBind()
        {
            List<Model.Colors> list = BLL.ColorsBLL.GetColorsList();
            ColorViews.DataSource = list;
            ColorViews.DataBind();
        }
        //点击编辑
        protected void ColorViews_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ColorViews.EditIndex = e.NewEditIndex;
            ColorDataBind();
        }
        //点击删除
        protected void ColorViews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse( ColorViews.DataKeys[e.RowIndex].Values[0].ToString());
            if (BLL.ColorsBLL.RemoveColor(id) > 0)
            {
                ColorViews.EditIndex = -1;
                ColorDataBind();
            }
        }
        //点击取消
        protected void ColorViews_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            ColorViews.EditIndex = -1;
            ColorDataBind();
        }
        //点击更新
        protected void ColorViews_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Model.Colors color = new Model.Colors();
            color.ColorId = int.Parse(ColorViews.DataKeys[e.RowIndex].Values[0].ToString());
            color.ColorCode = ((TextBox)ColorViews.Rows[e.RowIndex].FindControl("TextColorCode")).Text;
            color.Name = ((TextBox)ColorViews.Rows[e.RowIndex].FindControl("TextName")).Text;
            color.Matching = ((TextBox)ColorViews.Rows[e.RowIndex].FindControl("TextMatch")).Text;
            if(BLL.ColorsBLL.UpdateColor(color) > 0)
            {
                ColorViews.EditIndex = -1;
                ColorDataBind();
            }
        }
    }
}