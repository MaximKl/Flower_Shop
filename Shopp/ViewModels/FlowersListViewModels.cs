using Shopp.Data.Models;
using System.Collections.Generic;

namespace Shopp.ViewModels
{
    public class FlowersListViewModels
    {
        //поле, що збергіає всі товари
        public IEnumerable<Flower> allFlowers { get; set; }
        //зберігає поточну категорію
        public string currCategory { get; set; }

    }
}
