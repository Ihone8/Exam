using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColorsBLL
    {
        /// <summary>
        /// 获取所有颜色信息集合
        /// </summary>
        /// <returns>颜色信息集合</returns>
        public static List<Model.Colors> GetColorsList()
        {
            return DAL.ColorsDAL.GetColorsList();
        }
        /// <summary>
        /// 修改单个颜色信息
        /// </summary>
        /// <param name="colors">修改之后的颜色信息</param>
        /// <returns>是否修改成功 1 = 成功  0 = 失败</returns>
        public static int UpdateColor(Model.Colors colors)
        {
            return DAL.ColorsDAL.UpdateColor(colors);
        }

        /// <summary>
        /// 删除单个颜色信息
        /// </summary>
        /// <param name="id">颜色ID</param>
        /// <returns>是否删除成功 1 = 成功  0 = 失败</returns>
        public static int RemoveColor(int id)
        {
            return DAL.ColorsDAL.RemoveColor(id);
        }
    }
}
