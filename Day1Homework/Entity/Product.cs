using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework.Entity
{
    public class Product
    {
        /// <summary>
        /// 商品代碼
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 原價
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// 收益
        /// </summary>
        public int Revenue { get; set; }
        /// <summary>
        /// 售價
        /// </summary>
        public int SellPrice { get; set; }

    }
}
