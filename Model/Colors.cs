using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Colors
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        /// 属性：颜色编码
        /// </summary>
        public string ColorCode { get; set; }
        /// <summary>
        /// 属性：颜色名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 属性：配色
        /// </summary>
        public string Matching { get; set; }
        public Colors() { }
        public Colors(int id ,string code,string name,string matching)
        {
            this.ColorId = id;
            this.ColorCode = code;
            this.Name = name;
            this.Matching = matching;
        }
    }
}
