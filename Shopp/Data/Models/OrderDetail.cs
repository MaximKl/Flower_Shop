using Microsoft.AspNetCore.Mvc;
using System.Web.WebPages.Html;

namespace Shopp.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int flowerID { get; set; }
        public uint price { get; set; }
        public virtual Flower flowers { get; set; }
        public virtual Order order { get; set; }


    }
}
