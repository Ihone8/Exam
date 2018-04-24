using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewsInfoBLL
    {
        /// <summary>
        /// 获取所有新闻信息
        /// </summary>
        /// <returns>新闻信息集合</returns>
        public static List<Model.newsInfo> GetNewsList()
        {
            return DAL.NewsInfoDAL.GetNewsList();
        }
        /// <summary>
        /// 删除单个新闻信息
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns>新闻是否删除成功 1 = 成功 0 = 失败</returns>
        public static int RemoveNews(int id)
        {
            return DAL.NewsInfoDAL.RemoveNews(id);
        }
    }
}
