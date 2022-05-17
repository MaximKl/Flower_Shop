using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System.Collections.Generic;

namespace Shopp.Data.Mocks
{
    public class MockCategory : IFlowerCategory
    {

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                     new Category {categoryName = "Домашні рослини", desc =
                    "Гарні рослини для прикраси вашої домівки"},

                     new Category {categoryName = "Садові рослини",
                    desc = "Квіти для створення неперевершеного букету"},
                     };
            }
        }

    }
}
