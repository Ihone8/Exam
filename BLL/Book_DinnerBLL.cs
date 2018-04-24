using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Book_DinnerBLL
    {
        /// <summary>
        /// 添加员工订餐信息
        /// </summary>
        /// <param name="_Dinner">员工订餐信息类</param>
        /// <returns>是否添加成功</returns>
        public static int AddOrder(Model.Book_Dinner _Dinner)
        {
            return DAL.Book_DinnerDAL.AddOrder(_Dinner);
        }
        /// <summary>
        /// 读取员工订餐信息
        /// </summary>
        /// <returns>员工订餐信息实体集</returns>
        public static List<Model.Book_Dinner> GetDinnerList()
        {
            return DAL.Book_DinnerDAL.GetDinnerList();
        }

        }
}
