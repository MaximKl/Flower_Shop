using System.Collections.Generic;

namespace Shopp.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Flower> flowers { set; get; }


    }
}
